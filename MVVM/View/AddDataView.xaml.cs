using Expense_Tracker.MVVM.ViewModel;
using System;
using System.Windows.Controls;

namespace Expense_Tracker.MVVM.View
{
    /// <summary>
    /// Interaction logic for AddDataView.xaml
    /// </summary>
    public partial class AddDataView : UserControl
    {
        public AddDataView(AddDataViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
