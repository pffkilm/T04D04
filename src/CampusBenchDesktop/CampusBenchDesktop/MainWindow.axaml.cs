using Avalonia.Controls;
using CampusBenchDesktop.Pages;

namespace CampusBenchDesktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Content = new OrdersPage();
        App.mainWindow = this;
    }
}