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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
  
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdUserInterfaz.Children.Clear();
            switch (cbUser.SelectedIndex)
            {
                case 0: //Alumno
                    grdUserInterfaz.Children.Add(new UserAlumno());
                    break;
                case 1: //Maestro
                    grdUserInterfaz.Children.Add(new UserMaestro());
                    break;
            }
        }
    }
}
