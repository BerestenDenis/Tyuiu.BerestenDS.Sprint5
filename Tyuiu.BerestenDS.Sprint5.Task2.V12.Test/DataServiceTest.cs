using Tyuiu.BerestenDS.Sprint5.Task2.V12.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            //C:\Users\Пользователь\AppData\Local\Temp\OutPutFileTask2.txt
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
        }
    }
}