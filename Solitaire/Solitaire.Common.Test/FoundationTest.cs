using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solitaire.Common.Factories;
using Solitaire.Common.Models;

namespace Solitaire.Common.Test
{
    [TestClass]
    public class FoundationTest
    {
        [TestMethod]
        public void TestAddCard()
        {
            // Create a card.
            var card = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Ace
            };
            // Attempt to add it to a foundation.
            IFoundation foundation = new Foundation(card.Suit);
            bool accepted = foundation.AddCard(card);
            Assert.IsTrue(accepted);
        }

        [TestMethod]
        public void TestAddCardIncorrectSuit()
        {
            // Create a card.
            var card = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Ace
            };
            // Attempt to add a card with a different suit than the foundation.
            IFoundation foundation = new Foundation(Card.Suits.Clubs);
            bool accepted = foundation.AddCard(card);
            Assert.IsFalse(accepted);
        }

        [TestMethod]
        public void TestAddCardCorrectOrder()
        {
            // Create a card.
            var card1 = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Ace
            };
            // Create a second card.
            var card2 = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Two
            };
            // Attempt to add cards in order.
            IFoundation foundation = new Foundation(card1.Suit);
            foundation.AddCard(card1);
            bool accepted = foundation.AddCard(card2);
            Assert.IsTrue(accepted);
        }

        [TestMethod]
        public void TestAddCardIncorrectOrder()
        {
            // Create a card.
            var card1 = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Ace
            };
            // Create a second card.
            var card2 = new Card
            {
                Suit = Card.Suits.Spades,
                Value = Card.Values.Three
            };
            // Attempt to add cards in incorrect order.
            IFoundation foundation = new Foundation(card1.Suit);
            foundation.AddCard(card1);
            bool accepted = foundation.AddCard(card2);
            Assert.IsFalse(accepted);
        }

        [TestMethod]
        public void TestAddCardFullFoundation()
        {
            var suit = Card.Suits.Spades;
            IFoundation foundation = new Foundation(suit);
            Card card = null;
            // Fill the foundation up with all possible card values.
            foreach (Card.Values value in Enum.GetValues(typeof(Card.Values)))
            {
                card = new Card
                {
                    Suit = suit,
                    Value = value
                };
                foundation.AddCard(card);
            }
            // Attempt to add a card when the foundation is full.
            bool accepted = foundation.AddCard(card);
            Assert.IsFalse(accepted);
        }
    }
}
