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

            #region Mevcut Personel SicilNo
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SicilNumarası from Personel", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kisiler.Add(dr[0].ToString());
            }
            con.Close();
            dr.Close();
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (kisiler.Contains(mtxtSicil.Text))
            {
                MessageBox.Show("Bu Sicil Numarasıyla sisteme kayıtlı başka bir kullanıcı bulunmaktadır.");
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Personel values(@p1,@p2,@p3,@p4,@p5,@p6)", con);
            cmd.Parameters.AddWithValue("@p1", mtxtSicil.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p4", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@p5", cmbBolumKod.SelectedItem);
            cmd.Parameters.AddWithValue("@p6", txtAdresKod.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Eklenmiştir");
            mtxtSicil.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtUnvan.Clear();
            cmbBolumKod.SelectedIndex = 0;
            txtAdresKod.Clear();
            con.Close();

            Close();
        }
    }
}
