namespace MiaoProject;

public class Greetings
{
    public void Greet()
    {
        Console.Clear();
        Console.WriteLine("Введите имя");
        string username = Console.ReadLine();
        Console.WriteLine($"Привет, {username}!");
    }
}