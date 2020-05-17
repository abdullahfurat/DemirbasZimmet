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
    public partial class YeniBölüm : Form
    {
        public YeniBölüm()
        {
            InitializeComponent();


            #region BÖLÜM OLUŞTUR Combobox
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");
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
            BolumOlustur(txtBolumKodu.Text, txtBolumAdi.Text, mtxtTelefon.Text, mtxtFaks.Text, cmbAdresKodu.SelectedItem.ToString()); ;
            Close();
        }

        public bool BolumOlustur(string BolumKodu, string BolumAdi, string Telefon, string Faks,string AdresKodu)
        {
            if (MessageBox.Show("Yeni bölüm oluşturulacak. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));
            parametreler.Add(new DictionaryEntry("BolumAdi", BolumAdi));
            parametreler.Add(new DictionaryEntry("Telefon", Telefon));
            parametreler.Add(new DictionaryEntry("Faks", Faks));
            parametreler.Add(new DictionaryEntry("AdresKodu", AdresKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("BolumOlustur", parametreler));
        }
    }
}
