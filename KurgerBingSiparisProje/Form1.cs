using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KurgerBingSiparisProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            v.SiparisSirasi = v.SiparisSirasi;
            VerileriOku();
        }

        public void satışlarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatis frmS = new frmSatis(v);
            frmS.Show();
            
        }
        Veri v = new Veri();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSiparisVer.Enabled = false;
            cmbMenuTuru.Text = "Seç";
            cmbMenuTuru.Items.Add("Hazır Menü");
            cmbMenuTuru.Items.Add("Kendi Menünü Oluştur");

            cmbHazirMenu.Text = "Seç";

            cmbBurger.Text = "Seç";

            cmbPatates.Text = "Seç";
            cmbPatates.Items.Add("Yok");
            
            cmbIcecek.Text = "Seç";
            
            cmbIcecekOzel.Text = "Seç";
            cmbIcecekOzel.Items.Add("Yok");
           
            cmbEkstra.Text = "Seç";
            cmbEkstra.Items.Add("Yok");
        }

        private void cmbMenuTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMenuTuru.SelectedIndex == 0)
            {
                FalseYap(true, true, false, false, false);
            }
            else if(cmbMenuTuru.SelectedIndex == 1)
            {
                FalseYap(false, false, true, true, true);
            }
            
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        
        decimal araci = 0;
        public void btnEkle_Click(object sender, EventArgs e)
        {
            decimal araci2 = 0;
            if (cmbMenuTuru.SelectedIndex == 0)
            {
                if(cmbHazirMenu.SelectedIndex == -1 || cmbIcecek.SelectedIndex == -1 || cmbEkstra.SelectedIndex == -1)
                {
                    MessageBox.Show("Boş Alanları Doldur.");
                }
                else
                {
                    lblSiparis.Text = lblSiparis.Text + " -- " + SiparisDetayHazir();
                    Siparis sip = new Siparis();
                    
                    foreach (var item in v.Menuler)
                    {
                        if (item.UrunAdi == cmbHazirMenu.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }
                    foreach (var item in v.Ekstralar)
                    {
                        if (item.UrunAdi == cmbEkstra.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }
                    lblTutar.Text = araci.ToString() + "₺";
                
                    sip.SiparisDetayi = SiparisDetayHazir();
                    sip.SiparisSayisi = v.SiparisSirasi;
                    v.SiparisSirasi++;
                    sip.SiparisZamani = DateTime.Now;
                    sip.SiparisFiyati = araci2;

                    v.Siparisler.Add(sip);
                }
            }
            else if(cmbMenuTuru.SelectedIndex == 1)
            {
                if(cmbBurger.SelectedIndex == -1 || cmbPatates.SelectedIndex == -1 || cmbIcecekOzel.SelectedIndex == -1 || cmbEkstra.SelectedIndex == -1)
                {
                    MessageBox.Show("Boş Alanları doldur.");
                }
                else
                {
                    lblSiparis.Text = lblSiparis.Text + " -- " + SiparisDetayOzel();
                    Siparis sip = new Siparis();

                    foreach (var item in v.Patates)
                    {
                        if (item.UrunAdi == cmbPatates.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }
                    foreach (var item in v.Burgerlar)
                    {
                        if (item.UrunAdi == cmbBurger.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }
                    foreach (var item in v.IceceklerOzel)
                    {
                        if (item.UrunAdi == cmbIcecekOzel.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }
                    foreach (var item in v.Ekstralar)
                    {
                        if (item.UrunAdi == cmbEkstra.SelectedItem.ToString())
                        {
                            araci += item.UrunFiyati;
                            araci2 += item.UrunFiyati;
                        }
                    }

                    lblTutar.Text = araci.ToString() + '₺';
                    sip.SiparisFiyati = araci2;
                    sip.SiparisDetayi = SiparisDetayOzel();
                    sip.SiparisSayisi = v.SiparisSirasi;
                    v.SiparisSirasi++;
                    sip.SiparisZamani = DateTime.Now;


                    v.Siparisler.Add(sip);
                }
            }
            else
            {
                MessageBox.Show("Menü Türünü Seçin.");
            }
            btnSiparisVer.Enabled = true;
        }

        private void cmbMenuTuru_Click(object sender, EventArgs e)
        {
            cmbEkstra.Items.Clear();
            cmbBurger.Items.Clear();
            cmbHazirMenu.Items.Clear();
            cmbIcecek.Items.Clear();
            cmbIcecekOzel.Items.Clear();
            cmbPatates.Items.Clear();

            foreach (var item in v.Menuler)
            {
                cmbHazirMenu.Items.Add(item.UrunAdi);
            }
            foreach (var item in v.Icecekler)
            {
                cmbIcecek.Items.Add(item.UrunAdi);
            }
            foreach (var item in v.Burgerlar)
            {
                cmbBurger.Items.Add(item.UrunAdi);
            }
            foreach (var item in v.IceceklerOzel)
            {
                cmbIcecekOzel.Items.Add(item.UrunAdi);
            }
            foreach (var item in v.Ekstralar)
            {
                cmbEkstra.Items.Add(item.UrunAdi);

            }
            foreach (var item in v.Patates)
            {
                cmbPatates.Items.Add(item.UrunAdi);
            }
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        { 
            araci = 0;
            Temizle();
        }

        private void smUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmEkle = new frmUrunEkle(v);
            frmEkle.Show();
        }

        public void Temizle()
        {
            cmbHazirMenu.Text = "Seç";
            cmbMenuTuru.Text = "Seç";
            cmbBurger.Text = "Seç";
            cmbPatates.Text = "Seç";
            cmbIcecekOzel.Text = "Seç";
            cmbIcecek.Text = "Seç";
            cmbEkstra.Text = "Seç";
            chbKetcap.Checked = false;
            chbMayonez.Checked = false;
            chbRanch.Checked = false;
            chbSMayonez.Checked = false;
            cmbBurger.Enabled = true;
            cmbPatates.Enabled = true;
            cmbIcecekOzel.Enabled = true;
            cmbIcecek.Enabled = true;
            cmbHazirMenu.Enabled = true;
            lblTutar.Text = "";
            lblSiparis.Text = "";
        }

        public string SiparisDetayHazir()
        {
            return cmbHazirMenu.SelectedItem.ToString() + ' ' + cmbIcecek.SelectedItem.ToString() + ' ' + (cmbEkstra.SelectedIndex > 0 ? cmbEkstra.SelectedItem.ToString() + " " : ", ") + ' ' + (chbKetcap.Checked ? chbKetcap.Text + ' ' : "") + (chbMayonez.Checked ? " " + chbMayonez.Text : "") + (chbSMayonez.Checked ? " " + chbSMayonez.Text : "") + (chbRanch.Checked ? " " + chbRanch.Text : "");
        }

        public string SiparisDetayOzel()
        { 
            return cmbBurger.SelectedItem.ToString() + ' ' + cmbIcecekOzel.SelectedItem.ToString() + ' ' + cmbPatates.SelectedItem.ToString() + ' ' + (cmbEkstra.SelectedIndex > 0 ? cmbEkstra.SelectedItem.ToString() + " " : ", ") + ' ' + (chbKetcap.Checked ? chbKetcap.Text + ' ' : "") + (chbMayonez.Checked ? " " + chbMayonez.Text : "") + (chbSMayonez.Checked ? " " + chbSMayonez.Text : "") + (chbRanch.Checked ? " " + chbRanch.Text : "");
        }

        public void FalseYap(bool t, bool t1, bool t2, bool t3, bool t4)
        {
            cmbIcecek.Enabled = t;
            cmbHazirMenu.Enabled = t1;
            cmbBurger.Enabled = t2;
            cmbPatates.Enabled = t3;
            cmbIcecekOzel.Enabled = t4;
        }

        void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(v);
            File.WriteAllText("veri.json", json);
        }

        void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                v = JsonConvert.DeserializeObject<Veri>(json);
            }
            catch (Exception)
            {
                v = new Veri();
            }
        }


    }
}
