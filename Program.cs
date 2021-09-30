using System;

namespace MethodExercisePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            var sum = Add(5, 8);
            var product = Multiply(5, 8);
            var quotient = Divide(5, 8);
            var remainder = Modulus(5, 8);
            var difference = Subtract(5, 8);
            Console.WriteLine("sum = " + sum); 
            Console.WriteLine("product = " + product);
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " + remainder);
            Console.WriteLine("difference = " + difference);
            Console.WriteLine("total =" + (sum + product + quotient + remainder + difference));
        }

        public static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
            
            

        }
        public static int Subtract(int num1, int num2)
        {
            var difference = num1 - num2;
            return difference;



        }
        public static int Multiply(int num1, int num2)
        {
            var product = num1 * num2;
            return product;



        }
        public static int Divide(int num1, int num2)
        {
            var quotient = num1 / num2;
            return quotient;



        }
        public static int Modulus(int num1, int num2)
        {
            var remainder = num1 % num2;
            return remainder;



        }

    }
}
