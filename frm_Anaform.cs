using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SQL_Yardimcisi
{
    public partial class frm_Anaform : Form
    {
        private const string PROGRAM_ADI = "SQL Yardımcısı";

        public frm_Anaform()
        {
            InitializeComponent();
            try
            {
                rtb_Kod.Settings.Keywords.AddRange(_kelimeler.KelimeListesi());
                rtb_Kod.Settings.Comment = "//";
                rtb_Kod.Settings.KeywordColor = Color.Blue;
                rtb_Kod.Settings.CommentColor = Color.Green;
                rtb_Kod.Settings.StringColor = Color.DarkRed;
                rtb_Kod.Settings.IntegerColor = Color.DeepPink;
                rtb_Kod.Settings.EnableStrings = true;
                rtb_Kod.Settings.EnableIntegers = true;
                rtb_Kod.CompileKeywords();
                Listele();
            }
            catch (Exception hata)
            {
                // Bu hata ile ne yapmamızı istersin Mr. UZUN?
                // Yazıralım mı hata var diye?
                // MessageBox.Show("Şu hata meydana geldi : \n"+hata,"Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log mu tutalım yada kendi sunucumuza hata var mesajımı yollayalım?
            }
            
        }
        Kelimeler _kelimeler = new Kelimeler();
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        string baglanti = ConfigurationManager.ConnectionStrings["Baglanti"].ToString();
        string query, filename = string.Empty;

        #region Metotlar
        public void Listele()
        {
            conn = new OleDbConnection(baglanti);
            try
            {
                if (rb_veriTabani.Checked)
                {
                    query = "SELECT * FROM tbl_VTSql";
                }
                else
                {
                    query = "SELECT * FROM tbl_TabloSql";
                }
                cmd = new OleDbCommand(query, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                cmb_islem.Items.Clear();
                cmb_islem.Text = string.Empty;
                while (dr.Read())
                {
                    cmb_islem.Items.Add(dr["sqlAciklama"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        #endregion

        #region Kontroller

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            tsm_Ekle_Click(sender, e);
        }

        private void btn_kopyala_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtb_Kod.Text))
            {
                Clipboard.SetText(rtb_Kod.Text);
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtb_Kod.Text))
                if (MessageBox.Show("Bu kodları silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_Kod.Clear();
                }
        }

        private void Listele_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void cmb_islem_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection(baglanti);
            try
            {
                if (rb_veriTabani.Checked)
                {
                    query = "SELECT * FROM tbl_VTSql where sqlAciklama='" + cmb_islem.Text + "'";
                }
                else
                {
                    query = "SELECT * FROM tbl_TabloSql where sqlAciklama='" + cmb_islem.Text + "'";
                }
                cmd = new OleDbCommand(query, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtb_Kod.AppendText(dr["sqlKodu"].ToString() + "\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        #endregion

        #region Menu

        private void tsm_Yeni_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            catch
            {

            }
        }

        private void tsm_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsm_Kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                if (sfd_kaydet.FilterIndex == 1) //Text dosyası
                    rtb_Kod.SaveFile(sfd_kaydet.FileName, RichTextBoxStreamType.PlainText);
                else
                    rtb_Kod.SaveFile(sfd_kaydet.FileName, RichTextBoxStreamType.RichText);
                this.Text = PROGRAM_ADI + " - " + filename.ToString();
            }
            else
            {
                sfd_kaydet.Filter = "TXT dosyası|*.txt|RTF dosyası|*.rtf|SQL dosyası|*.sql";
                sfd_kaydet.Title = "SQL sorgunuzu kaydedin";
                if (sfd_kaydet.ShowDialog() == DialogResult.OK)
                {
                    if (sfd_kaydet.FilterIndex == 1) //Text dosyası
                        rtb_Kod.SaveFile(sfd_kaydet.FileName, RichTextBoxStreamType.PlainText);
                    else
                        rtb_Kod.SaveFile(sfd_kaydet.FileName, RichTextBoxStreamType.RichText);
                    filename = sfd_kaydet.FileName;
                }
                this.Text = PROGRAM_ADI + " - " + filename.ToString();
            }
        }

        private void tsm_Ekle_Click(object sender, EventArgs e)
        {
            string ilkmetin = rtb_Kod.Text;

            if (ofd_ac.ShowDialog() == DialogResult.OK)
            {
                rtb_Kod.LoadFile(ofd_ac.FileName);
                filename = ofd_ac.FileName;
                rtb_Kod.Text += ilkmetin;
            }

        }

        private void tsm_Ara_Click(object sender, EventArgs e)
        {
            frm_Bul.rtb = this.rtb_Kod;
            frm_Bul frmBul = new frm_Bul();
            frmBul.Show();

        }

        private void tsm_Yardim_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.nullovy.com/sqlyardim.php");
            }
            catch
            {
                MessageBox.Show("Yardıma ulaşılamıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsm_Hakkinda_Click(object sender, EventArgs e)
        {
            frm_Hakkinda frmHakkinda = new frm_Hakkinda();
            frmHakkinda.ShowDialog();
        }

        private void tsm_Degistir_Click(object sender, EventArgs e)
        {
            frm_Degistir.rtb = this.rtb_Kod;
            frm_Degistir frmDegistir = new frm_Degistir();
            frmDegistir.Show();
        }

        private void tsm_Ac_Click(object sender, EventArgs e)
        {
            if (ofd_ac.ShowDialog() == DialogResult.OK)
            {
                rtb_Kod.LoadFile(ofd_ac.FileName);
                filename = ofd_ac.FileName;
                this.Text += filename;
            }
        }

        private void tsm_Kes_Click(object sender, EventArgs e)
        {
            rtb_Kod.Cut();
        }

        private void tsm_Kopyala_Click(object sender, EventArgs e)
        {
            rtb_Kod.Copy();
        }

        private void tsm_Yapistir_Click(object sender, EventArgs e)
        {
            rtb_Kod.Paste();
        }

        private void tsm_TumunuSec_Click(object sender, EventArgs e)
        {
            rtb_Kod.SelectAll();
        }

        private void tsm_GeriAl_Click(object sender, EventArgs e)
        {
            rtb_Kod.Undo();
        }

        #endregion

        private void btn_Araclar_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject((sender as Button).Name);
        }

        private void btn_Araclar_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject((sender as Button).Name + "Hover");
        }

        private void cmb_islem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_islem.DroppedDown = true;
            }
            else if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(cmb_islem.Text))
            {
                cmb_islem.DroppedDown = false;
            }
        }
    }
}
