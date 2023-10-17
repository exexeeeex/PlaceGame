using System;

class Program
{

    static int ක්රීඩකයාගේස්ථානයX = Convert.ToInt32(Console.ReadLine());
    static int ක්රීඩකයාගේස්ථානයY = Convert.ToInt32(Console.ReadLine());

    static void Main()
    {


        string[,] ස්ථානය = උත්පාදනස්ථානය();

        while (true)
        {
            string චලනය = "0";
            Display(ක්රීඩකයාගේස්ථානයX, ක්රීඩකයාගේස්ථානයY, චලනය);
            GamePlace(ස්ථානය);
            var ch = Console.ReadKey(false).Key;
            switch (ch)
            {
                case ConsoleKey.Q:
                    Console.Clear();
                    Console.WriteLine("አበቃለት!");
                    return;
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    MovePlayer(0, -1, ස්ථානය);
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    MovePlayer(0, 1, ස්ථානය);
                    break;
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    MovePlayer(-1, 0, ස්ථානය);
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    MovePlayer(1, 0, ස්ථානය);
                    break;
            }
        }
    }

    static string[,] උත්පාදනස්ථානය()
    {
        Console.WriteLine("أدخل القيمة الأولى: ");
        int ප්ලේයර්රෝස් = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("أدخل القيمة الثانية: ");
        int ක්‍රීඩකතීරු = Convert.ToInt32(Console.ReadLine());
        string[,] ස්ථානය = new string[ප්ලේයර්රෝස්, ක්‍රීඩකතීරු];
        for (int በግልጽ = 0; በግልጽ < ස්ථානය.GetLength(0); በግልጽ++)
        {
            for (int እና = 0; እና < ස්ථානය.GetLength(1); እና++)
            {
                ස්ථානය[እና, በግልጽ] = "#";
            }
        }
        return ස්ථානය;
    }

    static void GamePlace(string[,] ස්ථානය)
    {
        for (int සහ = 0; සහ < ස්ථානය.GetLength(0); සහ++)
        {
            for (int සමග = 0; සමග < ස්ථානය.GetLength(1); සමග++)
            {
                if (සමග == ක්රීඩකයාගේස්ථානයX && සහ == ක්රීඩකයාගේස්ථානයY)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write(ස්ථානය[සහ, සමග]);
                }
            }
            Console.WriteLine();
        }
    }

    static void Display(int ක්රීඩකයාගේස්ථානයX, int ක්රීඩකයාගේස්ථානයY, string චලනය)
    {
        Console.WriteLine($"------------------------------\n" +
            "لعبةالميدان!\n" +
            $"الإحداثيات الحالية: {ක්රීඩකයාගේස්ථානයX}, {ක්රීඩකයාගේස්ථානයY}\n" +
            $"التحرك الحالي: {චලනය}\n" +
            $"------------------------------");
    }

    static void MovePlayer(int සමග, int සහ, string[,] ස්ථානය)
    {
        int ක්රීඩකයාගේස්ථානයඊළඟX = ක්රීඩකයාගේස්ථානයX + සමග;
        int ක්රීඩකයාගේස්ථානයඊළඟY = ක්රීඩකයාගේස්ථානයY + සහ;

        if (ක්රීඩකයාගේස්ථානයඊළඟX >= 0 && ක්රීඩකයාගේස්ථානයඊළඟX < ස්ථානය.GetLength(1) && ක්රීඩකයාගේස්ථානයඊළඟY >= 0 && ක්රීඩකයාගේස්ථානයඊළඟY < ස්ථානය.GetLength(0))
        {
            ක්රීඩකයාගේස්ථානයX = ක්රීඩකයාගේස්ථානයඊළඟX;
            ක්රීඩකයාගේස්ථානයY = ක්රීඩකයාගේස්ථානයඊළඟY;
        }
    }
}