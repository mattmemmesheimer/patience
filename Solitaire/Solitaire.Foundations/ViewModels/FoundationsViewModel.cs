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

        public List<FoundationViewModel> Foundations { get; set; }

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
            Foundations = new List<FoundationViewModel>(gameInstance.Foundations.Length);
            foreach (var foundation in gameInstance.Foundations)
            {
                Foundations.Add(new FoundationViewModel(foundation));
            }

            _eventAggregator.GetEvent<CardTransferRequestEvent>().Subscribe(AcceptCard);
        }

        private void AcceptCard(Card card)
        {
            var result = true;

            // TODO: Decide if the card transfer is valid.

            _eventAggregator.GetEvent<CardTransferResponseEvent>().Publish(result);
        }

        #region Fields

        private readonly IEventAggregator _eventAggregator;

        #endregion
    }
}
