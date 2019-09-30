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

namespace InterfazDinamita
{
    /// <summary>
    /// Lógica de interacción para UserMaestro.xaml
    /// </summary>
    public partial class UserMaestro : UserControl
    {
        public UserMaestro()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            lblNombreMaestro.Visibility = Visibility.Hidden;
            txtNombreMaestro.Visibility = Visibility.Hidden;
            lblCodigo.Visibility = Visibility.Hidden;
            txtCodigo.Visibility = Visibility.Hidden;
            lblTitulo.Visibility = Visibility.Hidden;
            txtTitulo.Visibility = Visibility.Hidden;
            lblMateria.Visibility = Visibility.Hidden;
            txtMateria.Visibility = Visibility.Hidden;
            btnGuardarMaestro.Visibility = Visibility.Hidden;
            btnCancelarMaestro.Visibility = Visibility.Hidden;
        }

        private void BtnCancelarMaestro_Click(object sender, RoutedEventArgs e)
        {
            lblNombreMaestro.Visibility = Visibility.Hidden;
            txtNombreMaestro.Visibility = Visibility.Hidden;
            lblCodigo.Visibility = Visibility.Hidden;
            txtCodigo.Visibility = Visibility.Hidden;
            lblTitulo.Visibility = Visibility.Hidden;
            txtTitulo.Visibility = Visibility.Hidden;
            lblMateria.Visibility = Visibility.Hidden;
            txtMateria.Visibility = Visibility.Hidden;
            btnGuardarMaestro.Visibility = Visibility.Hidden;
            btnCancelarMaestro.Visibility = Visibility.Hidden;
        }
    }
}
