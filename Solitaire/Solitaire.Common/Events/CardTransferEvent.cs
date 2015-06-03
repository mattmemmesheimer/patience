using Microsoft.Practices.Prism.PubSubEvents;
using Solitaire.Common.Models;

namespace Solitaire.Common.Events
{
    public class CardTransferEvent : PubSubEvent<Card>
    {

    }
}
