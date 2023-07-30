using BrainLinkConnect.service;
using BrainLinkSDK_Windows;
using InTheHand.Net.Sockets;
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

namespace BrainLinkConnect
{
    public interface FormWithConnect
    {
        void connect(long Address);
    }

    public partial class ConnectForm : Form
    {
        private BluetoothClient client = new BluetoothClient();

        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
        private List<(long, string)> Devices = new List<(long, string)>();

        FormWithConnect FormWithConnect;
        public ConnectForm(FormWithConnect f)
        {
            FormWithConnect = f;
            InitializeComponent();
            Start_Click(null, null);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < Devices.Count)
            {
                (long, string) Device = Devices[listBox1.SelectedIndex];
                FormWithConnect.connect(Device.Item1);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Click");

            var peers = client.DiscoverDevices();
            foreach (var peer in peers)
            {
                devices.Add(peer);
            }

            listBox1.Items.Clear();
            Devices.Clear();
        }

        public void BrainLinkSDK_OnDeviceFoundEvent(long Address, string Name)
        {
            Debug.WriteLine("Discover name " + Name);
            listBox1.Items.Add(Name + " : " + Address.ToString("X12"));
            Devices.Add((Address, Name));
        }
    }
}
