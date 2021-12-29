using System;

namespace Ch03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //double firstNumber, secondNumber;
            //string userName;
            //Console.WriteLine("Enter your" +
            //    " name:\n");
            //userName = Console.ReadLine();
            //Console.WriteLine($"Welcome {userName}!");
            //Console.WriteLine("Now give me a number:\n");
            //firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Now give me another number:\n");
            //secondNumber = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("=========================================");


            //Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + 
            //    $"{firstNumber + secondNumber}");
            //Console.WriteLine();
            //Console.WriteLine($"The result of substracting {secondNumber} from " + 
            //    $"{firstNumber} is {firstNumber - secondNumber}.");
            //Console.WriteLine();
            //Console.WriteLine($"The product of {firstNumber} and {secondNumber} " +
            //       $"is {firstNumber + secondNumber}.");
            //Console.WriteLine();
            //Console.WriteLine($"The result of dividing {firstNumber} by " + 
            //    $"{secondNumber} is {firstNumber / secondNumber}");
            //Console.WriteLine();
            //Console.WriteLine($"The remainder after dividing {firstNumber} by " +
            //    $"{secondNumber} is {firstNumber % secondNumber}");

            var var1 = 1;
            var var2 = 1;

            var1 &= var2;

            Console.WriteLine(var1);

            Console.ReadKey();
        }
    }
}
