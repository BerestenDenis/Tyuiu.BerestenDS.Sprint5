using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerestenDS.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double bg = (-(1 / 4) * ((Math.Pow(x, 3)) - (3 * Math.Pow(x, 2)) + 4));
            bg = Math.Round(bg,3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(bg));
            }

            return path;


        }
    }
}
