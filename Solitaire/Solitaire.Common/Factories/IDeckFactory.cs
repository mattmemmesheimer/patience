using Solitaire.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Common.Factories
{
    public interface IDeckFactory
    {
        IDeck CreateDeck();
    }
}
