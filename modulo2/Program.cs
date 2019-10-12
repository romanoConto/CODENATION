using Modulo2;
using System;

namespace Modulo2
{
    class Program
    {
        public static Agenda agenda = new Agenda();
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Juveno";
            pessoa.DataNascimento = new DateTime(2001, 11, 11);
            pessoa.Altura = 1.58f;

            pessoa.ImprimirDados();

            int idade = pessoa.CalculaIdade();

            Console.WriteLine($"Idade da pessoa: {idade}");


            bool continuar = false;
            do
            {
                continuar = Menu();

            } while (continuar);
        }

        private static bool Menu()
        {
            Console.Clear();
            bool continuar = true;

            Console.WriteLine("DIGITE O NUMERO DO EXERCÍCIO DESEJA EXECUTAR:");
            Console.WriteLine("2 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações: ");

            Console.WriteLine();
            Console.WriteLine("0 - SAIR.");

            int exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 2:
                    Console.Clear();

                    bool continuar2 = false;
                    do
                    {
                        continuar2 = Exercicio2();

                    } while (continuar2);
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

        private static bool Exercicio2()
        {
            bool continuar = true;

            Console.WriteLine("DIGITE O NUMERO DO EXERCÍCIO DESEJA EXECUTAR:");
            Console.WriteLine("1 - void armazenaPessoa(String nome, int idade, float altura);");
            Console.WriteLine();
            Console.WriteLine("2 - void removePessoa(String nome);");
            Console.WriteLine();
            Console.WriteLine("3 - int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa: ");
            Console.WriteLine();
            Console.WriteLine("4 - void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda: ");
            Console.WriteLine();
            Console.WriteLine("5 - void imprimePessoa(int index); // imprime os dados da pessoa que está na posição “i” da agenda.: ");
            Console.WriteLine();

            Console.WriteLine("0 - SAIR.");

            int exercicio = int.Parse(Console.ReadLine());

            string nome = "";
            string indice = "";

            try
            {
                switch (exercicio)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("digite o nome da pessoa, a idade e a altura");

                        nome = Console.ReadLine();
                        String idade = Console.ReadLine();
                        String altura = Console.ReadLine();

                        agenda.ArmazenaPessoa(nome, Convert.ToInt32(idade), float.Parse(altura));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("digite o nome da pessoa para remover");

                        nome = Console.ReadLine();

                        agenda.RemovePessoa(nome);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("informe um nome para mostrar o indice da pessoa");
                        indice = Console.ReadLine();

                        Console.WriteLine(agenda.BuscaPessoa(indice));
                        break;
                    case 4:
                        Console.Clear();
                        agenda.ImprimeAgenda();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("informe um indice para mostrar a pessoa");
                        indice = Console.ReadLine();
                        agenda.ImprimePessoa(Convert.ToInt32(indice));
                        break;
                    case 0:
                        continuar = false;
                        break;
                }
                Console.WriteLine("Aperte enter para voltar");
                Console.ReadLine();
                Console.Clear();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("ERRO!! Aperte enter para voltar");
                Console.ReadLine();
            }

            return continuar;
        }
    }
}
