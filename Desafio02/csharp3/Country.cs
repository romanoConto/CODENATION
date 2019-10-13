using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02.csharp3
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            State[] top10StatesByArea = new State[10];

            top10StatesByArea[0] = new State("Amazonas", "AM");
            top10StatesByArea[1] = new State("Pará", "PA");
            top10StatesByArea[2] = new State("Mato Grosso", "MT");
            top10StatesByArea[3] = new State("Minas Gerais", "MG");
            top10StatesByArea[4] = new State("Bahia", "BA");
            top10StatesByArea[5] = new State("Mato Grosso do Sul", "MS");
            top10StatesByArea[6] = new State("Goiás", "GO");
            top10StatesByArea[7] = new State("Maranhão", "MA");
            top10StatesByArea[8] = new State("Rio Grande do Sul", "RS");
            top10StatesByArea[9] = new State("Tocantins", "TO");

            return top10StatesByArea;
        }
    }
}
