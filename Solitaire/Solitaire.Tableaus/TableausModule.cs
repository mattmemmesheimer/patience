using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Solitaire.Tableaus.Views;

namespace Solitaire.Tableaus
{
    public class TableausModule : IModule
    {
        public TableausModule(IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("TableausRegion", typeof (TableausView));
        }

        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;

        #endregion
    }
}
