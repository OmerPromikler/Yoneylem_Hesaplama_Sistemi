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
//excel kutuphanesi
using Excel = Microsoft.Office.Interop.Excel;
//-----------------------------------------
namespace Yöneylem_Hesaplama_Sistemi
{
    public partial class BelirlilikAltındaKararVermeMaliyet : Form
    {
        public BelirlilikAltındaKararVermeMaliyet()
        {
            InitializeComponent();
        }

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

        //belirlilik2_1_maliyet form nesneleri
        Panel belirlilik2_1_maliyet_pl1 = new Panel();
        Panel belirlilik2_1_maliyet_pl2 = new Panel();
        Panel belirlilik2_1_maliyet_pl3 = new Panel();
        Panel belirlilik2_1_maliyet_pl4 = new Panel();
        Panel belirlilik2_1_maliyet_pl5 = new Panel();
        Panel belirlilik2_1_maliyet_pl6 = new Panel();
        Panel belirlilik2_1_maliyet_pl7 = new Panel();
        Panel belirlilik2_1_maliyet_pl8 = new Panel();
        Panel belirlilik2_1_maliyet_pl9 = new Panel();
        Panel belirlilik2_1_maliyet_pl10 = new Panel();
        Panel belirlilik2_1_maliyet_pl11 = new Panel();
        Panel belirlilik2_1_maliyet_pl12 = new Panel();
        Panel belirlilik2_1_maliyet_pl13 = new Panel();
        Panel belirlilik2_1_maliyet_pl14 = new Panel();
        Panel belirlilik2_1_maliyet_pl15 = new Panel();
        Panel belirlilik2_1_maliyet_pl16 = new Panel();
        Panel belirlilik2_1_maliyet_pl17 = new Panel();
        TabControl belirlilik2_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik2_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik2_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik2_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik2_1_maliyet_txt_baslik1;
        TextBox belirlilik2_1_maliyet_txt_baslik2;
        TextBox belirlilik2_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik2_1_maliyet_txt_baslik1_satir2;
        NumericUpDown belirlilik2_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik2_1_maliyet_txt_baslik2_satir2;
        Label belirlilik2_1_maliyet_sonucbaslik;
        Label belirlilik2_1_maliyet_sonuc;
        DataGridView belirlilik2_1_maliyet_dr1 = new DataGridView();
        Button belirlilik2_1_maliyet_btn1 = new Button();
        Button belirlilik2_1_maliyet_btn2 = new Button();
        Button belirlilik2_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik2_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik3_1_maliyet form nesneleri
        Panel belirlilik3_1_maliyet_pl1 = new Panel();
        Panel belirlilik3_1_maliyet_pl2 = new Panel();
        Panel belirlilik3_1_maliyet_pl3 = new Panel();
        Panel belirlilik3_1_maliyet_pl4 = new Panel();
        Panel belirlilik3_1_maliyet_pl5 = new Panel();
        Panel belirlilik3_1_maliyet_pl6 = new Panel();
        Panel belirlilik3_1_maliyet_pl7 = new Panel();
        Panel belirlilik3_1_maliyet_pl8 = new Panel();
        Panel belirlilik3_1_maliyet_pl9 = new Panel();
        Panel belirlilik3_1_maliyet_pl10 = new Panel();
        Panel belirlilik3_1_maliyet_pl11 = new Panel();
        Panel belirlilik3_1_maliyet_pl12 = new Panel();
        Panel belirlilik3_1_maliyet_pl13 = new Panel();
        Panel belirlilik3_1_maliyet_pl14 = new Panel();
        Panel belirlilik3_1_maliyet_pl15 = new Panel();
        Panel belirlilik3_1_maliyet_pl16 = new Panel();
        Panel belirlilik3_1_maliyet_pl17 = new Panel();
        Panel belirlilik3_1_maliyet_pl18 = new Panel();
        Panel belirlilik3_1_maliyet_pl19 = new Panel();
        TabControl belirlilik3_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik3_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik3_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik3_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik3_1_maliyet_txt_baslik1;
        TextBox belirlilik3_1_maliyet_txt_baslik2;
        TextBox belirlilik3_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik3_1_maliyet_txt_baslik1_satir2;
        TextBox belirlilik3_1_maliyet_txt_baslik1_satir3;
        NumericUpDown belirlilik3_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik3_1_maliyet_txt_baslik2_satir2;
        NumericUpDown belirlilik3_1_maliyet_txt_baslik2_satir3;
        Label belirlilik3_1_maliyet_sonucbaslik;
        Label belirlilik3_1_maliyet_sonuc;
        DataGridView belirlilik3_1_maliyet_dr1 = new DataGridView();
        Button belirlilik3_1_maliyet_btn1 = new Button();
        Button belirlilik3_1_maliyet_btn2 = new Button();
        Button belirlilik3_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik3_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik4_1_maliyet form nesneleri
        Panel belirlilik4_1_maliyet_pl1 = new Panel();
        Panel belirlilik4_1_maliyet_pl2 = new Panel();
        Panel belirlilik4_1_maliyet_pl3 = new Panel();
        Panel belirlilik4_1_maliyet_pl4 = new Panel();
        Panel belirlilik4_1_maliyet_pl5 = new Panel();
        Panel belirlilik4_1_maliyet_pl6 = new Panel();
        Panel belirlilik4_1_maliyet_pl7 = new Panel();
        Panel belirlilik4_1_maliyet_pl8 = new Panel();
        Panel belirlilik4_1_maliyet_pl9 = new Panel();
        Panel belirlilik4_1_maliyet_pl10 = new Panel();
        Panel belirlilik4_1_maliyet_pl11 = new Panel();
        Panel belirlilik4_1_maliyet_pl12 = new Panel();
        Panel belirlilik4_1_maliyet_pl13 = new Panel();
        Panel belirlilik4_1_maliyet_pl14 = new Panel();
        Panel belirlilik4_1_maliyet_pl15 = new Panel();
        Panel belirlilik4_1_maliyet_pl16 = new Panel();
        Panel belirlilik4_1_maliyet_pl17 = new Panel();
        Panel belirlilik4_1_maliyet_pl18 = new Panel();
        Panel belirlilik4_1_maliyet_pl19 = new Panel();
        Panel belirlilik4_1_maliyet_pl20 = new Panel();
        Panel belirlilik4_1_maliyet_pl21 = new Panel();
        TabControl belirlilik4_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik4_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik4_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik4_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik4_1_maliyet_txt_baslik1;
        TextBox belirlilik4_1_maliyet_txt_baslik2;
        TextBox belirlilik4_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik4_1_maliyet_txt_baslik1_satir2;
        TextBox belirlilik4_1_maliyet_txt_baslik1_satir3;
        TextBox belirlilik4_1_maliyet_txt_baslik1_satir4;
        NumericUpDown belirlilik4_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik4_1_maliyet_txt_baslik2_satir2;
        NumericUpDown belirlilik4_1_maliyet_txt_baslik2_satir3;
        NumericUpDown belirlilik4_1_maliyet_txt_baslik2_satir4;
        Label belirlilik4_1_maliyet_sonucbaslik;
        Label belirlilik4_1_maliyet_sonuc;
        DataGridView belirlilik4_1_maliyet_dr1 = new DataGridView();
        Button belirlilik4_1_maliyet_btn1 = new Button();
        Button belirlilik4_1_maliyet_btn2 = new Button();
        Button belirlilik4_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik4_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik5_1_maliyet form nesneleri
        Panel belirlilik5_1_maliyet_pl1 = new Panel();
        Panel belirlilik5_1_maliyet_pl2 = new Panel();
        Panel belirlilik5_1_maliyet_pl3 = new Panel();
        Panel belirlilik5_1_maliyet_pl4 = new Panel();
        Panel belirlilik5_1_maliyet_pl5 = new Panel();
        Panel belirlilik5_1_maliyet_pl6 = new Panel();
        Panel belirlilik5_1_maliyet_pl7 = new Panel();
        Panel belirlilik5_1_maliyet_pl8 = new Panel();
        Panel belirlilik5_1_maliyet_pl9 = new Panel();
        Panel belirlilik5_1_maliyet_pl10 = new Panel();
        Panel belirlilik5_1_maliyet_pl11 = new Panel();
        Panel belirlilik5_1_maliyet_pl12 = new Panel();
        Panel belirlilik5_1_maliyet_pl13 = new Panel();
        Panel belirlilik5_1_maliyet_pl14 = new Panel();
        Panel belirlilik5_1_maliyet_pl15 = new Panel();
        Panel belirlilik5_1_maliyet_pl16 = new Panel();
        Panel belirlilik5_1_maliyet_pl17 = new Panel();
        Panel belirlilik5_1_maliyet_pl18 = new Panel();
        Panel belirlilik5_1_maliyet_pl19 = new Panel();
        Panel belirlilik5_1_maliyet_pl20 = new Panel();
        Panel belirlilik5_1_maliyet_pl21 = new Panel();
        Panel belirlilik5_1_maliyet_pl22 = new Panel();
        Panel belirlilik5_1_maliyet_pl23 = new Panel();
        TabControl belirlilik5_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik5_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik5_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik5_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik5_1_maliyet_txt_baslik1;
        TextBox belirlilik5_1_maliyet_txt_baslik2;
        TextBox belirlilik5_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik5_1_maliyet_txt_baslik1_satir2;
        TextBox belirlilik5_1_maliyet_txt_baslik1_satir3;
        TextBox belirlilik5_1_maliyet_txt_baslik1_satir4;
        TextBox belirlilik5_1_maliyet_txt_baslik1_satir5;
        NumericUpDown belirlilik5_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik5_1_maliyet_txt_baslik2_satir2;
        NumericUpDown belirlilik5_1_maliyet_txt_baslik2_satir3;
        NumericUpDown belirlilik5_1_maliyet_txt_baslik2_satir4;
        NumericUpDown belirlilik5_1_maliyet_txt_baslik2_satir5;
        Label belirlilik5_1_maliyet_sonucbaslik;
        Label belirlilik5_1_maliyet_sonuc;
        DataGridView belirlilik5_1_maliyet_dr1 = new DataGridView();
        Button belirlilik5_1_maliyet_btn1 = new Button();
        Button belirlilik5_1_maliyet_btn2 = new Button();
        Button belirlilik5_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik5_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik6_1_maliyet form nesneleri
        Panel belirlilik6_1_maliyet_pl1 = new Panel();
        Panel belirlilik6_1_maliyet_pl2 = new Panel();
        Panel belirlilik6_1_maliyet_pl3 = new Panel();
        Panel belirlilik6_1_maliyet_pl4 = new Panel();
        Panel belirlilik6_1_maliyet_pl5 = new Panel();
        Panel belirlilik6_1_maliyet_pl6 = new Panel();
        Panel belirlilik6_1_maliyet_pl7 = new Panel();
        Panel belirlilik6_1_maliyet_pl8 = new Panel();
        Panel belirlilik6_1_maliyet_pl9 = new Panel();
        Panel belirlilik6_1_maliyet_pl10 = new Panel();
        Panel belirlilik6_1_maliyet_pl11 = new Panel();
        Panel belirlilik6_1_maliyet_pl12 = new Panel();
        Panel belirlilik6_1_maliyet_pl13 = new Panel();
        Panel belirlilik6_1_maliyet_pl14 = new Panel();
        Panel belirlilik6_1_maliyet_pl15 = new Panel();
        Panel belirlilik6_1_maliyet_pl16 = new Panel();
        Panel belirlilik6_1_maliyet_pl17 = new Panel();
        Panel belirlilik6_1_maliyet_pl18 = new Panel();
        Panel belirlilik6_1_maliyet_pl19 = new Panel();
        Panel belirlilik6_1_maliyet_pl20 = new Panel();
        Panel belirlilik6_1_maliyet_pl21 = new Panel();
        Panel belirlilik6_1_maliyet_pl22 = new Panel();
        Panel belirlilik6_1_maliyet_pl23 = new Panel();
        Panel belirlilik6_1_maliyet_pl24 = new Panel();
        Panel belirlilik6_1_maliyet_pl25 = new Panel();
        TabControl belirlilik6_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik6_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik6_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik6_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik6_1_maliyet_txt_baslik1;
        TextBox belirlilik6_1_maliyet_txt_baslik2;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir2;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir3;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir4;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir5;
        TextBox belirlilik6_1_maliyet_txt_baslik1_satir6;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir2;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir3;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir4;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir5;
        NumericUpDown belirlilik6_1_maliyet_txt_baslik2_satir6;
        Label belirlilik6_1_maliyet_sonucbaslik;
        Label belirlilik6_1_maliyet_sonuc;
        DataGridView belirlilik6_1_maliyet_dr1 = new DataGridView();
        Button belirlilik6_1_maliyet_btn1 = new Button();
        Button belirlilik6_1_maliyet_btn2 = new Button();
        Button belirlilik6_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik6_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik7_1_maliyet form nesneleri
        Panel belirlilik7_1_maliyet_pl1 = new Panel();
        Panel belirlilik7_1_maliyet_pl2 = new Panel();
        Panel belirlilik7_1_maliyet_pl3 = new Panel();
        Panel belirlilik7_1_maliyet_pl4 = new Panel();
        Panel belirlilik7_1_maliyet_pl5 = new Panel();
        Panel belirlilik7_1_maliyet_pl6 = new Panel();
        Panel belirlilik7_1_maliyet_pl7 = new Panel();
        Panel belirlilik7_1_maliyet_pl8 = new Panel();
        Panel belirlilik7_1_maliyet_pl9 = new Panel();
        Panel belirlilik7_1_maliyet_pl10 = new Panel();
        Panel belirlilik7_1_maliyet_pl11 = new Panel();
        Panel belirlilik7_1_maliyet_pl12 = new Panel();
        Panel belirlilik7_1_maliyet_pl13 = new Panel();
        Panel belirlilik7_1_maliyet_pl14 = new Panel();
        Panel belirlilik7_1_maliyet_pl15 = new Panel();
        Panel belirlilik7_1_maliyet_pl16 = new Panel();
        Panel belirlilik7_1_maliyet_pl17 = new Panel();
        Panel belirlilik7_1_maliyet_pl18 = new Panel();
        Panel belirlilik7_1_maliyet_pl19 = new Panel();
        Panel belirlilik7_1_maliyet_pl20 = new Panel();
        Panel belirlilik7_1_maliyet_pl21 = new Panel();
        Panel belirlilik7_1_maliyet_pl22 = new Panel();
        Panel belirlilik7_1_maliyet_pl23 = new Panel();
        Panel belirlilik7_1_maliyet_pl24 = new Panel();
        Panel belirlilik7_1_maliyet_pl25 = new Panel();
        Panel belirlilik7_1_maliyet_pl26 = new Panel();
        Panel belirlilik7_1_maliyet_pl27 = new Panel();
        TabControl belirlilik7_1_maliyet_tb1 = new TabControl();
        TabPage belirlilik7_1_maliyet_tb1_1 = new TabPage();
        TabPage belirlilik7_1_maliyet_tb1_2 = new TabPage();
        TabPage belirlilik7_1_maliyet_tb1_3 = new TabPage();
        TextBox belirlilik7_1_maliyet_txt_baslik1;
        TextBox belirlilik7_1_maliyet_txt_baslik2;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir1;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir2;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir3;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir4;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir5;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir6;
        TextBox belirlilik7_1_maliyet_txt_baslik1_satir7;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir1;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir2;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir3;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir4;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir5;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir6;
        NumericUpDown belirlilik7_1_maliyet_txt_baslik2_satir7;
        Label belirlilik7_1_maliyet_sonucbaslik;
        Label belirlilik7_1_maliyet_sonuc;
        DataGridView belirlilik7_1_maliyet_dr1 = new DataGridView();
        Button belirlilik7_1_maliyet_btn1 = new Button();
        Button belirlilik7_1_maliyet_btn2 = new Button();
        Button belirlilik7_1_maliyet_btn3 = new Button();
        RichTextBox belirlilik7_1_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //belirlilik2_1_maliyet form nesne tasarımları
        public void belirlilik2_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik2_1_maliyet_sonuc = new Label();
            belirlilik2_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik2_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik2_1_maliyet_sonuc.Location = sonuc;
            belirlilik2_1_maliyet_sonuc.Text = "";
            belirlilik2_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik2_1_maliyet_pl4.Controls.Add(belirlilik2_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik2_1_maliyet_sonucbaslik = new Label();
            belirlilik2_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik2_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik2_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik2_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik2_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik2_1_maliyet_pl4.Controls.Add(belirlilik2_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik2_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik2_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik2_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik2_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik2_1_maliyet_pl17.Controls.Add(belirlilik2_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik2_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik2_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik2_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik2_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik2_1_maliyet_pl15.Controls.Add(belirlilik2_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik2_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik2_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik2_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik2_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik2_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik2_1_maliyet_pl16.Controls.Add(belirlilik2_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik2_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik2_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik2_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik2_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik2_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik2_1_maliyet_pl14.Controls.Add(belirlilik2_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik2_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik2_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik2_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik2_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik2_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik2_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik2_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik2_1_maliyet_pl13.Controls.Add(belirlilik2_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik2_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik2_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik2_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik2_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik2_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik2_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik2_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik2_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik2_1_maliyet_pl12.Controls.Add(belirlilik2_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik2_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik2_1_maliyet_pl17.Location = pl17k;
            belirlilik2_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik2_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik2_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik2_1_maliyet_pl16.Location = pl16k;
            belirlilik2_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik2_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik2_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik2_1_maliyet_pl15.Location = pl15k;
            belirlilik2_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik2_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik2_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik2_1_maliyet_pl14.Location = pl14k;
            belirlilik2_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik2_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik2_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik2_1_maliyet_pl13.Location = pl13k;
            belirlilik2_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik2_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik2_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik2_1_maliyet_pl12.Location = pl12k;
            belirlilik2_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik2_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl5.Controls.Add(belirlilik2_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik2_1_maliyet_pl11.Name = "pl11";
            belirlilik2_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik2_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik2_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik2_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl11.Click += new EventHandler(belirlilik2_1_maliyet_pl11_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik2_1_maliyet_pl10.Name = "pl10";
            belirlilik2_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik2_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik2_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl10.Click += new EventHandler(belirlilik2_1_maliyet_pl10_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik2_1_maliyet_pl9.Name = "pl9";
            belirlilik2_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik2_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik2_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl9.Click += new EventHandler(belirlilik2_1_maliyet_pl9_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik2_1_maliyet_pl8.Name = "pl8";
            belirlilik2_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik2_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik2_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl8.Click += new EventHandler(belirlilik2_1_maliyet_pl8_Click);
            belirlilik2_1_maliyet_pl7.Controls.Add(belirlilik2_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik2_1_maliyet_pl6.Name = "pl6";
            belirlilik2_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik2_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik2_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl6.Click += new EventHandler(belirlilik2_1_maliyet_pl6_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik2_1_maliyet_btn3.Name = "btn3";
            belirlilik2_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik2_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik2_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik2_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_btn3.Click += new EventHandler(belirlilik2_1_maliyet_btn3_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik2_1_maliyet_btn2.Name = "btn2";
            belirlilik2_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik2_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik2_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik2_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik2_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik2_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_btn2.Click += new EventHandler(belirlilik2_1_maliyet_btn2_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik2_1_maliyet_btn1.Name = "btn1";
            belirlilik2_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik2_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik2_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik2_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik2_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik2_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik2_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik2_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_btn1.Click += new EventHandler(belirlilik2_1_maliyet_btn1_Click);
            belirlilik2_1_maliyet_pl2.Controls.Add(belirlilik2_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik2_1_maliyet_dr1.Name = "dr1";
            belirlilik2_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik2_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik2_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik2_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik2_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik2_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik2_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik2_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik2_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik2_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik2_1_maliyet_dr1_CellEnter);
            belirlilik2_1_maliyet_tb1_2.Controls.Add(belirlilik2_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik2_1_maliyet_pl7.Name = "pl7";
            belirlilik2_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik2_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik2_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_tb1_2.Controls.Add(belirlilik2_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik2_1_maliyet_pl5.Name = "pl5";
            belirlilik2_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik2_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik2_1_maliyet_pl5.AutoScroll = true;
            belirlilik2_1_maliyet_pl5.AutoSize = true;
            belirlilik2_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik2_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_tb1_1.Controls.Add(belirlilik2_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik2_1_maliyet_rt1.Name = "rt1";
            belirlilik2_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik2_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik2_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_rt1.Enabled = false;
            belirlilik2_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n•  En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik2_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik2_1_maliyet_tb1_3.Controls.Add(belirlilik2_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik2_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik2_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik2_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik2_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_tb1.Controls.Add(belirlilik2_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik2_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik2_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik2_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik2_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_tb1.Controls.Add(belirlilik2_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik2_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik2_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik2_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik2_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_tb1.Controls.Add(belirlilik2_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik2_1_maliyet_tb1.Name = "tb1";
            belirlilik2_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik2_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik2_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik2_1_maliyet_pl3.Controls.Add(belirlilik2_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik2_1_maliyet_pl4.Name = "pl4";
            belirlilik2_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik2_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik2_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik2_1_maliyet_pl4_MouseUp);
            belirlilik2_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik2_1_maliyet_pl4_MouseMove);
            belirlilik2_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik2_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik2_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik2_1_maliyet_pl3.Name = "pl3";
            belirlilik2_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik2_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik2_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik2_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik2_1_maliyet_pl2.Name = "pl2";
            belirlilik2_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik2_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik2_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik2_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik2_1_maliyet_pl1.Name = "pl1";
            belirlilik2_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik2_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik2_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik2_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik2_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik2_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik2_1_maliyet_pl1_MouseUp);
            belirlilik2_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik2_1_maliyet_pl1_MouseMove);
            belirlilik2_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik2_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik2_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik3_1_maliyet form nesne tasarımları
        public void belirlilik3_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik3_1_maliyet_sonuc = new Label();
            belirlilik3_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik3_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik3_1_maliyet_sonuc.Location = sonuc;
            belirlilik3_1_maliyet_sonuc.Text = "";
            belirlilik3_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik3_1_maliyet_pl4.Controls.Add(belirlilik3_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik3_1_maliyet_sonucbaslik = new Label();
            belirlilik3_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik3_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik3_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik3_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik3_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik3_1_maliyet_pl4.Controls.Add(belirlilik3_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel19 içerisine baslik2 altında satır3 numeric textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik2_satir3 = new NumericUpDown();
            belirlilik3_1_maliyet_txt_baslik2_satir3.Name = "txtb2s3";
            Point txt_b2s3 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik2_satir3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik3_1_maliyet_txt_baslik2_satir3.Location = txt_b2s3;
            belirlilik3_1_maliyet_txt_baslik2_satir3.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl19.Controls.Add(belirlilik3_1_maliyet_txt_baslik2_satir3);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik3_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik3_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik3_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl17.Controls.Add(belirlilik3_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik3_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik3_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik3_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl15.Controls.Add(belirlilik3_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel18 içerisine baslik1 altında satır3 textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik1_satir3 = new TextBox();
            belirlilik3_1_maliyet_txt_baslik1_satir3.Name = "txtb1s3";
            Point txt_b1s3 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik1_satir3.Location = txt_b1s3;
            belirlilik3_1_maliyet_txt_baslik1_satir3.Text = "C";
            belirlilik3_1_maliyet_txt_baslik1_satir3.MaxLength = 30;
            belirlilik3_1_maliyet_txt_baslik1_satir3.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl18.Controls.Add(belirlilik3_1_maliyet_txt_baslik1_satir3);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik3_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik3_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik3_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik3_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl16.Controls.Add(belirlilik3_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik3_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik3_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik3_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik3_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik3_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik3_1_maliyet_pl14.Controls.Add(belirlilik3_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik3_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik3_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik3_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik3_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik3_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik3_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik3_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik3_1_maliyet_pl13.Controls.Add(belirlilik3_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik3_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik3_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik3_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik3_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik3_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik3_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik3_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik3_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik3_1_maliyet_pl12.Controls.Add(belirlilik3_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel19 oluşturuldu satır-3-2 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(220, 194);
            belirlilik3_1_maliyet_pl19.Location = pl19k;
            belirlilik3_1_maliyet_pl19.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu satır-3-1 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(5, 194);
            belirlilik3_1_maliyet_pl18.Location = pl18k;
            belirlilik3_1_maliyet_pl18.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl18);
            //-----------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik3_1_maliyet_pl17.Location = pl17k;
            belirlilik3_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik3_1_maliyet_pl16.Location = pl16k;
            belirlilik3_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik3_1_maliyet_pl15.Location = pl15k;
            belirlilik3_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik3_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik3_1_maliyet_pl14.Location = pl14k;
            belirlilik3_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik3_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik3_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik3_1_maliyet_pl13.Location = pl13k;
            belirlilik3_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik3_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik3_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik3_1_maliyet_pl12.Location = pl12k;
            belirlilik3_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik3_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl5.Controls.Add(belirlilik3_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik3_1_maliyet_pl11.Name = "pl11";
            belirlilik3_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik3_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik3_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik3_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl11.Click += new EventHandler(belirlilik3_1_maliyet_pl11_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik3_1_maliyet_pl10.Name = "pl10";
            belirlilik3_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik3_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik3_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl10.Click += new EventHandler(belirlilik3_1_maliyet_pl10_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik3_1_maliyet_pl9.Name = "pl9";
            belirlilik3_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik3_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik3_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl9.Click += new EventHandler(belirlilik3_1_maliyet_pl9_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik3_1_maliyet_pl8.Name = "pl8";
            belirlilik3_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik3_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik3_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl8.Click += new EventHandler(belirlilik3_1_maliyet_pl8_Click);
            belirlilik3_1_maliyet_pl7.Controls.Add(belirlilik3_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik3_1_maliyet_pl6.Name = "pl6";
            belirlilik3_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik3_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik3_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl6.Click += new EventHandler(belirlilik3_1_maliyet_pl6_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik3_1_maliyet_btn3.Name = "btn3";
            belirlilik3_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik3_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik3_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik3_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_btn3.Click += new EventHandler(belirlilik3_1_maliyet_btn3_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik3_1_maliyet_btn2.Name = "btn2";
            belirlilik3_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik3_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik3_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik3_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik3_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik3_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_btn2.Click += new EventHandler(belirlilik3_1_maliyet_btn2_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik3_1_maliyet_btn1.Name = "btn1";
            belirlilik3_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik3_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik3_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik3_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik3_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik3_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik3_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik3_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_btn1.Click += new EventHandler(belirlilik3_1_maliyet_btn1_Click);
            belirlilik3_1_maliyet_pl2.Controls.Add(belirlilik3_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik3_1_maliyet_dr1.Name = "dr1";
            belirlilik3_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik3_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik3_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik3_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik3_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik3_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik3_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik3_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik3_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik3_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik3_1_maliyet_dr1_CellEnter);
            belirlilik3_1_maliyet_tb1_2.Controls.Add(belirlilik3_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik3_1_maliyet_pl7.Name = "pl7";
            belirlilik3_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik3_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik3_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_tb1_2.Controls.Add(belirlilik3_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik3_1_maliyet_pl5.Name = "pl5";
            belirlilik3_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik3_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik3_1_maliyet_pl5.AutoScroll = true;
            belirlilik3_1_maliyet_pl5.AutoSize = true;
            belirlilik3_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik3_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_tb1_1.Controls.Add(belirlilik3_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik3_1_maliyet_rt1.Name = "rt1";
            belirlilik3_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik3_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik3_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_rt1.Enabled = false;
            belirlilik3_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n•  En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik3_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik3_1_maliyet_tb1_3.Controls.Add(belirlilik3_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik3_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik3_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik3_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik3_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_tb1.Controls.Add(belirlilik3_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik3_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik3_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik3_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik3_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_tb1.Controls.Add(belirlilik3_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik3_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik3_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik3_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik3_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_tb1.Controls.Add(belirlilik3_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik3_1_maliyet_tb1.Name = "tb1";
            belirlilik3_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik3_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik3_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik3_1_maliyet_pl3.Controls.Add(belirlilik3_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik3_1_maliyet_pl4.Name = "pl4";
            belirlilik3_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik3_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik3_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik3_1_maliyet_pl4_MouseUp);
            belirlilik3_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik3_1_maliyet_pl4_MouseMove);
            belirlilik3_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik3_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik3_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik3_1_maliyet_pl3.Name = "pl3";
            belirlilik3_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik3_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik3_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik3_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik3_1_maliyet_pl2.Name = "pl2";
            belirlilik3_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik3_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik3_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik3_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik3_1_maliyet_pl1.Name = "pl1";
            belirlilik3_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik3_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik3_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik3_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik3_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik3_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik3_1_maliyet_pl1_MouseUp);
            belirlilik3_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik3_1_maliyet_pl1_MouseMove);
            belirlilik3_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik3_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik3_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik4_1_maliyet form nesne tasarımları
        public void belirlilik4_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik4_1_maliyet_sonuc = new Label();
            belirlilik4_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik4_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik4_1_maliyet_sonuc.Location = sonuc;
            belirlilik4_1_maliyet_sonuc.Text = "";
            belirlilik4_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik4_1_maliyet_pl4.Controls.Add(belirlilik4_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik4_1_maliyet_sonucbaslik = new Label();
            belirlilik4_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik4_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik4_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik4_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik4_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik4_1_maliyet_pl4.Controls.Add(belirlilik4_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel21 içerisine baslik2 altında satır4 numeric textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik2_satir4 = new NumericUpDown();
            belirlilik4_1_maliyet_txt_baslik2_satir4.Name = "txtb2s4";
            Point txt_b2s4 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik2_satir4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik4_1_maliyet_txt_baslik2_satir4.Location = txt_b2s4;
            belirlilik4_1_maliyet_txt_baslik2_satir4.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl21.Controls.Add(belirlilik4_1_maliyet_txt_baslik2_satir4);
            //---------------------------------------------------------------

            //panel19 içerisine baslik2 altında satır3 numeric textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik2_satir3 = new NumericUpDown();
            belirlilik4_1_maliyet_txt_baslik2_satir3.Name = "txtb2s3";
            Point txt_b2s3 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik2_satir3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik4_1_maliyet_txt_baslik2_satir3.Location = txt_b2s3;
            belirlilik4_1_maliyet_txt_baslik2_satir3.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl19.Controls.Add(belirlilik4_1_maliyet_txt_baslik2_satir3);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik4_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik4_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik4_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl17.Controls.Add(belirlilik4_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik4_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik4_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik4_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl15.Controls.Add(belirlilik4_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel20 içerisine baslik1 altında satır4 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik1_satir4 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik1_satir4.Name = "txtb1s4";
            Point txt_b1s4 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik1_satir4.Location = txt_b1s4;
            belirlilik4_1_maliyet_txt_baslik1_satir4.Text = "D";
            belirlilik4_1_maliyet_txt_baslik1_satir4.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik1_satir4.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl20.Controls.Add(belirlilik4_1_maliyet_txt_baslik1_satir4);
            //---------------------------------------------------------------

            //panel18 içerisine baslik1 altında satır3 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik1_satir3 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik1_satir3.Name = "txtb1s3";
            Point txt_b1s3 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik1_satir3.Location = txt_b1s3;
            belirlilik4_1_maliyet_txt_baslik1_satir3.Text = "C";
            belirlilik4_1_maliyet_txt_baslik1_satir3.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik1_satir3.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl18.Controls.Add(belirlilik4_1_maliyet_txt_baslik1_satir3);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik4_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik4_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl16.Controls.Add(belirlilik4_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik4_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik4_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik4_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik4_1_maliyet_pl14.Controls.Add(belirlilik4_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik4_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik4_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik4_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik4_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik4_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik4_1_maliyet_pl13.Controls.Add(belirlilik4_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik4_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik4_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik4_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik4_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik4_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik4_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik4_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik4_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik4_1_maliyet_pl12.Controls.Add(belirlilik4_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel21 oluşturuldu satır-4-2 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(220, 239);
            belirlilik4_1_maliyet_pl21.Location = pl21k;
            belirlilik4_1_maliyet_pl21.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu satır-4-1 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(5, 239);
            belirlilik4_1_maliyet_pl20.Location = pl20k;
            belirlilik4_1_maliyet_pl20.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl20);
            //-----------------------------------------

            //panel19 oluşturuldu satır-3-2 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(220, 194);
            belirlilik4_1_maliyet_pl19.Location = pl19k;
            belirlilik4_1_maliyet_pl19.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu satır-3-1 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(5, 194);
            belirlilik4_1_maliyet_pl18.Location = pl18k;
            belirlilik4_1_maliyet_pl18.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl18);
            //-----------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik4_1_maliyet_pl17.Location = pl17k;
            belirlilik4_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik4_1_maliyet_pl16.Location = pl16k;
            belirlilik4_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik4_1_maliyet_pl15.Location = pl15k;
            belirlilik4_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik4_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik4_1_maliyet_pl14.Location = pl14k;
            belirlilik4_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik4_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik4_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik4_1_maliyet_pl13.Location = pl13k;
            belirlilik4_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik4_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik4_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik4_1_maliyet_pl12.Location = pl12k;
            belirlilik4_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik4_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl5.Controls.Add(belirlilik4_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik4_1_maliyet_pl11.Name = "pl11";
            belirlilik4_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik4_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik4_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik4_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl11.Click += new EventHandler(belirlilik4_1_maliyet_pl11_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik4_1_maliyet_pl10.Name = "pl10";
            belirlilik4_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik4_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik4_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl10.Click += new EventHandler(belirlilik4_1_maliyet_pl10_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik4_1_maliyet_pl9.Name = "pl9";
            belirlilik4_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik4_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik4_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl9.Click += new EventHandler(belirlilik4_1_maliyet_pl9_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik4_1_maliyet_pl8.Name = "pl8";
            belirlilik4_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik4_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik4_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl8.Click += new EventHandler(belirlilik4_1_maliyet_pl8_Click);
            belirlilik4_1_maliyet_pl7.Controls.Add(belirlilik4_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik4_1_maliyet_pl6.Name = "pl6";
            belirlilik4_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik4_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik4_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl6.Click += new EventHandler(belirlilik4_1_maliyet_pl6_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik4_1_maliyet_btn3.Name = "btn3";
            belirlilik4_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik4_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik4_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik4_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_btn3.Click += new EventHandler(belirlilik4_1_maliyet_btn3_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik4_1_maliyet_btn2.Name = "btn2";
            belirlilik4_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik4_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik4_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik4_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik4_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik4_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_btn2.Click += new EventHandler(belirlilik4_1_maliyet_btn2_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik4_1_maliyet_btn1.Name = "btn1";
            belirlilik4_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik4_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik4_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik4_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik4_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik4_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik4_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik4_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_btn1.Click += new EventHandler(belirlilik4_1_maliyet_btn1_Click);
            belirlilik4_1_maliyet_pl2.Controls.Add(belirlilik4_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik4_1_maliyet_dr1.Name = "dr1";
            belirlilik4_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik4_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik4_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik4_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik4_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik4_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik4_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik4_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik4_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik4_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik4_1_maliyet_dr1_CellEnter);
            belirlilik4_1_maliyet_tb1_2.Controls.Add(belirlilik4_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik4_1_maliyet_pl7.Name = "pl7";
            belirlilik4_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik4_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik4_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_tb1_2.Controls.Add(belirlilik4_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik4_1_maliyet_pl5.Name = "pl5";
            belirlilik4_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik4_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik4_1_maliyet_pl5.AutoScroll = true;
            belirlilik4_1_maliyet_pl5.AutoSize = true;
            belirlilik4_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik4_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_tb1_1.Controls.Add(belirlilik4_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik4_1_maliyet_rt1.Name = "rt1";
            belirlilik4_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik4_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik4_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_rt1.Enabled = false;
            belirlilik4_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n•  En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik4_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik4_1_maliyet_tb1_3.Controls.Add(belirlilik4_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik4_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik4_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik4_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik4_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_tb1.Controls.Add(belirlilik4_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik4_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik4_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik4_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik4_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_tb1.Controls.Add(belirlilik4_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik4_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik4_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik4_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik4_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_tb1.Controls.Add(belirlilik4_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik4_1_maliyet_tb1.Name = "tb1";
            belirlilik4_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik4_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik4_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik4_1_maliyet_pl3.Controls.Add(belirlilik4_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik4_1_maliyet_pl4.Name = "pl4";
            belirlilik4_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik4_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik4_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik4_1_maliyet_pl4_MouseUp);
            belirlilik4_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik4_1_maliyet_pl4_MouseMove);
            belirlilik4_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik4_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik4_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik4_1_maliyet_pl3.Name = "pl3";
            belirlilik4_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik4_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik4_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik4_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik4_1_maliyet_pl2.Name = "pl2";
            belirlilik4_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik4_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik4_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik4_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik4_1_maliyet_pl1.Name = "pl1";
            belirlilik4_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik4_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik4_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik4_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik4_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik4_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik4_1_maliyet_pl1_MouseUp);
            belirlilik4_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik4_1_maliyet_pl1_MouseMove);
            belirlilik4_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik4_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik4_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik5_1_maliyet form nesne tasarımları
        public void belirlilik5_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik5_1_maliyet_sonuc = new Label();
            belirlilik5_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik5_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik5_1_maliyet_sonuc.Location = sonuc;
            belirlilik5_1_maliyet_sonuc.Text = "";
            belirlilik5_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik5_1_maliyet_pl4.Controls.Add(belirlilik5_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik5_1_maliyet_sonucbaslik = new Label();
            belirlilik5_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik5_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik5_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik5_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik5_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik5_1_maliyet_pl4.Controls.Add(belirlilik5_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel23 içerisine baslik2 altında satır5 numeric textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2_satir5 = new NumericUpDown();
            belirlilik5_1_maliyet_txt_baslik2_satir5.Name = "txtb2s5";
            Point txt_b2s5 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik2_satir5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik5_1_maliyet_txt_baslik2_satir5.Location = txt_b2s5;
            belirlilik5_1_maliyet_txt_baslik2_satir5.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl23.Controls.Add(belirlilik5_1_maliyet_txt_baslik2_satir5);
            //---------------------------------------------------------------

            //panel21 içerisine baslik2 altında satır4 numeric textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2_satir4 = new NumericUpDown();
            belirlilik5_1_maliyet_txt_baslik2_satir4.Name = "txtb2s4";
            Point txt_b2s4 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik2_satir4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik5_1_maliyet_txt_baslik2_satir4.Location = txt_b2s4;
            belirlilik5_1_maliyet_txt_baslik2_satir4.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl21.Controls.Add(belirlilik5_1_maliyet_txt_baslik2_satir4);
            //---------------------------------------------------------------

            //panel19 içerisine baslik2 altında satır3 numeric textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2_satir3 = new NumericUpDown();
            belirlilik5_1_maliyet_txt_baslik2_satir3.Name = "txtb2s3";
            Point txt_b2s3 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik2_satir3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik5_1_maliyet_txt_baslik2_satir3.Location = txt_b2s3;
            belirlilik5_1_maliyet_txt_baslik2_satir3.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl19.Controls.Add(belirlilik5_1_maliyet_txt_baslik2_satir3);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik5_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik5_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik5_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl17.Controls.Add(belirlilik5_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik5_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik5_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik5_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl15.Controls.Add(belirlilik5_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel22 içerisine baslik1 altında satır5 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1_satir5 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1_satir5.Name = "txtb1s5";
            Point txt_b1s5 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik1_satir5.Location = txt_b1s5;
            belirlilik5_1_maliyet_txt_baslik1_satir5.Text = "E";
            belirlilik5_1_maliyet_txt_baslik1_satir5.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1_satir5.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl22.Controls.Add(belirlilik5_1_maliyet_txt_baslik1_satir5);
            //---------------------------------------------------------------

            //panel20 içerisine baslik1 altında satır4 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1_satir4 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1_satir4.Name = "txtb1s4";
            Point txt_b1s4 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik1_satir4.Location = txt_b1s4;
            belirlilik5_1_maliyet_txt_baslik1_satir4.Text = "D";
            belirlilik5_1_maliyet_txt_baslik1_satir4.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1_satir4.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl20.Controls.Add(belirlilik5_1_maliyet_txt_baslik1_satir4);
            //---------------------------------------------------------------

            //panel18 içerisine baslik1 altında satır3 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1_satir3 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1_satir3.Name = "txtb1s3";
            Point txt_b1s3 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik1_satir3.Location = txt_b1s3;
            belirlilik5_1_maliyet_txt_baslik1_satir3.Text = "C";
            belirlilik5_1_maliyet_txt_baslik1_satir3.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1_satir3.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl18.Controls.Add(belirlilik5_1_maliyet_txt_baslik1_satir3);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik5_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik5_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl16.Controls.Add(belirlilik5_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik5_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik5_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik5_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik5_1_maliyet_pl14.Controls.Add(belirlilik5_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik5_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik5_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik5_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik5_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik5_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik5_1_maliyet_pl13.Controls.Add(belirlilik5_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik5_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik5_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik5_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik5_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik5_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik5_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik5_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik5_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik5_1_maliyet_pl12.Controls.Add(belirlilik5_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel23 oluşturuldu satır-5-2 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(220, 284);
            belirlilik5_1_maliyet_pl23.Location = pl23k;
            belirlilik5_1_maliyet_pl23.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu satır-5-1 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(5, 284);
            belirlilik5_1_maliyet_pl22.Location = pl22k;
            belirlilik5_1_maliyet_pl22.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu satır-4-2 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(220, 239);
            belirlilik5_1_maliyet_pl21.Location = pl21k;
            belirlilik5_1_maliyet_pl21.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu satır-4-1 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(5, 239);
            belirlilik5_1_maliyet_pl20.Location = pl20k;
            belirlilik5_1_maliyet_pl20.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl20);
            //-----------------------------------------

            //panel19 oluşturuldu satır-3-2 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(220, 194);
            belirlilik5_1_maliyet_pl19.Location = pl19k;
            belirlilik5_1_maliyet_pl19.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu satır-3-1 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(5, 194);
            belirlilik5_1_maliyet_pl18.Location = pl18k;
            belirlilik5_1_maliyet_pl18.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl18);
            //-----------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik5_1_maliyet_pl17.Location = pl17k;
            belirlilik5_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik5_1_maliyet_pl16.Location = pl16k;
            belirlilik5_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik5_1_maliyet_pl15.Location = pl15k;
            belirlilik5_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik5_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik5_1_maliyet_pl14.Location = pl14k;
            belirlilik5_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik5_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik5_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik5_1_maliyet_pl13.Location = pl13k;
            belirlilik5_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik5_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik5_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik5_1_maliyet_pl12.Location = pl12k;
            belirlilik5_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik5_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl5.Controls.Add(belirlilik5_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik5_1_maliyet_pl11.Name = "pl11";
            belirlilik5_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik5_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik5_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik5_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl11.Click += new EventHandler(belirlilik5_1_maliyet_pl11_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik5_1_maliyet_pl10.Name = "pl10";
            belirlilik5_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik5_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik5_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl10.Click += new EventHandler(belirlilik5_1_maliyet_pl10_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik5_1_maliyet_pl9.Name = "pl9";
            belirlilik5_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik5_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik5_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl9.Click += new EventHandler(belirlilik5_1_maliyet_pl9_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik5_1_maliyet_pl8.Name = "pl8";
            belirlilik5_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik5_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik5_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl8.Click += new EventHandler(belirlilik5_1_maliyet_pl8_Click);
            belirlilik5_1_maliyet_pl7.Controls.Add(belirlilik5_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik5_1_maliyet_pl6.Name = "pl6";
            belirlilik5_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik5_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik5_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl6.Click += new EventHandler(belirlilik5_1_maliyet_pl6_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik5_1_maliyet_btn3.Name = "btn3";
            belirlilik5_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik5_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik5_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik5_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_btn3.Click += new EventHandler(belirlilik5_1_maliyet_btn3_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik5_1_maliyet_btn2.Name = "btn2";
            belirlilik5_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik5_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik5_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik5_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik5_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik5_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_btn2.Click += new EventHandler(belirlilik5_1_maliyet_btn2_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik5_1_maliyet_btn1.Name = "btn1";
            belirlilik5_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik5_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik5_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik5_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik5_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik5_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik5_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik5_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_btn1.Click += new EventHandler(belirlilik5_1_maliyet_btn1_Click);
            belirlilik5_1_maliyet_pl2.Controls.Add(belirlilik5_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik5_1_maliyet_dr1.Name = "dr1";
            belirlilik5_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik5_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik5_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik5_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik5_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik5_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik5_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik5_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik5_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik5_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik5_1_maliyet_dr1_CellEnter);
            belirlilik5_1_maliyet_tb1_2.Controls.Add(belirlilik5_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik5_1_maliyet_pl7.Name = "pl7";
            belirlilik5_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik5_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik5_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_tb1_2.Controls.Add(belirlilik5_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik5_1_maliyet_pl5.Name = "pl5";
            belirlilik5_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik5_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik5_1_maliyet_pl5.AutoScroll = true;
            belirlilik5_1_maliyet_pl5.AutoSize = true;
            belirlilik5_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik5_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_tb1_1.Controls.Add(belirlilik5_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik5_1_maliyet_rt1.Name = "rt1";
            belirlilik5_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik5_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik5_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_rt1.Enabled = false;
            belirlilik5_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n• En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik5_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik5_1_maliyet_tb1_3.Controls.Add(belirlilik5_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik5_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik5_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik5_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik5_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_tb1.Controls.Add(belirlilik5_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik5_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik5_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik5_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik5_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_tb1.Controls.Add(belirlilik5_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik5_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik5_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik5_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik5_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_tb1.Controls.Add(belirlilik5_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik5_1_maliyet_tb1.Name = "tb1";
            belirlilik5_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik5_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik5_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik5_1_maliyet_pl3.Controls.Add(belirlilik5_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik5_1_maliyet_pl4.Name = "pl4";
            belirlilik5_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik5_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik5_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik5_1_maliyet_pl4_MouseUp);
            belirlilik5_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik5_1_maliyet_pl4_MouseMove);
            belirlilik5_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik5_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik5_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik5_1_maliyet_pl3.Name = "pl3";
            belirlilik5_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik5_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik5_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik5_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik5_1_maliyet_pl2.Name = "pl2";
            belirlilik5_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik5_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik5_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik5_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik5_1_maliyet_pl1.Name = "pl1";
            belirlilik5_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik5_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik5_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik5_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik5_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik5_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik5_1_maliyet_pl1_MouseUp);
            belirlilik5_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik5_1_maliyet_pl1_MouseMove);
            belirlilik5_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik5_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik5_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik6_1_maliyet form nesne tasarımları
        public void belirlilik6_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik6_1_maliyet_sonuc = new Label();
            belirlilik6_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik6_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik6_1_maliyet_sonuc.Location = sonuc;
            belirlilik6_1_maliyet_sonuc.Text = "";
            belirlilik6_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik6_1_maliyet_pl4.Controls.Add(belirlilik6_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik6_1_maliyet_sonucbaslik = new Label();
            belirlilik6_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik6_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik6_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik6_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik6_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik6_1_maliyet_pl4.Controls.Add(belirlilik6_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel25 içerisine baslik2 altında satır6 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir6 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir6.Name = "txtb2s6";
            Point txt_b2s6 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir6.Location = txt_b2s6;
            belirlilik6_1_maliyet_txt_baslik2_satir6.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl25.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir6);
            //---------------------------------------------------------------

            //panel23 içerisine baslik2 altında satır5 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir5 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir5.Name = "txtb2s5";
            Point txt_b2s5 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir5.Location = txt_b2s5;
            belirlilik6_1_maliyet_txt_baslik2_satir5.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl23.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir5);
            //---------------------------------------------------------------

            //panel21 içerisine baslik2 altında satır4 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir4 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir4.Name = "txtb2s4";
            Point txt_b2s4 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir4.Location = txt_b2s4;
            belirlilik6_1_maliyet_txt_baslik2_satir4.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl21.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir4);
            //---------------------------------------------------------------

            //panel19 içerisine baslik2 altında satır3 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir3 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir3.Name = "txtb2s3";
            Point txt_b2s3 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir3.Location = txt_b2s3;
            belirlilik6_1_maliyet_txt_baslik2_satir3.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl19.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir3);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik6_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl17.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik6_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik6_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik6_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl15.Controls.Add(belirlilik6_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel24 içerisine baslik1 altında satır6 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir6 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir6.Name = "txtb1s6";
            Point txt_b1s6 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir6.Location = txt_b1s6;
            belirlilik6_1_maliyet_txt_baslik1_satir6.Text = "F";
            belirlilik6_1_maliyet_txt_baslik1_satir6.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir6.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl24.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir6);
            //---------------------------------------------------------------

            //panel22 içerisine baslik1 altında satır5 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir5 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir5.Name = "txtb1s5";
            Point txt_b1s5 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir5.Location = txt_b1s5;
            belirlilik6_1_maliyet_txt_baslik1_satir5.Text = "E";
            belirlilik6_1_maliyet_txt_baslik1_satir5.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir5.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl22.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir5);
            //---------------------------------------------------------------

            //panel20 içerisine baslik1 altında satır4 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir4 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir4.Name = "txtb1s4";
            Point txt_b1s4 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir4.Location = txt_b1s4;
            belirlilik6_1_maliyet_txt_baslik1_satir4.Text = "D";
            belirlilik6_1_maliyet_txt_baslik1_satir4.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir4.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl20.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir4);
            //---------------------------------------------------------------

            //panel18 içerisine baslik1 altında satır3 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir3 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir3.Name = "txtb1s3";
            Point txt_b1s3 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir3.Location = txt_b1s3;
            belirlilik6_1_maliyet_txt_baslik1_satir3.Text = "C";
            belirlilik6_1_maliyet_txt_baslik1_satir3.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir3.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl18.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir3);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik6_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik6_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl16.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik6_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik6_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik6_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik6_1_maliyet_pl14.Controls.Add(belirlilik6_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik6_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik6_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik6_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik6_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik6_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik6_1_maliyet_pl13.Controls.Add(belirlilik6_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik6_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik6_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik6_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik6_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik6_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik6_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik6_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik6_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik6_1_maliyet_pl12.Controls.Add(belirlilik6_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel25 oluşturuldu satır-6-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(220, 329);
            belirlilik6_1_maliyet_pl25.Location = pl25k;
            belirlilik6_1_maliyet_pl25.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl25);
            //-----------------------------------------

            //panel24 oluşturuldu satır-6-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(5, 329);
            belirlilik6_1_maliyet_pl24.Location = pl24k;
            belirlilik6_1_maliyet_pl24.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl24);
            //-----------------------------------------

            //panel23 oluşturuldu satır-5-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(220, 284);
            belirlilik6_1_maliyet_pl23.Location = pl23k;
            belirlilik6_1_maliyet_pl23.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu satır-5-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(5, 284);
            belirlilik6_1_maliyet_pl22.Location = pl22k;
            belirlilik6_1_maliyet_pl22.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu satır-4-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(220, 239);
            belirlilik6_1_maliyet_pl21.Location = pl21k;
            belirlilik6_1_maliyet_pl21.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu satır-4-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(5, 239);
            belirlilik6_1_maliyet_pl20.Location = pl20k;
            belirlilik6_1_maliyet_pl20.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl20);
            //-----------------------------------------

            //panel19 oluşturuldu satır-3-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(220, 194);
            belirlilik6_1_maliyet_pl19.Location = pl19k;
            belirlilik6_1_maliyet_pl19.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu satır-3-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(5, 194);
            belirlilik6_1_maliyet_pl18.Location = pl18k;
            belirlilik6_1_maliyet_pl18.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl18);
            //-----------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik6_1_maliyet_pl17.Location = pl17k;
            belirlilik6_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik6_1_maliyet_pl16.Location = pl16k;
            belirlilik6_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik6_1_maliyet_pl15.Location = pl15k;
            belirlilik6_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik6_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik6_1_maliyet_pl14.Location = pl14k;
            belirlilik6_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik6_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik6_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik6_1_maliyet_pl13.Location = pl13k;
            belirlilik6_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik6_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik6_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik6_1_maliyet_pl12.Location = pl12k;
            belirlilik6_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik6_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl5.Controls.Add(belirlilik6_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik6_1_maliyet_pl11.Name = "pl11";
            belirlilik6_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik6_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik6_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik6_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl11.Click += new EventHandler(belirlilik6_1_maliyet_pl11_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik6_1_maliyet_pl10.Name = "pl10";
            belirlilik6_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik6_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik6_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl10.Click += new EventHandler(belirlilik6_1_maliyet_pl10_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik6_1_maliyet_pl9.Name = "pl9";
            belirlilik6_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik6_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik6_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl9.Click += new EventHandler(belirlilik6_1_maliyet_pl9_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik6_1_maliyet_pl8.Name = "pl8";
            belirlilik6_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik6_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik6_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl8.Click += new EventHandler(belirlilik6_1_maliyet_pl8_Click);
            belirlilik6_1_maliyet_pl7.Controls.Add(belirlilik6_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik6_1_maliyet_pl6.Name = "pl6";
            belirlilik6_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik6_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik6_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl6.Click += new EventHandler(belirlilik6_1_maliyet_pl6_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik6_1_maliyet_btn3.Name = "btn3";
            belirlilik6_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik6_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik6_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik6_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_btn3.Click += new EventHandler(belirlilik6_1_maliyet_btn3_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik6_1_maliyet_btn2.Name = "btn2";
            belirlilik6_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik6_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik6_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik6_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik6_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik6_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_btn2.Click += new EventHandler(belirlilik6_1_maliyet_btn2_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik6_1_maliyet_btn1.Name = "btn1";
            belirlilik6_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik6_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik6_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik6_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik6_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik6_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik6_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik6_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_btn1.Click += new EventHandler(belirlilik6_1_maliyet_btn1_Click);
            belirlilik6_1_maliyet_pl2.Controls.Add(belirlilik6_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik6_1_maliyet_dr1.Name = "dr1";
            belirlilik6_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik6_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik6_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik6_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik6_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik6_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik6_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik6_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik6_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik6_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik6_1_maliyet_dr1_CellEnter);
            belirlilik6_1_maliyet_tb1_2.Controls.Add(belirlilik6_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik6_1_maliyet_pl7.Name = "pl7";
            belirlilik6_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik6_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik6_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_tb1_2.Controls.Add(belirlilik6_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik6_1_maliyet_pl5.Name = "pl5";
            belirlilik6_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik6_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik6_1_maliyet_pl5.AutoScroll = true;
            belirlilik6_1_maliyet_pl5.AutoSize = true;
            belirlilik6_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik6_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_tb1_1.Controls.Add(belirlilik6_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik6_1_maliyet_rt1.Name = "rt1";
            belirlilik6_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik6_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik6_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_rt1.Enabled = false;
            belirlilik6_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n•  En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik6_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik6_1_maliyet_tb1_3.Controls.Add(belirlilik6_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik6_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik6_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik6_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik6_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_tb1.Controls.Add(belirlilik6_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik6_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik6_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik6_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik6_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_tb1.Controls.Add(belirlilik6_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik6_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik6_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik6_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik6_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_tb1.Controls.Add(belirlilik6_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik6_1_maliyet_tb1.Name = "tb1";
            belirlilik6_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik6_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik6_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik6_1_maliyet_pl3.Controls.Add(belirlilik6_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik6_1_maliyet_pl4.Name = "pl4";
            belirlilik6_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik6_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik6_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik6_1_maliyet_pl4_MouseUp);
            belirlilik6_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik6_1_maliyet_pl4_MouseMove);
            belirlilik6_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik6_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik6_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik6_1_maliyet_pl3.Name = "pl3";
            belirlilik6_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik6_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik6_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik6_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik6_1_maliyet_pl2.Name = "pl2";
            belirlilik6_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik6_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik6_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik6_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik6_1_maliyet_pl1.Name = "pl1";
            belirlilik6_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik6_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik6_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik6_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik6_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik6_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik6_1_maliyet_pl1_MouseUp);
            belirlilik6_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik6_1_maliyet_pl1_MouseMove);
            belirlilik6_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik6_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik6_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik7_1_maliyet form nesne tasarımları
        public void belirlilik7_1_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            belirlilik7_1_maliyet_sonuc = new Label();
            belirlilik7_1_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            belirlilik7_1_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik7_1_maliyet_sonuc.Location = sonuc;
            belirlilik7_1_maliyet_sonuc.Text = "";
            belirlilik7_1_maliyet_sonuc.Size = new Size(650, 13);
            belirlilik7_1_maliyet_pl4.Controls.Add(belirlilik7_1_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            belirlilik7_1_maliyet_sonucbaslik = new Label();
            belirlilik7_1_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            belirlilik7_1_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            belirlilik7_1_maliyet_sonucbaslik.Location = sonucbaslik;
            belirlilik7_1_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            belirlilik7_1_maliyet_sonucbaslik.Size = new Size(93, 13);
            belirlilik7_1_maliyet_pl4.Controls.Add(belirlilik7_1_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            //panel27 içerisine baslik2 altında satır7 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir7 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir7.Name = "txtb2s7";
            Point txt_b2s7 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir7.Location = txt_b2s7;
            belirlilik7_1_maliyet_txt_baslik2_satir7.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl27.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir7);
            //---------------------------------------------------------------

            //panel25 içerisine baslik2 altında satır6 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir6 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir6.Name = "txtb2s6";
            Point txt_b2s6 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir6.Location = txt_b2s6;
            belirlilik7_1_maliyet_txt_baslik2_satir6.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl25.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir6);
            //---------------------------------------------------------------

            //panel23 içerisine baslik2 altında satır5 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir5 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir5.Name = "txtb2s5";
            Point txt_b2s5 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir5.Location = txt_b2s5;
            belirlilik7_1_maliyet_txt_baslik2_satir5.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl23.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir5);
            //---------------------------------------------------------------

            //panel21 içerisine baslik2 altında satır4 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir4 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir4.Name = "txtb2s4";
            Point txt_b2s4 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir4.Location = txt_b2s4;
            belirlilik7_1_maliyet_txt_baslik2_satir4.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl21.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir4);
            //---------------------------------------------------------------

            //panel19 içerisine baslik2 altında satır3 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir3 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir3.Name = "txtb2s3";
            Point txt_b2s3 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir3.Location = txt_b2s3;
            belirlilik7_1_maliyet_txt_baslik2_satir3.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl19.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir3);
            //---------------------------------------------------------------

            //panel17 içerisine baslik2 altında satır2 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir2 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir2.Name = "txtb2s2";
            Point txt_b2s2 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir2.Location = txt_b2s2;
            belirlilik7_1_maliyet_txt_baslik2_satir2.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl17.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir2);
            //---------------------------------------------------------------

            //panel15 içerisine baslik2 altında satır1 numeric textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2_satir1 = new NumericUpDown();
            belirlilik7_1_maliyet_txt_baslik2_satir1.Name = "txtb2s1";
            Point txt_b2s1 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik2_satir1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            belirlilik7_1_maliyet_txt_baslik2_satir1.Location = txt_b2s1;
            belirlilik7_1_maliyet_txt_baslik2_satir1.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl15.Controls.Add(belirlilik7_1_maliyet_txt_baslik2_satir1);
            //---------------------------------------------------------------

            //panel26 içerisine baslik1 altında satır7 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir7 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir7.Name = "txtb1s7";
            Point txt_b1s7 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir7.Location = txt_b1s7;
            belirlilik7_1_maliyet_txt_baslik1_satir7.Text = "G";
            belirlilik7_1_maliyet_txt_baslik1_satir7.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir7.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl26.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir7);
            //---------------------------------------------------------------

            //panel24 içerisine baslik1 altında satır6 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir6 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir6.Name = "txtb1s6";
            Point txt_b1s6 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir6.Location = txt_b1s6;
            belirlilik7_1_maliyet_txt_baslik1_satir6.Text = "F";
            belirlilik7_1_maliyet_txt_baslik1_satir6.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir6.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl24.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir6);
            //---------------------------------------------------------------

            //panel22 içerisine baslik1 altında satır5 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir5 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir5.Name = "txtb1s5";
            Point txt_b1s5 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir5.Location = txt_b1s5;
            belirlilik7_1_maliyet_txt_baslik1_satir5.Text = "E";
            belirlilik7_1_maliyet_txt_baslik1_satir5.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir5.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl22.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir5);
            //---------------------------------------------------------------

            //panel20 içerisine baslik1 altında satır4 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir4 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir4.Name = "txtb1s4";
            Point txt_b1s4 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir4.Location = txt_b1s4;
            belirlilik7_1_maliyet_txt_baslik1_satir4.Text = "D";
            belirlilik7_1_maliyet_txt_baslik1_satir4.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir4.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl20.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir4);
            //---------------------------------------------------------------

            //panel18 içerisine baslik1 altında satır3 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir3 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir3.Name = "txtb1s3";
            Point txt_b1s3 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir3.Location = txt_b1s3;
            belirlilik7_1_maliyet_txt_baslik1_satir3.Text = "C";
            belirlilik7_1_maliyet_txt_baslik1_satir3.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir3.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl18.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir3);
            //---------------------------------------------------------------

            //panel16 içerisine baslik1 altında satır2 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir2 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir2.Name = "txtb1s2";
            Point txt_b1s2 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir2.Location = txt_b1s2;
            belirlilik7_1_maliyet_txt_baslik1_satir2.Text = "B";
            belirlilik7_1_maliyet_txt_baslik1_satir2.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir2.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl16.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir2);
            //---------------------------------------------------------------

            //panel14 içerisine baslik1 altında satır1 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1_satir1 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1_satir1.Name = "txtb1s1";
            Point txt_b1s1 = new Point(18, 9);
            belirlilik7_1_maliyet_txt_baslik1_satir1.Location = txt_b1s1;
            belirlilik7_1_maliyet_txt_baslik1_satir1.Text = "A";
            belirlilik7_1_maliyet_txt_baslik1_satir1.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1_satir1.Size = new Size(174, 20);
            belirlilik7_1_maliyet_pl14.Controls.Add(belirlilik7_1_maliyet_txt_baslik1_satir1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik2 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(18, 24);
            belirlilik7_1_maliyet_txt_baslik2.Location = txt_baslik2;
            belirlilik7_1_maliyet_txt_baslik2.Text = "Başlık-2";
            belirlilik7_1_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik7_1_maliyet_txt_baslik2.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik2.Multiline = true;
            belirlilik7_1_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_txt_baslik2.Size = new Size(174, 51);
            belirlilik7_1_maliyet_pl13.Controls.Add(belirlilik7_1_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            belirlilik7_1_maliyet_txt_baslik1 = new TextBox();
            belirlilik7_1_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(18, 24);
            belirlilik7_1_maliyet_txt_baslik1.Location = txt_baslik1;
            belirlilik7_1_maliyet_txt_baslik1.Text = "Başlık-1";
            belirlilik7_1_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            belirlilik7_1_maliyet_txt_baslik1.MaxLength = 30;
            belirlilik7_1_maliyet_txt_baslik1.Multiline = true;
            belirlilik7_1_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_txt_baslik1.Size = new Size(174, 51);
            belirlilik7_1_maliyet_pl12.Controls.Add(belirlilik7_1_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel27 oluşturuldu satır-7-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(220, 374);
            belirlilik7_1_maliyet_pl27.Location = pl27k;
            belirlilik7_1_maliyet_pl27.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu satır-7-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(5, 374);
            belirlilik7_1_maliyet_pl26.Location = pl26k;
            belirlilik7_1_maliyet_pl26.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl26);
            //-----------------------------------------

            //panel25 oluşturuldu satır-6-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(220, 329);
            belirlilik7_1_maliyet_pl25.Location = pl25k;
            belirlilik7_1_maliyet_pl25.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl25);
            //-----------------------------------------

            //panel24 oluşturuldu satır-6-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(5, 329);
            belirlilik7_1_maliyet_pl24.Location = pl24k;
            belirlilik7_1_maliyet_pl24.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl24);
            //-----------------------------------------

            //panel23 oluşturuldu satır-5-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(220, 284);
            belirlilik7_1_maliyet_pl23.Location = pl23k;
            belirlilik7_1_maliyet_pl23.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu satır-5-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(5, 284);
            belirlilik7_1_maliyet_pl22.Location = pl22k;
            belirlilik7_1_maliyet_pl22.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu satır-4-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(220, 239);
            belirlilik7_1_maliyet_pl21.Location = pl21k;
            belirlilik7_1_maliyet_pl21.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu satır-4-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(5, 239);
            belirlilik7_1_maliyet_pl20.Location = pl20k;
            belirlilik7_1_maliyet_pl20.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl20);
            //-----------------------------------------

            //panel19 oluşturuldu satır-3-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(220, 194);
            belirlilik7_1_maliyet_pl19.Location = pl19k;
            belirlilik7_1_maliyet_pl19.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu satır-3-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(5, 194);
            belirlilik7_1_maliyet_pl18.Location = pl18k;
            belirlilik7_1_maliyet_pl18.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl18);
            //-----------------------------------------

            //panel17 oluşturuldu  satır-2-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(220, 149);
            belirlilik7_1_maliyet_pl17.Location = pl17k;
            belirlilik7_1_maliyet_pl17.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu satır-2-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(5, 149);
            belirlilik7_1_maliyet_pl16.Location = pl16k;
            belirlilik7_1_maliyet_pl16.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu satır-1-2 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(220, 104);
            belirlilik7_1_maliyet_pl15.Location = pl15k;
            belirlilik7_1_maliyet_pl15.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu satır-1-1 isimi arka planı orta kısım 
            belirlilik7_1_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 104);
            belirlilik7_1_maliyet_pl14.Location = pl14k;
            belirlilik7_1_maliyet_pl14.Size = new Size(209, 39);
            belirlilik7_1_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu başlık-2 arka planı orta kısım 
            belirlilik7_1_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(220, 3);
            belirlilik7_1_maliyet_pl13.Location = pl13k;
            belirlilik7_1_maliyet_pl13.Size = new Size(209, 95);
            belirlilik7_1_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu başlık-1 arka planı orta kısım 
            belirlilik7_1_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            belirlilik7_1_maliyet_pl12.Location = pl12k;
            belirlilik7_1_maliyet_pl12.Size = new Size(209, 95);
            belirlilik7_1_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl5.Controls.Add(belirlilik7_1_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            belirlilik7_1_maliyet_pl11.Name = "pl11";
            belirlilik7_1_maliyet_pl11.Size = new Size(65, 50);
            belirlilik7_1_maliyet_pl11.Dock = DockStyle.Left;
            belirlilik7_1_maliyet_pl11.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            belirlilik7_1_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl11.Click += new EventHandler(belirlilik7_1_maliyet_pl11_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            belirlilik7_1_maliyet_pl10.Name = "pl10";
            belirlilik7_1_maliyet_pl10.Size = new Size(65, 50);
            belirlilik7_1_maliyet_pl10.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_pl10.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            belirlilik7_1_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl10.Click += new EventHandler(belirlilik7_1_maliyet_pl10_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            belirlilik7_1_maliyet_pl9.Name = "pl9";
            belirlilik7_1_maliyet_pl9.Size = new Size(65, 50);
            belirlilik7_1_maliyet_pl9.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_pl9.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            belirlilik7_1_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl9.Click += new EventHandler(belirlilik7_1_maliyet_pl9_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            belirlilik7_1_maliyet_pl8.Name = "pl8";
            belirlilik7_1_maliyet_pl8.Size = new Size(65, 50);
            belirlilik7_1_maliyet_pl8.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_pl8.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            belirlilik7_1_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl8.Click += new EventHandler(belirlilik7_1_maliyet_pl8_Click);
            belirlilik7_1_maliyet_pl7.Controls.Add(belirlilik7_1_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            belirlilik7_1_maliyet_pl6.Name = "pl6";
            belirlilik7_1_maliyet_pl6.Size = new Size(65, 50);
            belirlilik7_1_maliyet_pl6.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_pl6.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            belirlilik7_1_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl6.Click += new EventHandler(belirlilik7_1_maliyet_pl6_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            belirlilik7_1_maliyet_btn3.Name = "btn3";
            belirlilik7_1_maliyet_btn3.Size = new Size(65, 50);
            belirlilik7_1_maliyet_btn3.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            belirlilik7_1_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_btn3.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            belirlilik7_1_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_btn3.Click += new EventHandler(belirlilik7_1_maliyet_btn3_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            belirlilik7_1_maliyet_btn2.Name = "btn2";
            belirlilik7_1_maliyet_btn2.Size = new Size(65, 50);
            belirlilik7_1_maliyet_btn2.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            belirlilik7_1_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik7_1_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik7_1_maliyet_btn2.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            belirlilik7_1_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_btn2.Click += new EventHandler(belirlilik7_1_maliyet_btn2_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            belirlilik7_1_maliyet_btn1.Name = "btn1";
            belirlilik7_1_maliyet_btn1.Size = new Size(65, 50);
            belirlilik7_1_maliyet_btn1.Dock = DockStyle.Right;
            belirlilik7_1_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            belirlilik7_1_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            belirlilik7_1_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            belirlilik7_1_maliyet_btn1.BackColor = Color.Transparent;
            belirlilik7_1_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            belirlilik7_1_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_btn1.Click += new EventHandler(belirlilik7_1_maliyet_btn1_Click);
            belirlilik7_1_maliyet_pl2.Controls.Add(belirlilik7_1_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            belirlilik7_1_maliyet_dr1.Name = "dr1";
            belirlilik7_1_maliyet_dr1.Size = new Size(851, 498);
            belirlilik7_1_maliyet_dr1.Dock = DockStyle.Fill;
            belirlilik7_1_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_dr1.AllowUserToAddRows = false;
            belirlilik7_1_maliyet_dr1.AllowUserToDeleteRows = false;
            belirlilik7_1_maliyet_dr1.AllowUserToResizeColumns = false;
            belirlilik7_1_maliyet_dr1.AllowUserToResizeRows = false;
            belirlilik7_1_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            belirlilik7_1_maliyet_dr1.RowHeadersVisible = false;
            belirlilik7_1_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            belirlilik7_1_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(belirlilik7_1_maliyet_dr1_CellEnter);
            belirlilik7_1_maliyet_tb1_2.Controls.Add(belirlilik7_1_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            belirlilik7_1_maliyet_pl7.Name = "pl7";
            belirlilik7_1_maliyet_pl7.Size = new Size(865, 50);
            belirlilik7_1_maliyet_pl7.Dock = DockStyle.Top;
            belirlilik7_1_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_tb1_2.Controls.Add(belirlilik7_1_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            belirlilik7_1_maliyet_pl5.Name = "pl5";
            belirlilik7_1_maliyet_pl5.Size = new Size(851, 498);
            belirlilik7_1_maliyet_pl5.Dock = DockStyle.Fill;
            belirlilik7_1_maliyet_pl5.AutoScroll = true;
            belirlilik7_1_maliyet_pl5.AutoSize = true;
            belirlilik7_1_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            belirlilik7_1_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_tb1_1.Controls.Add(belirlilik7_1_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            belirlilik7_1_maliyet_rt1.Name = "rt1";
            belirlilik7_1_maliyet_rt1.Size = new Size(851, 498);
            belirlilik7_1_maliyet_rt1.Dock = DockStyle.Fill;
            belirlilik7_1_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_rt1.Enabled = false;
            belirlilik7_1_maliyet_rt1.Text = "• Doğanın sunduğu olaylar yerine gerçek durumun ne olduğunu KV karar vermeden önce bilmektedir.\n• En iyi seçim en düşük getirisi olan seçeneği seçmektir.";
            belirlilik7_1_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            belirlilik7_1_maliyet_tb1_3.Controls.Add(belirlilik7_1_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            belirlilik7_1_maliyet_tb1_1.Name = "tb1_1";
            belirlilik7_1_maliyet_tb1_1.Text = "Tablo";
            belirlilik7_1_maliyet_tb1_1.Size = new Size(651, 50);
            belirlilik7_1_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_tb1.Controls.Add(belirlilik7_1_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            belirlilik7_1_maliyet_tb1_2.Name = "tb1_2";
            belirlilik7_1_maliyet_tb1_2.Text = "Veri Tabanı";
            belirlilik7_1_maliyet_tb1_2.Size = new Size(651, 50);
            belirlilik7_1_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_tb1.Controls.Add(belirlilik7_1_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            belirlilik7_1_maliyet_tb1_3.Name = "tb1_3";
            belirlilik7_1_maliyet_tb1_3.Text = "Konu Anlatımı";
            belirlilik7_1_maliyet_tb1_3.Size = new Size(651, 50);
            belirlilik7_1_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_tb1.Controls.Add(belirlilik7_1_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            belirlilik7_1_maliyet_tb1.Name = "tb1";
            belirlilik7_1_maliyet_tb1.Size = new Size(651, 50);
            belirlilik7_1_maliyet_tb1.Dock = DockStyle.Fill;
            belirlilik7_1_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            belirlilik7_1_maliyet_pl3.Controls.Add(belirlilik7_1_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            belirlilik7_1_maliyet_pl4.Name = "pl4";
            belirlilik7_1_maliyet_pl4.Size = new Size(865, 50);
            belirlilik7_1_maliyet_pl4.Dock = DockStyle.Bottom;
            belirlilik7_1_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl4.MouseUp += new MouseEventHandler(belirlilik7_1_maliyet_pl4_MouseUp);
            belirlilik7_1_maliyet_pl4.MouseMove += new MouseEventHandler(belirlilik7_1_maliyet_pl4_MouseMove);
            belirlilik7_1_maliyet_pl4.MouseDown += new MouseEventHandler(belirlilik7_1_maliyet_pl4_MouseDown);
            this.Controls.Add(belirlilik7_1_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            belirlilik7_1_maliyet_pl3.Name = "pl3";
            belirlilik7_1_maliyet_pl3.Size = new Size(865, 530);
            belirlilik7_1_maliyet_pl3.Dock = DockStyle.Top;
            belirlilik7_1_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik7_1_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            belirlilik7_1_maliyet_pl2.Name = "pl2";
            belirlilik7_1_maliyet_pl2.Size = new Size(865, 50);
            belirlilik7_1_maliyet_pl2.Dock = DockStyle.Top;
            belirlilik7_1_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(belirlilik7_1_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            belirlilik7_1_maliyet_pl1.Name = "pl1";
            belirlilik7_1_maliyet_pl1.Size = new Size(865, 50);
            belirlilik7_1_maliyet_pl1.Dock = DockStyle.Top;
            belirlilik7_1_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            belirlilik7_1_maliyet_pl1.BackgroundImage = Properties.Resources.belirlilikmaliyet;
            belirlilik7_1_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            belirlilik7_1_maliyet_pl1.MouseUp += new MouseEventHandler(belirlilik7_1_maliyet_pl1_MouseUp);
            belirlilik7_1_maliyet_pl1.MouseMove += new MouseEventHandler(belirlilik7_1_maliyet_pl1_MouseMove);
            belirlilik7_1_maliyet_pl1.MouseDown += new MouseEventHandler(belirlilik7_1_maliyet_pl1_MouseDown);
            this.Controls.Add(belirlilik7_1_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //belirlilik2_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik2_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik2_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik2_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 7; i++)
            {
                belirlilik2_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik3_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik3_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik3_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik3_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 9; i++)
            {
                belirlilik3_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik4_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik4_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik4_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik4_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 11; i++)
            {
                belirlilik4_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik5_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik5_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik5_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik5_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 13; i++)
            {
                belirlilik5_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik6_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik6_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik6_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik6_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 15; i++)
            {
                belirlilik6_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik7_1_maliyet veritabanına listelemek için kullanılır
        public void belirlilik7_1_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From belirlilik7_1_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            belirlilik7_1_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 17; i++)
            {
                belirlilik7_1_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //belirlilik2_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik2_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik2_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik2_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik2_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik2_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik2_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik2_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik2_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik2_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik2_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik2_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik2_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik2_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik2_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //belirlilik2_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik2_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik2_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik2_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik2_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik2_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik2_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik2_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text);
                if (txtb2s1 < txtb2s2)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }

                baglanti.Open();
                string sorgu = "Insert into belirlilik2_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Veri_1,Veri_2,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Veri_1,@Veri_2,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik2_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik2_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik2_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik2_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());

                belirlilik2_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik2_1_maliyet_listele();

                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik2_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik2_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik2_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik2_1_maliyet where Id=" + belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik2_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik2_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text);
            if (txtb2s1 < txtb2s2)
            {
                kucukolanibul = Convert.ToInt32(belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1)
            {
                kucukolanibul = Convert.ToInt32(belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik2_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Veri_1=@Veri_1,Veri_2=@Veri_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik2_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik2_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik2_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik2_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik2_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik2_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());

            belirlilik2_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik2_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik2_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik2_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik2_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik2_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik2_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik2_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik2_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------


        //belirlilik3_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik3_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik3_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik3_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik3_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik3_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik3_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik3_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik3_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik3_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik3_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik3_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik3_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik3_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik3_1_maliyet_pl18.Controls["txtb1s3"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                belirlilik3_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //belirlilik3_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik3_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik3_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik3_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik3_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik3_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik3_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik3_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text);
                int txtb2s3 = Convert.ToInt32(belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text);
                if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }
                else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text);
                }
                baglanti.Open();
                string sorgu = "Insert into belirlilik3_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Alt_Baslik3,Veri_1,Veri_2,Veri_3,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Alt_Baslik3,@Veri_1,@Veri_2,@Veri_3,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik3_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik3_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik3_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik3_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik3_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_3", belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                belirlilik3_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik3_1_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik3_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik3_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik3_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(198, 79, 115);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select Alt_Baslik3 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik3.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select Veri_3 From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri3.Value2 = komut9.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik3_1_maliyet where Id=" + belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik3_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik3_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();
            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text);
            int txtb2s3 = Convert.ToInt32(belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text);
            if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3)
            {
                kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3)
            {
                kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2)
            {
                kucukolanibul = Convert.ToInt32(belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text);
            }

            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik3_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Alt_Baslik3=@Alt_Baslik3,Veri_1=@Veri_1,Veri_2=@Veri_2,Veri_3=@Veri_3,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik3_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik3_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik3_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik3_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik3_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik3_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik3_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_3", belirlilik3_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());

            belirlilik3_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik3_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik3_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik3_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik3_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik3_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik3_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik3_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik3_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik4_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik4_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik4_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik4_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik4_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik4_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik4_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik4_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik4_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik4_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik4_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik4_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik4_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik4_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik4_1_maliyet_pl18.Controls["txtb1s3"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik4_1_maliyet_pl20.Controls["txtb1s4"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                belirlilik4_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //belirlilik4_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik4_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik4_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik4_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik4_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik4_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik4_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik4_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text);
                int txtb2s3 = Convert.ToInt32(belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text);
                int txtb2s4 = Convert.ToInt32(belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text);
                if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2  <txtb2s4)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }
                else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text);
                }
                else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text);
                }
                baglanti.Open();
                string sorgu = "Insert into belirlilik4_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Alt_Baslik3,Alt_Baslik4,Veri_1,Veri_2,Veri_3,Veri_4,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Alt_Baslik3,@Alt_Baslik4,@Veri_1,@Veri_2,@Veri_3,@Veri_4,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik4_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik4_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik4_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik4_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik4_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik4_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_3", belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_4", belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                belirlilik4_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik4_1_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik4_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik4_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik4_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(198, 79, 115);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(192, 255, 255);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select Alt_Baslik3 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik3.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select Alt_Baslik4 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik4.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select Veri_3 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri3.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select Veri_4 From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri4.Value2 = komut11.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik4_1_maliyet where Id=" + belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik4_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik4_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();
            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text);
            int txtb2s3 = Convert.ToInt32(belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text);
            int txtb2s4 = Convert.ToInt32(belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text);
            if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4)
            {
                kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4)
            {
                kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4)
            {
                kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text);
            }
            else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3)
            {
                kucukolanibul = Convert.ToInt32(belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text);
            }

            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik4_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Alt_Baslik3=@Alt_Baslik3,Alt_Baslik4=@Alt_Baslik4,Veri_1=@Veri_1,Veri_2=@Veri_2,Veri_3=@Veri_3,Veri_4=@Veri_4,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik4_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik4_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik4_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik4_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik4_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik4_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik4_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik4_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_3", belirlilik4_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_4", belirlilik4_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());
            belirlilik4_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik4_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik4_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik4_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik4_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik4_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik4_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik4_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik4_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik5_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik5_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik5_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik5_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik5_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik5_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik5_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik5_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik5_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik5_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik5_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik5_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik5_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik5_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik5_1_maliyet_pl18.Controls["txtb1s3"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik5_1_maliyet_pl20.Controls["txtb1s4"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik5_1_maliyet_pl22.Controls["txtb1s5"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                belirlilik5_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //belirlilik5_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik5_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik5_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik5_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik5_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik5_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik5_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik5_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text);
                int txtb2s3 = Convert.ToInt32(belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text);
                int txtb2s4 = Convert.ToInt32(belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text);
                int txtb2s5 = Convert.ToInt32(belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text);
                if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }
                else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text);
                }
                else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text);
                }
                else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text);
                }
                baglanti.Open();
                string sorgu = "Insert into belirlilik5_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Alt_Baslik3,Alt_Baslik4,Alt_Baslik5,Veri_1,Veri_2,Veri_3,Veri_4,Veri_5,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Alt_Baslik3,@Alt_Baslik4,@Alt_Baslik5,@Veri_1,@Veri_2,@Veri_3,@Veri_4,@Veri_5,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik5_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik5_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik5_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik5_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik5_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik5_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik5_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_3", belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_4", belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_5", belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                belirlilik5_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik5_1_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik5_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik5_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik5_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(198, 79, 115);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(192, 255, 255);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(0, 192, 192);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select Alt_Baslik3 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik3.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select Alt_Baslik4 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik4.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select Alt_Baslik5 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik5.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select Veri_3 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri3.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select Veri_4 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri4.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select Veri_5 From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri5.Value2 = komut13.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik5_1_maliyet where Id=" + belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik5_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik5_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();
            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text);
            int txtb2s3 = Convert.ToInt32(belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text);
            int txtb2s4 = Convert.ToInt32(belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text);
            int txtb2s5 = Convert.ToInt32(belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text);
            if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5)
            {
                kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5)
            {
                kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5)
            {
                kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text);
            }
            else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5)
            {
                kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text);
            }
            else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4)
            {
                kucukolanibul = Convert.ToInt32(belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text);
            }
            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik5_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Alt_Baslik3=@Alt_Baslik3,Alt_Baslik4=@Alt_Baslik4,Alt_Baslik5=@Alt_Baslik5,Veri_1=@Veri_1,Veri_2=@Veri_2,Veri_3=@Veri_3,Veri_4=@Veri_4,Veri_5=@Veri_5,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik5_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik5_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik5_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik5_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik5_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik5_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik5_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik5_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik5_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_3", belirlilik5_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_4", belirlilik5_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_5", belirlilik5_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());
            belirlilik5_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik5_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik5_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik5_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik5_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik5_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik5_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik5_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik5_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik6_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik6_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik6_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik6_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik6_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik6_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik6_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik6_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik6_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik6_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik6_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik6_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik6_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik6_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik6_1_maliyet_pl18.Controls["txtb1s3"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik6_1_maliyet_pl20.Controls["txtb1s4"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik6_1_maliyet_pl22.Controls["txtb1s5"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                belirlilik6_1_maliyet_pl24.Controls["txtb1s6"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                belirlilik6_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //belirlilik6_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik6_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik6_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik6_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik6_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik6_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik6_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik6_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text);
                int txtb2s3 = Convert.ToInt32(belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text);
                int txtb2s4 = Convert.ToInt32(belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text);
                int txtb2s5 = Convert.ToInt32(belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text);
                int txtb2s6 = Convert.ToInt32(belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text);
                if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5 && txtb2s1 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5 && txtb2s2 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }
                else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5 && txtb2s3 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text);
                }
                else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5 && txtb2s4 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text);
                }
                else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4 && txtb2s5 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text);
                }
                else if (txtb2s6 < txtb2s1 && txtb2s6 < txtb2s2 && txtb2s6 < txtb2s3 && txtb2s6 < txtb2s4 && txtb2s6 < txtb2s5)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text);
                }
                baglanti.Open();
                string sorgu = "Insert into belirlilik6_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Alt_Baslik3,Alt_Baslik4,Alt_Baslik5,Alt_Baslik6,Veri_1,Veri_2,Veri_3,Veri_4,Veri_5,Veri_6,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Alt_Baslik3,@Alt_Baslik4,@Alt_Baslik5,@Alt_Baslik6,@Veri_1,@Veri_2,@Veri_3,@Veri_4,@Veri_5,@Veri_6,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik6_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik6_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik6_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik6_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik6_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik6_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik6_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik6", belirlilik6_1_maliyet_pl24.Controls["txtb1s6"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_3", belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_4", belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_5", belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_6", belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                belirlilik6_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik6_1_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik6_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik6_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik6_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(198, 79, 115);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(192, 255, 255);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(0, 192, 192);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(220, 211, 103);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select Alt_Baslik3 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik3.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select Alt_Baslik4 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik4.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select Alt_Baslik5 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik5.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select Alt_Baslik6 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik6.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select Veri_3 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri3.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select Veri_4 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri4.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select Veri_5 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri5.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select Veri_6 From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri6.Value2 = komut15.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik6_1_maliyet where Id=" + belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik6_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik6_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();
            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text);
            int txtb2s3 = Convert.ToInt32(belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text);
            int txtb2s4 = Convert.ToInt32(belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text);
            int txtb2s5 = Convert.ToInt32(belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text);
            int txtb2s6 = Convert.ToInt32(belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text);
            if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5 && txtb2s1 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5 && txtb2s2 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5 && txtb2s3 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text);
            }
            else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5 && txtb2s4 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text);
            }
            else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4 && txtb2s5 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text);
            }
            else if (txtb2s6 < txtb2s1 && txtb2s6 < txtb2s2 && txtb2s6 < txtb2s3 && txtb2s6 < txtb2s4 && txtb2s6 < txtb2s5)
            {
                kucukolanibul = Convert.ToInt32(belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text);
            }
            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik6_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Alt_Baslik3=@Alt_Baslik3,Alt_Baslik4=@Alt_Baslik4,Alt_Baslik5=@Alt_Baslik5,Alt_Baslik6=@Alt_Baslik6,Veri_1=@Veri_1,Veri_2=@Veri_2,Veri_3=@Veri_3,Veri_4=@Veri_4,Veri_5=@Veri_5,Veri_6=@Veri_6,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik6_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik6_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik6_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik6_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik6_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik6_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik6_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik6", belirlilik6_1_maliyet_pl24.Controls["txtb1s6"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik6_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik6_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_3", belirlilik6_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_4", belirlilik6_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_5", belirlilik6_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_6", belirlilik6_1_maliyet_pl25.Controls["txtb2s6"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());
            belirlilik6_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik6_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik6_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik6_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik6_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik6_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik6_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik6_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik6_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik7_1_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik7_1_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik7_1_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik7_1_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik7_1_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void belirlilik7_1_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void belirlilik7_1_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void belirlilik7_1_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //belirlilik7_1_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void belirlilik7_1_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belirlilik7_1_maliyet_pl12.Controls["txtbaslik1"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                belirlilik7_1_maliyet_pl13.Controls["txtbaslik2"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                belirlilik7_1_maliyet_pl14.Controls["txtb1s1"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                belirlilik7_1_maliyet_pl16.Controls["txtb1s2"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                belirlilik7_1_maliyet_pl18.Controls["txtb1s3"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                belirlilik7_1_maliyet_pl20.Controls["txtb1s4"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                belirlilik7_1_maliyet_pl22.Controls["txtb1s5"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                belirlilik7_1_maliyet_pl24.Controls["txtb1s6"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                belirlilik7_1_maliyet_pl26.Controls["txtb1s7"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                belirlilik7_1_maliyet_pl4.Controls["sonuc"].Text = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //belirlilik7_1_maliyet formu kapatmak için oluşturulmuş button1
        private void belirlilik7_1_maliyet_btn1_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik7_1_maliyet formu altaalmak için oluşturulmuş button2
        private void belirlilik7_1_maliyet_btn2_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        //belirlilik7_1_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void belirlilik7_1_maliyet_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Karar_Modelleri k = new Karar_Modelleri();
                k.Show();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik7_1_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void belirlilik7_1_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                int kucukolanibul = 0;
                int txtb2s1 = Convert.ToInt32(belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text);
                int txtb2s2 = Convert.ToInt32(belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text);
                int txtb2s3 = Convert.ToInt32(belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text);
                int txtb2s4 = Convert.ToInt32(belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text);
                int txtb2s5 = Convert.ToInt32(belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text);
                int txtb2s6 = Convert.ToInt32(belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text);
                int txtb2s7 = Convert.ToInt32(belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text);

                if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5 && txtb2s1 < txtb2s6 && txtb2s1 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text);
                }
                else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5 && txtb2s2 < txtb2s6 && txtb2s2 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text);
                }
                else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5 && txtb2s3 < txtb2s6 && txtb2s3 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text);
                }
                else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5 && txtb2s4 < txtb2s6 && txtb2s4 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text);
                }
                else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4 && txtb2s5 < txtb2s6 && txtb2s5 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text);
                }
                else if (txtb2s6 < txtb2s1 && txtb2s6 < txtb2s2 && txtb2s6 < txtb2s3 && txtb2s6 < txtb2s4 && txtb2s6 < txtb2s5 && txtb2s6 < txtb2s7)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text);
                }
                else if (txtb2s7 < txtb2s1 && txtb2s7 < txtb2s2 && txtb2s7 < txtb2s3 && txtb2s7 < txtb2s4 && txtb2s7 < txtb2s5 && txtb2s7 < txtb2s6)
                {
                    kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text);
                }
                baglanti.Open();
                string sorgu = "Insert into belirlilik7_1_maliyet(Baslik_1,Baslik_2,Alt_Baslik1,Alt_Baslik2,Alt_Baslik3,Alt_Baslik4,Alt_Baslik5,Alt_Baslik6,Alt_Baslik7,Veri_1,Veri_2,Veri_3,Veri_4,Veri_5,Veri_6,Veri_7,maliyet) values(@Baslik_1,@Baslik_2,@Alt_Baslik1,@Alt_Baslik2,@Alt_Baslik3,@Alt_Baslik4,@Alt_Baslik5,@Alt_Baslik6,@Alt_Baslik7,@Veri_1,@Veri_2,@Veri_3,@Veri_4,@Veri_5,@Veri_6,@Veri_7,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Baslik_1", belirlilik7_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@Baslik_2", belirlilik7_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik7_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik7_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik7_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik7_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik7_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik6", belirlilik7_1_maliyet_pl24.Controls["txtb1s6"].Text.ToString());
                komut.Parameters.AddWithValue("@Alt_Baslik7", belirlilik7_1_maliyet_pl26.Controls["txtb1s7"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_1", belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_2", belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_3", belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_4", belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_5", belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_6", belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text.ToString());
                komut.Parameters.AddWithValue("@Veri_7", belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                belirlilik7_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                belirlilik7_1_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik7_1_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void belirlilik7_1_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //belirlilik7_1_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Belirlilik Altında Karar Verme";
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(197, 218, 239);
                }
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select Baslik_1 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select Baslik_2 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(136, 228, 33);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(198, 79, 115);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(192, 255, 255);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(0, 192, 192);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(220, 211, 103);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(102, 170, 57);
                }

                OleDbCommand komut3 = new OleDbCommand("Select Alt_Baslik1 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select Alt_Baslik2 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select Alt_Baslik3 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik3.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select Alt_Baslik4 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik4.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select Alt_Baslik5 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik5.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select Alt_Baslik6 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik6.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select Alt_Baslik7 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik7.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select Veri_1 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                veri1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select Veri_2 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select Veri_3 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri3.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select Veri_4 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri4.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select Veri_5 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri5.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select Veri_6 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri6.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select Veri_7 From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri7.Value2 = komut17.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan.Interior.Color = System.Drawing.Color.FromArgb(199, 86, 122);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut7 = new OleDbCommand("Select maliyet From belirlilik7_1_maliyet where Id=" + belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                maliyet.Value2 = komut7.ExecuteScalar().ToString();
                //---------------------------------------------------------------------------------------
                baglanti.Close();
                uygulama.Visible = true;
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //belirlilik7_1_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void belirlilik7_1_maliyet_pl9_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();
            int kucukolanibul = 0;
            int txtb2s1 = Convert.ToInt32(belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text);
            int txtb2s2 = Convert.ToInt32(belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text);
            int txtb2s3 = Convert.ToInt32(belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text);
            int txtb2s4 = Convert.ToInt32(belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text);
            int txtb2s5 = Convert.ToInt32(belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text);
            int txtb2s6 = Convert.ToInt32(belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text);
            int txtb2s7 = Convert.ToInt32(belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text);

            if (txtb2s1 < txtb2s2 && txtb2s1 < txtb2s3 && txtb2s1 < txtb2s4 && txtb2s1 < txtb2s5 && txtb2s1 < txtb2s6 && txtb2s1 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text);
            }
            else if (txtb2s2 < txtb2s1 && txtb2s2 < txtb2s3 && txtb2s2 < txtb2s4 && txtb2s2 < txtb2s5 && txtb2s2 < txtb2s6 && txtb2s2 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text);
            }
            else if (txtb2s3 < txtb2s1 && txtb2s3 < txtb2s2 && txtb2s3 < txtb2s4 && txtb2s3 < txtb2s5 && txtb2s3 < txtb2s6 && txtb2s3 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text);
            }
            else if (txtb2s4 < txtb2s1 && txtb2s4 < txtb2s2 && txtb2s4 < txtb2s3 && txtb2s4 < txtb2s5 && txtb2s4 < txtb2s6 && txtb2s4 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text);
            }
            else if (txtb2s5 < txtb2s1 && txtb2s5 < txtb2s2 && txtb2s5 < txtb2s3 && txtb2s5 < txtb2s4 && txtb2s5 < txtb2s6 && txtb2s5 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text);
            }
            else if (txtb2s6 < txtb2s1 && txtb2s6 < txtb2s2 && txtb2s6 < txtb2s3 && txtb2s6 < txtb2s4 && txtb2s6 < txtb2s5 && txtb2s6 < txtb2s7)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text);
            }
            else if (txtb2s7 < txtb2s1 && txtb2s7 < txtb2s2 && txtb2s7 < txtb2s3 && txtb2s7 < txtb2s4 && txtb2s7 < txtb2s5 && txtb2s7 < txtb2s6)
            {
                kucukolanibul = Convert.ToInt32(belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text);
            }
            baglanti.Open();
            komut = new OleDbCommand("UPDATE belirlilik7_1_maliyet SET Baslik_1=@Baslik_1,Baslik_2=@Baslik_2,Alt_Baslik1=@Alt_Baslik1,Alt_Baslik2=@Alt_Baslik2,Alt_Baslik3=@Alt_Baslik3,Alt_Baslik4=@Alt_Baslik4,Alt_Baslik5=@Alt_Baslik5,Alt_Baslik6=@Alt_Baslik6,Alt_Baslik7=@Alt_Baslik7,Veri_1=@Veri_1,Veri_2=@Veri_2,Veri_3=@Veri_3,Veri_4=@Veri_4,Veri_5=@Veri_5,Veri_6=@Veri_6,Veri_7=@Veri_7,maliyet=@maliyet WHERE Id=@Id", baglanti);

            komut.Parameters.AddWithValue("@Baslik_1", belirlilik7_1_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
            komut.Parameters.AddWithValue("@Baslik_2", belirlilik7_1_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik1", belirlilik7_1_maliyet_pl14.Controls["txtb1s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik2", belirlilik7_1_maliyet_pl16.Controls["txtb1s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik3", belirlilik7_1_maliyet_pl18.Controls["txtb1s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik4", belirlilik7_1_maliyet_pl20.Controls["txtb1s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik5", belirlilik7_1_maliyet_pl22.Controls["txtb1s5"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik6", belirlilik7_1_maliyet_pl24.Controls["txtb1s6"].Text.ToString());
            komut.Parameters.AddWithValue("@Alt_Baslik7", belirlilik7_1_maliyet_pl26.Controls["txtb1s7"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_1", belirlilik7_1_maliyet_pl15.Controls["txtb2s1"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_2", belirlilik7_1_maliyet_pl17.Controls["txtb2s2"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_3", belirlilik7_1_maliyet_pl19.Controls["txtb2s3"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_4", belirlilik7_1_maliyet_pl21.Controls["txtb2s4"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_5", belirlilik7_1_maliyet_pl23.Controls["txtb2s5"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_6", belirlilik7_1_maliyet_pl25.Controls["txtb2s6"].Text.ToString());
            komut.Parameters.AddWithValue("@Veri_7", belirlilik7_1_maliyet_pl27.Controls["txtb2s7"].Text.ToString());
            komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
            komut.Parameters.AddWithValue("@Id", id.ToString());
            belirlilik7_1_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            tablo.Clear();
            belirlilik7_1_maliyet_listele();
            MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik7_1_maliyet silme yapmak için oluşturulmuş panel10
        private void belirlilik7_1_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = belirlilik7_1_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from belirlilik7_1_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            belirlilik7_1_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //belirlilik7_1_maliyet hakkında kısmı için panel11 oluşturuldu
        private void belirlilik7_1_maliyet_pl11_Click(object sender, EventArgs e)
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
        //-------------------------------------------------

        private void BelirlilikAltındaKararVermeMaliyet_Load(object sender, EventArgs e)
        {
            try
            {
                if (Karar_Modelleri.sayı == "Satır:2-Sütun:1")
                {
                    formortala();
                    belirlilik2_1_maliyet();
                    belirlilik2_1_maliyet_listele();
                }
                if (Karar_Modelleri.sayı == "Satır:3-Sütun:1")
                {
                    formortala();
                    belirlilik3_1_maliyet();
                    belirlilik3_1_maliyet_listele();
                }
                if (Karar_Modelleri.sayı == "Satır:4-Sütun:1")
                {
                    formortala();
                    belirlilik4_1_maliyet();
                    belirlilik4_1_maliyet_listele();
                }
                if (Karar_Modelleri.sayı == "Satır:5-Sütun:1")
                {
                    formortala();
                    belirlilik5_1_maliyet();
                    belirlilik5_1_maliyet_listele();
                }
                if (Karar_Modelleri.sayı == "Satır:6-Sütun:1")
                {
                    formortala();
                    belirlilik6_1_maliyet();
                    belirlilik6_1_maliyet_listele();
                }
                if (Karar_Modelleri.sayı == "Satır:7-Sütun:1")
                {
                    formortala();
                    belirlilik7_1_maliyet();
                    belirlilik7_1_maliyet_listele();
                }
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
    }
}
