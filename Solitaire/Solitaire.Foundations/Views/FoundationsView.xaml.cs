using Microsoft.Practices.Prism.PubSubEvents;
using Solitaire.Common.Models;
using Solitaire.Foundations.ViewModels;

namespace Solitaire.Foundations.Views
{

    /// <summary>
    /// Interaction logic for FoundationsView.xaml
    /// </summary>
    public partial class FoundationsView
    {
        public FoundationsView(ISolitaireGameInstance gameInstance, IEventAggregator eventAggregator)
        {
            InitializeComponent();

            DataContext = new FoundationsViewModel(gameInstance, eventAggregator);
        }
    }

}