﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('.', ',');
                    if ( Convert.ToDouble(line) % 2 == 0 || (Convert.ToDouble(line) > 0));
                    {
                        res = 1;

                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
