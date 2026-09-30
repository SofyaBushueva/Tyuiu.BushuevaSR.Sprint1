using Tyuiu.BushuevaSR.Sprint1.Task2.V17.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task2.V17
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
            Console.WriteLine("* Задание #2                                                                                                    *");
            Console.WriteLine("* Вариант #17                                                                                                   *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                       *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.                                                    *");
            Console.WriteLine("*                                                                                                               *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Число X, умноженное на 60 = " + ds.ConvertMinutesToHours(x));

            Console.ReadLine();

        }
    }
}
