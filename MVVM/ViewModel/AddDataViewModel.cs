using Expense_Tracker.Core;
using Expense_Tracker.Data;
using System;
using System.Collections.ObjectModel;
using System.Transactions;
using System.Windows.Input;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class AddDataViewModel
    {
        private readonly DataAccess _dataAccess;
        public ICommand AddTransactionCommand { get; }
        public ObservableCollection<Transaction> RecentTransactions { get; set; }

        public AddDataViewModel(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;

            AddTransactionCommand = new RelayCommand(AddTransaction);

            // Initialize RecentTransactions
            RecentTransactions = new ObservableCollection<Transaction>();
        }

        private void AddTransaction(object param)
        {
            if (param is Transaction newTransaction)
            {
                // Add new transaction to RecentTransactions
                // RecentTransactions.Add(newTransaction);

                // Add new transaction to database
                _dataAccess.InsertTransaction(newTransaction);
            }

        }
    }
}
