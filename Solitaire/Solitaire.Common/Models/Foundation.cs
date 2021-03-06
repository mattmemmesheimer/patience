﻿using System.Collections.Generic;

namespace Solitaire.Common.Models
{
    /// <summary>
    /// Interface defining a foundation.
    /// </summary>
    public class Foundation : IFoundation
    {
        /// <summary>
        /// Cards in the foundation.
        /// </summary>
        public List<Card> Cards { get; set; }

        /// <summary>
        /// Top card in the foundation.
        /// </summary>
        /// <remarks>
        /// Can be null if the foundation is empty.
        /// </remarks>
        public Card TopCard
        {
            get { return Cards.Count == 0 ? null : Cards[Cards.Count - 1]; }
        }

        /// <summary>
        /// Suit of the foundation.
        /// </summary>
        public Card.Suits Suit { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Foundation"/>.
        /// </summary>
        public Foundation(Card.Suits suit)
        {
            Suit = suit;
            Cards = new List<Card>();
        }

        /// <summary>
        /// Attempts to add a card to this foundation.
        /// </summary>
        /// <param name="card">Card to add.</param>
        /// <returns>True if the card was added, false otherwise.</returns>
        public bool AddCard(Card card)
        {
            bool accepted;

            // Do not accept a card of a different suit than this foundation.
            if (card.Suit != Suit)
            {
                return false;
            }

            if (Cards.Count == 0)
            {
                // Special case for when the foundation is empty.
                // Only accept an Ace.
                accepted = card.Value == Card.Values.Ace;
            }
            else
            {
                var topCard = Cards[Cards.Count - 1];
                if (topCard.Value == Card.Values.Ace)
                {
                    // Special case for when the foundation only contains an Ace.
                    // Only accept a two.
                    accepted = card.Value == Card.Values.Two;
                }
                else
                {
                    // General case.
                    // Only accept the next card value.
                    accepted = topCard.Value == card.Value + 1;
                }
            }

            // Add the card to the foundation if is was accepted.
            if (accepted)
            {
                Cards.Add(card);
            }

            return accepted;
        }
    }
}
