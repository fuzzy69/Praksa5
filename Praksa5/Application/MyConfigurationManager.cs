using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Praksa5
{
    class MyConfigurationManager
    {
        private Configuration configuration;

        public MyConfigurationManager()
        {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetKey(string key)
        {
            return ConfigurationManager.AppSettings[key]?? String.Empty;
        }

        public bool SetKey(string key, string value)
        {
            try
            {
                if (configuration.AppSettings.Settings.Count == 0 | configuration.AppSettings.Settings[key] == null)
                {
                    configuration.AppSettings.Settings.Add(key, value);
                }
                else
                {
                    configuration.AppSettings.Settings[key].Value = value;
                }
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
                return true;

            }
            catch (ConfigurationErrorsException ex)
            {
                return false;
            }
        }
    }
}
