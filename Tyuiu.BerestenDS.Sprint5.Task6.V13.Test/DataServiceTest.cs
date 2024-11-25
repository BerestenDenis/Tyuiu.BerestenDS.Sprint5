using Tyuiu.BerestenDS.Sprint5.Task6.V13.Lib;
namespace Tyuiu.BerestenDS.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);
        }
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
            DataService ds = new DataService();
            int wait = 3;
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}