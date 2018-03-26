namespace Routing_Optimization
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopologyEditorMap)).BeginInit();
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
            // TopologyEditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1582, 853);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopologyEditorMap)).EndInit();
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
    }
}