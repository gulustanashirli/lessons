using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            Console.WriteLine("1-ci reqemi daxil edin");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci reqemi daxil edin");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-cu reqemi daxil edin");
            int number2 = Convert.ToInt32(Console.ReadLine());
            num1 = number + number1 + number2;
            num2 = number - number1 - number2;
            num3 = number * number1 * number2;
            num4 = number / number1 / number2;
            Console.WriteLine("netice:8+10+12=30");
            Console.WriteLine("netice:8-10-12=-14");
            Console.WriteLine("netice:8*10*12=960");
            Console.WriteLine("netice:8/10/12=0");
            Console.ReadLine();








        }







    }  
    }

