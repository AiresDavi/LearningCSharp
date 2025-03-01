using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHello, " + name + "! Your age is " + age + ".");

            if (age < 18)
            {
                Console.WriteLine("\nSorry, you cannot enter.");
            }
            else
            {
                Console.WriteLine("\nYou are weolcome!");
            }

        }
    }
}
