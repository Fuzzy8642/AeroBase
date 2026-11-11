using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyAvaloniaApp.Models;
using MyAvaloniaApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyAvaloniaApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ObservableCollection<DroneItem> _allDrones = new()
    {
        new("Учебный №1", "UAV-001", "Квадрокоптер", "Исправен"),
        new("Учебный №2", "UAV-002", "Самолётный", "На ТО"),
        new("Учебный №3", "UAV-003", "Квадрокоптер", "Исправен"),
        new("Учебный №4", "UAV-004", "Самолётный", "Исправен"),
        new("Учебный №5", "UAV-005", "Квадрокоптер", "На ТО")
    };

    public ObservableCollection<DroneItem> FilteredDrones { get; } = new();

    [ObservableProperty] private string _searchText = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(EditDroneCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteDroneCommand))]
    private DroneItem? _selectedDrone;

    public int TotalCount => _allDrones.Count;
    public int WorkingCount => _allDrones.Count(d => d.Status == "Исправен");
    public int ServiceCount => _allDrones.Count(d => d.Status == "На ТО" || d.Status == "На обслуживании");

    public MainViewModel()
    {
        RefreshVisible();
    }

    partial void OnSearchTextChanged(string value) => RefreshVisible();

    [RelayCommand]
    private async Task AddDrone()
    {
        var owner = GetOwnerWindow();
        if (owner is null) return;

        var dialogVm = new DroneEditViewModel(null);
        var dialog = new DroneEditWindow { DataContext = dialogVm };
        
        var ok = await dialog.ShowDialog<bool>(owner);
        if (ok && dialogVm.Result != null)
        {
            _allDrones.Add(dialogVm.Result);
            RefreshVisible();
            RecalculateStats();
            SelectedDrone = dialogVm.Result;
        }
    }

    [RelayCommand(CanExecute = nameof(CanEditOrDelete))]
    private async Task EditDrone()
    {
        var owner = GetOwnerWindow();
        if (SelectedDrone is null || owner is null) return;

        var dialogVm = new DroneEditViewModel(SelectedDrone);
        var dialog = new DroneEditWindow { DataContext = dialogVm };
        
        var ok = await dialog.ShowDialog<bool>(owner);
        if (ok && dialogVm.Result != null)
        {
            SelectedDrone.Name = dialogVm.Result.Name;
            SelectedDrone.Number = dialogVm.Result.Number;
            SelectedDrone.Type = dialogVm.Result.Type;
            SelectedDrone.Status = dialogVm.Result.Status;

            RefreshVisible();
            RecalculateStats();
        }
    }

    [RelayCommand(CanExecute = nameof(CanEditOrDelete))]
    private void DeleteDrone()
    {
        if (SelectedDrone is null) return;
        
        _allDrones.Remove(SelectedDrone);
        SelectedDrone = null;
        RefreshVisible();
        RecalculateStats();
    }

    private bool CanEditOrDelete() => SelectedDrone is not null;

    private void RefreshVisible()
    {
        var query = string.IsNullOrWhiteSpace(SearchText)
            ? _allDrones
            : _allDrones.Where(d => d.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase));

        FilteredDrones.Clear();
        foreach (var d in query)
            FilteredDrones.Add(d);
    }

    private void RecalculateStats()
    {
        OnPropertyChanged(nameof(TotalCount));
        OnPropertyChanged(nameof(WorkingCount));
        OnPropertyChanged(nameof(ServiceCount));
    }

    // Этот метод автоматически находит главное окно приложения
    private Window? GetOwnerWindow()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            return desktop.MainWindow;
        return null;
    }
}