﻿using System;
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
using BrainLinkSDK_Windows;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
        private EventMouse eventMouse = new EventMouse();
        private BrainLinkSDK brainLinkSDK;
        private BrainLinkToServiseDto brainLinkToServiseDto = new BrainLinkToServiseDto();
        private BrainLinkToServiseDto brainLinkToServiseConfig = new BrainLinkToServiseDto();

        public History history = new History();
        public service.Map Map = new service.Map();
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

            brainLinkToServiseDto.input = Model;

            brainLinkToServiseDto.system = systemService.Run(brainLinkToServiseDto.system);
            brainLinkToServiseDto.id = OnEEGDataEventId;
            if (IsUseKeySave.Checked)
            {
                brainLinkToServiseDto.eventName = keyI.Text;
            }
            else if(checkBoxMl.Checked)
            {
                brainLinkToServiseDto.eventName = "ml";
            } 
            else if (checkBoxMr.Checked)
            {
                brainLinkToServiseDto.eventName = "mr";
            }
            else if (checkBoxMu.Checked)
            {
                brainLinkToServiseDto.eventName = "mu";
            }
            else if (checkBoxMd.Checked)
            {
                brainLinkToServiseDto.eventName = "md";
            }
            else
            {
                brainLinkToServiseDto.eventName = "";
            }

            services.mouse.check(brainLinkToServiseDto, this);

            onEEGDataEventChangeTable(Model);

            if (brainLinkToServiseDto.eventName == "") return;

            Console.WriteLine("eventName:" + brainLinkToServiseDto.eventName);
            EegHistoryModel eeg = EegHistoryModel.getFromDto(brainLinkToServiseDto);
            history.Add(eeg);


            // bf.Serialize(ms, brainLinkToServiseDto);
            // byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(brainLinkToServiseDto));
            // udpClient.SendAsync(buffer, buffer.Length, "127.0.0.1", 1234);
        }


        private void saveToFile()
        {
            string filePath = "data.json";
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write(history.ToString());
            }
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
                brainLinkToServiseDto.system = systemService.UpdateGetInfo();


                using (WebClient client = new WebClient())
                {
                    string data = "Sample data to send";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resync();
        }

        public void resync()
        {
            var c = false;
            if (controll.Checked)
            {
                c = true; controll.Checked = false;
            }

            using (WebClient client = new WebClient())
            {
                string data = "Sample data to send";

                string response = Encoding.UTF8.GetString(client.UploadData("http://localhost:5001/", "POST", Encoding.UTF8.GetBytes(data)));
                Console.WriteLine(response);
                services.mouse.saveMap(JsonConvert.DeserializeObject<Map>(response));
            }

            if (c) { controll.Checked = true; }
        }

        public void resyncEvent()
        {
            var c = false;
            if (controll.Checked)
            {
                c = true; controll.Checked = false;
            }

            using (WebClient client = new WebClient())
            {
                BrainLinkModel model = new BrainLinkModel();
                model.Attention = int.Parse(textBoxAttention.Text);
                model.Meditation = int.Parse(textBoxMeditation.Text);
                model.Delta = int.Parse(textBoxDelta.Text);
                model.Theta = int.Parse(textBoxTheta.Text);
                model.LowAlpha = int.Parse(textBoxLowAlpha.Text);
                model.HighAlpha = int.Parse(textBoxHighAlpha.Text);
                model.LowBeta = int.Parse(textBoxLowBeta.Text);
                model.HighBeta = int.Parse(textBoxHighBeta.Text);
                model.LowGamma = int.Parse(textBoxLowGamma.Text);
                model.HighGamma = int.Parse(textBoxHighGamma.Text);

                string data = JsonConvert.SerializeObject(model);
                string response = Encoding.UTF8.GetString(client.UploadData("http://localhost:5001/event", "POST", Encoding.UTF8.GetBytes(data)));
                Console.WriteLine(response);
                history = JsonConvert.DeserializeObject<History>(response); 
                Console.WriteLine(history);
            }

            if (c) { controll.Checked = true; }
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

        private void ResynKey_Click(object sender, EventArgs e)
        {
            resyncEvent();
        }

        private void saveToFileB_Click(object sender, EventArgs e)
        {
            if (history.Count() == 0)
            {
                Console.WriteLine("not history");
                return;
            }

            string filePath = getHistorySavePath();
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write(JsonConvert.SerializeObject(history));
            }
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            string filePath = getHistorySavePath();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("not correct path file");
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            history = JsonConvert.DeserializeObject<History>(jsonString);
            Console.WriteLine("history" + history.Count.ToString());
        }


        private string getHistorySavePath()
        {
            if (!Directory.Exists(getHistorySaveDir()))
            {
                Directory.CreateDirectory(getHistorySaveDir());
            }
            return getHistorySaveDir() + textBoxPostfix.Text + ".json";
        }

        private string getHistorySaveDir()
        {
            return userName.Text + "/";
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            Config config = Config.GetConfig(this);
            using (StreamWriter streamWriter = new StreamWriter(configPath))
            {
                streamWriter.Write(JsonConvert.SerializeObject(config));
            }
        }

        private async void loadConfig_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(configPath);
            Config config = JsonConvert.DeserializeObject<Config>(jsonString);
            config.set(this);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            history.Clear();
        }
    }
}
