using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyAvaloniaApp.Models;
using MyAvaloniaApp.Views;
using MyAvaloniaApp.Data; // Не забудь добавить using
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyAvaloniaApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly DroneRepository _repository = new();
    private readonly ObservableCollection<DroneItem> _allDrones = new();

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
        LoadDataFromDb(); // Загружаем при старте
    }

    private void LoadDataFromDb()
    {
        try
        {
            var dbDrones = _repository.GetAll();
            _allDrones.Clear();
            foreach (var drone in dbDrones)
            {
                _allDrones.Add(drone);
            }
            RefreshVisible();
            RecalculateStats();
        }
        catch (Exception ex)
        {
            // В реальном приложении лучше выводить ошибку через диалоговое окно
            Console.WriteLine($"Ошибка загрузки из БД: {ex.Message}");
        }
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
            try
            {
                _repository.Add(dialogVm.Result); // Сохраняем в БД
                _allDrones.Add(dialogVm.Result);  // Добавляем в UI
                RefreshVisible();
                RecalculateStats();
                SelectedDrone = dialogVm.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка добавления: {ex.Message}");
            }
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
            try
            {
                _repository.Update(dialogVm.Result); // Обновляем в БД
                
                // Обновляем объект в памяти
                SelectedDrone.Name = dialogVm.Result.Name;
                SelectedDrone.Number = dialogVm.Result.Number;
                SelectedDrone.Type = dialogVm.Result.Type;
                SelectedDrone.Status = dialogVm.Result.Status;

                RefreshVisible();
                RecalculateStats();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления: {ex.Message}");
            }
        }
    }

    [RelayCommand(CanExecute = nameof(CanEditOrDelete))]
    private void DeleteDrone()
    {
        if (SelectedDrone is null) return;
        
        try
        {
            _repository.Delete(SelectedDrone); // Удаляем из БД
            _allDrones.Remove(SelectedDrone);  // Удаляем из UI
            SelectedDrone = null;
            RefreshVisible();
            RecalculateStats();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка удаления: {ex.Message}");
        }
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

    private Window? GetOwnerWindow()
    {
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            return desktop.MainWindow;
        return null;
    }
}