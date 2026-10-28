using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class UserProfile
{
    public int Id { get; set; }
    public string Username { get; set; }

    [JsonIgnore]
    public string Password { get; set; }
}

class Program
{
    static void Main()
    {
        UserProfile user = new UserProfile
        {
            Id = 101,
            Username = "coder_ua",
            Password = "SuperSecretPassword123"
        };

        string json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("--- Результат серіалізації з [JsonIgnore] ---");
        Console.WriteLine(json);
    }
}