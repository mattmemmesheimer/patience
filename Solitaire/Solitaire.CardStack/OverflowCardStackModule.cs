using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Solitaire.OverflowCardStack.Views;

namespace Solitaire.OverflowCardStack
{

    public class OverflowCardStackModule : IModule
    {
        public OverflowCardStackModule(IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("OverflowCardStackRegion",
                typeof (OverflowCardStackView));
        }

        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;

        #endregion
    }

}