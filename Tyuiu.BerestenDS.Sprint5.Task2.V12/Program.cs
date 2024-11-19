using Tyuiu.BerestenDS.Sprint5.Task2.V12.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] matrix = new int[3, 3] { { -5, -5, 9 }, { -7, 3, -4 }, { 8, 7, 9 } };
        int rows = matrix.GetUpperBound(0)+1;
        int colums = matrix.Length/rows;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("файл создан!" + res);
        Console.ReadKey();
    }
}