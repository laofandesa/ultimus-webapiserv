using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace TCC_CoreApi.Common.Tool
{
    public class ConfigManager
    {
        private static IConfiguration _configuration;

        static ConfigManager()
        {
            //在当前目录或者根目录中寻找appsettings.json文件
            var fileName = "appsettings.json";

            var directory = AppContext.BaseDirectory;
            directory = directory.Replace("\\", "/");

            var filePath = $"{directory}/{fileName}";
            if (!File.Exists(filePath))
            {
                var length = directory.IndexOf("/bin");
                filePath = $"{directory.Substring(0, length)}/{fileName}";
            }

            var builder = new ConfigurationBuilder()
                .AddJsonFile(filePath, false, true);

            _configuration = builder.Build();
        }

        public static string GetSectionValue(string rootKey, string key)
        {
            return _configuration.GetSection(rootKey)[key];
        }
    }
}
