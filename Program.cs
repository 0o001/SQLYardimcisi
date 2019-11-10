using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SQL_Yardimcisi
{
    static class Program
    {
        private const double PROGRAM_VERSIYON = 1.0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!Internet.BaglantiKontrol())
            {
                SqlYardimcisiAc();
            }
            else
            {
                bool kontrol = false;
                try
                {
                    kontrol = Internet.VersiyonKontrol(PROGRAM_VERSIYON.ToString(), new Uri("http://nullovy.com/sqlyardimcisi/sqlYardimcisiVersiyon.php"));
                }
                catch
                {
                }

                if (kontrol)
                {
                    try
                    {
                        ProcessStartInfo acUpdate = new ProcessStartInfo("null_update.exe");
                        acUpdate.UseShellExecute = true;
                        acUpdate.Verb = "RunAs";
                        Process.Start(acUpdate);
                    }
                    catch
                    {
                        MessageBox.Show("SQL Yardımcısı güncelleme dosyası açılamıyor...\nLütfen SQL Yardımcısı programını yeniden yükleyiniz.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlYardimcisiAc();
                    }
                }
                else
                {
                    SqlYardimcisiAc();
                }
            }
        }

        private static void SqlYardimcisiAc()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Anaform());
        }
    }
}
