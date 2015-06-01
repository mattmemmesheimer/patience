using System.Collections.Generic;

namespace Solitaire.Common.Models
{
    public class Foundation
    {
        public List<Card> Cards { get; set; }

        public Foundation()
        {
            Cards = new List<Card>();
        }
    }
}
