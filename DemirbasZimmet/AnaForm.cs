using System;
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
    public partial class AnaForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Demirbas;Integrated Security=True");
        public AnaForm()
        {
            InitializeComponent();

            #region BÖLÜM Combobox
            SqlCommand cmd = new SqlCommand("Select BölümKodu from Bölüm", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.Items.Add(dr[0]);
            }
            con.Close();
            dr.Close();
            #endregion

            

            PersonelComboBox();

            #region DEMİRBAŞ Combobox
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select distinct MalzemeKodu from Demirbaş", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbMalzemeKodu.Items.Add(dr2[0]);
            }
            con.Close();
            dr2.Close();
            #endregion

            #region MALZEME ComboBox
            dgvMalzeme.DataSource = Veritabani.SELECTCalistir("Select MalzemeKodu,MalzemeAdı,MalzemeTürü,Adet from Malzeme");
            #endregion

            ZimmetDataGridView();


        }

        public void ZimmetDataGridView()
        {
            dgvZimmetListesi.DataSource = Veritabani.SELECTCalistir("select Unvan,PersonelAdı,PersonelSoyadı,DemirbasKodu,BaşlangıcTarihi,BitisTarihi from DemirbasZimmetleme inner join Personel on Personel.SicilNumarası =  DemirbasZimmetleme.SicilNo ");
        }

        private void PersonelComboBox()
        {
            SqlCommand cmd1 = new SqlCommand("Select SicilNumarası from Personel", con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbSicilNo.Items.Add(dr1[0]);
            }
            con.Close();
            dr1.Close();
        }

        private void cmbBolum_SelectedValueChanged(object sender, EventArgs e)
        {
            var secilen = cmbBolum.SelectedItem;
            var com = $"'{secilen}'";
            #region BolumDetay

            dgvBolumDetay.DataSource = Veritabani.SELECTCalistir($"Select BölümAdı,Telefon,Faks,AdresKodu from Bölüm where BölümKodu ={com}");

            #endregion

            #region BolumPersonelDetay

            dgvBolumPersonel.DataSource = Veritabani.SELECTCalistir($"Select Unvan,PersonelAdı,PersonelSoyadı,SicilNumarası from Personel where BölümKodu ={com}");

            #endregion

            #region BolumDemirbas

            dgvBolumDemirbas.DataSource = Veritabani.SELECTCalistir($"Select DemirbaşKodu,DemirbaşAdı from Demirbaş where BölümKodu ={com}");

            #endregion

            #region BolumAdres

            dgvAdres.DataSource = Veritabani.SELECTCalistir($"Select Mahalle,Sokak,KapıNo,İlçe,Şehir from AdresBilgisi where AdresKodu =(Select AdresKodu from Bölüm where BölümKodu ={com})");

            #endregion
        }

        private void cmbSicilNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = cmbSicilNo.SelectedItem;
            var com = $"'{secilen}'";
            #region PersonelDetayTelefon

            dgvPersonelDetayTel.DataSource = Veritabani.SELECTCalistir($"Select Telefon from [Personel-Telefon] where SicilNumarası ={com}");

            #endregion

            #region PersonelDetayBilgi

            con.Open();
            SqlCommand cmd1 = new SqlCommand($"Select Unvan,PersonelAdı,PersonelSoyadı,BölümKodu from Personel where SicilNumarası ={com}", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvPersonelDetayBilgi.DataSource = dt1;
            con.Close();

            #endregion

            #region PersonelDetayAdres

            con.Open();
            SqlCommand cmd2 = new SqlCommand($"select Mahalle,Sokak,KapıNo,İlçe,Şehir from AdresBilgisi inner join Personel on Personel.AdresKodu = AdresBilgisi.AdresKodu where Personel.SicilNumarası={com}", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvPersonelDetayAdres.DataSource = dt2;
            con.Close();

            #endregion

            #region PersonelDetayZimmet

            con.Open();
            SqlCommand cmd3 = new SqlCommand($"select DemirbasKodu,BaşlangıcTarihi,BitisTarihi from DemirbasZimmetleme where SicilNo={com}", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvPersonelZimmet.DataSource = dt3;
            con.Close();

            #endregion
        }

        private void cmbMalzemeKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = cmbMalzemeKodu.SelectedItem;
            var com = $"'{secilen}'";

            #region Demirbas

            dgvDemirbas.DataSource = Veritabani.SELECTCalistir($"select DemirbaşKodu,DemirbaşAdı,BölümKodu from Demirbaş where MalzemeKodu={com} and DemirbaşDurumu='true'");

            #endregion
        }


        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            cmbSicilNo.Items.Clear();
            var frm = new YeniPersonel();
            frm.ShowDialog();
            PersonelComboBox();
        }

        private void dgvZimmetListesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var DemirbasKodu = dgvZimmetListesi.SelectedRows[0].Cells[3].Value;
            var Baslangıc = dgvZimmetListesi.SelectedRows[0].Cells[4].Value;
            con.Open();
            SqlCommand cmd = new SqlCommand("select SicilNo,BaşlangıcTarihi,BitisTarihi from DemirbasZimmetleme where DemirbasKodu =@p1 and BaşlangıcTarihi = @p2", con);
            cmd.Parameters.AddWithValue("@p1", DemirbasKodu);
            cmd.Parameters.AddWithValue("@p2", Baslangıc);
            SqlDataReader dr = cmd.ExecuteReader();
            Zimmet zimmet = new Zimmet();
            dr.Read();

            DateTime bitis = DateTime.Now;
            if (dr[2] is DateTime)
            {
                bitis = (DateTime)dr[2];
            }
            zimmet = new Zimmet()
            {
                SicilNo = (int)dr[0],
                BaslangicTarihi = (DateTime)dr[1],
                BitisTarihi = bitis,
                DemirbasKodu = DemirbasKodu.ToString()
            };
            con.Close();
            dr.Close();
            var frm = new ZimmetDüzenleSil(zimmet);
            frm.ShowDialog();
            ZimmetDataGridView();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
