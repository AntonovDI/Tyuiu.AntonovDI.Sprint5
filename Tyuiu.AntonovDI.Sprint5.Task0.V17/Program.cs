using Tyuiu.AntonovDI.Sprint5.Task0.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Антонов Д. И. | ИСТНб-25-1";
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение , вычислить его значение при x = 3, результат сохранить  *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до *");
        Console.WriteLine("* трёх знаков после запятой. Название проектов (консольного приложения,   *");
        Console.WriteLine("* библиотеки классов, тестового модуля) оформить по шаблону в             *"); 
        Console.WriteLine("* соответствии с вариантом. Интерфейс консольного приложения оформить     *");
        Console.WriteLine("* по шаблону.                                                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");
    }
}