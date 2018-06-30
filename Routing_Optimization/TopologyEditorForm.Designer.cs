﻿namespace Routing_Optimization
{
    partial class TopologyEditorForm
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
            this.labelTopologyEditor = new System.Windows.Forms.Label();
            this.pictureBoxTopologyEditorMap = new System.Windows.Forms.PictureBox();
            this.labelMousePositionX = new System.Windows.Forms.Label();
            this.labelMousePositionXValue = new System.Windows.Forms.Label();
            this.labelMousePositionY = new System.Windows.Forms.Label();
            this.labelMousePositionYValue = new System.Windows.Forms.Label();
            this.buttonAddRouter = new System.Windows.Forms.Button();
            this.buttonSetLink = new System.Windows.Forms.Button();
            this.buttonShowInfos = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonReady = new System.Windows.Forms.Button();
            this.labelRouterInfos = new System.Windows.Forms.Label();
            this.buttonTopologyReset = new System.Windows.Forms.Button();
            this.groupBoxInformations = new System.Windows.Forms.GroupBox();
            this.labelTopologyAllInfos = new System.Windows.Forms.Label();
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxSameBandwidth = new System.Windows.Forms.CheckBox();
            this.groupBoxBandWidth = new System.Windows.Forms.GroupBox();
            this.textBoxTypeBandwidth = new System.Windows.Forms.TextBox();
            this.buttonLoadTopology = new System.Windows.Forms.Button();
            this.openFileDialogLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.labelAutoBandwidth = new System.Windows.Forms.Label();
            this.labelAutoDelay = new System.Windows.Forms.Label();
            this.textBoxTypeDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopologyEditorMap)).BeginInit();
            this.groupBoxInformations.SuspendLayout();
            this.groupBoxBandWidth.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTopologyEditor
            // 
            this.labelTopologyEditor.AutoSize = true;
            this.labelTopologyEditor.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopologyEditor.Location = new System.Drawing.Point(12, 9);
            this.labelTopologyEditor.Name = "labelTopologyEditor";
            this.labelTopologyEditor.Size = new System.Drawing.Size(292, 45);
            this.labelTopologyEditor.TabIndex = 0;
            this.labelTopologyEditor.Text = "Edytor topologii";
            // 
            // pictureBoxTopologyEditorMap
            // 
            this.pictureBoxTopologyEditorMap.BackColor = System.Drawing.Color.White;
            this.pictureBoxTopologyEditorMap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxTopologyEditorMap.Location = new System.Drawing.Point(550, 100);
            this.pictureBoxTopologyEditorMap.Name = "pictureBoxTopologyEditorMap";
            this.pictureBoxTopologyEditorMap.Size = new System.Drawing.Size(1000, 700);
            this.pictureBoxTopologyEditorMap.TabIndex = 1;
            this.pictureBoxTopologyEditorMap.TabStop = false;
            this.pictureBoxTopologyEditorMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTopologyEditorMap_MouseClick);
            this.pictureBoxTopologyEditorMap.MouseHover += new System.EventHandler(this.pictureBoxTopologyEditorMap_MouseHover);
            this.pictureBoxTopologyEditorMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTopologyEditorMap_MouseMove);
            // 
            // labelMousePositionX
            // 
            this.labelMousePositionX.AutoSize = true;
            this.labelMousePositionX.Location = new System.Drawing.Point(1333, 813);
            this.labelMousePositionX.Name = "labelMousePositionX";
            this.labelMousePositionX.Size = new System.Drawing.Size(30, 22);
            this.labelMousePositionX.TabIndex = 2;
            this.labelMousePositionX.Text = "X:";
            // 
            // labelMousePositionXValue
            // 
            this.labelMousePositionXValue.AutoSize = true;
            this.labelMousePositionXValue.Location = new System.Drawing.Point(1360, 813);
            this.labelMousePositionXValue.Name = "labelMousePositionXValue";
            this.labelMousePositionXValue.Size = new System.Drawing.Size(0, 22);
            this.labelMousePositionXValue.TabIndex = 3;
            // 
            // labelMousePositionY
            // 
            this.labelMousePositionY.AutoSize = true;
            this.labelMousePositionY.Location = new System.Drawing.Point(1417, 813);
            this.labelMousePositionY.Name = "labelMousePositionY";
            this.labelMousePositionY.Size = new System.Drawing.Size(28, 22);
            this.labelMousePositionY.TabIndex = 4;
            this.labelMousePositionY.Text = "Y:";
            // 
            // labelMousePositionYValue
            // 
            this.labelMousePositionYValue.AutoSize = true;
            this.labelMousePositionYValue.Location = new System.Drawing.Point(1441, 813);
            this.labelMousePositionYValue.Name = "labelMousePositionYValue";
            this.labelMousePositionYValue.Size = new System.Drawing.Size(0, 22);
            this.labelMousePositionYValue.TabIndex = 5;
            // 
            // buttonAddRouter
            // 
            this.buttonAddRouter.Location = new System.Drawing.Point(550, 54);
            this.buttonAddRouter.Name = "buttonAddRouter";
            this.buttonAddRouter.Size = new System.Drawing.Size(166, 40);
            this.buttonAddRouter.TabIndex = 6;
            this.buttonAddRouter.Text = "Dodaj router";
            this.buttonAddRouter.UseVisualStyleBackColor = true;
            this.buttonAddRouter.Click += new System.EventHandler(this.buttonAddRouter_Click);
            // 
            // buttonSetLink
            // 
            this.buttonSetLink.Location = new System.Drawing.Point(722, 54);
            this.buttonSetLink.Name = "buttonSetLink";
            this.buttonSetLink.Size = new System.Drawing.Size(166, 40);
            this.buttonSetLink.TabIndex = 7;
            this.buttonSetLink.Text = "Połączenie";
            this.buttonSetLink.UseVisualStyleBackColor = true;
            this.buttonSetLink.Click += new System.EventHandler(this.buttonSetLink_Click);
            // 
            // buttonShowInfos
            // 
            this.buttonShowInfos.Location = new System.Drawing.Point(894, 54);
            this.buttonShowInfos.Name = "buttonShowInfos";
            this.buttonShowInfos.Size = new System.Drawing.Size(166, 40);
            this.buttonShowInfos.TabIndex = 8;
            this.buttonShowInfos.Text = "Pokaż informacje";
            this.buttonShowInfos.UseVisualStyleBackColor = true;
            this.buttonShowInfos.Click += new System.EventHandler(this.buttonShowInfos_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.labelErrorMessage.Location = new System.Drawing.Point(555, 800);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 32);
            this.labelErrorMessage.TabIndex = 9;
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(50, 746);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(454, 54);
            this.buttonReady.TabIndex = 10;
            this.buttonReady.Text = "Gotowe";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // labelRouterInfos
            // 
            this.labelRouterInfos.AutoSize = true;
            this.labelRouterInfos.Location = new System.Drawing.Point(6, 137);
            this.labelRouterInfos.Name = "labelRouterInfos";
            this.labelRouterInfos.Size = new System.Drawing.Size(41, 22);
            this.labelRouterInfos.TabIndex = 11;
            this.labelRouterInfos.Text = "info";
            // 
            // buttonTopologyReset
            // 
            this.buttonTopologyReset.ForeColor = System.Drawing.Color.Red;
            this.buttonTopologyReset.Location = new System.Drawing.Point(1384, 54);
            this.buttonTopologyReset.Name = "buttonTopologyReset";
            this.buttonTopologyReset.Size = new System.Drawing.Size(166, 40);
            this.buttonTopologyReset.TabIndex = 12;
            this.buttonTopologyReset.Text = "Resetuj";
            this.buttonTopologyReset.UseVisualStyleBackColor = true;
            this.buttonTopologyReset.Click += new System.EventHandler(this.buttonTopologyReset_Click);
            // 
            // groupBoxInformations
            // 
            this.groupBoxInformations.Controls.Add(this.labelTopologyAllInfos);
            this.groupBoxInformations.Controls.Add(this.labelRouterInfos);
            this.groupBoxInformations.Location = new System.Drawing.Point(12, 100);
            this.groupBoxInformations.Name = "groupBoxInformations";
            this.groupBoxInformations.Size = new System.Drawing.Size(292, 318);
            this.groupBoxInformations.TabIndex = 13;
            this.groupBoxInformations.TabStop = false;
            this.groupBoxInformations.Text = "Informacje";
            // 
            // labelTopologyAllInfos
            // 
            this.labelTopologyAllInfos.AutoSize = true;
            this.labelTopologyAllInfos.Location = new System.Drawing.Point(6, 26);
            this.labelTopologyAllInfos.Name = "labelTopologyAllInfos";
            this.labelTopologyAllInfos.Size = new System.Drawing.Size(49, 22);
            this.labelTopologyAllInfos.TabIndex = 12;
            this.labelTopologyAllInfos.Text = "infos";
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Location = new System.Drawing.Point(1066, 54);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(166, 40);
            this.buttonCheckConnection.TabIndex = 14;
            this.buttonCheckConnection.Text = "Czy połączone";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.buttonCheckConnection_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(310, 107);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(232, 61);
            this.buttonSaveFile.TabIndex = 15;
            this.buttonSaveFile.Text = "Zapisz konfigurację";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // saveFileDialogSaveFile
            // 
            this.saveFileDialogSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogSaveFile_FileOk);
            // 
            // checkBoxSameBandwidth
            // 
            this.checkBoxSameBandwidth.AutoSize = true;
            this.checkBoxSameBandwidth.Location = new System.Drawing.Point(10, 29);
            this.checkBoxSameBandwidth.Name = "checkBoxSameBandwidth";
            this.checkBoxSameBandwidth.Size = new System.Drawing.Size(232, 26);
            this.checkBoxSameBandwidth.TabIndex = 16;
            this.checkBoxSameBandwidth.Text = "Automatyczne ustawianie";
            this.checkBoxSameBandwidth.UseVisualStyleBackColor = true;
            // 
            // groupBoxBandWidth
            // 
            this.groupBoxBandWidth.Controls.Add(this.label2);
            this.groupBoxBandWidth.Controls.Add(this.label1);
            this.groupBoxBandWidth.Controls.Add(this.textBoxTypeDelay);
            this.groupBoxBandWidth.Controls.Add(this.labelAutoDelay);
            this.groupBoxBandWidth.Controls.Add(this.labelAutoBandwidth);
            this.groupBoxBandWidth.Controls.Add(this.textBoxTypeBandwidth);
            this.groupBoxBandWidth.Controls.Add(this.checkBoxSameBandwidth);
            this.groupBoxBandWidth.Location = new System.Drawing.Point(12, 434);
            this.groupBoxBandWidth.Name = "groupBoxBandWidth";
            this.groupBoxBandWidth.Size = new System.Drawing.Size(291, 287);
            this.groupBoxBandWidth.TabIndex = 17;
            this.groupBoxBandWidth.TabStop = false;
            this.groupBoxBandWidth.Text = "Przepustowość";
            // 
            // textBoxTypeBandwidth
            // 
            this.textBoxTypeBandwidth.Location = new System.Drawing.Point(104, 72);
            this.textBoxTypeBandwidth.Name = "textBoxTypeBandwidth";
            this.textBoxTypeBandwidth.Size = new System.Drawing.Size(102, 30);
            this.textBoxTypeBandwidth.TabIndex = 17;
            this.textBoxTypeBandwidth.Text = "100";
            // 
            // buttonLoadTopology
            // 
            this.buttonLoadTopology.Location = new System.Drawing.Point(310, 174);
            this.buttonLoadTopology.Name = "buttonLoadTopology";
            this.buttonLoadTopology.Size = new System.Drawing.Size(232, 61);
            this.buttonLoadTopology.TabIndex = 18;
            this.buttonLoadTopology.Text = "Wczytaj konfigurację";
            this.buttonLoadTopology.UseVisualStyleBackColor = true;
            this.buttonLoadTopology.Click += new System.EventHandler(this.buttonLoadTopology_Click);
            // 
            // openFileDialogLoadFile
            // 
            this.openFileDialogLoadFile.FileName = "openFileDialogLoadFile";
            this.openFileDialogLoadFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogLoadFile_FileOk);
            // 
            // labelAutoBandwidth
            // 
            this.labelAutoBandwidth.AutoSize = true;
            this.labelAutoBandwidth.Location = new System.Drawing.Point(15, 75);
            this.labelAutoBandwidth.Name = "labelAutoBandwidth";
            this.labelAutoBandwidth.Size = new System.Drawing.Size(102, 22);
            this.labelAutoBandwidth.TabIndex = 18;
            this.labelAutoBandwidth.Text = "Bandwidth:";
            // 
            // labelAutoDelay
            // 
            this.labelAutoDelay.AutoSize = true;
            this.labelAutoDelay.Location = new System.Drawing.Point(15, 121);
            this.labelAutoDelay.Name = "labelAutoDelay";
            this.labelAutoDelay.Size = new System.Drawing.Size(63, 22);
            this.labelAutoDelay.TabIndex = 19;
            this.labelAutoDelay.Text = "Delay:";
            // 
            // textBoxTypeDelay
            // 
            this.textBoxTypeDelay.Location = new System.Drawing.Point(104, 117);
            this.textBoxTypeDelay.Name = "textBoxTypeDelay";
            this.textBoxTypeDelay.Size = new System.Drawing.Size(102, 30);
            this.textBoxTypeDelay.TabIndex = 20;
            this.textBoxTypeDelay.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "[Mbps]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "[0.01ms]";
            // 
            // TopologyEditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLoadTopology);
            this.Controls.Add(this.groupBoxBandWidth);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonCheckConnection);
            this.Controls.Add(this.groupBoxInformations);
            this.Controls.Add(this.buttonTopologyReset);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.buttonShowInfos);
            this.Controls.Add(this.buttonSetLink);
            this.Controls.Add(this.buttonAddRouter);
            this.Controls.Add(this.labelMousePositionYValue);
            this.Controls.Add(this.labelMousePositionY);
            this.Controls.Add(this.labelMousePositionXValue);
            this.Controls.Add(this.labelMousePositionX);
            this.Controls.Add(this.pictureBoxTopologyEditorMap);
            this.Controls.Add(this.labelTopologyEditor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopologyEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TopologyEditorForm_Load);
            this.Shown += new System.EventHandler(this.TopologyEditorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopologyEditorMap)).EndInit();
            this.groupBoxInformations.ResumeLayout(false);
            this.groupBoxInformations.PerformLayout();
            this.groupBoxBandWidth.ResumeLayout(false);
            this.groupBoxBandWidth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopologyEditor;
        private System.Windows.Forms.PictureBox pictureBoxTopologyEditorMap;
        private System.Windows.Forms.Label labelMousePositionX;
        private System.Windows.Forms.Label labelMousePositionXValue;
        private System.Windows.Forms.Label labelMousePositionY;
        private System.Windows.Forms.Label labelMousePositionYValue;
        private System.Windows.Forms.Button buttonAddRouter;
        private System.Windows.Forms.Button buttonSetLink;
        private System.Windows.Forms.Button buttonShowInfos;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Label labelRouterInfos;
        private System.Windows.Forms.Button buttonTopologyReset;
        private System.Windows.Forms.GroupBox groupBoxInformations;
        private System.Windows.Forms.Label labelTopologyAllInfos;
        private System.Windows.Forms.Button buttonCheckConnection;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveFile;
        private System.Windows.Forms.CheckBox checkBoxSameBandwidth;
        private System.Windows.Forms.GroupBox groupBoxBandWidth;
        private System.Windows.Forms.TextBox textBoxTypeBandwidth;
        private System.Windows.Forms.Button buttonLoadTopology;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTypeDelay;
        private System.Windows.Forms.Label labelAutoDelay;
        private System.Windows.Forms.Label labelAutoBandwidth;
    }
}