using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Enigmap.Modéles;
using Newtonsoft.Json;

namespace Enigmap.Apirest
{
    class ApiDéfis
    {
        public static async Task GetDéfisAsync()
        {
            //reset des collections de classes
            Défis.CollClassDéfis.Clear();

            //Recuperations des données (personne et outils) depuis l'API

            var client = new HttpClient();

            var json = await client.GetStringAsync(Constantes.BaseApiAddress + "api/Défis.json");
            JsonConvert.DeserializeObject<List<Défis>>(json);

        }
    }
}
