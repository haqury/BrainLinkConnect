using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using ContollerBL.dto;

namespace ConfigBrainLinkForm
{
    public interface FormWithConfig
    {
        void setConfigFault(EegFaultModel config);
        EegFaultModel getConfigFault();
    }

    public partial class ConfigFaultForm : Form
    {
        FormWithConfig BaseForm;
        public ConfigFaultForm(FormWithConfig form)
        {
            BaseForm = form;
            InitializeComponent();
            try
            {
                LoadConfigFromConfig(form.getConfigFault());
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private EegFaultModel GetConfigFault()
        {
            EegFaultModel config = new EegFaultModel();
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return config;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            BaseForm.setConfigFault(GetConfigFault());
        }

        private void loadConfig_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(FilePath.Text);
            LoadConfigFromJson(jsonString);
        }

        private void LoadConfigFromJson(string jsonString)
        {
            try
            {
                EegFaultModel config = JsonSerializer.Deserialize<EegFaultModel>(jsonString);
                LoadConfigFromConfig(config);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadConfigFromConfig(EegFaultModel config)
        {
            try
            {
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
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                EegFaultModel config = GetConfigFault();
                using (StreamWriter streamWriter = new StreamWriter(FilePath.Text))
                {
                    streamWriter.Write(JsonSerializer.Serialize(config));
                }
            } catch { 
                
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

        private void FilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class EegFaultModel
    {
        public int Attention { get; set; }
        public int Meditation { get; set; }
        public int Signal { get; set; }
        public int Delta { get; set; }
        public int Theta { get; set; }
        public int LowAlpha { get; set; }
        public int HighAlpha { get; set; }
        public int LowBeta { get; set; }
        public int HighBeta { get; set; }
        public int LowGamma { get; set; }
        public int HighGamma { get; set; }
    }
}
