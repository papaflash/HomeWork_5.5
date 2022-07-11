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
        /// <returns>Массив слов</returns>
        static string[] SplitWords(string stringLine, char separator = ' ')
        {
            return stringLine.Split(separator);
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