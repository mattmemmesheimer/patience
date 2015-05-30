using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;

namespace Solitaire.Common.Models
{
    public class StandardDeck : BindableBase, IDeck
    {
        #region Constants

        /// <summary>
        /// Number of cards in the deck.
        /// </summary>
        public static readonly int NumCards = 52;

        #endregion

        #region Properties

        /// <summary>
        /// List of cards in the deck.
        /// </summary>
        public List<Card> Cards
        {
            get { return _cards; }
            set { SetProperty(ref _cards, value); }
        }

        #endregion

        /// <summary>
        /// Shuffles the deck of cards using the Fisher-Yates method.
        /// </summary>
        public void Shuffle()
        {
            var r = new Random();
            for (int n = Cards.Count - 1; n > 0; n--)
            {
                int k = r.Next(n + 1);
                var temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
        }

        #region Fields

        private List<Card> _cards;

        #endregion
    }
}
