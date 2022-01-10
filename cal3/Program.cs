using System;

namespace cal3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var num1 = GitNumber();
            var o = GitOperator();
            var num2 = GitNumber();
            switch (o)
            {
                case Operator.Add:
                    Console.WriteLine(num1 + num2);
                    break;
                case Operator.Subtract:
                    Console.WriteLine(num1 - num2);
                    break;
                case Operator.Multiply:
                    Console.WriteLine(num1 * num2);
                    break;
                case Operator.Divide:
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }  
        public static int GitNumber()
        {
            Console.WriteLine("\nenter a number");
            var num1 = Console.ReadLine();
            return int.Parse(num1);
        }
        public static Operator GitOperator()
        {
            var input = Operator.invalid;
            while (input == Operator.invalid)
            {

                Console.WriteLine("enter one of the following\n- for subtraction \n+ for addtion\n* for mutiply \n/ for divide");
                var opperater = Console.ReadKey();

                switch (opperater.KeyChar)
                {
                    case '+':
                        input = Operator.Add;
                        break;
                    case '-':
                        input = Operator.Subtract;
                        break;
                    case '*':
                        input = Operator.Multiply;
                        break;
                    case '/':
                        input = Operator.Divide;
                        break;
                    default:
                        input = Operator.invalid;
                        break;
                }

            }

            return input;
        }
    }
}
