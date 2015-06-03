using System.Collections.Generic;

namespace Solitaire.Common.Models
{
    public class Foundation : IFoundation
    {
        public List<Card> Cards { get; set; }

        public Foundation()
        {
            Cards = new List<Card>();
        }
    }
}
