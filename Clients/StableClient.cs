using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedSharp.Helpers;
using ZedSharp.Models;

namespace ZedSharp.Clients
{
    public class StableClient
    {
        public async Task<List<Horse>> GetStableHorsesAsync(string address)
        {
            var request = new RestRequest("horses/get_user_horses", Method.GET);
            request.AddQueryParameter("public_address", address);

            var response = await RestHelper.Client.ExecuteGetAsync<List<Horse>>(request);
            return response.Data.OrderByDescending(s => s.Id).ToList();
        }

        public async Task<Stable> GetStableAsync(string stableName)
        {
            var request = new RestRequest($"users/stable/{stableName}", Method.GET);

            var response = await RestHelper.Client.ExecuteGetAsync<Stable>(request);
            return response.Data;
        }
    }
}
