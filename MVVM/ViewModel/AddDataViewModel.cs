using Expense_Tracker.Core;
using System;
using System.Collections.ObjectModel;
using System.Transactions;
using System.Windows.Input;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class AddDataViewModel
    {
        public ICommand AddTransactionCommand { get; }
        public ObservableCollection<Transaction> RecentTransactions { get; set; }

        public AddDataViewModel()
        {
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
            }

        }
    }
}
