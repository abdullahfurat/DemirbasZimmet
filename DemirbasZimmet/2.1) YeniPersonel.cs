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
    public partial class YeniPersonel : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");
        List<string> kisiler = new List<string>();
        public YeniPersonel()
        {
            InitializeComponent();

            #region PERSONEL BölümCombobox
            SqlCommand cmd4 = new SqlCommand("Select BölümKodu from Bölüm", con);
            con.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBolumKod.Items.Add(dr4[0]);
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
            }
            con.Close();
            dr.Close();
            #endregion

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelOlustur(mtxtSicil.Text,txtAd.Text,txtSoyad.Text,txtUnvan.Text,cmbBolumKod.Text,cmbAdresKodu.Text);
            this.Close();
        }

        public bool PersonelOlustur(string SicilNo, string Ad, string Soyad, string Unvan, string BolumKodu, string AdresKodu)
        {
            if (MessageBox.Show("Personel kaydı oluşturulacaktır. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNumarasi", SicilNo));
            parametreler.Add(new DictionaryEntry("PersonelAdi", Ad));
            parametreler.Add(new DictionaryEntry("PersonelSoyadi", Soyad));
            parametreler.Add(new DictionaryEntry("Unvan", Unvan));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("PersonelOlustur", parametreler));
        }
    }
}
