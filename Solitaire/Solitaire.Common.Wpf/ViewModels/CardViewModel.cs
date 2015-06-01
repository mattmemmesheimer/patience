using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Common.Wpf.ViewModels
{

    public class CardViewModel : BindableBase
    {
        public Card Card
        {
            get { return _card; }
            set { SetProperty(ref _card, value); }
        }

        #region Fields

        private Card _card;

        #endregion
    }

}