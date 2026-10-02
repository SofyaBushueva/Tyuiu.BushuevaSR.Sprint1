using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushuevaSR.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (value == " ")
            {
                return value;
            }
            return value[value.Length - 1] + value.Substring (0, value.Length -1);

            
        }
    }
}
