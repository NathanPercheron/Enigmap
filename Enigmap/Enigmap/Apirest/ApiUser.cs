using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Enigmap.Modéles;
using Newtonsoft.Json;

namespace Enigmap.Apirest
{
    class ApiUser
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            bool resultat = false;
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Identifiant", username),
                new KeyValuePair<string, string>("MotDePasse", password)
            };


            var request = new HttpRequestMessage(
                    HttpMethod.Post, Constantes.BaseApiAddress + "test");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);

            var content = await response.Content.ReadAsStringAsync();

            List<user> posts = JsonConvert.DeserializeObject<List<user>>(content);
            if (posts.Count == 1) resultat = true;

            return resultat;
        }
    }
}
