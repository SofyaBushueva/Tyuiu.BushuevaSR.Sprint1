using Tyuiu.BushuevaSR.Sprint1.Task6.V9.Lib;
namespace Tyuiu.BushuevaSR.Sprint1.Task6.V9
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
            Console.WriteLine("* Задание #6                                                                                                    *");
            Console.WriteLine("* Вариант #9                                                                                                    *");
            Console.WriteLine("* Выполнила: Бушуева Софья Романовна | ПИНб-26-1                                                                *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                                                                *");
            Console.WriteLine("* Напечатать все слова, перенеся их последнюю букву в начало.                                                   *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("Ведите текст:");
            string text = Console.ReadLine()!;

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (word == "") continue;
                Console.WriteLine(ds.MoveLetterToStart(word));
            }
            Console.ReadLine();
        }
    }
}
