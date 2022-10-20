namespace KurgerBingSiparisProje
{
    partial class frmUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.btnIcecekEkle = new System.Windows.Forms.Button();
            this.btnBurgerEkle = new System.Windows.Forms.Button();
            this.btnPatatesEkle = new System.Windows.Forms.Button();
            this.btnIcecekOzel = new System.Windows.Forms.Button();
            this.BtnEkstralarEkle = new System.Windows.Forms.Button();
            this.dgvIcecek = new System.Windows.Forms.DataGridView();
            this.dgvBurger = new System.Windows.Forms.DataGridView();
            this.dgvPatates = new System.Windows.Forms.DataGridView();
            this.dgvIcecekOzel = new System.Windows.Forms.DataGridView();
            this.dgvEkstra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcecekOzel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkstra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(12, 117);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(250, 275);
            this.dgvMenu.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(82, 16);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(110, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(82, 51);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(110, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı:";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnMenuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEkle.Location = new System.Drawing.Point(13, 90);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(249, 21);
            this.btnMenuEkle.TabIndex = 5;
            this.btnMenuEkle.Text = "Menu Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // btnIcecekEkle
            // 
            this.btnIcecekEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnIcecekEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcecekEkle.Location = new System.Drawing.Point(269, 90);
            this.btnIcecekEkle.Name = "btnIcecekEkle";
            this.btnIcecekEkle.Size = new System.Drawing.Size(249, 21);
            this.btnIcecekEkle.TabIndex = 5;
            this.btnIcecekEkle.Text = "İçecek Ekle";
            this.btnIcecekEkle.UseVisualStyleBackColor = false;
            this.btnIcecekEkle.Click += new System.EventHandler(this.btnIcecekEkle_Click);
            // 
            // btnBurgerEkle
            // 
            this.btnBurgerEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBurgerEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgerEkle.Location = new System.Drawing.Point(524, 90);
            this.btnBurgerEkle.Name = "btnBurgerEkle";
            this.btnBurgerEkle.Size = new System.Drawing.Size(250, 21);
            this.btnBurgerEkle.TabIndex = 5;
            this.btnBurgerEkle.Text = "Burger Ekle";
            this.btnBurgerEkle.UseVisualStyleBackColor = false;
            this.btnBurgerEkle.Click += new System.EventHandler(this.btnBurgerEkle_Click);
            // 
            // btnPatatesEkle
            // 
            this.btnPatatesEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPatatesEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatatesEkle.Location = new System.Drawing.Point(524, 403);
            this.btnPatatesEkle.Name = "btnPatatesEkle";
            this.btnPatatesEkle.Size = new System.Drawing.Size(249, 21);
            this.btnPatatesEkle.TabIndex = 5;
            this.btnPatatesEkle.Text = "Patates ekle";
            this.btnPatatesEkle.UseVisualStyleBackColor = false;
            this.btnPatatesEkle.Click += new System.EventHandler(this.btnPatatesEkle_Click);
            // 
            // btnIcecekOzel
            // 
            this.btnIcecekOzel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnIcecekOzel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcecekOzel.Location = new System.Drawing.Point(13, 403);
            this.btnIcecekOzel.Name = "btnIcecekOzel";
            this.btnIcecekOzel.Size = new System.Drawing.Size(249, 21);
            this.btnIcecekOzel.TabIndex = 5;
            this.btnIcecekOzel.Text = "İçecek Özel Ekle";
            this.btnIcecekOzel.UseVisualStyleBackColor = false;
            this.btnIcecekOzel.Click += new System.EventHandler(this.btnIcecekOzel_Click);
            // 
            // BtnEkstralarEkle
            // 
            this.BtnEkstralarEkle.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnEkstralarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkstralarEkle.Location = new System.Drawing.Point(268, 403);
            this.BtnEkstralarEkle.Name = "BtnEkstralarEkle";
            this.BtnEkstralarEkle.Size = new System.Drawing.Size(250, 21);
            this.BtnEkstralarEkle.TabIndex = 5;
            this.BtnEkstralarEkle.Text = "Ekstralar Ekle";
            this.BtnEkstralarEkle.UseVisualStyleBackColor = false;
            this.BtnEkstralarEkle.Click += new System.EventHandler(this.BtnEkstralarEkle_Click);
            // 
            // dgvIcecek
            // 
            this.dgvIcecek.AllowUserToAddRows = false;
            this.dgvIcecek.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvIcecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcecek.Location = new System.Drawing.Point(269, 117);
            this.dgvIcecek.Name = "dgvIcecek";
            this.dgvIcecek.ReadOnly = true;
            this.dgvIcecek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIcecek.Size = new System.Drawing.Size(250, 275);
            this.dgvIcecek.TabIndex = 0;
            // 
            // dgvBurger
            // 
            this.dgvBurger.AllowUserToAddRows = false;
            this.dgvBurger.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvBurger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBurger.Location = new System.Drawing.Point(524, 117);
            this.dgvBurger.Name = "dgvBurger";
            this.dgvBurger.ReadOnly = true;
            this.dgvBurger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBurger.Size = new System.Drawing.Size(250, 275);
            this.dgvBurger.TabIndex = 0;
            // 
            // dgvPatates
            // 
            this.dgvPatates.AllowUserToAddRows = false;
            this.dgvPatates.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvPatates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatates.Location = new System.Drawing.Point(524, 430);
            this.dgvPatates.Name = "dgvPatates";
            this.dgvPatates.ReadOnly = true;
            this.dgvPatates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatates.Size = new System.Drawing.Size(250, 275);
            this.dgvPatates.TabIndex = 0;
            // 
            // dgvIcecekOzel
            // 
            this.dgvIcecekOzel.AllowUserToAddRows = false;
            this.dgvIcecekOzel.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvIcecekOzel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcecekOzel.Location = new System.Drawing.Point(12, 430);
            this.dgvIcecekOzel.Name = "dgvIcecekOzel";
            this.dgvIcecekOzel.ReadOnly = true;
            this.dgvIcecekOzel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIcecekOzel.Size = new System.Drawing.Size(250, 275);
            this.dgvIcecekOzel.TabIndex = 0;
            // 
            // dgvEkstra
            // 
            this.dgvEkstra.AllowUserToAddRows = false;
            this.dgvEkstra.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvEkstra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEkstra.Location = new System.Drawing.Point(268, 430);
            this.dgvEkstra.Name = "dgvEkstra";
            this.dgvEkstra.ReadOnly = true;
            this.dgvEkstra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEkstra.Size = new System.Drawing.Size(250, 275);
            this.dgvEkstra.TabIndex = 0;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(786, 714);
            this.Controls.Add(this.BtnEkstralarEkle);
            this.Controls.Add(this.btnIcecekOzel);
            this.Controls.Add(this.btnPatatesEkle);
            this.Controls.Add(this.btnBurgerEkle);
            this.Controls.Add(this.btnIcecekEkle);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.dgvPatates);
            this.Controls.Add(this.dgvBurger);
            this.Controls.Add(this.dgvIcecek);
            this.Controls.Add(this.dgvEkstra);
            this.Controls.Add(this.dgvIcecekOzel);
            this.Controls.Add(this.dgvMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUrunEkle";
            this.Text = "frmUrunEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcecekOzel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkstra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.Button btnIcecekEkle;
        private System.Windows.Forms.Button btnBurgerEkle;
        private System.Windows.Forms.Button btnPatatesEkle;
        private System.Windows.Forms.Button btnIcecekOzel;
        private System.Windows.Forms.Button BtnEkstralarEkle;
        private System.Windows.Forms.DataGridView dgvIcecek;
        private System.Windows.Forms.DataGridView dgvBurger;
        private System.Windows.Forms.DataGridView dgvPatates;
        private System.Windows.Forms.DataGridView dgvIcecekOzel;
        private System.Windows.Forms.DataGridView dgvEkstra;
    }
}