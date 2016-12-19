using System;
using System.Net.Http;
using TelegramBot.TelegramClasses;
using Newtonsoft.Json;

namespace TelegramBot
{
    public class HttpClientTelegramConnector : ITelegramConnector
    {
        private const string TOKEN = "317153897:AAEaJbXn66RCL2DE5DzESVGOuJeG_r_eRfw"; 
        private readonly string SampleUrl = "https://api.telegram.org/bot";
        private HttpClient httpClient;

        public HttpClientTelegramConnector()
        {
            SampleUrl += TOKEN + '/';
            httpClient = new HttpClient();
        }
        public GetUpdatesClass GetUpdate()
        {
            return JsonConvert.DeserializeObject<GetUpdatesClass>(
                httpClient.GetStringAsync(SampleUrl + "getUpdates").Result
            );
        }

        public SendMessageClass SendMessage(int id, string message)
        {
            string requestparams = $"sendMessage?chat_id={id}&text={message}";
            return JsonConvert.DeserializeObject<SendMessageClass>(
                httpClient.GetStringAsync(SampleUrl + requestparams).Result
            );
        }
    }
}