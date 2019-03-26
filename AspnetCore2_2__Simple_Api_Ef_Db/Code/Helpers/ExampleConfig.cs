using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace template.Helpers
{
    public class ExampleConfig
    {
        public string ExampleApiPrivateKey { get; set; }
        public string ExampleApiBaseUrl { get; set; }


        public ExampleConfig(IConfiguration config)
        {
            var apiConfig = config.GetSection("ExampleConfig");

            ExampleApiPrivateKey = apiConfig["PrivateKey"];
            ExampleApiBaseUrl = apiConfig["BaseUrl"];
        }
    }
}
