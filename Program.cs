using System;

namespace result
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            Console.WriteLine("Enter your Frist Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Addtion
            result = (num1 + num2);
            Console.WriteLine("Addition: " + result);

            //subtraction
            result = (num1 - num2);
            Console.WriteLine("Subtraction: " + result);

            //Multipication
            result = (num1 * num2);
            Console.WriteLine("Multipication: " + result);

            //Division
            result = (num1 / num2);
            Console.WriteLine("Division: " + result);

            Console.ReadLine();
        }
    }
}