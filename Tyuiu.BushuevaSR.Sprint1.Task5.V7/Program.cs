using System.ComponentModel.Design;
using Tyuiu.BushuevaSR.Sprint1.Task5.V7.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task5.V7
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
            Console.WriteLine("* Задание #5                                                                                                    *");
            Console.WriteLine("* Вариант #7                                                                                                    *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                                                          *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня),     *");
            Console.WriteLine("* когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).                            *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Введите f");
            double f = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            int res = Convert.ToInt32(ds.AngleToHoursMinutes(f));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
