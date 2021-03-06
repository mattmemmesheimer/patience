﻿using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Solitaire.Foundations.Views;

namespace Solitaire.Foundations
{

    public class FoundationsModule : IModule
    {
        public FoundationsModule(IRegionViewRegistry regionViewRegistry)
        {
            _regionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            _regionViewRegistry.RegisterViewWithRegion("FoundationsRegion", typeof (FoundationsView));
        }

        #region Fields

        private readonly IRegionViewRegistry _regionViewRegistry;

        #endregion
    }

}