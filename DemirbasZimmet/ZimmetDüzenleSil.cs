using System;
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
    public partial class ZimmetDüzenleSil : Form
    {
        public ZimmetDüzenleSil(Zimmet zimmet)
        {
            InitializeComponent();
            Zimmet duzenle = new Zimmet();
            duzenle.SicilNo = zimmet.SicilNo;
            duzenle.BaslangicTarihi = zimmet.BaslangicTarihi;
            duzenle.BitisTarihi = zimmet.BitisTarihi;
            label3.Text = duzenle.SicilNo.ToString();
        }
    }
}
