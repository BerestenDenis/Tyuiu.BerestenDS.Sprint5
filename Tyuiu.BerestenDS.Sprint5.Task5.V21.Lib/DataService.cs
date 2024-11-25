using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double x;
                while ((line = reader.ReadLine()) != null)
                {
                    x = Convert.ToDouble(line);
                    if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99)
                    {
                        res *= x;
                    }
                }
            }

            return Math.Round(res, 3);
        }
    }
}
