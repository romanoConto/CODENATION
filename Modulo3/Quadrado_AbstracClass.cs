using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    public class Quadrado_AbstracClass : Forma
    {
        public double Lado { get; set; }

        #region [ Metodos Override]
        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public override void TrocarDescricao()
        {
            base.TrocarDescricao();

            Descricao += "Clase Quadrado.";
        }

        #endregion

        #region [ Metodos ]



        #endregion
    }
}
