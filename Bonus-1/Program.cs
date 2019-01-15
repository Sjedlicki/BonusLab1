using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.Write("Enter Numerical Grade: ");

                //double val = double.Parse(Console.ReadLine());

                bool inv = true;
                while (inv == true)
                {
                    double val = double.Parse(Console.ReadLine());

                    if ((val <= 100) && (val >= 88))
                    {
                        Console.WriteLine("A");
                        inv = false;
                    }
                    else if ((val <= 87) && (val >= 80))
                    {
                        Console.WriteLine("B");
                        inv = false;
                    }
                    else if ((val <= 79) && (val >= 67))
                    {
                        Console.WriteLine("C");
                        inv = false;
                    }
                    else if ((val <= 66) && (val >= 60))
                    {
                        Console.WriteLine("D");
                        inv = false;
                    }
                    else if ((val <= 59) && (val >= 0))
                    {
                        Console.WriteLine("F");
                        inv = false;
                    }
                    else if ((val > 100) || (val < 0))
                    {
                        Console.Write("Invalid, Try Again: ");
                        inv = true;
                    }
                }



               // Console.WriteLine("Enter another grade? (y/n): ");

                bool loop = true;
                while (loop == true)
                {
                    Console.WriteLine("Enter another grade? (y/n): ");
                    string cont = Console.ReadLine().ToLower();
                    if (cont == "y")
                    {
                        loop = false;
                        repeat = true;                       
                    }
                    else if (cont == "n")
                    {
                        loop = false;
                        repeat = false;
                        break;
                    }                    
                    else 
                    {
                        Console.WriteLine("Invalid try again");
                        loop = true;
                    }
                }

            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
