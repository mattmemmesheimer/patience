using System;
using Solitaire.Common.Models;

namespace Solitaire.Common.Events
{
    /// <summary>
    /// Arguments pertaining to <see cref="CardTransferRequestEvent"/>.
    /// </summary>
    public class CardTransferRequestEventArgs : EventArgs
    {
        /// <summary>
        /// Card to be transferred.
        /// </summary>
        public Card Card { get; set; }
    }
}
