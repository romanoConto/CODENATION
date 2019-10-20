using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    public abstract class Forma
    {
        public double Area { get; set; }
        public string Cor { get; set; }
        public double Perimetro { get; set; }
        public string Descricao { get; set; }

        #region [ Metodos ]

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public virtual void TrocarDescricao()
        {
            Descricao += "Sou a classe abstrata Forma.";
        }

        #endregion
    }
}
