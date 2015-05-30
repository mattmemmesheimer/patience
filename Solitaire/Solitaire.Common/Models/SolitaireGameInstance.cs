using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Prism.Mvvm;

namespace Solitaire.Common.Models
{

    /// <summary>
    /// Class represnting an instance of a Klondike Solitaire game.
    /// </summary>
    public class SolitaireGameInstance : BindableBase, ISolitaireGameInstance
    {
        #region Constants

        /// <summary>
        /// Number of tableaus.
        /// </summary>
        public const int NumTableaus = 7;

        #endregion

        /// <summary>
        /// Initializes a new instance of <see cref="SolitaireGameInstance" /> using the
        /// specified deck of cards.
        /// </summary>
        /// <param name="deck">The deck of cards to use.</param>
        public SolitaireGameInstance(IDeck deck)
        {
            deck.Shuffle();
            Deck = deck;
            CreateTableaus();
            CreateOverflowStack();
        }

        private void CreateTableaus()
        {
            Tableaus = new List<Card>[NumTableaus];
            for (int tableauIndex = 0, rangeIndex = 0; tableauIndex < NumTableaus; tableauIndex++)
            {
                var numCards = tableauIndex + 1;
                Tableaus[tableauIndex] = Deck.Cards.GetRange(rangeIndex, numCards);
                rangeIndex = rangeIndex + numCards;
            }
        }

        private void CreateOverflowStack()
        {
            var numCardsInTableaus = 0;
            Tableaus.ToList().ForEach(t => numCardsInTableaus += t.Count);
            OverflowStack = Deck.Cards.GetRange(numCardsInTableaus,
                Deck.Cards.Count - numCardsInTableaus);
            var i = 5;
        }

        #region Properties

        /// <summary>
        /// Deck of cards.
        /// </summary>
        public IDeck Deck
        {
            get { return _deck; }
            set { SetProperty(ref _deck, value); }
        }

        /// <summary>
        /// List of tableaus.
        /// </summary>
        public List<Card>[] Tableaus
        {
            get { return _tableaus; }
            set { SetProperty(ref _tableaus, value); }
        }

        /// <summary>
        /// Overflow stack of cards.
        /// </summary>
        public List<Card> OverflowStack
        {
            get { return _overflowStack; }
            set { SetProperty(ref _overflowStack, value); }
        }

        #endregion

        #region Fields

        private IDeck _deck;
        private List<Card>[] _tableaus;
        private List<Card> _overflowStack;

        #endregion
    }

}