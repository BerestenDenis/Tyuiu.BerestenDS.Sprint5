using Tyuiu.BerestenDS.Sprint5.Task0.V7.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            //C:\Users\Пользователь\AppData\Local\Temp\OutPutFileTask0.txt
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
            ;
        }
    }
}