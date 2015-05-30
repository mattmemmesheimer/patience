using System.Collections.ObjectModel;
using Solitaire.Common.Models;
using Solitaire.Tableaus.ViewModels;

namespace Solitaire.Tableaus.Views
{
    /// <summary>
    /// Interaction logic for TableausView.xaml
    /// </summary>
    public partial class TableausView
    {
        public TableausView(ISolitaireGameInstance gameInstance)
        {
            InitializeComponent();

            var vm = new TablaeusViewModel(gameInstance);
            DataContext = vm;
        }
    }
}
