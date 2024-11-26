using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null) ;
                string lines = Regex.Replace(line, "[ ]+","  ");
                return lines;
            }

        }
    }
}
