using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab5_1
{
    public class CurrencyAPIWrapper
    {
        static string baseUrl = @"https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/{0}/{1}.json";
        static HttpClient client = new HttpClient();
        public static async Task<decimal> GetCurrentCurrencyAsync(string currencyCode1, string currencyCode2)
        {
            var response = await client.GetAsync(string.Format(baseUrl, currencyCode1, currencyCode2));
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
            return decimal.Parse(result[currencyCode2].ToString());
        }
    }
}
