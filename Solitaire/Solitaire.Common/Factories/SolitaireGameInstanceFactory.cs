using Solitaire.Common.Models;

namespace Solitaire.Common.Factories
{
    /// <summary>
    /// Factory class used to create instances of <see cref="ISolitaireGameInstance"/>.
    /// </summary>
    public class SolitaireGameInstanceFactory : ISolitaireGameInstanceFactory
    {
        /// <summary>
        /// Creates a concrete instance of <see cref="ISolitaireGameInstance"/>.
        /// </summary>
        /// <returns>Instance of a solitaire game.</returns>
        public ISolitaireGameInstance CreateGameInstance()
        {
            IDeckFactory deckFactory = new StandardDeckFactory();
            IDeck deck = deckFactory.CreateDeck();
            ISolitaireGameInstance gameInstance = new SolitaireGameInstance(deck);
            return gameInstance;
        }
    }
}
