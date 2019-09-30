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
    /// Lógica de interacción para UserAlumno.xaml
    /// </summary>
    public partial class UserAlumno : UserControl
    {
        public UserAlumno()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            lblNombreAlumno.Visibility = Visibility.Hidden;
            txtNombreAlumno.Visibility = Visibility.Hidden;
            lblMatricula.Visibility = Visibility.Hidden;
            txtMatricula.Visibility = Visibility.Hidden;
            lblPreparatoria.Visibility = Visibility.Hidden;
            txtPreparatoria.Visibility = Visibility.Hidden;
            btnGuardarAlumno.Visibility = Visibility.Hidden;
            btnCancelarAlumno.Visibility = Visibility.Hidden;
        }

        private void BtnCancelarAlumno_Click(object sender, RoutedEventArgs e)
        {
            lblNombreAlumno.Visibility = Visibility.Hidden;
            txtNombreAlumno.Visibility = Visibility.Hidden;
            lblMatricula.Visibility = Visibility.Hidden;
            txtMatricula.Visibility = Visibility.Hidden;
            lblPreparatoria.Visibility = Visibility.Hidden;
            txtPreparatoria.Visibility = Visibility.Hidden;
            btnGuardarAlumno.Visibility = Visibility.Hidden;
            btnCancelarAlumno.Visibility = Visibility.Hidden;
        }
    }
}
