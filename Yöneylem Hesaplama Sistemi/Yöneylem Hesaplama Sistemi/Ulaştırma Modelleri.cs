using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yöneylem_Hesaplama_Sistemi
{
    public partial class Ulaştırma_Modelleri : Form
    {
        //seçilen karar modeli ve satır-sütun sayısını diğer forma göndermek için kullanılır
        public static string sayı;
        //-----------------------------------------

        public Ulaştırma_Modelleri()
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
        //------------------------------------------------

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
        //------------------------------------------------

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
        //------------------------------------------------
      
        //panel1 uzerinde mouse ile tutup formu surukleme eventleri
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
        //--------------------------------------------------------------

        //panel4 uzerinde mouse ile tutup formu surukleme eventleri
        private void panel4_MouseMove(object sender, MouseEventArgs e)
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
        private void panel4_MouseUp(object sender, MouseEventArgs e)
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
        private void panel4_MouseDown(object sender, MouseEventArgs e)
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
        //--------------------------------------------------------------

        //ayarlar buttonuna hareketli efekt vermek için kullanılır button3
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.ayarlarhareketli;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ayarlarhareketsiz;
        }
        //--------------------------------------------------------------

        //ayarlar formuna gitmek için kullanılır button3
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {              
                this.Close();
                Ulastirmamodelleriayarlari ayar = new Ulastirmamodelleriayarlari();
                ayar.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //ulaştırma modeli ve satır-sütun sayısı seçimi combobox2
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Kuzey-Batı Köşe Yöntemi")
                {
                    if(comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:2")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:4")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:5")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:6")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:7")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        KuzeyBatiYontemi kz = new KuzeyBatiYontemi();
                        kz.Show();
                    }        
                }
                if (comboBox1.SelectedItem.ToString() == "En Düşük Maliyet Yöntemi")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:2")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:4")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:5")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:6")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:7")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        EnDusukMaliyetYontemi en = new EnDusukMaliyetYontemi();
                        en.Show();
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Sıra / Sütun En Küçüğü Yöntemi")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:2")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:4")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:5")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:6")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:7")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        SiraVeSutunEnKucugu s = new SiraVeSutunEnKucugu();
                        s.Show();
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "Vogel Yaklaşımı (VAM) Yöntemi")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:2")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:4")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:5")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:6")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:7")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        VogelYaklasimYontemi v = new VogelYaklasimYontemi();
                        v.Show();
                    }
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //fordan bir önceki forma geçmek için oluşturulmuş panel21
        private void panel21_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Arayüz ar = new Arayüz();
                ar.Show();
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

        private void Ulaştırma_Modelleri_Load(object sender, EventArgs e)
        {
            formortala();
            button3.Image = Properties.Resources.ayarlarhareketsiz;
        }
       
    }
}
