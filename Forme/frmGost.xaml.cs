using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Interaction logic for frmGost.xaml
    /// </summary>
    public partial class frmGost : Window
    {

        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();
        public frmGost()
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
                cmd.Parameters.Add("@brKartice", SqlDbType.NVarChar).Value = txtBrojKartice.Text;
                cmd.CommandText = @"insert into tblKonobar(BrojKartice)
                                    values(@brKartice)";
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
