using System.Collections.ObjectModel;

namespace MyAvaloniaApp.ViewModels;

public class MainViewModel
{
    public int TotalCount => 5;
    public int WorkingCount => 3;
    public int ServiceCount => 2;

    public string SearchText { get; set; } = "";

    public ObservableCollection<DroneItem> FilteredDrones { get; } = new()
    {
        new("Учебный №1", "UAV-001", "Квадрокоптер", "Исправен"),
        new("Учебный №2", "UAV-002", "Самолётный", "На ТО"),
        new("Учебный №3", "UAV-003", "Квадрокоптер", "Исправен"),
        new("Учебный №4", "UAV-004", "Самолётный", "Исправен"),
        new("Учебный №5", "UAV-005", "Квадрокоптер", "На ТО")
    };
}

public class DroneItem
{
    public string Name { get; set; }
    public string Number { get; set; }
    public string Type { get; set; }
    public string Status { get; set; }

    public string StatusColor =>
        Status == "Исправен" ? "#11966B" : "#D28A24";

    public DroneItem(string name, string number, string type, string status)
    {
        Name = name;
        Number = number;
        Type = type;
        Status = status;
    }
}