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
    public partial class DemirbasSilDüzenle : Form
    {
        public DemirbasSilDüzenle(Demirbas demirbas)
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
                cmbBolumDuzenle.Items.Add(dr4[0]);
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
                cmbMalzDuzenle.Items.Add(dr2[0]);
            }
            con.Close();
            dr2.Close();
            #endregion

            mtxtDemirbasKodDuzenle.Text = mtxtKod.Text = demirbas.DemirbasKodu;
            txtDemirbasAdDuzenle.Text = txtAd.Text = demirbas.DemirbasAdi;
            cmbBolumDuzenle.Text = cmbBolumKod.Text = demirbas.BolumKodu;
            cmbMalzDuzenle.Text = cmbMalzKod.Text = demirbas.MalzemeKodu;

            mtxtKod.Enabled = txtAd.Enabled = cmbBolumKod.Enabled = cmbMalzKod.Enabled = mtxtDemirbasKodDuzenle.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DemirbasSil(mtxtKod.Text, txtAd.Text ,cmbMalzKod.SelectedItem.ToString(),cmbBolumKod.SelectedItem.ToString());
            Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DemirbasDuzenle(mtxtDemirbasKodDuzenle.Text, txtDemirbasAdDuzenle.Text, cmbMalzDuzenle.SelectedItem.ToString(), cmbBolumDuzenle.SelectedItem.ToString());
            Close();
        }

        public bool DemirbasSil(string DemirbasKodu, string DemirbasAdi, string MalzemeKodu, string BolumKodu)
        {
            if (MessageBox.Show("Demirbas kaydı silinecektir. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("DemirbasKodu", DemirbasKodu));
            parametreler.Add(new DictionaryEntry("DemirbasAdi", DemirbasAdi));
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasSil", parametreler));
        }

        public bool DemirbasDuzenle(string DemirbasKodu, string DemirbasAdi, string MalzemeKodu, string BolumKodu)
        {
            if (MessageBox.Show("Demirbas kaydı düzenlenecektir. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("DemirbasKodu", DemirbasKodu));
            parametreler.Add(new DictionaryEntry("DemirbasAdi", DemirbasAdi));
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("BolumKodu", BolumKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasDuzenle", parametreler));
        }
    }
}
