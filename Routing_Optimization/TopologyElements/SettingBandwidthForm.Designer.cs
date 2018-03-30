namespace Routing_Optimization.TopologyElements
{
    partial class SettingBandwidthForm
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
            this.buttonSetBandwidthApply = new System.Windows.Forms.Button();
            this.radioButtonSetBandwidthStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonSetBandwidthType = new System.Windows.Forms.RadioButton();
            this.buttonSetBandwidthRefuse = new System.Windows.Forms.Button();
            this.comboBoxSetBandwidthStandard = new System.Windows.Forms.ComboBox();
            this.textBoxSetBandwidthType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSetBandwidthApply
            // 
            this.buttonSetBandwidthApply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetBandwidthApply.Location = new System.Drawing.Point(12, 221);
            this.buttonSetBandwidthApply.Name = "buttonSetBandwidthApply";
            this.buttonSetBandwidthApply.Size = new System.Drawing.Size(328, 43);
            this.buttonSetBandwidthApply.TabIndex = 0;
            this.buttonSetBandwidthApply.Text = "Zatwierdź";
            this.buttonSetBandwidthApply.UseVisualStyleBackColor = true;
            this.buttonSetBandwidthApply.Click += new System.EventHandler(this.buttonSetBandwidthApply_Click);
            // 
            // radioButtonSetBandwidthStandard
            // 
            this.radioButtonSetBandwidthStandard.AutoSize = true;
            this.radioButtonSetBandwidthStandard.Checked = true;
            this.radioButtonSetBandwidthStandard.Location = new System.Drawing.Point(32, 64);
            this.radioButtonSetBandwidthStandard.Name = "radioButtonSetBandwidthStandard";
            this.radioButtonSetBandwidthStandard.Size = new System.Drawing.Size(124, 21);
            this.radioButtonSetBandwidthStandard.TabIndex = 1;
            this.radioButtonSetBandwidthStandard.TabStop = true;
            this.radioButtonSetBandwidthStandard.Text = "Użyj standardu";
            this.radioButtonSetBandwidthStandard.UseVisualStyleBackColor = true;
            // 
            // radioButtonSetBandwidthType
            // 
            this.radioButtonSetBandwidthType.AutoSize = true;
            this.radioButtonSetBandwidthType.Location = new System.Drawing.Point(32, 149);
            this.radioButtonSetBandwidthType.Name = "radioButtonSetBandwidthType";
            this.radioButtonSetBandwidthType.Size = new System.Drawing.Size(165, 21);
            this.radioButtonSetBandwidthType.TabIndex = 2;
            this.radioButtonSetBandwidthType.Text = "Wpisz wartość [Mbps]";
            this.radioButtonSetBandwidthType.UseVisualStyleBackColor = true;
            // 
            // buttonSetBandwidthRefuse
            // 
            this.buttonSetBandwidthRefuse.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetBandwidthRefuse.ForeColor = System.Drawing.Color.Red;
            this.buttonSetBandwidthRefuse.Location = new System.Drawing.Point(12, 12);
            this.buttonSetBandwidthRefuse.Name = "buttonSetBandwidthRefuse";
            this.buttonSetBandwidthRefuse.Size = new System.Drawing.Size(88, 36);
            this.buttonSetBandwidthRefuse.TabIndex = 3;
            this.buttonSetBandwidthRefuse.Text = "<<< Porzuć";
            this.buttonSetBandwidthRefuse.UseVisualStyleBackColor = true;
            this.buttonSetBandwidthRefuse.Click += new System.EventHandler(this.buttonSetBandwidthRefuse_Click);
            // 
            // comboBoxSetBandwidthStandard
            // 
            this.comboBoxSetBandwidthStandard.FormattingEnabled = true;
            this.comboBoxSetBandwidthStandard.Location = new System.Drawing.Point(54, 91);
            this.comboBoxSetBandwidthStandard.Name = "comboBoxSetBandwidthStandard";
            this.comboBoxSetBandwidthStandard.Size = new System.Drawing.Size(168, 24);
            this.comboBoxSetBandwidthStandard.TabIndex = 4;
            // 
            // textBoxSetBandwidthType
            // 
            this.textBoxSetBandwidthType.Location = new System.Drawing.Point(54, 176);
            this.textBoxSetBandwidthType.Name = "textBoxSetBandwidthType";
            this.textBoxSetBandwidthType.Size = new System.Drawing.Size(168, 22);
            this.textBoxSetBandwidthType.TabIndex = 5;
            // 
            // SettingBandwidthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(352, 276);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSetBandwidthType);
            this.Controls.Add(this.comboBoxSetBandwidthStandard);
            this.Controls.Add(this.buttonSetBandwidthRefuse);
            this.Controls.Add(this.radioButtonSetBandwidthType);
            this.Controls.Add(this.radioButtonSetBandwidthStandard);
            this.Controls.Add(this.buttonSetBandwidthApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingBandwidthForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SettingBandwidthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetBandwidthApply;
        private System.Windows.Forms.RadioButton radioButtonSetBandwidthStandard;
        private System.Windows.Forms.RadioButton radioButtonSetBandwidthType;
        private System.Windows.Forms.Button buttonSetBandwidthRefuse;
        private System.Windows.Forms.ComboBox comboBoxSetBandwidthStandard;
        private System.Windows.Forms.TextBox textBoxSetBandwidthType;
    }
}