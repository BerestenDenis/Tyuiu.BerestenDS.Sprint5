using Tyuiu.BerestenDS.Sprint5.Task1.V27.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds= new DataService();
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

    }
}