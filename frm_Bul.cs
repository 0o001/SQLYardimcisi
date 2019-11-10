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
    public partial class frm_Bul : Form
    {
        public frm_Bul()
        {
            InitializeComponent();
        }
        public static SyntaxRichTextBox rtb;
        private void btn_Ara_Click(object sender, EventArgs e)
        {
            lbl_Sonuc.Text = "Toplam " + rtb.Bul(txt_Ara.Text, Color.Yellow) + " adet kayıt bulundu.";
        }
        private void Kapat()
        {
            rtb.SelectAll();
            rtb.SelectionBackColor = Color.White;
            rtb.Select(0, 0);
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            Kapat(); this.Close();
        }

        private void frm_Bul_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kapat();
           
        }
    }
}
