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
    public partial class YeniDemirbas : Form
    {
        public YeniDemirbas()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");

            #region Demirbaş BölümCombobox
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

            #region DEMİRBAŞ Combobox
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select distinct MalzemeKodu from Demirbaş", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbMalzKod.Items.Add(dr2[0]);
            }
            con.Close();
            dr2.Close();
            #endregion
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            DemirbasOlustur(mtxtKod.Text,txtAd.Text,cmbMalzKod.Text,cmbBolumKod.Text);
            Close();
        }

        public bool DemirbasOlustur(string DemirbasKodu, string DemirbasAdi, string MalzemeKodu, string BolumKodu)
        {
            if (MessageBox.Show("Demirbas kaydı oluşturulacaktır. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("DemirbasKodu", DemirbasKodu));
            parametreler.Add(new DictionaryEntry("DemirbasAdi", DemirbasAdi));
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasOlustur", parametreler));
        }
    }
}
