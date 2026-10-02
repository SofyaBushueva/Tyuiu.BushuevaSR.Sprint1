using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushuevaSR.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    string word = words[i];
                    words[i] = word [word.Length - 1] +word.Substring(0, word.Length - 1);  
                }
            }
            return string.Join(" ", words);

            
        }
    }
}
