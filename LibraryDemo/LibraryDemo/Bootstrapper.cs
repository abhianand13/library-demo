using AutoMapper;
using LibraryDemo.ServiceRepository;
using LibraryDemo.ServiceRepository.LibraryService;
using Prism.Mef;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Windows;

namespace LibraryDemo
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            var executingAssembly = Assembly.GetExecutingAssembly();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(executingAssembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(IServiceRepository).Assembly));
        }

        protected override CompositionContainer CreateContainer()
        {
            var container = base.CreateContainer();
            container.ComposeExportedValue(container);
            return container;
        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            ConfigureAutoMapping();
            base.Run(runWithDefaultConfiguration);
        }

        public static void ConfigureAutoMapping()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<BookDTO, BookModel>();
                });

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<BookDTO, BookModel>();
                });
                config.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            {
                // TODO - Log error and exit application
            }
        }
    }
}
