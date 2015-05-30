using Solitaire.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Factories
{
    /// <summary>
    /// Interface defining a deck factory.
    /// </summary>
    public interface IDeckFactory
    {
        /// <summary>
        /// Creates a concrete instance of <see cref="IDeck"/>.
        /// </summary>
        /// <returns>Deck of cards.</returns>
        IDeck CreateDeck();
    }
}
