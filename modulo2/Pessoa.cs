using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataNascimento;
        private float _altura;

        #region [ Variables ] 

        /// <summary>
        /// Nome de pessoal
        /// </summary>
        /// <param>
        /// Nome = Nome especifico
        /// </param>
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        #endregion

        #region [ Methods ] 

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome da pessoa: {_nome}");
            Console.WriteLine($"Data de nascimento: {_dataNascimento}");
            Console.WriteLine($"Altura da pessoa: {_altura}");
        }

        internal int CalculaIdade()
        {
            return DateTime.Today.Year - _dataNascimento.Year;
        }

        #endregion
    }
}
