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
using System.Data.OleDb;
using System.Data;

namespace BaseDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            OleDbConnection con; //Agregamos la conexion
            DataTable dt; //Agregar la tabla
            InitializeComponent();
            con = new OleDbConnection;
            con.ConnectionString = "Provider=Microsfot.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\AlumnosDB.mdb";
        }

        private void TxtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CbGenero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
