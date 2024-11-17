using Tyuiu.BerestenDS.Sprint5.Task0.V7.Lib;
class program
{
    static void Main (string[] args)
    {
        DataService ds = new DataService();
        int x = 4;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"x = {x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.ReadLine();
    }
}