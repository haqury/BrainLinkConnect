namespace BrainLinkConnect
{
    partial class GyroForm
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.zvalue = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.yvalue = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.xvalue = new System.Windows.Forms.Label();
            this.GyroBase = new System.Windows.Forms.Button();
            this.UseGyro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBox2.Location = new System.Drawing.Point(14, 17);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 17);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "X:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // zvalue
            // 
            this.zvalue.AutoSize = true;
            this.zvalue.ForeColor = System.Drawing.Color.GreenYellow;
            this.zvalue.Location = new System.Drawing.Point(134, 18);
            this.zvalue.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.zvalue.Name = "zvalue";
            this.zvalue.Size = new System.Drawing.Size(13, 13);
            this.zvalue.TabIndex = 47;
            this.zvalue.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.GreenYellow;
            this.label36.Location = new System.Drawing.Point(112, 18);
            this.label36.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 13);
            this.label36.TabIndex = 46;
            this.label36.Text = "Z:";
            // 
            // yvalue
            // 
            this.yvalue.AutoSize = true;
            this.yvalue.ForeColor = System.Drawing.Color.GreenYellow;
            this.yvalue.Location = new System.Drawing.Point(95, 18);
            this.yvalue.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.yvalue.Name = "yvalue";
            this.yvalue.Size = new System.Drawing.Size(13, 13);
            this.yvalue.TabIndex = 45;
            this.yvalue.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.GreenYellow;
            this.label34.Location = new System.Drawing.Point(73, 18);
            this.label34.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Y:";
            // 
            // xvalue
            // 
            this.xvalue.AutoSize = true;
            this.xvalue.ForeColor = System.Drawing.Color.GreenYellow;
            this.xvalue.Location = new System.Drawing.Point(54, 18);
            this.xvalue.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.xvalue.Name = "xvalue";
            this.xvalue.Size = new System.Drawing.Size(13, 13);
            this.xvalue.TabIndex = 43;
            this.xvalue.Text = "0";
            // 
            // GyroBase
            // 
            this.GyroBase.ForeColor = System.Drawing.Color.Black;
            this.GyroBase.Location = new System.Drawing.Point(89, 43);
            this.GyroBase.Name = "GyroBase";
            this.GyroBase.Size = new System.Drawing.Size(49, 19);
            this.GyroBase.TabIndex = 96;
            this.GyroBase.Text = "Gyro";
            this.GyroBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GyroBase.UseVisualStyleBackColor = true;
            this.GyroBase.Click += new System.EventHandler(this.GyroBase_Click);
            // 
            // UseGyro
            // 
            this.UseGyro.AutoSize = true;
            this.UseGyro.ForeColor = System.Drawing.Color.GreenYellow;
            this.UseGyro.Location = new System.Drawing.Point(17, 43);
            this.UseGyro.Name = "UseGyro";
            this.UseGyro.Size = new System.Drawing.Size(66, 17);
            this.UseGyro.TabIndex = 95;
            this.UseGyro.Text = "use gyro";
            this.UseGyro.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UseGyro.UseVisualStyleBackColor = true;
            // 
            // GyroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(191, 85);
            this.Controls.Add(this.GyroBase);
            this.Controls.Add(this.UseGyro);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.zvalue);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.yvalue);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.xvalue);
            this.Name = "GyroForm";
            this.Text = "GyroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label zvalue;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label yvalue;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label xvalue;
        private System.Windows.Forms.Button GyroBase;
        public System.Windows.Forms.CheckBox UseGyro;
    }
}