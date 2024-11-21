using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(1 / Math.Cos(Convert.ToDouble(strX)) + 2.2 * Math.Pow(Convert.ToDouble(strX), 2), 3);
            return res;
        }
    }
}
