using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasZimmet
{
    public partial class ZimmetDüzenleSil : Form
    {
        Zimmet secilenZimmet = new Zimmet();
        public ZimmetDüzenleSil(Zimmet zimmet)
        {
            InitializeComponent();
            secilenZimmet = zimmet;
            txtSicilNo.Text = zimmet.SicilNo.ToString();
            dtpBaslangic.Value = Convert.ToDateTime(zimmet.BaslangicTarihi);
            dtpBitis.Value = Convert.ToDateTime(zimmet.BitisTarihi);
            mtxtSicilNo.Text = zimmet.SicilNo.ToString();
            dtpBaslangıcTarihi.Value = Convert.ToDateTime(zimmet.BaslangicTarihi);
            dtpBitisTarihi.Value = Convert.ToDateTime(zimmet.BitisTarihi);
            dtpBaslangic.Enabled = false;
            dtpBitis.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ZimmetSicilNo = txtSicilNo.Text;
            string ZimmetDemirbasKodu = secilenZimmet.DemirbasKodu;

            if (ZimmetSil(ZimmetSicilNo, ZimmetDemirbasKodu))
            {
                this.Close();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string ZimmetSicilNo = mtxtSicilNo.Text;
            string ZimmetDemirbasKodu = secilenZimmet.DemirbasKodu;
            DateTime ZimmetBaslangicTarihi = dtpBaslangıcTarihi.Value;
            DateTime ZimmetBitisTarihi = dtpBitisTarihi.Value;

            if (ZimmetDuzenle(ZimmetSicilNo, ZimmetDemirbasKodu,ZimmetBaslangicTarihi,ZimmetBitisTarihi))
            {
                this.Close();
            }
        }

        public bool ZimmetSil(string ZimmetSicilNo, string ZimmetDemirbasKodu)
        {
            if (MessageBox.Show("Seçilen zimmet kaydı silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNo", ZimmetSicilNo));
            parametreler.Add(new DictionaryEntry("DemirbasKodu", ZimmetDemirbasKodu));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasZimmetIptal", parametreler));
        }

        public bool ZimmetDuzenle(string ZimmetSicilNo, string ZimmetDemirbasKodu,DateTime ZimmetBaslangicTarihi, DateTime ZimmetBitisTarihi)
        {
            if (MessageBox.Show("Seçilen zimmet kaydı düzenlenecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;

            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNo", ZimmetSicilNo));
            parametreler.Add(new DictionaryEntry("DemirbasKodu", ZimmetDemirbasKodu));
            parametreler.Add(new DictionaryEntry("BaslangicTarihi", ZimmetBaslangicTarihi));
            parametreler.Add(new DictionaryEntry("BitisTarihi", ZimmetBitisTarihi));

            return (Veritabani.ProsedurCalistir_MesajDegerlendir("DemirbasZimmetDuzenle", parametreler));
        }
    }
}
