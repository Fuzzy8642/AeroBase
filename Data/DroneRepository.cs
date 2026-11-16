using System;
using System.Collections.Generic;
using Npgsql;
using MyAvaloniaApp.Models;

namespace MyAvaloniaApp.Data;

public class DroneRepository
{
    // Строка подключения. ЗАМЕНИ пароль на свой, если он есть!
    // На Mac локально часто Username=твое_имя_пользователя и пустой пароль,
    // либо Username=postgres, Password=твой_пароль.
    private readonly string _connectionString = 
        "Host=localhost;Port=5432;Database=aerobase;Username=postgres;Password=ur_pass";

    public List<DroneItem> GetAll()
    {
        var result = new List<DroneItem>();
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("SELECT name, number, type, status FROM drones ORDER BY id", connection);
        using var reader = command.ExecuteReader();
        
        while (reader.Read())
        {
            result.Add(new DroneItem(
                reader.GetString(0), // name
                reader.GetString(1), // number
                reader.GetString(2), // type
                reader.GetString(3)  // status
            ));
        }
        return result;
    }

    public void Add(DroneItem drone)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand(
            "INSERT INTO drones (name, number, type, status) VALUES (@name, @number, @type, @status)", 
            connection);
        
        command.Parameters.AddWithValue("name", drone.Name);
        command.Parameters.AddWithValue("number", drone.Number);
        command.Parameters.AddWithValue("type", drone.Type);
        command.Parameters.AddWithValue("status", drone.Status);
        command.ExecuteNonQuery();
    }

    // Переопределяем метод удаления по номеру (так как в DroneItem нет Id)
    public void Delete(DroneItem drone)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("DELETE FROM drones WHERE number = @number", connection);
        command.Parameters.AddWithValue("number", drone.Number);
        command.ExecuteNonQuery();
    }

    // Обновление записи (понадобится для команды EditDrone)
    public void Update(DroneItem drone)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand(
            "UPDATE drones SET name = @name, type = @type, status = @status WHERE number = @number", 
            connection);
        
        command.Parameters.AddWithValue("name", drone.Name);
        command.Parameters.AddWithValue("number", drone.Number);
        command.Parameters.AddWithValue("type", drone.Type);
        command.Parameters.AddWithValue("status", drone.Status);
        command.ExecuteNonQuery();
    }
}