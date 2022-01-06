using System;

namespace cal3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var num1 = GitNumber();
            var isAddition = GitOperator();
            var num2 = GitNumber();
            if (isAddition)
            {
                Console.WriteLine(num1+num2);

            }
            else
            {
                Console.WriteLine(num1-num2);
            }

        }
        public static int GitNumber()
        {
            Console.WriteLine("\nenter a number");
            var num1 = Console.ReadLine();
            return int.Parse(num1);
        }
        public static bool GitOperator() 
        { 
        Console.WriteLine("enter - for subtraction + for addtion");
            var opperater =Console.ReadKey();
            var o = opperater.KeyChar;
            if(o == '+')
            {
                return true;
            }
            return false;
        } 
    }
}
