using LibraryDemo.Helper;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace LibraryDemo
{
    public class ViewModelBase : NotifierBase
    {
        [Import]
        public IRegionManager RegionManager { get; set; }

        protected void NavigateToPage(string viewName)
        {
            RegionManager.RequestNavigate("MainRegion", viewName);
        }
    }
}
