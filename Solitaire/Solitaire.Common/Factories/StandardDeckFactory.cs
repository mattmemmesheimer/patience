using System;
using System.Collections.Generic;
using Solitaire.Common.Models;

namespace Solitaire.Common.Factories
{

    /// <summary>
    /// Factory class used to create instances of <see cref="StandardDeck"/>.
    /// </summary>
    public class StandardDeckFactory : IDeckFactory
    {
        /// <summary>
        /// Creates a new instance of <see cref="StandardDeck" />.
        /// </summary>
        /// <returns></returns>
        public IDeck CreateDeck()
        {
            var deck = new StandardDeck
            {
                Cards = new List<Card>(StandardDeck.NumCards)
            };

            foreach (Card.Values value in Enum.GetValues(typeof (Card.Values)))
            {
                foreach (Card.Suits suit in Enum.GetValues(typeof (Card.Suits)))
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