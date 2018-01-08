using Microsoft.Extensions.Configuration;
using System;

namespace CommonSdk
{
    /// <summary>
    /// 项目目录下增加app.json做为配置文件
    /// </summary>
    public class ConfigurationManager
    {
        private static IConfigurationRoot config = null;
        static ConfigurationManager()
        {
            // Microsoft.Extensions.Configuration扩展包提供的
            var builder = new ConfigurationBuilder()
                .AddJsonFile("app.json");
            config = builder.Build();
        }

        public static IConfigurationRoot AppSettings
        {
            get
            {
                return config;
            }
        }

        public static string Get(string key)
        {
            return config[key];
        }

    }
}
