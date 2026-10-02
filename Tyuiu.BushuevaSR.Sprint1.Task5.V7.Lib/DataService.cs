using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushuevaSR.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            // 1 час = 30 градусов(360/12=30)
            int h = (int)(f / 30);
            return h;

            
        }
    }
}
