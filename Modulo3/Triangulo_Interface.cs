using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    class Triangulo_Interface : IForma
    {
        public double Area { get; set; }
        public string Cor { get; set; }
        public double Perimetro { get; set; }
        public string Descricao { get; set; }
        public double Base { get; set; }
        public double LadoE { get; set; }
        public double LadoD { get; set; }
        public double Altura { get; set; }

        public void CalcularArea()
        {
            this.Area = this.Base * Altura;
        }

        public void CalcularPerimetro()
        {
            this.Perimetro = Base + LadoE + LadoD;
        }
    }
}
