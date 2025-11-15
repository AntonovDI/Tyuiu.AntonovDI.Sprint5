using Tyuiu.AntonovDI.Sprint5.Task0.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан!");
    }
}