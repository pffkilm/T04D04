using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CampusBenchDesktop.Models;
using CampusBenchDesktop.Services;

namespace CampusBenchDesktop.Pages;

public partial class AddEditOrderPage : UserControl
{
    private Order _contextOrder;
    public AddEditOrderPage(Order order)
    {
        InitializeComponent();
        if (order.dateTime == default)
            order.dateTime = DateTime.Now;
        _contextOrder = order;
        DataContext = order;
    }

    private async void BSave_OnClick(object? sender, RoutedEventArgs e)
    {
        if (_contextOrder.id == 0)
        {
            //Добавление
            await NetManager.Post("api/Order", _contextOrder);
        }
        else
        {
            //Изменение
        }
        App.mainWindow.MainFrame.Content = new OrdersPage();

    }

    private void BBack_OnClick(object? sender, RoutedEventArgs e)
    {
        App.mainWindow.MainFrame.Content = new OrdersPage();
    }
}