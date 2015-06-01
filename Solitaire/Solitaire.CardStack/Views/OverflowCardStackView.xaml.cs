using Solitaire.Common.Models;
using Solitaire.OverflowCardStack.ViewModels;

namespace Solitaire.OverflowCardStack.Views
{

    /// <summary>
    /// Interaction logic for CardStackView.xaml
    /// </summary>
    public partial class OverflowCardStackView
    {
        public OverflowCardStackView(ISolitaireGameInstance gameInstance)
        {
            InitializeComponent();

            DataContext = new OverflowCardStackViewModel(gameInstance);
        }
    }

}