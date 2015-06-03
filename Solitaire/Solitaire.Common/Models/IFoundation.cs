using System.Collections.Generic;

namespace Solitaire.Common.Models
{
    /// <summary>
    /// Interface defining a foundation.
    /// </summary>
    public interface IFoundation
    {
        /// <summary>
        /// Cards in the foundation.
        /// </summary>
        List<Card> Cards { get; set; }

        /// <summary>
        /// Attempts to add a card to this foundation.
        /// </summary>
        /// <param name="card">Card to add.</param>
        /// <returns>True if the card was added, false otherwise.</returns>
        bool AddCard(Card card);
    }

}