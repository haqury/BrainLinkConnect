using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContollerBL.service;

namespace BrainLinkConnect
{
    public partial class GyroForm : Form
    {
        private int x, y, z;
        public GyroHistory baseH;
        private ContollerBL.service.HeadTracker headTracer = new ContollerBL.service.HeadTracker();
        private string curKey = null;

        public GyroForm()
        {
            InitializeComponent();
        }

        public void BrainLinkSDK_OnGyroDataEvent(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
            xvalue.Text = X.ToString();
            yvalue.Text = Y.ToString();
            zvalue.Text = Z.ToString();

            curKey = headTracer.GetDirectionKey(X, Y, Z); 
        }

        public void Calibrete()
        {
            headTracer.Calibrate(x, y, z); 
        }

        public void deCalibrete()
        {
            headTracer.deCalibrate(); 
        }

        public bool isCalibrete()
        {
            return headTracer.isCalibrate(); 
        }

        public string getEventName()
        {
            curKey = headTracer.GetDirectionKey(x, y, z);
            return curKey;
        }


        private void GyroBase_Click(object sender, EventArgs e)
        {
        }

    }
    
    public class GyroHistory
    {
        public int Xvalue { get; set; }
        public int Yvalue { get; set; }
        public int Zvalue { get; set; }
    }
}
