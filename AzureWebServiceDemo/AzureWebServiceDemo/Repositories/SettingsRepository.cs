using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure;

namespace AzureWebServiceDemo.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        public string EnvironmentName { get { return CloudConfigurationManager.GetSetting("EnvironmentName"); } }
    }
}