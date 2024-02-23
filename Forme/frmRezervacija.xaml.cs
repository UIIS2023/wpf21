using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for frmRezervacija.xaml
    /// </summary>
    public partial class frmRezervacija : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();
        public frmRezervacija()
        {
            InitializeComponent();

            try
            {
                konekcija = kon.KreirajKonekciju();
                konekcija.Open();

                string vratiMenadzera = @"select MenadzerID, ImeMenadzera+PrezimeMenadzera as 'Ime i prezime menadzera' from tblMenadzer";
                SqlDataAdapter daMenadzer = new SqlDataAdapter(vratiMenadzera, konekcija);
                DataTable dtMenadzer = new DataTable();
                daMenadzer.Fill(dtMenadzer);
                cbMenadzer.ItemsSource = dtMenadzer.DefaultView;
                dtMenadzer.Dispose();
                daMenadzer.Dispose();
            }

            catch (SqlException)
            {
                MessageBox.Show("Padajuce liste nisu popunjene", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtSacuvaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
