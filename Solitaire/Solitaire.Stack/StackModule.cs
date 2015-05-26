using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Solitaire.Stack
{
    public class StackModule : IModule
    {
        public StackModule(IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("TestRegion", typeof(StackModule));
        }

        private readonly IRegionViewRegistry _regionViewRegistry;
    }
}
