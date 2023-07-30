using ContollerBL.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainLinkConnect
{
    public partial class GyroForm : Form
    {
        public GyroHistory baseH;
        public GyroForm()
        {
            InitializeComponent();
        }

        public void BrainLinkSDK_OnGyroDataEvent(int X, int Y, int Z)
        {
            xvalue.Text = X.ToString();
            yvalue.Text = Y.ToString();
            zvalue.Text = Z.ToString();
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
