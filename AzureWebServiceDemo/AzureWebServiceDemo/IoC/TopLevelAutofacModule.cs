using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using AzureWebServiceDemo.Repositories;

namespace AzureWebServiceDemo.IoC
{
    public class TopLevelAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SettingsRepository>().As<ISettingsRepository>();
            builder.RegisterType<ContactRepository>().As<IContactRepository>().SingleInstance();
        }
    }
}