using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Restoran.Forme
{
    /// <summary>
    /// Interaction logic for frmJelo.xaml
    /// </summary>
    public partial class frmJelo : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();
        public frmJelo()
        {
            InitializeComponent();
        }

        private void txtSacuvaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
