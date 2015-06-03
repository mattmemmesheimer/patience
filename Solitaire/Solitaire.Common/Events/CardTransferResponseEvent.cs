using Microsoft.Practices.Prism.PubSubEvents;

namespace Solitaire.Common.Events
{
    /// <summary>
    /// Event raised in response to a <see cref="CardTransferRequestEvent"/>.
    /// The result is true if the card transfer is valid, false otherwise.
    /// </summary>
    public class CardTransferResponseEvent : PubSubEvent<bool>
    {
    }
}
