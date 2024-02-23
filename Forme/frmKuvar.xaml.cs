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
    /// Interaction logic for frmKuvar.xaml
    /// </summary>
    public partial class frmKuvar : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();

        public frmKuvar()
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
                cmd.Parameters.Add("@imeKuvara", SqlDbType.NVarChar).Value = txtImeKuvara.Text;
                cmd.Parameters.Add("@prezimeKuvara", SqlDbType.NVarChar).Value = txtPrezimeKuvara.Text;
                cmd.Parameters.Add("@kontaktKuvara", SqlDbType.NVarChar).Value = txtKontaktKuvara.Text;
                cmd.Parameters.Add("@adresaKuvara", SqlDbType.NVarChar).Value = txtAdresaKuvara.Text;

                cmd.CommandText = @"insert into tblKuvar(ImeKuvar, PrezimeKuvar, KontaktKuvar, AdresaKuvara)
                                    values(@imeKuvara, @prezimeKuvara, @kontaktKuvara, @adresaKuvara)";
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
