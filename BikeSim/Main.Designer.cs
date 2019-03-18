namespace BikeSim
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.lbl_connected = new System.Windows.Forms.Label();
            this.progressBarConnected = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCreateSP = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbSent = new System.Windows.Forms.ListBox();
            this.groupBoxProtokoll = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.lbl_belastungstyp_show = new System.Windows.Forms.Label();
            this.lbl_belastungstyp = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxSystole = new System.Windows.Forms.TextBox();
            this.trackBarSystole = new System.Windows.Forms.TrackBar();
            this.lbl_systole = new System.Windows.Forms.Label();
            this.textBoxDiastole = new System.Windows.Forms.TextBox();
            this.trackBarDiastole = new System.Windows.Forms.TrackBar();
            this.lbl_diastole = new System.Windows.Forms.Label();
            this.textBoxHerzfrequenz = new System.Windows.Forms.TextBox();
            this.trackBarHerzfrequenz = new System.Windows.Forms.TrackBar();
            this.lbl_Herzfrequenz = new System.Windows.Forms.Label();
            this.textBoxSattel = new System.Windows.Forms.TextBox();
            this.textBoxDrehzahl = new System.Windows.Forms.TextBox();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.trackBarSattel = new System.Windows.Forms.TrackBar();
            this.trackBarDrehzahl = new System.Windows.Forms.TrackBar();
            this.trackBarLast = new System.Windows.Forms.TrackBar();
            this.lbl_status_show = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_Sattel = new System.Windows.Forms.Label();
            this.lbl_drehzahl = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbConfig.SuspendLayout();
            this.groupBoxProtokoll.SuspendLayout();
            this.groupBoxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSystole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiastole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHerzfrequenz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSattel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrehzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLast)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.lbl_connected);
            this.gbConfig.Controls.Add(this.progressBarConnected);
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.bCreateSP);
            this.gbConfig.Controls.Add(this.cbBaudRate);
            this.gbConfig.Controls.Add(this.cbPort);
            this.gbConfig.Location = new System.Drawing.Point(12, 40);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Size = new System.Drawing.Size(416, 185);
            this.gbConfig.TabIndex = 1;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Serialport Config";
            // 
            // lbl_connected
            // 
            this.lbl_connected.AutoSize = true;
            this.lbl_connected.Location = new System.Drawing.Point(126, 152);
            this.lbl_connected.Name = "lbl_connected";
            this.lbl_connected.Size = new System.Drawing.Size(55, 20);
            this.lbl_connected.TabIndex = 7;
            this.lbl_connected.Text = "closed";
            // 
            // progressBarConnected
            // 
            this.progressBarConnected.Location = new System.Drawing.Point(13, 110);
            this.progressBarConnected.Name = "progressBarConnected";
            this.progressBarConnected.Size = new System.Drawing.Size(273, 35);
            this.progressBarConnected.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // bCreateSP
            // 
            this.bCreateSP.Location = new System.Drawing.Point(293, 110);
            this.bCreateSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCreateSP.Name = "bCreateSP";
            this.bCreateSP.Size = new System.Drawing.Size(112, 35);
            this.bCreateSP.TabIndex = 4;
            this.bCreateSP.Text = "Open";
            this.bCreateSP.UseVisualStyleBackColor = true;
            this.bCreateSP.Click += new System.EventHandler(this.bCreateSP_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(189, 72);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(216, 28);
            this.cbBaudRate.TabIndex = 2;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(189, 31);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(216, 28);
            this.cbPort.TabIndex = 1;
            // 
            // lbSent
            // 
            this.lbSent.FormattingEnabled = true;
            this.lbSent.ItemHeight = 20;
            this.lbSent.Location = new System.Drawing.Point(7, 47);
            this.lbSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSent.Name = "lbSent";
            this.lbSent.Size = new System.Drawing.Size(399, 624);
            this.lbSent.TabIndex = 2;
            // 
            // groupBoxProtokoll
            // 
            this.groupBoxProtokoll.Controls.Add(this.bt_clear);
            this.groupBoxProtokoll.Controls.Add(this.lbSent);
            this.groupBoxProtokoll.Location = new System.Drawing.Point(12, 233);
            this.groupBoxProtokoll.Name = "groupBoxProtokoll";
            this.groupBoxProtokoll.Size = new System.Drawing.Size(417, 687);
            this.groupBoxProtokoll.TabIndex = 3;
            this.groupBoxProtokoll.TabStop = false;
            this.groupBoxProtokoll.Text = "Protokoll";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(316, 13);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(90, 36);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.lbl_belastungstyp_show);
            this.groupBoxSimulation.Controls.Add(this.lbl_belastungstyp);
            this.groupBoxSimulation.Controls.Add(this.richTextBox1);
            this.groupBoxSimulation.Controls.Add(this.textBoxSystole);
            this.groupBoxSimulation.Controls.Add(this.trackBarSystole);
            this.groupBoxSimulation.Controls.Add(this.lbl_systole);
            this.groupBoxSimulation.Controls.Add(this.textBoxDiastole);
            this.groupBoxSimulation.Controls.Add(this.trackBarDiastole);
            this.groupBoxSimulation.Controls.Add(this.lbl_diastole);
            this.groupBoxSimulation.Controls.Add(this.textBoxHerzfrequenz);
            this.groupBoxSimulation.Controls.Add(this.trackBarHerzfrequenz);
            this.groupBoxSimulation.Controls.Add(this.lbl_Herzfrequenz);
            this.groupBoxSimulation.Controls.Add(this.textBoxSattel);
            this.groupBoxSimulation.Controls.Add(this.textBoxDrehzahl);
            this.groupBoxSimulation.Controls.Add(this.textBoxLast);
            this.groupBoxSimulation.Controls.Add(this.trackBarSattel);
            this.groupBoxSimulation.Controls.Add(this.trackBarDrehzahl);
            this.groupBoxSimulation.Controls.Add(this.trackBarLast);
            this.groupBoxSimulation.Controls.Add(this.lbl_status_show);
            this.groupBoxSimulation.Controls.Add(this.lbl_status);
            this.groupBoxSimulation.Controls.Add(this.lbl_Sattel);
            this.groupBoxSimulation.Controls.Add(this.lbl_drehzahl);
            this.groupBoxSimulation.Controls.Add(this.lbl_last);
            this.groupBoxSimulation.Location = new System.Drawing.Point(435, 40);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(1375, 877);
            this.groupBoxSimulation.TabIndex = 4;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "Simulation";
            this.groupBoxSimulation.Visible = false;
            // 
            // lbl_belastungstyp_show
            // 
            this.lbl_belastungstyp_show.AutoSize = true;
            this.lbl_belastungstyp_show.Location = new System.Drawing.Point(207, 72);
            this.lbl_belastungstyp_show.Name = "lbl_belastungstyp_show";
            this.lbl_belastungstyp_show.Size = new System.Drawing.Size(68, 20);
            this.lbl_belastungstyp_show.TabIndex = 45;
            this.lbl_belastungstyp_show.Text = "Standby";
            // 
            // lbl_belastungstyp
            // 
            this.lbl_belastungstyp.AutoSize = true;
            this.lbl_belastungstyp.Location = new System.Drawing.Point(70, 72);
            this.lbl_belastungstyp.Name = "lbl_belastungstyp";
            this.lbl_belastungstyp.Size = new System.Drawing.Size(110, 20);
            this.lbl_belastungstyp.TabIndex = 44;
            this.lbl_belastungstyp.Text = "Belastungstyp";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(135, 723);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1103, 98);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // textBoxSystole
            // 
            this.textBoxSystole.Location = new System.Drawing.Point(222, 553);
            this.textBoxSystole.Name = "textBoxSystole";
            this.textBoxSystole.Size = new System.Drawing.Size(116, 26);
            this.textBoxSystole.TabIndex = 42;
            // 
            // trackBarSystole
            // 
            this.trackBarSystole.Location = new System.Drawing.Point(426, 553);
            this.trackBarSystole.Maximum = 200;
            this.trackBarSystole.Name = "trackBarSystole";
            this.trackBarSystole.Size = new System.Drawing.Size(755, 69);
            this.trackBarSystole.TabIndex = 41;
            // 
            // lbl_systole
            // 
            this.lbl_systole.AutoSize = true;
            this.lbl_systole.Location = new System.Drawing.Point(119, 553);
            this.lbl_systole.Name = "lbl_systole";
            this.lbl_systole.Size = new System.Drawing.Size(61, 20);
            this.lbl_systole.TabIndex = 40;
            this.lbl_systole.Text = "Systole";
            // 
            // textBoxDiastole
            // 
            this.textBoxDiastole.Location = new System.Drawing.Point(222, 478);
            this.textBoxDiastole.Name = "textBoxDiastole";
            this.textBoxDiastole.Size = new System.Drawing.Size(116, 26);
            this.textBoxDiastole.TabIndex = 39;
            // 
            // trackBarDiastole
            // 
            this.trackBarDiastole.Location = new System.Drawing.Point(426, 478);
            this.trackBarDiastole.Maximum = 120;
            this.trackBarDiastole.Name = "trackBarDiastole";
            this.trackBarDiastole.Size = new System.Drawing.Size(755, 69);
            this.trackBarDiastole.TabIndex = 38;
            // 
            // lbl_diastole
            // 
            this.lbl_diastole.AutoSize = true;
            this.lbl_diastole.Location = new System.Drawing.Point(113, 478);
            this.lbl_diastole.Name = "lbl_diastole";
            this.lbl_diastole.Size = new System.Drawing.Size(67, 20);
            this.lbl_diastole.TabIndex = 37;
            this.lbl_diastole.Text = "Diastole";
            // 
            // textBoxHerzfrequenz
            // 
            this.textBoxHerzfrequenz.Location = new System.Drawing.Point(222, 403);
            this.textBoxHerzfrequenz.Name = "textBoxHerzfrequenz";
            this.textBoxHerzfrequenz.Size = new System.Drawing.Size(116, 26);
            this.textBoxHerzfrequenz.TabIndex = 36;
            // 
            // trackBarHerzfrequenz
            // 
            this.trackBarHerzfrequenz.Location = new System.Drawing.Point(426, 403);
            this.trackBarHerzfrequenz.Maximum = 200;
            this.trackBarHerzfrequenz.Name = "trackBarHerzfrequenz";
            this.trackBarHerzfrequenz.Size = new System.Drawing.Size(755, 69);
            this.trackBarHerzfrequenz.TabIndex = 35;
            // 
            // lbl_Herzfrequenz
            // 
            this.lbl_Herzfrequenz.AutoSize = true;
            this.lbl_Herzfrequenz.Location = new System.Drawing.Point(74, 403);
            this.lbl_Herzfrequenz.Name = "lbl_Herzfrequenz";
            this.lbl_Herzfrequenz.Size = new System.Drawing.Size(106, 20);
            this.lbl_Herzfrequenz.TabIndex = 34;
            this.lbl_Herzfrequenz.Text = "Herzfrequenz";
            // 
            // textBoxSattel
            // 
            this.textBoxSattel.Location = new System.Drawing.Point(222, 328);
            this.textBoxSattel.Name = "textBoxSattel";
            this.textBoxSattel.Size = new System.Drawing.Size(116, 26);
            this.textBoxSattel.TabIndex = 33;
            // 
            // textBoxDrehzahl
            // 
            this.textBoxDrehzahl.Location = new System.Drawing.Point(222, 253);
            this.textBoxDrehzahl.Name = "textBoxDrehzahl";
            this.textBoxDrehzahl.Size = new System.Drawing.Size(116, 26);
            this.textBoxDrehzahl.TabIndex = 32;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(222, 177);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(116, 26);
            this.textBoxLast.TabIndex = 31;
            // 
            // trackBarSattel
            // 
            this.trackBarSattel.Location = new System.Drawing.Point(426, 328);
            this.trackBarSattel.Maximum = 30;
            this.trackBarSattel.Name = "trackBarSattel";
            this.trackBarSattel.Size = new System.Drawing.Size(755, 69);
            this.trackBarSattel.TabIndex = 30;
            // 
            // trackBarDrehzahl
            // 
            this.trackBarDrehzahl.Location = new System.Drawing.Point(426, 253);
            this.trackBarDrehzahl.Maximum = 150;
            this.trackBarDrehzahl.Name = "trackBarDrehzahl";
            this.trackBarDrehzahl.Size = new System.Drawing.Size(755, 69);
            this.trackBarDrehzahl.TabIndex = 12;
            this.trackBarDrehzahl.Value = 20;
            // 
            // trackBarLast
            // 
            this.trackBarLast.Location = new System.Drawing.Point(426, 178);
            this.trackBarLast.Maximum = 550;
            this.trackBarLast.Name = "trackBarLast";
            this.trackBarLast.Size = new System.Drawing.Size(755, 69);
            this.trackBarLast.TabIndex = 11;
            this.trackBarLast.Value = 20;
            // 
            // lbl_status_show
            // 
            this.lbl_status_show.AutoSize = true;
            this.lbl_status_show.Location = new System.Drawing.Point(207, 34);
            this.lbl_status_show.Name = "lbl_status_show";
            this.lbl_status_show.Size = new System.Drawing.Size(68, 20);
            this.lbl_status_show.TabIndex = 4;
            this.lbl_status_show.Text = "Standby";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(124, 34);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(56, 20);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "Status";
            // 
            // lbl_Sattel
            // 
            this.lbl_Sattel.AutoSize = true;
            this.lbl_Sattel.Location = new System.Drawing.Point(129, 328);
            this.lbl_Sattel.Name = "lbl_Sattel";
            this.lbl_Sattel.Size = new System.Drawing.Size(51, 20);
            this.lbl_Sattel.TabIndex = 2;
            this.lbl_Sattel.Text = "Sattel";
            // 
            // lbl_drehzahl
            // 
            this.lbl_drehzahl.AutoSize = true;
            this.lbl_drehzahl.Location = new System.Drawing.Point(107, 253);
            this.lbl_drehzahl.Name = "lbl_drehzahl";
            this.lbl_drehzahl.Size = new System.Drawing.Size(73, 20);
            this.lbl_drehzahl.TabIndex = 1;
            this.lbl_drehzahl.Text = "Drehzahl";
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(140, 177);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(40, 20);
            this.lbl_last.TabIndex = 0;
            this.lbl_last.Text = "Last";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1847, 35);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.dateiToolStripMenuItem.Text = "Beenden";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1847, 929);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxSimulation);
            this.Controls.Add(this.groupBoxProtokoll);
            this.Controls.Add(this.gbConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "BikeSim";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.groupBoxProtokoll.ResumeLayout(false);
            this.groupBoxSimulation.ResumeLayout(false);
            this.groupBoxSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSystole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiastole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHerzfrequenz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSattel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDrehzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLast)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCreateSP;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.ProgressBar progressBarConnected;
        private System.Windows.Forms.ListBox lbSent;
        private System.Windows.Forms.GroupBox groupBoxProtokoll;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarSattel;
        private System.Windows.Forms.TrackBar trackBarDrehzahl;
        private System.Windows.Forms.TrackBar trackBarLast;
        private System.Windows.Forms.Label lbl_status_show;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_Sattel;
        private System.Windows.Forms.Label lbl_drehzahl;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.TextBox textBoxSattel;
        private System.Windows.Forms.TextBox textBoxDrehzahl;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.TextBox textBoxSystole;
        private System.Windows.Forms.TrackBar trackBarSystole;
        private System.Windows.Forms.Label lbl_systole;
        private System.Windows.Forms.TextBox textBoxDiastole;
        private System.Windows.Forms.TrackBar trackBarDiastole;
        private System.Windows.Forms.Label lbl_diastole;
        private System.Windows.Forms.TextBox textBoxHerzfrequenz;
        private System.Windows.Forms.TrackBar trackBarHerzfrequenz;
        private System.Windows.Forms.Label lbl_Herzfrequenz;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_belastungstyp_show;
        private System.Windows.Forms.Label lbl_belastungstyp;
    }
}

