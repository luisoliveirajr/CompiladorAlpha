using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAlpha
{
    class Simbolo
    {
        private char simbolo;
        private List <int> transicao = new List<int>();

        public void setSimbolo(char s, List <int> t)
        {
            this.simbolo = s;
            this.transicao = t;
        }
        public Simbolo getSimbolo()
        {
            return this;
        }
    }
}
