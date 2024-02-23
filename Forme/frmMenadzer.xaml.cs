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
    /// Interaction logic for frmMenadzer.xaml
    /// </summary>
    public partial class frmMenadzer : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();
        public frmMenadzer()
        {
            InitializeComponent();
        }

        private void txtSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = konekcija
                };
                cmd.Parameters.Add("@imeMenadzera", SqlDbType.NVarChar).Value = txtImeMenadzera.Text;
                cmd.Parameters.Add("@prezimeMenadzera", SqlDbType.NVarChar).Value = txtPrezimeMenadzera.Text;
                cmd.Parameters.Add("@kontaktMenadzera", SqlDbType.NVarChar).Value = txtKontaktMenadzera.Text;

                cmd.CommandText = @"insert into tblMenadzer(ImeMenadzera, PrezimeMenadzera, KontaktMenadzera)
                                    values(@imeMenadzera, @prezimeMenadzera, @kontaktMenadzera)";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Close();
            }

            catch (SqlException)
            {
                MessageBox.Show("Unos nije validan", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }
            }
        }

        private void txtOtkazi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
