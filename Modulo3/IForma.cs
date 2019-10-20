using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    public interface IForma
    {
        double Area { get; set; }
        string Cor { get; set; }
        double Perimetro { get; set; }
        string Descricao { get; set; }

        void CalcularArea();
        void CalcularPerimetro();
    }
}
