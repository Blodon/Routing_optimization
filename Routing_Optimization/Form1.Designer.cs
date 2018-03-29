namespace Routing_Optimization
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Title = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.checkBoxProtocolRIP = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolOSPF = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolISIS = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolEIGRP = new System.Windows.Forms.CheckBox();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.trackBarMaxPath = new System.Windows.Forms.TrackBar();
            this.labelMaxPathValue = new System.Windows.Forms.Label();
            this.labelSelectMaxPath = new System.Windows.Forms.Label();
            this.labelMaxRouters = new System.Windows.Forms.Label();
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.groupBoxGenerate = new System.Windows.Forms.GroupBox();
            this.buttonShowGenerator = new System.Windows.Forms.Button();
            this.buttonEditor = new System.Windows.Forms.Button();
            this.groupBoxGenerateRandom = new System.Windows.Forms.GroupBox();
            this.labelRouterNumberValue = new System.Windows.Forms.Label();
            this.trackBarRandomRoutersNumber = new System.Windows.Forms.TrackBar();
            this.buttonBandwidthHelp = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelBandwidthRange = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.buttonLoadConnections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPath)).BeginInit();
            this.groupBoxGenerate.SuspendLayout();
            this.groupBoxGenerateRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRandomRoutersNumber)).BeginInit();
            this.groupBoxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(759, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "Optymalizacja trasy w ruchu sieciowym";
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InfoButton.FlatAppearance.BorderSize = 2;
            this.InfoButton.Location = new System.Drawing.Point(12, 72);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(128, 50);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Informacje";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // checkBoxProtocolRIP
            // 
            this.checkBoxProtocolRIP.AutoSize = true;
            this.checkBoxProtocolRIP.Checked = true;
            this.checkBoxProtocolRIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolRIP.Location = new System.Drawing.Point(38, 73);
            this.checkBoxProtocolRIP.Name = "checkBoxProtocolRIP";
            this.checkBoxProtocolRIP.Size = new System.Drawing.Size(62, 26);
            this.checkBoxProtocolRIP.TabIndex = 2;
            this.checkBoxProtocolRIP.Text = "RIP";
            this.checkBoxProtocolRIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocolOSPF
            // 
            this.checkBoxProtocolOSPF.AutoSize = true;
            this.checkBoxProtocolOSPF.Checked = true;
            this.checkBoxProtocolOSPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolOSPF.Location = new System.Drawing.Point(38, 105);
            this.checkBoxProtocolOSPF.Name = "checkBoxProtocolOSPF";
            this.checkBoxProtocolOSPF.Size = new System.Drawing.Size(79, 26);
            this.checkBoxProtocolOSPF.TabIndex = 3;
            this.checkBoxProtocolOSPF.Text = "OSPF";
            this.checkBoxProtocolOSPF.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocolISIS
            // 
            this.checkBoxProtocolISIS.AutoSize = true;
            this.checkBoxProtocolISIS.Checked = true;
            this.checkBoxProtocolISIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolISIS.Location = new System.Drawing.Point(38, 137);
            this.checkBoxProtocolISIS.Name = "checkBoxProtocolISIS";
            this.checkBoxProtocolISIS.Size = new System.Drawing.Size(73, 26);
            this.checkBoxProtocolISIS.TabIndex = 4;
            this.checkBoxProtocolISIS.Text = "IS-IS";
            this.checkBoxProtocolISIS.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocolEIGRP
            // 
            this.checkBoxProtocolEIGRP.AutoSize = true;
            this.checkBoxProtocolEIGRP.Checked = true;
            this.checkBoxProtocolEIGRP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolEIGRP.Location = new System.Drawing.Point(38, 169);
            this.checkBoxProtocolEIGRP.Name = "checkBoxProtocolEIGRP";
            this.checkBoxProtocolEIGRP.Size = new System.Drawing.Size(88, 26);
            this.checkBoxProtocolEIGRP.TabIndex = 5;
            this.checkBoxProtocolEIGRP.Text = "EIGRP";
            this.checkBoxProtocolEIGRP.UseVisualStyleBackColor = true;
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(19, 36);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(163, 22);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "Wybierz protokoły:";
            // 
            // trackBarMaxPath
            // 
            this.trackBarMaxPath.LargeChange = 1;
            this.trackBarMaxPath.Location = new System.Drawing.Point(27, 168);
            this.trackBarMaxPath.Maximum = 0;
            this.trackBarMaxPath.Name = "trackBarMaxPath";
            this.trackBarMaxPath.Size = new System.Drawing.Size(284, 56);
            this.trackBarMaxPath.TabIndex = 7;
            this.trackBarMaxPath.ValueChanged += new System.EventHandler(this.trackBarMaxPath_ValueChanged);
            // 
            // labelMaxPathValue
            // 
            this.labelMaxPathValue.AutoSize = true;
            this.labelMaxPathValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPathValue.Location = new System.Drawing.Point(317, 168);
            this.labelMaxPathValue.Name = "labelMaxPathValue";
            this.labelMaxPathValue.Size = new System.Drawing.Size(0, 23);
            this.labelMaxPathValue.TabIndex = 8;
            // 
            // labelSelectMaxPath
            // 
            this.labelSelectMaxPath.AutoSize = true;
            this.labelSelectMaxPath.Location = new System.Drawing.Point(23, 143);
            this.labelSelectMaxPath.Name = "labelSelectMaxPath";
            this.labelSelectMaxPath.Size = new System.Drawing.Size(201, 22);
            this.labelSelectMaxPath.TabIndex = 10;
            this.labelSelectMaxPath.Text = "Wybierz ilość połączeń:";
            // 
            // labelMaxRouters
            // 
            this.labelMaxRouters.AutoSize = true;
            this.labelMaxRouters.Location = new System.Drawing.Point(24, 62);
            this.labelMaxRouters.Name = "labelMaxRouters";
            this.labelMaxRouters.Size = new System.Drawing.Size(203, 22);
            this.labelMaxRouters.TabIndex = 11;
            this.labelMaxRouters.Text = "Wybierz ilość routerów:";
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Location = new System.Drawing.Point(6, 225);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(376, 50);
            this.buttonGenerateMap.TabIndex = 12;
            this.buttonGenerateMap.Text = "Generuj losowe połączenia";
            this.buttonGenerateMap.UseVisualStyleBackColor = true;
            this.buttonGenerateMap.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // groupBoxGenerate
            // 
            this.groupBoxGenerate.Controls.Add(this.buttonShowGenerator);
            this.groupBoxGenerate.Controls.Add(this.buttonEditor);
            this.groupBoxGenerate.Controls.Add(this.groupBoxGenerateRandom);
            this.groupBoxGenerate.Location = new System.Drawing.Point(15, 138);
            this.groupBoxGenerate.Name = "groupBoxGenerate";
            this.groupBoxGenerate.Size = new System.Drawing.Size(402, 383);
            this.groupBoxGenerate.TabIndex = 13;
            this.groupBoxGenerate.TabStop = false;
            this.groupBoxGenerate.Text = "Generator połączń";
            this.groupBoxGenerate.Enter += new System.EventHandler(this.groupBoxGenerate_Enter);
            // 
            // buttonShowGenerator
            // 
            this.buttonShowGenerator.Location = new System.Drawing.Point(14, 100);
            this.buttonShowGenerator.Name = "buttonShowGenerator";
            this.buttonShowGenerator.Size = new System.Drawing.Size(376, 50);
            this.buttonShowGenerator.TabIndex = 18;
            this.buttonShowGenerator.Text = "Losowe połączenia";
            this.buttonShowGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonShowGenerator.UseVisualStyleBackColor = true;
            this.buttonShowGenerator.Click += new System.EventHandler(this.buttonShowGenerator_Click);
            // 
            // buttonEditor
            // 
            this.buttonEditor.Location = new System.Drawing.Point(14, 35);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.Size = new System.Drawing.Size(376, 50);
            this.buttonEditor.TabIndex = 1;
            this.buttonEditor.Text = "Edytor połączeń";
            this.buttonEditor.UseVisualStyleBackColor = true;
            this.buttonEditor.Click += new System.EventHandler(this.buttonEditor_Click);
            // 
            // groupBoxGenerateRandom
            // 
            this.groupBoxGenerateRandom.Controls.Add(this.labelRouterNumberValue);
            this.groupBoxGenerateRandom.Controls.Add(this.trackBarRandomRoutersNumber);
            this.groupBoxGenerateRandom.Controls.Add(this.buttonBandwidthHelp);
            this.groupBoxGenerateRandom.Controls.Add(this.comboBox2);
            this.groupBoxGenerateRandom.Controls.Add(this.labelBandwidthRange);
            this.groupBoxGenerateRandom.Controls.Add(this.comboBox1);
            this.groupBoxGenerateRandom.Controls.Add(this.labelBandwidth);
            this.groupBoxGenerateRandom.Controls.Add(this.buttonGenerateMap);
            this.groupBoxGenerateRandom.Controls.Add(this.trackBarMaxPath);
            this.groupBoxGenerateRandom.Controls.Add(this.labelMaxRouters);
            this.groupBoxGenerateRandom.Controls.Add(this.labelMaxPathValue);
            this.groupBoxGenerateRandom.Controls.Add(this.labelSelectMaxPath);
            this.groupBoxGenerateRandom.Location = new System.Drawing.Point(8, 96);
            this.groupBoxGenerateRandom.Name = "groupBoxGenerateRandom";
            this.groupBoxGenerateRandom.Size = new System.Drawing.Size(388, 281);
            this.groupBoxGenerateRandom.TabIndex = 0;
            this.groupBoxGenerateRandom.TabStop = false;
            this.groupBoxGenerateRandom.Text = "Losowe połączenia";
            this.groupBoxGenerateRandom.Visible = false;
            // 
            // labelRouterNumberValue
            // 
            this.labelRouterNumberValue.AutoSize = true;
            this.labelRouterNumberValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRouterNumberValue.Location = new System.Drawing.Point(317, 87);
            this.labelRouterNumberValue.Name = "labelRouterNumberValue";
            this.labelRouterNumberValue.Size = new System.Drawing.Size(0, 23);
            this.labelRouterNumberValue.TabIndex = 19;
            // 
            // trackBarRandomRoutersNumber
            // 
            this.trackBarRandomRoutersNumber.LargeChange = 1;
            this.trackBarRandomRoutersNumber.Location = new System.Drawing.Point(27, 87);
            this.trackBarRandomRoutersNumber.Maximum = 20;
            this.trackBarRandomRoutersNumber.Minimum = 1;
            this.trackBarRandomRoutersNumber.Name = "trackBarRandomRoutersNumber";
            this.trackBarRandomRoutersNumber.Size = new System.Drawing.Size(284, 56);
            this.trackBarRandomRoutersNumber.TabIndex = 18;
            this.trackBarRandomRoutersNumber.Value = 1;
            this.trackBarRandomRoutersNumber.ValueChanged += new System.EventHandler(this.trackBarRandomRoutersNumber_ValueChanged);
            // 
            // buttonBandwidthHelp
            // 
            this.buttonBandwidthHelp.Location = new System.Drawing.Point(338, 29);
            this.buttonBandwidthHelp.Name = "buttonBandwidthHelp";
            this.buttonBandwidthHelp.Size = new System.Drawing.Size(30, 30);
            this.buttonBandwidthHelp.TabIndex = 17;
            this.buttonBandwidthHelp.Text = "?";
            this.buttonBandwidthHelp.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 30);
            this.comboBox2.TabIndex = 16;
            // 
            // labelBandwidthRange
            // 
            this.labelBandwidthRange.AutoSize = true;
            this.labelBandwidthRange.Location = new System.Drawing.Point(197, 32);
            this.labelBandwidthRange.Name = "labelBandwidthRange";
            this.labelBandwidthRange.Size = new System.Drawing.Size(30, 22);
            this.labelBandwidthRange.TabIndex = 15;
            this.labelBandwidthRange.Text = "do";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 30);
            this.comboBox1.TabIndex = 14;
            // 
            // labelBandwidth
            // 
            this.labelBandwidth.AutoSize = true;
            this.labelBandwidth.Location = new System.Drawing.Point(23, 32);
            this.labelBandwidth.Name = "labelBandwidth";
            this.labelBandwidth.Size = new System.Drawing.Size(63, 22);
            this.labelBandwidth.TabIndex = 13;
            this.labelBandwidth.Text = "Łącza:";
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.buttonSimulation);
            this.groupBoxSimulation.Controls.Add(this.labelProtocol);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolEIGRP);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolISIS);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolOSPF);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolRIP);
            this.groupBoxSimulation.Location = new System.Drawing.Point(15, 527);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(402, 278);
            this.groupBoxSimulation.TabIndex = 14;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "Symulacja";
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSimulation.Enabled = false;
            this.buttonSimulation.Location = new System.Drawing.Point(8, 222);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(382, 50);
            this.buttonSimulation.TabIndex = 7;
            this.buttonSimulation.Text = "Przeporowadź symulację";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(785, 435);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(714, 370);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraph.Image")));
            this.pictureBoxGraph.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraph.InitialImage")));
            this.pictureBoxGraph.Location = new System.Drawing.Point(785, 12);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(714, 417);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGraph.TabIndex = 16;
            this.pictureBoxGraph.TabStop = false;
            // 
            // buttonLoadConnections
            // 
            this.buttonLoadConnections.Location = new System.Drawing.Point(146, 72);
            this.buttonLoadConnections.Name = "buttonLoadConnections";
            this.buttonLoadConnections.Size = new System.Drawing.Size(271, 50);
            this.buttonLoadConnections.TabIndex = 17;
            this.buttonLoadConnections.Text = "Wczytaj połączenia";
            this.buttonLoadConnections.UseVisualStyleBackColor = true;
            this.buttonLoadConnections.Click += new System.EventHandler(this.buttonLoadConnections_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1511, 803);
            this.Controls.Add(this.buttonLoadConnections);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxSimulation);
            this.Controls.Add(this.groupBoxGenerate);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Routing optimization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPath)).EndInit();
            this.groupBoxGenerate.ResumeLayout(false);
            this.groupBoxGenerateRandom.ResumeLayout(false);
            this.groupBoxGenerateRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRandomRoutersNumber)).EndInit();
            this.groupBoxSimulation.ResumeLayout(false);
            this.groupBoxSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.CheckBox checkBoxProtocolRIP;
        private System.Windows.Forms.CheckBox checkBoxProtocolOSPF;
        private System.Windows.Forms.CheckBox checkBoxProtocolISIS;
        private System.Windows.Forms.CheckBox checkBoxProtocolEIGRP;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.TrackBar trackBarMaxPath;
        private System.Windows.Forms.Label labelMaxPathValue;
        private System.Windows.Forms.Label labelSelectMaxPath;
        private System.Windows.Forms.Label labelMaxRouters;
        private System.Windows.Forms.Button buttonGenerateMap;
        private System.Windows.Forms.GroupBox groupBoxGenerate;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.Button buttonSimulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.GroupBox groupBoxGenerateRandom;
        private System.Windows.Forms.Button buttonLoadConnections;
        private System.Windows.Forms.Button buttonEditor;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelBandwidthRange;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBandwidthHelp;
        private System.Windows.Forms.Button buttonShowGenerator;
        private System.Windows.Forms.TrackBar trackBarRandomRoutersNumber;
        private System.Windows.Forms.Label labelRouterNumberValue;
    }
}

