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

namespace Jogo_dos_Erros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool verifica = false;
        bool um = false;
        bool dois = false;
        bool tres = false;
        bool quatro = false;
        bool cinco = false;
        bool seis = false;
        bool sete = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click1(object sender, MouseButtonEventArgs e)
        {
            acerto1.Visibility = Visibility.Visible;
            um = true;
            terminou();
            voltar();
        }

        private void click2(object sender, MouseButtonEventArgs e)
        {
            acerto2.Visibility = Visibility.Visible;
            dois = true;
            terminou();
            voltar();
        }

        private void click3(object sender, MouseButtonEventArgs e)
        {
            acerto3.Visibility = Visibility.Visible;
            tres = true;
            terminou();
            voltar();
        }

        private void click4(object sender, MouseButtonEventArgs e)
        {
            acerto4.Visibility = Visibility.Visible;
            quatro = true;
            terminou();
            voltar();
        }

        private void click5(object sender, MouseButtonEventArgs e)
        {
            acerto5.Visibility = Visibility.Visible;
            cinco = true;
            terminou();
            voltar();
        }

        private void click6(object sender, MouseButtonEventArgs e)
        {
            acerto6.Visibility = Visibility.Visible;
            seis = true;
            terminou();
            voltar();
        }

        private void click7(object sender, MouseButtonEventArgs e)
        {
            acerto7.Visibility = Visibility.Visible;
            sete = true;
            terminou();
            voltar();
        }
        private void terminou()
        {
            if (um == true && dois == true && tres == true && quatro == true && cinco == true && seis == true && sete == true)
            {
                MessageBoxResult result = MessageBox.Show(
                    "Você conseguiu achar todos os erros",
                    "Parabéns!",
                    MessageBoxButton.OK
                    );
                verifica = true;
            }
        }
        private void voltar()
        {
            if (verifica == true)
            {
                verifica = false;
                um = false;
                dois = false;
                tres = false;
                quatro = false;
                cinco = false;
                seis = false;
                sete = false;
                acerto1.Visibility = Visibility.Hidden;
                acerto2.Visibility = Visibility.Hidden;
                acerto3.Visibility = Visibility.Hidden;
                acerto4.Visibility = Visibility.Hidden;
                acerto5.Visibility = Visibility.Hidden;
                acerto6.Visibility = Visibility.Hidden;
                acerto7.Visibility = Visibility.Hidden;
            }
        }
    }
}
