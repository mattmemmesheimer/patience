using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Solitaire.Common.Models;

namespace Solitaire.Foundations.ViewModels
{
    public class FoundationsViewModel : BindableBase
    {
        #region Properties

        public List<FoundationViewModel> Foundations { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new instance of <see cref="FoundationsViewModel"/> using the specified
        /// game instance.
        /// </summary>
        /// <param name="gameInstance">The solitaire game.</param>
        public FoundationsViewModel(ISolitaireGameInstance gameInstance)
        {
            Foundations = new List<FoundationViewModel>(gameInstance.Foundations.Length);
            foreach (var foundation in gameInstance.Foundations)
            {
                Foundations.Add(new FoundationViewModel(foundation));
            }
        }

        #region Fields

        #endregion
    }
}
