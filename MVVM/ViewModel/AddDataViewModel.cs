using System;
using System.Collections.ObjectModel;
using System.Transactions;

namespace Expense_Tracker.MVVM.ViewModel
{
    internal class AddDataViewModel
    {
        public ObservableCollection<Transaction> RecentTransactions { get; set; }

        public AddDataViewModel()
        {
            // Initialize RecentTransactions
            RecentTransactions = new ObservableCollection<Transaction>();
        }
    }
}
