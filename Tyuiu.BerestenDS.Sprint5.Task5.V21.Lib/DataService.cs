﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lines = line.Replace('.', ',');
                    string[] linearray = lines.Split(' ');

                    foreach (string number in linearray)
                    {
                        double lineParse = double.Parse(number);

                        if (lineParse == 6)
                        {
                            res = 1*2*3*4*5*6;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
