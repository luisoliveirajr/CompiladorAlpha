using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAlpha
{
    class Automato
    {
        private String alfabeto;
        private List<int> estados = new List<int>();
        private List <Simbolo> matrizdeTransicao = new List<Simbolo>();
        private int estadoInicial;
        private List<int> EstadosFinais = new List<int>();

        public void setAutomato(char simbolo)
        {
            alfabeto = alfabeto + simbolo;
            estados.Add(1);
            estados.Add(2);
            estadoInicial = 1;
            EstadosFinais.Add(2);
        }
    }
}
