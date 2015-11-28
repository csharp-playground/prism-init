using ModuleJw.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleJw
{
    public class ModuleJwModule : IModule
    {
        private IRegionManager _regionManager;

        public ModuleJwModule(IRegionManager manager)
        {
            _regionManager = manager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewB));
        }
    }
}
