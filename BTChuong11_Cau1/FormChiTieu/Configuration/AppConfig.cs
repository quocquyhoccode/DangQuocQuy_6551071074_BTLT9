using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FormChiTieu.Configuration
{
    public class ConnectionStringsSettings
    {
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public class AppConfig
    {
        public ConnectionStringsSettings ConnectionStrings { get; set; } = new();
    }

    public static class ConfigurationManager
    {
        private static AppConfig? _instance;

        public static AppConfig Config
        {
            get
            {
                if (_instance == null)
                {
                    LoadConfiguration();
                }
                return _instance!;
            }
        }

        public static void LoadConfiguration()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;

            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

            _instance = new AppConfig();
            configuration.Bind(_instance);
        }

        public static string GetConnectionString()
        {
            return Config.ConnectionStrings.DefaultConnection;
        }
    }
}
