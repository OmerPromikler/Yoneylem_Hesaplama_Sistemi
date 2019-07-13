using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//veri tabanu kutuphanesi
using System.Data.OleDb;
//-----------------------------------------
namespace Yöneylem_Hesaplama_Sistemi
{
    public partial class Ulastirmamodelleriayarlari : Form
    {
        //Veri Tabanı Bağlantı Ve Komut İşlemleri
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + "\\verimerkezi.mdb");
        OleDbDataAdapter adp;
        DataTable tablo = new DataTable();
        OleDbCommand komut;
        //-----------------------------------------

        //Form Hareketi Sağlamak için kullanılan komutlar
        bool surukle = false;
        Point baslangıc_konum = new Point(0, 0);
        //-----------------------------------------

        public Ulastirmamodelleriayarlari()
        {
            InitializeComponent();
        }

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

        //veritabanına listelemek için kullanılır
        public void listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select *From ulastirmamodelleriayarlari", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            baglanti.Close();
        }
        //--------------------------------------------------------------

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
        //--------------------------------------------------------------

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
        //--------------------------------------------------------------

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
        //--------------------------------------------------------------

        //DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox19.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
        }
        //--------------------------------------------------------------

        //fordan bir önceki forma geçmek için oluşturulmuş panel6
        private void panel6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Ulaştırma_Modelleri ul = new Ulaştırma_Modelleri();
                ul.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //--------------------------------------------------------------

        //ulaştirma modelleri ayarları güncelleme yapmak için oluşturulmuş panel7
        private void panel7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox12.Text == "" || textBox11.Text == "" || textBox13.Text == "" || textBox19.Text == "" || textBox18.Text == "" || textBox17.Text == "" || textBox16.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız.");
                }
                else
                {
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE ulastirmamodelleriayarlari set Depo='" + textBox2.Text + "',Fabrika='" + textBox3.Text + "',Arz='" + textBox4.Text + "',Talep='" + textBox5.Text + "',D1='" + textBox7.Text + "',D2='" + textBox8.Text + "',D3='" + textBox9.Text + "',D4='" + textBox10.Text + "',D5='" + textBox12.Text + "',D6='" + textBox11.Text + "',D7='" + textBox13.Text + "',F1='" + textBox19.Text + "',F2='" + textBox18.Text + "',F3='" + textBox17.Text + "',F4='" + textBox16.Text + "',F5='" + textBox14.Text + "',F6='" + textBox15.Text + "',F7='" + textBox6.Text + "'  where Id=" + textBox1.Text + "", baglanti);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();//Tekrar listelenmeyi engelliyor
                    MessageBox.Show("Başlık Ayarları Güncellendi...");
                    listele();
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }          
        }
        //--------------------------------------------------------------

        //ulaştirma modelleri ayarları  varsayılan olarak textleri doldurmak için kullanılır  panel8
        private void panel8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Depo";
            textBox3.Text = "Fabrika";
            textBox4.Text = "Arz";
            textBox5.Text = "Talep";
            textBox7.Text = "D1";
            textBox8.Text = "D2";
            textBox9.Text = "D3";
            textBox10.Text = "D4";
            textBox12.Text = "D5";
            textBox11.Text = "D6";
            textBox13.Text = "D7";
            textBox19.Text = "F1";
            textBox18.Text = "F2";
            textBox17.Text = "F3";
            textBox16.Text = "F4";
            textBox14.Text = "F5";
            textBox15.Text = "F6";
            textBox6.Text = "F7";
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

        private void Ulastirmamodelleriayarlari_Load(object sender, EventArgs e)
        {
            formortala();
            listele();
        }

       
    }
}
