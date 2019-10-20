using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    class Quadrado_Interface : IForma
    {
        public double Area { get; set; }
        public string Cor { get; set; }
        public double Perimetro { get; set; }
        public string Descricao { get; set; }
        public double Lado { get; set; }

        #region [ Methods ]
        public void CalcularArea()
        {
            this.Area = Math.Pow(Lado, 2);
        }

        public void CalcularPerimetro()
        {
            this.Perimetro = Lado * 4;
        }
        #endregion
    }
}
