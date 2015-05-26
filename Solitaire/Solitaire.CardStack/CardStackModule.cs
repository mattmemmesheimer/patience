using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Solitaire.CardStack.Views;

namespace Solitaire.CardStack
{
    public class CardStackModule : IModule
    {
        public CardStackModule(IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("CardStackRegion", typeof (CardStackView));
        }

        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;

        #endregion
    }
}
