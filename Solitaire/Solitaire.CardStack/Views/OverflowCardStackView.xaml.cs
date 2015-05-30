using Microsoft.Practices.ServiceLocation;
using Soliatire.Common.Wpf.ViewModels;
using Solitaire.Common.Models;

namespace Solitaire.OverflowCardStack.Views
{
    /// <summary>
    /// Interaction logic for CardStackView.xaml
    /// </summary>
    public partial class OverflowCardStackView
    {
        public OverflowCardStackView()
        {
            InitializeComponent();

            var instance = ServiceLocator.Current.GetInstance<SolitaireGameInstance>();

            var card = instance.Deck.Cards[0];

            var vm = new CardViewModel
            {
                Card = card
            };

            DataContext = vm;
        }
    }
}
