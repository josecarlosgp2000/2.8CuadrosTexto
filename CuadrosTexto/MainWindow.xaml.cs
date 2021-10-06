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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreUsuarioTextBox.Tag = AyudaNombreTextBlock;
            ApellidoUsuarioTextBox.Tag = AyudaApellidoTextBlock;
        }

        private void SacarAyuda_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox objeto = (TextBox)sender;
            TextBlock mensaje = (TextBlock)objeto.Tag;
            if (e.Key == Key.F1)
            {
                mensaje.Visibility = mensaje.Visibility == Visibility ? Visibility.Hidden : Visibility.Visible;

            }
        }    
        private void EdadUsuarioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            AyudaEdadTextBox.Foreground = Brushes.Red;
            if (e.Key == Key.F2)
            {
                AyudaEdadTextBox.Text = int.TryParse(EdadUsuarioTextBox.Text, out _) ? "" : "Edad Incorrecta";
            }
        }
    }
}
