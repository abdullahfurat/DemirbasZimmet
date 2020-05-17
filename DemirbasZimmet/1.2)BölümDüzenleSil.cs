using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasZimmet
{
    public partial class BölümDüzenleSil : Form
    {
        public BölümDüzenleSil(Bölüm bölüm)
        {
            InitializeComponent();
            mtxtFaks.Enabled = txtBolumAdi.Enabled = txtBolumKodu.Enabled = txtBolumAdi.Enabled = mtxtTelefon.Enabled = cmbAdresKodu.Enabled = txtKodDuzenle.Enabled= false;

            mtxtFaks.Text = mtxtFaksDuzenle.Text = bölüm.Faks;
            cmbAdresKodDuzenle.Text = cmbAdresKodu.Text = bölüm.AdresKodu.ToString();
            txtAdDuzenle.Text = txtBolumAdi.Text = bölüm.BolumAdi;
            txtBolumKodu.Text = txtKodDuzenle.Text = bölüm.BolumKodu;
            mtxtTelefon.Text = mtxtTelefonDuzenle.Text = bölüm.Telefon;
            mtxtFaks.Text = mtxtFaksDuzenle.Text = bölüm.Faks;


            #region BÖLÜM OLUŞTUR Combobox
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select AdresKodu from AdresBilgisi", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbAdresKodDuzenle.Items.Add(dr[0]);
            }
            con.Close();
            dr.Close();
            #endregion

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            BolumSil(txtBolumKodu.Text, txtBolumAdi.Text, mtxtTelefon.Text, mtxtFaks.Text, cmbAdresKodu.Text);
            Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            BolumDuzenle(txtKodDuzenle.Text, txtAdDuzenle.Text, mtxtTelefonDuzenle.Text, mtxtFaksDuzenle.Text, cmbAdresKodDuzenle.Text);
            Close();
        }


        public bool BolumSil(string BolumKodu, string BolumAdi, string Telefon, string Faks, string AdresKodu)
        {
            if (MessageBox.Show("Bölüm silinecektir. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("BolumAdi", BolumAdi));
            parametreler.Add(new DictionaryEntry("Telefon", Telefon));
            parametreler.Add(new DictionaryEntry("Faks", Faks));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("BolumSil", parametreler));
        }

        public bool BolumDuzenle(string BolumKodu, string BolumAdi, string Telefon, string Faks, string AdresKodu)
        {
            if (MessageBox.Show("Bölüm düzenlenecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("BolumAdi", BolumAdi));
            parametreler.Add(new DictionaryEntry("Telefon", Telefon));
            parametreler.Add(new DictionaryEntry("Faks", Faks));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("BolumDuzenle", parametreler));
        }
    }
}
