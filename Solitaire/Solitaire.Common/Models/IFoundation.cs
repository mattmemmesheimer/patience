using System.Collections.Generic;

namespace Solitaire.Common.Models
{

    public interface IFoundation
    {
        List<Card> Cards { get; set; }
    }

}