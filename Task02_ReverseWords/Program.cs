using System;

namespace Task02_ReverseWords
{
    internal class Program
    {
        /// <summary>
        /// Задача2. Переставить слова из предложения в обратном порядке
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа перестановки слов в обратном порядке");
            Console.Write("Введите предложение: ");
            ReverseWords(Console.ReadLine());
            Console.ReadKey();
        }
        /// <summary>
        /// Метод перестановки слов и вывода результата на экран
        /// </summary>
        /// <param name="parseString">Строка для разбивки на слова</param>
        static void ReverseWords(string parseString)
        {
            string[] words = SplitWords(parseString);
            string reverseStr = "";
            for(int i = words.Length - 1; i >= 0; i--)
            {
                if(i != 0)
                    reverseStr += words[i] + ' ';
                else
                    reverseStr += words[i];
            }
            Console.WriteLine(reverseStr);
        }
        /// <summary>
        /// Метод разделения предложения на строковый массив
        /// </summary>
        /// <param name="parseString">Строка для разбивки на слова</param>
        /// <param name="separator">Разделитель по умолчанию</param>
        /// <returns>Строковый массив из слов</returns>
        static string [] SplitWords(string parseString, char separator = ' ')
        {
            return parseString.Split(separator);
        }
    }
}
