using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasZimmet
{
    public partial class MalzemeDuzenleSil : Form
    {
        public MalzemeDuzenleSil(Malzeme malzeme)
        {
            InitializeComponent();
            mtxtMalzemeKodu.Text = malzeme.MalzemeKodu;
            txtMalzemeAdi.Text = malzeme.MalzemeAdi;
            txtMalzemeTuru.Text = malzeme.MalzemeTuru;
            nudAdet.Value = malzeme.Adet;

            mtxtKodDuzenle.Text = malzeme.MalzemeKodu;
            txtAdDuzenle.Text = malzeme.MalzemeAdi;
            txtTurDuzenle.Text = malzeme.MalzemeTuru;
            nudAdetDuzenle.Value = malzeme.Adet;

            mtxtMalzemeKodu.Enabled = false;
            txtMalzemeAdi.Enabled = false;
            txtMalzemeTuru.Enabled = false;
            nudAdet.Enabled = false;
            mtxtKodDuzenle.Enabled = false;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            MalzemeDuzenle(mtxtKodDuzenle.Text, txtAdDuzenle.Text, txtTurDuzenle.Text, (int)nudAdetDuzenle.Value);
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MalzemeSil(mtxtMalzemeKodu.Text, txtMalzemeAdi.Text, txtMalzemeTuru.Text, (int)nudAdet.Value);
            Close();
        }

        public bool MalzemeSil(string MalzemeKodu, string MalzemeAdi, string MalzemeTuru, int Adet)
        {
            if (MessageBox.Show("Malzeme silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("MalzemeAdi", MalzemeAdi));
            parametreler.Add(new DictionaryEntry("MalzemeTuru", MalzemeTuru));
            parametreler.Add(new DictionaryEntry("Adet", Adet));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("MalzemeSil", parametreler));
        }

        public bool MalzemeDuzenle(string MalzemeKodu, string MalzemeAdi, string MalzemeTuru, int Adet)
        {
            if (MessageBox.Show("Malzeme düzenlenecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("MalzemeAdi", MalzemeAdi));
            parametreler.Add(new DictionaryEntry("MalzemeTuru", MalzemeTuru));
            parametreler.Add(new DictionaryEntry("Adet", Adet));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("MalzemeDuzenle", parametreler));
        }
    }
}
