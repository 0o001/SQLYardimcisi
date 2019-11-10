namespace SQL_Yardimcisi
{
    partial class frm_Anaform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anaform));
            this.cmb_islem = new System.Windows.Forms.ComboBox();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsm_Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Duzen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Kes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Kopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Yapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Ara = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Degistir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_TumunuSec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_GeriAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_YardimH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_ac = new System.Windows.Forms.OpenFileDialog();
            this.sfd_kaydet = new System.Windows.Forms.SaveFileDialog();
            this.tip_bilgi = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Kopyala = new System.Windows.Forms.Button();
            this.lbl_cizgi = new System.Windows.Forms.Label();
            this.cms_sag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Kod = new SQL_Yardimcisi.SyntaxRichTextBox();
            this.rb_tablo = new KareRadioButton();
            this.rb_veriTabani = new KareRadioButton();
            this.ms_menu.SuspendLayout();
            this.cms_sag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_islem
            // 
            this.cmb_islem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_islem.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_islem.FormattingEnabled = true;
            this.cmb_islem.Items.AddRange(new object[] {
            "İşlem Türünü Seçiniz:"});
            this.cmb_islem.Location = new System.Drawing.Point(12, 42);
            this.cmb_islem.Name = "cmb_islem";
            this.cmb_islem.Size = new System.Drawing.Size(277, 26);
            this.cmb_islem.Sorted = true;
            this.cmb_islem.TabIndex = 0;
            this.tip_bilgi.SetToolTip(this.cmb_islem, "SQL Kodunu Seçiniz ");
            this.cmb_islem.SelectedIndexChanged += new System.EventHandler(this.cmb_islem_SelectedIndexChanged);
            this.cmb_islem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_islem_KeyUp);
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Dosya,
            this.tsm_Duzen,
            this.tsm_YardimH});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(589, 24);
            this.ms_menu.TabIndex = 6;
            this.ms_menu.Text = "menuStrip1";
            // 
            // tsm_Dosya
            // 
            this.tsm_Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Yeni,
            this.tsm_Ac,
            this.tsm_Kaydet,
            this.tsm_FarkliKaydet,
            this.toolStripSeparator3,
            this.tsm_Cikis});
            this.tsm_Dosya.Name = "tsm_Dosya";
            this.tsm_Dosya.Size = new System.Drawing.Size(51, 20);
            this.tsm_Dosya.Text = "&Dosya";
            // 
            // tsm_Yeni
            // 
            this.tsm_Yeni.Image = global::SQL_Yardimcisi.Properties.Resources.yeni;
            this.tsm_Yeni.Name = "tsm_Yeni";
            this.tsm_Yeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsm_Yeni.Size = new System.Drawing.Size(213, 22);
            this.tsm_Yeni.Text = "Yeni";
            this.tsm_Yeni.Click += new System.EventHandler(this.tsm_Yeni_Click);
            // 
            // tsm_Ac
            // 
            this.tsm_Ac.Image = global::SQL_Yardimcisi.Properties.Resources.ac;
            this.tsm_Ac.Name = "tsm_Ac";
            this.tsm_Ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsm_Ac.Size = new System.Drawing.Size(213, 22);
            this.tsm_Ac.Text = "Aç";
            this.tsm_Ac.Click += new System.EventHandler(this.tsm_Ac_Click);
            // 
            // tsm_Kaydet
            // 
            this.tsm_Kaydet.Image = global::SQL_Yardimcisi.Properties.Resources.kaydet;
            this.tsm_Kaydet.Name = "tsm_Kaydet";
            this.tsm_Kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsm_Kaydet.Size = new System.Drawing.Size(213, 22);
            this.tsm_Kaydet.Text = "Kaydet";
            this.tsm_Kaydet.Click += new System.EventHandler(this.tsm_Kaydet_Click);
            // 
            // tsm_FarkliKaydet
            // 
            this.tsm_FarkliKaydet.Name = "tsm_FarkliKaydet";
            this.tsm_FarkliKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsm_FarkliKaydet.Size = new System.Drawing.Size(213, 22);
            this.tsm_FarkliKaydet.Text = "Farklı Kaydet";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // tsm_Cikis
            // 
            this.tsm_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Cikis.Image")));
            this.tsm_Cikis.Name = "tsm_Cikis";
            this.tsm_Cikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsm_Cikis.Size = new System.Drawing.Size(213, 22);
            this.tsm_Cikis.Text = "Çıkış";
            this.tsm_Cikis.Click += new System.EventHandler(this.tsm_Cikis_Click);
            // 
            // tsm_Duzen
            // 
            this.tsm_Duzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Ekle,
            this.toolStripSeparator2,
            this.tsm_Kes,
            this.tsm_Kopyala,
            this.tsm_Yapistir,
            this.toolStripSeparator5,
            this.tsm_Ara,
            this.tsm_Degistir,
            this.toolStripSeparator4,
            this.tsm_TumunuSec,
            this.tsm_GeriAl});
            this.tsm_Duzen.Name = "tsm_Duzen";
            this.tsm_Duzen.Size = new System.Drawing.Size(52, 20);
            this.tsm_Duzen.Text = "Dü&zen";
            // 
            // tsm_Ekle
            // 
            this.tsm_Ekle.Image = global::SQL_Yardimcisi.Properties.Resources.ekle;
            this.tsm_Ekle.Name = "tsm_Ekle";
            this.tsm_Ekle.Size = new System.Drawing.Size(183, 22);
            this.tsm_Ekle.Text = "Ekle";
            this.tsm_Ekle.Click += new System.EventHandler(this.tsm_Ekle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // tsm_Kes
            // 
            this.tsm_Kes.Name = "tsm_Kes";
            this.tsm_Kes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsm_Kes.Size = new System.Drawing.Size(183, 22);
            this.tsm_Kes.Text = "Kes";
            this.tsm_Kes.Click += new System.EventHandler(this.tsm_Kes_Click);
            // 
            // tsm_Kopyala
            // 
            this.tsm_Kopyala.Image = global::SQL_Yardimcisi.Properties.Resources.kopyala;
            this.tsm_Kopyala.Name = "tsm_Kopyala";
            this.tsm_Kopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsm_Kopyala.Size = new System.Drawing.Size(183, 22);
            this.tsm_Kopyala.Text = "Kopyala";
            this.tsm_Kopyala.Click += new System.EventHandler(this.tsm_Kopyala_Click);
            // 
            // tsm_Yapistir
            // 
            this.tsm_Yapistir.Name = "tsm_Yapistir";
            this.tsm_Yapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsm_Yapistir.Size = new System.Drawing.Size(183, 22);
            this.tsm_Yapistir.Text = "Yapiştır";
            this.tsm_Yapistir.Click += new System.EventHandler(this.tsm_Yapistir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            // 
            // tsm_Ara
            // 
            this.tsm_Ara.Image = global::SQL_Yardimcisi.Properties.Resources.ara;
            this.tsm_Ara.Name = "tsm_Ara";
            this.tsm_Ara.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsm_Ara.Size = new System.Drawing.Size(183, 22);
            this.tsm_Ara.Text = "Bul...";
            this.tsm_Ara.Click += new System.EventHandler(this.tsm_Ara_Click);
            // 
            // tsm_Degistir
            // 
            this.tsm_Degistir.Name = "tsm_Degistir";
            this.tsm_Degistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsm_Degistir.Size = new System.Drawing.Size(183, 22);
            this.tsm_Degistir.Text = "Değiştir...";
            this.tsm_Degistir.Click += new System.EventHandler(this.tsm_Degistir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // tsm_TumunuSec
            // 
            this.tsm_TumunuSec.Name = "tsm_TumunuSec";
            this.tsm_TumunuSec.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsm_TumunuSec.Size = new System.Drawing.Size(183, 22);
            this.tsm_TumunuSec.Text = "Tümünü Seç";
            this.tsm_TumunuSec.Click += new System.EventHandler(this.tsm_TumunuSec_Click);
            // 
            // tsm_GeriAl
            // 
            this.tsm_GeriAl.Name = "tsm_GeriAl";
            this.tsm_GeriAl.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsm_GeriAl.Size = new System.Drawing.Size(183, 22);
            this.tsm_GeriAl.Text = "Geri Al";
            this.tsm_GeriAl.Click += new System.EventHandler(this.tsm_GeriAl_Click);
            // 
            // tsm_YardimH
            // 
            this.tsm_YardimH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Yardim,
            this.toolStripSeparator1,
            this.tsm_Hakkinda});
            this.tsm_YardimH.Name = "tsm_YardimH";
            this.tsm_YardimH.Size = new System.Drawing.Size(56, 20);
            this.tsm_YardimH.Text = "&Yardım";
            // 
            // tsm_Yardim
            // 
            this.tsm_Yardim.Image = global::SQL_Yardimcisi.Properties.Resources.yardim;
            this.tsm_Yardim.Name = "tsm_Yardim";
            this.tsm_Yardim.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsm_Yardim.Size = new System.Drawing.Size(143, 22);
            this.tsm_Yardim.Text = "Yardım";
            this.tsm_Yardim.Click += new System.EventHandler(this.tsm_Yardim_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // tsm_Hakkinda
            // 
            this.tsm_Hakkinda.Image = global::SQL_Yardimcisi.Properties.Resources.hakkinda;
            this.tsm_Hakkinda.Name = "tsm_Hakkinda";
            this.tsm_Hakkinda.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsm_Hakkinda.Size = new System.Drawing.Size(143, 22);
            this.tsm_Hakkinda.Text = "Hakkında";
            this.tsm_Hakkinda.Click += new System.EventHandler(this.tsm_Hakkinda_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.BackgroundImage")));
            this.btn_Temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Temizle.FlatAppearance.BorderSize = 0;
            this.btn_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Temizle.Location = new System.Drawing.Point(539, 36);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(38, 38);
            this.btn_Temizle.TabIndex = 9;
            this.tip_bilgi.SetToolTip(this.btn_Temizle, "Tümünü Sil");
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            this.btn_Temizle.MouseEnter += new System.EventHandler(this.btn_Araclar_MouseEnter);
            this.btn_Temizle.MouseLeave += new System.EventHandler(this.btn_Araclar_MouseLeave);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ekle.BackgroundImage = global::SQL_Yardimcisi.Properties.Resources.btn_Ekle;
            this.btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Ekle.Location = new System.Drawing.Point(404, 36);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(38, 38);
            this.btn_Ekle.TabIndex = 7;
            this.tip_bilgi.SetToolTip(this.btn_Ekle, "Üzerine Ekle");
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            this.btn_Ekle.MouseEnter += new System.EventHandler(this.btn_Araclar_MouseEnter);
            this.btn_Ekle.MouseLeave += new System.EventHandler(this.btn_Araclar_MouseLeave);
            // 
            // btn_Kopyala
            // 
            this.btn_Kopyala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kopyala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kopyala.BackgroundImage")));
            this.btn_Kopyala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Kopyala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kopyala.FlatAppearance.BorderSize = 0;
            this.btn_Kopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kopyala.Location = new System.Drawing.Point(457, 36);
            this.btn_Kopyala.Name = "btn_Kopyala";
            this.btn_Kopyala.Size = new System.Drawing.Size(38, 38);
            this.btn_Kopyala.TabIndex = 5;
            this.tip_bilgi.SetToolTip(this.btn_Kopyala, "Tümünü Kopyala");
            this.btn_Kopyala.UseVisualStyleBackColor = true;
            this.btn_Kopyala.Click += new System.EventHandler(this.btn_kopyala_Click);
            this.btn_Kopyala.MouseEnter += new System.EventHandler(this.btn_Araclar_MouseEnter);
            this.btn_Kopyala.MouseLeave += new System.EventHandler(this.btn_Araclar_MouseLeave);
            // 
            // lbl_cizgi
            // 
            this.lbl_cizgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cizgi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cizgi.Location = new System.Drawing.Point(-6, 84);
            this.lbl_cizgi.Name = "lbl_cizgi";
            this.lbl_cizgi.Size = new System.Drawing.Size(602, 1);
            this.lbl_cizgi.TabIndex = 11;
            // 
            // cms_sag
            // 
            this.cms_sag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cms_sag.Name = "cms_sag";
            this.cms_sag.Size = new System.Drawing.Size(117, 120);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.tsm_Ekle_Click);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            this.değiştirToolStripMenuItem.Click += new System.EventHandler(this.tsm_Degistir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.tsm_Kes_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.tsm_Kopyala_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.tsm_Yapistir_Click);
            // 
            // rtb_Kod
            // 
            this.rtb_Kod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Kod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Kod.ContextMenuStrip = this.cms_sag;
            this.rtb_Kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_Kod.ForeColor = System.Drawing.Color.Black;
            this.rtb_Kod.Location = new System.Drawing.Point(0, 86);
            this.rtb_Kod.Name = "rtb_Kod";
            this.rtb_Kod.Size = new System.Drawing.Size(589, 245);
            this.rtb_Kod.TabIndex = 10;
            this.rtb_Kod.Text = "";
            this.rtb_Kod.WordWrap = false;
            // 
            // rb_tablo
            // 
            this.rb_tablo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_tablo.AutoSize = true;
            this.rb_tablo.BackColor = System.Drawing.Color.Transparent;
            this.rb_tablo.disRenk = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rb_tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rb_tablo.icRenk = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rb_tablo.Location = new System.Drawing.Point(302, 54);
            this.rb_tablo.Name = "rb_tablo";
            this.rb_tablo.Size = new System.Drawing.Size(56, 19);
            this.rb_tablo.TabIndex = 4;
            this.rb_tablo.Text = "Tablo";
            this.rb_tablo.UseVisualStyleBackColor = false;
            this.rb_tablo.CheckedChanged += new System.EventHandler(this.Listele_CheckedChanged);
            // 
            // rb_veriTabani
            // 
            this.rb_veriTabani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_veriTabani.AutoSize = true;
            this.rb_veriTabani.BackColor = System.Drawing.Color.Transparent;
            this.rb_veriTabani.Checked = true;
            this.rb_veriTabani.disRenk = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rb_veriTabani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_veriTabani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rb_veriTabani.icRenk = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rb_veriTabani.Location = new System.Drawing.Point(302, 36);
            this.rb_veriTabani.Name = "rb_veriTabani";
            this.rb_veriTabani.Size = new System.Drawing.Size(87, 19);
            this.rb_veriTabani.TabIndex = 3;
            this.rb_veriTabani.TabStop = true;
            this.rb_veriTabani.Text = "Veri Tabanı";
            this.rb_veriTabani.UseVisualStyleBackColor = false;
            this.rb_veriTabani.CheckedChanged += new System.EventHandler(this.Listele_CheckedChanged);
            // 
            // frm_Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 331);
            this.Controls.Add(this.lbl_cizgi);
            this.Controls.Add(this.rtb_Kod);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Kopyala);
            this.Controls.Add(this.rb_tablo);
            this.Controls.Add(this.rb_veriTabani);
            this.Controls.Add(this.ms_menu);
            this.Controls.Add(this.cmb_islem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "frm_Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Yardımcısı";
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.cms_sag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_islem;
        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem tsm_Dosya;
        private System.Windows.Forms.ToolStripMenuItem tsm_Duzen;
        private System.Windows.Forms.ToolStripMenuItem tsm_Ac;
        private System.Windows.Forms.ToolStripMenuItem tsm_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem tsm_Kopyala;
        private System.Windows.Forms.ToolStripMenuItem tsm_Ara;
        private System.Windows.Forms.ToolStripMenuItem tsm_Ekle;
        private System.Windows.Forms.ToolStripMenuItem tsm_YardimH;
        private System.Windows.Forms.ToolStripMenuItem tsm_Yardim;
        private System.Windows.Forms.ToolStripMenuItem tsm_Hakkinda;
        private System.Windows.Forms.OpenFileDialog ofd_ac;
        private System.Windows.Forms.SaveFileDialog sfd_kaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip tip_bilgi;
        private System.Windows.Forms.ToolStripMenuItem tsm_FarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsm_Cikis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsm_Kes;
        private System.Windows.Forms.ToolStripMenuItem tsm_Yapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsm_TumunuSec;
        private System.Windows.Forms.ToolStripMenuItem tsm_GeriAl;
        private System.Windows.Forms.ToolStripMenuItem tsm_Yeni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsm_Degistir;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Kopyala;
        private System.Windows.Forms.Button btn_Temizle;
        private KareRadioButton rb_veriTabani;
        private KareRadioButton rb_tablo;
        private System.Windows.Forms.Label lbl_cizgi;
        private System.Windows.Forms.ContextMenuStrip cms_sag;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        public SyntaxRichTextBox rtb_Kod;
    }
}

