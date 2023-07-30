namespace BrainLinkConnect
{
    partial class HRVForm
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
            this.hrvBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hrvBox
            // 
            this.hrvBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.hrvBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hrvBox.Location = new System.Drawing.Point(11, 11);
            this.hrvBox.Margin = new System.Windows.Forms.Padding(2);
            this.hrvBox.Multiline = true;
            this.hrvBox.Name = "hrvBox";
            this.hrvBox.Size = new System.Drawing.Size(283, 145);
            this.hrvBox.TabIndex = 40;
            // 
            // HRVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(302, 162);
            this.Controls.Add(this.hrvBox);
            this.Name = "HRVForm";
            this.Text = "HRVForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hrvBox;
    }
}