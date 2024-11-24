using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            path.Replace(".", ",");
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
    
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 2 == 0 && Convert.ToDouble(line) > 0 );
                    {
                        for (int i = 0; i <= Convert.ToDouble(line); i++)
                        {
                            res = res * i;
                        }

                    }
                }
            }
            return res;
        }
    }
}
