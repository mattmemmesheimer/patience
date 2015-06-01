using System.Windows.Controls;
using Solitaire.Common.Models;
using Solitaire.Foundations.ViewModels;

namespace Solitaire.Foundations.Views
{

    /// <summary>
    /// Interaction logic for FoundationsView.xaml
    /// </summary>
    public partial class FoundationsView : UserControl
    {
        public FoundationsView(ISolitaireGameInstance gameInstance)
        {
            InitializeComponent();

            DataContext = new FoundationsViewModel(gameInstance);
        }
    }

}