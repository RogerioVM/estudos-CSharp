using System;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            string myString;
            myInt = 17;
            myString = " \"myInteger\" is"; // @ for use whithout escape sequence, exceptioning the quotation marks
            Console.WriteLine($"{myString} {myInt}");

            /*  int numero1;
              int numero2;

              int[] numbers = { 0b0001, 0b0010, 0b00100, 0b0001000, 0b00010000 };

              for (int i = 0; i < 10; i++)
              {
                  numero1 = 0b01 + 0b10;
                  Console.WriteLine(numero1);
              }*/
            var var1 = 1;
            var var2 = 2;

            var1 = var2++;

            Console.WriteLine(var1);
            Console.ReadKey();
        }
    }
}
