using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace ServiceProxy
{
    public sealed class NetworkWorldBuilder
    {
        private async Task<IEnumerable<BuildCommand>> BuildAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("localhost:8080");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("map");

                if (response.IsSuccessStatusCode)
                {
                    String world = await response.Content.ReadAsStringAsync();
                    
                }
            }

            return null;
        }

        public IAsyncOperation<IEnumerable<BuildCommand>> GetWorldAsync()
        {
            return BuildAsync().AsAsyncOperation();
        }
    }
}
