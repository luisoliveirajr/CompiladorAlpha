using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompiladorAlpha
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Posfixa posfixa = new Posfixa();
        private ValidaExpPosfixa vep = new ValidaExpPosfixa();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String expressao = "";
            tbSaida.Clear();
            expressao = posfixa.ConvertePosfixa(tbEntrada.Text);
            if (vep.ValidaExpressaoPosfixa(expressao) == 1)
            {
                tbSaida.Text = expressao;
            }
            
        }
    }
}
