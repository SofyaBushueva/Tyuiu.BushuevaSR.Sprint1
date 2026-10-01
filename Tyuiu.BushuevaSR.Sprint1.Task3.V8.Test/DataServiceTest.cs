using Tyuiu.BushuevaSR.Sprint1.Task3.V8.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2500;
            double y = 20;
            double z = 30;
            double wait = 41.096;
            var res = ds.IncomeAmount(x, y, z);
            Assert.AreEqual(wait, res);

        }
    }
}
