using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace BikeSim
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            foreach (var item in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(item);
            }
            cbPort.Text = cbPort.Items[0].ToString();

            cbBaudRate.Items.Add("110");
            cbBaudRate.Items.Add("300");
            cbBaudRate.Items.Add("600");
            cbBaudRate.Items.Add("1200");
            cbBaudRate.Items.Add("2400");
            cbBaudRate.Items.Add("4800");
            cbBaudRate.Items.Add("9600");
            cbBaudRate.Items.Add("14400");
            cbBaudRate.Items.Add("19200");
            cbBaudRate.Items.Add("28800");
            cbBaudRate.Items.Add("38400");
            cbBaudRate.Items.Add("56000");
            cbBaudRate.Items.Add("57600");
            cbBaudRate.Items.Add("115200");
            cbBaudRate.Text = cbBaudRate.Items[10].ToString();

            InitializeTrackBars();
        }
        SerialPort serialPort;
        Boolean GotoClose = false;

        delegate void InvokeLB(string Data);

        InvokeLB lbRecievedDelegate;
        private byte[] buffer;
        private object stringComparer;

        private void bCreateSP_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbPort.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.NewLine = "\r";
                serialPort.Open(); //Serialport öffnen
                lbRecievedDelegate = new InvokeLB(InvokeLBRecieved);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived); //DataRecieved Event abonnieren
                this.bCreateSP.Text = "Close";
                this.lbl_connected.Text = "Connected";
                this.progressBarConnected.Value = 100;
                groupBoxSimulation.Show();
                goto ende_create;
            }
            if (serialPort.IsOpen)
            {
                GotoClose = true;
                serialPort.Close();
                serialPort.Dispose();
                this.lbl_connected.Text = "Closed";
                this.bCreateSP.Text = "Open";
                this.progressBarConnected.Value = 0;
                groupBoxSimulation.Hide();
            }
            ende_create:
            cbPort.Show();
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                this.Invoke(new EventHandler(DoUpdate));
            }
            catch { }

        }

        void DoUpdate(object s, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            string RecievedLine;
            RecievedLine = serialPort.ReadLine();
            //if (stringComparer.Equals("s\r", RecievedLine)){}
            //lbl_Herzfrequenz.Text = RecievedLine.Substring(0, 1);
            //richTextBox1.Text = "abc" + RecievedLine.Substring(0, 1);
            lbSent.Invoke(lbRecievedDelegate, new object[] { RecievedLine });
            if (RecievedLine == "k")RecievedLine="kxx";
            switch (RecievedLine.Substring(0,1))
            {
                case "A":
                    if (lbl_status_show.Text == "Standby") trackBarLast.Value = Convert.ToInt32(RecievedLine.Substring(1,3));
                break;
                case "s":
                    lbl_status_show.Text = "Run";
                    trackBarHerzfrequenz.Value = 60;
                    trackBarDrehzahl.Value = 60;
                    lbl_belastungstyp_show.Text = "Block";
                    break;
                case "S":
                    lbl_status_show.Text = "Run";
                    trackBarDiastole.Value = 80;
                    trackBarSystole.Value = 100;
                    trackBarHerzfrequenz.Value = 60;
                    trackBarDrehzahl.Value = 60;
                    lbl_belastungstyp_show.Text = "Block";
                    break;
                case "I":
                    SerialWrite("SIMUP03V100\r");
                break;
                case "W":
                    if (lbl_status_show.Text == "Run")
                    {
                        trackBarLast.Value = Convert.ToInt32(RecievedLine.Substring(1, 3));
                        lbl_belastungstyp_show.Text = "Block";
                    }
                    break;
                case "L":
                    if (lbl_status_show.Text == "Run")
                    {
                        trackBarLast.Value = Convert.ToInt32(RecievedLine.Substring(1, 3));
                        lbl_belastungstyp_show.Text = "Linear";
                    }
                    break;
                case "B":
                    if (lbl_status_show.Text == "Run") SerialWrite("B"+trackBarLast.Value+"\r");
                    break;
                case "D":
                    if (lbl_status_show.Text == "Run") SerialWrite("D"+trackBarDrehzahl.Value + "\r");
                    break;
                case "H":
                    if (lbl_status_show.Text == "Run") SerialWrite("H"+trackBarHerzfrequenz.Value + "\r");
                    break;
                case "O":
                    if (lbl_status_show.Text == "Run") SerialWrite("O"+trackBarSystole.Value + "\r");
                    break;
                case "U":
                    if (lbl_status_show.Text == "Run") SerialWrite("U"+trackBarDiastole.Value + "\r");
                    break;
                case "k":
                    int ActualSattel = Convert.ToInt16(trackBarSattel.Value);
                    string WriteActualSattel;
                    if (ActualSattel < 10) WriteActualSattel = "0" + ActualSattel.ToString(); else WriteActualSattel = ActualSattel.ToString();
                    if (RecievedLine.Substring(1, 2)=="xx")
                    {
                        SerialWrite("k" + WriteActualSattel + WriteActualSattel + "\r");
                    }
                    else
                    {
                        SerialWrite("k" + WriteActualSattel + RecievedLine.Substring(1, 2) + "\r");
                        trackBarSattel.Value = Convert.ToInt32(RecievedLine.Substring(1, 2));
                    }
                    break;
                case "F":
                    InitializeTrackBars();
                    lbl_status_show.Text = "Standby";
                    lbl_belastungstyp_show.Text = "Standby";
                    break;
                case "P":
                    if (lbl_status_show.Text == "Run") SerialWrite("P205\r");
                    break;

            }
            //richTextBox1.Text = RecievedLine;
            
        }
        void InvokeLBRecieved(string Data)
        {
            lbSent.Items.Add(Data);
        }
        private void SerialWrite(String Data)
        {
            serialPort.Write(Data);
            lbSent.Items.Add(Data);
            lbSent.Items.Add(" ");
        }
        

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lbSent.Items.Clear();
        }

        private void InitializeTrackBars()
        {
            trackBarLast.Value = 0;
            trackBarLast.TickFrequency = 20;
            trackBarLast.ValueChanged += new System.EventHandler(trackBarLast_ValueChanged);
            trackBarDrehzahl.Value = 0;
            trackBarDrehzahl.TickFrequency = 10;
            trackBarDrehzahl.ValueChanged += new System.EventHandler(trackBarDrehzahl_ValueChanged);
            trackBarSattel.Value = 0;
            trackBarSattel.TickFrequency = 1;
            trackBarSattel.ValueChanged += new System.EventHandler(trackBarSattel_ValueChanged);
            trackBarHerzfrequenz.Value = 0;
            trackBarHerzfrequenz.TickFrequency = 10;
            trackBarHerzfrequenz.ValueChanged += new System.EventHandler(trackBarHerzfrequenz_ValueChanged);
            trackBarDiastole.Value = 0;
            trackBarDiastole.TickFrequency = 10;
            trackBarDiastole.ValueChanged += new System.EventHandler(trackBarDiastole_ValueChanged);
            trackBarSystole.Value = 0;
            trackBarSystole.TickFrequency = 10;
            trackBarSystole.ValueChanged += new System.EventHandler(trackBarSystole_ValueChanged);

        }
        private void trackBarLast_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxLast.Text = (System.Math.Round(trackBarLast.Value / 1.0)).ToString();
        }
        private void trackBarDrehzahl_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxDrehzahl.Text = (System.Math.Round(trackBarDrehzahl.Value / 1.0)).ToString();
        }
        private void trackBarSattel_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxSattel.Text = (System.Math.Round(trackBarSattel.Value / 1.0)).ToString();
        }
        private void trackBarHerzfrequenz_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxHerzfrequenz.Text = (System.Math.Round(trackBarHerzfrequenz.Value / 1.0)).ToString();
        }
        private void trackBarDiastole_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxDiastole.Text = (System.Math.Round(trackBarDiastole.Value / 1.0)).ToString();
        }
        private void trackBarSystole_ValueChanged(object sender, System.EventArgs e)
        {
            textBoxSystole.Text = (System.Math.Round(trackBarSystole.Value / 1.0)).ToString();
        }

    }
}
