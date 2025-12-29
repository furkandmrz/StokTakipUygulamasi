using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace StokTakipUygulaması.Helpers
{
    public static class TelegramHelper
    {
        static string token = "8589444856:AAHR4XAyUmqBXHolQj0-uPI8qYt4zVQRnZM";
        static string chatId = "1469296618";

        public static async void MesajGonder(string mesaj)
        {
            string url =
                $"https://api.telegram.org/bot{token}/sendMessage" +
                $"?chat_id={chatId}&text={mesaj}";

            using (HttpClient client = new HttpClient())
            {
                await client.GetAsync(url);
            }
        }
    }
}


