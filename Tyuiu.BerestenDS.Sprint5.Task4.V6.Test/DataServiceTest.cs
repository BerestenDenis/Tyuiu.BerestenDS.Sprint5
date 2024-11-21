using Tyuiu.BerestenDS.Sprint5.Task4.V6.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";

            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
        }
    }
}