using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    class Circulo_AbstractClass : Forma
    {
        public double Raio { get; set; }
        
        #region [ Method Override ]
        public override void CalcularArea()
        {
            this.Area = Math.PI * Math.Pow(this.Raio, 2);
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = Math.PI * this.Raio;
        }

        public override void TrocarDescricao()
        {
            base.TrocarDescricao();

            this.Descricao += "Forma de círculo";
        }
        #endregion
    }
}
