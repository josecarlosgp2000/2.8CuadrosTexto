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
        }

        private void SacarAyuda_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox objeto = (TextBox)sender;
            if (e.Key == Key.F1)
            {
                switch(objeto.Tag.ToString())
                {
                    case "nombreUsuario":
                        AyudaNombreTextBlock.Text = AyudaNombreTextBlock.Text.Length > 1 ? "" : "Nombre del usuario";
                        break;
                    case "apellidoUsuario":
                        AyudaApellidoTextBlock.Text = AyudaApellidoTextBlock.Text.Length> 1 ? "": "Apellido del usuario";
                        break;
                }
            }
        }    
        private void EdadUsuarioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                try
                {
                    int.Parse(EdadUsuarioTextBox.Text);
                    AyudaEdadTextBox.Text = "";
                }
                catch
                {
                    AyudaEdadTextBox.Text = "Edad Incorrecta";
                    AyudaEdadTextBox.Foreground = Brushes.Red;
                }
            }
        }
    }
}
