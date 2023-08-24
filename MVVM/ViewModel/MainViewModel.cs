using Expense_Tracker.Core;
using System;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AddDataViewCommand { get; set; }

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

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            AddDataViewCommand = new RelayCommand(o =>
            {
                CurrentView = AddDataVm;
            });
        }

    }
}
