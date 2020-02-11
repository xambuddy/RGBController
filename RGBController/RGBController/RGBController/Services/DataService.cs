using Newtonsoft.Json;
using RGBController.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RGBController.Services
{
    public class DataService
    {
        HttpClient _httpClient = new HttpClient();

        public async Task<bool> SendColor(RGB color)
        {
            _httpClient.BaseAddress = new Uri("https://rgbtrigger.azurewebsites.net");

            string jsonData = JsonConvert.SerializeObject(color);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/rgb?code=NseLrd6joN9gy6kNFo3lzHWyvYC6NSijQBL/l6UCUSZreUCd2KDAbA==", content);

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
