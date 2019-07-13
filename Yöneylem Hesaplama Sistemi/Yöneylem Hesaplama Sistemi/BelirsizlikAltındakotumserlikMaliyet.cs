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
    public partial class BelirsizlikAltındakotumserlikMaliyet : Form
    {
        public BelirsizlikAltındakotumserlikMaliyet()
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

        //kotumserlik2_3_maliyet form nesneleri
        Panel kotumserlik2_3_maliyet_pl1 = new Panel();
        Panel kotumserlik2_3_maliyet_pl2 = new Panel();
        Panel kotumserlik2_3_maliyet_pl3 = new Panel();
        Panel kotumserlik2_3_maliyet_pl4 = new Panel();
        Panel kotumserlik2_3_maliyet_pl5 = new Panel();
        Panel kotumserlik2_3_maliyet_pl6 = new Panel();
        Panel kotumserlik2_3_maliyet_pl7 = new Panel();
        Panel kotumserlik2_3_maliyet_pl8 = new Panel();
        Panel kotumserlik2_3_maliyet_pl9 = new Panel();
        Panel kotumserlik2_3_maliyet_pl10 = new Panel();
        Panel kotumserlik2_3_maliyet_pl11 = new Panel();
        Panel kotumserlik2_3_maliyet_pl12 = new Panel();
        Panel kotumserlik2_3_maliyet_pl13 = new Panel();
        Panel kotumserlik2_3_maliyet_pl14 = new Panel();
        Panel kotumserlik2_3_maliyet_pl15 = new Panel();
        Panel kotumserlik2_3_maliyet_pl16 = new Panel();
        Panel kotumserlik2_3_maliyet_pl17 = new Panel();
        Panel kotumserlik2_3_maliyet_pl18 = new Panel();
        Panel kotumserlik2_3_maliyet_pl19 = new Panel();
        Panel kotumserlik2_3_maliyet_pl20 = new Panel();
        Panel kotumserlik2_3_maliyet_pl21 = new Panel();
        Panel kotumserlik2_3_maliyet_pl22 = new Panel();
        Panel kotumserlik2_3_maliyet_pl23 = new Panel();
        Panel kotumserlik2_3_maliyet_pl24 = new Panel();
        Panel kotumserlik2_3_maliyet_pl25 = new Panel();
        Panel kotumserlik2_3_maliyet_pl26 = new Panel();
        Panel kotumserlik2_3_maliyet_pl27 = new Panel();
        Panel kotumserlik2_3_maliyet_pl28 = new Panel();
        Panel kotumserlik2_3_maliyet_pl29 = new Panel();
        Panel kotumserlik2_3_maliyet_pl30 = new Panel();
        TabControl kotumserlik2_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik2_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik2_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik2_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik2_3_maliyet_txt_baslik1;
        TextBox kotumserlik2_3_maliyet_txt_baslik2;
        TextBox kotumserlik2_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik2_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik2_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik2_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik2_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik2_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik2_3_maliyet_txt_f2sonuc;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik2_3_maliyet_txt_veri6;
        Label kotumserlik2_3_maliyet_sonucbaslik;
        Label kotumserlik2_3_maliyet_sonuc;
        Label kotumserlik2_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik2_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik2_3_maliyet_btn1 = new Button();
        Button kotumserlik2_3_maliyet_btn2 = new Button();
        Button kotumserlik2_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik2_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik3_3_maliyet form nesneleri
        Panel kotumserlik3_3_maliyet_pl1 = new Panel();
        Panel kotumserlik3_3_maliyet_pl2 = new Panel();
        Panel kotumserlik3_3_maliyet_pl3 = new Panel();
        Panel kotumserlik3_3_maliyet_pl4 = new Panel();
        Panel kotumserlik3_3_maliyet_pl5 = new Panel();
        Panel kotumserlik3_3_maliyet_pl6 = new Panel();
        Panel kotumserlik3_3_maliyet_pl7 = new Panel();
        Panel kotumserlik3_3_maliyet_pl8 = new Panel();
        Panel kotumserlik3_3_maliyet_pl9 = new Panel();
        Panel kotumserlik3_3_maliyet_pl10 = new Panel();
        Panel kotumserlik3_3_maliyet_pl11 = new Panel();
        Panel kotumserlik3_3_maliyet_pl12 = new Panel();
        Panel kotumserlik3_3_maliyet_pl13 = new Panel();
        Panel kotumserlik3_3_maliyet_pl14 = new Panel();
        Panel kotumserlik3_3_maliyet_pl15 = new Panel();
        Panel kotumserlik3_3_maliyet_pl16 = new Panel();
        Panel kotumserlik3_3_maliyet_pl17 = new Panel();
        Panel kotumserlik3_3_maliyet_pl18 = new Panel();
        Panel kotumserlik3_3_maliyet_pl19 = new Panel();
        Panel kotumserlik3_3_maliyet_pl20 = new Panel();
        Panel kotumserlik3_3_maliyet_pl21 = new Panel();
        Panel kotumserlik3_3_maliyet_pl22 = new Panel();
        Panel kotumserlik3_3_maliyet_pl23 = new Panel();
        Panel kotumserlik3_3_maliyet_pl24 = new Panel();
        Panel kotumserlik3_3_maliyet_pl25 = new Panel();
        Panel kotumserlik3_3_maliyet_pl26 = new Panel();
        Panel kotumserlik3_3_maliyet_pl27 = new Panel();
        Panel kotumserlik3_3_maliyet_pl28 = new Panel();
        Panel kotumserlik3_3_maliyet_pl29 = new Panel();
        Panel kotumserlik3_3_maliyet_pl30 = new Panel();
        Panel kotumserlik3_3_maliyet_pl31 = new Panel();
        Panel kotumserlik3_3_maliyet_pl32 = new Panel();
        Panel kotumserlik3_3_maliyet_pl33 = new Panel();
        Panel kotumserlik3_3_maliyet_pl34 = new Panel();
        Panel kotumserlik3_3_maliyet_pl35 = new Panel();
        TabControl kotumserlik3_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik3_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik3_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik3_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik3_3_maliyet_txt_baslik1;
        TextBox kotumserlik3_3_maliyet_txt_baslik2;
        TextBox kotumserlik3_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik3_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik3_3_maliyet_txt_altbaslik3;
        TextBox kotumserlik3_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik3_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik3_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik3_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik3_3_maliyet_txt_f2sonuc;
        TextBox kotumserlik3_3_maliyet_txt_f3sonuc;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri6;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri7;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri8;
        NumericUpDown kotumserlik3_3_maliyet_txt_veri9;
        Label kotumserlik3_3_maliyet_sonucbaslik;
        Label kotumserlik3_3_maliyet_sonuc;
        Label kotumserlik3_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik3_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik3_3_maliyet_btn1 = new Button();
        Button kotumserlik3_3_maliyet_btn2 = new Button();
        Button kotumserlik3_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik3_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik4_3_maliyet form nesneleri
        Panel kotumserlik4_3_maliyet_pl1 = new Panel();
        Panel kotumserlik4_3_maliyet_pl2 = new Panel();
        Panel kotumserlik4_3_maliyet_pl3 = new Panel();
        Panel kotumserlik4_3_maliyet_pl4 = new Panel();
        Panel kotumserlik4_3_maliyet_pl5 = new Panel();
        Panel kotumserlik4_3_maliyet_pl6 = new Panel();
        Panel kotumserlik4_3_maliyet_pl7 = new Panel();
        Panel kotumserlik4_3_maliyet_pl8 = new Panel();
        Panel kotumserlik4_3_maliyet_pl9 = new Panel();
        Panel kotumserlik4_3_maliyet_pl10 = new Panel();
        Panel kotumserlik4_3_maliyet_pl11 = new Panel();
        Panel kotumserlik4_3_maliyet_pl12 = new Panel();
        Panel kotumserlik4_3_maliyet_pl13 = new Panel();
        Panel kotumserlik4_3_maliyet_pl14 = new Panel();
        Panel kotumserlik4_3_maliyet_pl15 = new Panel();
        Panel kotumserlik4_3_maliyet_pl16 = new Panel();
        Panel kotumserlik4_3_maliyet_pl17 = new Panel();
        Panel kotumserlik4_3_maliyet_pl18 = new Panel();
        Panel kotumserlik4_3_maliyet_pl19 = new Panel();
        Panel kotumserlik4_3_maliyet_pl20 = new Panel();
        Panel kotumserlik4_3_maliyet_pl21 = new Panel();
        Panel kotumserlik4_3_maliyet_pl22 = new Panel();
        Panel kotumserlik4_3_maliyet_pl23 = new Panel();
        Panel kotumserlik4_3_maliyet_pl24 = new Panel();
        Panel kotumserlik4_3_maliyet_pl25 = new Panel();
        Panel kotumserlik4_3_maliyet_pl26 = new Panel();
        Panel kotumserlik4_3_maliyet_pl27 = new Panel();
        Panel kotumserlik4_3_maliyet_pl28 = new Panel();
        Panel kotumserlik4_3_maliyet_pl29 = new Panel();
        Panel kotumserlik4_3_maliyet_pl30 = new Panel();
        Panel kotumserlik4_3_maliyet_pl31 = new Panel();
        Panel kotumserlik4_3_maliyet_pl32 = new Panel();
        Panel kotumserlik4_3_maliyet_pl33 = new Panel();
        Panel kotumserlik4_3_maliyet_pl34 = new Panel();
        Panel kotumserlik4_3_maliyet_pl35 = new Panel();
        Panel kotumserlik4_3_maliyet_pl36 = new Panel();
        Panel kotumserlik4_3_maliyet_pl37 = new Panel();
        Panel kotumserlik4_3_maliyet_pl38 = new Panel();
        Panel kotumserlik4_3_maliyet_pl39 = new Panel();
        Panel kotumserlik4_3_maliyet_pl40 = new Panel();
        TabControl kotumserlik4_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik4_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik4_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik4_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik4_3_maliyet_txt_baslik1;
        TextBox kotumserlik4_3_maliyet_txt_baslik2;
        TextBox kotumserlik4_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik4_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik4_3_maliyet_txt_altbaslik3;
        TextBox kotumserlik4_3_maliyet_txt_altbaslik4;
        TextBox kotumserlik4_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik4_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik4_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik4_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik4_3_maliyet_txt_f2sonuc;
        TextBox kotumserlik4_3_maliyet_txt_f3sonuc;
        TextBox kotumserlik4_3_maliyet_txt_f4sonuc;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri6;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri7;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri8;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri9;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri10;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri11;
        NumericUpDown kotumserlik4_3_maliyet_txt_veri12;
        Label kotumserlik4_3_maliyet_sonucbaslik;
        Label kotumserlik4_3_maliyet_sonuc;
        Label kotumserlik4_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik4_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik4_3_maliyet_btn1 = new Button();
        Button kotumserlik4_3_maliyet_btn2 = new Button();
        Button kotumserlik4_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik4_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik5_3_maliyet form nesneleri
        Panel kotumserlik5_3_maliyet_pl1 = new Panel();
        Panel kotumserlik5_3_maliyet_pl2 = new Panel();
        Panel kotumserlik5_3_maliyet_pl3 = new Panel();
        Panel kotumserlik5_3_maliyet_pl4 = new Panel();
        Panel kotumserlik5_3_maliyet_pl5 = new Panel();
        Panel kotumserlik5_3_maliyet_pl6 = new Panel();
        Panel kotumserlik5_3_maliyet_pl7 = new Panel();
        Panel kotumserlik5_3_maliyet_pl8 = new Panel();
        Panel kotumserlik5_3_maliyet_pl9 = new Panel();
        Panel kotumserlik5_3_maliyet_pl10 = new Panel();
        Panel kotumserlik5_3_maliyet_pl11 = new Panel();
        Panel kotumserlik5_3_maliyet_pl12 = new Panel();
        Panel kotumserlik5_3_maliyet_pl13 = new Panel();
        Panel kotumserlik5_3_maliyet_pl14 = new Panel();
        Panel kotumserlik5_3_maliyet_pl15 = new Panel();
        Panel kotumserlik5_3_maliyet_pl16 = new Panel();
        Panel kotumserlik5_3_maliyet_pl17 = new Panel();
        Panel kotumserlik5_3_maliyet_pl18 = new Panel();
        Panel kotumserlik5_3_maliyet_pl19 = new Panel();
        Panel kotumserlik5_3_maliyet_pl20 = new Panel();
        Panel kotumserlik5_3_maliyet_pl21 = new Panel();
        Panel kotumserlik5_3_maliyet_pl22 = new Panel();
        Panel kotumserlik5_3_maliyet_pl23 = new Panel();
        Panel kotumserlik5_3_maliyet_pl24 = new Panel();
        Panel kotumserlik5_3_maliyet_pl25 = new Panel();
        Panel kotumserlik5_3_maliyet_pl26 = new Panel();
        Panel kotumserlik5_3_maliyet_pl27 = new Panel();
        Panel kotumserlik5_3_maliyet_pl28 = new Panel();
        Panel kotumserlik5_3_maliyet_pl29 = new Panel();
        Panel kotumserlik5_3_maliyet_pl30 = new Panel();
        Panel kotumserlik5_3_maliyet_pl31 = new Panel();
        Panel kotumserlik5_3_maliyet_pl32 = new Panel();
        Panel kotumserlik5_3_maliyet_pl33 = new Panel();
        Panel kotumserlik5_3_maliyet_pl34 = new Panel();
        Panel kotumserlik5_3_maliyet_pl35 = new Panel();
        Panel kotumserlik5_3_maliyet_pl36 = new Panel();
        Panel kotumserlik5_3_maliyet_pl37 = new Panel();
        Panel kotumserlik5_3_maliyet_pl38 = new Panel();
        Panel kotumserlik5_3_maliyet_pl39 = new Panel();
        Panel kotumserlik5_3_maliyet_pl40 = new Panel();
        Panel kotumserlik5_3_maliyet_pl41 = new Panel();
        Panel kotumserlik5_3_maliyet_pl42 = new Panel();
        Panel kotumserlik5_3_maliyet_pl43 = new Panel();
        Panel kotumserlik5_3_maliyet_pl44 = new Panel();
        Panel kotumserlik5_3_maliyet_pl45 = new Panel();
        TabControl kotumserlik5_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik5_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik5_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik5_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik5_3_maliyet_txt_baslik1;
        TextBox kotumserlik5_3_maliyet_txt_baslik2;
        TextBox kotumserlik5_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik5_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik5_3_maliyet_txt_altbaslik3;
        TextBox kotumserlik5_3_maliyet_txt_altbaslik4;
        TextBox kotumserlik5_3_maliyet_txt_altbaslik5;
        TextBox kotumserlik5_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik5_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik5_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik5_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik5_3_maliyet_txt_f2sonuc;
        TextBox kotumserlik5_3_maliyet_txt_f3sonuc;
        TextBox kotumserlik5_3_maliyet_txt_f4sonuc;
        TextBox kotumserlik5_3_maliyet_txt_f5sonuc;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri6;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri7;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri8;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri9;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri10;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri11;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri12;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri13;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri14;
        NumericUpDown kotumserlik5_3_maliyet_txt_veri15;
        Label kotumserlik5_3_maliyet_sonucbaslik;
        Label kotumserlik5_3_maliyet_sonuc;
        Label kotumserlik5_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik5_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik5_3_maliyet_btn1 = new Button();
        Button kotumserlik5_3_maliyet_btn2 = new Button();
        Button kotumserlik5_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik5_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik6_3_maliyet form nesneleri
        Panel kotumserlik6_3_maliyet_pl1 = new Panel();
        Panel kotumserlik6_3_maliyet_pl2 = new Panel();
        Panel kotumserlik6_3_maliyet_pl3 = new Panel();
        Panel kotumserlik6_3_maliyet_pl4 = new Panel();
        Panel kotumserlik6_3_maliyet_pl5 = new Panel();
        Panel kotumserlik6_3_maliyet_pl6 = new Panel();
        Panel kotumserlik6_3_maliyet_pl7 = new Panel();
        Panel kotumserlik6_3_maliyet_pl8 = new Panel();
        Panel kotumserlik6_3_maliyet_pl9 = new Panel();
        Panel kotumserlik6_3_maliyet_pl10 = new Panel();
        Panel kotumserlik6_3_maliyet_pl11 = new Panel();
        Panel kotumserlik6_3_maliyet_pl12 = new Panel();
        Panel kotumserlik6_3_maliyet_pl13 = new Panel();
        Panel kotumserlik6_3_maliyet_pl14 = new Panel();
        Panel kotumserlik6_3_maliyet_pl15 = new Panel();
        Panel kotumserlik6_3_maliyet_pl16 = new Panel();
        Panel kotumserlik6_3_maliyet_pl17 = new Panel();
        Panel kotumserlik6_3_maliyet_pl18 = new Panel();
        Panel kotumserlik6_3_maliyet_pl19 = new Panel();
        Panel kotumserlik6_3_maliyet_pl20 = new Panel();
        Panel kotumserlik6_3_maliyet_pl21 = new Panel();
        Panel kotumserlik6_3_maliyet_pl22 = new Panel();
        Panel kotumserlik6_3_maliyet_pl23 = new Panel();
        Panel kotumserlik6_3_maliyet_pl24 = new Panel();
        Panel kotumserlik6_3_maliyet_pl25 = new Panel();
        Panel kotumserlik6_3_maliyet_pl26 = new Panel();
        Panel kotumserlik6_3_maliyet_pl27 = new Panel();
        Panel kotumserlik6_3_maliyet_pl28 = new Panel();
        Panel kotumserlik6_3_maliyet_pl29 = new Panel();
        Panel kotumserlik6_3_maliyet_pl30 = new Panel();
        Panel kotumserlik6_3_maliyet_pl31 = new Panel();
        Panel kotumserlik6_3_maliyet_pl32 = new Panel();
        Panel kotumserlik6_3_maliyet_pl33 = new Panel();
        Panel kotumserlik6_3_maliyet_pl34 = new Panel();
        Panel kotumserlik6_3_maliyet_pl35 = new Panel();
        Panel kotumserlik6_3_maliyet_pl36 = new Panel();
        Panel kotumserlik6_3_maliyet_pl37 = new Panel();
        Panel kotumserlik6_3_maliyet_pl38 = new Panel();
        Panel kotumserlik6_3_maliyet_pl39 = new Panel();
        Panel kotumserlik6_3_maliyet_pl40 = new Panel();
        Panel kotumserlik6_3_maliyet_pl41 = new Panel();
        Panel kotumserlik6_3_maliyet_pl42 = new Panel();
        Panel kotumserlik6_3_maliyet_pl43 = new Panel();
        Panel kotumserlik6_3_maliyet_pl44 = new Panel();
        Panel kotumserlik6_3_maliyet_pl45 = new Panel();
        Panel kotumserlik6_3_maliyet_pl46 = new Panel();
        Panel kotumserlik6_3_maliyet_pl47 = new Panel();
        Panel kotumserlik6_3_maliyet_pl48 = new Panel();
        Panel kotumserlik6_3_maliyet_pl49 = new Panel();
        Panel kotumserlik6_3_maliyet_pl50 = new Panel();
        TabControl kotumserlik6_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik6_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik6_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik6_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik6_3_maliyet_txt_baslik1;
        TextBox kotumserlik6_3_maliyet_txt_baslik2;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik3;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik4;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik5;
        TextBox kotumserlik6_3_maliyet_txt_altbaslik6;
        TextBox kotumserlik6_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik6_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik6_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik6_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik6_3_maliyet_txt_f2sonuc;
        TextBox kotumserlik6_3_maliyet_txt_f3sonuc;
        TextBox kotumserlik6_3_maliyet_txt_f4sonuc;
        TextBox kotumserlik6_3_maliyet_txt_f5sonuc;
        TextBox kotumserlik6_3_maliyet_txt_f6sonuc;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri6;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri7;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri8;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri9;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri10;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri11;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri12;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri13;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri14;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri15;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri16;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri17;
        NumericUpDown kotumserlik6_3_maliyet_txt_veri18;
        Label kotumserlik6_3_maliyet_sonucbaslik;
        Label kotumserlik6_3_maliyet_sonuc;
        Label kotumserlik6_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik6_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik6_3_maliyet_btn1 = new Button();
        Button kotumserlik6_3_maliyet_btn2 = new Button();
        Button kotumserlik6_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik6_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik7_3_maliyet form nesneleri
        Panel kotumserlik7_3_maliyet_pl1 = new Panel();
        Panel kotumserlik7_3_maliyet_pl2 = new Panel();
        Panel kotumserlik7_3_maliyet_pl3 = new Panel();
        Panel kotumserlik7_3_maliyet_pl4 = new Panel();
        Panel kotumserlik7_3_maliyet_pl5 = new Panel();
        Panel kotumserlik7_3_maliyet_pl6 = new Panel();
        Panel kotumserlik7_3_maliyet_pl7 = new Panel();
        Panel kotumserlik7_3_maliyet_pl8 = new Panel();
        Panel kotumserlik7_3_maliyet_pl9 = new Panel();
        Panel kotumserlik7_3_maliyet_pl10 = new Panel();
        Panel kotumserlik7_3_maliyet_pl11 = new Panel();
        Panel kotumserlik7_3_maliyet_pl12 = new Panel();
        Panel kotumserlik7_3_maliyet_pl13 = new Panel();
        Panel kotumserlik7_3_maliyet_pl14 = new Panel();
        Panel kotumserlik7_3_maliyet_pl15 = new Panel();
        Panel kotumserlik7_3_maliyet_pl16 = new Panel();
        Panel kotumserlik7_3_maliyet_pl17 = new Panel();
        Panel kotumserlik7_3_maliyet_pl18 = new Panel();
        Panel kotumserlik7_3_maliyet_pl19 = new Panel();
        Panel kotumserlik7_3_maliyet_pl20 = new Panel();
        Panel kotumserlik7_3_maliyet_pl21 = new Panel();
        Panel kotumserlik7_3_maliyet_pl22 = new Panel();
        Panel kotumserlik7_3_maliyet_pl23 = new Panel();
        Panel kotumserlik7_3_maliyet_pl24 = new Panel();
        Panel kotumserlik7_3_maliyet_pl25 = new Panel();
        Panel kotumserlik7_3_maliyet_pl26 = new Panel();
        Panel kotumserlik7_3_maliyet_pl27 = new Panel();
        Panel kotumserlik7_3_maliyet_pl28 = new Panel();
        Panel kotumserlik7_3_maliyet_pl29 = new Panel();
        Panel kotumserlik7_3_maliyet_pl30 = new Panel();
        Panel kotumserlik7_3_maliyet_pl31 = new Panel();
        Panel kotumserlik7_3_maliyet_pl32 = new Panel();
        Panel kotumserlik7_3_maliyet_pl33 = new Panel();
        Panel kotumserlik7_3_maliyet_pl34 = new Panel();
        Panel kotumserlik7_3_maliyet_pl35 = new Panel();
        Panel kotumserlik7_3_maliyet_pl36 = new Panel();
        Panel kotumserlik7_3_maliyet_pl37 = new Panel();
        Panel kotumserlik7_3_maliyet_pl38 = new Panel();
        Panel kotumserlik7_3_maliyet_pl39 = new Panel();
        Panel kotumserlik7_3_maliyet_pl40 = new Panel();
        Panel kotumserlik7_3_maliyet_pl41 = new Panel();
        Panel kotumserlik7_3_maliyet_pl42 = new Panel();
        Panel kotumserlik7_3_maliyet_pl43 = new Panel();
        Panel kotumserlik7_3_maliyet_pl44 = new Panel();
        Panel kotumserlik7_3_maliyet_pl45 = new Panel();
        Panel kotumserlik7_3_maliyet_pl46 = new Panel();
        Panel kotumserlik7_3_maliyet_pl47 = new Panel();
        Panel kotumserlik7_3_maliyet_pl48 = new Panel();
        Panel kotumserlik7_3_maliyet_pl49 = new Panel();
        Panel kotumserlik7_3_maliyet_pl50 = new Panel();
        Panel kotumserlik7_3_maliyet_pl51 = new Panel();
        Panel kotumserlik7_3_maliyet_pl52 = new Panel();
        Panel kotumserlik7_3_maliyet_pl53 = new Panel();
        Panel kotumserlik7_3_maliyet_pl54 = new Panel();
        Panel kotumserlik7_3_maliyet_pl55 = new Panel();
        TabControl kotumserlik7_3_maliyet_tb1 = new TabControl();
        TabPage kotumserlik7_3_maliyet_tb1_1 = new TabPage();
        TabPage kotumserlik7_3_maliyet_tb1_2 = new TabPage();
        TabPage kotumserlik7_3_maliyet_tb1_3 = new TabPage();
        TextBox kotumserlik7_3_maliyet_txt_baslik1;
        TextBox kotumserlik7_3_maliyet_txt_baslik2;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik1;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik2;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik3;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik4;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik5;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik6;
        TextBox kotumserlik7_3_maliyet_txt_altbaslik7;
        TextBox kotumserlik7_3_maliyet_txt_üstbaslik1;
        TextBox kotumserlik7_3_maliyet_txt_üstbaslik2;
        TextBox kotumserlik7_3_maliyet_txt_üstbaslik3;
        TextBox kotumserlik7_3_maliyet_txt_f1sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f2sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f3sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f4sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f5sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f6sonuc;
        TextBox kotumserlik7_3_maliyet_txt_f7sonuc;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri1;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri2;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri3;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri4;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri5;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri6;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri7;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri8;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri9;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri10;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri11;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri12;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri13;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri14;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri15;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri16;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri17;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri18;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri19;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri20;
        NumericUpDown kotumserlik7_3_maliyet_txt_veri21;
        Label kotumserlik7_3_maliyet_sonucbaslik;
        Label kotumserlik7_3_maliyet_sonuc;
        Label kotumserlik7_3_maliyet_sonuclarortabaslik;
        DataGridView kotumserlik7_3_maliyet_dr1 = new DataGridView();
        Button kotumserlik7_3_maliyet_btn1 = new Button();
        Button kotumserlik7_3_maliyet_btn2 = new Button();
        Button kotumserlik7_3_maliyet_btn3 = new Button();
        RichTextBox kotumserlik7_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //kotumserlik2_3_maliyet form nesne tasarımları
        public void kotumserlik2_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik2_3_maliyet_sonuc = new Label();
            kotumserlik2_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik2_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik2_3_maliyet_sonuc.Location = sonuc;
            kotumserlik2_3_maliyet_sonuc.Text = "";
            kotumserlik2_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik2_3_maliyet_pl4.Controls.Add(kotumserlik2_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik2_3_maliyet_sonucbaslik = new Label();
            kotumserlik2_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik2_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik2_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik2_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik2_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik2_3_maliyet_pl4.Controls.Add(kotumserlik2_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik2_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik2_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik2_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik2_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik2_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik2_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik2_3_maliyet_pl28.Controls.Add(kotumserlik2_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik2_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl27.Controls.Add(kotumserlik2_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik2_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl23.Controls.Add(kotumserlik2_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik2_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl22.Controls.Add(kotumserlik2_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik2_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl26.Controls.Add(kotumserlik2_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik2_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl21.Controls.Add(kotumserlik2_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik2_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik2_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik2_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl20.Controls.Add(kotumserlik2_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik2_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik2_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik2_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik2_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl30.Controls.Add(kotumserlik2_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik2_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik2_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik2_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik2_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik2_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik2_3_maliyet_pl29.Controls.Add(kotumserlik2_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik2_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik2_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik2_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik2_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik2_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik2_3_maliyet_pl24.Controls.Add(kotumserlik2_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik2_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik2_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik2_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik2_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik2_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik2_3_maliyet_pl17.Controls.Add(kotumserlik2_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik2_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik2_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik2_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik2_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik2_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik2_3_maliyet_pl16.Controls.Add(kotumserlik2_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik2_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik2_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik2_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik2_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik2_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik2_3_maliyet_pl15.Controls.Add(kotumserlik2_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik2_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik2_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik2_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik2_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik2_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik2_3_maliyet_pl14.Controls.Add(kotumserlik2_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik2_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik2_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik2_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik2_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik2_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik2_3_maliyet_pl13.Controls.Add(kotumserlik2_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik2_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik2_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik2_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik2_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik2_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik2_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik2_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik2_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik2_3_maliyet_pl12.Controls.Add(kotumserlik2_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik2_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik2_3_maliyet_pl30.Location = pl30k;
            kotumserlik2_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik2_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik2_3_maliyet_pl29.Location = pl29k;
            kotumserlik2_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik2_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik2_3_maliyet_pl28.Location = pl28k;
            kotumserlik2_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik2_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik2_3_maliyet_pl27.Location = pl27k;
            kotumserlik2_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik2_3_maliyet_pl26.Location = pl26k;
            kotumserlik2_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik2_3_maliyet_pl23.Location = pl23k;
            kotumserlik2_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik2_3_maliyet_pl22.Location = pl22k;
            kotumserlik2_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik2_3_maliyet_pl21.Location = pl21k;
            kotumserlik2_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik2_3_maliyet_pl20.Location = pl20k;
            kotumserlik2_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik2_3_maliyet_pl25.Location = pl25k;
            kotumserlik2_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik2_3_maliyet_pl19.Location = pl19k;
            kotumserlik2_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik2_3_maliyet_pl18.Location = pl18k;
            kotumserlik2_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik2_3_maliyet_pl24.Location = pl24k;
            kotumserlik2_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik2_3_maliyet_pl17.Location = pl17k;
            kotumserlik2_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik2_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik2_3_maliyet_pl16.Location = pl16k;
            kotumserlik2_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik2_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik2_3_maliyet_pl15.Location = pl15k;
            kotumserlik2_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik2_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik2_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik2_3_maliyet_pl14.Location = pl14k;
            kotumserlik2_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik2_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik2_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik2_3_maliyet_pl13.Location = pl13k;
            kotumserlik2_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik2_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik2_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik2_3_maliyet_pl12.Location = pl12k;
            kotumserlik2_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik2_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl5.Controls.Add(kotumserlik2_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik2_3_maliyet_pl11.Name = "pl11";
            kotumserlik2_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik2_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik2_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl11.Click += new EventHandler(kotumserlik2_3_maliyet_pl11_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik2_3_maliyet_pl10.Name = "pl10";
            kotumserlik2_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik2_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl10.Click += new EventHandler(kotumserlik2_3_maliyet_pl10_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik2_3_maliyet_pl9.Name = "pl9";
            kotumserlik2_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik2_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl9.Click += new EventHandler(kotumserlik2_3_maliyet_pl9_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik2_3_maliyet_pl8.Name = "pl8";
            kotumserlik2_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik2_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl8.Click += new EventHandler(kotumserlik2_3_maliyet_pl8_Click);
            kotumserlik2_3_maliyet_pl7.Controls.Add(kotumserlik2_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik2_3_maliyet_pl6.Name = "pl6";
            kotumserlik2_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik2_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl6.Click += new EventHandler(kotumserlik2_3_maliyet_pl6_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik2_3_maliyet_btn3.Name = "btn3";
            kotumserlik2_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik2_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik2_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_btn3.Click += new EventHandler(kotumserlik2_3_maliyet_btn3_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik2_3_maliyet_btn2.Name = "btn2";
            kotumserlik2_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik2_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik2_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik2_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik2_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_btn2.Click += new EventHandler(kotumserlik2_3_maliyet_btn2_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik2_3_maliyet_btn1.Name = "btn1";
            kotumserlik2_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik2_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik2_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik2_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik2_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik2_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik2_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik2_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_btn1.Click += new EventHandler(kotumserlik2_3_maliyet_btn1_Click);
            kotumserlik2_3_maliyet_pl2.Controls.Add(kotumserlik2_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik2_3_maliyet_dr1.Name = "dr1";
            kotumserlik2_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik2_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik2_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik2_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik2_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik2_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik2_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik2_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik2_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik2_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik2_3_maliyet_dr1_CellEnter);
            kotumserlik2_3_maliyet_tb1_2.Controls.Add(kotumserlik2_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik2_3_maliyet_pl7.Name = "pl7";
            kotumserlik2_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik2_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik2_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_tb1_2.Controls.Add(kotumserlik2_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik2_3_maliyet_pl5.Name = "pl5";
            kotumserlik2_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik2_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik2_3_maliyet_pl5.AutoScroll = true;
            kotumserlik2_3_maliyet_pl5.AutoSize = true;
            kotumserlik2_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik2_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_tb1_1.Controls.Add(kotumserlik2_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik2_3_maliyet_rt1.Name = "rt1";
            kotumserlik2_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik2_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik2_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_rt1.Enabled = false;
            kotumserlik2_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik2_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik2_3_maliyet_tb1_3.Controls.Add(kotumserlik2_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik2_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik2_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik2_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik2_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_tb1.Controls.Add(kotumserlik2_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik2_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik2_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik2_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik2_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_tb1.Controls.Add(kotumserlik2_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik2_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik2_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik2_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik2_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_tb1.Controls.Add(kotumserlik2_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik2_3_maliyet_tb1.Name = "tb1";
            kotumserlik2_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik2_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik2_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik2_3_maliyet_pl3.Controls.Add(kotumserlik2_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik2_3_maliyet_pl4.Name = "pl4";
            kotumserlik2_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik2_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik2_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik2_3_maliyet_pl4_MouseUp);
            kotumserlik2_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik2_3_maliyet_pl4_MouseMove);
            kotumserlik2_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik2_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik2_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik2_3_maliyet_pl3.Name = "pl3";
            kotumserlik2_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik2_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik2_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik2_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik2_3_maliyet_pl2.Name = "pl2";
            kotumserlik2_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik2_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik2_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik2_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik2_3_maliyet_pl1.Name = "pl1";
            kotumserlik2_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik2_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik2_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik2_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik2_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik2_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik2_3_maliyet_pl1_MouseUp);
            kotumserlik2_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik2_3_maliyet_pl1_MouseMove);
            kotumserlik2_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik2_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik2_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik3_3_maliyet form nesne tasarımları
        public void kotumserlik3_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik3_3_maliyet_sonuc = new Label();
            kotumserlik3_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik3_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik3_3_maliyet_sonuc.Location = sonuc;
            kotumserlik3_3_maliyet_sonuc.Text = "";
            kotumserlik3_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik3_3_maliyet_pl4.Controls.Add(kotumserlik3_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik3_3_maliyet_sonucbaslik = new Label();
            kotumserlik3_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik3_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik3_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik3_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik3_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik3_3_maliyet_pl4.Controls.Add(kotumserlik3_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik3_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik3_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik3_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik3_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik3_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik3_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik3_3_maliyet_pl28.Controls.Add(kotumserlik3_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri9 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri9.Location = txt_veri9;
            kotumserlik3_3_maliyet_txt_veri9.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl34.Controls.Add(kotumserlik3_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri8 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri8.Location = txt_veri8;
            kotumserlik3_3_maliyet_txt_veri8.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl33.Controls.Add(kotumserlik3_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri7 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri7.Location = txt_veri7;
            kotumserlik3_3_maliyet_txt_veri7.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl32.Controls.Add(kotumserlik3_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik3_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl27.Controls.Add(kotumserlik3_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik3_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl23.Controls.Add(kotumserlik3_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik3_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl22.Controls.Add(kotumserlik3_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik3_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl26.Controls.Add(kotumserlik3_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik3_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl21.Controls.Add(kotumserlik3_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik3_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik3_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik3_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl20.Controls.Add(kotumserlik3_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_f3sonuc = new TextBox();
            kotumserlik3_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            kotumserlik3_3_maliyet_txt_f3sonuc.Text = "0";
            kotumserlik3_3_maliyet_txt_f3sonuc.Enabled = false;
            kotumserlik3_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl35.Controls.Add(kotumserlik3_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik3_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik3_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik3_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik3_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl30.Controls.Add(kotumserlik3_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik3_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik3_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik3_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik3_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik3_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik3_3_maliyet_pl29.Controls.Add(kotumserlik3_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik3_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik3_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik3_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik3_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik3_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik3_3_maliyet_pl24.Controls.Add(kotumserlik3_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik3_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik3_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik3_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik3_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik3_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik3_3_maliyet_pl17.Controls.Add(kotumserlik3_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik3_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik3_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik3_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik3_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik3_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik3_3_maliyet_pl16.Controls.Add(kotumserlik3_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_altbaslik3 = new TextBox();
            kotumserlik3_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            kotumserlik3_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            kotumserlik3_3_maliyet_txt_altbaslik3.Text = "F3";
            kotumserlik3_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_altbaslik3.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_altbaslik3.Multiline = true;
            kotumserlik3_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            kotumserlik3_3_maliyet_pl31.Controls.Add(kotumserlik3_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik3_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik3_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik3_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik3_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik3_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik3_3_maliyet_pl15.Controls.Add(kotumserlik3_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik3_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik3_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik3_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik3_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik3_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik3_3_maliyet_pl14.Controls.Add(kotumserlik3_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik3_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik3_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik3_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik3_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik3_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik3_3_maliyet_pl13.Controls.Add(kotumserlik3_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik3_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik3_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik3_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik3_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik3_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik3_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik3_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik3_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik3_3_maliyet_pl12.Controls.Add(kotumserlik3_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            kotumserlik3_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            kotumserlik3_3_maliyet_pl35.Location = pl35k;
            kotumserlik3_3_maliyet_pl35.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik3_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik3_3_maliyet_pl30.Location = pl30k;
            kotumserlik3_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik3_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik3_3_maliyet_pl29.Location = pl29k;
            kotumserlik3_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik3_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik3_3_maliyet_pl28.Location = pl28k;
            kotumserlik3_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik3_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            kotumserlik3_3_maliyet_pl34.Location = pl34k;
            kotumserlik3_3_maliyet_pl34.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            kotumserlik3_3_maliyet_pl33.Location = pl33k;
            kotumserlik3_3_maliyet_pl33.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            kotumserlik3_3_maliyet_pl32.Location = pl32k;
            kotumserlik3_3_maliyet_pl32.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik3_3_maliyet_pl27.Location = pl27k;
            kotumserlik3_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik3_3_maliyet_pl26.Location = pl26k;
            kotumserlik3_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik3_3_maliyet_pl23.Location = pl23k;
            kotumserlik3_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik3_3_maliyet_pl22.Location = pl22k;
            kotumserlik3_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik3_3_maliyet_pl21.Location = pl21k;
            kotumserlik3_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik3_3_maliyet_pl20.Location = pl20k;
            kotumserlik3_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik3_3_maliyet_pl25.Location = pl25k;
            kotumserlik3_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik3_3_maliyet_pl19.Location = pl19k;
            kotumserlik3_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik3_3_maliyet_pl18.Location = pl18k;
            kotumserlik3_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik3_3_maliyet_pl24.Location = pl24k;
            kotumserlik3_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik3_3_maliyet_pl17.Location = pl17k;
            kotumserlik3_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik3_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik3_3_maliyet_pl16.Location = pl16k;
            kotumserlik3_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik3_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            kotumserlik3_3_maliyet_pl31.Location = pl31k;
            kotumserlik3_3_maliyet_pl31.Size = new Size(168, 33);
            kotumserlik3_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik3_3_maliyet_pl15.Location = pl15k;
            kotumserlik3_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik3_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik3_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik3_3_maliyet_pl14.Location = pl14k;
            kotumserlik3_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik3_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik3_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik3_3_maliyet_pl13.Location = pl13k;
            kotumserlik3_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik3_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik3_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik3_3_maliyet_pl12.Location = pl12k;
            kotumserlik3_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik3_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl5.Controls.Add(kotumserlik3_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik3_3_maliyet_pl11.Name = "pl11";
            kotumserlik3_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik3_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik3_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl11.Click += new EventHandler(kotumserlik3_3_maliyet_pl11_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik3_3_maliyet_pl10.Name = "pl10";
            kotumserlik3_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik3_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl10.Click += new EventHandler(kotumserlik3_3_maliyet_pl10_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik3_3_maliyet_pl9.Name = "pl9";
            kotumserlik3_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik3_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl9.Click += new EventHandler(kotumserlik3_3_maliyet_pl9_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik3_3_maliyet_pl8.Name = "pl8";
            kotumserlik3_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik3_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl8.Click += new EventHandler(kotumserlik3_3_maliyet_pl8_Click);
            kotumserlik3_3_maliyet_pl7.Controls.Add(kotumserlik3_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik3_3_maliyet_pl6.Name = "pl6";
            kotumserlik3_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik3_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl6.Click += new EventHandler(kotumserlik3_3_maliyet_pl6_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik3_3_maliyet_btn3.Name = "btn3";
            kotumserlik3_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik3_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik3_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_btn3.Click += new EventHandler(kotumserlik3_3_maliyet_btn3_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik3_3_maliyet_btn2.Name = "btn2";
            kotumserlik3_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik3_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik3_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik3_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik3_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_btn2.Click += new EventHandler(kotumserlik3_3_maliyet_btn2_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik3_3_maliyet_btn1.Name = "btn1";
            kotumserlik3_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik3_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik3_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik3_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik3_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik3_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik3_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik3_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_btn1.Click += new EventHandler(kotumserlik3_3_maliyet_btn1_Click);
            kotumserlik3_3_maliyet_pl2.Controls.Add(kotumserlik3_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik3_3_maliyet_dr1.Name = "dr1";
            kotumserlik3_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik3_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik3_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik3_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik3_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik3_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik3_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik3_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik3_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik3_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik3_3_maliyet_dr1_CellEnter);
            kotumserlik3_3_maliyet_tb1_2.Controls.Add(kotumserlik3_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik3_3_maliyet_pl7.Name = "pl7";
            kotumserlik3_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik3_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik3_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_tb1_2.Controls.Add(kotumserlik3_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik3_3_maliyet_pl5.Name = "pl5";
            kotumserlik3_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik3_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik3_3_maliyet_pl5.AutoScroll = true;
            kotumserlik3_3_maliyet_pl5.AutoSize = true;
            kotumserlik3_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik3_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_tb1_1.Controls.Add(kotumserlik3_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik3_3_maliyet_rt1.Name = "rt1";
            kotumserlik3_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik3_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik3_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_rt1.Enabled = false;
            kotumserlik3_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik3_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik3_3_maliyet_tb1_3.Controls.Add(kotumserlik3_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik3_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik3_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik3_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik3_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_tb1.Controls.Add(kotumserlik3_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik3_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik3_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik3_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik3_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_tb1.Controls.Add(kotumserlik3_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik3_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik3_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik3_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik3_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_tb1.Controls.Add(kotumserlik3_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik3_3_maliyet_tb1.Name = "tb1";
            kotumserlik3_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik3_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik3_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik3_3_maliyet_pl3.Controls.Add(kotumserlik3_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik3_3_maliyet_pl4.Name = "pl4";
            kotumserlik3_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik3_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik3_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik3_3_maliyet_pl4_MouseUp);
            kotumserlik3_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik3_3_maliyet_pl4_MouseMove);
            kotumserlik3_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik3_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik3_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik3_3_maliyet_pl3.Name = "pl3";
            kotumserlik3_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik3_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik3_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik3_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik3_3_maliyet_pl2.Name = "pl2";
            kotumserlik3_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik3_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik3_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik3_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik3_3_maliyet_pl1.Name = "pl1";
            kotumserlik3_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik3_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik3_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik3_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik3_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik3_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik3_3_maliyet_pl1_MouseUp);
            kotumserlik3_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik3_3_maliyet_pl1_MouseMove);
            kotumserlik3_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik3_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik3_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik4_3_maliyet form nesne tasarımları
        public void kotumserlik4_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik4_3_maliyet_sonuc = new Label();
            kotumserlik4_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik4_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik4_3_maliyet_sonuc.Location = sonuc;
            kotumserlik4_3_maliyet_sonuc.Text = "";
            kotumserlik4_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik4_3_maliyet_pl4.Controls.Add(kotumserlik4_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik4_3_maliyet_sonucbaslik = new Label();
            kotumserlik4_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik4_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik4_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik4_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik4_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik4_3_maliyet_pl4.Controls.Add(kotumserlik4_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik4_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik4_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik4_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik4_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik4_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik4_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik4_3_maliyet_pl28.Controls.Add(kotumserlik4_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri12 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri12.Location = txt_veri12;
            kotumserlik4_3_maliyet_txt_veri12.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl39.Controls.Add(kotumserlik4_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri11 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri11.Location = txt_veri11;
            kotumserlik4_3_maliyet_txt_veri11.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl38.Controls.Add(kotumserlik4_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri10 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri10.Location = txt_veri10;
            kotumserlik4_3_maliyet_txt_veri10.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl37.Controls.Add(kotumserlik4_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri9 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri9.Location = txt_veri9;
            kotumserlik4_3_maliyet_txt_veri9.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl34.Controls.Add(kotumserlik4_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri8 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri8.Location = txt_veri8;
            kotumserlik4_3_maliyet_txt_veri8.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl33.Controls.Add(kotumserlik4_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri7 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri7.Location = txt_veri7;
            kotumserlik4_3_maliyet_txt_veri7.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl32.Controls.Add(kotumserlik4_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik4_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl27.Controls.Add(kotumserlik4_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik4_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl23.Controls.Add(kotumserlik4_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik4_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl22.Controls.Add(kotumserlik4_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik4_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl26.Controls.Add(kotumserlik4_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik4_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl21.Controls.Add(kotumserlik4_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik4_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik4_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik4_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl20.Controls.Add(kotumserlik4_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_f4sonuc = new TextBox();
            kotumserlik4_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            kotumserlik4_3_maliyet_txt_f4sonuc.Text = "0";
            kotumserlik4_3_maliyet_txt_f4sonuc.Enabled = false;
            kotumserlik4_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl40.Controls.Add(kotumserlik4_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_f3sonuc = new TextBox();
            kotumserlik4_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            kotumserlik4_3_maliyet_txt_f3sonuc.Text = "0";
            kotumserlik4_3_maliyet_txt_f3sonuc.Enabled = false;
            kotumserlik4_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl35.Controls.Add(kotumserlik4_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik4_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik4_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik4_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik4_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl30.Controls.Add(kotumserlik4_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik4_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik4_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik4_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik4_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik4_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik4_3_maliyet_pl29.Controls.Add(kotumserlik4_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik4_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik4_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik4_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik4_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik4_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik4_3_maliyet_pl24.Controls.Add(kotumserlik4_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik4_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik4_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik4_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik4_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik4_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik4_3_maliyet_pl17.Controls.Add(kotumserlik4_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik4_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik4_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik4_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik4_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik4_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik4_3_maliyet_pl16.Controls.Add(kotumserlik4_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_altbaslik4 = new TextBox();
            kotumserlik4_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            kotumserlik4_3_maliyet_txt_altbaslik4.Text = "F4";
            kotumserlik4_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_altbaslik4.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_altbaslik4.Multiline = true;
            kotumserlik4_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl36.Controls.Add(kotumserlik4_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_altbaslik3 = new TextBox();
            kotumserlik4_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            kotumserlik4_3_maliyet_txt_altbaslik3.Text = "F3";
            kotumserlik4_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_altbaslik3.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_altbaslik3.Multiline = true;
            kotumserlik4_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl31.Controls.Add(kotumserlik4_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik4_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik4_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik4_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik4_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl15.Controls.Add(kotumserlik4_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik4_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik4_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik4_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik4_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl14.Controls.Add(kotumserlik4_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik4_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik4_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik4_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik4_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl13.Controls.Add(kotumserlik4_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik4_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik4_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik4_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik4_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik4_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik4_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik4_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik4_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik4_3_maliyet_pl12.Controls.Add(kotumserlik4_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            kotumserlik4_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            kotumserlik4_3_maliyet_pl40.Location = pl40k;
            kotumserlik4_3_maliyet_pl40.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            kotumserlik4_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            kotumserlik4_3_maliyet_pl35.Location = pl35k;
            kotumserlik4_3_maliyet_pl35.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik4_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik4_3_maliyet_pl30.Location = pl30k;
            kotumserlik4_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik4_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik4_3_maliyet_pl29.Location = pl29k;
            kotumserlik4_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik4_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik4_3_maliyet_pl28.Location = pl28k;
            kotumserlik4_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik4_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            kotumserlik4_3_maliyet_pl39.Location = pl39k;
            kotumserlik4_3_maliyet_pl39.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            kotumserlik4_3_maliyet_pl38.Location = pl38k;
            kotumserlik4_3_maliyet_pl38.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            kotumserlik4_3_maliyet_pl37.Location = pl37k;
            kotumserlik4_3_maliyet_pl37.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            kotumserlik4_3_maliyet_pl34.Location = pl34k;
            kotumserlik4_3_maliyet_pl34.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            kotumserlik4_3_maliyet_pl33.Location = pl33k;
            kotumserlik4_3_maliyet_pl33.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            kotumserlik4_3_maliyet_pl32.Location = pl32k;
            kotumserlik4_3_maliyet_pl32.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik4_3_maliyet_pl27.Location = pl27k;
            kotumserlik4_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik4_3_maliyet_pl26.Location = pl26k;
            kotumserlik4_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik4_3_maliyet_pl23.Location = pl23k;
            kotumserlik4_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik4_3_maliyet_pl22.Location = pl22k;
            kotumserlik4_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik4_3_maliyet_pl21.Location = pl21k;
            kotumserlik4_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik4_3_maliyet_pl20.Location = pl20k;
            kotumserlik4_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik4_3_maliyet_pl25.Location = pl25k;
            kotumserlik4_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik4_3_maliyet_pl19.Location = pl19k;
            kotumserlik4_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik4_3_maliyet_pl18.Location = pl18k;
            kotumserlik4_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik4_3_maliyet_pl24.Location = pl24k;
            kotumserlik4_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik4_3_maliyet_pl17.Location = pl17k;
            kotumserlik4_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik4_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik4_3_maliyet_pl16.Location = pl16k;
            kotumserlik4_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik4_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            kotumserlik4_3_maliyet_pl36.Location = pl36k;
            kotumserlik4_3_maliyet_pl36.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            kotumserlik4_3_maliyet_pl31.Location = pl31k;
            kotumserlik4_3_maliyet_pl31.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik4_3_maliyet_pl15.Location = pl15k;
            kotumserlik4_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik4_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik4_3_maliyet_pl14.Location = pl14k;
            kotumserlik4_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik4_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik4_3_maliyet_pl13.Location = pl13k;
            kotumserlik4_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik4_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik4_3_maliyet_pl12.Location = pl12k;
            kotumserlik4_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik4_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl5.Controls.Add(kotumserlik4_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik4_3_maliyet_pl11.Name = "pl11";
            kotumserlik4_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik4_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik4_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl11.Click += new EventHandler(kotumserlik4_3_maliyet_pl11_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik4_3_maliyet_pl10.Name = "pl10";
            kotumserlik4_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik4_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl10.Click += new EventHandler(kotumserlik4_3_maliyet_pl10_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik4_3_maliyet_pl9.Name = "pl9";
            kotumserlik4_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik4_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl9.Click += new EventHandler(kotumserlik4_3_maliyet_pl9_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik4_3_maliyet_pl8.Name = "pl8";
            kotumserlik4_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik4_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl8.Click += new EventHandler(kotumserlik4_3_maliyet_pl8_Click);
            kotumserlik4_3_maliyet_pl7.Controls.Add(kotumserlik4_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik4_3_maliyet_pl6.Name = "pl6";
            kotumserlik4_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik4_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl6.Click += new EventHandler(kotumserlik4_3_maliyet_pl6_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik4_3_maliyet_btn3.Name = "btn3";
            kotumserlik4_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik4_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik4_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_btn3.Click += new EventHandler(kotumserlik4_3_maliyet_btn3_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik4_3_maliyet_btn2.Name = "btn2";
            kotumserlik4_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik4_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik4_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik4_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik4_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_btn2.Click += new EventHandler(kotumserlik4_3_maliyet_btn2_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik4_3_maliyet_btn1.Name = "btn1";
            kotumserlik4_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik4_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik4_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik4_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik4_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik4_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik4_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik4_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_btn1.Click += new EventHandler(kotumserlik4_3_maliyet_btn1_Click);
            kotumserlik4_3_maliyet_pl2.Controls.Add(kotumserlik4_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik4_3_maliyet_dr1.Name = "dr1";
            kotumserlik4_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik4_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik4_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik4_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik4_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik4_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik4_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik4_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik4_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik4_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik4_3_maliyet_dr1_CellEnter);
            kotumserlik4_3_maliyet_tb1_2.Controls.Add(kotumserlik4_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik4_3_maliyet_pl7.Name = "pl7";
            kotumserlik4_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik4_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik4_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_tb1_2.Controls.Add(kotumserlik4_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik4_3_maliyet_pl5.Name = "pl5";
            kotumserlik4_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik4_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik4_3_maliyet_pl5.AutoScroll = true;
            kotumserlik4_3_maliyet_pl5.AutoSize = true;
            kotumserlik4_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik4_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_tb1_1.Controls.Add(kotumserlik4_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik4_3_maliyet_rt1.Name = "rt1";
            kotumserlik4_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik4_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik4_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_rt1.Enabled = false;
            kotumserlik4_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik4_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik4_3_maliyet_tb1_3.Controls.Add(kotumserlik4_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik4_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik4_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik4_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik4_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_tb1.Controls.Add(kotumserlik4_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik4_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik4_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik4_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik4_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_tb1.Controls.Add(kotumserlik4_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik4_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik4_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik4_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik4_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_tb1.Controls.Add(kotumserlik4_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik4_3_maliyet_tb1.Name = "tb1";
            kotumserlik4_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik4_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik4_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik4_3_maliyet_pl3.Controls.Add(kotumserlik4_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik4_3_maliyet_pl4.Name = "pl4";
            kotumserlik4_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik4_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik4_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik4_3_maliyet_pl4_MouseUp);
            kotumserlik4_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik4_3_maliyet_pl4_MouseMove);
            kotumserlik4_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik4_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik4_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik4_3_maliyet_pl3.Name = "pl3";
            kotumserlik4_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik4_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik4_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik4_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik4_3_maliyet_pl2.Name = "pl2";
            kotumserlik4_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik4_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik4_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik4_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik4_3_maliyet_pl1.Name = "pl1";
            kotumserlik4_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik4_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik4_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik4_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik4_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik4_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik4_3_maliyet_pl1_MouseUp);
            kotumserlik4_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik4_3_maliyet_pl1_MouseMove);
            kotumserlik4_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik4_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik4_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik5_3_maliyet form nesne tasarımları
        public void kotumserlik5_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik5_3_maliyet_sonuc = new Label();
            kotumserlik5_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik5_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik5_3_maliyet_sonuc.Location = sonuc;
            kotumserlik5_3_maliyet_sonuc.Text = "";
            kotumserlik5_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik5_3_maliyet_pl4.Controls.Add(kotumserlik5_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik5_3_maliyet_sonucbaslik = new Label();
            kotumserlik5_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik5_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik5_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik5_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik5_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik5_3_maliyet_pl4.Controls.Add(kotumserlik5_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik5_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik5_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik5_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik5_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik5_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik5_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik5_3_maliyet_pl28.Controls.Add(kotumserlik5_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri15 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri15.Location = txt_veri15;
            kotumserlik5_3_maliyet_txt_veri15.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl44.Controls.Add(kotumserlik5_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri14 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri14.Location = txt_veri14;
            kotumserlik5_3_maliyet_txt_veri14.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl43.Controls.Add(kotumserlik5_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri13 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri13.Location = txt_veri13;
            kotumserlik5_3_maliyet_txt_veri13.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl42.Controls.Add(kotumserlik5_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri12 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri12.Location = txt_veri12;
            kotumserlik5_3_maliyet_txt_veri12.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl39.Controls.Add(kotumserlik5_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri11 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri11.Location = txt_veri11;
            kotumserlik5_3_maliyet_txt_veri11.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl38.Controls.Add(kotumserlik5_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri10 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri10.Location = txt_veri10;
            kotumserlik5_3_maliyet_txt_veri10.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl37.Controls.Add(kotumserlik5_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri9 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri9.Location = txt_veri9;
            kotumserlik5_3_maliyet_txt_veri9.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl34.Controls.Add(kotumserlik5_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri8 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri8.Location = txt_veri8;
            kotumserlik5_3_maliyet_txt_veri8.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl33.Controls.Add(kotumserlik5_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri7 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri7.Location = txt_veri7;
            kotumserlik5_3_maliyet_txt_veri7.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl32.Controls.Add(kotumserlik5_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik5_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl27.Controls.Add(kotumserlik5_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik5_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl23.Controls.Add(kotumserlik5_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik5_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl22.Controls.Add(kotumserlik5_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik5_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl26.Controls.Add(kotumserlik5_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik5_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl21.Controls.Add(kotumserlik5_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik5_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik5_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik5_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl20.Controls.Add(kotumserlik5_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_f5sonuc = new TextBox();
            kotumserlik5_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            kotumserlik5_3_maliyet_txt_f5sonuc.Text = "0";
            kotumserlik5_3_maliyet_txt_f5sonuc.Enabled = false;
            kotumserlik5_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl45.Controls.Add(kotumserlik5_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_f4sonuc = new TextBox();
            kotumserlik5_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            kotumserlik5_3_maliyet_txt_f4sonuc.Text = "0";
            kotumserlik5_3_maliyet_txt_f4sonuc.Enabled = false;
            kotumserlik5_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl40.Controls.Add(kotumserlik5_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_f3sonuc = new TextBox();
            kotumserlik5_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            kotumserlik5_3_maliyet_txt_f3sonuc.Text = "0";
            kotumserlik5_3_maliyet_txt_f3sonuc.Enabled = false;
            kotumserlik5_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl35.Controls.Add(kotumserlik5_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik5_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik5_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik5_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik5_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl30.Controls.Add(kotumserlik5_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik5_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik5_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik5_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik5_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik5_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik5_3_maliyet_pl29.Controls.Add(kotumserlik5_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik5_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik5_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik5_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik5_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik5_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik5_3_maliyet_pl24.Controls.Add(kotumserlik5_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik5_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik5_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik5_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik5_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik5_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik5_3_maliyet_pl17.Controls.Add(kotumserlik5_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik5_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik5_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik5_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik5_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik5_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik5_3_maliyet_pl16.Controls.Add(kotumserlik5_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_altbaslik5 = new TextBox();
            kotumserlik5_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            kotumserlik5_3_maliyet_txt_altbaslik5.Text = "F5";
            kotumserlik5_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_altbaslik5.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_altbaslik5.Multiline = true;
            kotumserlik5_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl41.Controls.Add(kotumserlik5_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_altbaslik4 = new TextBox();
            kotumserlik5_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            kotumserlik5_3_maliyet_txt_altbaslik4.Text = "F4";
            kotumserlik5_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_altbaslik4.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_altbaslik4.Multiline = true;
            kotumserlik5_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl36.Controls.Add(kotumserlik5_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_altbaslik3 = new TextBox();
            kotumserlik5_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            kotumserlik5_3_maliyet_txt_altbaslik3.Text = "F3";
            kotumserlik5_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_altbaslik3.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_altbaslik3.Multiline = true;
            kotumserlik5_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl31.Controls.Add(kotumserlik5_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik5_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik5_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik5_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik5_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl15.Controls.Add(kotumserlik5_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik5_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik5_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik5_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik5_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl14.Controls.Add(kotumserlik5_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik5_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik5_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik5_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik5_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl13.Controls.Add(kotumserlik5_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik5_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik5_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik5_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik5_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik5_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik5_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik5_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik5_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik5_3_maliyet_pl12.Controls.Add(kotumserlik5_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            kotumserlik5_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            kotumserlik5_3_maliyet_pl45.Location = pl45k;
            kotumserlik5_3_maliyet_pl45.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            kotumserlik5_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            kotumserlik5_3_maliyet_pl40.Location = pl40k;
            kotumserlik5_3_maliyet_pl40.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            kotumserlik5_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            kotumserlik5_3_maliyet_pl35.Location = pl35k;
            kotumserlik5_3_maliyet_pl35.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik5_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik5_3_maliyet_pl30.Location = pl30k;
            kotumserlik5_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik5_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik5_3_maliyet_pl29.Location = pl29k;
            kotumserlik5_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik5_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik5_3_maliyet_pl28.Location = pl28k;
            kotumserlik5_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik5_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            kotumserlik5_3_maliyet_pl44.Location = pl44k;
            kotumserlik5_3_maliyet_pl44.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            kotumserlik5_3_maliyet_pl43.Location = pl43k;
            kotumserlik5_3_maliyet_pl43.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            kotumserlik5_3_maliyet_pl42.Location = pl42k;
            kotumserlik5_3_maliyet_pl42.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            kotumserlik5_3_maliyet_pl39.Location = pl39k;
            kotumserlik5_3_maliyet_pl39.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            kotumserlik5_3_maliyet_pl38.Location = pl38k;
            kotumserlik5_3_maliyet_pl38.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            kotumserlik5_3_maliyet_pl37.Location = pl37k;
            kotumserlik5_3_maliyet_pl37.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            kotumserlik5_3_maliyet_pl34.Location = pl34k;
            kotumserlik5_3_maliyet_pl34.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            kotumserlik5_3_maliyet_pl33.Location = pl33k;
            kotumserlik5_3_maliyet_pl33.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            kotumserlik5_3_maliyet_pl32.Location = pl32k;
            kotumserlik5_3_maliyet_pl32.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik5_3_maliyet_pl27.Location = pl27k;
            kotumserlik5_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik5_3_maliyet_pl26.Location = pl26k;
            kotumserlik5_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik5_3_maliyet_pl23.Location = pl23k;
            kotumserlik5_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik5_3_maliyet_pl22.Location = pl22k;
            kotumserlik5_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik5_3_maliyet_pl21.Location = pl21k;
            kotumserlik5_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik5_3_maliyet_pl20.Location = pl20k;
            kotumserlik5_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik5_3_maliyet_pl25.Location = pl25k;
            kotumserlik5_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik5_3_maliyet_pl19.Location = pl19k;
            kotumserlik5_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik5_3_maliyet_pl18.Location = pl18k;
            kotumserlik5_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik5_3_maliyet_pl24.Location = pl24k;
            kotumserlik5_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik5_3_maliyet_pl17.Location = pl17k;
            kotumserlik5_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik5_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik5_3_maliyet_pl16.Location = pl16k;
            kotumserlik5_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik5_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            kotumserlik5_3_maliyet_pl41.Location = pl41k;
            kotumserlik5_3_maliyet_pl41.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            kotumserlik5_3_maliyet_pl36.Location = pl36k;
            kotumserlik5_3_maliyet_pl36.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            kotumserlik5_3_maliyet_pl31.Location = pl31k;
            kotumserlik5_3_maliyet_pl31.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik5_3_maliyet_pl15.Location = pl15k;
            kotumserlik5_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik5_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik5_3_maliyet_pl14.Location = pl14k;
            kotumserlik5_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik5_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik5_3_maliyet_pl13.Location = pl13k;
            kotumserlik5_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik5_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik5_3_maliyet_pl12.Location = pl12k;
            kotumserlik5_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik5_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl5.Controls.Add(kotumserlik5_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik5_3_maliyet_pl11.Name = "pl11";
            kotumserlik5_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik5_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik5_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl11.Click += new EventHandler(kotumserlik5_3_maliyet_pl11_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik5_3_maliyet_pl10.Name = "pl10";
            kotumserlik5_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik5_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl10.Click += new EventHandler(kotumserlik5_3_maliyet_pl10_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik5_3_maliyet_pl9.Name = "pl9";
            kotumserlik5_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik5_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl9.Click += new EventHandler(kotumserlik5_3_maliyet_pl9_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik5_3_maliyet_pl8.Name = "pl8";
            kotumserlik5_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik5_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl8.Click += new EventHandler(kotumserlik5_3_maliyet_pl8_Click);
            kotumserlik5_3_maliyet_pl7.Controls.Add(kotumserlik5_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik5_3_maliyet_pl6.Name = "pl6";
            kotumserlik5_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik5_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl6.Click += new EventHandler(kotumserlik5_3_maliyet_pl6_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik5_3_maliyet_btn3.Name = "btn3";
            kotumserlik5_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik5_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik5_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_btn3.Click += new EventHandler(kotumserlik5_3_maliyet_btn3_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik5_3_maliyet_btn2.Name = "btn2";
            kotumserlik5_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik5_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik5_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik5_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik5_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_btn2.Click += new EventHandler(kotumserlik5_3_maliyet_btn2_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik5_3_maliyet_btn1.Name = "btn1";
            kotumserlik5_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik5_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik5_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik5_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik5_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik5_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik5_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik5_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_btn1.Click += new EventHandler(kotumserlik5_3_maliyet_btn1_Click);
            kotumserlik5_3_maliyet_pl2.Controls.Add(kotumserlik5_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik5_3_maliyet_dr1.Name = "dr1";
            kotumserlik5_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik5_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik5_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik5_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik5_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik5_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik5_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik5_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik5_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik5_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik5_3_maliyet_dr1_CellEnter);
            kotumserlik5_3_maliyet_tb1_2.Controls.Add(kotumserlik5_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik5_3_maliyet_pl7.Name = "pl7";
            kotumserlik5_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik5_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik5_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_tb1_2.Controls.Add(kotumserlik5_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik5_3_maliyet_pl5.Name = "pl5";
            kotumserlik5_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik5_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik5_3_maliyet_pl5.AutoScroll = true;
            kotumserlik5_3_maliyet_pl5.AutoSize = true;
            kotumserlik5_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik5_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_tb1_1.Controls.Add(kotumserlik5_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik5_3_maliyet_rt1.Name = "rt1";
            kotumserlik5_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik5_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik5_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_rt1.Enabled = false;
            kotumserlik5_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik5_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik5_3_maliyet_tb1_3.Controls.Add(kotumserlik5_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik5_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik5_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik5_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik5_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_tb1.Controls.Add(kotumserlik5_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik5_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik5_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik5_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik5_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_tb1.Controls.Add(kotumserlik5_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik5_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik5_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik5_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik5_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_tb1.Controls.Add(kotumserlik5_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik5_3_maliyet_tb1.Name = "tb1";
            kotumserlik5_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik5_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik5_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik5_3_maliyet_pl3.Controls.Add(kotumserlik5_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik5_3_maliyet_pl4.Name = "pl4";
            kotumserlik5_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik5_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik5_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik5_3_maliyet_pl4_MouseUp);
            kotumserlik5_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik5_3_maliyet_pl4_MouseMove);
            kotumserlik5_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik5_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik5_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik5_3_maliyet_pl3.Name = "pl3";
            kotumserlik5_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik5_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik5_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik5_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik5_3_maliyet_pl2.Name = "pl2";
            kotumserlik5_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik5_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik5_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik5_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik5_3_maliyet_pl1.Name = "pl1";
            kotumserlik5_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik5_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik5_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik5_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik5_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik5_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik5_3_maliyet_pl1_MouseUp);
            kotumserlik5_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik5_3_maliyet_pl1_MouseMove);
            kotumserlik5_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik5_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik5_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik6_3_maliyet form nesne tasarımları
        public void kotumserlik6_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik6_3_maliyet_sonuc = new Label();
            kotumserlik6_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik6_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik6_3_maliyet_sonuc.Location = sonuc;
            kotumserlik6_3_maliyet_sonuc.Text = "";
            kotumserlik6_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik6_3_maliyet_pl4.Controls.Add(kotumserlik6_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik6_3_maliyet_sonucbaslik = new Label();
            kotumserlik6_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik6_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik6_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik6_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik6_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik6_3_maliyet_pl4.Controls.Add(kotumserlik6_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik6_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik6_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik6_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik6_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik6_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik6_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik6_3_maliyet_pl28.Controls.Add(kotumserlik6_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri18 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri18.Location = txt_veri18;
            kotumserlik6_3_maliyet_txt_veri18.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl49.Controls.Add(kotumserlik6_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri17 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri17.Location = txt_veri17;
            kotumserlik6_3_maliyet_txt_veri17.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl48.Controls.Add(kotumserlik6_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri16 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri16.Location = txt_veri16;
            kotumserlik6_3_maliyet_txt_veri16.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl47.Controls.Add(kotumserlik6_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri15 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri15.Location = txt_veri15;
            kotumserlik6_3_maliyet_txt_veri15.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl44.Controls.Add(kotumserlik6_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri14 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri14.Location = txt_veri14;
            kotumserlik6_3_maliyet_txt_veri14.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl43.Controls.Add(kotumserlik6_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri13 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri13.Location = txt_veri13;
            kotumserlik6_3_maliyet_txt_veri13.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl42.Controls.Add(kotumserlik6_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri12 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri12.Location = txt_veri12;
            kotumserlik6_3_maliyet_txt_veri12.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl39.Controls.Add(kotumserlik6_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri11 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri11.Location = txt_veri11;
            kotumserlik6_3_maliyet_txt_veri11.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl38.Controls.Add(kotumserlik6_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri10 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri10.Location = txt_veri10;
            kotumserlik6_3_maliyet_txt_veri10.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl37.Controls.Add(kotumserlik6_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri9 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri9.Location = txt_veri9;
            kotumserlik6_3_maliyet_txt_veri9.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl34.Controls.Add(kotumserlik6_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri8 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri8.Location = txt_veri8;
            kotumserlik6_3_maliyet_txt_veri8.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl33.Controls.Add(kotumserlik6_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri7 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri7.Location = txt_veri7;
            kotumserlik6_3_maliyet_txt_veri7.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl32.Controls.Add(kotumserlik6_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik6_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl27.Controls.Add(kotumserlik6_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik6_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl23.Controls.Add(kotumserlik6_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik6_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl22.Controls.Add(kotumserlik6_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik6_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl26.Controls.Add(kotumserlik6_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik6_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl21.Controls.Add(kotumserlik6_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik6_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik6_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik6_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl20.Controls.Add(kotumserlik6_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f6sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f6sonuc.Location = txt_txtf6sonuc;
            kotumserlik6_3_maliyet_txt_f6sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f6sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f6sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl50.Controls.Add(kotumserlik6_3_maliyet_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f5sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            kotumserlik6_3_maliyet_txt_f5sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f5sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl45.Controls.Add(kotumserlik6_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f4sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            kotumserlik6_3_maliyet_txt_f4sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f4sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl40.Controls.Add(kotumserlik6_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f3sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            kotumserlik6_3_maliyet_txt_f3sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f3sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl35.Controls.Add(kotumserlik6_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik6_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl30.Controls.Add(kotumserlik6_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik6_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik6_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik6_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik6_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik6_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik6_3_maliyet_pl29.Controls.Add(kotumserlik6_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------        

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik6_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik6_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik6_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik6_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik6_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik6_3_maliyet_pl24.Controls.Add(kotumserlik6_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik6_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik6_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik6_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik6_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik6_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik6_3_maliyet_pl17.Controls.Add(kotumserlik6_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik6_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik6_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik6_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik6_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik6_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik6_3_maliyet_pl16.Controls.Add(kotumserlik6_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik6 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            kotumserlik6_3_maliyet_txt_altbaslik6.Text = "F6";
            kotumserlik6_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik6.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik6.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl46.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik5 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            kotumserlik6_3_maliyet_txt_altbaslik5.Text = "F5";
            kotumserlik6_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik5.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik5.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl41.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik4 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            kotumserlik6_3_maliyet_txt_altbaslik4.Text = "F4";
            kotumserlik6_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik4.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik4.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl36.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik3 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            kotumserlik6_3_maliyet_txt_altbaslik3.Text = "F3";
            kotumserlik6_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik3.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik3.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl31.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik6_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik6_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl15.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik6_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik6_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik6_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik6_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl14.Controls.Add(kotumserlik6_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik6_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik6_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik6_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik6_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl13.Controls.Add(kotumserlik6_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik6_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik6_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik6_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik6_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik6_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik6_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik6_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik6_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik6_3_maliyet_pl12.Controls.Add(kotumserlik6_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            kotumserlik6_3_maliyet_pl50.Location = pl50k;
            kotumserlik6_3_maliyet_pl50.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            kotumserlik6_3_maliyet_pl45.Location = pl45k;
            kotumserlik6_3_maliyet_pl45.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            kotumserlik6_3_maliyet_pl40.Location = pl40k;
            kotumserlik6_3_maliyet_pl40.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            kotumserlik6_3_maliyet_pl35.Location = pl35k;
            kotumserlik6_3_maliyet_pl35.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik6_3_maliyet_pl30.Location = pl30k;
            kotumserlik6_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik6_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik6_3_maliyet_pl29.Location = pl29k;
            kotumserlik6_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik6_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik6_3_maliyet_pl28.Location = pl28k;
            kotumserlik6_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik6_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            kotumserlik6_3_maliyet_pl49.Location = pl49k;
            kotumserlik6_3_maliyet_pl49.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            kotumserlik6_3_maliyet_pl48.Location = pl48k;
            kotumserlik6_3_maliyet_pl48.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            kotumserlik6_3_maliyet_pl47.Location = pl47k;
            kotumserlik6_3_maliyet_pl47.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            kotumserlik6_3_maliyet_pl44.Location = pl44k;
            kotumserlik6_3_maliyet_pl44.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            kotumserlik6_3_maliyet_pl43.Location = pl43k;
            kotumserlik6_3_maliyet_pl43.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            kotumserlik6_3_maliyet_pl42.Location = pl42k;
            kotumserlik6_3_maliyet_pl42.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            kotumserlik6_3_maliyet_pl39.Location = pl39k;
            kotumserlik6_3_maliyet_pl39.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            kotumserlik6_3_maliyet_pl38.Location = pl38k;
            kotumserlik6_3_maliyet_pl38.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            kotumserlik6_3_maliyet_pl37.Location = pl37k;
            kotumserlik6_3_maliyet_pl37.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            kotumserlik6_3_maliyet_pl34.Location = pl34k;
            kotumserlik6_3_maliyet_pl34.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            kotumserlik6_3_maliyet_pl33.Location = pl33k;
            kotumserlik6_3_maliyet_pl33.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            kotumserlik6_3_maliyet_pl32.Location = pl32k;
            kotumserlik6_3_maliyet_pl32.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik6_3_maliyet_pl27.Location = pl27k;
            kotumserlik6_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik6_3_maliyet_pl26.Location = pl26k;
            kotumserlik6_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik6_3_maliyet_pl23.Location = pl23k;
            kotumserlik6_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik6_3_maliyet_pl22.Location = pl22k;
            kotumserlik6_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik6_3_maliyet_pl21.Location = pl21k;
            kotumserlik6_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik6_3_maliyet_pl20.Location = pl20k;
            kotumserlik6_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik6_3_maliyet_pl25.Location = pl25k;
            kotumserlik6_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik6_3_maliyet_pl19.Location = pl19k;
            kotumserlik6_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik6_3_maliyet_pl18.Location = pl18k;
            kotumserlik6_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik6_3_maliyet_pl24.Location = pl24k;
            kotumserlik6_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik6_3_maliyet_pl17.Location = pl17k;
            kotumserlik6_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik6_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik6_3_maliyet_pl16.Location = pl16k;
            kotumserlik6_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik6_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            kotumserlik6_3_maliyet_pl46.Location = pl46k;
            kotumserlik6_3_maliyet_pl46.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            kotumserlik6_3_maliyet_pl41.Location = pl41k;
            kotumserlik6_3_maliyet_pl41.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            kotumserlik6_3_maliyet_pl36.Location = pl36k;
            kotumserlik6_3_maliyet_pl36.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            kotumserlik6_3_maliyet_pl31.Location = pl31k;
            kotumserlik6_3_maliyet_pl31.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik6_3_maliyet_pl15.Location = pl15k;
            kotumserlik6_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik6_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik6_3_maliyet_pl14.Location = pl14k;
            kotumserlik6_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik6_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik6_3_maliyet_pl13.Location = pl13k;
            kotumserlik6_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik6_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik6_3_maliyet_pl12.Location = pl12k;
            kotumserlik6_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik6_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl5.Controls.Add(kotumserlik6_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik6_3_maliyet_pl11.Name = "pl11";
            kotumserlik6_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik6_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik6_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl11.Click += new EventHandler(kotumserlik6_3_maliyet_pl11_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik6_3_maliyet_pl10.Name = "pl10";
            kotumserlik6_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik6_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl10.Click += new EventHandler(kotumserlik6_3_maliyet_pl10_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik6_3_maliyet_pl9.Name = "pl9";
            kotumserlik6_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik6_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl9.Click += new EventHandler(kotumserlik6_3_maliyet_pl9_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik6_3_maliyet_pl8.Name = "pl8";
            kotumserlik6_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik6_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl8.Click += new EventHandler(kotumserlik6_3_maliyet_pl8_Click);
            kotumserlik6_3_maliyet_pl7.Controls.Add(kotumserlik6_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik6_3_maliyet_pl6.Name = "pl6";
            kotumserlik6_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik6_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl6.Click += new EventHandler(kotumserlik6_3_maliyet_pl6_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik6_3_maliyet_btn3.Name = "btn3";
            kotumserlik6_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik6_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik6_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_btn3.Click += new EventHandler(kotumserlik6_3_maliyet_btn3_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik6_3_maliyet_btn2.Name = "btn2";
            kotumserlik6_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik6_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik6_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik6_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik6_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_btn2.Click += new EventHandler(kotumserlik6_3_maliyet_btn2_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik6_3_maliyet_btn1.Name = "btn1";
            kotumserlik6_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik6_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik6_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik6_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik6_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik6_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik6_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik6_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_btn1.Click += new EventHandler(kotumserlik6_3_maliyet_btn1_Click);
            kotumserlik6_3_maliyet_pl2.Controls.Add(kotumserlik6_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik6_3_maliyet_dr1.Name = "dr1";
            kotumserlik6_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik6_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik6_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik6_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik6_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik6_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik6_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik6_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik6_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik6_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik6_3_maliyet_dr1_CellEnter);
            kotumserlik6_3_maliyet_tb1_2.Controls.Add(kotumserlik6_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik6_3_maliyet_pl7.Name = "pl7";
            kotumserlik6_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik6_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik6_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_tb1_2.Controls.Add(kotumserlik6_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik6_3_maliyet_pl5.Name = "pl5";
            kotumserlik6_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik6_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik6_3_maliyet_pl5.AutoScroll = true;
            kotumserlik6_3_maliyet_pl5.AutoSize = true;
            kotumserlik6_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik6_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_tb1_1.Controls.Add(kotumserlik6_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik6_3_maliyet_rt1.Name = "rt1";
            kotumserlik6_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik6_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik6_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_rt1.Enabled = false;
            kotumserlik6_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik6_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik6_3_maliyet_tb1_3.Controls.Add(kotumserlik6_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik6_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik6_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik6_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik6_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_tb1.Controls.Add(kotumserlik6_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik6_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik6_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik6_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik6_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_tb1.Controls.Add(kotumserlik6_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik6_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik6_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik6_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik6_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_tb1.Controls.Add(kotumserlik6_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik6_3_maliyet_tb1.Name = "tb1";
            kotumserlik6_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik6_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik6_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik6_3_maliyet_pl3.Controls.Add(kotumserlik6_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik6_3_maliyet_pl4.Name = "pl4";
            kotumserlik6_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik6_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik6_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik6_3_maliyet_pl4_MouseUp);
            kotumserlik6_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik6_3_maliyet_pl4_MouseMove);
            kotumserlik6_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik6_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik6_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik6_3_maliyet_pl3.Name = "pl3";
            kotumserlik6_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik6_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik6_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik6_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik6_3_maliyet_pl2.Name = "pl2";
            kotumserlik6_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik6_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik6_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik6_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik6_3_maliyet_pl1.Name = "pl1";
            kotumserlik6_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik6_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik6_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik6_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik6_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik6_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik6_3_maliyet_pl1_MouseUp);
            kotumserlik6_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik6_3_maliyet_pl1_MouseMove);
            kotumserlik6_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik6_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik6_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik7_3_maliyet form nesne tasarımları
        public void kotumserlik7_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            kotumserlik7_3_maliyet_sonuc = new Label();
            kotumserlik7_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            kotumserlik7_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik7_3_maliyet_sonuc.Location = sonuc;
            kotumserlik7_3_maliyet_sonuc.Text = "";
            kotumserlik7_3_maliyet_sonuc.Size = new Size(650, 13);
            kotumserlik7_3_maliyet_pl4.Controls.Add(kotumserlik7_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet isMaximaxi Label  olarak yerleştirir
            kotumserlik7_3_maliyet_sonucbaslik = new Label();
            kotumserlik7_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            kotumserlik7_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik7_3_maliyet_sonucbaslik.Location = sonucbaslik;
            kotumserlik7_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            kotumserlik7_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            kotumserlik7_3_maliyet_pl4.Controls.Add(kotumserlik7_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            kotumserlik7_3_maliyet_sonuclarortabaslik = new Label();
            kotumserlik7_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            kotumserlik7_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            kotumserlik7_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            kotumserlik7_3_maliyet_sonuclarortabaslik.Text = "Maximax";
            kotumserlik7_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            kotumserlik7_3_maliyet_pl28.Controls.Add(kotumserlik7_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri21 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri21.Location = txt_veri21;
            kotumserlik7_3_maliyet_txt_veri21.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl54.Controls.Add(kotumserlik7_3_maliyet_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri20 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri20.Location = txt_veri20;
            kotumserlik7_3_maliyet_txt_veri20.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl53.Controls.Add(kotumserlik7_3_maliyet_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri19 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri19.Location = txt_veri19;
            kotumserlik7_3_maliyet_txt_veri19.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl52.Controls.Add(kotumserlik7_3_maliyet_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri18 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri18.Location = txt_veri18;
            kotumserlik7_3_maliyet_txt_veri18.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl49.Controls.Add(kotumserlik7_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri17 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri17.Location = txt_veri17;
            kotumserlik7_3_maliyet_txt_veri17.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl48.Controls.Add(kotumserlik7_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri16 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri16.Location = txt_veri16;
            kotumserlik7_3_maliyet_txt_veri16.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl47.Controls.Add(kotumserlik7_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri15 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri15.Location = txt_veri15;
            kotumserlik7_3_maliyet_txt_veri15.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl44.Controls.Add(kotumserlik7_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri14 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri14.Location = txt_veri14;
            kotumserlik7_3_maliyet_txt_veri14.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl43.Controls.Add(kotumserlik7_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri13 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri13.Location = txt_veri13;
            kotumserlik7_3_maliyet_txt_veri13.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl42.Controls.Add(kotumserlik7_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri12 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri12.Location = txt_veri12;
            kotumserlik7_3_maliyet_txt_veri12.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl39.Controls.Add(kotumserlik7_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri11 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri11.Location = txt_veri11;
            kotumserlik7_3_maliyet_txt_veri11.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl38.Controls.Add(kotumserlik7_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri10 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri10.Location = txt_veri10;
            kotumserlik7_3_maliyet_txt_veri10.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl37.Controls.Add(kotumserlik7_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri9 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri9.Location = txt_veri9;
            kotumserlik7_3_maliyet_txt_veri9.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl34.Controls.Add(kotumserlik7_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri8 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri8.Location = txt_veri8;
            kotumserlik7_3_maliyet_txt_veri8.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl33.Controls.Add(kotumserlik7_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri7 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri7.Location = txt_veri7;
            kotumserlik7_3_maliyet_txt_veri7.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl32.Controls.Add(kotumserlik7_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri6 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri6.Location = txt_veri6;
            kotumserlik7_3_maliyet_txt_veri6.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl27.Controls.Add(kotumserlik7_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri5 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri5.Location = txt_veri5;
            kotumserlik7_3_maliyet_txt_veri5.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl23.Controls.Add(kotumserlik7_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri4 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri4.Location = txt_veri4;
            kotumserlik7_3_maliyet_txt_veri4.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl22.Controls.Add(kotumserlik7_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri3 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri3.Location = txt_veri3;
            kotumserlik7_3_maliyet_txt_veri3.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl26.Controls.Add(kotumserlik7_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri2 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri2.Location = txt_veri2;
            kotumserlik7_3_maliyet_txt_veri2.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl21.Controls.Add(kotumserlik7_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_veri1 = new NumericUpDown();
            kotumserlik7_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            kotumserlik7_3_maliyet_txt_veri1.Location = txt_veri1;
            kotumserlik7_3_maliyet_txt_veri1.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl20.Controls.Add(kotumserlik7_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel55 içerisine f7sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f7sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f7sonuc.Name = "txtf7sonuc";
            Point txt_txtf7sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f7sonuc.Location = txt_txtf7sonuc;
            kotumserlik7_3_maliyet_txt_f7sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f7sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f7sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl55.Controls.Add(kotumserlik7_3_maliyet_txt_f7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f6sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f6sonuc.Location = txt_txtf6sonuc;
            kotumserlik7_3_maliyet_txt_f6sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f6sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f6sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl50.Controls.Add(kotumserlik7_3_maliyet_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f5sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            kotumserlik7_3_maliyet_txt_f5sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f5sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl45.Controls.Add(kotumserlik7_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f4sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            kotumserlik7_3_maliyet_txt_f4sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f4sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl40.Controls.Add(kotumserlik7_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f3sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            kotumserlik7_3_maliyet_txt_f3sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f3sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl35.Controls.Add(kotumserlik7_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f2sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            kotumserlik7_3_maliyet_txt_f2sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f2sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl30.Controls.Add(kotumserlik7_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_f1sonuc = new TextBox();
            kotumserlik7_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            kotumserlik7_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            kotumserlik7_3_maliyet_txt_f1sonuc.Text = "0";
            kotumserlik7_3_maliyet_txt_f1sonuc.Enabled = false;
            kotumserlik7_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            kotumserlik7_3_maliyet_pl29.Controls.Add(kotumserlik7_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------          

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_üstbaslik3 = new TextBox();
            kotumserlik7_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            kotumserlik7_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            kotumserlik7_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            kotumserlik7_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_üstbaslik3.Multiline = true;
            kotumserlik7_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            kotumserlik7_3_maliyet_pl24.Controls.Add(kotumserlik7_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_üstbaslik2 = new TextBox();
            kotumserlik7_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            kotumserlik7_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            kotumserlik7_3_maliyet_txt_üstbaslik2.Text = "Orta";
            kotumserlik7_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_üstbaslik2.Multiline = true;
            kotumserlik7_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            kotumserlik7_3_maliyet_pl17.Controls.Add(kotumserlik7_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_üstbaslik1 = new TextBox();
            kotumserlik7_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            kotumserlik7_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            kotumserlik7_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            kotumserlik7_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_üstbaslik1.Multiline = true;
            kotumserlik7_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            kotumserlik7_3_maliyet_pl16.Controls.Add(kotumserlik7_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik7 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik7.Location = txt_txtaltbaslik7;
            kotumserlik7_3_maliyet_txt_altbaslik7.Text = "F7";
            kotumserlik7_3_maliyet_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik7.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik7.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik7.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl51.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik6 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            kotumserlik7_3_maliyet_txt_altbaslik6.Text = "F6";
            kotumserlik7_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik6.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik6.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl46.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik5 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            kotumserlik7_3_maliyet_txt_altbaslik5.Text = "F5";
            kotumserlik7_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik5.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik5.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl41.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik4 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            kotumserlik7_3_maliyet_txt_altbaslik4.Text = "F4";
            kotumserlik7_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik4.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik4.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl36.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik3 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            kotumserlik7_3_maliyet_txt_altbaslik3.Text = "F3";
            kotumserlik7_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik3.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik3.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl31.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik2 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            kotumserlik7_3_maliyet_txt_altbaslik2.Text = "F2";
            kotumserlik7_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik2.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik2.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl15.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_altbaslik1 = new TextBox();
            kotumserlik7_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            kotumserlik7_3_maliyet_txt_altbaslik1.Text = "F1";
            kotumserlik7_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_altbaslik1.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_altbaslik1.Multiline = true;
            kotumserlik7_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl14.Controls.Add(kotumserlik7_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_baslik2 = new TextBox();
            kotumserlik7_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_baslik2.Location = txt_baslik2;
            kotumserlik7_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            kotumserlik7_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_baslik2.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_baslik2.Multiline = true;
            kotumserlik7_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl13.Controls.Add(kotumserlik7_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            kotumserlik7_3_maliyet_txt_baslik1 = new TextBox();
            kotumserlik7_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            kotumserlik7_3_maliyet_txt_baslik1.Location = txt_baslik1;
            kotumserlik7_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            kotumserlik7_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            kotumserlik7_3_maliyet_txt_baslik1.MaxLength = 30;
            kotumserlik7_3_maliyet_txt_baslik1.Multiline = true;
            kotumserlik7_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            kotumserlik7_3_maliyet_pl12.Controls.Add(kotumserlik7_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel55 oluşturuldu  f7-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            kotumserlik7_3_maliyet_pl55.Location = pl55k;
            kotumserlik7_3_maliyet_pl55.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl55.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            kotumserlik7_3_maliyet_pl50.Location = pl50k;
            kotumserlik7_3_maliyet_pl50.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            kotumserlik7_3_maliyet_pl45.Location = pl45k;
            kotumserlik7_3_maliyet_pl45.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            kotumserlik7_3_maliyet_pl40.Location = pl40k;
            kotumserlik7_3_maliyet_pl40.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            kotumserlik7_3_maliyet_pl35.Location = pl35k;
            kotumserlik7_3_maliyet_pl35.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            kotumserlik7_3_maliyet_pl30.Location = pl30k;
            kotumserlik7_3_maliyet_pl30.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            kotumserlik7_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            kotumserlik7_3_maliyet_pl29.Location = pl29k;
            kotumserlik7_3_maliyet_pl29.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            kotumserlik7_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            kotumserlik7_3_maliyet_pl28.Location = pl28k;
            kotumserlik7_3_maliyet_pl28.Size = new Size(91, 72);
            kotumserlik7_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            kotumserlik7_3_maliyet_pl54.Location = pl54k;
            kotumserlik7_3_maliyet_pl54.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl54.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            kotumserlik7_3_maliyet_pl53.Location = pl53k;
            kotumserlik7_3_maliyet_pl53.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl53.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            kotumserlik7_3_maliyet_pl52.Location = pl52k;
            kotumserlik7_3_maliyet_pl52.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl52.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            kotumserlik7_3_maliyet_pl49.Location = pl49k;
            kotumserlik7_3_maliyet_pl49.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            kotumserlik7_3_maliyet_pl48.Location = pl48k;
            kotumserlik7_3_maliyet_pl48.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            kotumserlik7_3_maliyet_pl47.Location = pl47k;
            kotumserlik7_3_maliyet_pl47.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            kotumserlik7_3_maliyet_pl44.Location = pl44k;
            kotumserlik7_3_maliyet_pl44.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            kotumserlik7_3_maliyet_pl43.Location = pl43k;
            kotumserlik7_3_maliyet_pl43.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            kotumserlik7_3_maliyet_pl42.Location = pl42k;
            kotumserlik7_3_maliyet_pl42.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            kotumserlik7_3_maliyet_pl39.Location = pl39k;
            kotumserlik7_3_maliyet_pl39.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            kotumserlik7_3_maliyet_pl38.Location = pl38k;
            kotumserlik7_3_maliyet_pl38.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            kotumserlik7_3_maliyet_pl37.Location = pl37k;
            kotumserlik7_3_maliyet_pl37.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            kotumserlik7_3_maliyet_pl34.Location = pl34k;
            kotumserlik7_3_maliyet_pl34.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            kotumserlik7_3_maliyet_pl33.Location = pl33k;
            kotumserlik7_3_maliyet_pl33.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            kotumserlik7_3_maliyet_pl32.Location = pl32k;
            kotumserlik7_3_maliyet_pl32.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            kotumserlik7_3_maliyet_pl27.Location = pl27k;
            kotumserlik7_3_maliyet_pl27.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            kotumserlik7_3_maliyet_pl26.Location = pl26k;
            kotumserlik7_3_maliyet_pl26.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            kotumserlik7_3_maliyet_pl23.Location = pl23k;
            kotumserlik7_3_maliyet_pl23.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            kotumserlik7_3_maliyet_pl22.Location = pl22k;
            kotumserlik7_3_maliyet_pl22.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            kotumserlik7_3_maliyet_pl21.Location = pl21k;
            kotumserlik7_3_maliyet_pl21.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            kotumserlik7_3_maliyet_pl20.Location = pl20k;
            kotumserlik7_3_maliyet_pl20.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            kotumserlik7_3_maliyet_pl25.Location = pl25k;
            kotumserlik7_3_maliyet_pl25.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            kotumserlik7_3_maliyet_pl19.Location = pl19k;
            kotumserlik7_3_maliyet_pl19.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            kotumserlik7_3_maliyet_pl18.Location = pl18k;
            kotumserlik7_3_maliyet_pl18.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            kotumserlik7_3_maliyet_pl24.Location = pl24k;
            kotumserlik7_3_maliyet_pl24.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            kotumserlik7_3_maliyet_pl17.Location = pl17k;
            kotumserlik7_3_maliyet_pl17.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            kotumserlik7_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            kotumserlik7_3_maliyet_pl16.Location = pl16k;
            kotumserlik7_3_maliyet_pl16.Size = new Size(91, 33);
            kotumserlik7_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            kotumserlik7_3_maliyet_pl51.Location = pl51k;
            kotumserlik7_3_maliyet_pl51.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl51.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            kotumserlik7_3_maliyet_pl46.Location = pl46k;
            kotumserlik7_3_maliyet_pl46.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            kotumserlik7_3_maliyet_pl41.Location = pl41k;
            kotumserlik7_3_maliyet_pl41.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            kotumserlik7_3_maliyet_pl36.Location = pl36k;
            kotumserlik7_3_maliyet_pl36.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            kotumserlik7_3_maliyet_pl31.Location = pl31k;
            kotumserlik7_3_maliyet_pl31.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            kotumserlik7_3_maliyet_pl15.Location = pl15k;
            kotumserlik7_3_maliyet_pl15.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            kotumserlik7_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            kotumserlik7_3_maliyet_pl14.Location = pl14k;
            kotumserlik7_3_maliyet_pl14.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            kotumserlik7_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            kotumserlik7_3_maliyet_pl13.Location = pl13k;
            kotumserlik7_3_maliyet_pl13.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            kotumserlik7_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            kotumserlik7_3_maliyet_pl12.Location = pl12k;
            kotumserlik7_3_maliyet_pl12.Size = new Size(168, 33);
            kotumserlik7_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl5.Controls.Add(kotumserlik7_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            kotumserlik7_3_maliyet_pl11.Name = "pl11";
            kotumserlik7_3_maliyet_pl11.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_pl11.Dock = DockStyle.Left;
            kotumserlik7_3_maliyet_pl11.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            kotumserlik7_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl11.Click += new EventHandler(kotumserlik7_3_maliyet_pl11_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            kotumserlik7_3_maliyet_pl10.Name = "pl10";
            kotumserlik7_3_maliyet_pl10.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_pl10.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_pl10.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            kotumserlik7_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl10.Click += new EventHandler(kotumserlik7_3_maliyet_pl10_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            kotumserlik7_3_maliyet_pl9.Name = "pl9";
            kotumserlik7_3_maliyet_pl9.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_pl9.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_pl9.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            kotumserlik7_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl9.Click += new EventHandler(kotumserlik7_3_maliyet_pl9_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            kotumserlik7_3_maliyet_pl8.Name = "pl8";
            kotumserlik7_3_maliyet_pl8.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_pl8.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_pl8.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            kotumserlik7_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl8.Click += new EventHandler(kotumserlik7_3_maliyet_pl8_Click);
            kotumserlik7_3_maliyet_pl7.Controls.Add(kotumserlik7_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            kotumserlik7_3_maliyet_pl6.Name = "pl6";
            kotumserlik7_3_maliyet_pl6.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_pl6.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_pl6.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            kotumserlik7_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl6.Click += new EventHandler(kotumserlik7_3_maliyet_pl6_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            kotumserlik7_3_maliyet_btn3.Name = "btn3";
            kotumserlik7_3_maliyet_btn3.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_btn3.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            kotumserlik7_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_btn3.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            kotumserlik7_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_btn3.Click += new EventHandler(kotumserlik7_3_maliyet_btn3_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            kotumserlik7_3_maliyet_btn2.Name = "btn2";
            kotumserlik7_3_maliyet_btn2.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_btn2.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            kotumserlik7_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik7_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik7_3_maliyet_btn2.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            kotumserlik7_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_btn2.Click += new EventHandler(kotumserlik7_3_maliyet_btn2_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            kotumserlik7_3_maliyet_btn1.Name = "btn1";
            kotumserlik7_3_maliyet_btn1.Size = new Size(65, 50);
            kotumserlik7_3_maliyet_btn1.Dock = DockStyle.Right;
            kotumserlik7_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            kotumserlik7_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            kotumserlik7_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            kotumserlik7_3_maliyet_btn1.BackColor = Color.Transparent;
            kotumserlik7_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            kotumserlik7_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_btn1.Click += new EventHandler(kotumserlik7_3_maliyet_btn1_Click);
            kotumserlik7_3_maliyet_pl2.Controls.Add(kotumserlik7_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            kotumserlik7_3_maliyet_dr1.Name = "dr1";
            kotumserlik7_3_maliyet_dr1.Size = new Size(851, 498);
            kotumserlik7_3_maliyet_dr1.Dock = DockStyle.Fill;
            kotumserlik7_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_dr1.AllowUserToAddRows = false;
            kotumserlik7_3_maliyet_dr1.AllowUserToDeleteRows = false;
            kotumserlik7_3_maliyet_dr1.AllowUserToResizeColumns = false;
            kotumserlik7_3_maliyet_dr1.AllowUserToResizeRows = false;
            kotumserlik7_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kotumserlik7_3_maliyet_dr1.RowHeadersVisible = false;
            kotumserlik7_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kotumserlik7_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(kotumserlik7_3_maliyet_dr1_CellEnter);
            kotumserlik7_3_maliyet_tb1_2.Controls.Add(kotumserlik7_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            kotumserlik7_3_maliyet_pl7.Name = "pl7";
            kotumserlik7_3_maliyet_pl7.Size = new Size(865, 50);
            kotumserlik7_3_maliyet_pl7.Dock = DockStyle.Top;
            kotumserlik7_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_tb1_2.Controls.Add(kotumserlik7_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            kotumserlik7_3_maliyet_pl5.Name = "pl5";
            kotumserlik7_3_maliyet_pl5.Size = new Size(851, 498);
            kotumserlik7_3_maliyet_pl5.Dock = DockStyle.Fill;
            kotumserlik7_3_maliyet_pl5.AutoScroll = true;
            kotumserlik7_3_maliyet_pl5.AutoSize = true;
            kotumserlik7_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            kotumserlik7_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_tb1_1.Controls.Add(kotumserlik7_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            kotumserlik7_3_maliyet_rt1.Name = "rt1";
            kotumserlik7_3_maliyet_rt1.Size = new Size(851, 498);
            kotumserlik7_3_maliyet_rt1.Dock = DockStyle.Fill;
            kotumserlik7_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_rt1.Enabled = false;
            kotumserlik7_3_maliyet_rt1.Text = "•Güvenlik düzeyi en büyük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            kotumserlik7_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kotumserlik7_3_maliyet_tb1_3.Controls.Add(kotumserlik7_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            kotumserlik7_3_maliyet_tb1_1.Name = "tb1_1";
            kotumserlik7_3_maliyet_tb1_1.Text = "Tablo";
            kotumserlik7_3_maliyet_tb1_1.Size = new Size(651, 50);
            kotumserlik7_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_tb1.Controls.Add(kotumserlik7_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            kotumserlik7_3_maliyet_tb1_2.Name = "tb1_2";
            kotumserlik7_3_maliyet_tb1_2.Text = "Veri Tabanı";
            kotumserlik7_3_maliyet_tb1_2.Size = new Size(651, 50);
            kotumserlik7_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_tb1.Controls.Add(kotumserlik7_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            kotumserlik7_3_maliyet_tb1_3.Name = "tb1_3";
            kotumserlik7_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            kotumserlik7_3_maliyet_tb1_3.Size = new Size(651, 50);
            kotumserlik7_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_tb1.Controls.Add(kotumserlik7_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            kotumserlik7_3_maliyet_tb1.Name = "tb1";
            kotumserlik7_3_maliyet_tb1.Size = new Size(651, 50);
            kotumserlik7_3_maliyet_tb1.Dock = DockStyle.Fill;
            kotumserlik7_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            kotumserlik7_3_maliyet_pl3.Controls.Add(kotumserlik7_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            kotumserlik7_3_maliyet_pl4.Name = "pl4";
            kotumserlik7_3_maliyet_pl4.Size = new Size(865, 50);
            kotumserlik7_3_maliyet_pl4.Dock = DockStyle.Bottom;
            kotumserlik7_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl4.MouseUp += new MouseEventHandler(kotumserlik7_3_maliyet_pl4_MouseUp);
            kotumserlik7_3_maliyet_pl4.MouseMove += new MouseEventHandler(kotumserlik7_3_maliyet_pl4_MouseMove);
            kotumserlik7_3_maliyet_pl4.MouseDown += new MouseEventHandler(kotumserlik7_3_maliyet_pl4_MouseDown);
            this.Controls.Add(kotumserlik7_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            kotumserlik7_3_maliyet_pl3.Name = "pl3";
            kotumserlik7_3_maliyet_pl3.Size = new Size(865, 530);
            kotumserlik7_3_maliyet_pl3.Dock = DockStyle.Top;
            kotumserlik7_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik7_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            kotumserlik7_3_maliyet_pl2.Name = "pl2";
            kotumserlik7_3_maliyet_pl2.Size = new Size(865, 50);
            kotumserlik7_3_maliyet_pl2.Dock = DockStyle.Top;
            kotumserlik7_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(kotumserlik7_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            kotumserlik7_3_maliyet_pl1.Name = "pl1";
            kotumserlik7_3_maliyet_pl1.Size = new Size(865, 50);
            kotumserlik7_3_maliyet_pl1.Dock = DockStyle.Top;
            kotumserlik7_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            kotumserlik7_3_maliyet_pl1.BackgroundImage = Properties.Resources.kotumserlikmaliyet;
            kotumserlik7_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            kotumserlik7_3_maliyet_pl1.MouseUp += new MouseEventHandler(kotumserlik7_3_maliyet_pl1_MouseUp);
            kotumserlik7_3_maliyet_pl1.MouseMove += new MouseEventHandler(kotumserlik7_3_maliyet_pl1_MouseMove);
            kotumserlik7_3_maliyet_pl1.MouseDown += new MouseEventHandler(kotumserlik7_3_maliyet_pl1_MouseDown);
            this.Controls.Add(kotumserlik7_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //kotumserlik2_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik2_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik2_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik2_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 16; i++)
            {
                kotumserlik2_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik3_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik3_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik3_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik3_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 21; i++)
            {
                kotumserlik3_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik4_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik4_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik4_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik4_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 26; i++)
            {
                kotumserlik4_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik5_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik5_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik5_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik5_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 31; i++)
            {
                kotumserlik5_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik6_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik6_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik6_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik6_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 36; i++)
            {
                kotumserlik6_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik7_3_maliyet veritabanına listelemek için kullanılır
        public void kotumserlik7_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From kotumserlik7_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            kotumserlik7_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 41; i++)
            {
                kotumserlik7_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //kotumserlik2_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik2_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik2_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik2_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik2_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik2_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik2_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik2_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik2_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik2_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik2_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik2_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik2_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik2_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik2_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik2_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik2_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik2_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik2_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik2_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik2_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik2_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik2_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik2_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik2_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik2_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik2_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik2_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik2_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik2_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik2_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                if (f1sonuc < f2sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik2_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,sonuc_1,sonuc_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@sonuc_1,@sonuc_2,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik2_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik2_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik2_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik2_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 2; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik2_3_maliyet where Id=" + kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik2_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik2_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik2_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik2_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik2_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik2_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik2_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik2_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                if (f1sonuc < f2sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik2_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                komut.Parameters.AddWithValue("@Id", id.ToString());

                kotumserlik2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik2_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik2_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik2_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik2_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik2_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik2_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik2_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //kotumserlik3_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik3_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik3_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik3_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik3_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik3_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik3_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik3_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik3_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik3_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik3_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik3_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik3_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik3_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik3_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik3_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik3_3_maliyet_pl32.Controls["txtveri7"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik3_3_maliyet_pl33.Controls["txtveri8"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                kotumserlik3_3_maliyet_pl34.Controls["txtveri9"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                kotumserlik3_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik3_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik3_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik3_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik3_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik3_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik3_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik3_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik3_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik3_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik3_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik3_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik3_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik3_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik3_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik3_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik3_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik3_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------           
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik3_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,sonuc_1,sonuc_2,sonuc_3,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@sonuc_1,@sonuc_2,@sonuc_3,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik3_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik3_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik3_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik3_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 5; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 5; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik3_3_maliyet where Id=" + kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik3_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik3_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik3_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik3_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik3_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik3_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik3_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik3_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik3_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik3_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik3_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------           
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik3_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik3_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik3_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik3_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik3_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik3_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik3_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik3_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //kotumserlik4_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik4_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik4_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik4_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik4_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik4_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik4_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik4_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik4_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik4_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik4_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik4_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik4_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik4_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik4_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik4_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik4_3_maliyet_pl32.Controls["txtveri7"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                kotumserlik4_3_maliyet_pl33.Controls["txtveri8"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                kotumserlik4_3_maliyet_pl34.Controls["txtveri9"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                kotumserlik4_3_maliyet_pl37.Controls["txtveri10"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                kotumserlik4_3_maliyet_pl38.Controls["txtveri11"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                kotumserlik4_3_maliyet_pl39.Controls["txtveri12"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                kotumserlik4_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik4_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik4_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik4_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik4_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik4_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik4_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik4_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik4_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik4_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik4_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik4_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik4_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik4_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik4_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik4_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik4_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik4_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik4_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik4_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik4_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik4_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,sonuc_1,sonuc_2,sonuc_3,sonuc_4,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik4_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik4_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik4_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik4_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik4_3_maliyet where Id=" + kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik4_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik4_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik4_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik4_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik4_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik4_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik4_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik4_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik4_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik4_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik4_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik4_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik4_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik4_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------       
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik4_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik4_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik4_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik4_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik4_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik4_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik4_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik4_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //kotumserlik5_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik5_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik5_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik5_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik5_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik5_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik5_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik5_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik5_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik5_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik5_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik5_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik5_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik5_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik5_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik5_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                kotumserlik5_3_maliyet_pl32.Controls["txtveri7"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                kotumserlik5_3_maliyet_pl33.Controls["txtveri8"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                kotumserlik5_3_maliyet_pl34.Controls["txtveri9"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                kotumserlik5_3_maliyet_pl37.Controls["txtveri10"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                kotumserlik5_3_maliyet_pl38.Controls["txtveri11"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                kotumserlik5_3_maliyet_pl39.Controls["txtveri12"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                kotumserlik5_3_maliyet_pl42.Controls["txtveri13"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                kotumserlik5_3_maliyet_pl43.Controls["txtveri14"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                kotumserlik5_3_maliyet_pl44.Controls["txtveri15"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                kotumserlik5_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik5_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik5_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik5_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik5_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik5_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik5_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik5_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik5_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik5_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik5_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik5_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik5_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik5_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik5_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik5_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik5_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik5_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik5_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik5_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik5_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik5_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik5_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik5_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik5_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik5_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik5_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik5_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik5_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 7; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 7; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik5_3_maliyet where Id=" + kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik5_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik5_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik5_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik5_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik5_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik5_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik5_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik5_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik5_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik5_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik5_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik5_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik5_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik5_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik5_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik5_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik5_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------                    
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik5_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik5_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik5_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik5_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik5_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik5_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik5_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik5_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //kotumserlik6_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik6_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik6_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik6_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik6_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik6_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik6_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik6_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik6_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik6_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik6_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik6_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik6_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik6_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik6_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                kotumserlik6_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                kotumserlik6_3_maliyet_pl32.Controls["txtveri7"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                kotumserlik6_3_maliyet_pl33.Controls["txtveri8"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                kotumserlik6_3_maliyet_pl34.Controls["txtveri9"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                kotumserlik6_3_maliyet_pl37.Controls["txtveri10"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                kotumserlik6_3_maliyet_pl38.Controls["txtveri11"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                kotumserlik6_3_maliyet_pl39.Controls["txtveri12"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                kotumserlik6_3_maliyet_pl42.Controls["txtveri13"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                kotumserlik6_3_maliyet_pl43.Controls["txtveri14"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                kotumserlik6_3_maliyet_pl44.Controls["txtveri15"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                kotumserlik6_3_maliyet_pl47.Controls["txtveri16"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                kotumserlik6_3_maliyet_pl48.Controls["txtveri17"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                kotumserlik6_3_maliyet_pl49.Controls["txtveri18"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                kotumserlik6_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik6_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik6_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik6_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik6_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik6_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik6_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik6_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik6_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik6_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik6_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik6_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik6_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik6_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik6_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik6_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik6_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik6_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik6_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik6_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik6_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik6_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik6_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik6_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(kotumserlik6_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(kotumserlik6_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(kotumserlik6_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 > veri17 && veri16 > veri18)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 > veri16 && veri17 > veri18)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 > veri17 && veri18 > veri16)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc && f1sonuc < f6sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc && f2sonuc < f6sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc && f3sonuc < f6sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc && f4sonuc < f6sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc && f5sonuc < f6sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                else if (f6sonuc < f1sonuc && f6sonuc < f2sonuc && f6sonuc < f3sonuc && f6sonuc < f4sonuc && f6sonuc < f5sonuc)
                {
                    kucukolanibul = f6sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik6_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", kotumserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", kotumserlik6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", kotumserlik6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", kotumserlik6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik6_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik6_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik6_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik6_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 6; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 8; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 8; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik6_3_maliyet where Id=" + kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik6_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik6_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik6_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik6_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik6_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik6_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik6_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik6_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik6_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik6_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik6_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik6_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik6_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik6_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik6_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik6_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik6_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(kotumserlik6_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(kotumserlik6_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(kotumserlik6_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 > veri17 && veri16 > veri18)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 > veri16 && veri17 > veri18)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 > veri17 && veri18 > veri16)
                {
                    kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc && f1sonuc < f6sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc && f2sonuc < f6sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc && f3sonuc < f6sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc && f4sonuc < f6sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc && f5sonuc < f6sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                else if (f6sonuc < f1sonuc && f6sonuc < f2sonuc && f6sonuc < f3sonuc && f6sonuc < f4sonuc && f6sonuc < f5sonuc)
                {
                    kucukolanibul = f6sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik6_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", kotumserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", kotumserlik6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", kotumserlik6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", kotumserlik6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", kotumserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik6_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik6_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik6_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik6_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik6_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik6_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik6_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //kotumserlik7_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik7_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik7_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik7_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik7_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void kotumserlik7_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void kotumserlik7_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void kotumserlik7_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //kotumserlik7_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void kotumserlik7_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kotumserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                kotumserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                kotumserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                kotumserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                kotumserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                kotumserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                kotumserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                kotumserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                kotumserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                kotumserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                kotumserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                kotumserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                kotumserlik7_3_maliyet_pl20.Controls["txtveri1"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                kotumserlik7_3_maliyet_pl21.Controls["txtveri2"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                kotumserlik7_3_maliyet_pl26.Controls["txtveri3"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                kotumserlik7_3_maliyet_pl22.Controls["txtveri4"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                kotumserlik7_3_maliyet_pl23.Controls["txtveri5"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                kotumserlik7_3_maliyet_pl27.Controls["txtveri6"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                kotumserlik7_3_maliyet_pl32.Controls["txtveri7"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                kotumserlik7_3_maliyet_pl33.Controls["txtveri8"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                kotumserlik7_3_maliyet_pl34.Controls["txtveri9"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                kotumserlik7_3_maliyet_pl37.Controls["txtveri10"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                kotumserlik7_3_maliyet_pl38.Controls["txtveri11"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                kotumserlik7_3_maliyet_pl39.Controls["txtveri12"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                kotumserlik7_3_maliyet_pl42.Controls["txtveri13"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                kotumserlik7_3_maliyet_pl43.Controls["txtveri14"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                kotumserlik7_3_maliyet_pl44.Controls["txtveri15"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                kotumserlik7_3_maliyet_pl47.Controls["txtveri16"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                kotumserlik7_3_maliyet_pl48.Controls["txtveri17"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                kotumserlik7_3_maliyet_pl49.Controls["txtveri18"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                kotumserlik7_3_maliyet_pl52.Controls["txtveri19"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                kotumserlik7_3_maliyet_pl53.Controls["txtveri20"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                kotumserlik7_3_maliyet_pl54.Controls["txtveri21"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
                kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[37].Value.ToString();
                kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[38].Value.ToString();
                kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[39].Value.ToString();
                kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[40].Value.ToString();
                kotumserlik7_3_maliyet_pl4.Controls["sonuc"].Text = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[41].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //kotumserlik7_3_maliyet formu kapatmak için oluşturulmuş button1
        private void kotumserlik7_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //kotumserlik7_3_maliyet formu altaalmak için oluşturulmuş button2
        private void kotumserlik7_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //kotumserlik7_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void kotumserlik7_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //kotumserlik7_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void kotumserlik7_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik7_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik7_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik7_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik7_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik7_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik7_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik7_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik7_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik7_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik7_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik7_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik7_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik7_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik7_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik7_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(kotumserlik7_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(kotumserlik7_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(kotumserlik7_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 > veri17 && veri16 > veri18)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 > veri16 && veri17 > veri18)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 > veri17 && veri18 > veri16)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------     
                //f7sonuc kısmı
                double veri19 = Convert.ToDouble(kotumserlik7_3_maliyet_pl52.Controls["txtveri19"].Text);
                double veri20 = Convert.ToDouble(kotumserlik7_3_maliyet_pl53.Controls["txtveri20"].Text);
                double veri21 = Convert.ToDouble(kotumserlik7_3_maliyet_pl54.Controls["txtveri21"].Text);
                if (veri19 > veri20 && veri19 > veri21)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri19.ToString();
                }
                else if (veri20 > veri19 && veri20 > veri21)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri20.ToString();
                }
                else if (veri21 > veri19 && veri21 > veri20)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri21.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc && f1sonuc < f6sonuc && f1sonuc < f7sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc && f2sonuc < f6sonuc && f2sonuc < f7sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc && f3sonuc < f6sonuc && f3sonuc < f7sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc && f4sonuc < f6sonuc && f4sonuc < f7sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc && f5sonuc < f6sonuc && f5sonuc < f7sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                else if (f6sonuc < f1sonuc && f6sonuc < f2sonuc && f6sonuc < f3sonuc && f6sonuc < f4sonuc && f6sonuc < f5sonuc && f6sonuc < f7sonuc)
                {
                    kucukolanibul = f6sonuc;
                }
                else if (f7sonuc < f1sonuc && f7sonuc < f2sonuc && f7sonuc < f3sonuc && f7sonuc < f4sonuc && f7sonuc < f5sonuc && f7sonuc < f6sonuc)
                {
                    kucukolanibul = f7sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                string sorgu = "Insert into kotumserlik7_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,sonuc_7,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@sonuc_7,@maliyet)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", kotumserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", kotumserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_7", kotumserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", kotumserlik7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", kotumserlik7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", kotumserlik7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_19", kotumserlik7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_20", kotumserlik7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_21", kotumserlik7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_7", kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                kotumserlik7_3_maliyet_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik7_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void kotumserlik7_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //kotumserlik7_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Kötümserlik";
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range ortaalanrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2 + i, 1 + j];
                        ortaalanrenk.Interior.Color = System.Drawing.Color.FromArgb(205, 193, 217);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range ustbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, i];
                    ustbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(152, 215, 89);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range oranrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, i];
                    oranrenk.Interior.Color = System.Drawing.Color.FromArgb(80, 203, 220);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range baslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    baslikrenk.Interior.Color = System.Drawing.Color.FromArgb(174, 192, 131);
                }

                for (int i = 3; i <= 9; i++)
                {
                    Microsoft.Office.Interop.Excel.Range altbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 1];
                    altbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(224, 163, 187);
                }

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 9; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 5];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Maximax";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select sonuc_7 From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 5];
                sonuc7.Value2 = komut44.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From kotumserlik7_3_maliyet where Id=" + kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                maliyet.Value2 = komut19.ExecuteScalar().ToString();
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

        //kotumserlik7_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void kotumserlik7_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(kotumserlik7_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(kotumserlik7_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(kotumserlik7_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 > veri2 && veri1 > veri3)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 > veri1 && veri2 > veri3)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 > veri1 && veri3 > veri2)
                {
                    kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(kotumserlik7_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(kotumserlik7_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(kotumserlik7_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 > veri5 && veri4 > veri6)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 > veri4 && veri5 > veri6)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 > veri4 && veri6 > veri5)
                {
                    kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(kotumserlik7_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(kotumserlik7_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(kotumserlik7_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 > veri8 && veri7 > veri9)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 > veri7 && veri8 > veri9)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 > veri7 && veri9 > veri8)
                {
                    kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(kotumserlik7_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(kotumserlik7_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(kotumserlik7_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 > veri11 && veri10 > veri12)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 > veri10 && veri11 > veri12)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 > veri10 && veri12 > veri11)
                {
                    kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(kotumserlik7_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(kotumserlik7_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(kotumserlik7_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 > veri14 && veri13 > veri15)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 > veri13 && veri14 > veri15)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 > veri14 && veri15 > veri13)
                {
                    kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(kotumserlik7_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(kotumserlik7_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(kotumserlik7_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 > veri17 && veri16 > veri18)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 > veri16 && veri17 > veri18)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 > veri17 && veri18 > veri16)
                {
                    kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------     
                //f7sonuc kısmı
                double veri19 = Convert.ToDouble(kotumserlik7_3_maliyet_pl52.Controls["txtveri19"].Text);
                double veri20 = Convert.ToDouble(kotumserlik7_3_maliyet_pl53.Controls["txtveri20"].Text);
                double veri21 = Convert.ToDouble(kotumserlik7_3_maliyet_pl54.Controls["txtveri21"].Text);
                if (veri19 > veri20 && veri19 > veri21)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri19.ToString();
                }
                else if (veri20 > veri19 && veri20 > veri21)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri20.ToString();
                }
                else if (veri21 > veri19 && veri21 > veri20)
                {
                    kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri21.ToString();
                }
                //--------------------------------------------        
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text);
                if (f1sonuc < f2sonuc && f1sonuc < f3sonuc && f1sonuc < f4sonuc && f1sonuc < f5sonuc && f1sonuc < f6sonuc && f1sonuc < f7sonuc)
                {
                    kucukolanibul = f1sonuc;
                }
                else if (f2sonuc < f1sonuc && f2sonuc < f3sonuc && f2sonuc < f4sonuc && f2sonuc < f5sonuc && f2sonuc < f6sonuc && f2sonuc < f7sonuc)
                {
                    kucukolanibul = f2sonuc;
                }
                else if (f3sonuc < f1sonuc && f3sonuc < f2sonuc && f3sonuc < f4sonuc && f3sonuc < f5sonuc && f3sonuc < f6sonuc && f3sonuc < f7sonuc)
                {
                    kucukolanibul = f3sonuc;
                }
                else if (f4sonuc < f1sonuc && f4sonuc < f2sonuc && f4sonuc < f3sonuc && f4sonuc < f5sonuc && f4sonuc < f6sonuc && f4sonuc < f7sonuc)
                {
                    kucukolanibul = f4sonuc;
                }
                else if (f5sonuc < f1sonuc && f5sonuc < f2sonuc && f5sonuc < f3sonuc && f5sonuc < f4sonuc && f5sonuc < f6sonuc && f5sonuc < f7sonuc)
                {
                    kucukolanibul = f5sonuc;
                }
                else if (f6sonuc < f1sonuc && f6sonuc < f2sonuc && f6sonuc < f3sonuc && f6sonuc < f4sonuc && f6sonuc < f5sonuc && f6sonuc < f7sonuc)
                {
                    kucukolanibul = f6sonuc;
                }
                else if (f7sonuc < f1sonuc && f7sonuc < f2sonuc && f7sonuc < f3sonuc && f7sonuc < f4sonuc && f7sonuc < f5sonuc && f7sonuc < f6sonuc)
                {
                    kucukolanibul = f7sonuc;
                }
                //---------------------------------------
                baglanti.Open();
                komut = new OleDbCommand("UPDATE kotumserlik7_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,sonuc_7=@sonuc_7,maliyet=@maliyet WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", kotumserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", kotumserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", kotumserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", kotumserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", kotumserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", kotumserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", kotumserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", kotumserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_7", kotumserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", kotumserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", kotumserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", kotumserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", kotumserlik7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", kotumserlik7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", kotumserlik7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", kotumserlik7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", kotumserlik7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", kotumserlik7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", kotumserlik7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", kotumserlik7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", kotumserlik7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", kotumserlik7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", kotumserlik7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", kotumserlik7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", kotumserlik7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", kotumserlik7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", kotumserlik7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", kotumserlik7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", kotumserlik7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", kotumserlik7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_19", kotumserlik7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_20", kotumserlik7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_21", kotumserlik7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", kotumserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", kotumserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", kotumserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", kotumserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", kotumserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", kotumserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_7", kotumserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                kotumserlik7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                kotumserlik7_3_maliyet_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //kotumserlik7_3_maliyet silme yapmak için oluşturulmuş panel10
        private void kotumserlik7_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = kotumserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kotumserlik7_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            kotumserlik7_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //kotumserlik7_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void kotumserlik7_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        private void BelirsizlikAltındakotumserlikMaliyet_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                kotumserlik2_3_maliyet();
                kotumserlik2_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                kotumserlik3_3_maliyet();
                kotumserlik3_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                kotumserlik4_3_maliyet();
                kotumserlik4_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                kotumserlik5_3_maliyet();
                kotumserlik5_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                kotumserlik6_3_maliyet();
                kotumserlik6_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                kotumserlik7_3_maliyet();
                kotumserlik7_3_maliyet_listele();
            }
        }
    }
}
