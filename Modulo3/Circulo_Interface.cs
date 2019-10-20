using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    public class Circulo_Interface : IForma
    {
        public double Area { get; set; }
        public string Cor { get; set; }
        public double Perimetro { get; set; }
        public string Descricao { get; set; }
        public double Raio { get; set; }

        #region [ Metodo ]
        public void CalcularArea()
        {
            this.Area = Math.Pow(this.Raio, 2) * Math.PI;
        }

        public void CalcularPerimetro()
        {
            this.Perimetro = this.Raio * Math.PI;
        }

        #endregion
    }
}
