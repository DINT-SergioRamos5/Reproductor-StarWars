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

namespace Reproductor_StarWars
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Pause();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Stop();
        }

        private void Silenciar_Click(object sender, RoutedEventArgs e)
        {
            if (Silenciar.IsChecked == true)
            {
                Pantalla.IsMuted = true;
            }
            else
            {
                Pantalla.IsMuted = false;
            }
        }

        private void Trailer_Checked(object sender, RoutedEventArgs e)
        {
            if (Trailer1.IsChecked == true)
            {
                Pantalla.Source = new Uri(@"E:\2 DAM\DINT\2. Introduccion a WPF\Ejercicios\Reproductor StarWars\Reproductor StarWars\trailer1.mp4");
                Pantalla.Play();
            }
            else if (Trailer2.IsChecked == true)
            {
                Pantalla.Source = new Uri(@"E:\2 DAM\DINT\2. Introduccion a WPF\Ejercicios\Reproductor StarWars\Reproductor StarWars\trailer2.mp4");
                Pantalla.Play();
            }
        }
    }
}
