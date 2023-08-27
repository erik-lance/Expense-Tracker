using Expense_Tracker.MVVM.View;
using Expense_Tracker.MVVM.ViewModel;
using System;

namespace Expense_Tracker.Core
{
    internal class ViewModelLocator
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public AddDataView GetAddDataView(AddDataViewModel viewModel)
        {
            return new AddDataView(viewModel);
        }
    }
}
