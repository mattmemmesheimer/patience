using Microsoft.Practices.Prism.PubSubEvents;
using Solitaire.Common.Models;

namespace Solitaire.Common.Events
{
    /// <summary>
    /// Event raised to request a card be transferred.
    /// Subscribe to <see cref="CardTransferRequestEvent"/> to get the result of the request.
    /// </summary>
    public class CardTransferRequestEvent : PubSubEvent<Card>
    {

    }
}
