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

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            ZimmetOlustur(mtxtsicilOlustur.Text, txtDemirbasOlustur.Text, dtpBaslangicOlustur.Value, dtpBitisOlustur.Value);
            ZimmetDataGridView();
        }

        public bool ZimmetOlustur(string ZimmetSicilNo, string ZimmetDemirbasKodu, DateTime Baslangic,DateTime Bitis)
        {
            if (MessageBox.Show("Zimmetleme kaydı oluşturulacaktır. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNo", ZimmetSicilNo));
            parametreler.Add(new DictionaryEntry("DemirbasKodu", ZimmetDemirbasKodu));
            parametreler.Add(new DictionaryEntry("BaslangicTarihi", Baslangic));
            parametreler.Add(new DictionaryEntry("BitisTarihi", Bitis));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasZimmetOlustur", parametreler));
        }

        private void btnYeniMalzeme_Click(object sender, EventArgs e)
        {
            var frm = new YeniMalzeme();
            frm.ShowDialog();
            #region MALZEME DataGridView
            dgvMalzeme.DataSource = Veritabani.SELECTCalistir("Select MalzemeKodu,MalzemeAdı,MalzemeTürü,Adet from Malzeme");
            #endregion
        }

        private void dgvMalzeme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string _MalzemeKodu = (string)dgvMalzeme.SelectedRows[0].Cells[0].Value;
            string _MalzemeAdi = (string)dgvMalzeme.SelectedRows[0].Cells[1].Value;
            string _MalzemTuru = (string)dgvMalzeme.SelectedRows[0].Cells[2].Value;
            int _Adet = (int)dgvMalzeme.SelectedRows[0].Cells[3].Value;

            Malzeme malzeme = new Malzeme
            {
                MalzemeAdi = _MalzemeAdi,
                MalzemeKodu = _MalzemeKodu,
                MalzemeTuru = _MalzemTuru,
                Adet = _Adet
            };
            var frm = new MalzemeDuzenleSil(malzeme);
            frm.ShowDialog();
            #region MALZEME DataGridView
            dgvMalzeme.DataSource = Veritabani.SELECTCalistir("Select MalzemeKodu,MalzemeAdı,MalzemeTürü,Adet from Malzeme");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new YeniBölüm();
            frm.ShowDialog();
            #region BÖLÜM Combobox
            con.Open();
            SqlCommand cmd = new SqlCommand("Select BölümKodu from Bölüm", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.Items.Add(dr[0]);
            }
            con.Close();
            dr.Close();
            #endregion
        }

        private void btnYeniBolum_Click(object sender, EventArgs e)
        {
            var frm = new YeniBölüm();
            frm.ShowDialog();

            #region BÖLÜM Combobox
            con.Open();
            SqlCommand cmd = new SqlCommand("Select BölümKodu from Bölüm", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.Items.Add(dr[0]);
            }
            con.Close();
            dr.Close();
            #endregion

        }

        private void btnBolumSilDuzenle_Click(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir bölüm seçiniz.");
                return;
            }
            string BolumKodu = cmbBolum.SelectedItem.ToString();
            var tamKod = "'" + BolumKodu + "'";
            con.Open();;
            SqlCommand cmd = new SqlCommand("Select BölümAdı,Telefon,Faks,AdresKodu from Bölüm where BölümKodu =" +tamKod, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Bölüm bölüm = new Bölüm();
            while (dr.Read())
            {
                 bölüm = new Bölüm
                {
                    BolumKodu=BolumKodu,
                    BolumAdi=dr[0].ToString(),
                    Telefon=dr[1].ToString(),
                    Faks=dr[2].ToString(),
                    AdresKodu=(int)dr[3]
                };
            }
            con.Close();
            dr.Close();

            var frm = new BölümDüzenleSil(bölüm);
            frm.ShowDialog();
            cmbBolum.SelectedIndex = 0;
            #region BÖLÜM Combobox
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select BölümKodu from Bölüm", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBolum.Items.Add(dr1[0]);
            }
            con.Close();
            dr1.Close();
            #endregion
        }

        private void btnPersonelSil_Click_1(object sender, EventArgs e)
        {
            if (cmbSicilNo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sicil numarası seçiniz.");
                return;
            }
            var SicilNo = cmbSicilNo.SelectedItem.ToString();
            var tamNo = "'" + SicilNo + "'";
            con.Open(); ;
            SqlCommand cmd = new SqlCommand("Select PersonelAdı,PersonelSoyadı,Unvan,BölümKodu,AdresKodu from Personel where SicilNumarası =" + tamNo, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Personel personel = new Personel();
            while (dr.Read())
            {
                personel = new Personel
                {
                    Sicilnumarasi = SicilNo,
                    PersonelAdi = dr[0].ToString(),
                    PersonelSoyadi = dr[1].ToString(),
                    Unvan = dr[2].ToString(),
                    BolumKodu = dr[3].ToString(),
                    AdresKodu=dr[4].ToString()
                };
            }
            con.Close();
            dr.Close();

            var frm = new PersonelSildüzenle(personel);
            frm.ShowDialog();
            cmbSicilNo.Items.Clear();
            PersonelComboBox();
        }

        private void btnYeniDemirbasOlustur_Click(object sender, EventArgs e)
        {
            var frm = new YeniDemirbas();
            frm.ShowDialog();

            #region Demirbas
            var secilen = cmbMalzemeKodu.SelectedItem;
            var com = $"'{secilen}'";
            dgvDemirbas.DataSource = Veritabani.SELECTCalistir($"select DemirbaşKodu,DemirbaşAdı,BölümKodu from Demirbaş where MalzemeKodu={com} and DemirbaşDurumu='true'");

            #endregion
        }

        private void dgvDemirbas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string _DemirbasAdi = (string)dgvDemirbas.SelectedRows[0].Cells[1].Value;
            string _DemirbasKodu = (string)dgvDemirbas.SelectedRows[0].Cells[0].Value;
            string _BolumKodu = (string)dgvDemirbas.SelectedRows[0].Cells[2].Value;
            string _MalzemeKodu = (string)cmbMalzemeKodu.SelectedItem;

            Demirbas demirbas = new Demirbas
            {
                DemirbasAdi = _DemirbasAdi,
                DemirbasKodu =_DemirbasKodu,
                BolumKodu =_BolumKodu,
                MalzemeKodu =_MalzemeKodu
            };
            var frm = new DemirbasSilDüzenle(demirbas);
            frm.ShowDialog();

            #region Demirbas
            var secilen = cmbMalzemeKodu.SelectedItem;
            var com = $"'{secilen}'";
            dgvDemirbas.DataSource = Veritabani.SELECTCalistir($"select DemirbaşKodu,DemirbaşAdı,BölümKodu from Demirbaş where MalzemeKodu={com} and DemirbaşDurumu='true'");

            #endregion
        }
    }
}
