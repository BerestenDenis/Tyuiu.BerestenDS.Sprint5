using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
                using (StreamReader rd = new StreamReader(path))
                {
                    string line;
                    int count = 0;
                    while ((line = rd.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == 'с' && line[i + 1] == 'с')
                            {
                                count++;
                            }

                        }
                    }
                    return count;
                }
            
        }
    }
}
