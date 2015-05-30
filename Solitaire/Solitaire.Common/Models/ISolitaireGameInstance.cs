using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Models
{
    /// <summary>
    /// Interface defining a solitaire game instance.
    /// </summary>
    public interface ISolitaireGameInstance
    {
        /// <summary>
        /// Deck of cards.
        /// </summary>
        IDeck Deck { get; set; }

        /// <summary>
        /// List of tableaus.
        /// </summary>
        List<Card>[] Tableaus { get; set; }

        /// <summary>
        /// Overflow stack of cards.
        /// </summary>
        List<Card> OverflowStack { get; set; }
    }
}
