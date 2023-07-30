using BrainLinkSDK_Windows;
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
    public partial class EEGDataForm : Form
    {
        public EEGDataForm()
        {
            InitializeComponent();
        }

        private void EEGDataForm_Load(object sender, EventArgs e)
        {

        }

        public void BrainLinkSDK_OnEEGDataEvent(BrainLinkModel Model)
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
        }

            private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
