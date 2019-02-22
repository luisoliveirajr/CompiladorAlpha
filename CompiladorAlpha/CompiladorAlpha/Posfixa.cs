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

            //Convertendo expressao infixa para posfixa;
            for(i=0; i < expressao.Length; i++)
            {
                //Se for operando;
                if(expressao[i] != '(' && expressao[i] != ')' && expressao[i] != '.' && expressao[i] != '+' && expressao[i] != '*')
                {
                    ExpressaoPosfixa += expressao[i];
                }
                //Se for operador;
                else
                {
                    if(expressao[i] == '(')
                    {
                        Pilha.Push('(');
                    }
                    else if(expressao[i] == ')')
                    {
                        //Desempilhar todos elementos da pilha;
                        while (Pilha.Count != 0 && Pilha.Last() != '(')
                        {
                            ExpressaoPosfixa += Pilha.Last();
                            Pilha.Pop();
                        }
                        if(Pilha.Count != 0)
                        {
                            Pilha.Pop();
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("ERRO: Falta abrir parêntese.", "ERRO", System.Windows.MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        if(Pilha.Count != 0)
                        {
                            if(Precedencia(expressao[i]) > Precedencia(Pilha.Last()))
                            {
                                Pilha.Push(expressao[i]);
                            }
                            else
                            {
                                while(Pilha.Count != 0 && Precedencia(expressao[i]) <= Precedencia(Pilha.Last()))
                                {
                                    ExpressaoPosfixa += Pilha.Last();
                                    Pilha.Pop();
                                }
                                Pilha.Push(expressao[i]);
                            }
                        }
                        else
                        {
                            Pilha.Push(expressao[i]);
                        }
                    }
                }
            }
            while (Pilha.Count != 0 && Pilha.Last() != '(')
            {
                ExpressaoPosfixa += Pilha.Last();
                Pilha.Pop();
            }
            if(Pilha.Count != 0)
            {
                System.Windows.MessageBox.Show("ERRO: Falta fechar parêntese.", "ERRO", System.Windows.MessageBoxButton.OK);
            }
           
            return ExpressaoPosfixa;
        }

    }
}
