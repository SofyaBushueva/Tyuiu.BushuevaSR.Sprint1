using Tyuiu.BushuevaSR.Sprint1.Task5.V7.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataserviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 60;
            DataService ds = new DataService();
            var res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 2;

            Assert.AreEqual(wait, result);
        }
    }
}
