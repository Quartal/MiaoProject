namespace MiaoProject;
    
class Programm 
{
    static void Main()
    {
        Console.WriteLine("Приветсвие");
        Console.WriteLine("Ваше отражение");
        Console.WriteLine("Дата и время");
        Console.WriteLine("Пожелание на день");
        Console.WriteLine();
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D1:
                
                break;
            case ConsoleKey.D2:
                new Mirror().ShowMyFace();
                break;
            case ConsoleKey.D3:
                
                break;
            case ConsoleKey.D4:
                
                break;
        }
    }
}
