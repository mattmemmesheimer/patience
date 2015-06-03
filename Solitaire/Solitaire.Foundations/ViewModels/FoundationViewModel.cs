using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Foundations.ViewModels
{
    public class FoundationViewModel : BindableBase
    {
        #region Properties

        public Card TopCard
        {
            get { return _topCard; }
            set { SetProperty(ref _topCard, value); }
        }

        /// <summary>
        /// Whether or not the stack of cards is empty.
        /// </summary>
        public bool CardsEmpty
        {
            get { return _cardsEmpty; }
            set { SetProperty(ref _cardsEmpty, value); }
        }

        #endregion

        public FoundationViewModel(IFoundation foundation)
        {
            _cards = new List<Card>(foundation.Cards);
            CardsEmpty = _cards.Count == 0;
            TopCard = CardsEmpty ? null : _cards[_cards.Count - 1];
        }

        #region Fields

        private List<Card> _cards;
        private Card _topCard;
        private bool _cardsEmpty;

        #endregion
    }
}
