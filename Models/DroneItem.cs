using CommunityToolkit.Mvvm.ComponentModel;

namespace MyAvaloniaApp.Models;

public partial class DroneItem : ObservableObject
{
    [ObservableProperty] private string _name = string.Empty;
    [ObservableProperty] private string _number = string.Empty;
    [ObservableProperty] private string _type = string.Empty;
    [ObservableProperty] private string _status = string.Empty;

    public string StatusColor => Status == "Исправен" ? "#11966B" : "#D28A24";

    public DroneItem(string name, string number, string type, string status)
    {
        Name = name;
        Number = number;
        Type = type;
        Status = status;
    }
}