using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Tableaus.ViewModels
{

    /// <summary>
    /// Tableaus view model.
    /// </summary>
    public class TableausViewModel : BindableBase
    {
        #region Properties

        /// <summary>
        /// Collection of <see cref="VerticalCardStackViewModel" />.
        /// </summary>
        public ObservableCollection<VerticalCardStackViewModel> StackViewModels
        {
            get { return _stackViewModels; }
            set { SetProperty(ref _stackViewModels, value); }
        }

        #endregion

        /// <summary>
        /// Initializes an instance of <see cref="TableausViewModel" /> using the specified
        /// game instance.
        /// </summary>
        /// <param name="gameInstance">The solitaire game.</param>
        public TableausViewModel(ISolitaireGameInstance gameInstance)
        {
            StackViewModels = new ObservableCollection<VerticalCardStackViewModel>();

            foreach (var tableau in gameInstance.Tableaus)
            {
                StackViewModels.Add(new VerticalCardStackViewModel(tableau));
            }
        }

        #region Fields

        private ObservableCollection<VerticalCardStackViewModel> _stackViewModels;

        #endregion
    }

}