
namespace CokluBaglıListe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabLayout = new System.Windows.Forms.TabControl();
            this.DoublyLinkedList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunGuncellemeHata = new System.Windows.Forms.Label();
            this.hataMesajSilme = new System.Windows.Forms.Label();
            this.btnUrunleriListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunGuncellemeBul = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.urunGuncelleFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.urunGuncelleAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.urunGuncelleKod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunSilmeBul = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.urunSilmeFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.urunSilmeAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.urunSilmeKod = new System.Windows.Forms.TextBox();
            this.UrunEkleme = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urunEkleFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urunEkleAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunEkleKod = new System.Windows.Forms.TextBox();
            this.hataMesaj = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Stack = new System.Windows.Forms.TabPage();
            this.dataGridViewStack = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCıkarStack = new System.Windows.Forms.Button();
            this.btnEkleStack = new System.Windows.Forms.Button();
            this.stackYeniEkle = new System.Windows.Forms.TextBox();
            this.TabLayout.SuspendLayout();
            this.DoublyLinkedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UrunEkleme.SuspendLayout();
            this.Stack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).BeginInit();
            this.SuspendLayout();
            // 
            // TabLayout
            // 
            this.TabLayout.Controls.Add(this.DoublyLinkedList);
            this.TabLayout.Controls.Add(this.Stack);
            this.TabLayout.Location = new System.Drawing.Point(-1, 0);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.SelectedIndex = 0;
            this.TabLayout.Size = new System.Drawing.Size(1026, 706);
            this.TabLayout.TabIndex = 0;
            this.TabLayout.Tag = "";
            // 
            // DoublyLinkedList
            // 
            this.DoublyLinkedList.Controls.Add(this.dataGridView);
            this.DoublyLinkedList.Controls.Add(this.urunGuncellemeHata);
            this.DoublyLinkedList.Controls.Add(this.hataMesajSilme);
            this.DoublyLinkedList.Controls.Add(this.btnUrunleriListele);
            this.DoublyLinkedList.Controls.Add(this.groupBox2);
            this.DoublyLinkedList.Controls.Add(this.groupBox1);
            this.DoublyLinkedList.Controls.Add(this.UrunEkleme);
            this.DoublyLinkedList.Controls.Add(this.hataMesaj);
            this.DoublyLinkedList.Controls.Add(this.btnGüncelle);
            this.DoublyLinkedList.Controls.Add(this.label12);
            this.DoublyLinkedList.Controls.Add(this.btnSil);
            this.DoublyLinkedList.Controls.Add(this.label5);
            this.DoublyLinkedList.Controls.Add(this.btnEkle);
            this.DoublyLinkedList.Controls.Add(this.label1);
            this.DoublyLinkedList.Location = new System.Drawing.Point(4, 24);
            this.DoublyLinkedList.Name = "DoublyLinkedList";
            this.DoublyLinkedList.Padding = new System.Windows.Forms.Padding(3);
            this.DoublyLinkedList.Size = new System.Drawing.Size(1018, 678);
            this.DoublyLinkedList.TabIndex = 0;
            this.DoublyLinkedList.Text = "Doubly Linked List";
            this.DoublyLinkedList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView.Location = new System.Drawing.Point(245, 472);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(485, 198);
            this.dataGridView.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Kodu";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün kg Fiyatı";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // urunGuncellemeHata
            // 
            this.urunGuncellemeHata.AutoSize = true;
            this.urunGuncellemeHata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urunGuncellemeHata.ForeColor = System.Drawing.Color.Red;
            this.urunGuncellemeHata.Location = new System.Drawing.Point(736, 336);
            this.urunGuncellemeHata.Name = "urunGuncellemeHata";
            this.urunGuncellemeHata.Size = new System.Drawing.Size(178, 40);
            this.urunGuncellemeHata.TabIndex = 46;
            this.urunGuncellemeHata.Text = "Bu koda sahip bir \r\n ürün bulunmamaktadır.";
            this.urunGuncellemeHata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.urunGuncellemeHata.Visible = false;
            // 
            // hataMesajSilme
            // 
            this.hataMesajSilme.AutoSize = true;
            this.hataMesajSilme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hataMesajSilme.ForeColor = System.Drawing.Color.Red;
            this.hataMesajSilme.Location = new System.Drawing.Point(395, 336);
            this.hataMesajSilme.Name = "hataMesajSilme";
            this.hataMesajSilme.Size = new System.Drawing.Size(178, 40);
            this.hataMesajSilme.TabIndex = 45;
            this.hataMesajSilme.Text = "Bu koda sahip bir \r\n ürün bulunmamaktadır.";
            this.hataMesajSilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hataMesajSilme.Visible = false;
            // 
            // btnUrunleriListele
            // 
            this.btnUrunleriListele.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunleriListele.Location = new System.Drawing.Point(364, 401);
            this.btnUrunleriListele.Name = "btnUrunleriListele";
            this.btnUrunleriListele.Size = new System.Drawing.Size(209, 50);
            this.btnUrunleriListele.TabIndex = 44;
            this.btnUrunleriListele.Text = "Ürünleri Listele";
            this.btnUrunleriListele.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunGuncellemeBul);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.urunGuncelleFiyat);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.urunGuncelleAd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.urunGuncelleKod);
            this.groupBox2.Location = new System.Drawing.Point(669, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 198);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // urunGuncellemeBul
            // 
            this.urunGuncellemeBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urunGuncellemeBul.Location = new System.Drawing.Point(228, 28);
            this.urunGuncellemeBul.Name = "urunGuncellemeBul";
            this.urunGuncellemeBul.Size = new System.Drawing.Size(47, 28);
            this.urunGuncellemeBul.TabIndex = 31;
            this.urunGuncellemeBul.Text = "Bul";
            this.urunGuncellemeBul.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 28);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fiyatı :";
            // 
            // urunGuncelleFiyat
            // 
            this.urunGuncelleFiyat.Enabled = false;
            this.urunGuncelleFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunGuncelleFiyat.Location = new System.Drawing.Point(91, 146);
            this.urunGuncelleFiyat.Name = "urunGuncelleFiyat";
            this.urunGuncelleFiyat.Size = new System.Drawing.Size(185, 29);
            this.urunGuncelleFiyat.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Adı :";
            // 
            // urunGuncelleAd
            // 
            this.urunGuncelleAd.Enabled = false;
            this.urunGuncelleAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunGuncelleAd.Location = new System.Drawing.Point(90, 90);
            this.urunGuncelleAd.Name = "urunGuncelleAd";
            this.urunGuncelleAd.Size = new System.Drawing.Size(185, 29);
            this.urunGuncelleAd.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kodu :";
            // 
            // urunGuncelleKod
            // 
            this.urunGuncelleKod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunGuncelleKod.Location = new System.Drawing.Point(88, 28);
            this.urunGuncelleKod.Name = "urunGuncelleKod";
            this.urunGuncelleKod.Size = new System.Drawing.Size(134, 29);
            this.urunGuncelleKod.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunSilmeBul);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.urunSilmeFiyat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.urunSilmeAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.urunSilmeKod);
            this.groupBox1.Location = new System.Drawing.Point(322, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 198);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // urunSilmeBul
            // 
            this.urunSilmeBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urunSilmeBul.Location = new System.Drawing.Point(239, 34);
            this.urunSilmeBul.Name = "urunSilmeBul";
            this.urunSilmeBul.Size = new System.Drawing.Size(47, 28);
            this.urunSilmeBul.TabIndex = 22;
            this.urunSilmeBul.Text = "Bul";
            this.urunSilmeBul.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fiyatı :";
            // 
            // urunSilmeFiyat
            // 
            this.urunSilmeFiyat.Enabled = false;
            this.urunSilmeFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunSilmeFiyat.Location = new System.Drawing.Point(101, 145);
            this.urunSilmeFiyat.Name = "urunSilmeFiyat";
            this.urunSilmeFiyat.Size = new System.Drawing.Size(185, 29);
            this.urunSilmeFiyat.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Adı :";
            // 
            // urunSilmeAd
            // 
            this.urunSilmeAd.Enabled = false;
            this.urunSilmeAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunSilmeAd.Location = new System.Drawing.Point(101, 89);
            this.urunSilmeAd.Name = "urunSilmeAd";
            this.urunSilmeAd.Size = new System.Drawing.Size(185, 29);
            this.urunSilmeAd.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kodu :";
            // 
            // urunSilmeKod
            // 
            this.urunSilmeKod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunSilmeKod.Location = new System.Drawing.Point(99, 34);
            this.urunSilmeKod.Name = "urunSilmeKod";
            this.urunSilmeKod.Size = new System.Drawing.Size(134, 29);
            this.urunSilmeKod.TabIndex = 16;
            // 
            // UrunEkleme
            // 
            this.UrunEkleme.Controls.Add(this.label4);
            this.UrunEkleme.Controls.Add(this.urunEkleFiyat);
            this.UrunEkleme.Controls.Add(this.label3);
            this.UrunEkleme.Controls.Add(this.urunEkleAd);
            this.UrunEkleme.Controls.Add(this.label2);
            this.UrunEkleme.Controls.Add(this.urunEkleKod);
            this.UrunEkleme.Location = new System.Drawing.Point(32, 67);
            this.UrunEkleme.Name = "UrunEkleme";
            this.UrunEkleme.Size = new System.Drawing.Size(269, 198);
            this.UrunEkleme.TabIndex = 41;
            this.UrunEkleme.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fiyatı :";
            // 
            // urunEkleFiyat
            // 
            this.urunEkleFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunEkleFiyat.Location = new System.Drawing.Point(106, 140);
            this.urunEkleFiyat.Name = "urunEkleFiyat";
            this.urunEkleFiyat.Size = new System.Drawing.Size(140, 29);
            this.urunEkleFiyat.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adı :";
            // 
            // urunEkleAd
            // 
            this.urunEkleAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunEkleAd.Location = new System.Drawing.Point(106, 84);
            this.urunEkleAd.Name = "urunEkleAd";
            this.urunEkleAd.Size = new System.Drawing.Size(140, 29);
            this.urunEkleAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kodu :";
            // 
            // urunEkleKod
            // 
            this.urunEkleKod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunEkleKod.Location = new System.Drawing.Point(104, 29);
            this.urunEkleKod.Name = "urunEkleKod";
            this.urunEkleKod.Size = new System.Drawing.Size(142, 29);
            this.urunEkleKod.TabIndex = 7;
            // 
            // hataMesaj
            // 
            this.hataMesaj.AutoSize = true;
            this.hataMesaj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hataMesaj.ForeColor = System.Drawing.Color.Red;
            this.hataMesaj.Location = new System.Drawing.Point(43, 336);
            this.hataMesaj.Name = "hataMesaj";
            this.hataMesaj.Size = new System.Drawing.Size(248, 40);
            this.hataMesaj.TabIndex = 40;
            this.hataMesaj.Text = "Aynı koda sahip bir ürün mevcut...\r\n Lütfen başka bir kod giriniz\"";
            this.hataMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hataMesaj.Visible = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Enabled = false;
            this.btnGüncelle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGüncelle.Location = new System.Drawing.Point(736, 285);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(120, 42);
            this.btnGüncelle.TabIndex = 39;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(660, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 32);
            this.label12.TabIndex = 38;
            this.label12.Text = "ÜRÜN FİYAT GÜNCELLEME\r\n";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(409, 285);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 42);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(391, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "ÜRÜN SİLME";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(90, 285);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 42);
            this.btnEkle.TabIndex = 35;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "ÜRÜN EKLEME";
            // 
            // Stack
            // 
            this.Stack.Controls.Add(this.dataGridViewStack);
            this.Stack.Controls.Add(this.label13);
            this.Stack.Controls.Add(this.btnCıkarStack);
            this.Stack.Controls.Add(this.btnEkleStack);
            this.Stack.Controls.Add(this.stackYeniEkle);
            this.Stack.Location = new System.Drawing.Point(4, 24);
            this.Stack.Name = "Stack";
            this.Stack.Padding = new System.Windows.Forms.Padding(3);
            this.Stack.Size = new System.Drawing.Size(1018, 678);
            this.Stack.TabIndex = 1;
            this.Stack.Text = "Stack (Yığın)";
            this.Stack.UseVisualStyleBackColor = true;
            this.Stack.Click += new System.EventHandler(this.Stack_Click);
            // 
            // dataGridViewStack
            // 
            this.dataGridViewStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dataGridViewStack.Location = new System.Drawing.Point(430, 140);
            this.dataGridViewStack.Name = "dataGridViewStack";
            this.dataGridViewStack.RowTemplate.Height = 25;
            this.dataGridViewStack.Size = new System.Drawing.Size(141, 250);
            this.dataGridViewStack.TabIndex = 5;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Numara";
            this.Column4.Name = "Column4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(371, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 54);
            this.label13.TabIndex = 4;
            this.label13.Text = "Stack (Yığın)";
            // 
            // btnCıkarStack
            // 
            this.btnCıkarStack.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCıkarStack.Location = new System.Drawing.Point(579, 144);
            this.btnCıkarStack.Name = "btnCıkarStack";
            this.btnCıkarStack.Size = new System.Drawing.Size(74, 36);
            this.btnCıkarStack.TabIndex = 3;
            this.btnCıkarStack.Text = "Çıkar";
            this.btnCıkarStack.UseVisualStyleBackColor = true;
            this.btnCıkarStack.Click += new System.EventHandler(this.btnCıkarStack_Click);
            // 
            // btnEkleStack
            // 
            this.btnEkleStack.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkleStack.Location = new System.Drawing.Point(350, 144);
            this.btnEkleStack.Name = "btnEkleStack";
            this.btnEkleStack.Size = new System.Drawing.Size(74, 36);
            this.btnEkleStack.TabIndex = 2;
            this.btnEkleStack.Text = "Ekle";
            this.btnEkleStack.UseVisualStyleBackColor = true;
            this.btnEkleStack.Click += new System.EventHandler(this.btnEkleStack_Click);
            // 
            // stackYeniEkle
            // 
            this.stackYeniEkle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stackYeniEkle.Location = new System.Drawing.Point(241, 140);
            this.stackYeniEkle.Name = "stackYeniEkle";
            this.stackYeniEkle.Size = new System.Drawing.Size(94, 39);
            this.stackYeniEkle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 703);
            this.Controls.Add(this.TabLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabLayout.ResumeLayout(false);
            this.DoublyLinkedList.ResumeLayout(false);
            this.DoublyLinkedList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UrunEkleme.ResumeLayout(false);
            this.UrunEkleme.PerformLayout();
            this.Stack.ResumeLayout(false);
            this.Stack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyat;
        private System.Windows.Forms.TabControl TabLayout;
        private System.Windows.Forms.TabPage DoublyLinkedList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label urunGuncellemeHata;
        private System.Windows.Forms.Label hataMesajSilme;
        private System.Windows.Forms.Button btnUrunleriListele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button urunGuncellemeBul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox urunGuncelleFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox urunGuncelleAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urunGuncelleKod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button urunSilmeBul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urunSilmeFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urunSilmeAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urunSilmeKod;
        private System.Windows.Forms.GroupBox UrunEkleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunEkleFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urunEkleAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunEkleKod;
        private System.Windows.Forms.Label hataMesaj;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Stack;
        private System.Windows.Forms.TextBox stackYeniEkle;
        private System.Windows.Forms.Button btnCıkarStack;
        private System.Windows.Forms.Button btnEkleStack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewStack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

