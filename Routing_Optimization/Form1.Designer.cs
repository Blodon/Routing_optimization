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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSelectMaxPath = new System.Windows.Forms.Label();
            this.labelMaxRouters = new System.Windows.Forms.Label();
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.groupBoxGenerate = new System.Windows.Forms.GroupBox();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPath)).BeginInit();
            this.groupBoxGenerate.SuspendLayout();
            this.groupBoxSimulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(667, 43);
            this.Title.TabIndex = 0;
            this.Title.Text = "Optymalizacja trasy w ruchu sieciowym";
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InfoButton.FlatAppearance.BorderSize = 2;
            this.InfoButton.Location = new System.Drawing.Point(20, 95);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(120, 34);
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
            this.trackBarMaxPath.Location = new System.Drawing.Point(20, 226);
            this.trackBarMaxPath.Maximum = 8;
            this.trackBarMaxPath.Minimum = 1;
            this.trackBarMaxPath.Name = "trackBarMaxPath";
            this.trackBarMaxPath.Size = new System.Drawing.Size(284, 56);
            this.trackBarMaxPath.TabIndex = 7;
            this.trackBarMaxPath.Value = 4;
            this.trackBarMaxPath.ValueChanged += new System.EventHandler(this.trackBarMaxPath_ValueChanged);
            // 
            // labelMaxPathValue
            // 
            this.labelMaxPathValue.AutoSize = true;
            this.labelMaxPathValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPathValue.Location = new System.Drawing.Point(310, 226);
            this.labelMaxPathValue.Name = "labelMaxPathValue";
            this.labelMaxPathValue.Size = new System.Drawing.Size(0, 23);
            this.labelMaxPathValue.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.listBox1.Location = new System.Drawing.Point(22, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 26);
            this.listBox1.TabIndex = 9;
            // 
            // labelSelectMaxPath
            // 
            this.labelSelectMaxPath.AutoSize = true;
            this.labelSelectMaxPath.Location = new System.Drawing.Point(16, 201);
            this.labelSelectMaxPath.Name = "labelSelectMaxPath";
            this.labelSelectMaxPath.Size = new System.Drawing.Size(251, 22);
            this.labelSelectMaxPath.TabIndex = 10;
            this.labelSelectMaxPath.Text = "Wybierz maks. ilość połączeń:";
            // 
            // labelMaxRouters
            // 
            this.labelMaxRouters.AutoSize = true;
            this.labelMaxRouters.Location = new System.Drawing.Point(16, 102);
            this.labelMaxRouters.Name = "labelMaxRouters";
            this.labelMaxRouters.Size = new System.Drawing.Size(203, 22);
            this.labelMaxRouters.TabIndex = 11;
            this.labelMaxRouters.Text = "Wybierz ilość routerów:";
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Location = new System.Drawing.Point(6, 283);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(350, 50);
            this.buttonGenerateMap.TabIndex = 12;
            this.buttonGenerateMap.Text = "Generuj połączenia";
            this.buttonGenerateMap.UseVisualStyleBackColor = true;
            this.buttonGenerateMap.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // groupBoxGenerate
            // 
            this.groupBoxGenerate.Controls.Add(this.buttonGenerateMap);
            this.groupBoxGenerate.Controls.Add(this.labelMaxRouters);
            this.groupBoxGenerate.Controls.Add(this.labelSelectMaxPath);
            this.groupBoxGenerate.Controls.Add(this.listBox1);
            this.groupBoxGenerate.Controls.Add(this.labelMaxPathValue);
            this.groupBoxGenerate.Controls.Add(this.trackBarMaxPath);
            this.groupBoxGenerate.Location = new System.Drawing.Point(15, 138);
            this.groupBoxGenerate.Name = "groupBoxGenerate";
            this.groupBoxGenerate.Size = new System.Drawing.Size(361, 340);
            this.groupBoxGenerate.TabIndex = 13;
            this.groupBoxGenerate.TabStop = false;
            this.groupBoxGenerate.Text = "Generator połączń";
            this.groupBoxGenerate.Enter += new System.EventHandler(this.groupBoxGenerate_Enter);
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.buttonSimulation);
            this.groupBoxSimulation.Controls.Add(this.labelProtocol);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolEIGRP);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolISIS);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolOSPF);
            this.groupBoxSimulation.Controls.Add(this.checkBoxProtocolRIP);
            this.groupBoxSimulation.Location = new System.Drawing.Point(12, 484);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(363, 278);
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
            this.buttonSimulation.Size = new System.Drawing.Size(350, 50);
            this.buttonSimulation.TabIndex = 7;
            this.buttonSimulation.Text = "Przeporowadź symulację";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1511, 803);
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
            this.groupBoxGenerate.PerformLayout();
            this.groupBoxSimulation.ResumeLayout(false);
            this.groupBoxSimulation.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSelectMaxPath;
        private System.Windows.Forms.Label labelMaxRouters;
        private System.Windows.Forms.Button buttonGenerateMap;
        private System.Windows.Forms.GroupBox groupBoxGenerate;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.Button buttonSimulation;
    }
}

