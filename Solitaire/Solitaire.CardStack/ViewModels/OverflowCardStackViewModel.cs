using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.OverflowCardStack.ViewModels
{

    /// <summary>
    /// View model for the overflow stack of cards.
    /// </summary>
    public class OverflowCardStackViewModel : BindableBase
    {
        #region Properties

        /// <summary>
        /// Cards in the stack.
        /// </summary>
        public ObservableCollection<Card> Cards
        {
            get { return _cards; }
            set { SetProperty(ref _cards, value); }
        }

        #endregion

        /// <summary>
        /// Initializes a new instanct of <see cref="OverflowCardStackViewModel" /> using the specified
        /// game instance.
        /// </summary>
        /// <param name="gameInstance">The solitaire game.</param>
        public OverflowCardStackViewModel(ISolitaireGameInstance gameInstance)
        {
            Cards = new ObservableCollection<Card>(gameInstance.OverflowStack);
        }

        #region Fields

        private ObservableCollection<Card> _cards;

        #endregion
    }

}