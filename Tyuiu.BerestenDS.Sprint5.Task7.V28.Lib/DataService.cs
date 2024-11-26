using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string pathsavefile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(pathsavefile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathsavefile);
            }
            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            if (line[i+1] != ' ')
                            {
                                strline = strline + line[i] ;
                            }
                        }
                    }
                    File.AppendAllText(pathsavefile, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return pathsavefile;

        }
    }
}
