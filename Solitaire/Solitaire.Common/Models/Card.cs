using Microsoft.Practices.Prism.Mvvm;

namespace Solitaire.Common.Models
{
    /// <summary>
    /// Class representing a playing card.
    /// </summary>
    public class Card : BindableBase
    {
        #region Properties

        /// <summary>
        /// Card value.
        /// </summary>
        public Values Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        /// <summary>
        /// Card suit.
        /// </summary>
        public Suits Suit
        {
            get { return _suit; }
            set { SetProperty(ref _suit, value); }
        }

        /// <summary>
        /// Whether or not the card is face up.
        /// </summary>
        public bool FaceUp
        {
            get { return _faceUp; }
            set { SetProperty(ref _faceUp, value); }
        }

        #endregion

        #region Fields

        private Values _value;
        private Suits _suit;
        private bool _faceUp;

        #endregion 

        #region Enums

        /// <summary>
        /// Card suits.
        /// </summary>
        public enum Suits
        {
            /// <summary>
            /// Clubs.
            /// </summary>
            Clubs,

            /// <summary>
            /// Diamonds.
            /// </summary>
            Diamonds,

            /// <summary>
            /// Hearts.
            /// </summary>
            Hearts,

            /// <summary>
            /// Spades.
            /// </summary>
            Spades
        };

        /// <summary>
        /// Card values.
        /// </summary>
        public enum Values
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }

        #endregion
    }
}
