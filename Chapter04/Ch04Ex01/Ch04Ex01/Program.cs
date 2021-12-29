﻿using System;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer is less than 10? {isLessThan10}");
            Console.WriteLine($"Integer is between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of above is true? " + 
                $"{isLessThan10 ^ isBetween0And5}");

            string stringResult = (myInt < 10) ? "Menor que 10"
                                            : "Maior ou igual a 10";

            Console.WriteLine(stringResult);

            Console.ReadKey();
        }
    }
}
