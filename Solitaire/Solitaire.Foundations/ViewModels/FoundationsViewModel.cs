using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
using Solitaire.Common.Events;
using Solitaire.Common.Models;

namespace Solitaire.Foundations.ViewModels
{
    public class FoundationsViewModel : BindableBase
    {
        #region Properties

        public IDictionary<Card.Suits, IFoundation> Foundations { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new instance of <see cref="FoundationsViewModel"/> using the specified
        /// game instance.
        /// </summary>
        /// <param name="gameInstance">The solitaire game.</param>
        /// <param name="eventAggregator">Event aggregator.</param>
        public FoundationsViewModel(ISolitaireGameInstance gameInstance, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Foundations = new Dictionary<Card.Suits, IFoundation>(gameInstance.Foundations);
            _eventAggregator.GetEvent<CardTransferRequestEvent>().Subscribe(AcceptCard);
        }

        private void AcceptCard(CardTransferRequestEventArgs request)
        {
            var accepted = true;

            // TODO: Decide if the card transfer is valid.

            var result = new CardTransferResponseEventArgs
            {
                Card = request.Card,
                Accepted = accepted
            };
            _eventAggregator.GetEvent<CardTransferResponseEvent>().Publish(result);
        }

        #region Fields

        private readonly IEventAggregator _eventAggregator;

        #endregion
    }
}
