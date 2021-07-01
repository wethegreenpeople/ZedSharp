using RestSharp;
using RestSharp.Serializers.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZedSharp.Helpers
{
    public static class RestHelper
    {
        private static RestClient _client = null;
        public static RestClient Client
        {
            get
            {
                if (_client != null) return _client;
                _client = new RestClient("https://api.zed.run/api/v1/");
                _client.UseSystemTextJson();

                return _client;
            }
        }
    }
}
