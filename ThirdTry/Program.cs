using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DzFiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Программа должна вывести в консоль число 21.");
            Console.WriteLine();
            Console.WriteLine(21);
            Console.WriteLine();

            Thread.Sleep(2000);

            Console.WriteLine("2. Программа должна вывести в консоль текст:/Hello World!/");
            Console.WriteLine();
            Console.WriteLine("Hello World");
            Console.WriteLine();

            Thread.Sleep(2000);

            Console.WriteLine("3. Программа должна вывести в консоль значение числовой переменной /number/");
            int number = 4;
            Console.WriteLine();
            Console.WriteLine(number);
            Console.WriteLine();

            Thread.Sleep(2000);

            Console.WriteLine("4. Программа должна вывести в консоль значение текстовой переменной /text/.");
            Console.WriteLine();
            object Text = "cucumber";
            Console.WriteLine(Text);
            Console.WriteLine();

            Thread.Sleep(2000);

            Console.WriteLine("5. Программа должна вывести в консоль результат произведение числовых переменных " +
                "/firstNum/ и /secondNum/.");
            Console.WriteLine();
            int firstNum = 8;
            int secondNum = 4;
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
            Console.WriteLine();

            Thread.Sleep(2000);

            Console.WriteLine("6*. Программа должна запросить у пользователя ввести число, после чего она должна вывести его в консоль.");
            Console.WriteLine();

            Thread.Sleep(1000);
            Console.WriteLine("ВНИМАНИЕ! \n Введите любое число в консоль:");

            float x;

            while (true)
            {
                try
                {
                    x = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Хорошо.");
                    Console.WriteLine(x);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не является числом. \n Введите любое число в консоль:");
                }
            }

            Console.WriteLine("7*. Программа должна запросить у пользователя ввести текст, после чего она должна вывести его в консоль.");


            string y;
            float test;

            while (true)
            {

                Console.WriteLine("ВНИМАНИЕ! \n Введите любой текст в консоль:");
                y = Console.ReadLine(); //Не приходит к правде продолжая запрашивать введения слова

                try
                {
                    test = Convert.ToSingle(y);
                    Console.WriteLine("Вы ввели число");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Cпасибо, вот ваш текст: {y}");
                    break;
                }
            }

            Console.WriteLine("8*. Программа должна запросить у пользователя 2 числа, после чего вывести" +
                " в консоль их сумму, разность, произведение, частное.");
            Console.WriteLine("");

            float thirdNum;
            float fourthNum;

            Console.Write("ВНИМАНИЕ! \nВведите первое число: ");
            thirdNum = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            fourthNum = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{thirdNum} + {fourthNum} = {thirdNum + fourthNum} \n" +
                $"{thirdNum} - {fourthNum} = {thirdNum - fourthNum} \n" +
                $"{thirdNum} / {fourthNum} = {thirdNum / fourthNum} \n" +
                $"{thirdNum} * {fourthNum} = {thirdNum * fourthNum}");
        }
    }
}
