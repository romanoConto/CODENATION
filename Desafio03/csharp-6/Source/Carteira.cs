using Codenation.Challenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03.csharp_6.Source
{
    class Carteira
    {

        [Add]
        private decimal _salary;

        [Add]
        private decimal _dsr;

        [Subtract]
        private decimal _shop;

        [Subtract]
        private decimal _study;

        public decimal Salary { get => _salary; set => _salary = value; }
        public decimal Dsr { get => _dsr; set => _dsr = value; }
        public decimal Shop { get => _shop; set => _shop = value; }
        public decimal Study { get => _study; set => _study = value; }
    }
}
