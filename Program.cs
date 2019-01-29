using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first numbre:");
            int tiv1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your sign: (+,-,*,/,%)");
            string sign = Console.ReadLine();
            if (tiv1 != 0)
                Console.WriteLine("Write your second numbre:");
            int tiv2 = Convert.ToInt32(Console.ReadLine());

           

            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", tiv1, tiv2, tiv1 + tiv2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", tiv1, tiv2, tiv1 - tiv2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", tiv1, tiv2, tiv1 * tiv2);
                    break;
                case "%":
                    Console.WriteLine("{0} % {1} = {2}", tiv1, tiv2, (tiv1 * tiv2) / 100);
                    break;
                case "/":
                    if (tiv2 != 0)
                        Console.WriteLine("{0} / {1} = {2}", tiv1, tiv2, (float)tiv1 / tiv2);
                    else
                        Console.WriteLine("To divide by zero! ");
                    break;

                default:
                    Console.WriteLine("You are write not a sign");
                    break;
            }
            Console.ReadKey();
        
        }
    }
}
