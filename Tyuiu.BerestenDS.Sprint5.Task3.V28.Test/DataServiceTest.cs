using Tyuiu.BerestenDS.Sprint5.Task3.V28.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            //C:\Users\������������\AppData\Local\Temp\OutPutFileTask3.txt
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
        }
    }
}