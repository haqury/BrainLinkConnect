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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start = new System.Windows.Forms.Button();
            this.ele = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ap = new System.Windows.Forms.Label();
            this.hgamma = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lgamma = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.hbeta = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbeta = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.halpha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lalpha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.theta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.med = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.att = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.heart = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.xvalue = new System.Windows.Forms.Label();
            this.yvalue = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.zvalue = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.signal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hrvBox = new System.Windows.Forms.TextBox();
            this.hrvLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Connect = new System.Windows.Forms.Button();
            this.deviceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(520, 20);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(56, 18);
            this.Start.TabIndex = 0;
            this.Start.Text = "Scan";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ele
            // 
            this.ele.AutoSize = true;
            this.ele.Location = new System.Drawing.Point(470, 196);
            this.ele.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.ele.Name = "ele";
            this.ele.Size = new System.Drawing.Size(11, 12);
            this.ele.TabIndex = 23;
            this.ele.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(406, 196);
            this.label23.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 22;
            this.label23.Text = "Battery:";
            // 
            // ap
            // 
            this.ap.AutoSize = true;
            this.ap.Location = new System.Drawing.Point(358, 196);
            this.ap.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(11, 12);
            this.ap.TabIndex = 21;
            this.ap.Text = "0";
            // 
            // hgamma
            // 
            this.hgamma.AutoSize = true;
            this.hgamma.Location = new System.Drawing.Point(223, 196);
            this.hgamma.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.hgamma.Name = "hgamma";
            this.hgamma.Size = new System.Drawing.Size(11, 12);
            this.hgamma.TabIndex = 19;
            this.hgamma.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(147, 196);
            this.label19.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 18;
            this.label19.Text = "HighGamma:";
            // 
            // lgamma
            // 
            this.lgamma.AutoSize = true;
            this.lgamma.Location = new System.Drawing.Point(104, 196);
            this.lgamma.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.lgamma.Name = "lgamma";
            this.lgamma.Size = new System.Drawing.Size(11, 12);
            this.lgamma.TabIndex = 17;
            this.lgamma.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 196);
            this.label17.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "LowGamma:";
            // 
            // hbeta
            // 
            this.hbeta.AutoSize = true;
            this.hbeta.Location = new System.Drawing.Point(470, 168);
            this.hbeta.Margin = new System.Windows.Forms.Padding(2, 8, 75, 8);
            this.hbeta.Name = "hbeta";
            this.hbeta.Size = new System.Drawing.Size(11, 12);
            this.hbeta.TabIndex = 15;
            this.hbeta.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 168);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "HighBeta:";
            // 
            // lbeta
            // 
            this.lbeta.AutoSize = true;
            this.lbeta.Location = new System.Drawing.Point(344, 168);
            this.lbeta.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.lbeta.Name = "lbeta";
            this.lbeta.Size = new System.Drawing.Size(11, 12);
            this.lbeta.TabIndex = 13;
            this.lbeta.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "LowBeta:";
            // 
            // halpha
            // 
            this.halpha.AutoSize = true;
            this.halpha.Location = new System.Drawing.Point(223, 168);
            this.halpha.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.halpha.Name = "halpha";
            this.halpha.Size = new System.Drawing.Size(11, 12);
            this.halpha.TabIndex = 11;
            this.halpha.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "HighAlpha:";
            // 
            // lalpha
            // 
            this.lalpha.AutoSize = true;
            this.lalpha.Location = new System.Drawing.Point(104, 168);
            this.lalpha.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.lalpha.Name = "lalpha";
            this.lalpha.Size = new System.Drawing.Size(11, 12);
            this.lalpha.TabIndex = 9;
            this.lalpha.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "LowAlpha:";
            // 
            // theta
            // 
            this.theta.AutoSize = true;
            this.theta.Location = new System.Drawing.Point(470, 140);
            this.theta.Margin = new System.Windows.Forms.Padding(2, 8, 75, 8);
            this.theta.Name = "theta";
            this.theta.Size = new System.Drawing.Size(11, 12);
            this.theta.TabIndex = 7;
            this.theta.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Theta:";
            // 
            // delta
            // 
            this.delta.AutoSize = true;
            this.delta.Location = new System.Drawing.Point(344, 140);
            this.delta.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(11, 12);
            this.delta.TabIndex = 5;
            this.delta.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delta:";
            // 
            // med
            // 
            this.med.AutoSize = true;
            this.med.Location = new System.Drawing.Point(223, 140);
            this.med.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(11, 12);
            this.med.TabIndex = 3;
            this.med.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meditation:";
            // 
            // att
            // 
            this.att.AutoSize = true;
            this.att.Location = new System.Drawing.Point(104, 140);
            this.att.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(11, 12);
            this.att.TabIndex = 1;
            this.att.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attention:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(344, 224);
            this.version.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(11, 12);
            this.version.TabIndex = 25;
            this.version.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(274, 224);
            this.label26.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 24;
            this.label26.Text = "Version:";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(104, 224);
            this.temp.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(11, 12);
            this.temp.TabIndex = 27;
            this.temp.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 224);
            this.label28.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 12);
            this.label28.TabIndex = 26;
            this.label28.Text = "Temperature:";
            // 
            // heart
            // 
            this.heart.AutoSize = true;
            this.heart.Location = new System.Drawing.Point(217, 224);
            this.heart.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(11, 12);
            this.heart.TabIndex = 29;
            this.heart.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(147, 224);
            this.label30.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 12);
            this.label30.TabIndex = 28;
            this.label30.Text = "Heart Rate:";
            // 
            // xvalue
            // 
            this.xvalue.AutoSize = true;
            this.xvalue.Location = new System.Drawing.Point(430, 224);
            this.xvalue.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.xvalue.Name = "xvalue";
            this.xvalue.Size = new System.Drawing.Size(11, 12);
            this.xvalue.TabIndex = 31;
            this.xvalue.Text = "0";
            // 
            // yvalue
            // 
            this.yvalue.AutoSize = true;
            this.yvalue.Location = new System.Drawing.Point(490, 224);
            this.yvalue.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.yvalue.Name = "yvalue";
            this.yvalue.Size = new System.Drawing.Size(11, 12);
            this.yvalue.TabIndex = 33;
            this.yvalue.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(468, 224);
            this.label34.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 12);
            this.label34.TabIndex = 32;
            this.label34.Text = "Y:";
            // 
            // zvalue
            // 
            this.zvalue.AutoSize = true;
            this.zvalue.Location = new System.Drawing.Point(554, 224);
            this.zvalue.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.zvalue.Name = "zvalue";
            this.zvalue.Size = new System.Drawing.Size(11, 12);
            this.zvalue.TabIndex = 35;
            this.zvalue.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(532, 224);
            this.label36.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 12);
            this.label36.TabIndex = 34;
            this.label36.Text = "Z:";
            // 
            // chart1
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 2000D;
            chartArea2.AxisY.Minimum = -2000D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(21, 266);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(556, 200);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // signal
            // 
            this.signal.AutoSize = true;
            this.signal.Location = new System.Drawing.Point(554, 196);
            this.signal.Margin = new System.Windows.Forms.Padding(2, 8, 10, 8);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(11, 12);
            this.signal.TabIndex = 38;
            this.signal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 8, 2, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Signal:";
            // 
            // hrvBox
            // 
            this.hrvBox.Location = new System.Drawing.Point(21, 502);
            this.hrvBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hrvBox.Multiline = true;
            this.hrvBox.Name = "hrvBox";
            this.hrvBox.Size = new System.Drawing.Size(558, 125);
            this.hrvBox.TabIndex = 39;
            // 
            // hrvLabel
            // 
            this.hrvLabel.AutoSize = true;
            this.hrvLabel.Location = new System.Drawing.Point(21, 479);
            this.hrvLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hrvLabel.Name = "hrvLabel";
            this.hrvLabel.Size = new System.Drawing.Size(41, 12);
            this.hrvLabel.TabIndex = 40;
            this.hrvLabel.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(258, 195);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 16);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Appreciation:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(392, 222);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 16);
            this.checkBox2.TabIndex = 42;
            this.checkBox2.Text = "X:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(21, 20);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 100);
            this.listBox1.TabIndex = 43;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(520, 52);
            this.Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(56, 18);
            this.Connect.TabIndex = 44;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 648);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.hrvLabel);
            this.Controls.Add(this.hrvBox);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zvalue);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.yvalue);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.xvalue);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.att);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.med);
            this.Controls.Add(this.ele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.theta);
            this.Controls.Add(this.hgamma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lalpha);
            this.Controls.Add(this.lgamma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.halpha);
            this.Controls.Add(this.hbeta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ele;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label ap;
        private System.Windows.Forms.Label hgamma;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lgamma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label hbeta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbeta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label halpha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lalpha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label theta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label delta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label med;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label att;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label heart;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label xvalue;
        private System.Windows.Forms.Label yvalue;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label zvalue;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label signal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hrvBox;
        private System.Windows.Forms.Label hrvLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.BindingSource deviceItemBindingSource;
    }
}

