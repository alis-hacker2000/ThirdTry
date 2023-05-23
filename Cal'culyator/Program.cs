using System;
using System.Threading;

namespace Cal_culyator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {

                    Console.WriteLine("СпиДран по TikTocy");

                    float firstNamber;   //Первое число
                    float secondNamber; //Второе число
                    char userChar;     // символ

                    Console.Write("Введите первое число: ");
                    firstNamber = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    secondNamber = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите любое арифметическое действие(/,+,-,*): ");
                    userChar = Convert.ToChar(Console.ReadLine());

                    if (userChar == '+')
                    {
                        Console.WriteLine("Эгэ)))");
                        Console.WriteLine($"{firstNamber} + {secondNamber} = {firstNamber + secondNamber}");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (userChar == '-')
                    {
                        Console.WriteLine("НиЧёсе");
                        Console.WriteLine($"{firstNamber} - {secondNamber} = {firstNamber - secondNamber}");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (userChar == '*')
                    {
                        Console.WriteLine("Бум!");
                        Console.WriteLine($"{firstNamber} * {secondNamber} = {firstNamber * secondNamber}");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (userChar == '/')
                    {
                        if (secondNamber == 0)
                            Console.WriteLine("Минуточку... не могу разделить на ноль");
                        else
                            Console.WriteLine("тядя...");
                            Console.WriteLine($"{firstNamber} / {secondNamber} = {firstNamber / secondNamber}");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                        Console.WriteLine("Ошибка");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
    }
}
