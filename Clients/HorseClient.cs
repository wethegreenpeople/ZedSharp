using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedSharp.Helpers;
using ZedSharp.Models;

namespace ZedSharp.Clients
{
    public class HorseClient
    {
        public async Task<Horse> GetHorseAsync (string address)
        {
            var request = new RestRequest("horses/roster", Method.GET, DataFormat.Json);
            request.AddUrlSegment("offset", address);
            request.AddUrlSegment("gen[]", 1);
            request.AddUrlSegment("gen[]", 268);

            var response = await RestHelper.Client.ExecuteGetAsync<List<Horse>>(request);
            return response.Data.OrderByDescending(s => s.Id).ToList()[0];
        }
    }
}
