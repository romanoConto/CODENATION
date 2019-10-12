using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulo1
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">parâmetro padrão</param>
        static void Main(string[] args)
        {
            bool continuar = false;
            do
            {
                continuar = MenuExercicios();

            } while (continuar);
        }

        public static int GetInteger(string texto)
        {
            System.Console.WriteLine(texto);
            string input = Console.ReadLine();
            int valor = 0;

            if (int.TryParse(input, out valor))
            {
                return valor;
            }
            else
            {
                System.Console.WriteLine("Valor digitado inválido!");
                return GetInteger(texto);
            }
        }

        public static bool MenuExercicios()
        {
            bool continuar = true;

            Console.WriteLine("DIGITE O NUMERO DO EXERCÍCIO DESEJA EXECUTAR:");
            Console.WriteLine("11 - Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a possuir o valor da variável B, e a variável B passe a possuir o valor da variável. Apresentar os valores trocados.");
            Console.WriteLine();
            Console.WriteLine("12 - Escreva um programa que leia um número inteiro e exiba o seu módulo.O módulo de um número x é: x se x é maior ou igual a zero x * (-1) se x é menor que zero ");
            Console.WriteLine();
            Console.WriteLine("13 - Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.");
            Console.WriteLine();
            Console.WriteLine("14 - Escreva um programa que leia dois números e apresente a diferença do maior para o menor.");
            Console.WriteLine();
            Console.WriteLine("15 - Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter a nova média.Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação.Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição.Apresentar junto com as mensagens o valor da média do aluno.");
            Console.WriteLine();
            Console.WriteLine("26 - Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.");
            Console.WriteLine();
            Console.WriteLine("27 - FEscreva um programa que leia:");
            Console.WriteLine();
            Console.WriteLine("- a quantidade de números que deverá processar;");
            Console.WriteLine();
            Console.WriteLine("-os números que deverá processar, e calcule e exiba, para cada número a ser processado o seu fatorial.");
            Console.WriteLine();
            Console.WriteLine("Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... *N");
            Console.WriteLine();
            Console.WriteLine("28 - Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.");
            Console.WriteLine();
            Console.WriteLine("29 - Faça um programa que exiba os números de 1 até 2000.");
            Console.WriteLine();
            Console.WriteLine("0 - SAIR.");

            int exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 11:
                    Console.Clear();
                    Exercicio11();
                    break;
                case 12:
                    Console.Clear();
                    Exercicio12();
                    break;
                case 13:
                    Console.Clear();
                    Exercicio13();
                    break;
                case 14:
                    Console.Clear();
                    Exercicio14();
                    break;
                case 15:
                    Console.Clear();
                    Exercicio15();
                    break;
                case 26:
                    Console.Clear();
                    Exercicio26();
                    break;
                    break;
                case 27:
                    Console.Clear();
                    Exercicio27();
                    break;
                    break;
                case 28:
                    Console.Clear();
                    Exercicio28();
                    break;
                    break;
                case 29:
                    Console.Clear();
                    Exercicio29();
                    break;
                case 0:
                    continuar = false;
                    break;
            }
            Console.WriteLine("Aperte enter para voltar");
            Console.ReadLine();
            Console.Clear();

            return continuar;
        }

        public static void preAula()
        {
            string texto = "123456";

            int numero = int.Parse(texto);

            texto = numero.ToString();

            numero = Convert.ToInt32(texto);

            DateTime calendario = new DateTime();

            string calendarString = calendario.ToString();

            String leo = "Cachaceiro";

            Console.WriteLine("Hello World!" + " LEO = " + leo);
            Console.WriteLine("Numero 01 = " + numero);
            Console.WriteLine("Data = " + calendarString);

        }

        /*
         * 11) Ler dois valores inteiros para as variáveis A e B,
         * efetuar a troca dos valores de modo que a variável A passe a possuir o valor da variável B,
         * e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
        */
        public static void Exercicio11()
        {
            Console.WriteLine("Digite o primeiro texto");
            String var1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo texto");
            String var2 = Console.ReadLine();
            String temp = "";

            temp = var1;
            var1 = var2;
            var2 = temp;

            Console.WriteLine($"var1 = {var1}, var2 = {var2}");
        }

        /* 
         * 12) Escreva um programa que leia um número inteiro e exiba o seu módulo.
         *  O módulo de um número x é:
         *  x se x é maior ou igual a zero
         *  x * (-1) se x é menor que zero
         */
        public static void Exercicio12()
        {
            Console.WriteLine("Digite um numero para recebe o módulo dele:");
            String texto = Console.ReadLine();

            int var1 = int.Parse(texto);

            if (var1 < 0)
            {
                var1 = var1 * -1;
            }

            Console.WriteLine($"O resultado do módulo do número é: {var1}");
        }

        /*
         * 13) Escreva um programa que leia 3 números inteiros
         * e imprima na tela os valores em ordem decrescente.
         */
        public static void Exercicio13()
        {
            Console.WriteLine("Digite um numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero 3: ");
            int num3 = int.Parse(Console.ReadLine());

            List<int> numeros = new List<int>();

            numeros.Add(num1);
            numeros.Add(num2);
            numeros.Add(num3);

            numeros = numeros.OrderByDescending(x => x).ToArray().ToList();

            foreach (int num in numeros)
            {
                Console.WriteLine(num + "; ");
            }
        }

        /*
         * 14) Escreva um programa que leia dois números 
         * e apresente a diferença do maior para o menor.
         */
        public static void Exercicio14()
        {
            Console.WriteLine("Digite um numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int dif = 0;
            if (num1 > num2)
            {
                dif = num1 - num2;
            }
            else
            {
                dif = num2 - num1;
            }

            Console.WriteLine(dif);
        }

        /*
         * 15) Escreva um programa que leia quatro notas escolares de um aluno 
         * e apresentar uma mensagem que o aluno foi aprovado 
         * se o valor da média escolar for maior ou igual a 7. 
         * Se o valor da média for menor que 7, solicitar a nota do recuperação, 
         * somar com o valor da média e obter a nova média. 
         * Se a nova média for maior ou igual a 7, 
         * apresentar uma mensagem informando que o aluno foi aprovado na recuperação. 
         * Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição. 
         * Apresentar junto com as mensagens o valor da média do aluno.
         */
        private static void Exercicio15()
        {
            Console.WriteLine("Digite a primeira nota do Aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do Aluno: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do Aluno: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota do Aluno: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = nota1 + nota2 + nota3 + nota4;
            media = media / 4;

            String resultado = "Aluno aprovado! ";

            if (media < 7)
            {
                Console.WriteLine("Digite a nota de recuperação: ");
                media = media + double.Parse(Console.ReadLine());
                media = media / 2;
            }

            if (media < 7)
            {
                resultado = "Aluno reprovado";
            }

            Console.WriteLine(resultado + " Nota :" + media);
        }

        /*
         * 26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.
         */
        public static void Exercicio26()
        {
            for (int indice = 100; indice >= 0; indice--)
            {
                Console.Write(indice + "; ");
            }
            Console.WriteLine();
        }

        /*
         * 27) Escreva um programa que leia:
         * - a quantidade de números que deverá processar;
         * - os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu fatorial.
         * Lembrete: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N
         */
        public static void Exercicio27()
        {
            int val = 0;
            List<int> numeros = new List<int>();
            do
            {
                Console.WriteLine("Informe um número inteiro para ver seu fatorial. Se Desejar sair informe 0.");
                val = int.Parse(Console.ReadLine());
                numeros.Add(val);

            } while (val != 0);

            foreach (var numero in numeros)
            {
                if (numero == 0)
                    continue;

                Int64 fatorial = 1;
                for (int indice = 2; indice <= numero; indice++)
                {
                    fatorial = fatorial * indice;
                }

                Console.Write($"Número: {numero}. Fatorial: {fatorial}");
                Console.WriteLine();
            }
        }

        /*
         * 28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
         */
        public static void Exercicio28()
        {
            for (int indice = 100; indice <= 200; indice++)
            {
                if (indice % 2 == 0)
                {
                    Console.Write(indice + "; ");
                }
            }
            Console.WriteLine();
        }

        /*
         * 29) Faça um programa que exiba os números de 1 até 2000.
         */
        public static void Exercicio29()
        {
            for (int indice = 1; indice <= 2000; indice++)
            {
                Console.Write(indice + "; ");
            }
            Console.WriteLine();
        }
    }
}