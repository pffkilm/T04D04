using System;
using System.ComponentModel.DataAnnotations;
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
        _contextOrder = order;
        DataContext = order;
    }

    private async void BSave_OnClick(object? sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_contextOrder.name))
        {
            if (_contextOrder.id == 0)
            {
                //Добавление
                await NetManager.Post("api/Order", _contextOrder);
            }
            else
            {
                //Изменение
                await NetManager.Put($"api/Order/{_contextOrder.id}", _contextOrder);

            }
            App.mainWindow.MainFrame.Content = new OrdersPage();
        }
    }

    private void BBack_OnClick(object? sender, RoutedEventArgs e)
    {
        App.mainWindow.MainFrame.Content = new OrdersPage();
    }
}
