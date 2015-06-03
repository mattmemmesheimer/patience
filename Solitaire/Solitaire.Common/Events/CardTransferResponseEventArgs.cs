using System;
using Solitaire.Common.Models;

namespace Solitaire.Common.Events
{
    /// <summary>
    /// Arguments pertaining to <see cref="CardTransferResponseEvent"/>.
    /// </summary>
    public class CardTransferResponseEventArgs : EventArgs
    {
        /// <summary>
        /// Subject of the card transfer request.
        /// </summary>
        public Card Card { get; set; }

        /// <summary>
        /// Whether or not the card transfer request was accepted.
        /// </summary>
        public bool Accepted { get; set; }
    }
}
