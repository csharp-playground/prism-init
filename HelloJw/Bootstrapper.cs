﻿using HelloJw.Views;
using ModuleJw;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace HelloJw
{
    public class Bootstrapper :  UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ModuleJwModule));
        }
    }
}
