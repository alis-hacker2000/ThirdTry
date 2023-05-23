using System;
using System.Threading;
namespace DzFiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
                    Console.WriteLine("Не является числом. \nВведите любое число в консоль:");
                }
            }

            Console.WriteLine("7*. Программа должна запросить у пользователя ввести текст, после чего она должна вывести его в консоль.");


            string y;
            float test;

            while (true)
            {

                Console.WriteLine("ВНИМАНИЕ! \nВведите любой текст в консоль:");
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
            Console.Write("Введите второе число:");
            fourthNum = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{thirdNum} + {fourthNum} = {thirdNum + fourthNum} \n" +
                $"{thirdNum} - {fourthNum} = {thirdNum - fourthNum} \n" +
                $"{thirdNum} / {fourthNum} = {thirdNum / fourthNum} \n" +
                $"{thirdNum} * {fourthNum} = {thirdNum * fourthNum}");

            Console.WriteLine("9*");

            string firstText;
            string secondText;

            Console.Write("ВНИМАНИЕ! \nВведите первое слово: ");
            firstText = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            secondText = Console.ReadLine();

            Console.WriteLine($"{firstText} {secondText}");

            Console.WriteLine(firstText + " " + secondText);
            
             */
            /*
            Console.WriteLine("10.");

            float fifthNum;
            float sixthNum;

            Console.Write("\nВНИМАНИЕ!\nВведите первое число: ");
            fifthNum = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nВНИМАНИЕ!\nВведите второе число: ");
            sixthNum = Convert.ToSingle(Console.ReadLine());

            if (fifthNum == sixthNum)
            {
                Console.WriteLine($"\n{fifthNum} = {sixthNum}");
            }
            else if (fifthNum > sixthNum)
            {
                Console.WriteLine($"\n{fifthNum} > {sixthNum}");
            }
            else  
            {
                Console.WriteLine($"\n{fifthNum} < {sixthNum}");
            }
            //Поймать ошибку (буквыБ точки. пробелы )
            

            Console.WriteLine("11");

            float seventhNum;
            float eightNum;

          //  Thread.Sleep(1000);

            Console.Write("\nВНИМАНИЕ!\nВведите первое число:");
            seventhNum = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nВНИМАНИЕ!\nВведите второе число:");
            eightNum = Convert.ToSingle(Console.ReadLine());

            if (seventhNum == 1000 && eightNum == 7)
             {
                Console.Beep(500, 200);
                Console.WriteLine("Le");
                Console.Beep(500, 220);
                Console.WriteLine("Le");
                Console.Beep(500, 240);
                Console.WriteLine("Let");
                Console.Beep(500, 300);
                Console.WriteLine("Me DIE");
                Console.Beep(400, 700);
                Console.Beep(500, 740);
             }

            while (seventhNum > 0)
            {
                Thread.Sleep(100);

                Console.WriteLine($"{seventhNum} - {eightNum} = {seventhNum - eightNum}");
                seventhNum = seventhNum - eightNum;
            }

            

            Console.WriteLine("12* Вывод текста с милодией.");
            Console.Write("\nВведите любое слово: ");

            string thirdText;
             int i = 0;
            thirdText = Console.ReadLine();

            while(i < 100)
            {
                i++;

                Console.Beep(100, 90);
                Console.Beep(300, 90);
                Console.Beep(400, 90);
                Console.Beep(100, 90);

                Console.WriteLine($"  {thirdText}");
            }

            */


        }
    }
}
