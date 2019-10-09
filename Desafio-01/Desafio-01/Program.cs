using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listFib350 = Fibonacci();

            showFibonacciList(listFib350);

            String a = "á";
            char[] asa = a.ToCharArray();
            char.IsLetterOrDigit(asa[0]);

            IsFibonacci(2);

            string v = Crypt("a1b2c3d4e5f6g7h8i9j0");
            
            Console.WriteLine(v.Equals("d1e2f3g4h5i6j7k8l9m0").ToString());

            string u = Decrypt("a1b2c3d4e5f6g7h8i9j0");

            Console.WriteLine(u);
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


        public static string Crypt(string message)
        {
            int count = 3;

            if (message == null)
                throw new ArgumentNullException();

            if (message.Equals(""))
                return "";

            message = message.ToLower();

            char[] charsMsg = message.ToCharArray();

            for (int i = 0; i < charsMsg.Length; i++)
            {
                char c = charsMsg[i];

                if (!(char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (char.IsLetter(c))
                {

                    charsMsg[i] = (char)((charsMsg[i] - 'a' + 26 - count) % 26 + 'a');

                    charsMsg[i] = c;
                }
            }

            return new string(charsMsg);
        }

        public static string Decrypt(string cryptedMessage)
        {
            if (cryptedMessage == null)
                throw new ArgumentNullException();

            if (cryptedMessage.Equals(""))
                return "";

            char[] chars = cryptedMessage.ToCharArray();

            cryptedMessage = cryptedMessage.ToLower();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                if (!(char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (char.IsLetter(c))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        c--;
                    }

                    chars[i] = c;
                }
            }


            string retorno = new string(chars);

            retorno = retorno.ToLower();

            return retorno;
        }
    }
}
