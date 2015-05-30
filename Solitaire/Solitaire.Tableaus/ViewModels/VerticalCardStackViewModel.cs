using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Tableaus.ViewModels
{

    public class VerticalCardStackViewModel : BindableBase
    {
        public VerticalCardStackViewModel(List<Card> cards)
        {
            Cards = new ObservableCollection<Card>();
            if (cards.Count > 2)
            {
                Cards.AddRange(cards.GetRange(0, cards.Count - 2));
            }
            if (cards.Count > 1)
            {
                BottomCard = cards[cards.Count - 2];
            }
            TopCard = cards[cards.Count - 1];
            TopCard.FaceUp = true;
        }

        #region Properties

        public ObservableCollection<Card> Cards
        {
            get { return _cards; }
            set { SetProperty(ref _cards, value); }
        }

        public Card BottomCard
        {
            get { return _bottomCard; }
            set { SetProperty(ref _bottomCard, value); }
        }

        public Card TopCard
        {
            get { return _topCard; }
            set { SetProperty(ref _topCard, value); }
        }

        #endregion

        #region Fields

        private ObservableCollection<Card> _cards;
        private Card _bottomCard;
        private Card _topCard;

        #endregion
    }

}