using System;
using System.Collections.Generic;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listFib350 = Fibonacci();

            showFibonacciList(listFib350);

            IsFibonacci(2);
        }

        public static List<int> Fibonacci()
        {
            List<int> listFibonacci = new List<int>();

            int fib = 1;
            int fibAnt = 0;

            listFibonacci.Add(fibAnt);
            listFibonacci.Add(fib);

            while (true)
            {
                int soma = fib + fibAnt;

                if (soma > 350)
                    break;

                fibAnt = fib;

                fib = soma;

                listFibonacci.Add(soma);
            };

            return listFibonacci;
        }

        private static void showFibonacciList(List<int> list)
        {
            string text = "";
            int indice = 0;
            bool isFirst = true;

            foreach (int fib in list)
            {
                indice++;

                text += fib;

                if (indice < list.Count)
                {
                    text += ", ";
                }
            }

            Console.WriteLine(text);
        }

        public static bool IsFibonacci(int numberToTest)
        {
            int fib = 1;
            int fibAnt = 0;

            for (int i = 0; i <= numberToTest; i++)
            {
                int soma = fib + fibAnt;

                if (soma == numberToTest)
                    return true;

                fibAnt = fib;

                fib = soma;
            }

            return false;
        }
    }
}
