﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Expense_Tracker.Core
{
    /**
     * This class is used to notify the UI when a property is changed.
     */
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
