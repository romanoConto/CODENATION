using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo2
{
    public class Agenda
    {
        private List<Pessoa> _pessoas = new List<Pessoa>();

        #region [ Variables ]

        #endregion

        #region [ Methods ]

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = nome;
            pessoa.DataNascimento = new DateTime(DateTime.Now.Year - idade, DateTime.Now.Month, DateTime.Now.Day);
            pessoa.Altura = altura;

            if(_pessoas.Count < 10)
            {
                _pessoas.Add(pessoa);
            }
        }

        public void RemovePessoa(string nome)
        {
            _pessoas.RemoveAt(BuscaPessoa(nome));
        }

        public int BuscaPessoa(string nome)
        {
            return _pessoas.FindIndex(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            foreach(var pessoa in _pessoas)
            {
                Console.WriteLine();
                pessoa.ImprimirDados();
            }
        }

        public void ImprimePessoa(int index)
        {
            _pessoas.ElementAt(index).ImprimirDados();
        }

        #endregion
    }
}
