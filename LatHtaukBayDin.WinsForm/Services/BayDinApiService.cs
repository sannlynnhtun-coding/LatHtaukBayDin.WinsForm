using LatHtaukBayDin.WinsForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LatHtaukBayDin.WinsForm.Services
{
    public class BayDinApiService
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _httpClient2;
        public BayDinApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://www.ydnp.net") };
            _httpClient2 = new HttpClient { BaseAddress = new Uri("https://bd.ydnp.net/") };
        }

        public async Task<BayDinModel> QuestionListAysnc()
        {
            var model = await _httpClient.GetFromJsonAsync<BayDinModel>("baydin/_next/data/HmAmLWm8d-Je6rehKaa27/index.json");
            return model;
        }

        public async Task<Question> AnswerAsync(int qId)
        {
            string resource = $"api/v1/reqans.ashx?count=true&qId={qId}";
            var result = await _httpClient2.GetAsync(resource);
            var jsonStr = await result.Content.ReadAsStringAsync();
            Question model = JsonConvert.DeserializeObject<Question[]>(jsonStr)[0];
            return model;
        }
    }
}
