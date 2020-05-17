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
    public partial class YeniMalzeme : Form
    {
        public YeniMalzeme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MalzemeOlustur(mtxtMalzemeKodu.Text, txtMalzemeAdi.Text, txtMalzemeTuru.Text, (int)nudAdet.Value);
            Close();
        }

        public bool MalzemeOlustur(string MalzemeKodu, string MalzemeAdi, string MalzemeTuru, int Adet)
        {
            if (MessageBox.Show("Yeni malzeme oluşturulacak. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("MalzemeKodu", MalzemeKodu));
            parametreler.Add(new DictionaryEntry("MalzemeAdi", MalzemeAdi));
            parametreler.Add(new DictionaryEntry("MalzemeTuru", MalzemeTuru));
            parametreler.Add(new DictionaryEntry("Adet", Adet));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("MalzemeOlustur", parametreler));
        }
    }
}
