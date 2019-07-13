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
    public partial class Karar_Modelleri : Form
    {
        public Karar_Modelleri()
        {
            InitializeComponent();
        }

        //seçilen ulaştırma modeli ve satır-sütun sayısını diğer forma göndermek için kullanılır
        public static string sayı;
        //-----------------------------------------

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
        //------------------------------------------------

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

        private void Karar_Modelleri_Load(object sender, EventArgs e)
        {
            formortala();
            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedItem.ToString() == "Belirlilik Altında Karar Verme" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeFayda b = new BelirlilikAltındaKararVermeFayda();
                        b.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirlilik Altında Karar Verme" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:1")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirlilikAltındaKararVermeMaliyet m = new BelirlilikAltındaKararVermeMaliyet();
                        m.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Risk Altında Karar Verme" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeFayda f = new RiskAltındaKararVermeFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Risk Altında Karar Verme" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        RiskAltındaKararVermeMaliyet f = new RiskAltındaKararVermeMaliyet();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Eş Olasılık" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkFayda f = new BelirsizlikAltındaEsolasılıkFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Eş Olasılık" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaEsolasılıkMaliyet f = new BelirsizlikAltındaEsolasılıkMaliyet();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "İyimserlik" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikFayda f = new BelirsizlikAltındaiyimserlikFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "İyimserlik" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaiyimserlikMaliyet f = new BelirsizlikAltındaiyimserlikMaliyet();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Kötümserlik" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikFayda f = new BelirsizlikAltındakotumserlikFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Kötümserlik" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındakotumserlikMaliyet f = new BelirsizlikAltındakotumserlikMaliyet();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Pişmanlık" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikMaliyet f = new BelirsizlikAltındaPismanlikMaliyet();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Pişmanlık" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaPismanlikFayda f = new BelirsizlikAltındaPismanlikFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Hurwicz" && comboBox4.SelectedItem.ToString() == "Fayda")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczFayda f = new BelirsizlikAltındaHurwiczFayda();
                        f.Show();
                    }
                }
                if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme" && comboBox1.SelectedItem.ToString() == "Hurwicz" && comboBox4.SelectedItem.ToString() == "Maliyet")
                {
                    if (comboBox2.SelectedItem.ToString() == "Satır:2-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:3-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:4-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:5-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:6-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                    if (comboBox2.SelectedItem.ToString() == "Satır:7-Sütun:3")
                    {
                        sayı = comboBox2.SelectedItem.ToString();
                        this.Close();
                        BelirsizlikAltındaHurwiczMaliyet f = new BelirsizlikAltındaHurwiczMaliyet();
                        f.Show();
                    }
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedItem.ToString() == "Belirlilik Altında Karar Verme")
                {
                    comboBox1.Enabled = false;
                    comboBox1.SelectedText = "";
                    comboBox2.Items.Clear();
                    for (int i=2;i<=7;i++)
                    {
                        comboBox2.Items.Add("Satır:"+i+"-Sütun:1");
                    }                                   
                }
                else if (comboBox3.SelectedItem.ToString() == "Risk Altında Karar Verme")
                {
                    comboBox1.Enabled = false;
                    comboBox1.SelectedText = "";
                    comboBox2.Items.Clear();
                    for (int i = 2; i <= 7; i++)
                    {
                        comboBox2.Items.Add("Satır:" + i + "-Sütun:3");
                    }
                }
                else if (comboBox3.SelectedItem.ToString() == "Belirsizlik Altında Karar Verme")
                {
                    comboBox1.Enabled = true;
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Eş Olasılık");
                    comboBox1.Items.Add("İyimserlik");
                    comboBox1.Items.Add("Kötümserlik");
                    comboBox1.Items.Add("Pişmanlık");
                    comboBox1.Items.Add("Hurwicz");              
                    comboBox2.Items.Clear();                 
                }
                else
                {
                    comboBox1.Enabled = true;
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Eş Olasılık")
            {
                comboBox2.Items.Clear();
                for (int i = 2; i <= 7; i++)
                {
                    comboBox2.Items.Add("Satır:" + i + "-Sütun:3");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "İyimserlik")
            {
                comboBox2.Items.Clear();
                for (int i = 2; i <= 7; i++)
                {                   
                    comboBox2.Items.Add("Satır:" + i + "-Sütun:3");                
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Kötümserlik")
            {
                comboBox2.Items.Clear();
                for (int i = 2; i <= 7; i++)
                {
                    comboBox2.Items.Add("Satır:" + i + "-Sütun:3");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Pişmanlık")
            {
                comboBox2.Items.Clear();
                for (int i = 2; i <= 7; i++)
                {
                    comboBox2.Items.Add("Satır:" + i + "-Sütun:3");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Hurwicz")
            {
                comboBox2.Items.Clear();
                for (int i = 2; i <= 7; i++)
                {
                    comboBox2.Items.Add("Satır:" + i + "-Sütun:3");
                }
            }
        }
    }
}
