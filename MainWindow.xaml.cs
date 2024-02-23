using Restoran.Forme;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restoran
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string ucitanaTabela;
        Konekcija kon = new Konekcija();
        SqlConnection konekcija = new SqlConnection();

        #region Select upiti
        static string konobariSelect = @"Select KonobarID, ImeKonobara as 'Ime konobara',
                                        PrezimeKonobara as 'Prezime konobara', KontaktKonobara as 'Kontakt konobara' from tblKonobar";
        static string menadzerSelect = @"Select MenadzerID, ImeMenadzera as 'Ime menadzera',
                                        PrezimeMenadzera as 'Prezime menadzera', KontaktMenadzera as 'Kontakt menazdera' from tblMenadzer";
        static string kuvarSelect = @"Select KuvarID, ImeKuvara as 'Ime konobara',
                                        PrezimeKuvara as 'Prezime kuvara', KontaktKuvara as 'Kontakt kuvara', AdresaKuvara as 'Adresa kuvara' from tblKuvar";
        static string gostSelect = @"Select GostID, BrojKartice as 'Broj kartice gosta' from tblGost";
        static string vrstaJelaSelect = @"Select VrstaJelaID, NazivVrstaJela as 'Naziv vrste jela' from tblVrstaJelo";
        static string rezervacijaSelect = @"Select RezervacijaID, DatumVreme as 'Datum rezervacije', BrojMesta as 'Broj rezervisanih mesta',
                                    BrojKartice as 'Broj kartice gosta', ImeMenadzera+PrezimeMenadzera as 'Ime i prezime menadzera' from
                                    tblRezervacija join tblGost on tblRezervacija.GostID=tblGost.GostID
                                    join tblMenadzer on tblMenadzer.MenadzerID=tblGost.GostID";
        static string porudzbinaSelect = @"select PorudzbinaID, Kolicina, Mera, Iznos, BrojKartice as 'Broj kartice gosta',
                                    ImeKonobara+PrezimeKonobara as 'Ime i prezime konobara' from tblPorudzbina join
                                    tblGost on tblPorudzbina.GostID=tblGost.GostID join tblKonobar on tblPorudzbina.KonobarID=tblKonobar.KonobarID";
        static string jeloSelect = @"select JeloID, NazivVrsteJela as 'Naziv vrste jela', NazivJela as 'Naziv jela', Cena, ImeKuvara+PrezimeKuvara as 'Ime i prezime kuvara',
                            from tblJelo join tblVrstaJelo on tblJelo.VrstaJelaID=tblVrstaJelo.VrstJelaID join tblKuvar.KuvarID=tblJelo.KuvarID";


        #endregion

        #region Select sa uslovom
        string selectUslovKonobar = @"select * from tblKonobar where KonobarID=";
        string selectUslovMenadzer = @"select * from tblMenadzer where MenadzerID=";
        string selectUslovKuvar = @"select * tblKuvar where KuvarID=";
        string selectUslovGost = @"select * from tblGost where GostID=";
        string selectUslovVrstaJela = @"select * from tblVrstaJelo where VrstaJelaID=";
        string selectUslovRezervacija = @"select * tblRezervacija where RezervacijaID=";
        string selectUslovPorudzbina = @"select * tblPorudzbina where PorudzbinaID=";
        string selectUslovJelo= @"select * tblJelo where JeloID=";
        #endregion

        #region
        string konobariDelete = @"delete from tblKonobar where KonobarID=";
        string menadzeriDelete = @"delete from tblMenadzer where MenadzerID=";
        string kuvariDelete = @"delete from tblKuvar where KuvarID=";
        string gostiDelete = @"delete from tblGost where GostID=";
        string vrstJelaDelete = @"delete from tblVrstaJelo where VrstaJeloID=";
        string rezervacijaDelete = @"delete from tblRezervacija where RezervacijaID=";
        string porudzbinaDelete = @"delete from tblPorudzbina where PorudzbinaID=";
        string jeloDelete = @"delete from tblJelo where JeloID=";
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            konekcija = kon.KreirajKonekciju();
            UcitajPodatke(dataGridCentralni, konobariSelect);
        }
        
        private void UcitajPodatke(DataGrid grid, string selectUpit)
        {
            try
            {
                konekcija.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectUpit, konekcija);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if(grid!=null)
                {
                    grid.ItemsSource = dt.DefaultView;
                }
                ucitanaTabela = selectUpit;
                dt.Dispose();
                dataAdapter.Dispose();
            }

            catch(SqlException)
            {
                MessageBox.Show("Nesuspesno ucitani podaci", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if(konekcija!=null)
                {
                    konekcija.Close();
                }
            }

        }

        private void btnKonobari_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, konobariSelect);
        }

        private void btnMenadzeri_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, menadzerSelect);

        }

        private void btnKuvari_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, kuvarSelect);

        }

        private void btnGosti_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, gostSelect);

        }

        private void btnRezervacije_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, rezervacijaSelect);

        }

        private void btnPorudzbine_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, porudzbinaSelect);

        }

        private void btnVrsteJela_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, vrstaJelaSelect);

        }

        private void btnJelo_Click(object sender, RoutedEventArgs e)
        {
            UcitajPodatke(dataGridCentralni, jeloSelect);

        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Window prozor;

            if(ucitanaTabela.Equals(konobariSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, konobariSelect);
            }
            else if(ucitanaTabela.Equals(menadzerSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, menadzerSelect);
            }
            else if (ucitanaTabela.Equals(kuvarSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, kuvarSelect);
            }
            else if (ucitanaTabela.Equals(gostSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, gostSelect);
            }
            else if (ucitanaTabela.Equals(vrstaJelaSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, vrstaJelaSelect);
            }
            else if (ucitanaTabela.Equals(rezervacijaSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, rezervacijaSelect);
            }
            else if (ucitanaTabela.Equals(porudzbinaSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, porudzbinaSelect);
            }
            else if (ucitanaTabela.Equals(jeloSelect))
            {
                prozor = new frmKonobar();
                prozor.ShowDialog();
                UcitajPodatke(dataGridCentralni, jeloSelect);
            }
        }
    }
}
