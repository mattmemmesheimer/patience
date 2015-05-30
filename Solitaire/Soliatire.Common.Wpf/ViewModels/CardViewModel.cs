using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Soliatire.Common.Wpf.ViewModels
{

    public class CardViewModel : BindableBase
    {
        #region Fields

        private Card _card;

        #endregion

        public Card Card
        {
            get { return _card; }
            set { SetProperty(ref _card, value); }
        }
    }

}