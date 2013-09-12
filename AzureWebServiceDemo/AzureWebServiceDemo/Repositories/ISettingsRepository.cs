using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureWebServiceDemo.Repositories
{
    public interface ISettingsRepository
    {
        string EnvironmentName { get; }
    }
}