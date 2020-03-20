using System;
using Microsoft.Extensions.Configuration;

namespace RoboSter.Utilities.Configuration
{
    public class AppSettingsJsonConfig : IConfig
    {
        private readonly IConfiguration configuration;

        public AppSettingsJsonConfig(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetValue(string key)
        {
            return configuration[key];
        }
        
        public T GetValue<T>(string key, Func<string, T> converter)
        {
            return converter(configuration[key]);
        }
    }
}