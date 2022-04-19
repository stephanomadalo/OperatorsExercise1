// See https://aka.ms/new-console-template for more information

using System;

namespace OperatorExercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) ;
            Console.WriteLine($"Modulo of {a} and {b} is {quotient} with remainder of {remainder}");
        }
    }
}