using System;

namespace Task01_SplitWords
{
    internal class Program
    {
        /// <summary>
        /// Задание1. Программа разделяющая предложение на слова.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа разделения строк на слова");
            Console.Write("Введите предложение: ");
            PrintWords(SplitWords(Console.ReadLine()));
            Console.ReadKey();
        }
        /// <summary>
        /// Метод разделения строки на массив слов по разделителю - "Пробел".
        /// </summary>
        /// <param name="parseString">Строка для разбивки на слова</param>
        /// <param name="separator">Разделитель по умолчанию</param>
        /// <returns>Строковый массив слов</returns>
        static string[] SplitWords(string parseString, char separator = ' ')
        {
            return parseString.Split(separator);
        }
        /// <summary>
        /// Метод вывода элементов массива на экран
        /// </summary>
        static void PrintWords(string[] words)
        {
            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}