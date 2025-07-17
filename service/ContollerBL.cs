using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainLinkConnect.service;
using ConfigBrainLinkForm;
using ContollerBL;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ContollerBL.service
{
    public class ContollerBL
    {
        public dto.History History = new dto.History();

        public void load(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("not correct path file");
                return;
            }

            string jsonString = File.ReadAllText(path);
            History = JsonConvert.DeserializeObject<dto.History>(jsonString);
            Console.WriteLine("history" + History.Count.ToString());
        }

        public void save(string path)
        {
            if (History.Count() == 0)
            {
                Console.WriteLine("not history");
                return;
            }
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(JsonConvert.SerializeObject(History));
            }
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
            if (this.Count == 0) {
                return "";
            }

            var r = this.ToList();
            List<List<EegHistoryModel>> mr = new List<List<EegHistoryModel>>();
            List<EegFaultModel> ef = new List<EegFaultModel>(f.EegFaults);
            ef.Reverse();
            List<EegHistoryModel> g = new List<EegHistoryModel>(r);
            for (int i = 0; i < f.MultiCount; i++)
            {
                if (i != 0)
                {
                    g = mr[i - 1];
                }
                mr.Add(SearchEvents(g, brainLinkToServiseDto, ef[i]));
            }
            mr.Reverse();
            for (int i = 0; i < mr.Count; i++)
            {
                if (mr[i].Count == 0)
                {
                    continue;
                }
                List<EegHistoryModel> result = new List<EegHistoryModel>(mr[i].ToList());
                Dictionary<string, int> resCounts = new Dictionary<string, int>();

                resCounts["ml"] = result.FindAll(x => (x.EventName == "ml")).Count();
                resCounts["mr"] = result.FindAll(x => (x.EventName == "mr")).Count();
                resCounts["mu"] = result.FindAll(x => (x.EventName == "mu")).Count();
                resCounts["md"] = result.FindAll(x => (x.EventName == "md")).Count();
                resCounts["stop"] = result.FindAll(x => (x.EventName == "stop")).Count();

                Console.WriteLine(resCounts["ml"] + ", " + resCounts["mr"] + ", " + resCounts["mu"] + ", " + resCounts["md"] + "stop: " + resCounts["stop"] + " - on " + i);


                if (resCounts.OrderBy(x => x.Value) == null)
                {
                    continue;
                }
                return resCounts.OrderBy(x => x.Value).Last().Key;
            }
            return "";
        }

        public List<EegHistoryModel> SearchEvents(List<EegHistoryModel> result, EegHistoryModel brainLinkToServiseDto, EegFaultModel f)
        {
            if (f == null || f == null)
            {
                return result;
            }
            if (result.Count == 0) { return result; }
            if (f.Attention != 0)
            {
                result = result.FindAll(x => (x.Attention <= brainLinkToServiseDto.Attention + f.Attention) &&
                (brainLinkToServiseDto.Attention - f.Attention <= x.Attention));
            }
            if (result.Count == 0) { return result; }
            if (f.Meditation != 0)
            {
                result = result.FindAll(x => (x.Meditation <= brainLinkToServiseDto.Meditation + f.Meditation) &&
                (brainLinkToServiseDto.Meditation - f.Meditation <= x.Meditation));
            }
            if (result.Count == 0) { return result; }
            if (f.Delta != 0)
            {
                result = result.FindAll(x => (x.Delta <= brainLinkToServiseDto.Delta + f.Delta) &&
                (brainLinkToServiseDto.Delta - f.Delta <= x.Delta));
            }
            if (result.Count == 0) { return result; }
            if (f.Theta != 0)
            {
                result = result.FindAll(x => (x.Theta <= brainLinkToServiseDto.Theta + f.Theta) &&
                (brainLinkToServiseDto.Theta - f.Theta <= x.Theta));
            }
            if (result.Count == 0) { return result; }
            if (f.HighBeta != 0)
            {
                result = result.FindAll(x => (x.HighBeta <= brainLinkToServiseDto.HighBeta + f.HighBeta) &&
                (brainLinkToServiseDto.HighBeta - f.HighBeta <= x.HighBeta));
            }
            if (result.Count == 0) { return result; }
            if (f.LowBeta != 0)
            {
                result = result.FindAll(x => (x.LowBeta <= brainLinkToServiseDto.LowBeta + f.LowBeta) &&
                (brainLinkToServiseDto.LowBeta - f.LowBeta <= x.LowBeta));
            }
            if (result.Count == 0) { return result; }
            if (f.HighAlpha != 0)
            {
                result = result.FindAll(x => (x.HighAlpha <= brainLinkToServiseDto.HighAlpha + f.HighAlpha) &&
                (brainLinkToServiseDto.HighAlpha - f.HighAlpha <= x.HighAlpha));
            }
            if (result.Count == 0) { return result; }
            if (f.LowAlpha != 0)
            {
                result = result.FindAll(x => (x.LowAlpha <= brainLinkToServiseDto.LowAlpha + f.LowAlpha) &&
                (brainLinkToServiseDto.LowAlpha - f.LowAlpha <= x.LowAlpha));
            }
            if (result.Count == 0) { return result; }
            if (f.HighGamma != 0)
            {
                result = result.FindAll(x => (x.HighGamma <= brainLinkToServiseDto.HighGamma + f.HighGamma) &&
                (brainLinkToServiseDto.HighGamma - f.HighGamma <= x.HighGamma));
            }
            if (result.Count == 0) { return result; }
            if (f.LowGamma != 0)
            {
                result = result.FindAll(x => (x.LowGamma <= brainLinkToServiseDto.LowGamma + f.LowGamma) &&
                (brainLinkToServiseDto.LowGamma - f.LowGamma <= x.LowGamma));
            }

            return result;
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
        public EegFaultModel EegFault { get; set; }
        public EegFaultModel EegFaultMulti { get; set; }
        public int MultiCount { get; set; }
        public List<EegFaultModel> EegFaults { get; set; }
    }
}