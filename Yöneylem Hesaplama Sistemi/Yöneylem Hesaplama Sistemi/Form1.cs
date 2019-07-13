using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Yöneylem_Hesaplama_Sistemi
{
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }

        //Form Hareketi Sağlamak için kullanılan komutlar
        bool surukle = false;
        Point baslangıc_konum = new Point(0, 0);
        //-----------------------------------------
     
        //formun ekran bazında ortalanması için kullanılır
        public void formortala()
        {
            try
            {
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------

        //formu kapatmak için oluşturulmuş button1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();      
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------

        //formu altaalmak için oluşturulmuş button2
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------

        //panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                surukle = true;
                baslangıc_konum = new Point(e.X, e.Y);
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (surukle)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - baslangıc_konum.X, p.Y - baslangıc_konum.Y);
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                surukle = false;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //panel2 uzerinde mouse ile tutup formu surukleme eventleri
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (surukle)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - baslangıc_konum.X, p.Y - baslangıc_konum.Y);
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                surukle = true;
                baslangıc_konum = new Point(e.X, e.Y);
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }   
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                surukle = false;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //ulaştırma modeli buttonuna hareketli efekt vermek için kullanılır button3
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.ulastırmahareketli;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ulastırmahareketsiz;
        }
        //--------------------------------------------------------------

        //ulaştırma modeli seçenek formuna gitmek için kullanılır button3
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ulaştırma_Modelleri ul = new Ulaştırma_Modelleri();
                ul.Show();

            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //hakkında formuna gitmek için kullanılır
        private void panel33_Click(object sender, EventArgs e)
        {
            try
            {
                Hakkinda hk = new Hakkinda();
                hk.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            formortala();
            button3.Image = Properties.Resources.ulastırmahareketsiz;          
        }

        //Program Kullanımı ile ilgili word dosyasını açar
        private void panel5_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Kullanımı.docx");
        }
        //--------------------------------------------------------------

        //kara modeli seçenek formuna gitmek için kullanılır button4
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

    }
}
