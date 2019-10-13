using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02.csharp3
{
    public class State
    {
        public State(string name, string acronym)
        {
            this.Name = name;
            this.Acronym = acronym;
        }

        public string Name { get; set; }

        public string Acronym { get; set; }

    }
}
