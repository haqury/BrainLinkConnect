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
using System.Net.Http;

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
    
    
// Define a class to represent the response structure
    public class ResponseModel
    {
        public string EventName { get; set; }
    }
    
    public class DataSender
    {
        private readonly HttpClient _client;

        public DataSender()
        {
            _client = new HttpClient();
            // Установите базовый URL, если он будет одинаковым для всех запросов
            _client.BaseAddress = new Uri("http://127.0.0.1:5000"); // Замените на адрес вашего сервера Flask
        }

        public async Task<string> SendDataGetAsync(object data)
        {
            // Преобразование объекта в JSON для отправки на сервер
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            // Отправка POST-запроса на /get эндпоинт
            HttpResponseMessage response = await _client.PostAsync("/get", content);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response
                var responseObject = JsonConvert.DeserializeObject<ResponseModel>(responseContent);

                // Access the predicted EventName
                return responseObject.EventName;

            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
        
        public string SendDataGet(object data)
        {
            try
            {
                // Преобразование объекта в JSON для отправки на сервер
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                // Отправка POST-запроса на /get эндпоинт и блокировка выполнения
                HttpResponseMessage response = _client.PostAsync("/get", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;

                    // Deserialize the JSON response
                    var responseObject = JsonConvert.DeserializeObject<ResponseModel>(responseContent);

                    // Access the predicted EventName
                    return responseObject.EventName;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public async Task<string> SendDataSetAsync(object data)
        {
            // Преобразование объекта в JSON для отправки на сервер
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            // Отправка POST-запроса на /set эндпоинт
            var response = await _client.PostAsync("/set", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
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
            if (f == null || f.EegFault == null)
            {
                return "";
            }
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
        public EegFaultModel EegFault { get; set; }
    }
}