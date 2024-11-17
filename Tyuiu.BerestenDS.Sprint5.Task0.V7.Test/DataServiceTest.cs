using Tyuiu.BerestenDS.Sprint5.Task0.V7.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BerestenDS.Sprint5\Tyuiu.BerestenDS.Sprint5.Task0.V7\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}