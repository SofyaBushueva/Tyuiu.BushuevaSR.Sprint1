using Tyuiu.BushuevaSR.Sprint1.Task7.V17.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = -2.817;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
