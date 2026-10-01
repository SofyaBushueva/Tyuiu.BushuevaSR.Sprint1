using Tyuiu.BushuevaSR.Sprint1.Task3.V8.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание #3                                                                                                    *");
            Console.WriteLine("* Вариант #8                                                                                                    *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                       *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.                                                    *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Величина вклада = " + x);
            Console.WriteLine("Проценты = " + y);
            Console.WriteLine("Срок вклада = " + z);

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Величина дохода по вкладу = " + ds.IncomeAmount(x, y, z));

            Console.ReadKey();
        }
    }
}
