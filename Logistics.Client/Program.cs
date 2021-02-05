using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using ConsoleTables;
using Logistics.Data.Dtos;

namespace Logistics.Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            //this should be injected
            var uri = new Uri("https://localhost:5001/api/shipping/generate");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

            var response = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseContentRead);

            var json = await response.Content.ReadAsStringAsync();
            var items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BoxItemDto>>(json);



            var table = new ConsoleTable("BoxId", "PartNumber", "PartWeight", "PartCost");


            foreach (var item in items)
            {
                table.AddRow(item.BoxId, item.PartNumber, item.PartWeight, item.PartCost);
            }

            table.Write();

            Console.ReadKey();

        }
    }

}
