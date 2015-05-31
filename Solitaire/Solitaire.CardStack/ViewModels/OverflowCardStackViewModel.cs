using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.OverflowCardStack.ViewModels
{

    /// <summary>
    /// View model for the overflow stack of cards.
    /// </summary>
    public class OverflowCardStackViewModel : BindableBase
    {
        #region Properties

        /// <summary>
        /// Top card of the left stack.
        /// </summary>
        public Card TopCard
        {
            get { return _topCard; }
            set { SetProperty(ref _topCard, value); }
        }

        /// <summary>
        /// Cards in the stack.
        /// </summary>
        public ObservableCollection<Card> DealtCards
        {
            get { return _dealtCards; }
            set { SetProperty(ref _dealtCards, value); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command to deal the stack of cards.
        /// </summary>
        public ICommand DealStackCommand { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new instanct of <see cref="OverflowCardStackViewModel" /> using the specified
        /// game instance.
        /// </summary>
        /// <param name="gameInstance">The solitaire game.</param>
        public OverflowCardStackViewModel(ISolitaireGameInstance gameInstance)
        {
            var stack = gameInstance.OverflowStack;
            _cards = new List<Card>(stack);
            _wasteStack = new List<Card>();
            DealtCards = new ObservableCollection<Card>();
            TopCard = stack[stack.Count - 1];

            DealStackCommand = new DelegateCommand(DealStack);
        }

        /// <summary>
        /// Deals the stack of cards.  Resets the stack if empty.
        /// </summary>
        /// <remarks>
        /// This method is a little over-complicated due the fact that lists are being
        /// used instead of actual stacks.
        /// </remarks>
        private void DealStack()
        {
            // Move the dealt stack to the waste stack.
            DealtCards.ToList().ForEach(c => c.FaceUp = false);
            _wasteStack.AddRange(DealtCards);
            DealtCards.Clear();

            if (_cards.Count == 0)
            {
                // Reset waste stack.
                _wasteStack.Reverse();
                _cards.AddRange(_wasteStack);
                _wasteStack.Clear();

                // Reset the top card.
                TopCard = _cards.Count > 0 ? _cards[_cards.Count - 1] : null;

                return;
            }

            int numToDeal = Math.Min(_cards.Count, 3);
            int index = _cards.Count - numToDeal;

            // Deal the next cards.
            var deal = _cards.GetRange(index, numToDeal);
            deal.Reverse();
            DealtCards.AddRange(deal);
            _cards.RemoveRange(index, numToDeal);
            DealtCards.ToList().ForEach(c => c.FaceUp = true);

            // Reset the top card.
            TopCard = _cards.Count > 0 ? _cards[_cards.Count - 1] : null;
        }

        #region Fields

        private readonly List<Card> _cards;
        private ObservableCollection<Card> _dealtCards;
        private readonly List<Card> _wasteStack;
        private Card _topCard;

        #endregion
    }

}