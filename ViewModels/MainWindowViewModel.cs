using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using Avalonia.Platform;
using Avalonia.Input;
using System.Windows.Input;

namespace SEAL.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
    }
}
