using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using CampusBenchDesktop.Pages;
using System;

namespace CampusBenchDesktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Content = new OrdersPage();
        App.mainWindow = this;
    }

    public MainWindow(IWindowImpl impl) : base(impl)
    {
    }

    internal void UpdateStatus(string message, Color color)
    {
        throw new NotImplementedException();
    }
}