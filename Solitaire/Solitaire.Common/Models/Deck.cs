using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;

namespace Solitaire.Common.Models
{
    public class Deck : BindableBase
    {
        #region Constants

        public const int NumCards = 52;

        #endregion

        #region Properties

        /// <summary>
        /// List of cards in the deck.
        /// </summary>
        public List<Card> Cards
        {
            get { return _cards; }
            set { SetProperty(ref _cards, value); }
        }

        /// <summary>
        /// Creates a standard deck of cards.
        /// </summary>
        public static Deck StandardDeck
        {
            get
            {
                var deck = new Deck
                {
                    Cards = new List<Card>(NumCards)
                };

                foreach (Card.Values value in Enum.GetValues(typeof(Card.Values)))
                {
                    foreach (Card.Suits suit in Enum.GetValues(typeof(Card.Suits)))
                    {
                        var card = new Card
                        {
                            Value = value,
                            Suit = suit
                        };
                        deck.Cards.Add(card);
                    }
                }

                return deck;
            }
        }

        #endregion

        public void Shuffle()
        {
            var r = new Random();
            for (int n = Cards.Count - 1; n > 0; n--)
            {
                int k = r.Next(n + 1);
                var temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
        }

        #region Fields

        private List<Card> _cards;

        #endregion
    }
}
