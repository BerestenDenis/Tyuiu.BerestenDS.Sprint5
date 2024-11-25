using Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
        using (StreamReader reader = new StreamReader(path))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

    }
}