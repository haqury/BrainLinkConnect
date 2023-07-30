namespace BrainLinkConnect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.ele = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ap = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.heart = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.signal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.keyDown = new System.Windows.Forms.Label();
            this.IsUseKey = new System.Windows.Forms.CheckBox();
            this.checkBoxMu = new System.Windows.Forms.CheckBox();
            this.checkBoxMl = new System.Windows.Forms.CheckBox();
            this.checkBoxMr = new System.Windows.Forms.CheckBox();
            this.checkBoxMd = new System.Windows.Forms.CheckBox();
            this.saveToFileB = new System.Windows.Forms.Button();
            this.LoadFromFile = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.CounterL = new System.Windows.Forms.Label();
            this.Autouse = new System.Windows.Forms.CheckBox();
            this.ConfigFault = new System.Windows.Forms.Button();
            this.EEGDataButton = new System.Windows.Forms.Button();
            this.BrowseB = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.HRVView = new System.Windows.Forms.Button();
            this.Gyro = new System.Windows.Forms.Button();
            this.Diagram = new System.Windows.Forms.Button();
            this.deviceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deviceItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Location = new System.Drawing.Point(11, 37);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 20);
            this.Start.TabIndex = 0;
            this.Start.Text = "Connect";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ele
            // 
            this.ele.AutoSize = true;
            this.ele.ForeColor = System.Drawing.Color.GreenYellow;
            this.ele.Location = new System.Drawing.Point(49, 13);
            this.ele.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.ele.Name = "ele";
            this.ele.Size = new System.Drawing.Size(13, 13);
            this.ele.TabIndex = 23;
            this.ele.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.GreenYellow;
            this.label23.Location = new System.Drawing.Point(2, 13);
            this.label23.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Battery:";
            // 
            // ap
            // 
            this.ap.AutoSize = true;
            this.ap.ForeColor = System.Drawing.Color.GreenYellow;
            this.ap.Location = new System.Drawing.Point(222, 12);
            this.ap.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(13, 13);
            this.ap.TabIndex = 21;
            this.ap.Text = "0";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.ForeColor = System.Drawing.Color.GreenYellow;
            this.temp.Location = new System.Drawing.Point(315, 12);
            this.temp.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(13, 13);
            this.temp.TabIndex = 27;
            this.temp.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.GreenYellow;
            this.label28.Location = new System.Drawing.Point(246, 12);
            this.label28.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Temperature:";
            // 
            // heart
            // 
            this.heart.AutoSize = true;
            this.heart.ForeColor = System.Drawing.Color.GreenYellow;
            this.heart.Location = new System.Drawing.Point(404, 13);
            this.heart.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(13, 13);
            this.heart.TabIndex = 29;
            this.heart.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.GreenYellow;
            this.label30.Location = new System.Drawing.Point(348, 13);
            this.label30.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 28;
            this.label30.Text = "Heart Rate:";
            // 
            // signal
            // 
            this.signal.AutoSize = true;
            this.signal.ForeColor = System.Drawing.Color.GreenYellow;
            this.signal.Location = new System.Drawing.Point(105, 13);
            this.signal.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(13, 13);
            this.signal.TabIndex = 38;
            this.signal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(70, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Signal:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBox1.Location = new System.Drawing.Point(121, 13);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 16);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Appreciation:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // keyDown
            // 
            this.keyDown.AutoSize = true;
            this.keyDown.Location = new System.Drawing.Point(387, 130);
            this.keyDown.Name = "keyDown";
            this.keyDown.Size = new System.Drawing.Size(0, 13);
            this.keyDown.TabIndex = 75;
            // 
            // IsUseKey
            // 
            this.IsUseKey.AutoSize = true;
            this.IsUseKey.ForeColor = System.Drawing.Color.GreenYellow;
            this.IsUseKey.Location = new System.Drawing.Point(94, 40);
            this.IsUseKey.Name = "IsUseKey";
            this.IsUseKey.Size = new System.Drawing.Size(63, 17);
            this.IsUseKey.TabIndex = 76;
            this.IsUseKey.Text = "use key";
            this.IsUseKey.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IsUseKey.UseVisualStyleBackColor = true;
            // 
            // checkBoxMu
            // 
            this.checkBoxMu.AutoSize = true;
            this.checkBoxMu.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxMu.Location = new System.Drawing.Point(270, 77);
            this.checkBoxMu.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxMu.Name = "checkBoxMu";
            this.checkBoxMu.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMu.TabIndex = 78;
            this.checkBoxMu.Text = "mouse up";
            this.checkBoxMu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMl
            // 
            this.checkBoxMl.AutoSize = true;
            this.checkBoxMl.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxMl.Location = new System.Drawing.Point(192, 84);
            this.checkBoxMl.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxMl.Name = "checkBoxMl";
            this.checkBoxMl.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMl.TabIndex = 79;
            this.checkBoxMl.Text = "mouse left";
            this.checkBoxMl.UseVisualStyleBackColor = true;
            // 
            // checkBoxMr
            // 
            this.checkBoxMr.AutoSize = true;
            this.checkBoxMr.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxMr.Location = new System.Drawing.Point(344, 84);
            this.checkBoxMr.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxMr.Name = "checkBoxMr";
            this.checkBoxMr.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMr.TabIndex = 80;
            this.checkBoxMr.Text = "mouse right";
            this.checkBoxMr.UseVisualStyleBackColor = true;
            // 
            // checkBoxMd
            // 
            this.checkBoxMd.AutoSize = true;
            this.checkBoxMd.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxMd.Location = new System.Drawing.Point(270, 103);
            this.checkBoxMd.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxMd.Name = "checkBoxMd";
            this.checkBoxMd.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMd.TabIndex = 81;
            this.checkBoxMd.Text = "mouse doewn";
            this.checkBoxMd.UseVisualStyleBackColor = true;
            // 
            // saveToFileB
            // 
            this.saveToFileB.ForeColor = System.Drawing.Color.Black;
            this.saveToFileB.Location = new System.Drawing.Point(472, 97);
            this.saveToFileB.Name = "saveToFileB";
            this.saveToFileB.Size = new System.Drawing.Size(75, 23);
            this.saveToFileB.TabIndex = 83;
            this.saveToFileB.Text = "save to file";
            this.saveToFileB.UseVisualStyleBackColor = true;
            this.saveToFileB.Click += new System.EventHandler(this.saveToFileB_Click);
            // 
            // LoadFromFile
            // 
            this.LoadFromFile.ForeColor = System.Drawing.Color.Black;
            this.LoadFromFile.Location = new System.Drawing.Point(469, 68);
            this.LoadFromFile.Name = "LoadFromFile";
            this.LoadFromFile.Size = new System.Drawing.Size(78, 23);
            this.LoadFromFile.TabIndex = 86;
            this.LoadFromFile.Text = "load from file";
            this.LoadFromFile.UseVisualStyleBackColor = true;
            this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(469, 39);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(78, 23);
            this.ClearButton.TabIndex = 90;
            this.ClearButton.Text = "clear";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.GreenYellow;
            this.label26.Location = new System.Drawing.Point(423, 12);
            this.label26.Margin = new System.Windows.Forms.Padding(10, 9, 2, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 13);
            this.label26.TabIndex = 24;
            this.label26.Text = "Version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.GreenYellow;
            this.version.Location = new System.Drawing.Point(466, 12);
            this.version.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(13, 13);
            this.version.TabIndex = 25;
            this.version.Text = "0";
            // 
            // CounterL
            // 
            this.CounterL.AutoSize = true;
            this.CounterL.ForeColor = System.Drawing.Color.GreenYellow;
            this.CounterL.Location = new System.Drawing.Point(534, 12);
            this.CounterL.Margin = new System.Windows.Forms.Padding(2, 9, 10, 9);
            this.CounterL.Name = "CounterL";
            this.CounterL.Size = new System.Drawing.Size(13, 13);
            this.CounterL.TabIndex = 91;
            this.CounterL.Text = "0";
            // 
            // Autouse
            // 
            this.Autouse.AutoSize = true;
            this.Autouse.ForeColor = System.Drawing.Color.GreenYellow;
            this.Autouse.Location = new System.Drawing.Point(94, 63);
            this.Autouse.Name = "Autouse";
            this.Autouse.Size = new System.Drawing.Size(64, 17);
            this.Autouse.TabIndex = 92;
            this.Autouse.Text = "autouse";
            this.Autouse.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Autouse.UseVisualStyleBackColor = true;
            // 
            // ConfigFault
            // 
            this.ConfigFault.ForeColor = System.Drawing.Color.Black;
            this.ConfigFault.Location = new System.Drawing.Point(14, 141);
            this.ConfigFault.Margin = new System.Windows.Forms.Padding(1);
            this.ConfigFault.Name = "ConfigFault";
            this.ConfigFault.Size = new System.Drawing.Size(76, 21);
            this.ConfigFault.TabIndex = 95;
            this.ConfigFault.Text = "config";
            this.ConfigFault.UseVisualStyleBackColor = true;
            this.ConfigFault.Click += new System.EventHandler(this.ConfigFault_Click);
            // 
            // EEGDataButton
            // 
            this.EEGDataButton.ForeColor = System.Drawing.Color.Black;
            this.EEGDataButton.Location = new System.Drawing.Point(10, 69);
            this.EEGDataButton.Name = "EEGDataButton";
            this.EEGDataButton.Size = new System.Drawing.Size(78, 23);
            this.EEGDataButton.TabIndex = 96;
            this.EEGDataButton.Text = "EEGData";
            this.EEGDataButton.UseVisualStyleBackColor = true;
            this.EEGDataButton.Click += new System.EventHandler(this.EEGDataButton_Click);
            // 
            // BrowseB
            // 
            this.BrowseB.ForeColor = System.Drawing.Color.Black;
            this.BrowseB.Location = new System.Drawing.Point(401, 40);
            this.BrowseB.Margin = new System.Windows.Forms.Padding(1);
            this.BrowseB.Name = "BrowseB";
            this.BrowseB.Size = new System.Drawing.Size(54, 21);
            this.BrowseB.TabIndex = 166;
            this.BrowseB.Text = "Browse";
            this.BrowseB.UseVisualStyleBackColor = true;
            this.BrowseB.Click += new System.EventHandler(this.BrowseB_Click);
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.MenuText;
            this.FilePath.ForeColor = System.Drawing.Color.PaleGreen;
            this.FilePath.Location = new System.Drawing.Point(240, 41);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(157, 20);
            this.FilePath.TabIndex = 165;
            this.FilePath.Text = "C:\\Users\\haqur\\OneDrive\\Документы\\hao\\0.json";
            // 
            // HRVView
            // 
            this.HRVView.ForeColor = System.Drawing.Color.Black;
            this.HRVView.Location = new System.Drawing.Point(309, 141);
            this.HRVView.Name = "HRVView";
            this.HRVView.Size = new System.Drawing.Size(78, 23);
            this.HRVView.TabIndex = 167;
            this.HRVView.Text = "HRV";
            this.HRVView.UseVisualStyleBackColor = true;
            this.HRVView.Click += new System.EventHandler(this.HRVView_Click);
            // 
            // Gyro
            // 
            this.Gyro.ForeColor = System.Drawing.Color.Black;
            this.Gyro.Location = new System.Drawing.Point(94, 145);
            this.Gyro.Name = "Gyro";
            this.Gyro.Size = new System.Drawing.Size(49, 19);
            this.Gyro.TabIndex = 168;
            this.Gyro.Text = "Gyro";
            this.Gyro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Gyro.UseVisualStyleBackColor = true;
            this.Gyro.Click += new System.EventHandler(this.Gyro_Click);
            // 
            // Diagram
            // 
            this.Diagram.ForeColor = System.Drawing.Color.Black;
            this.Diagram.Location = new System.Drawing.Point(469, 139);
            this.Diagram.Name = "Diagram";
            this.Diagram.Size = new System.Drawing.Size(78, 23);
            this.Diagram.TabIndex = 169;
            this.Diagram.Text = "Diagram";
            this.Diagram.UseVisualStyleBackColor = true;
            this.Diagram.Click += new System.EventHandler(this.Diagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(564, 168);
            this.Controls.Add(this.Diagram);
            this.Controls.Add(this.Gyro);
            this.Controls.Add(this.HRVView);
            this.Controls.Add(this.BrowseB);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.EEGDataButton);
            this.Controls.Add(this.ConfigFault);
            this.Controls.Add(this.Autouse);
            this.Controls.Add(this.CounterL);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadFromFile);
            this.Controls.Add(this.saveToFileB);
            this.Controls.Add(this.checkBoxMd);
            this.Controls.Add(this.checkBoxMr);
            this.Controls.Add(this.checkBoxMl);
            this.Controls.Add(this.checkBoxMu);
            this.Controls.Add(this.IsUseKey);
            this.Controls.Add(this.keyDown);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ele);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.ap);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.deviceItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ele;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label ap;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label heart;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label signal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource deviceItemBindingSource;
        public System.Windows.Forms.Label keyDown;
        public System.Windows.Forms.CheckBox IsUseKey;
        private System.Windows.Forms.CheckBox checkBoxMu;
        private System.Windows.Forms.CheckBox checkBoxMl;
        private System.Windows.Forms.CheckBox checkBoxMr;
        private System.Windows.Forms.CheckBox checkBoxMd;
        private System.Windows.Forms.Button saveToFileB;
        private System.Windows.Forms.Button LoadFromFile;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label CounterL;
        public System.Windows.Forms.CheckBox Autouse;
        private System.Windows.Forms.Button ConfigFault;
        private System.Windows.Forms.Button EEGDataButton;
        private System.Windows.Forms.Button BrowseB;
        public System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button HRVView;
        private System.Windows.Forms.Button Gyro;
        private System.Windows.Forms.Button Diagram;
    }
}

