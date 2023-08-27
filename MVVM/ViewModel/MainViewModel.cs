using Expense_Tracker.Core;
using System;

namespace Expense_Tracker.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AddDataViewCommand { get; set; }

        private readonly HomeViewModel _homeVm;
        private readonly AddDataViewModel _addDataVm;
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

        public MainViewModel(HomeViewModel homeVm, AddDataViewModel addDataVm)
        {
            _homeVm = homeVm;
            _addDataVm = addDataVm;
            CurrentView = _homeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = _homeVm;
            });

            AddDataViewCommand = new RelayCommand(o =>
            {
                CurrentView = _addDataVm;
            });
        }

    }
}
