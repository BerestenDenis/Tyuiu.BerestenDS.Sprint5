using Tyuiu.BerestenDS.Sprint5.Task6.V13.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }

}