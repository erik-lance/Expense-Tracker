using Expense_Tracker.Core;
using System;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public AddDataViewModel AddDataVm { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AddDataVm = new AddDataViewModel();
            CurrentView = AddDataVm;
        }

    }
}
