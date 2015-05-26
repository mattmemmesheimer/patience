using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;

namespace Solitaire.Common.Models
{
    public class SolitaireGameInstance : BindableBase
    {
        #region Constants

        public const int NumTableaus = 7;

        #endregion

        #region Properties

        public Deck Deck
        {
            get { return _deck; }
            set { SetProperty(ref _deck, value); }
        }

        public List<Card>[] Tableaus
        {
            get { return _tableaus; }
            set { SetProperty(ref _tableaus, value); }
        } 

        #endregion

        public SolitaireGameInstance()
        {
            var deck = Deck.StandardDeck;
            deck.Shuffle();
            Deck = deck;

            Tableaus = new List<Card>[NumTableaus];
            int current = 0;
            for (int i = 0; i < NumTableaus; i++)
            {
                Tableaus[i] = new List<Card>(i+1);
            }
            Tableaus[0].AddRange(Deck.Cards.GetRange(0, 1));
            Tableaus[1].AddRange(Deck.Cards.GetRange(1, 2));
            Tableaus[2].AddRange(Deck.Cards.GetRange(3, 3));
            Tableaus[3].AddRange(Deck.Cards.GetRange(6, 4));
            Tableaus[4].AddRange(Deck.Cards.GetRange(10, 5));
            Tableaus[5].AddRange(Deck.Cards.GetRange(15, 6));
            Tableaus[6].AddRange(Deck.Cards.GetRange(21, 7));
        }

        #region Fields

        private Deck _deck;
        private List<Card>[] _tableaus;

        #endregion
    }
}
