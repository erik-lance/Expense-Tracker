using Expense_Tracker.MVVM.View;
using Expense_Tracker.MVVM.ViewModel;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Expense_Tracker.Core
{
    public class ViewModelLocator
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

        public MainViewModel MainViewModel => _serviceProvider.GetRequiredService<MainViewModel>();
        public AddDataViewModel AddDataViewModel => _serviceProvider.GetRequiredService<AddDataViewModel>();
    }
}
