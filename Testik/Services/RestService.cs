using System;
using System.Diagnostics;
using System.Text.Json;
using Testik.Models;

namespace Testik.Services
{
	public class DataService
	{
		HttpClient _httpClient;
        JsonSerializerOptions _serializerOptions;

        public async Task<List<StdQuestion>> RefreshDataAsync()
        {
            var result = new List<StdQuestion>();
            Uri uri = new Uri(string.Format(Services.Constants.RestUrl, "data.json"));

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    result = JsonSerializer.Deserialize<List<StdQuestion>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return result;

        }

        public DataService()
		{
			_httpClient = new();
			_serializerOptions = new()
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				WriteIndented = true
			};
		}
	}
}

