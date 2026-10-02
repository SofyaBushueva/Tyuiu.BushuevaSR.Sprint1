using Tyuiu.BushuevaSR.Sprint1.Task6.V9.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            var res = ds.MoveLetterToStart("привет");
            Assert.AreEqual ("тприве", res);
        }
    }
}
