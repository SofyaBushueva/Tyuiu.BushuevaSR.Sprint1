using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushuevaSR.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            return Math.Round(startAmount * percent * timeDays / (100 * 365), 2); 
        }
    }
}
