using System;

namespace Project
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**************************************");
            Console.WriteLine("******* Hypotenuse Calculator ********");
            Console.WriteLine("**************************************");
            
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);


            Console.ReadKey();

        }
    }
}
