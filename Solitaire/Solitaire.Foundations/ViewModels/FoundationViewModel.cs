using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Foundations.ViewModels
{
    public class FoundationViewModel : BindableBase
    {
        #region Properties

        /// <summary>
        /// Top card in the foundation.
        /// </summary>
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
            CardsEmpty = foundation.Cards.Count == 0;
            TopCard = foundation.TopCard;
            _foundation = foundation;
        }

        public bool AddCard(Card card)
        {
            var accepted = _foundation.AddCard(card);
            if (accepted)
            {
                if (CardsEmpty)
                {
                    CardsEmpty = false;
                }
                TopCard = _foundation.TopCard;
            }
            return accepted;
        }

        #region Fields

        private readonly IFoundation _foundation;
        private Card _topCard;
        private bool _cardsEmpty;

        #endregion
    }
}
