using Avalonia.Controls;
using MyAvaloniaApp.ViewModels;

namespace MyAvaloniaApp.Views;

public partial class DroneEditWindow : Window
{
    public DroneEditWindow()
    {
        InitializeComponent();
    }

    protected override void OnDataContextChanged(System.EventArgs e)
    {
        base.OnDataContextChanged(e);
        if (DataContext is DroneEditViewModel vm)
        {
            vm.CloseRequested += ok => Close(ok);
        }
    }
}