using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorAlpha
{
    class ValidaExpPosfixa
    {
        private int i;
        private Stack<char> Pilha = new Stack<char>();


        public int ValidaExpressaoPosfixa(String expressao)
        {
            Pilha.Clear();

            for (i=0; i< expressao.Length; i++)
            {
                //Se for operando empilha;
                if(expressao[i] != '.' && expressao[i] != '+' && expressao[i] != '*')
                {
                    Pilha.Push(expressao[i]);
                }
                //Se for operador;
                else
                {
                   //Se for operador Binário;
                   if(expressao[i] != '*')
                    {
                        if(Pilha.Count != 0)
                        {
                            Pilha.Pop();
                            if(Pilha.Count != 0)
                            {
                                Pilha.Pop();
                                Pilha.Push('B');
                            } //fim operador 1;
                            else
                            {
                                System.Windows.MessageBox.Show("O operador '"+expressao[i]+"' é binário e só foi encontrado um operando.", "ERRO", System.Windows.MessageBoxButton.OK);
                                return 0;
                            }
                        } //fim operador 2;
                        else
                        {
                            System.Windows.MessageBox.Show("O operador '" + expressao[i] + "' é binário e só foi encontrado um operando.", "ERRO", System.Windows.MessageBoxButton.OK);
                            return 0;
                        }
                    } //Fim teste operadores binarios;
                      //Se o operador for Unario;
                    else
                    {
                        if(Pilha.Count != 0)
                        {
                            Pilha.Pop();
                            Pilha.Push('U');
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("O operador '" + expressao[i] + " é unário e não foi encontrado operando.", "ERRO", System.Windows.MessageBoxButton.OK);
                            return 0;
                        }
                    }
                } //Fim Operadores;
            }//Fim for
            if(Pilha.Count == 0)
            {
                System.Windows.MessageBox.Show("Erro na expressão regular.", "ERRO", System.Windows.MessageBoxButton.OK);
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
