using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solitaire.Common.Factories;
using Solitaire.Common.Models;
using Solitaire.OverflowCardStack.ViewModels;

namespace Solitaire.OverflowCardStack.Test
{
    [TestClass]
    public class OverflowCardStackViewModelTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            IDeckFactory deckFactory = new StandardDeckFactory();
            IDeck deck = deckFactory.CreateDeck();
            ISolitaireGameInstance game = new SolitaireGameInstance(deck);
            var viewModel = new OverflowCardStackViewModel(game);

            // Top card of the undealt stack should be the last card in the overflow stack array.
            Assert.AreEqual(viewModel.TopCard, game.OverflowStack[game.OverflowStack.Count - 1]);
            // No cards should be dealt.
            Assert.AreEqual(viewModel.DealtCards.Count, 0);
        }

        [TestMethod]
        public void TestDealStackCommand()
        {
            IDeckFactory deckFactory = new StandardDeckFactory();
            IDeck deck = deckFactory.CreateDeck();
            ISolitaireGameInstance game = new SolitaireGameInstance(deck);
            var viewModel = new OverflowCardStackViewModel(game);

            // NumCardsPerDeal cards should be dealt.
            viewModel.DealStackCommand.Execute(null);
            Assert.AreEqual(viewModel.DealtCards.Count, OverflowCardStackViewModel.NumCardsPerDeal);
        }
    }
}
