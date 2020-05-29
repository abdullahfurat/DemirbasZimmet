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
    public partial class BölümListesi : Form
    {
        public BölümListesi()
        {
            InitializeComponent();
            dgvBolum.DataSource = Veritabani.SELECTCalistir($"select * from Bölüm ");
        }
    }
}
