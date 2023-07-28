using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ContollerBL.service;
using BrainLinkSDK_Windows;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ContollerBL.dto;


using InTheHand.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BrainLinkConnect.service;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

using System.Windows.Input;
using System.Runtime.InteropServices.ComTypes;



namespace BrainLinkConnect
{
    public partial class Form1 : Form
    {
        private BrainLinkSDK brainLinkSDK;
        private BrainLinkToServiseDto brainLinkToServiseDto = new BrainLinkToServiseDto();

        private ContollerBL.service.ContollerBL controllerBL = new ContollerBL.service.ContollerBL();

        private service.services services = new service.services();

        public int OnEEGDataEventId = 1;

        private float ave = 0;

        private List<int> raw = new List<int>();

        private List<float> hrvList = new List<float>();

        private List<double> lastHRV = new List<double>();

        private List<(long, string)> Devices = new List<(long, string)>();

        private UdpClient udpClient = new UdpClient();
        private UdpClient udpServer = new UdpClient(5001);
        private IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);

        private SystemService systemService = new SystemService();

        private BinaryFormatter bf = new BinaryFormatter();

        private MemoryStream ms = new MemoryStream();

        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
            private BluetoothClient client = new BluetoothClient();


        private string configPath = "config.json";

        public Form1()
        {
            systemService.config = new SystemServiceConfig();

            InitializeComponent();


            brainLinkSDK = new BrainLinkSDK();
            brainLinkSDK.OnEEGDataEvent += new BrainLinkSDKEEGDataEvent(BrainLinkSDK_OnEEGDataEvent);
            brainLinkSDK.OnEEGExtendEvent += new BrainLinkSDKEEGExtendDataEvent(BrainLinkSDK_OnEEGExtendDataEvent);
            brainLinkSDK.OnGyroDataEvent += new BrainLinkSDKGyroDataEvent(BrainLinkSDK_OnGyroDataEvent);
            brainLinkSDK.OnHRVDataEvent += new BrainLinkSDKHRVDataEvent(BrainLinkSDK_OnHRVDataEvent);
            brainLinkSDK.OnRawDataEvent += new BrainLinkSDKRawDataEvent(BrainLinkSDK_OnRawDataEvent);
            brainLinkSDK.OnDeviceFound += new BrainLinkSDKOnDeviceFoundEvent(BrainLinkSDK_OnDeviceFoundEvent);

            KeyPreview = true;
        }

        private void BrainLinkSDK_OnDeviceFoundEvent(long Address, string Name)
        {
            Debug.WriteLine("Discover name " + Name);
            listBox1.Items.Add(Name + " : " + Address.ToString("X12"));
            Devices.Add((Address, Name));
        }        

        private void BrainLinkSDK_OnRawDataEvent(int Raw)
        {
            raw.Add(Raw);
            if (raw.Count > 512)
            {
                raw.Remove(raw[0]);
            }
            chart1.Series[0].Points.DataBindY(raw);
        }

        private void BrainLinkSDK_OnHRVDataEvent(int[] HRV, int Blink)
        {
            for (int i = 0; i < HRV.Length; i++)
            {
                hrvBox.Text += HRV[i] + "ms ";
                hrvList.Add(HRV[i]);
            }
            if (hrvList.Count >= 60)
            {
                double hrv = StandardDiviation(hrvList.ToArray());
                lastHRV.Add(hrv);
                if (lastHRV.Count > 5)
                {
                    lastHRV.RemoveAt(0);
                }
                string hrvString = "";
                for (int i = 0; i < lastHRV.Count; i++)
                {
                    hrvString += "hrv" + i + ":" + lastHRV[i].ToString("F2");
                }
                hrvString += " avg:" + ave.ToString("F2") + " size:" + hrvList.Count;
                hrvList.Clear();
                hrvBox.Text = "";
            }
        }

        private void BrainLinkSDK_OnGyroDataEvent(int X, int Y, int Z)
        {
            xvalue.Text = X.ToString();
            yvalue.Text = Y.ToString();
            zvalue.Text = Z.ToString();
        }

        private void BrainLinkSDK_OnEEGExtendDataEvent(BrainLinkExtendModel Model)
        {
            //Debug.WriteLine("Extend");
            ap.Text = Model.Ap.ToString();
            ele.Text = Model.Electric.ToString();
            version.Text = Model.Version.ToString();
            temp.Text = Model.Temperature.ToString();
            heart.Text = Model.HeartRate.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Click");
            brainLinkSDK.Start();

            var peers = client.DiscoverDevices();
            foreach (var peer in peers)
            {
                devices.Add(peer);
            }

            listBox1.Items.Clear();
            Devices.Clear();
        }

        private void BrainLinkSDK_OnEEGDataEvent(BrainLinkModel Model)
        {
            if (Model == null) return;

            EegHistoryModel h = new EegHistoryModel();
            h.Attention = Model.Attention;
            h.Meditation = Model.Meditation;
            h.Delta = Model.Delta;
            h.Theta = Model.Theta;
            h.LowAlpha = Model.LowAlpha;
            h.HighAlpha = Model.HighAlpha;
            h.LowBeta = Model.LowBeta;
            h.HighBeta = Model.HighBeta;
            h.LowGamma = Model.LowGamma;
            h.HighGamma = Model.HighGamma;
            try
            {
                h.Xvalue = int.Parse(xvalue.Text);
                h.Yvalue = int.Parse(yvalue.Text);
                h.Zvalue = int.Parse(zvalue.Text);
            }

            h.EventName = getEventName();

            EegHistoryModel fault = GetConfigFault();
            ConfigParams config = new ConfigParams();
            config.EegFault = fault;

            if (Autouse.Checked == true && h.EventName != "")
            {
                services.mouse.play(h, config, h.EventName, IsUseKey.Checked);
            } else
            {
                services.mouse.play(h, config, controllerBL.History.getEventNameBy(h, config), IsUseKey.Checked);
            }

            onEEGDataEventChangeTable(Model);

            if (h.EventName == "") return;
            Console.WriteLine(h.EventName);
            controllerBL.History.Add(h);

            CounterL.Text = controllerBL.History.Count().ToString();


            // bf.Serialize(ms, brainLinkToServiseDto);
            // byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(brainLinkToServiseDto));
            // udpClient.SendAsync(buffer, buffer.Length, "127.0.0.1", 1234);
        }

        private EegHistoryModel GetConfigFault()
        {
            EegHistoryModel config = new EegHistoryModel();
            try
            {
                config.Attention = int.Parse(this.textBoxAttention.Text);
                config.Meditation = int.Parse(this.textBoxMeditation.Text);
                config.Delta = int.Parse(this.textBoxDelta.Text);
                config.Theta = int.Parse(this.textBoxTheta.Text);
                config.LowAlpha = int.Parse(this.textBoxLowAlpha.Text);
                config.HighAlpha = int.Parse(this.textBoxHighAlpha.Text);
                config.LowBeta = int.Parse(this.textBoxLowBeta.Text);
                config.HighBeta = int.Parse(this.textBoxHighBeta.Text);
                config.LowGamma = int.Parse(this.textBoxLowGamma.Text);
                config.HighGamma = int.Parse(this.textBoxHighGamma.Text);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return config;
        }

        private string getEventName()
        {
            if (IsUseKeySave.Checked)
            {
               return keyI.Text;
            }
            else if (checkBoxMl.Checked)
            {
                return "ml";
            }
            else if (checkBoxMr.Checked)
            {
                return "mr";
            }
            else if (checkBoxMu.Checked)
            {
                return "mu";
            }
            else if (checkBoxMd.Checked)
            {
                return "md";
            }
            return "";
        }


        private void onEEGDataEventChangeTable(BrainLinkModel Model)
        {
            att.Text = Model.Attention.ToString();
            med.Text = Model.Meditation.ToString();
            delta.Text = Model.Delta.ToString();
            theta.Text = Model.Theta.ToString();
            lalpha.Text = Model.LowAlpha.ToString();
            halpha.Text = Model.HighAlpha.ToString();
            lbeta.Text = Model.LowBeta.ToString();
            hbeta.Text = Model.HighBeta.ToString();
            lgamma.Text = Model.LowGamma.ToString();
            hgamma.Text = Model.HighGamma.ToString();
            signal.Text = Model.Signal.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            //Debug.WriteLine("Click");
            //brainLinkSDK.Start();

        }

        private double StandardDiviation(float[] x)
        {
            ave = x.Average();
            double dVar = 0;
            for (int i = 0; i < x.Length; i++)
            {
                dVar += (x[i] - ave) * (x[i] - ave);
            }
            return Math.Sqrt(dVar / x.Length);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            brainLinkSDK.SetApEnable(checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            brainLinkSDK.SetGyroEnable(checkBox2.Checked);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            brainLinkSDK.Close();
            udpClient.Close();
            udpServer.Close();
            brainLinkSDK = null;
            Dispose();
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < Devices.Count)
            {
                (long, string) Device = Devices[listBox1.SelectedIndex];
                brainLinkSDK.connect(Device.Item1);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lgamma_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hrvBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToFileB_Click(object sender, EventArgs e)
        {

            controllerBL.save(userName.Text, textBoxPostfix.Text);
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            controllerBL.load(userName.Text, textBoxPostfix.Text);
            CounterL.Text = controllerBL.History.Count().ToString();
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            EegHistoryModel config = GetConfigFault();
            using (StreamWriter streamWriter = new StreamWriter(configPath))
            {
                streamWriter.Write(JsonConvert.SerializeObject(config));
            }
        }

        private async void loadConfig_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(configPath);
            EegHistoryModel config = JsonConvert.DeserializeObject<EegHistoryModel>(jsonString);

            textBoxAttention.Text = config.Attention.ToString();
            textBoxMeditation.Text = config.Meditation.ToString();
            textBoxDelta.Text = config.Delta.ToString();
            textBoxTheta.Text = config.Theta.ToString();
            textBoxLowAlpha.Text = config.LowAlpha.ToString();
            textBoxHighAlpha.Text = config.HighAlpha.ToString();
            textBoxLowBeta.Text = config.LowBeta.ToString();
            textBoxHighBeta.Text = config.HighBeta.ToString();
            textBoxLowGamma.Text = config.LowGamma.ToString();
            textBoxHighGamma.Text = config.HighGamma.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            controllerBL.History.Clear();
        }

        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                checkBoxMl.Checked = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                checkBoxMr.Checked = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                checkBoxMu.Checked = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                checkBoxMd.Checked = false;
            }
        }

        private void Form1_KeyUp_1(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                checkBoxMl.Checked = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                checkBoxMr.Checked = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                checkBoxMu.Checked = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                checkBoxMd.Checked = false;
            }
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);
            if (e.KeyCode == Keys.Left)
            {
                checkBoxMl.Checked = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                checkBoxMr.Checked = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                checkBoxMu.Checked = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                checkBoxMd.Checked = true;
            }
        }
    }
}
