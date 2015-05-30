using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.ServiceLocation;
using Solitaire.Common.Models;

namespace Solitaire.Tableaus.ViewModels
{
    public class TablaeusViewModel : BindableBase
    {
        #region Properties

        public VerticalCardStackViewModel Stack1
        {
            get { return _stack1; }
            set { SetProperty(ref _stack1, value); }
        }

        public VerticalCardStackViewModel Stack2
        {
            get { return _stack2; }
            set { SetProperty(ref _stack2, value); }
        }

        public VerticalCardStackViewModel Stack3
        {
            get { return _stack3; }
            set { SetProperty(ref _stack3, value); }
        }

        public VerticalCardStackViewModel Stack4
        {
            get { return _stack4; }
            set { SetProperty(ref _stack4, value); }
        }

        public VerticalCardStackViewModel Stack5
        {
            get { return _stack5; }
            set { SetProperty(ref _stack5, value); }
        }

        public VerticalCardStackViewModel Stack6
        {
            get { return _stack6; }
            set { SetProperty(ref _stack6, value); }
        }

        public VerticalCardStackViewModel Stack7
        {
            get { return _stack7; }
            set { SetProperty(ref _stack7, value); }
        }

        #endregion

        public TablaeusViewModel(ISolitaireGameInstance gameInstance)
        {
            _stack1 = new VerticalCardStackViewModel(gameInstance.Tableaus[0]);
            _stack2 = new VerticalCardStackViewModel(gameInstance.Tableaus[1]);
            _stack3 = new VerticalCardStackViewModel(gameInstance.Tableaus[2]);
            _stack4 = new VerticalCardStackViewModel(gameInstance.Tableaus[3]);
            _stack5 = new VerticalCardStackViewModel(gameInstance.Tableaus[4]);
            _stack6 = new VerticalCardStackViewModel(gameInstance.Tableaus[5]);
            _stack7 = new VerticalCardStackViewModel(gameInstance.Tableaus[6]);
        }

        #region Fields

        private VerticalCardStackViewModel _stack1;
        private VerticalCardStackViewModel _stack2;
        private VerticalCardStackViewModel _stack3;
        private VerticalCardStackViewModel _stack4;
        private VerticalCardStackViewModel _stack5;
        private VerticalCardStackViewModel _stack6;
        private VerticalCardStackViewModel _stack7;

        #endregion
    }
}
