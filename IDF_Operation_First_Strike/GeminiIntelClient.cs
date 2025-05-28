using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation_First_Strike
{
    internal class GeminiIntelClient
    {
       
            private readonly HttpClient _httpClient;
            private readonly string _apiKey;

            public GeminiIntelClient(string apiKey)
            {
                _httpClient = new HttpClient();
                _apiKey = apiKey;
            }

            public async Task<string> GetIntelAsync(string prompt)
            {
                string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={_apiKey}";

                var body = new
                {
                    contents = new[]
                    {
                new {
                    parts = new[] {
                        new { text = prompt }
                    }
                }
            }
                };

                var json = JsonSerializer.Serialize(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            
        }

    }
}
