using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txtSicilNo.Text = zimmet.SicilNo.ToString();
            dtpBaslangic.Value = Convert.ToDateTime(zimmet.BaslangicTarihi);
            dtpBitis.Value = Convert.ToDateTime(zimmet.BitisTarihi);
            dtpBaslangic.Enabled = false;
            dtpBitis.Enabled = false;
        }

    }
}
