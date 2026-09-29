using Tyuiu.BushuevaSR.Sprint1.Task0.V28.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);

        }
    }
}
