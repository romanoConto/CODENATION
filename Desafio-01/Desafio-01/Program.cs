using System;
using System.Collections.Generic;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fibonacci();
        }

        private static List<int> Fibonacci()
        {
            List<int> listFibonacci = new List<int>();

            int fib = 1;
            int fibAnt= 0;

            listFibonacci.Add(fibAnt);
            Console.WriteLine(fibAnt);
            listFibonacci.Add(fib);
            Console.WriteLine(fib); 

            while (fib <= 350)
            {
                int soma = fib + fibAnt;

                fibAnt = fib;

                fib = soma;

                listFibonacci.Add(soma);

                Console.WriteLine(soma);

            } ;


            return null;
        }

    }
}
