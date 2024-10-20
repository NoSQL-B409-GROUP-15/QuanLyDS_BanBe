using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NOSQL.CloudService
{
    public class ServiceConfig
    {
        public static string CloudinaryCloudName { get; private set; }
        public static string CloudinaryApiKey { get; private set; }
        public static string CloudinaryApiSecret { get; private set; }

        static ServiceConfig()
        {

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = "..\\..\\CloudService\\CloudIServiceConfig.config"
            };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            CloudinaryCloudName = config.AppSettings.Settings["CloudinaryCloudName"].Value;
            CloudinaryApiKey = config.AppSettings.Settings["CloudinaryApiKey"].Value;
            CloudinaryApiSecret = config.AppSettings.Settings["CloudinaryApiSecret"].Value;
        }
    }
}
