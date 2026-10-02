using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushuevaSR.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(1/(Math.Sqrt(x + 2 *y)), 3);
            return res;
        }
    }
}
