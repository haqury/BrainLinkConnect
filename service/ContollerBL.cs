using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainLinkConnect.service;
using ContollerBL;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ContollerBL.service
{
    public class ContollerBL
    {
        public dto.History History = new dto.History();

        public void load(string path, string postfix)
        {
            string filePath = getHistorySavePath(path, postfix);
            if (!File.Exists(filePath))
            {
                Console.WriteLine("not correct path file");
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            History = JsonConvert.DeserializeObject<dto.History>(jsonString);
            Console.WriteLine("history" + History.Count.ToString());
        }

        public void save(string path, string postfix)
        {
            string filePath = getHistorySavePath(path, postfix);
            if (History.Count() == 0)
            {
                Console.WriteLine("not history");
                return;
            }
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write(JsonConvert.SerializeObject(History));
            }
        }

        private string getHistorySavePath(string path, string postfix)
        {
            if (!Directory.Exists(getHistorySaveDir(path)))
            {
                Directory.CreateDirectory(getHistorySaveDir(path));
            }
            return getHistorySaveDir(path) + "/" + postfix + ".json";
        }

        private string getHistorySaveDir(string path)
        {
            return path + "/";
        }
    }
}


namespace ContollerBL.dto
{
    public class History : List<EegHistoryModel>
    {
        public string getEventNameBy(EegHistoryModel brainLinkToServiseDto, ConfigParams f)
        {
            var result = this.ToList();

            if (f.EegFault.Attention != 0)
            {
                result = result.FindAll(x => (x.Attention <= brainLinkToServiseDto.Attention + f.EegFault.Attention) &&
                (brainLinkToServiseDto.Attention - f.EegFault.Attention <= x.Attention));
            }
            if (f.EegFault.Meditation != 0)
            {
                result = result.FindAll(x => (x.Meditation <= brainLinkToServiseDto.Meditation + f.EegFault.Meditation) &&
                (brainLinkToServiseDto.Meditation - f.EegFault.Meditation <= x.Meditation));
            }
            if (f.EegFault.Delta != 0)
            {
                result = result.FindAll(x => (x.Delta <= brainLinkToServiseDto.Delta + f.EegFault.Delta) &&
                (brainLinkToServiseDto.Delta - f.EegFault.Delta <= x.Delta));
            }
            if (f.EegFault.Theta != 0)
            {
                result = result.FindAll(x => (x.Theta <= brainLinkToServiseDto.Theta + f.EegFault.Theta) &&
                (brainLinkToServiseDto.Theta - f.EegFault.Theta <= x.Theta));
            }
            if (f.EegFault.HighBeta != 0)
            {
                result = result.FindAll(x => (x.HighBeta <= brainLinkToServiseDto.HighBeta + f.EegFault.HighBeta) &&
                (brainLinkToServiseDto.HighBeta - f.EegFault.HighBeta <= x.HighBeta));
            }
            if (f.EegFault.LowBeta != 0)
            {
                result = result.FindAll(x => (x.LowBeta <= brainLinkToServiseDto.LowBeta + f.EegFault.LowBeta) &&
                (brainLinkToServiseDto.LowBeta - f.EegFault.LowBeta <= x.LowBeta));
            }
            if (f.EegFault.HighAlpha != 0)
            {
                result = result.FindAll(x => (x.HighAlpha <= brainLinkToServiseDto.HighAlpha + f.EegFault.HighAlpha) &&
                (brainLinkToServiseDto.HighAlpha - f.EegFault.HighAlpha <= x.HighAlpha));
            }
            if (f.EegFault.LowAlpha != 0)
            {
                result = result.FindAll(x => (x.LowAlpha <= brainLinkToServiseDto.LowAlpha + f.EegFault.LowAlpha) &&
                (brainLinkToServiseDto.LowAlpha - f.EegFault.LowAlpha <= x.LowAlpha));
            }
            if (f.EegFault.HighGamma != 0)
            {
                result = result.FindAll(x => (x.HighGamma <= brainLinkToServiseDto.HighGamma + f.EegFault.HighGamma) &&
                (brainLinkToServiseDto.HighGamma - f.EegFault.HighGamma <= x.HighGamma));
            }
            if (f.EegFault.LowGamma != 0)
            {
                result = result.FindAll(x => (x.LowGamma <= brainLinkToServiseDto.LowGamma + f.EegFault.LowGamma) &&
                (brainLinkToServiseDto.LowGamma - f.EegFault.LowGamma <= x.LowGamma));
            }

            if (result.Count != 0)
            {
                Dictionary<string, int> resCounts = new Dictionary<string, int>();

                resCounts["ml"] = result.FindAll(x => (x.EventName == "ml")).Count();
                resCounts["mr"] = result.FindAll(x => (x.EventName == "mr")).Count();
                resCounts["mu"] = result.FindAll(x => (x.EventName == "mu")).Count();
                resCounts["md"] = result.FindAll(x => (x.EventName == "md")).Count();

                Console.WriteLine(resCounts["ml"] + ", " + resCounts["mr"] + ", " + resCounts["mu"] + ", " + resCounts["md"]);

                return resCounts.OrderBy(x => x.Value).Last().Key;
            }
            else
            {
                return "";
            }
        }

        public List<EegHistoryModel> check(int param, int fault, List<EegHistoryModel> list)
        {
            if (fault != 0)
            {
                return list.FindAll(x => (x.Theta <= param + fault) && (param - fault <= x.Theta));
            }
            return list;
        }

}


    public class EegHistoryModel
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
        public string EventName { get; set; }
    }

    public class EegHistoryIsUsed
    {
        public bool Attention { get; set; }
        public bool Meditation { get; set; }
        public bool Signal { get; set; }
        public bool Delta { get; set; }
        public bool Theta { get; set; }
        public bool LowAlpha { get; set; }
        public bool HighAlpha { get; set; }
        public bool LowBeta { get; set; }
        public bool HighBeta { get; set; }
        public bool LowGamma { get; set; }
        public bool HighGamma { get; set; }
    }


    public class ConfigParams
    {
        public EegHistoryModel EegFault { get; set; }
    }
}