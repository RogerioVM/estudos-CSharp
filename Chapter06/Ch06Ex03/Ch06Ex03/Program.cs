using System;

namespace Ch06Ex03
{
    class Program
    {
        static string myString = "A string global";

        static void String()
        {
            string myString = "Local";
            Program.myString = "Manipulação da string global";
            Console.WriteLine($"String na função: {myString}");
            Console.WriteLine(Program.myString);
        }

        // Parametros por referencia
        static int ShowDouble(ref int val)
        {
            // temos que usar a palavra ref para receber o parametro por referência, e também para chamar a função, passando o argumento.
            val *= 2;
            return val;
        }

        // Params argumentos
        static double Numbers(params double[] numbers)
        {
            double soma = 0;
            foreach (double item in numbers)
            {
                soma += item;
            }
            return soma/numbers.Length;
        }

        static void Main(string[] args)
        {
            int myValue = 5;
            Console.WriteLine($"Meu valor passado como argumento: {myValue}");
            ShowDouble(ref myValue);
            Console.WriteLine($"Valor dobrado pela função: {myValue}");

            //O valor referenciado pela função é mantido depois que passamos com a palavra "ref" no restante da aplicação: 
            Console.WriteLine($"Valor depois de chamado na função, sendo referenciado: { myValue}");

            myString = "String global";
            double resultado = Numbers(9.5,8.3,7.9);
            Console.WriteLine($"Params argumentos: {resultado.ToString("F2")}");
            String();
            Console.WriteLine($"String na função Main(): {myString}");
            Console.ReadKey();
        }
    }
}
