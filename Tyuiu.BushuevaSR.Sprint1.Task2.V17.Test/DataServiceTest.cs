using Tyuiu.BushuevaSR.Sprint1.Task2.V17.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(120, res);

        }
    }
}
