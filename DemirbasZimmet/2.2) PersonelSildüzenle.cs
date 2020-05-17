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
    public partial class PersonelSildüzenle : Form
    {
        public PersonelSildüzenle(Personel personel)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");
            #region PERSONEL BölümCombobox
            SqlCommand cmd4 = new SqlCommand("Select BölümKodu from Bölüm", con);
            con.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBolumKod.Items.Add(dr4[0]);
                cmbBolumKoduDuzenle.Items.Add(dr4[0]);
            }
            con.Close();
            dr4.Close();
            #endregion


            #region PERSONEL AdresComboBox
            SqlCommand cmd = new SqlCommand("Select AdresKodu from AdresBilgisi", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbAdresKodu.Items.Add(dr[0]);
                cmbAdresKoduDuzenle.Items.Add(dr[0]);
            }
            con.Close();
            dr.Close();
            #endregion

            mtxtSicil.Text = mtxtSicilDuzenle.Text = personel.Sicilnumarasi;
            txtAd.Text = txtAdDuzenle.Text = personel.PersonelAdi;
            txtSoyad.Text = txtSoyadDuzenle.Text = personel.PersonelSoyadi;
            txtUnvan.Text = txtUnvanDuzenle.Text = personel.Unvan;
            cmbAdresKodu.Text = cmbAdresKoduDuzenle.Text = personel.AdresKodu;
            cmbBolumKod.Text = cmbBolumKoduDuzenle.Text = personel.BolumKodu;

            mtxtSicil.Enabled = txtAd.Enabled = txtSoyad.Enabled = txtUnvan.Enabled = cmbAdresKodu.Enabled = cmbBolumKod.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelSil(mtxtSicil.Text, txtAd.Text, txtSoyad.Text, txtUnvan.Text, cmbBolumKod.Text, cmbAdresKodu.Text);
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            PersonelDuzenle(mtxtSicilDuzenle.Text, txtAdDuzenle.Text, txtSoyadDuzenle.Text, txtUnvanDuzenle.Text, cmbBolumKoduDuzenle.Text, cmbAdresKoduDuzenle.Text);
            this.Close();
        }

        public bool PersonelSil(string SicilNo, string Ad, string Soyad, string Unvan, string BolumKodu, string AdresKodu)
        {
            if (MessageBox.Show("Personel silinecektir. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNumarasi", SicilNo));
            parametreler.Add(new DictionaryEntry("PersonelAdi", Ad));
            parametreler.Add(new DictionaryEntry("PersonelSoyadi", Soyad));
            parametreler.Add(new DictionaryEntry("Unvan", Unvan));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("PersonelSil", parametreler));
        }

        public bool PersonelDuzenle(string SicilNo, string Ad, string Soyad, string Unvan, string BolumKodu, string AdresKodu)
        {
            if (MessageBox.Show("Personel düzenlenecektir. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNumarasi", SicilNo));
            parametreler.Add(new DictionaryEntry("PersonelAdi", Ad));
            parametreler.Add(new DictionaryEntry("PersonelSoyadi", Soyad));
            parametreler.Add(new DictionaryEntry("Unvan", Unvan));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("PersonelDuzenle", parametreler));
        }
    }
}
