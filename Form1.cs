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

using ConfigBrainLinkForm;


namespace BrainLinkConnect
{
    public partial class Form1 : Form, FormWithConfig, FormWithConnect
    {
        private BrainLinkSDK brainLinkSDK;
        private BrainLinkToServiseDto brainLinkToServiseDto = new BrainLinkToServiseDto();

        private ContollerBL.service.ContollerBL controllerBL = new ContollerBL.service.ContollerBL();

        private service.services services = new service.services();

        public ConfigParams config = new ConfigParams();
        
        public int OnEEGDataEventId = 1;

        private EegHistoryModel baseH = new EegHistoryModel();
        private GyroForm fg = new GyroForm();

        private UdpClient udpClient = new UdpClient();
        private UdpClient udpServer = new UdpClient(5001);
        private IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);

        private SystemService systemService = new SystemService();

        private BinaryFormatter bf = new BinaryFormatter();

        private MemoryStream ms = new MemoryStream();

        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
            private BluetoothClient client = new BluetoothClient();


        private EEGDataForm EEGDataForm;


        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private LowLevelKeyboardProc _proc;

        const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру
        const int
            WM_KEYDOWN = 0x100,       //Key down
            WM_KEYUP = 0x101;         //Key up

        private static IntPtr hhook = IntPtr.Zero;

        private static Form1 baseForm;

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN || code >= 0 && wParam == (IntPtr)260)
            {
                int vkCode = Marshal.ReadInt32(lParam); //Получить код клавиши
                Console.WriteLine(vkCode);
                baseForm.KeyDown(vkCode);
            }else if (code >= 0 && wParam == (IntPtr)WM_KEYUP || code >= 0 && wParam == (IntPtr)260)
            {
                int vkCode = Marshal.ReadInt32(lParam); //Получить код клавиши
                Console.WriteLine(vkCode);
                baseForm.KeyUp(vkCode);
            }
            return IntPtr.Zero;
        }

        public Form1()
        {
            systemService.config = new SystemServiceConfig();

            InitializeComponent();

            brainLinkSDK = new BrainLinkSDK();
            brainLinkSDK.OnEEGDataEvent += new BrainLinkSDKEEGDataEvent(BrainLinkSDK_OnEEGDataEvent);
            brainLinkSDK.OnEEGExtendEvent += new BrainLinkSDKEEGExtendDataEvent(BrainLinkSDK_OnEEGExtendDataEvent);

            baseForm = this;
            _proc = hookProc;
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public void setConfigFault(EegFaultModel config, EegFaultModel configMulti, int multiCount)
        {
            this.config.EegFault = config;
            this.config.EegFaults = new List<EegFaultModel>();

            this.config.EegFaults.Add(this.config.EegFault);
            for (int i = 1; i < multiCount; i++)
            {
                var conf = new EegFaultModel();
                conf.Attention = this.config.EegFaults[i - 1].Attention * configMulti.Attention;
                conf.Meditation = this.config.EegFaults[i - 1].Meditation * configMulti.Meditation;
                conf.LowAlpha = this.config.EegFaults[i - 1].LowAlpha * configMulti.LowAlpha;
                conf.LowBeta = this.config.EegFaults[i - 1].LowBeta * configMulti.LowBeta;
                conf.LowGamma = this.config.EegFaults[i - 1].LowGamma * configMulti.LowGamma;
                conf.HighAlpha = this.config.EegFaults[i - 1].HighAlpha * configMulti.HighAlpha;
                conf.HighBeta = this.config.EegFaults[i - 1].HighBeta * configMulti.HighBeta;
                conf.HighGamma = this.config.EegFaults[i - 1].HighGamma * configMulti.HighGamma;
                conf.Delta = this.config.EegFaults[i - 1].Delta * configMulti.Delta;
                conf.Theta = this.config.EegFaults[i - 1].Theta * configMulti.Theta;
                this.config.EegFaults.Add(conf);
            }
            this.config.MultiCount = multiCount;
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
            brainLinkSDK.Start();
            ConnectForm formConn = new ConnectForm(this);
            formConn.Show();
            brainLinkSDK.OnDeviceFound = new BrainLinkSDKOnDeviceFoundEvent(formConn.BrainLinkSDK_OnDeviceFoundEvent);
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

            //this.runGyro(h);

            //if (fg.UseGyro.Checked == true) {
            //    string eventName = fg.getEventName();
            //    h.EventName = eventName;
            //}

            h.EventName = getEventName();

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

        private void runGyro(EegHistoryModel h)
        {
            if (h.Meditation >= 40)
            {
                if (fg.isCalibrete() == false)
                {
                    fg.Calibrete();
                }
                else
                {
                    string eventName = fg.getEventName();
                    h.EventName = eventName;
                    services.mouse.play(h, config, this.adeptEventName(h.EventName), true);
                }
            }
            else
            {
                fg.deCalibrete();
            }
        }

        private string adeptEventName(string name)
        {
            if (name == "left")
            {
                return "ml";
            }
            else if (name == "right")
            {
                return "mr";
            }
            else if (name == "up")
            {
                return "mu";
            }
            else if (name == "down")
            {
                return "md";
            }
            return "";
        }

        private string getEventName()
        {
            if (checkBoxMl.Checked)
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

            else if (checkBoxStop.Checked)
            {
                return "stop";
            }
            return "";
        }


        private void onEEGDataEventChangeTable(BrainLinkModel Model)
        {
            if (EEGDataForm != null)
            {
                EEGDataForm.BrainLinkSDK_OnEEGDataEvent(Model);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            //Debug.WriteLine("Click");
            //brainLinkSDK.Start();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            brainLinkSDK.SetApEnable(checkBox1.Checked);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnhookWindowsHookEx(hhook); //Остановить хук
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

        public void connect(long Address)
        {
            brainLinkSDK.connect(Address);
        }

        private void saveToFileB_Click(object sender, EventArgs e)
        {
            controllerBL.save(FilePath.Text);
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            controllerBL.load(FilePath.Text);
            CounterL.Text = controllerBL.History.Count().ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            controllerBL.History.Clear();
        }

        private const int VK_LEFT = 37;
        private const int VK_RIGHT = 39;
        private const int VK_UP = 38;
        private const int VK_DOWN = 40;

        public void KeyDown(int m)
        {
            if (m == VK_LEFT)
            {
                checkBoxMl.Checked = true;
            }
            else if (m == VK_RIGHT)
            {
                checkBoxMr.Checked = true;
            }
            else if (m == VK_UP)
            {
                checkBoxMu.Checked = true;
            }
            else if (m == VK_DOWN)
            {
                checkBoxMd.Checked = true;
            }
        }

        public void KeyUp(int m)
        {
            if (m == VK_LEFT)
            {
                checkBoxMl.Checked = false;
            }
            else if (m == VK_RIGHT)
            {
                checkBoxMr.Checked = false;
            }
            else if (m == VK_UP)
            {
                checkBoxMu.Checked = false;
            }
            else if (m == VK_DOWN)
            {
                checkBoxMd.Checked = false;
            }
        }

        private void ConfigFault_Click(object sender, EventArgs e)
        {
            ConfigFaultForm newForm = new ConfigFaultForm(this);
            newForm.Show();
        }

        private void EEGDataButton_Click(object sender, EventArgs e)
        {
            if (EEGDataForm == null)
            {
                EEGDataForm = new EEGDataForm();
                EEGDataForm.Show();
            }
        }

        private void BrowseB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\BLconfig";
            openFile.Title = "Browse Json Files Only";
            openFile.Filter = "Json Files Only (*.json) | *.json";
            openFile.DefaultExt = "json";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = openFile.FileName;
            }
        }

        private void HRVView_Click(object sender, EventArgs e)
        {
            HRVForm hrv = new HRVForm();
            hrv.Show();

            brainLinkSDK.OnHRVDataEvent = new BrainLinkSDKHRVDataEvent(hrv.BrainLinkSDK_OnHRVDataEvent);
        }

        private void Gyro_Click(object sender, EventArgs e)
        {
            fg.Show();

            brainLinkSDK.OnGyroDataEvent += new BrainLinkSDKGyroDataEvent(fg.BrainLinkSDK_OnGyroDataEvent);

            brainLinkSDK.SetGyroEnable(true);
        }

        private void Diagram_Click(object sender, EventArgs e)
        {
            StateForm stateForm = new StateForm();
            stateForm.Show();

            brainLinkSDK.OnRawDataEvent += new BrainLinkSDKRawDataEvent(stateForm.BrainLinkSDK_OnRawDataEvent);

        }
    }
}
