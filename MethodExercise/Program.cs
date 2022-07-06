using System;

namespace MethodExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} was on their way home with their pet {animal}, when they saw a {color} poster that announced {band}'s new album!");

            int answer1 = Add(23, 45);
            Console.WriteLine(answer1);

            int answer2 = Subtract(30, 15);
            Console.WriteLine(answer2);

            int answer3 = Multiply(5, 7);
            Console.WriteLine(answer3);

            int answer4 = Divide(35, 5);
            Console.WriteLine(answer4);

            int answer5 = Modulus(31, 3);
            Console.WriteLine(answer5);
        }
    }
}

