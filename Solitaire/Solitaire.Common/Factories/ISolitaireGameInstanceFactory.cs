using Solitaire.Common.Models;

namespace Solitaire.Common.Factories
{
    /// <summary>
    /// Interface defining a Solitaire game instance factory.
    /// </summary>
    public interface ISolitaireGameInstanceFactory
    {
        /// <summary>
        /// Creates a concrete instance of <see cref="ISolitaireGameInstance"/>.
        /// </summary>
        /// <returns>Instance of a solitaire game.</returns>
        ISolitaireGameInstance CreateGameInstance();
    }
}
