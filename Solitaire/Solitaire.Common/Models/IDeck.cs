using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Models
{
    /// <summary>
    /// Interface defining a deck of cards.
    /// </summary>
    public interface IDeck
    {
        /// <summary>
        /// List of cards in the deck.
        /// </summary>
        List<Card> Cards { get; set; }

        /// <summary>
        /// Shuffles the deck.
        /// </summary>
        void Shuffle();
    }
}
