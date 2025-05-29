//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace IDF_Operation_First_Strike
//{
//    internal class GeminiIntelClient
//    {

//        private readonly HttpClient _httpClient;
//        private readonly string _apiKey;

//        public GeminiIntelClient(string apiKey)
//        {
//            _httpClient = new HttpClient();
//            _apiKey = apiKey;
//        }

//        public async Task<string> GetIntelAsync(string prompt)
//        {
//            var endPoint = new Uri($"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={_apiKey}");


//        }

//    }
//}
