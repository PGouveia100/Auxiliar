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


namespace SOLID_practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            char operador = Convert.ToChar(textBox1.Text);
            IOperacao resultadoSoma = new Soma();
            IOperacao resultadoSubtracao = new Subtracao();
            IOperacao resultadoMultiplicacao = new Multiplicacao();
            string apresentacaoResultado = null;


            try
            {
                switch (operador)
                {
                    case '+':
                        resultadoSoma.op(numero1, numero2);
                        apresentacaoResultado = Convert.ToString(resultadoSoma.resultado);
                        break;

                    case '-':
                        resultadoSubtracao.op(numero1, numero2);
                        apresentacaoResultado = Convert.ToString(resultadoSubtracao.resultado);
                        break;

                    case '*':
                        resultadoMultiplicacao.op(numero1, numero2);
                        apresentacaoResultado = Convert.ToString(resultadoMultiplicacao.resultado);
                        break;
                }

                textBox3.Text = apresentacaoResultado;

            }
            catch (Exception)
            {
                
            }

            




        }
    }
} 
