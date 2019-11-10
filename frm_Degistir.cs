using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Yardimcisi
{
    public partial class frm_Degistir : Form
    {
        public frm_Degistir()
        {
            InitializeComponent();
        }
        public static SyntaxRichTextBox rtb;
        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            rtb.Bul(txt_Aranan.Text, Color.White);
            this.Close();
        }

        private void btn_TumunuDegistir_Click(object sender, EventArgs e)
        {
            lbl_Sonuc.Text = "Toplam "+ rtb.Degistir(txt_Aranan.Text, txt_Degistirilecek.Text, Color.Yellow) + " adet kayıt değiştirildi.";
        }

        private void frm_Degistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            rtb.Degistir(txt_Degistirilecek.Text, txt_Degistirilecek.Text, Color.White);

        }
    }
}
