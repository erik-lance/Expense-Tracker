using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Expense_Tracker.Data;
using Expense_Tracker.MVVM.ViewModel;
using Expense_Tracker.MVVM.View;

namespace Expense_Tracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ConfigureServices();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Register dependencies
            serviceCollection.AddSingleton<DataAccess>();

            serviceCollection.AddTransient<AddDataViewModel>();
            serviceCollection.AddTransient<HomeViewModel>();
            serviceCollection.AddTransient<AddDataView>();
            serviceCollection.AddTransient<HomeView>();

            serviceCollection.AddTransient<MainWindow>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
