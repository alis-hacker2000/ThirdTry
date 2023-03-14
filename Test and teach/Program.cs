using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_and_teach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            Console.WriteLine(a);
            a = -3;
            Console.WriteLine(a);

            Console.WriteLine($"{a} + {a} = {a + a}");
            Console.WriteLine(a);

            int b = 7;
            Console.WriteLine(b);
            Console.WriteLine($"{b} + {b} = {b + b}");
            Console.WriteLine(b);
            b = b + b;
            Console.WriteLine(b);

            Console.WriteLine($"{b} + {a} = {b + a}");
            Console.WriteLine($"b = {b}\na = {a}");
            a = a + b;
            Console.WriteLine(a);
        }
    }
}
