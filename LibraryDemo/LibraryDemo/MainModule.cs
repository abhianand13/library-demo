using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace LibraryDemo
{
    [ModuleExport(typeof(MainModule))]
    public class MainModule : IModule
    {
        [Import]
        public IRegionManager Region { get; set; }

        public void Initialize()
        {
            Region.RequestNavigate("MainRegion", "BooksView");
        }
    }
}
