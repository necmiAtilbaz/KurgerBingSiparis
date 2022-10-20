using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgerBingSiparisProje
{
    public partial class frmSatis : Form
    {
        public frmSatis(Veri veri)
        {
            InitializeComponent();
            v = veri;
        }
        Veri v;
        private void frmSatis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = v.Siparisler;
            lblCiro.Text = v.Siparisler.Sum(x => x.SiparisFiyati).ToString() + "₺";
        }

    }
}
