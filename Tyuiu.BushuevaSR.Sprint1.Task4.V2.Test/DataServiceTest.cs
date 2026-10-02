using Tyuiu.BushuevaSR.Sprint1.Task4.V2.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double wait = 0.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
