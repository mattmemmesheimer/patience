using Solitaire.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Factories
{
    /// <summary>
    /// Class representing a standard deck of cards.
    /// </summary>
    public class StandardDeckFactory : IDeckFactory
    {
        #region Constants

        /// <summary>
        /// Number of cards in the deck.
        /// </summary>
        public static readonly int NumCards = 52;

        #endregion

        /// <summary>
        /// Creates a new instance of <see cref="StardDeck"/>.
        /// </summary>
        /// <returns></returns>
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
