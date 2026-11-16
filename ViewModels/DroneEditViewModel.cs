using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyAvaloniaApp.Models;
using System;

namespace MyAvaloniaApp.ViewModels;

public partial class DroneEditViewModel : ObservableObject
{
    [ObservableProperty] private string _name = string.Empty;
    [ObservableProperty] private string _number = string.Empty;
    [ObservableProperty] private string _type = "Квадрокоптер";
    [ObservableProperty] private string _status = "Исправен";

    public string Title { get; }
    public DroneItem? Result { get; private set; }
    public event Action<bool>? CloseRequested;

    public DroneEditViewModel(DroneItem? existing = null)
    {
        if (existing is null)
        {
            Title = "Добавить БПЛА";
        }
        else
        {
            Title = "Изменить БПЛА";
            Name = existing.Name;
            Number = existing.Number;
            Type = existing.Type;
            Status = existing.Status;
        }
    }

    [RelayCommand]
    private void Save()
    {
        if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Number))
            return;

        Result = new DroneItem(Name.Trim(), Number.Trim(), Type.Trim(), Status);
        CloseRequested?.Invoke(true);
    }

    [RelayCommand]
    private void Cancel() => CloseRequested?.Invoke(false);
}