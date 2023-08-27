using Expense_Tracker.Core;
using System;
using System.Windows;
using System.Windows.Input;

namespace Expense_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Drag_Window(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        public void SetViewModelLocator(ViewModelLocator viewModelLocator)
        {
            DataContext = viewModelLocator.MainViewModel;
        }
    }
}
