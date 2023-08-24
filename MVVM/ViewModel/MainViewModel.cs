using Expense_Tracker.Core;
using System;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVm { get; set; }
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
            HomeVm = new HomeViewModel();
            AddDataVm = new AddDataViewModel();
            CurrentView = HomeVm;
        }

    }
}
