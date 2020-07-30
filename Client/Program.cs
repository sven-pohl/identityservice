using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private static async Task Main()
        {
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5001");

            if(disco.IsError) {
                Console.WriteLine(disco.Error);
                return;
            }
        }
    }
}
