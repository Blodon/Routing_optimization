namespace Routing_Optimization
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.InfoLabelTopic = new System.Windows.Forms.Label();
            this.InfoLabelSubject = new System.Windows.Forms.Label();
            this.InfoLabelAutors = new System.Windows.Forms.Label();
            this.InfoButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabelTopic
            // 
            resources.ApplyResources(this.InfoLabelTopic, "InfoLabelTopic");
            this.InfoLabelTopic.Name = "InfoLabelTopic";
            // 
            // InfoLabelSubject
            // 
            resources.ApplyResources(this.InfoLabelSubject, "InfoLabelSubject");
            this.InfoLabelSubject.Name = "InfoLabelSubject";
            // 
            // InfoLabelAutors
            // 
            resources.ApplyResources(this.InfoLabelAutors, "InfoLabelAutors");
            this.InfoLabelAutors.Name = "InfoLabelAutors";
            // 
            // InfoButtonExit
            // 
            resources.ApplyResources(this.InfoButtonExit, "InfoButtonExit");
            this.InfoButtonExit.Name = "InfoButtonExit";
            this.InfoButtonExit.UseVisualStyleBackColor = true;
            this.InfoButtonExit.Click += new System.EventHandler(this.InfoButtonExit_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.InfoButtonExit);
            this.Controls.Add(this.InfoLabelAutors);
            this.Controls.Add(this.InfoLabelSubject);
            this.Controls.Add(this.InfoLabelTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabelTopic;
        private System.Windows.Forms.Label InfoLabelSubject;
        private System.Windows.Forms.Label InfoLabelAutors;
        private System.Windows.Forms.Button InfoButtonExit;
    }
}