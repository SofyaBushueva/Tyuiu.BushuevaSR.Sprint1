using Tyuiu.BushuevaSR.Sprint1.Task7.V17.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бушуева С.Р. | ПИНб-26-1 ";

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                              *");
            Console.WriteLine("* Задание #7                                                                                                    *");
            Console.WriteLine("* Вариант #17                                                                                                   *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,                  *");
            Console.WriteLine("*вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                             *");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("*  (1 + sin(√(x + 1))                                                                                           *");
            Console.WriteLine("* --------------------                                                                                          *");
            Console.WriteLine("*   (cos(12 * y – 4)                                                                                            *");
            
            double x, y;
            Console.WriteLine("Введите знасччение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знасччение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));


            Console.ReadLine();
        }
    }
}

        
    

