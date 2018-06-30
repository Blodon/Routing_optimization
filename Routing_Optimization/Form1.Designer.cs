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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Title = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.checkBoxProtocolRIP = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolOSPF = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolIGRP = new System.Windows.Forms.CheckBox();
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
            this.textBoxMaximalBandWidth = new System.Windows.Forms.TextBox();
            this.textBoxMinimalBandWidth = new System.Windows.Forms.TextBox();
            this.labelRouterNumberValue = new System.Windows.Forms.Label();
            this.trackBarRandomRoutersNumber = new System.Windows.Forms.TrackBar();
            this.labelBandwidthRange = new System.Windows.Forms.Label();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.buttonTestAll = new System.Windows.Forms.Button();
            this.checkBoxWarshall = new System.Windows.Forms.CheckBox();
            this.labelDestinationRouter = new System.Windows.Forms.Label();
            this.labelSourceRouter = new System.Windows.Forms.Label();
            this.textBoxDestinationRouter = new System.Windows.Forms.TextBox();
            this.textBoxSourceRouter = new System.Windows.Forms.TextBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.chartRouts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.buttonLoadConnections = new System.Windows.Forms.Button();
            this.openFileDialogLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxSimulationInformations = new System.Windows.Forms.GroupBox();
            this.textBoxShowRoute = new System.Windows.Forms.TextBox();
            this.labelSelectedRoute = new System.Windows.Forms.Label();
            this.labelTimeBFSSummary = new System.Windows.Forms.Label();
            this.labelTimeDijkstraSummary = new System.Windows.Forms.Label();
            this.labelTimeBellmanSummary = new System.Windows.Forms.Label();
            this.labelTimeWarshallSummary = new System.Windows.Forms.Label();
            this.labelTimeSummary = new System.Windows.Forms.Label();
            this.labelTimeBFSData = new System.Windows.Forms.Label();
            this.labelTimeDijkstraData = new System.Windows.Forms.Label();
            this.labelTimeBellmanData = new System.Windows.Forms.Label();
            this.labelTimeWarshallData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimeBFS = new System.Windows.Forms.Label();
            this.buttonChartWarshall = new System.Windows.Forms.Button();
            this.buttonChartEIGP = new System.Windows.Forms.Button();
            this.buttonChartOSPF = new System.Windows.Forms.Button();
            this.buttonChartRIP = new System.Windows.Forms.Button();
            this.labelShowChart = new System.Windows.Forms.Label();
            this.buttonTraceWarshall = new System.Windows.Forms.Button();
            this.buttonTraceEIGRP = new System.Windows.Forms.Button();
            this.buttonTraceOSPF = new System.Windows.Forms.Button();
            this.buttonTraceRIP = new System.Windows.Forms.Button();
            this.labelShowTrace = new System.Windows.Forms.Label();
            this.labelTimeDijkstra = new System.Windows.Forms.Label();
            this.labelTimeBellman = new System.Windows.Forms.Label();
            this.labelTimeWarshall = new System.Windows.Forms.Label();
            this.labelInformationsTimes = new System.Windows.Forms.Label();
            this.labelSelectRandomDelay = new System.Windows.Forms.Label();
            this.textBoxRandomDelayMin = new System.Windows.Forms.TextBox();
            this.textBoxRandomDelayMax = new System.Windows.Forms.TextBox();
            this.labelDelayRange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetNewParameters = new System.Windows.Forms.Button();
            this.checkBoxCreateCSV = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPath)).BeginInit();
            this.groupBoxGenerate.SuspendLayout();
            this.groupBoxGenerateRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRandomRoutersNumber)).BeginInit();
            this.groupBoxSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.groupBoxSimulationInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(536, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "Routing protocols simulator";
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InfoButton.FlatAppearance.BorderSize = 2;
            this.InfoButton.Location = new System.Drawing.Point(12, 72);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(128, 50);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Informations";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // checkBoxProtocolRIP
            // 
            this.checkBoxProtocolRIP.AutoSize = true;
            this.checkBoxProtocolRIP.Checked = true;
            this.checkBoxProtocolRIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolRIP.Location = new System.Drawing.Point(38, 41);
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
            this.checkBoxProtocolOSPF.Location = new System.Drawing.Point(38, 64);
            this.checkBoxProtocolOSPF.Name = "checkBoxProtocolOSPF";
            this.checkBoxProtocolOSPF.Size = new System.Drawing.Size(79, 26);
            this.checkBoxProtocolOSPF.TabIndex = 3;
            this.checkBoxProtocolOSPF.Text = "OSPF";
            this.checkBoxProtocolOSPF.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocolIGRP
            // 
            this.checkBoxProtocolIGRP.AutoSize = true;
            this.checkBoxProtocolIGRP.Checked = true;
            this.checkBoxProtocolIGRP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolIGRP.Location = new System.Drawing.Point(38, 89);
            this.checkBoxProtocolIGRP.Name = "checkBoxProtocolIGRP";
            this.checkBoxProtocolIGRP.Size = new System.Drawing.Size(76, 26);
            this.checkBoxProtocolIGRP.TabIndex = 5;
            this.checkBoxProtocolIGRP.Text = "IGRP";
            this.checkBoxProtocolIGRP.UseVisualStyleBackColor = true;
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(19, 18);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(145, 22);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "Select protocols:";
            // 
            // trackBarMaxPath
            // 
            this.trackBarMaxPath.LargeChange = 1;
            this.trackBarMaxPath.Location = new System.Drawing.Point(27, 222);
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
            this.labelMaxPathValue.Location = new System.Drawing.Point(317, 222);
            this.labelMaxPathValue.Name = "labelMaxPathValue";
            this.labelMaxPathValue.Size = new System.Drawing.Size(0, 23);
            this.labelMaxPathValue.TabIndex = 8;
            // 
            // labelSelectMaxPath
            // 
            this.labelSelectMaxPath.AutoSize = true;
            this.labelSelectMaxPath.Location = new System.Drawing.Point(23, 197);
            this.labelSelectMaxPath.Name = "labelSelectMaxPath";
            this.labelSelectMaxPath.Size = new System.Drawing.Size(202, 22);
            this.labelSelectMaxPath.TabIndex = 10;
            this.labelSelectMaxPath.Text = "Choose number of links:";
            // 
            // labelMaxRouters
            // 
            this.labelMaxRouters.AutoSize = true;
            this.labelMaxRouters.Location = new System.Drawing.Point(24, 116);
            this.labelMaxRouters.Name = "labelMaxRouters";
            this.labelMaxRouters.Size = new System.Drawing.Size(219, 22);
            this.labelMaxRouters.TabIndex = 11;
            this.labelMaxRouters.Text = "Choose number of routers:";
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Location = new System.Drawing.Point(6, 279);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(188, 50);
            this.buttonGenerateMap.TabIndex = 12;
            this.buttonGenerateMap.Text = "Generate random";
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
            this.groupBoxGenerate.Size = new System.Drawing.Size(402, 436);
            this.groupBoxGenerate.TabIndex = 13;
            this.groupBoxGenerate.TabStop = false;
            this.groupBoxGenerate.Text = "Topology generator";
            this.groupBoxGenerate.Enter += new System.EventHandler(this.groupBoxGenerate_Enter);
            // 
            // buttonShowGenerator
            // 
            this.buttonShowGenerator.Location = new System.Drawing.Point(14, 100);
            this.buttonShowGenerator.Name = "buttonShowGenerator";
            this.buttonShowGenerator.Size = new System.Drawing.Size(376, 50);
            this.buttonShowGenerator.TabIndex = 18;
            this.buttonShowGenerator.Text = "Random topology";
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
            this.buttonEditor.Text = "Topology editor";
            this.buttonEditor.UseVisualStyleBackColor = true;
            this.buttonEditor.Click += new System.EventHandler(this.buttonEditor_Click);
            // 
            // groupBoxGenerateRandom
            // 
            this.groupBoxGenerateRandom.Controls.Add(this.buttonSetNewParameters);
            this.groupBoxGenerateRandom.Controls.Add(this.label2);
            this.groupBoxGenerateRandom.Controls.Add(this.label1);
            this.groupBoxGenerateRandom.Controls.Add(this.labelDelayRange);
            this.groupBoxGenerateRandom.Controls.Add(this.textBoxRandomDelayMax);
            this.groupBoxGenerateRandom.Controls.Add(this.textBoxRandomDelayMin);
            this.groupBoxGenerateRandom.Controls.Add(this.labelSelectRandomDelay);
            this.groupBoxGenerateRandom.Controls.Add(this.textBoxMaximalBandWidth);
            this.groupBoxGenerateRandom.Controls.Add(this.textBoxMinimalBandWidth);
            this.groupBoxGenerateRandom.Controls.Add(this.labelRouterNumberValue);
            this.groupBoxGenerateRandom.Controls.Add(this.trackBarRandomRoutersNumber);
            this.groupBoxGenerateRandom.Controls.Add(this.labelBandwidthRange);
            this.groupBoxGenerateRandom.Controls.Add(this.labelBandwidth);
            this.groupBoxGenerateRandom.Controls.Add(this.buttonGenerateMap);
            this.groupBoxGenerateRandom.Controls.Add(this.trackBarMaxPath);
            this.groupBoxGenerateRandom.Controls.Add(this.labelMaxRouters);
            this.groupBoxGenerateRandom.Controls.Add(this.labelMaxPathValue);
            this.groupBoxGenerateRandom.Controls.Add(this.labelSelectMaxPath);
            this.groupBoxGenerateRandom.Location = new System.Drawing.Point(8, 96);
            this.groupBoxGenerateRandom.Name = "groupBoxGenerateRandom";
            this.groupBoxGenerateRandom.Size = new System.Drawing.Size(388, 334);
            this.groupBoxGenerateRandom.TabIndex = 0;
            this.groupBoxGenerateRandom.TabStop = false;
            this.groupBoxGenerateRandom.Text = "Random connections";
            this.groupBoxGenerateRandom.Visible = false;
            // 
            // textBoxMaximalBandWidth
            // 
            this.textBoxMaximalBandWidth.Location = new System.Drawing.Point(228, 32);
            this.textBoxMaximalBandWidth.Name = "textBoxMaximalBandWidth";
            this.textBoxMaximalBandWidth.Size = new System.Drawing.Size(70, 30);
            this.textBoxMaximalBandWidth.TabIndex = 21;
            this.textBoxMaximalBandWidth.Text = "1000";
            // 
            // textBoxMinimalBandWidth
            // 
            this.textBoxMinimalBandWidth.Location = new System.Drawing.Point(123, 30);
            this.textBoxMinimalBandWidth.Name = "textBoxMinimalBandWidth";
            this.textBoxMinimalBandWidth.Size = new System.Drawing.Size(74, 30);
            this.textBoxMinimalBandWidth.TabIndex = 20;
            this.textBoxMinimalBandWidth.Text = "100";
            // 
            // labelRouterNumberValue
            // 
            this.labelRouterNumberValue.AutoSize = true;
            this.labelRouterNumberValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRouterNumberValue.Location = new System.Drawing.Point(317, 141);
            this.labelRouterNumberValue.Name = "labelRouterNumberValue";
            this.labelRouterNumberValue.Size = new System.Drawing.Size(0, 23);
            this.labelRouterNumberValue.TabIndex = 19;
            // 
            // trackBarRandomRoutersNumber
            // 
            this.trackBarRandomRoutersNumber.LargeChange = 1;
            this.trackBarRandomRoutersNumber.Location = new System.Drawing.Point(27, 141);
            this.trackBarRandomRoutersNumber.Maximum = 800;
            this.trackBarRandomRoutersNumber.Minimum = 1;
            this.trackBarRandomRoutersNumber.Name = "trackBarRandomRoutersNumber";
            this.trackBarRandomRoutersNumber.Size = new System.Drawing.Size(284, 56);
            this.trackBarRandomRoutersNumber.TabIndex = 18;
            this.trackBarRandomRoutersNumber.Value = 1;
            this.trackBarRandomRoutersNumber.ValueChanged += new System.EventHandler(this.trackBarRandomRoutersNumber_ValueChanged);
            // 
            // labelBandwidthRange
            // 
            this.labelBandwidthRange.AutoSize = true;
            this.labelBandwidthRange.Location = new System.Drawing.Point(197, 32);
            this.labelBandwidthRange.Name = "labelBandwidthRange";
            this.labelBandwidthRange.Size = new System.Drawing.Size(25, 22);
            this.labelBandwidthRange.TabIndex = 15;
            this.labelBandwidthRange.Text = "to";
            // 
            // labelBandwidth
            // 
            this.labelBandwidth.AutoSize = true;
            this.labelBandwidth.Location = new System.Drawing.Point(23, 32);
            this.labelBandwidth.Name = "labelBandwidth";
            this.labelBandwidth.Size = new System.Drawing.Size(102, 22);
            this.labelBandwidth.TabIndex = 13;
            this.labelBandwidth.Text = "Bandwidth:";
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.checkBoxCreateCSV);
            this.groupBoxSimulation.Controls.Add(this.buttonTestAll);
            this.groupBoxSimulation.Controls.Add(this.checkBoxWarshall);
            this.groupBoxSimulation.Controls.Add(this.labelDestinationRouter);
            this.groupBoxSimulation.Controls.Add(this.labelSourceRouter);
            this.groupBoxSimulation.Controls.Add(this.textBoxDestinationRouter);
            this.groupBoxSimulation.Controls.Add(this.textBoxSourceRouter);
            this.groupBoxSimulation.Controls.Add(this.buttonSimulation);
            this.groupBoxSimulation.Controls.Add(this.labelProtocol);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolIGRP);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolOSPF);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolRIP);
            this.groupBoxSimulation.Location = new System.Drawing.Point(15, 580);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(402, 225);
            this.groupBoxSimulation.TabIndex = 14;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "simulation";
            // 
            // buttonTestAll
            // 
            this.buttonTestAll.Location = new System.Drawing.Point(6, 177);
            this.buttonTestAll.Name = "buttonTestAll";
            this.buttonTestAll.Size = new System.Drawing.Size(188, 50);
            this.buttonTestAll.TabIndex = 13;
            this.buttonTestAll.Text = "All to all (csv)";
            this.buttonTestAll.UseVisualStyleBackColor = true;
            this.buttonTestAll.Click += new System.EventHandler(this.buttonTestAll_Click);
            // 
            // checkBoxWarshall
            // 
            this.checkBoxWarshall.AutoSize = true;
            this.checkBoxWarshall.Checked = true;
            this.checkBoxWarshall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWarshall.Location = new System.Drawing.Point(38, 113);
            this.checkBoxWarshall.Name = "checkBoxWarshall";
            this.checkBoxWarshall.Size = new System.Drawing.Size(164, 26);
            this.checkBoxWarshall.TabIndex = 12;
            this.checkBoxWarshall.Text = "Floyd-Warshall*";
            this.checkBoxWarshall.UseVisualStyleBackColor = true;
            // 
            // labelDestinationRouter
            // 
            this.labelDestinationRouter.AutoSize = true;
            this.labelDestinationRouter.Location = new System.Drawing.Point(222, 117);
            this.labelDestinationRouter.Name = "labelDestinationRouter";
            this.labelDestinationRouter.Size = new System.Drawing.Size(158, 22);
            this.labelDestinationRouter.TabIndex = 11;
            this.labelDestinationRouter.Text = "Destination router:";
            this.labelDestinationRouter.Click += new System.EventHandler(this.labelDestinationRouter_Click);
            // 
            // labelSourceRouter
            // 
            this.labelSourceRouter.AutoSize = true;
            this.labelSourceRouter.Location = new System.Drawing.Point(222, 55);
            this.labelSourceRouter.Name = "labelSourceRouter";
            this.labelSourceRouter.Size = new System.Drawing.Size(129, 22);
            this.labelSourceRouter.TabIndex = 10;
            this.labelSourceRouter.Text = "Source Router:";
            // 
            // textBoxDestinationRouter
            // 
            this.textBoxDestinationRouter.Location = new System.Drawing.Point(223, 142);
            this.textBoxDestinationRouter.Name = "textBoxDestinationRouter";
            this.textBoxDestinationRouter.Size = new System.Drawing.Size(100, 30);
            this.textBoxDestinationRouter.TabIndex = 9;
            this.textBoxDestinationRouter.Text = "1";
            // 
            // textBoxSourceRouter
            // 
            this.textBoxSourceRouter.Location = new System.Drawing.Point(223, 82);
            this.textBoxSourceRouter.Name = "textBoxSourceRouter";
            this.textBoxSourceRouter.Size = new System.Drawing.Size(100, 30);
            this.textBoxSourceRouter.TabIndex = 8;
            this.textBoxSourceRouter.Text = "1";
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSimulation.Location = new System.Drawing.Point(223, 177);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(167, 50);
            this.buttonSimulation.TabIndex = 7;
            this.buttonSimulation.Text = "single simulation";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            // 
            // chartRouts
            // 
            chartArea2.AxisX.Title = "Router no.";
            chartArea2.AxisY.Title = "Cost of route";
            chartArea2.Name = "ChartArea1";
            this.chartRouts.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRouts.Legends.Add(legend2);
            this.chartRouts.Location = new System.Drawing.Point(785, 435);
            this.chartRouts.Name = "chartRouts";
            this.chartRouts.Size = new System.Drawing.Size(714, 370);
            this.chartRouts.TabIndex = 15;
            this.chartRouts.Text = "Koszty tras";
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
            this.buttonLoadConnections.Text = "Load topology";
            this.buttonLoadConnections.UseVisualStyleBackColor = true;
            this.buttonLoadConnections.Click += new System.EventHandler(this.buttonLoadConnections_Click);
            // 
            // openFileDialogLoadFile
            // 
            this.openFileDialogLoadFile.FileName = "Load file";
            this.openFileDialogLoadFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLoadFile_FileOk);
            // 
            // groupBoxSimulationInformations
            // 
            this.groupBoxSimulationInformations.Controls.Add(this.textBoxShowRoute);
            this.groupBoxSimulationInformations.Controls.Add(this.labelSelectedRoute);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBFSSummary);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeDijkstraSummary);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBellmanSummary);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeWarshallSummary);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeSummary);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBFSData);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeDijkstraData);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBellmanData);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeWarshallData);
            this.groupBoxSimulationInformations.Controls.Add(this.label5);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBFS);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonChartWarshall);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonChartEIGP);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonChartOSPF);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonChartRIP);
            this.groupBoxSimulationInformations.Controls.Add(this.labelShowChart);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonTraceWarshall);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonTraceEIGRP);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonTraceOSPF);
            this.groupBoxSimulationInformations.Controls.Add(this.buttonTraceRIP);
            this.groupBoxSimulationInformations.Controls.Add(this.labelShowTrace);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeDijkstra);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeBellman);
            this.groupBoxSimulationInformations.Controls.Add(this.labelTimeWarshall);
            this.groupBoxSimulationInformations.Controls.Add(this.labelInformationsTimes);
            this.groupBoxSimulationInformations.Location = new System.Drawing.Point(423, 72);
            this.groupBoxSimulationInformations.Name = "groupBoxSimulationInformations";
            this.groupBoxSimulationInformations.Size = new System.Drawing.Size(348, 733);
            this.groupBoxSimulationInformations.TabIndex = 18;
            this.groupBoxSimulationInformations.TabStop = false;
            this.groupBoxSimulationInformations.Text = "Simulation informations";
            this.groupBoxSimulationInformations.Visible = false;
            // 
            // textBoxShowRoute
            // 
            this.textBoxShowRoute.Location = new System.Drawing.Point(17, 516);
            this.textBoxShowRoute.Name = "textBoxShowRoute";
            this.textBoxShowRoute.Size = new System.Drawing.Size(306, 30);
            this.textBoxShowRoute.TabIndex = 26;
            // 
            // labelSelectedRoute
            // 
            this.labelSelectedRoute.AutoSize = true;
            this.labelSelectedRoute.Location = new System.Drawing.Point(13, 491);
            this.labelSelectedRoute.Name = "labelSelectedRoute";
            this.labelSelectedRoute.Size = new System.Drawing.Size(110, 22);
            this.labelSelectedRoute.TabIndex = 25;
            this.labelSelectedRoute.Text = "Found route:";
            // 
            // labelTimeBFSSummary
            // 
            this.labelTimeBFSSummary.AutoSize = true;
            this.labelTimeBFSSummary.Location = new System.Drawing.Point(34, 341);
            this.labelTimeBFSSummary.Name = "labelTimeBFSSummary";
            this.labelTimeBFSSummary.Size = new System.Drawing.Size(45, 22);
            this.labelTimeBFSSummary.TabIndex = 24;
            this.labelTimeBFSSummary.Text = "BFS";
            // 
            // labelTimeDijkstraSummary
            // 
            this.labelTimeDijkstraSummary.AutoSize = true;
            this.labelTimeDijkstraSummary.Location = new System.Drawing.Point(34, 366);
            this.labelTimeDijkstraSummary.Name = "labelTimeDijkstraSummary";
            this.labelTimeDijkstraSummary.Size = new System.Drawing.Size(74, 22);
            this.labelTimeDijkstraSummary.TabIndex = 23;
            this.labelTimeDijkstraSummary.Text = "Dijkstra";
            // 
            // labelTimeBellmanSummary
            // 
            this.labelTimeBellmanSummary.AutoSize = true;
            this.labelTimeBellmanSummary.Location = new System.Drawing.Point(35, 393);
            this.labelTimeBellmanSummary.Name = "labelTimeBellmanSummary";
            this.labelTimeBellmanSummary.Size = new System.Drawing.Size(76, 22);
            this.labelTimeBellmanSummary.TabIndex = 22;
            this.labelTimeBellmanSummary.Text = "Bellman";
            // 
            // labelTimeWarshallSummary
            // 
            this.labelTimeWarshallSummary.AutoSize = true;
            this.labelTimeWarshallSummary.Location = new System.Drawing.Point(34, 416);
            this.labelTimeWarshallSummary.Name = "labelTimeWarshallSummary";
            this.labelTimeWarshallSummary.Size = new System.Drawing.Size(80, 22);
            this.labelTimeWarshallSummary.TabIndex = 21;
            this.labelTimeWarshallSummary.Text = "Warshall";
            // 
            // labelTimeSummary
            // 
            this.labelTimeSummary.AutoSize = true;
            this.labelTimeSummary.Location = new System.Drawing.Point(13, 315);
            this.labelTimeSummary.Name = "labelTimeSummary";
            this.labelTimeSummary.Size = new System.Drawing.Size(174, 22);
            this.labelTimeSummary.TabIndex = 20;
            this.labelTimeSummary.Text = "Whole time of work:";
            // 
            // labelTimeBFSData
            // 
            this.labelTimeBFSData.AutoSize = true;
            this.labelTimeBFSData.Location = new System.Drawing.Point(32, 49);
            this.labelTimeBFSData.Name = "labelTimeBFSData";
            this.labelTimeBFSData.Size = new System.Drawing.Size(45, 22);
            this.labelTimeBFSData.TabIndex = 19;
            this.labelTimeBFSData.Text = "BFS";
            // 
            // labelTimeDijkstraData
            // 
            this.labelTimeDijkstraData.AutoSize = true;
            this.labelTimeDijkstraData.Location = new System.Drawing.Point(33, 75);
            this.labelTimeDijkstraData.Name = "labelTimeDijkstraData";
            this.labelTimeDijkstraData.Size = new System.Drawing.Size(74, 22);
            this.labelTimeDijkstraData.TabIndex = 18;
            this.labelTimeDijkstraData.Text = "Dijkstra";
            // 
            // labelTimeBellmanData
            // 
            this.labelTimeBellmanData.AutoSize = true;
            this.labelTimeBellmanData.Location = new System.Drawing.Point(32, 98);
            this.labelTimeBellmanData.Name = "labelTimeBellmanData";
            this.labelTimeBellmanData.Size = new System.Drawing.Size(76, 22);
            this.labelTimeBellmanData.TabIndex = 17;
            this.labelTimeBellmanData.Text = "Bellman";
            // 
            // labelTimeWarshallData
            // 
            this.labelTimeWarshallData.AutoSize = true;
            this.labelTimeWarshallData.Location = new System.Drawing.Point(32, 124);
            this.labelTimeWarshallData.Name = "labelTimeWarshallData";
            this.labelTimeWarshallData.Size = new System.Drawing.Size(80, 22);
            this.labelTimeWarshallData.TabIndex = 16;
            this.labelTimeWarshallData.Text = "Warshall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time of collecting data:";
            // 
            // labelTimeBFS
            // 
            this.labelTimeBFS.AutoSize = true;
            this.labelTimeBFS.Location = new System.Drawing.Point(32, 193);
            this.labelTimeBFS.Name = "labelTimeBFS";
            this.labelTimeBFS.Size = new System.Drawing.Size(45, 22);
            this.labelTimeBFS.TabIndex = 14;
            this.labelTimeBFS.Text = "BFS";
            // 
            // buttonChartWarshall
            // 
            this.buttonChartWarshall.Location = new System.Drawing.Point(249, 676);
            this.buttonChartWarshall.Name = "buttonChartWarshall";
            this.buttonChartWarshall.Size = new System.Drawing.Size(75, 41);
            this.buttonChartWarshall.TabIndex = 13;
            this.buttonChartWarshall.Text = "F-W";
            this.buttonChartWarshall.UseVisualStyleBackColor = true;
            this.buttonChartWarshall.Click += new System.EventHandler(this.buttonChartWarshall_Click);
            // 
            // buttonChartEIGP
            // 
            this.buttonChartEIGP.Location = new System.Drawing.Point(168, 676);
            this.buttonChartEIGP.Name = "buttonChartEIGP";
            this.buttonChartEIGP.Size = new System.Drawing.Size(75, 41);
            this.buttonChartEIGP.TabIndex = 12;
            this.buttonChartEIGP.Text = "IGRP";
            this.buttonChartEIGP.UseVisualStyleBackColor = true;
            this.buttonChartEIGP.Click += new System.EventHandler(this.buttonChartEIGP_Click);
            // 
            // buttonChartOSPF
            // 
            this.buttonChartOSPF.Location = new System.Drawing.Point(87, 676);
            this.buttonChartOSPF.Name = "buttonChartOSPF";
            this.buttonChartOSPF.Size = new System.Drawing.Size(75, 41);
            this.buttonChartOSPF.TabIndex = 11;
            this.buttonChartOSPF.Text = "OSPF";
            this.buttonChartOSPF.UseVisualStyleBackColor = true;
            this.buttonChartOSPF.Click += new System.EventHandler(this.buttonChartOSPF_Click);
            // 
            // buttonChartRIP
            // 
            this.buttonChartRIP.Location = new System.Drawing.Point(6, 676);
            this.buttonChartRIP.Name = "buttonChartRIP";
            this.buttonChartRIP.Size = new System.Drawing.Size(75, 41);
            this.buttonChartRIP.TabIndex = 10;
            this.buttonChartRIP.Text = "RIP";
            this.buttonChartRIP.UseVisualStyleBackColor = true;
            this.buttonChartRIP.Click += new System.EventHandler(this.buttonChartRIP_Click);
            // 
            // labelShowChart
            // 
            this.labelShowChart.AutoSize = true;
            this.labelShowChart.Location = new System.Drawing.Point(23, 648);
            this.labelShowChart.Name = "labelShowChart";
            this.labelShowChart.Size = new System.Drawing.Size(133, 22);
            this.labelShowChart.TabIndex = 9;
            this.labelShowChart.Text = "Show chart for:";
            // 
            // buttonTraceWarshall
            // 
            this.buttonTraceWarshall.Location = new System.Drawing.Point(249, 585);
            this.buttonTraceWarshall.Name = "buttonTraceWarshall";
            this.buttonTraceWarshall.Size = new System.Drawing.Size(75, 41);
            this.buttonTraceWarshall.TabIndex = 8;
            this.buttonTraceWarshall.Text = "F-W";
            this.buttonTraceWarshall.UseVisualStyleBackColor = true;
            this.buttonTraceWarshall.Click += new System.EventHandler(this.buttonTraceWarshall_Click);
            // 
            // buttonTraceEIGRP
            // 
            this.buttonTraceEIGRP.Location = new System.Drawing.Point(168, 585);
            this.buttonTraceEIGRP.Name = "buttonTraceEIGRP";
            this.buttonTraceEIGRP.Size = new System.Drawing.Size(75, 41);
            this.buttonTraceEIGRP.TabIndex = 7;
            this.buttonTraceEIGRP.Text = "IGRP";
            this.buttonTraceEIGRP.UseVisualStyleBackColor = true;
            this.buttonTraceEIGRP.Click += new System.EventHandler(this.buttonTraceEIGRP_Click);
            // 
            // buttonTraceOSPF
            // 
            this.buttonTraceOSPF.Location = new System.Drawing.Point(87, 585);
            this.buttonTraceOSPF.Name = "buttonTraceOSPF";
            this.buttonTraceOSPF.Size = new System.Drawing.Size(75, 41);
            this.buttonTraceOSPF.TabIndex = 6;
            this.buttonTraceOSPF.Text = "OSPF";
            this.buttonTraceOSPF.UseVisualStyleBackColor = true;
            this.buttonTraceOSPF.Click += new System.EventHandler(this.buttonTraceOSPF_Click);
            // 
            // buttonTraceRIP
            // 
            this.buttonTraceRIP.Location = new System.Drawing.Point(6, 585);
            this.buttonTraceRIP.Name = "buttonTraceRIP";
            this.buttonTraceRIP.Size = new System.Drawing.Size(75, 41);
            this.buttonTraceRIP.TabIndex = 5;
            this.buttonTraceRIP.Text = "RIP";
            this.buttonTraceRIP.UseVisualStyleBackColor = true;
            this.buttonTraceRIP.Click += new System.EventHandler(this.buttonTraceRIP_Click);
            // 
            // labelShowTrace
            // 
            this.labelShowTrace.AutoSize = true;
            this.labelShowTrace.Location = new System.Drawing.Point(23, 557);
            this.labelShowTrace.Name = "labelShowTrace";
            this.labelShowTrace.Size = new System.Drawing.Size(134, 22);
            this.labelShowTrace.TabIndex = 4;
            this.labelShowTrace.Text = "Show route for:";
            // 
            // labelTimeDijkstra
            // 
            this.labelTimeDijkstra.AutoSize = true;
            this.labelTimeDijkstra.Location = new System.Drawing.Point(32, 218);
            this.labelTimeDijkstra.Name = "labelTimeDijkstra";
            this.labelTimeDijkstra.Size = new System.Drawing.Size(74, 22);
            this.labelTimeDijkstra.TabIndex = 3;
            this.labelTimeDijkstra.Text = "Dijkstra";
            // 
            // labelTimeBellman
            // 
            this.labelTimeBellman.AutoSize = true;
            this.labelTimeBellman.Location = new System.Drawing.Point(33, 245);
            this.labelTimeBellman.Name = "labelTimeBellman";
            this.labelTimeBellman.Size = new System.Drawing.Size(76, 22);
            this.labelTimeBellman.TabIndex = 2;
            this.labelTimeBellman.Text = "Bellman";
            // 
            // labelTimeWarshall
            // 
            this.labelTimeWarshall.AutoSize = true;
            this.labelTimeWarshall.Location = new System.Drawing.Point(32, 268);
            this.labelTimeWarshall.Name = "labelTimeWarshall";
            this.labelTimeWarshall.Size = new System.Drawing.Size(80, 22);
            this.labelTimeWarshall.TabIndex = 1;
            this.labelTimeWarshall.Text = "Warshall";
            // 
            // labelInformationsTimes
            // 
            this.labelInformationsTimes.AutoSize = true;
            this.labelInformationsTimes.Location = new System.Drawing.Point(13, 170);
            this.labelInformationsTimes.Name = "labelInformationsTimes";
            this.labelInformationsTimes.Size = new System.Drawing.Size(256, 22);
            this.labelInformationsTimes.TabIndex = 0;
            this.labelInformationsTimes.Text = "Time of calculating algorithms:";
            // 
            // labelSelectRandomDelay
            // 
            this.labelSelectRandomDelay.AutoSize = true;
            this.labelSelectRandomDelay.Location = new System.Drawing.Point(26, 83);
            this.labelSelectRandomDelay.Name = "labelSelectRandomDelay";
            this.labelSelectRandomDelay.Size = new System.Drawing.Size(63, 22);
            this.labelSelectRandomDelay.TabIndex = 22;
            this.labelSelectRandomDelay.Text = "Delay:";
            // 
            // textBoxRandomDelayMin
            // 
            this.textBoxRandomDelayMin.Location = new System.Drawing.Point(123, 75);
            this.textBoxRandomDelayMin.Name = "textBoxRandomDelayMin";
            this.textBoxRandomDelayMin.Size = new System.Drawing.Size(74, 30);
            this.textBoxRandomDelayMin.TabIndex = 23;
            this.textBoxRandomDelayMin.Text = "5";
            // 
            // textBoxRandomDelayMax
            // 
            this.textBoxRandomDelayMax.Location = new System.Drawing.Point(228, 77);
            this.textBoxRandomDelayMax.Name = "textBoxRandomDelayMax";
            this.textBoxRandomDelayMax.Size = new System.Drawing.Size(70, 30);
            this.textBoxRandomDelayMax.TabIndex = 24;
            this.textBoxRandomDelayMax.Text = "10";
            // 
            // labelDelayRange
            // 
            this.labelDelayRange.AutoSize = true;
            this.labelDelayRange.Location = new System.Drawing.Point(197, 78);
            this.labelDelayRange.Name = "labelDelayRange";
            this.labelDelayRange.Size = new System.Drawing.Size(25, 22);
            this.labelDelayRange.TabIndex = 25;
            this.labelDelayRange.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "[Mbps]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "[0.01ms]";
            // 
            // buttonSetNewParameters
            // 
            this.buttonSetNewParameters.Location = new System.Drawing.Point(197, 279);
            this.buttonSetNewParameters.Name = "buttonSetNewParameters";
            this.buttonSetNewParameters.Size = new System.Drawing.Size(188, 49);
            this.buttonSetNewParameters.TabIndex = 28;
            this.buttonSetNewParameters.Text = "Overwrite Params";
            this.buttonSetNewParameters.UseVisualStyleBackColor = true;
            this.buttonSetNewParameters.Click += new System.EventHandler(this.buttonSetNewParameters_Click);
            // 
            // checkBoxCreateCSV
            // 
            this.checkBoxCreateCSV.AutoSize = true;
            this.checkBoxCreateCSV.Checked = true;
            this.checkBoxCreateCSV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateCSV.Location = new System.Drawing.Point(223, 26);
            this.checkBoxCreateCSV.Name = "checkBoxCreateCSV";
            this.checkBoxCreateCSV.Size = new System.Drawing.Size(116, 26);
            this.checkBoxCreateCSV.TabIndex = 14;
            this.checkBoxCreateCSV.Text = "Create csv";
            this.checkBoxCreateCSV.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1511, 803);
            this.Controls.Add(this.groupBoxSimulationInformations);
            this.Controls.Add(this.buttonLoadConnections);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.chartRouts);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartRouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.groupBoxSimulationInformations.ResumeLayout(false);
            this.groupBoxSimulationInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.CheckBox checkBoxProtocolRIP;
        private System.Windows.Forms.CheckBox checkBoxProtocolOSPF;
        private System.Windows.Forms.CheckBox checkBoxProtocolIGRP;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.TrackBar trackBarMaxPath;
        private System.Windows.Forms.Label labelMaxPathValue;
        private System.Windows.Forms.Label labelSelectMaxPath;
        private System.Windows.Forms.Label labelMaxRouters;
        private System.Windows.Forms.Button buttonGenerateMap;
        private System.Windows.Forms.GroupBox groupBoxGenerate;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.Button buttonSimulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRouts;
        public System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.GroupBox groupBoxGenerateRandom;
        private System.Windows.Forms.Button buttonLoadConnections;
        private System.Windows.Forms.Button buttonEditor;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.Label labelBandwidthRange;
        private System.Windows.Forms.Button buttonShowGenerator;
        private System.Windows.Forms.TrackBar trackBarRandomRoutersNumber;
        private System.Windows.Forms.Label labelRouterNumberValue;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadFile;
        private System.Windows.Forms.GroupBox groupBoxSimulationInformations;
        private System.Windows.Forms.Label labelDestinationRouter;
        private System.Windows.Forms.Label labelSourceRouter;
        private System.Windows.Forms.TextBox textBoxDestinationRouter;
        private System.Windows.Forms.TextBox textBoxSourceRouter;
        private System.Windows.Forms.Label labelTimeDijkstra;
        private System.Windows.Forms.Label labelTimeBellman;
        private System.Windows.Forms.Label labelTimeWarshall;
        private System.Windows.Forms.Label labelInformationsTimes;
        private System.Windows.Forms.Button buttonChartWarshall;
        private System.Windows.Forms.Button buttonChartEIGP;
        private System.Windows.Forms.Button buttonChartOSPF;
        private System.Windows.Forms.Button buttonChartRIP;
        private System.Windows.Forms.Label labelShowChart;
        private System.Windows.Forms.Button buttonTraceWarshall;
        private System.Windows.Forms.Button buttonTraceEIGRP;
        private System.Windows.Forms.Button buttonTraceOSPF;
        private System.Windows.Forms.Button buttonTraceRIP;
        private System.Windows.Forms.Label labelShowTrace;
        private System.Windows.Forms.CheckBox checkBoxWarshall;
        private System.Windows.Forms.Label labelTimeBFSData;
        private System.Windows.Forms.Label labelTimeDijkstraData;
        private System.Windows.Forms.Label labelTimeBellmanData;
        private System.Windows.Forms.Label labelTimeWarshallData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTimeBFS;
        private System.Windows.Forms.Label labelTimeBFSSummary;
        private System.Windows.Forms.Label labelTimeDijkstraSummary;
        private System.Windows.Forms.Label labelTimeBellmanSummary;
        private System.Windows.Forms.Label labelTimeWarshallSummary;
        private System.Windows.Forms.Label labelTimeSummary;
        private System.Windows.Forms.TextBox textBoxMaximalBandWidth;
        private System.Windows.Forms.TextBox textBoxMinimalBandWidth;
        private System.Windows.Forms.Label labelSelectedRoute;
        private System.Windows.Forms.TextBox textBoxShowRoute;
        private System.Windows.Forms.Button buttonTestAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDelayRange;
        private System.Windows.Forms.TextBox textBoxRandomDelayMax;
        private System.Windows.Forms.TextBox textBoxRandomDelayMin;
        private System.Windows.Forms.Label labelSelectRandomDelay;
        private System.Windows.Forms.Button buttonSetNewParameters;
        private System.Windows.Forms.CheckBox checkBoxCreateCSV;
    }
}

