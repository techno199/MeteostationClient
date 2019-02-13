using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MeteostationClient
{
    public class HttpService
    {
        public static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(Constants.ServiceDomain)
        };
        public static string Username { get; set; } = "";
        public void OnMeasuredStats(object sender, StatisticsEventArgs args)
        {
            var body = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>(Constants.FormDataKeyTemperature, args.Temperature),
                    new KeyValuePair<string, string>(Constants.FormDataKeyHumidity, args.Humidity),
                    new KeyValuePair<string, string>(Constants.FormDataKeyMeasurementTime, args.MeasurementTime.ToString("yyyyMMddHHmmss"))
                });
            client.PostAsync(Constants.ApiSendStats, body);
        }

        public async Task<HttpResponseMessage> SignInAsync(string login, string password)
        {
            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>(Constants.FormDataKeyLogin, login),
                new KeyValuePair<string, string>(Constants.FormDataKeyPassword, password)
            });
           
            try
            {
                var res = await client.PostAsync(Constants.ApiLogin, body);
                res.EnsureSuccessStatusCode();
                Username = login;
                return res;
            }
            catch
            {
                throw new Exception("Error while logging in");
            }        
        }

        public async Task<HttpResponseMessage> SignUpAsync(string login, string password)
        {
            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>(Constants.FormDataKeyLogin, login),
                new KeyValuePair<string, string>(Constants.FormDataKeyPassword, password)
            });

            return await client.PostAsync(Constants.ApiRegister, body);
        }
    }
}
