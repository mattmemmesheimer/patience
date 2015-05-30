using Solitaire.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Factories
{
    public class StandardDeckFactory : IDeckFactory
    {
        public static readonly int NumCards = 52;

        public IDeck CreateDeck()
        {
            var deck = new StandardDeck
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
}
