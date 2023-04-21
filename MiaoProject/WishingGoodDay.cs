namespace MiaoProject;

public class WishingGoodDay
{
    private static string[] wishes = { "Удачи на работе! :)", "Счастливого дня! :))", "Хорошего настроения! :))))"};

    public void ShowWish()
    {
        Console.Clear();
        int wishIndex = new Random().Next(0, 2);
        Console.WriteLine(wishes[wishIndex]);
    }
}