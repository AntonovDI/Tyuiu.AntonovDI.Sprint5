using Tyuiu.AntonovDI.Sprint5.Task1.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("startValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.WriteLine(res);
    }
}