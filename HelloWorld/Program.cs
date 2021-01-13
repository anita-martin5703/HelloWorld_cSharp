/* Anita Martin 
 * Language: C#
 * Objective: Created a simple HelloWorld Program to introduce myself to C#
 */

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("On same line\n");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Your args: ");
            for (int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Num1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            float num2 = float.Parse(Console.ReadLine());

            float product = num1 * num2;
            Console.WriteLine(name + " the product is " + product);

            Console.WriteLine("Count: " + args.Length);
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }
    }
}
