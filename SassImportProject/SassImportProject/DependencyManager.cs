using Autofac.Extensions.DependencyInjection;
using Autofac;
using SassImportProject.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SassImportProject.Contracts;

namespace SassImportProject
{
    public class DependencyManager
    {


        public static IContainer Ioc { get; private set; }
        public static IServiceProvider _serviceProvider;
        public static void SetupDependenies()
        {
            var builder = new ContainerBuilder();
            RegisterDependencies(builder);

            Ioc = builder.Build();
            _serviceProvider = new AutofacServiceProvider(Ioc);
        }
        private static void RegisterDependencies(ContainerBuilder builder)
        {

            builder.RegisterType<ReadCsvFile>().As<IReadCsvFile>().SingleInstance();
            builder.RegisterType<ReadJsonFile>().As<IReadJsonFile>().SingleInstance();

            builder.RegisterType<ReadTextFile>().As<IReadTextFile>().SingleInstance();
            builder.RegisterType<ReadYamlFile>().As<IReadYamlFile>().SingleInstance();

        }
    }
}


