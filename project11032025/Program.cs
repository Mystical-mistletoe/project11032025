using System;

namespace project11032025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой символ будем считать в тексте?");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Осуществите ввод текста построчно.");
            Console.WriteLine("Для завершения ввода введите пустую строку, 'stop' или 'exit'");

            int countOfChar = 0;

            while (true)
            {
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp) || temp.ToLower() == "stop" || temp.ToLower() == "exit")
                    break;

                foreach (char ch in temp)
                {
                    if (ch == symbol)
                        countOfChar++;
                }
            }

            Console.WriteLine($"Вы ввели {countOfChar} символов '{symbol}'");
        }
    }
}