using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAlpha
{
    class Posfixa
    {
        private String ExpressaoPosfixa;
        private String Auxiliar;
        private Stack<char> Pilha = new Stack<char>();
        private int i;

        //Analisa precedência dos operadores;
        private int Precedencia(char operador){
            if (operador == '*') //Maior precedencia;
                return 3;
            else if (operador == '.')
                return 2;
            else if (operador == '+')
                return 1;
            else
                return 0; // Menor precedencia;
        }

        public String ConvertePosfixa(String expressao)
        {
            //Explicitando as concaternação da expressao;
            for (i=0; i < expressao.Length; i++) 
            {
                if(i > 0 && expressao[i] != ')' && expressao[i] != '.' && expressao[i] != '+' && expressao[i] != '*')
                {
                    if(expressao[i-1] != '(' && expressao[i-1] != ')' && expressao[i-1] != '+' && expressao[i-1] != '.'){

                        Auxiliar += '.'; 
                    }
                }
                Auxiliar += expressao[i];
            }
            expressao = Auxiliar;

            ExpressaoPosfixa = expressao;

            return ExpressaoPosfixa;
        }

    }
}
