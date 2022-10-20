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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle(Veri veri)
        {
            InitializeComponent();
            v = veri;
            dgvMenu.DataSource = v.Menuler;
            dgvIcecek.DataSource = v.Icecekler;
            dgvBurger.DataSource = v.Burgerlar;
            dgvIcecekOzel.DataSource = v.IceceklerOzel;
            dgvPatates.DataSource = v.Patates;
            dgvEkstra.DataSource = v.Ekstralar;
        }
        Veri v;
        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);

                v.Menuler.Add(u);

                dgvMenu.DataSource = null;
                dgvMenu.DataSource = v.Menuler;
            }

        }

        private void btnIcecekEkle_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = 0;

                v.Icecekler.Add(u);

                dgvIcecek.DataSource = null;
                dgvIcecek.DataSource = v.Icecekler;
            }

        }

        private void btnBurgerEkle_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);

                v.Burgerlar.Add(u);

                dgvBurger.DataSource = null;
                dgvBurger.DataSource = v.Burgerlar;
            }
  
        }

        private void btnPatatesEkle_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);

                v.Patates.Add(u);

                dgvPatates.DataSource = null;
                dgvPatates.DataSource = v.Patates;
            }


        }

        private void btnIcecekOzel_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {

                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);

                v.IceceklerOzel.Add(u);

                dgvIcecekOzel.DataSource = null;
                dgvIcecekOzel.DataSource = v.IceceklerOzel;
            }

        }

        private void BtnEkstralarEkle_Click(object sender, EventArgs e)
        {
            string deneme = txtFiyat.Text;
            if (string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || !decimal.TryParse(deneme, out decimal res))
            {
                MessageBox.Show("Doğru Giriş Yapın.");
            }
            else
            {
                Urun u = new Urun();
                u.UrunAdi = txtUrunAdi.Text;
                u.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);

                v.Ekstralar.Add(u);

                dgvEkstra.DataSource = null;
                dgvEkstra.DataSource = v.Ekstralar;
            }
            
        }

    }
}
