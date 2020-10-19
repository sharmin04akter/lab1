using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("Sharmin Akter");
            //2
            int a = 15;
            int b = 10;
            int c = a + b;
            Console.WriteLine("add :" + c);
            //3
            double d = a / b;
            Console.WriteLine("div :" + d);
            //4
            double a1 = -5 + 8 * 6;
            Console.WriteLine("result a :" + a1);
            double a2 = (55 + 9) % 9;
            Console.WriteLine("result b :" + a2);
            double a3 = 20 + -3 * 5 / 8;
            Console.WriteLine("result c :" + a3);
            double a4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("result d :" + a4);
            //5
            int i = 20;
            int j = 15;
            int addition = i + j;
            Console.WriteLine("result addition :" + addition);
            double multiply = i * j;
            Console.WriteLine("result multiply :" + multiply);
            double subtract = i - j;
            Console.WriteLine("result subtract :" + subtract);
            double divide = i / j;
            Console.WriteLine("result.divide :" + divide);
            double remainder = i % j;
            Console.WriteLine("result remainder :" + remainder);
            //6
            double cal = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("calculation :" + cal);
            //7
            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine("Area is :" + width + "*" + height + "=" + area);
            Console.WriteLine("Perimeter is 2 * (" + width + "+" + height + ")=" + perimeter);
        }
    }
    
}
