namespace ConfigBrainLinkForm
{
    partial class ConfigFaultForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadConfig = new System.Windows.Forms.Button();
            this.SaveConfig = new System.Windows.Forms.Button();
            this.textBoxHighGamma = new System.Windows.Forms.TextBox();
            this.textBoxLowGamma = new System.Windows.Forms.TextBox();
            this.textBoxHighBeta = new System.Windows.Forms.TextBox();
            this.textBoxLowBeta = new System.Windows.Forms.TextBox();
            this.textBoxHighAlpha = new System.Windows.Forms.TextBox();
            this.textBoxLowAlpha = new System.Windows.Forms.TextBox();
            this.textBoxMeditation = new System.Windows.Forms.TextBox();
            this.textBoxTheta = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxAttention = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.BrowseB = new System.Windows.Forms.Button();
            this.textBoxHighGammaX = new System.Windows.Forms.TextBox();
            this.textBoxLowGammaX = new System.Windows.Forms.TextBox();
            this.textBoxHighBetaX = new System.Windows.Forms.TextBox();
            this.textBoxLowBetaX = new System.Windows.Forms.TextBox();
            this.textBoxHighAlphaX = new System.Windows.Forms.TextBox();
            this.textBoxLowAlphaX = new System.Windows.Forms.TextBox();
            this.textBoxMeditationX = new System.Windows.Forms.TextBox();
            this.textBoxThetaX = new System.Windows.Forms.TextBox();
            this.textBoxDeltaX = new System.Windows.Forms.TextBox();
            this.textBoxAttentionX = new System.Windows.Forms.TextBox();
            this.textBoxMultiCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadConfig
            // 
            this.loadConfig.ForeColor = System.Drawing.Color.Black;
            this.loadConfig.Location = new System.Drawing.Point(122, 309);
            this.loadConfig.Margin = new System.Windows.Forms.Padding(1);
            this.loadConfig.Name = "loadConfig";
            this.loadConfig.Size = new System.Drawing.Size(94, 21);
            this.loadConfig.TabIndex = 159;
            this.loadConfig.Text = "load config";
            this.loadConfig.UseVisualStyleBackColor = true;
            this.loadConfig.Click += new System.EventHandler(this.loadConfig_Click);
            // 
            // SaveConfig
            // 
            this.SaveConfig.ForeColor = System.Drawing.Color.Black;
            this.SaveConfig.Location = new System.Drawing.Point(21, 309);
            this.SaveConfig.Margin = new System.Windows.Forms.Padding(1);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(94, 21);
            this.SaveConfig.TabIndex = 156;
            this.SaveConfig.Text = "save config";
            this.SaveConfig.UseVisualStyleBackColor = true;
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // textBoxHighGamma
            // 
            this.textBoxHighGamma.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighGamma.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighGamma.Location = new System.Drawing.Point(100, 281);
            this.textBoxHighGamma.Name = "textBoxHighGamma";
            this.textBoxHighGamma.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighGamma.TabIndex = 155;
            this.textBoxHighGamma.Text = "50";
            // 
            // textBoxLowGamma
            // 
            this.textBoxLowGamma.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowGamma.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowGamma.Location = new System.Drawing.Point(100, 254);
            this.textBoxLowGamma.Name = "textBoxLowGamma";
            this.textBoxLowGamma.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowGamma.TabIndex = 154;
            this.textBoxLowGamma.Text = "50";
            // 
            // textBoxHighBeta
            // 
            this.textBoxHighBeta.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighBeta.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighBeta.Location = new System.Drawing.Point(100, 228);
            this.textBoxHighBeta.Name = "textBoxHighBeta";
            this.textBoxHighBeta.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighBeta.TabIndex = 153;
            this.textBoxHighBeta.Text = "50";
            // 
            // textBoxLowBeta
            // 
            this.textBoxLowBeta.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowBeta.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowBeta.Location = new System.Drawing.Point(100, 202);
            this.textBoxLowBeta.Name = "textBoxLowBeta";
            this.textBoxLowBeta.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowBeta.TabIndex = 152;
            this.textBoxLowBeta.Text = "50";
            // 
            // textBoxHighAlpha
            // 
            this.textBoxHighAlpha.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighAlpha.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighAlpha.Location = new System.Drawing.Point(100, 177);
            this.textBoxHighAlpha.Name = "textBoxHighAlpha";
            this.textBoxHighAlpha.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighAlpha.TabIndex = 151;
            this.textBoxHighAlpha.Text = "50";
            // 
            // textBoxLowAlpha
            // 
            this.textBoxLowAlpha.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowAlpha.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowAlpha.Location = new System.Drawing.Point(99, 153);
            this.textBoxLowAlpha.Name = "textBoxLowAlpha";
            this.textBoxLowAlpha.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowAlpha.TabIndex = 150;
            this.textBoxLowAlpha.Text = "50";
            // 
            // textBoxMeditation
            // 
            this.textBoxMeditation.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMeditation.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxMeditation.Location = new System.Drawing.Point(99, 78);
            this.textBoxMeditation.Name = "textBoxMeditation";
            this.textBoxMeditation.Size = new System.Drawing.Size(52, 20);
            this.textBoxMeditation.TabIndex = 149;
            this.textBoxMeditation.Text = "10";
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxTheta.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxTheta.Location = new System.Drawing.Point(99, 127);
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(52, 20);
            this.textBoxTheta.TabIndex = 148;
            this.textBoxTheta.Text = "300";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxDelta.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxDelta.Location = new System.Drawing.Point(99, 104);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(52, 20);
            this.textBoxDelta.TabIndex = 147;
            this.textBoxDelta.Text = "300";
            // 
            // textBoxAttention
            // 
            this.textBoxAttention.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxAttention.ForeColor = System.Drawing.Color.PaleGreen;
            this.textBoxAttention.Location = new System.Drawing.Point(99, 52);
            this.textBoxAttention.Name = "textBoxAttention";
            this.textBoxAttention.Size = new System.Drawing.Size(52, 20);
            this.textBoxAttention.TabIndex = 146;
            this.textBoxAttention.Text = "5";
            // 
            // Ok
            // 
            this.Ok.ForeColor = System.Drawing.Color.Black;
            this.Ok.Location = new System.Drawing.Point(21, 332);
            this.Ok.Margin = new System.Windows.Forms.Padding(1);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(94, 21);
            this.Ok.TabIndex = 162;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.GreenYellow;
            this.label15.Location = new System.Drawing.Point(16, 231);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "HighBeta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.GreenYellow;
            this.label13.Location = new System.Drawing.Point(16, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 138;
            this.label13.Text = "LowBeta:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.GreenYellow;
            this.label17.Location = new System.Drawing.Point(16, 261);
            this.label17.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 142;
            this.label17.Text = "LowGamma:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.GreenYellow;
            this.label11.Location = new System.Drawing.Point(14, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 136;
            this.label11.Text = "HighAlpha:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.GreenYellow;
            this.label19.Location = new System.Drawing.Point(14, 284);
            this.label19.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 144;
            this.label19.Text = "HighGamma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(14, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "LowAlpha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "Theta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 130;
            this.label5.Text = "Delta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Meditation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "Attention:";
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.MenuText;
            this.FilePath.ForeColor = System.Drawing.Color.PaleGreen;
            this.FilePath.Location = new System.Drawing.Point(12, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(157, 20);
            this.FilePath.TabIndex = 163;
            this.FilePath.Text = "C:\\BLconfig\\config.json";
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BrowseB
            // 
            this.BrowseB.ForeColor = System.Drawing.Color.Black;
            this.BrowseB.Location = new System.Drawing.Point(173, 12);
            this.BrowseB.Margin = new System.Windows.Forms.Padding(1);
            this.BrowseB.Name = "BrowseB";
            this.BrowseB.Size = new System.Drawing.Size(54, 21);
            this.BrowseB.TabIndex = 164;
            this.BrowseB.Text = "Browse";
            this.BrowseB.UseVisualStyleBackColor = true;
            this.BrowseB.Click += new System.EventHandler(this.BrowseB_Click);
            // 
            // textBoxHighGammaX
            // 
            this.textBoxHighGammaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighGammaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighGammaX.Location = new System.Drawing.Point(158, 281);
            this.textBoxHighGammaX.Name = "textBoxHighGammaX";
            this.textBoxHighGammaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighGammaX.TabIndex = 174;
            this.textBoxHighGammaX.Text = "3";
            // 
            // textBoxLowGammaX
            // 
            this.textBoxLowGammaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowGammaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowGammaX.Location = new System.Drawing.Point(158, 254);
            this.textBoxLowGammaX.Name = "textBoxLowGammaX";
            this.textBoxLowGammaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowGammaX.TabIndex = 173;
            this.textBoxLowGammaX.Text = "3";
            // 
            // textBoxHighBetaX
            // 
            this.textBoxHighBetaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighBetaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighBetaX.Location = new System.Drawing.Point(158, 228);
            this.textBoxHighBetaX.Name = "textBoxHighBetaX";
            this.textBoxHighBetaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighBetaX.TabIndex = 172;
            this.textBoxHighBetaX.Text = "3";
            // 
            // textBoxLowBetaX
            // 
            this.textBoxLowBetaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowBetaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowBetaX.Location = new System.Drawing.Point(158, 202);
            this.textBoxLowBetaX.Name = "textBoxLowBetaX";
            this.textBoxLowBetaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowBetaX.TabIndex = 171;
            this.textBoxLowBetaX.Text = "3";
            // 
            // textBoxHighAlphaX
            // 
            this.textBoxHighAlphaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxHighAlphaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxHighAlphaX.Location = new System.Drawing.Point(158, 177);
            this.textBoxHighAlphaX.Name = "textBoxHighAlphaX";
            this.textBoxHighAlphaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxHighAlphaX.TabIndex = 170;
            this.textBoxHighAlphaX.Text = "3";
            // 
            // textBoxLowAlphaX
            // 
            this.textBoxLowAlphaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxLowAlphaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxLowAlphaX.Location = new System.Drawing.Point(157, 153);
            this.textBoxLowAlphaX.Name = "textBoxLowAlphaX";
            this.textBoxLowAlphaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxLowAlphaX.TabIndex = 169;
            this.textBoxLowAlphaX.Text = "3";
            // 
            // textBoxMeditationX
            // 
            this.textBoxMeditationX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMeditationX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxMeditationX.Location = new System.Drawing.Point(157, 78);
            this.textBoxMeditationX.Name = "textBoxMeditationX";
            this.textBoxMeditationX.Size = new System.Drawing.Size(52, 20);
            this.textBoxMeditationX.TabIndex = 168;
            this.textBoxMeditationX.Text = "1";
            // 
            // textBoxThetaX
            // 
            this.textBoxThetaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxThetaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxThetaX.Location = new System.Drawing.Point(157, 127);
            this.textBoxThetaX.Name = "textBoxThetaX";
            this.textBoxThetaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxThetaX.TabIndex = 167;
            this.textBoxThetaX.Text = "3";
            // 
            // textBoxDeltaX
            // 
            this.textBoxDeltaX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxDeltaX.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBoxDeltaX.Location = new System.Drawing.Point(157, 104);
            this.textBoxDeltaX.Name = "textBoxDeltaX";
            this.textBoxDeltaX.Size = new System.Drawing.Size(52, 20);
            this.textBoxDeltaX.TabIndex = 166;
            this.textBoxDeltaX.Text = "3";
            // 
            // textBoxAttentionX
            // 
            this.textBoxAttentionX.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxAttentionX.ForeColor = System.Drawing.Color.PaleGreen;
            this.textBoxAttentionX.Location = new System.Drawing.Point(157, 52);
            this.textBoxAttentionX.Name = "textBoxAttentionX";
            this.textBoxAttentionX.Size = new System.Drawing.Size(52, 20);
            this.textBoxAttentionX.TabIndex = 165;
            this.textBoxAttentionX.Text = "1";
            // 
            // textBoxMultiCount
            // 
            this.textBoxMultiCount.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMultiCount.ForeColor = System.Drawing.Color.PaleGreen;
            this.textBoxMultiCount.Location = new System.Drawing.Point(122, 334);
            this.textBoxMultiCount.Name = "textBoxMultiCount";
            this.textBoxMultiCount.Size = new System.Drawing.Size(52, 20);
            this.textBoxMultiCount.TabIndex = 175;
            this.textBoxMultiCount.Text = "10";
            // 
            // ConfigFaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(244, 373);
            this.Controls.Add(this.textBoxMultiCount);
            this.Controls.Add(this.textBoxHighGammaX);
            this.Controls.Add(this.textBoxLowGammaX);
            this.Controls.Add(this.textBoxHighBetaX);
            this.Controls.Add(this.textBoxLowBetaX);
            this.Controls.Add(this.textBoxHighAlphaX);
            this.Controls.Add(this.textBoxLowAlphaX);
            this.Controls.Add(this.textBoxMeditationX);
            this.Controls.Add(this.textBoxThetaX);
            this.Controls.Add(this.textBoxDeltaX);
            this.Controls.Add(this.textBoxAttentionX);
            this.Controls.Add(this.BrowseB);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.loadConfig);
            this.Controls.Add(this.SaveConfig);
            this.Controls.Add(this.textBoxHighGamma);
            this.Controls.Add(this.textBoxLowGamma);
            this.Controls.Add(this.textBoxHighBeta);
            this.Controls.Add(this.textBoxLowBeta);
            this.Controls.Add(this.textBoxHighAlpha);
            this.Controls.Add(this.textBoxLowAlpha);
            this.Controls.Add(this.textBoxMeditation);
            this.Controls.Add(this.textBoxTheta);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxAttention);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Name = "ConfigFaultForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadConfig;
        private System.Windows.Forms.Button SaveConfig;
        public System.Windows.Forms.TextBox textBoxHighGamma;
        public System.Windows.Forms.TextBox textBoxLowGamma;
        public System.Windows.Forms.TextBox textBoxHighBeta;
        public System.Windows.Forms.TextBox textBoxLowBeta;
        public System.Windows.Forms.TextBox textBoxHighAlpha;
        public System.Windows.Forms.TextBox textBoxLowAlpha;
        public System.Windows.Forms.TextBox textBoxMeditation;
        public System.Windows.Forms.TextBox textBoxTheta;
        public System.Windows.Forms.TextBox textBoxDelta;
        public System.Windows.Forms.TextBox textBoxAttention;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox FilePath;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button BrowseB;
        public System.Windows.Forms.TextBox textBoxHighGammaX;
        public System.Windows.Forms.TextBox textBoxLowGammaX;
        public System.Windows.Forms.TextBox textBoxHighBetaX;
        public System.Windows.Forms.TextBox textBoxLowBetaX;
        public System.Windows.Forms.TextBox textBoxHighAlphaX;
        public System.Windows.Forms.TextBox textBoxLowAlphaX;
        public System.Windows.Forms.TextBox textBoxMeditationX;
        public System.Windows.Forms.TextBox textBoxThetaX;
        public System.Windows.Forms.TextBox textBoxDeltaX;
        public System.Windows.Forms.TextBox textBoxAttentionX;
        public System.Windows.Forms.TextBox textBoxMultiCount;
    }
}

