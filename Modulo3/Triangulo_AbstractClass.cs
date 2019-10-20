using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    class Triangulo_AbstractClass : Forma
    {
        public double Base { get; set; }
        public double LadoE { get; set; }
        public double LadoD { get; set; }
        public double Altura { get; set; }

        public override void CalcularArea()
        {
            this.Area = this.Base * Altura;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = Base + LadoE + LadoD;

        }
    }
}
