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
    /// Interaction logic for frmPorudzbina.xaml
    /// </summary>
    public partial class frmPorudzbina : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();
        public frmPorudzbina()
        {
            InitializeComponent();

            try
            {
                konekcija = kon.KreirajKonekciju();
                konekcija.Open();

                string vratiKonobara = @"select KonobarID, ImeKonobaraa+PrezimeKonobara as 'Ime i prezime konobara' from tblKonobar";
                SqlDataAdapter daKonobar = new SqlDataAdapter(vratiKonobara, konekcija);
                DataTable dtKonobar = new DataTable();
                daKonobar.Fill(dtKonobar);
                cbKonobar.ItemsSource = dtKonobar.DefaultView;
                dtKonobar.Dispose();
                daKonobar.Dispose();
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
