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
    public partial class BelirsizlikAltındaiyimserlikMaliyet : Form
    {
        public BelirsizlikAltındaiyimserlikMaliyet()
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

        //iyimserlik2_3_maliyet form nesneleri
        Panel iyimserlik2_3_maliyet_pl1 = new Panel();
        Panel iyimserlik2_3_maliyet_pl2 = new Panel();
        Panel iyimserlik2_3_maliyet_pl3 = new Panel();
        Panel iyimserlik2_3_maliyet_pl4 = new Panel();
        Panel iyimserlik2_3_maliyet_pl5 = new Panel();
        Panel iyimserlik2_3_maliyet_pl6 = new Panel();
        Panel iyimserlik2_3_maliyet_pl7 = new Panel();
        Panel iyimserlik2_3_maliyet_pl8 = new Panel();
        Panel iyimserlik2_3_maliyet_pl9 = new Panel();
        Panel iyimserlik2_3_maliyet_pl10 = new Panel();
        Panel iyimserlik2_3_maliyet_pl11 = new Panel();
        Panel iyimserlik2_3_maliyet_pl12 = new Panel();
        Panel iyimserlik2_3_maliyet_pl13 = new Panel();
        Panel iyimserlik2_3_maliyet_pl14 = new Panel();
        Panel iyimserlik2_3_maliyet_pl15 = new Panel();
        Panel iyimserlik2_3_maliyet_pl16 = new Panel();
        Panel iyimserlik2_3_maliyet_pl17 = new Panel();
        Panel iyimserlik2_3_maliyet_pl18 = new Panel();
        Panel iyimserlik2_3_maliyet_pl19 = new Panel();
        Panel iyimserlik2_3_maliyet_pl20 = new Panel();
        Panel iyimserlik2_3_maliyet_pl21 = new Panel();
        Panel iyimserlik2_3_maliyet_pl22 = new Panel();
        Panel iyimserlik2_3_maliyet_pl23 = new Panel();
        Panel iyimserlik2_3_maliyet_pl24 = new Panel();
        Panel iyimserlik2_3_maliyet_pl25 = new Panel();
        Panel iyimserlik2_3_maliyet_pl26 = new Panel();
        Panel iyimserlik2_3_maliyet_pl27 = new Panel();
        Panel iyimserlik2_3_maliyet_pl28 = new Panel();
        Panel iyimserlik2_3_maliyet_pl29 = new Panel();
        Panel iyimserlik2_3_maliyet_pl30 = new Panel();
        TabControl iyimserlik2_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik2_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik2_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik2_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik2_3_maliyet_txt_baslik1;
        TextBox iyimserlik2_3_maliyet_txt_baslik2;
        TextBox iyimserlik2_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik2_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik2_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik2_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik2_3_maliyet_txt_üstbaslik3;     
        TextBox iyimserlik2_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik2_3_maliyet_txt_f2sonuc;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik2_3_maliyet_txt_veri6;
        Label iyimserlik2_3_maliyet_sonucbaslik;
        Label iyimserlik2_3_maliyet_sonuc;
        Label iyimserlik2_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik2_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik2_3_maliyet_btn1 = new Button();
        Button iyimserlik2_3_maliyet_btn2 = new Button();
        Button iyimserlik2_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik2_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik3_3_maliyet form nesneleri
        Panel iyimserlik3_3_maliyet_pl1 = new Panel();
        Panel iyimserlik3_3_maliyet_pl2 = new Panel();
        Panel iyimserlik3_3_maliyet_pl3 = new Panel();
        Panel iyimserlik3_3_maliyet_pl4 = new Panel();
        Panel iyimserlik3_3_maliyet_pl5 = new Panel();
        Panel iyimserlik3_3_maliyet_pl6 = new Panel();
        Panel iyimserlik3_3_maliyet_pl7 = new Panel();
        Panel iyimserlik3_3_maliyet_pl8 = new Panel();
        Panel iyimserlik3_3_maliyet_pl9 = new Panel();
        Panel iyimserlik3_3_maliyet_pl10 = new Panel();
        Panel iyimserlik3_3_maliyet_pl11 = new Panel();
        Panel iyimserlik3_3_maliyet_pl12 = new Panel();
        Panel iyimserlik3_3_maliyet_pl13 = new Panel();
        Panel iyimserlik3_3_maliyet_pl14 = new Panel();
        Panel iyimserlik3_3_maliyet_pl15 = new Panel();
        Panel iyimserlik3_3_maliyet_pl16 = new Panel();
        Panel iyimserlik3_3_maliyet_pl17 = new Panel();
        Panel iyimserlik3_3_maliyet_pl18 = new Panel();
        Panel iyimserlik3_3_maliyet_pl19 = new Panel();
        Panel iyimserlik3_3_maliyet_pl20 = new Panel();
        Panel iyimserlik3_3_maliyet_pl21 = new Panel();
        Panel iyimserlik3_3_maliyet_pl22 = new Panel();
        Panel iyimserlik3_3_maliyet_pl23 = new Panel();
        Panel iyimserlik3_3_maliyet_pl24 = new Panel();
        Panel iyimserlik3_3_maliyet_pl25 = new Panel();
        Panel iyimserlik3_3_maliyet_pl26 = new Panel();
        Panel iyimserlik3_3_maliyet_pl27 = new Panel();
        Panel iyimserlik3_3_maliyet_pl28 = new Panel();
        Panel iyimserlik3_3_maliyet_pl29 = new Panel();
        Panel iyimserlik3_3_maliyet_pl30 = new Panel();
        Panel iyimserlik3_3_maliyet_pl31 = new Panel();
        Panel iyimserlik3_3_maliyet_pl32 = new Panel();
        Panel iyimserlik3_3_maliyet_pl33 = new Panel();
        Panel iyimserlik3_3_maliyet_pl34 = new Panel();
        Panel iyimserlik3_3_maliyet_pl35 = new Panel();
        TabControl iyimserlik3_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik3_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik3_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik3_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik3_3_maliyet_txt_baslik1;
        TextBox iyimserlik3_3_maliyet_txt_baslik2;
        TextBox iyimserlik3_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik3_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik3_3_maliyet_txt_altbaslik3;
        TextBox iyimserlik3_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik3_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik3_3_maliyet_txt_üstbaslik3;      
        TextBox iyimserlik3_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik3_3_maliyet_txt_f2sonuc;
        TextBox iyimserlik3_3_maliyet_txt_f3sonuc;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri6;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri7;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri8;
        NumericUpDown iyimserlik3_3_maliyet_txt_veri9;
        Label iyimserlik3_3_maliyet_sonucbaslik;
        Label iyimserlik3_3_maliyet_sonuc;
        Label iyimserlik3_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik3_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik3_3_maliyet_btn1 = new Button();
        Button iyimserlik3_3_maliyet_btn2 = new Button();
        Button iyimserlik3_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik3_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik4_3_maliyet form nesneleri
        Panel iyimserlik4_3_maliyet_pl1 = new Panel();
        Panel iyimserlik4_3_maliyet_pl2 = new Panel();
        Panel iyimserlik4_3_maliyet_pl3 = new Panel();
        Panel iyimserlik4_3_maliyet_pl4 = new Panel();
        Panel iyimserlik4_3_maliyet_pl5 = new Panel();
        Panel iyimserlik4_3_maliyet_pl6 = new Panel();
        Panel iyimserlik4_3_maliyet_pl7 = new Panel();
        Panel iyimserlik4_3_maliyet_pl8 = new Panel();
        Panel iyimserlik4_3_maliyet_pl9 = new Panel();
        Panel iyimserlik4_3_maliyet_pl10 = new Panel();
        Panel iyimserlik4_3_maliyet_pl11 = new Panel();
        Panel iyimserlik4_3_maliyet_pl12 = new Panel();
        Panel iyimserlik4_3_maliyet_pl13 = new Panel();
        Panel iyimserlik4_3_maliyet_pl14 = new Panel();
        Panel iyimserlik4_3_maliyet_pl15 = new Panel();
        Panel iyimserlik4_3_maliyet_pl16 = new Panel();
        Panel iyimserlik4_3_maliyet_pl17 = new Panel();
        Panel iyimserlik4_3_maliyet_pl18 = new Panel();
        Panel iyimserlik4_3_maliyet_pl19 = new Panel();
        Panel iyimserlik4_3_maliyet_pl20 = new Panel();
        Panel iyimserlik4_3_maliyet_pl21 = new Panel();
        Panel iyimserlik4_3_maliyet_pl22 = new Panel();
        Panel iyimserlik4_3_maliyet_pl23 = new Panel();
        Panel iyimserlik4_3_maliyet_pl24 = new Panel();
        Panel iyimserlik4_3_maliyet_pl25 = new Panel();
        Panel iyimserlik4_3_maliyet_pl26 = new Panel();
        Panel iyimserlik4_3_maliyet_pl27 = new Panel();
        Panel iyimserlik4_3_maliyet_pl28 = new Panel();
        Panel iyimserlik4_3_maliyet_pl29 = new Panel();
        Panel iyimserlik4_3_maliyet_pl30 = new Panel();
        Panel iyimserlik4_3_maliyet_pl31 = new Panel();
        Panel iyimserlik4_3_maliyet_pl32 = new Panel();
        Panel iyimserlik4_3_maliyet_pl33 = new Panel();
        Panel iyimserlik4_3_maliyet_pl34 = new Panel();
        Panel iyimserlik4_3_maliyet_pl35 = new Panel();
        Panel iyimserlik4_3_maliyet_pl36 = new Panel();
        Panel iyimserlik4_3_maliyet_pl37 = new Panel();
        Panel iyimserlik4_3_maliyet_pl38 = new Panel();
        Panel iyimserlik4_3_maliyet_pl39 = new Panel();
        Panel iyimserlik4_3_maliyet_pl40 = new Panel();
        TabControl iyimserlik4_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik4_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik4_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik4_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik4_3_maliyet_txt_baslik1;
        TextBox iyimserlik4_3_maliyet_txt_baslik2;
        TextBox iyimserlik4_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik4_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik4_3_maliyet_txt_altbaslik3;
        TextBox iyimserlik4_3_maliyet_txt_altbaslik4;
        TextBox iyimserlik4_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik4_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik4_3_maliyet_txt_üstbaslik3;     
        TextBox iyimserlik4_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik4_3_maliyet_txt_f2sonuc;
        TextBox iyimserlik4_3_maliyet_txt_f3sonuc;
        TextBox iyimserlik4_3_maliyet_txt_f4sonuc;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri6;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri7;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri8;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri9;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri10;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri11;
        NumericUpDown iyimserlik4_3_maliyet_txt_veri12;
        Label iyimserlik4_3_maliyet_sonucbaslik;
        Label iyimserlik4_3_maliyet_sonuc;
        Label iyimserlik4_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik4_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik4_3_maliyet_btn1 = new Button();
        Button iyimserlik4_3_maliyet_btn2 = new Button();
        Button iyimserlik4_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik4_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik5_3_maliyet form nesneleri
        Panel iyimserlik5_3_maliyet_pl1 = new Panel();
        Panel iyimserlik5_3_maliyet_pl2 = new Panel();
        Panel iyimserlik5_3_maliyet_pl3 = new Panel();
        Panel iyimserlik5_3_maliyet_pl4 = new Panel();
        Panel iyimserlik5_3_maliyet_pl5 = new Panel();
        Panel iyimserlik5_3_maliyet_pl6 = new Panel();
        Panel iyimserlik5_3_maliyet_pl7 = new Panel();
        Panel iyimserlik5_3_maliyet_pl8 = new Panel();
        Panel iyimserlik5_3_maliyet_pl9 = new Panel();
        Panel iyimserlik5_3_maliyet_pl10 = new Panel();
        Panel iyimserlik5_3_maliyet_pl11 = new Panel();
        Panel iyimserlik5_3_maliyet_pl12 = new Panel();
        Panel iyimserlik5_3_maliyet_pl13 = new Panel();
        Panel iyimserlik5_3_maliyet_pl14 = new Panel();
        Panel iyimserlik5_3_maliyet_pl15 = new Panel();
        Panel iyimserlik5_3_maliyet_pl16 = new Panel();
        Panel iyimserlik5_3_maliyet_pl17 = new Panel();
        Panel iyimserlik5_3_maliyet_pl18 = new Panel();
        Panel iyimserlik5_3_maliyet_pl19 = new Panel();
        Panel iyimserlik5_3_maliyet_pl20 = new Panel();
        Panel iyimserlik5_3_maliyet_pl21 = new Panel();
        Panel iyimserlik5_3_maliyet_pl22 = new Panel();
        Panel iyimserlik5_3_maliyet_pl23 = new Panel();
        Panel iyimserlik5_3_maliyet_pl24 = new Panel();
        Panel iyimserlik5_3_maliyet_pl25 = new Panel();
        Panel iyimserlik5_3_maliyet_pl26 = new Panel();
        Panel iyimserlik5_3_maliyet_pl27 = new Panel();
        Panel iyimserlik5_3_maliyet_pl28 = new Panel();
        Panel iyimserlik5_3_maliyet_pl29 = new Panel();
        Panel iyimserlik5_3_maliyet_pl30 = new Panel();
        Panel iyimserlik5_3_maliyet_pl31 = new Panel();
        Panel iyimserlik5_3_maliyet_pl32 = new Panel();
        Panel iyimserlik5_3_maliyet_pl33 = new Panel();
        Panel iyimserlik5_3_maliyet_pl34 = new Panel();
        Panel iyimserlik5_3_maliyet_pl35 = new Panel();
        Panel iyimserlik5_3_maliyet_pl36 = new Panel();
        Panel iyimserlik5_3_maliyet_pl37 = new Panel();
        Panel iyimserlik5_3_maliyet_pl38 = new Panel();
        Panel iyimserlik5_3_maliyet_pl39 = new Panel();
        Panel iyimserlik5_3_maliyet_pl40 = new Panel();
        Panel iyimserlik5_3_maliyet_pl41 = new Panel();
        Panel iyimserlik5_3_maliyet_pl42 = new Panel();
        Panel iyimserlik5_3_maliyet_pl43 = new Panel();
        Panel iyimserlik5_3_maliyet_pl44 = new Panel();
        Panel iyimserlik5_3_maliyet_pl45 = new Panel();
        TabControl iyimserlik5_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik5_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik5_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik5_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik5_3_maliyet_txt_baslik1;
        TextBox iyimserlik5_3_maliyet_txt_baslik2;
        TextBox iyimserlik5_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik5_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik5_3_maliyet_txt_altbaslik3;
        TextBox iyimserlik5_3_maliyet_txt_altbaslik4;
        TextBox iyimserlik5_3_maliyet_txt_altbaslik5;
        TextBox iyimserlik5_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik5_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik5_3_maliyet_txt_üstbaslik3;    
        TextBox iyimserlik5_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik5_3_maliyet_txt_f2sonuc;
        TextBox iyimserlik5_3_maliyet_txt_f3sonuc;
        TextBox iyimserlik5_3_maliyet_txt_f4sonuc;
        TextBox iyimserlik5_3_maliyet_txt_f5sonuc;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri6;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri7;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri8;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri9;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri10;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri11;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri12;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri13;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri14;
        NumericUpDown iyimserlik5_3_maliyet_txt_veri15;
        Label iyimserlik5_3_maliyet_sonucbaslik;
        Label iyimserlik5_3_maliyet_sonuc;
        Label iyimserlik5_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik5_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik5_3_maliyet_btn1 = new Button();
        Button iyimserlik5_3_maliyet_btn2 = new Button();
        Button iyimserlik5_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik5_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik6_3_maliyet form nesneleri
        Panel iyimserlik6_3_maliyet_pl1 = new Panel();
        Panel iyimserlik6_3_maliyet_pl2 = new Panel();
        Panel iyimserlik6_3_maliyet_pl3 = new Panel();
        Panel iyimserlik6_3_maliyet_pl4 = new Panel();
        Panel iyimserlik6_3_maliyet_pl5 = new Panel();
        Panel iyimserlik6_3_maliyet_pl6 = new Panel();
        Panel iyimserlik6_3_maliyet_pl7 = new Panel();
        Panel iyimserlik6_3_maliyet_pl8 = new Panel();
        Panel iyimserlik6_3_maliyet_pl9 = new Panel();
        Panel iyimserlik6_3_maliyet_pl10 = new Panel();
        Panel iyimserlik6_3_maliyet_pl11 = new Panel();
        Panel iyimserlik6_3_maliyet_pl12 = new Panel();
        Panel iyimserlik6_3_maliyet_pl13 = new Panel();
        Panel iyimserlik6_3_maliyet_pl14 = new Panel();
        Panel iyimserlik6_3_maliyet_pl15 = new Panel();
        Panel iyimserlik6_3_maliyet_pl16 = new Panel();
        Panel iyimserlik6_3_maliyet_pl17 = new Panel();
        Panel iyimserlik6_3_maliyet_pl18 = new Panel();
        Panel iyimserlik6_3_maliyet_pl19 = new Panel();
        Panel iyimserlik6_3_maliyet_pl20 = new Panel();
        Panel iyimserlik6_3_maliyet_pl21 = new Panel();
        Panel iyimserlik6_3_maliyet_pl22 = new Panel();
        Panel iyimserlik6_3_maliyet_pl23 = new Panel();
        Panel iyimserlik6_3_maliyet_pl24 = new Panel();
        Panel iyimserlik6_3_maliyet_pl25 = new Panel();
        Panel iyimserlik6_3_maliyet_pl26 = new Panel();
        Panel iyimserlik6_3_maliyet_pl27 = new Panel();
        Panel iyimserlik6_3_maliyet_pl28 = new Panel();
        Panel iyimserlik6_3_maliyet_pl29 = new Panel();
        Panel iyimserlik6_3_maliyet_pl30 = new Panel();
        Panel iyimserlik6_3_maliyet_pl31 = new Panel();
        Panel iyimserlik6_3_maliyet_pl32 = new Panel();
        Panel iyimserlik6_3_maliyet_pl33 = new Panel();
        Panel iyimserlik6_3_maliyet_pl34 = new Panel();
        Panel iyimserlik6_3_maliyet_pl35 = new Panel();
        Panel iyimserlik6_3_maliyet_pl36 = new Panel();
        Panel iyimserlik6_3_maliyet_pl37 = new Panel();
        Panel iyimserlik6_3_maliyet_pl38 = new Panel();
        Panel iyimserlik6_3_maliyet_pl39 = new Panel();
        Panel iyimserlik6_3_maliyet_pl40 = new Panel();
        Panel iyimserlik6_3_maliyet_pl41 = new Panel();
        Panel iyimserlik6_3_maliyet_pl42 = new Panel();
        Panel iyimserlik6_3_maliyet_pl43 = new Panel();
        Panel iyimserlik6_3_maliyet_pl44 = new Panel();
        Panel iyimserlik6_3_maliyet_pl45 = new Panel();
        Panel iyimserlik6_3_maliyet_pl46 = new Panel();
        Panel iyimserlik6_3_maliyet_pl47 = new Panel();
        Panel iyimserlik6_3_maliyet_pl48 = new Panel();
        Panel iyimserlik6_3_maliyet_pl49 = new Panel();
        Panel iyimserlik6_3_maliyet_pl50 = new Panel();
        TabControl iyimserlik6_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik6_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik6_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik6_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik6_3_maliyet_txt_baslik1;
        TextBox iyimserlik6_3_maliyet_txt_baslik2;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik3;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik4;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik5;
        TextBox iyimserlik6_3_maliyet_txt_altbaslik6;
        TextBox iyimserlik6_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik6_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik6_3_maliyet_txt_üstbaslik3;  
        TextBox iyimserlik6_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik6_3_maliyet_txt_f2sonuc;
        TextBox iyimserlik6_3_maliyet_txt_f3sonuc;
        TextBox iyimserlik6_3_maliyet_txt_f4sonuc;
        TextBox iyimserlik6_3_maliyet_txt_f5sonuc;
        TextBox iyimserlik6_3_maliyet_txt_f6sonuc;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri6;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri7;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri8;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri9;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri10;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri11;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri12;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri13;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri14;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri15;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri16;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri17;
        NumericUpDown iyimserlik6_3_maliyet_txt_veri18;
        Label iyimserlik6_3_maliyet_sonucbaslik;
        Label iyimserlik6_3_maliyet_sonuc;
        Label iyimserlik6_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik6_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik6_3_maliyet_btn1 = new Button();
        Button iyimserlik6_3_maliyet_btn2 = new Button();
        Button iyimserlik6_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik6_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik7_3_maliyet form nesneleri
        Panel iyimserlik7_3_maliyet_pl1 = new Panel();
        Panel iyimserlik7_3_maliyet_pl2 = new Panel();
        Panel iyimserlik7_3_maliyet_pl3 = new Panel();
        Panel iyimserlik7_3_maliyet_pl4 = new Panel();
        Panel iyimserlik7_3_maliyet_pl5 = new Panel();
        Panel iyimserlik7_3_maliyet_pl6 = new Panel();
        Panel iyimserlik7_3_maliyet_pl7 = new Panel();
        Panel iyimserlik7_3_maliyet_pl8 = new Panel();
        Panel iyimserlik7_3_maliyet_pl9 = new Panel();
        Panel iyimserlik7_3_maliyet_pl10 = new Panel();
        Panel iyimserlik7_3_maliyet_pl11 = new Panel();
        Panel iyimserlik7_3_maliyet_pl12 = new Panel();
        Panel iyimserlik7_3_maliyet_pl13 = new Panel();
        Panel iyimserlik7_3_maliyet_pl14 = new Panel();
        Panel iyimserlik7_3_maliyet_pl15 = new Panel();
        Panel iyimserlik7_3_maliyet_pl16 = new Panel();
        Panel iyimserlik7_3_maliyet_pl17 = new Panel();
        Panel iyimserlik7_3_maliyet_pl18 = new Panel();
        Panel iyimserlik7_3_maliyet_pl19 = new Panel();
        Panel iyimserlik7_3_maliyet_pl20 = new Panel();
        Panel iyimserlik7_3_maliyet_pl21 = new Panel();
        Panel iyimserlik7_3_maliyet_pl22 = new Panel();
        Panel iyimserlik7_3_maliyet_pl23 = new Panel();
        Panel iyimserlik7_3_maliyet_pl24 = new Panel();
        Panel iyimserlik7_3_maliyet_pl25 = new Panel();
        Panel iyimserlik7_3_maliyet_pl26 = new Panel();
        Panel iyimserlik7_3_maliyet_pl27 = new Panel();
        Panel iyimserlik7_3_maliyet_pl28 = new Panel();
        Panel iyimserlik7_3_maliyet_pl29 = new Panel();
        Panel iyimserlik7_3_maliyet_pl30 = new Panel();
        Panel iyimserlik7_3_maliyet_pl31 = new Panel();
        Panel iyimserlik7_3_maliyet_pl32 = new Panel();
        Panel iyimserlik7_3_maliyet_pl33 = new Panel();
        Panel iyimserlik7_3_maliyet_pl34 = new Panel();
        Panel iyimserlik7_3_maliyet_pl35 = new Panel();
        Panel iyimserlik7_3_maliyet_pl36 = new Panel();
        Panel iyimserlik7_3_maliyet_pl37 = new Panel();
        Panel iyimserlik7_3_maliyet_pl38 = new Panel();
        Panel iyimserlik7_3_maliyet_pl39 = new Panel();
        Panel iyimserlik7_3_maliyet_pl40 = new Panel();
        Panel iyimserlik7_3_maliyet_pl41 = new Panel();
        Panel iyimserlik7_3_maliyet_pl42 = new Panel();
        Panel iyimserlik7_3_maliyet_pl43 = new Panel();
        Panel iyimserlik7_3_maliyet_pl44 = new Panel();
        Panel iyimserlik7_3_maliyet_pl45 = new Panel();
        Panel iyimserlik7_3_maliyet_pl46 = new Panel();
        Panel iyimserlik7_3_maliyet_pl47 = new Panel();
        Panel iyimserlik7_3_maliyet_pl48 = new Panel();
        Panel iyimserlik7_3_maliyet_pl49 = new Panel();
        Panel iyimserlik7_3_maliyet_pl50 = new Panel();
        Panel iyimserlik7_3_maliyet_pl51 = new Panel();
        Panel iyimserlik7_3_maliyet_pl52 = new Panel();
        Panel iyimserlik7_3_maliyet_pl53 = new Panel();
        Panel iyimserlik7_3_maliyet_pl54 = new Panel();
        Panel iyimserlik7_3_maliyet_pl55 = new Panel();
        TabControl iyimserlik7_3_maliyet_tb1 = new TabControl();
        TabPage iyimserlik7_3_maliyet_tb1_1 = new TabPage();
        TabPage iyimserlik7_3_maliyet_tb1_2 = new TabPage();
        TabPage iyimserlik7_3_maliyet_tb1_3 = new TabPage();
        TextBox iyimserlik7_3_maliyet_txt_baslik1;
        TextBox iyimserlik7_3_maliyet_txt_baslik2;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik1;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik2;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik3;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik4;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik5;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik6;
        TextBox iyimserlik7_3_maliyet_txt_altbaslik7;
        TextBox iyimserlik7_3_maliyet_txt_üstbaslik1;
        TextBox iyimserlik7_3_maliyet_txt_üstbaslik2;
        TextBox iyimserlik7_3_maliyet_txt_üstbaslik3;    
        TextBox iyimserlik7_3_maliyet_txt_f1sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f2sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f3sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f4sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f5sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f6sonuc;
        TextBox iyimserlik7_3_maliyet_txt_f7sonuc;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri1;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri2;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri3;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri4;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri5;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri6;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri7;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri8;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri9;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri10;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri11;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri12;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri13;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri14;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri15;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri16;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri17;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri18;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri19;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri20;
        NumericUpDown iyimserlik7_3_maliyet_txt_veri21;
        Label iyimserlik7_3_maliyet_sonucbaslik;
        Label iyimserlik7_3_maliyet_sonuc;
        Label iyimserlik7_3_maliyet_sonuclarortabaslik;
        DataGridView iyimserlik7_3_maliyet_dr1 = new DataGridView();
        Button iyimserlik7_3_maliyet_btn1 = new Button();
        Button iyimserlik7_3_maliyet_btn2 = new Button();
        Button iyimserlik7_3_maliyet_btn3 = new Button();
        RichTextBox iyimserlik7_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //iyimserlik2_3_maliyet form nesne tasarımları
        public void iyimserlik2_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik2_3_maliyet_sonuc = new Label();
            iyimserlik2_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik2_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik2_3_maliyet_sonuc.Location = sonuc;
            iyimserlik2_3_maliyet_sonuc.Text = "";
            iyimserlik2_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik2_3_maliyet_pl4.Controls.Add(iyimserlik2_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik2_3_maliyet_sonucbaslik = new Label();
            iyimserlik2_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik2_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik2_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik2_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik2_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik2_3_maliyet_pl4.Controls.Add(iyimserlik2_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik2_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik2_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik2_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik2_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik2_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik2_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik2_3_maliyet_pl28.Controls.Add(iyimserlik2_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik2_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl27.Controls.Add(iyimserlik2_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik2_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl23.Controls.Add(iyimserlik2_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik2_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl22.Controls.Add(iyimserlik2_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik2_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl26.Controls.Add(iyimserlik2_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik2_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl21.Controls.Add(iyimserlik2_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik2_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik2_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik2_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl20.Controls.Add(iyimserlik2_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik2_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik2_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik2_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik2_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl30.Controls.Add(iyimserlik2_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik2_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik2_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik2_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik2_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik2_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik2_3_maliyet_pl29.Controls.Add(iyimserlik2_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------
        
            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik2_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik2_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik2_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik2_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik2_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik2_3_maliyet_pl24.Controls.Add(iyimserlik2_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik2_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik2_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik2_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik2_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik2_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik2_3_maliyet_pl17.Controls.Add(iyimserlik2_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik2_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik2_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik2_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik2_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik2_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik2_3_maliyet_pl16.Controls.Add(iyimserlik2_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik2_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik2_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik2_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik2_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik2_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik2_3_maliyet_pl15.Controls.Add(iyimserlik2_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik2_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik2_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik2_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik2_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik2_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik2_3_maliyet_pl14.Controls.Add(iyimserlik2_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik2_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik2_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik2_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik2_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik2_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik2_3_maliyet_pl13.Controls.Add(iyimserlik2_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik2_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik2_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik2_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik2_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik2_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik2_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik2_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik2_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik2_3_maliyet_pl12.Controls.Add(iyimserlik2_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik2_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik2_3_maliyet_pl30.Location = pl30k;
            iyimserlik2_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik2_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik2_3_maliyet_pl29.Location = pl29k;
            iyimserlik2_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik2_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik2_3_maliyet_pl28.Location = pl28k;
            iyimserlik2_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik2_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik2_3_maliyet_pl27.Location = pl27k;
            iyimserlik2_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik2_3_maliyet_pl26.Location = pl26k;
            iyimserlik2_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik2_3_maliyet_pl23.Location = pl23k;
            iyimserlik2_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik2_3_maliyet_pl22.Location = pl22k;
            iyimserlik2_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik2_3_maliyet_pl21.Location = pl21k;
            iyimserlik2_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik2_3_maliyet_pl20.Location = pl20k;
            iyimserlik2_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik2_3_maliyet_pl25.Location = pl25k;
            iyimserlik2_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik2_3_maliyet_pl19.Location = pl19k;
            iyimserlik2_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik2_3_maliyet_pl18.Location = pl18k;
            iyimserlik2_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik2_3_maliyet_pl24.Location = pl24k;
            iyimserlik2_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik2_3_maliyet_pl17.Location = pl17k;
            iyimserlik2_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik2_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik2_3_maliyet_pl16.Location = pl16k;
            iyimserlik2_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik2_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik2_3_maliyet_pl15.Location = pl15k;
            iyimserlik2_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik2_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik2_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik2_3_maliyet_pl14.Location = pl14k;
            iyimserlik2_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik2_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik2_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik2_3_maliyet_pl13.Location = pl13k;
            iyimserlik2_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik2_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik2_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik2_3_maliyet_pl12.Location = pl12k;
            iyimserlik2_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik2_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl5.Controls.Add(iyimserlik2_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik2_3_maliyet_pl11.Name = "pl11";
            iyimserlik2_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik2_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik2_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl11.Click += new EventHandler(iyimserlik2_3_maliyet_pl11_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik2_3_maliyet_pl10.Name = "pl10";
            iyimserlik2_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik2_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl10.Click += new EventHandler(iyimserlik2_3_maliyet_pl10_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik2_3_maliyet_pl9.Name = "pl9";
            iyimserlik2_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik2_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl9.Click += new EventHandler(iyimserlik2_3_maliyet_pl9_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik2_3_maliyet_pl8.Name = "pl8";
            iyimserlik2_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik2_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl8.Click += new EventHandler(iyimserlik2_3_maliyet_pl8_Click);
            iyimserlik2_3_maliyet_pl7.Controls.Add(iyimserlik2_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik2_3_maliyet_pl6.Name = "pl6";
            iyimserlik2_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik2_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl6.Click += new EventHandler(iyimserlik2_3_maliyet_pl6_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik2_3_maliyet_btn3.Name = "btn3";
            iyimserlik2_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik2_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik2_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_btn3.Click += new EventHandler(iyimserlik2_3_maliyet_btn3_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik2_3_maliyet_btn2.Name = "btn2";
            iyimserlik2_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik2_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik2_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik2_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik2_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_btn2.Click += new EventHandler(iyimserlik2_3_maliyet_btn2_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik2_3_maliyet_btn1.Name = "btn1";
            iyimserlik2_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik2_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik2_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik2_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik2_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik2_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik2_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik2_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_btn1.Click += new EventHandler(iyimserlik2_3_maliyet_btn1_Click);
            iyimserlik2_3_maliyet_pl2.Controls.Add(iyimserlik2_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik2_3_maliyet_dr1.Name = "dr1";
            iyimserlik2_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik2_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik2_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik2_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik2_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik2_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik2_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik2_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik2_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik2_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik2_3_maliyet_dr1_CellEnter);
            iyimserlik2_3_maliyet_tb1_2.Controls.Add(iyimserlik2_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik2_3_maliyet_pl7.Name = "pl7";
            iyimserlik2_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik2_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik2_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_tb1_2.Controls.Add(iyimserlik2_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik2_3_maliyet_pl5.Name = "pl5";
            iyimserlik2_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik2_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik2_3_maliyet_pl5.AutoScroll = true;
            iyimserlik2_3_maliyet_pl5.AutoSize = true;
            iyimserlik2_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik2_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_tb1_1.Controls.Add(iyimserlik2_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik2_3_maliyet_rt1.Name = "rt1";
            iyimserlik2_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik2_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik2_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_rt1.Enabled = false;
            iyimserlik2_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik2_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik2_3_maliyet_tb1_3.Controls.Add(iyimserlik2_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik2_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik2_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik2_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik2_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_tb1.Controls.Add(iyimserlik2_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik2_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik2_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik2_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik2_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_tb1.Controls.Add(iyimserlik2_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik2_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik2_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik2_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik2_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_tb1.Controls.Add(iyimserlik2_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik2_3_maliyet_tb1.Name = "tb1";
            iyimserlik2_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik2_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik2_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik2_3_maliyet_pl3.Controls.Add(iyimserlik2_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik2_3_maliyet_pl4.Name = "pl4";
            iyimserlik2_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik2_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik2_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik2_3_maliyet_pl4_MouseUp);
            iyimserlik2_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik2_3_maliyet_pl4_MouseMove);
            iyimserlik2_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik2_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik2_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik2_3_maliyet_pl3.Name = "pl3";
            iyimserlik2_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik2_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik2_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik2_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik2_3_maliyet_pl2.Name = "pl2";
            iyimserlik2_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik2_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik2_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik2_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik2_3_maliyet_pl1.Name = "pl1";
            iyimserlik2_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik2_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik2_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik2_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik2_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik2_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik2_3_maliyet_pl1_MouseUp);
            iyimserlik2_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik2_3_maliyet_pl1_MouseMove);
            iyimserlik2_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik2_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik2_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik3_3_maliyet form nesne tasarımları
        public void iyimserlik3_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik3_3_maliyet_sonuc = new Label();
            iyimserlik3_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik3_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik3_3_maliyet_sonuc.Location = sonuc;
            iyimserlik3_3_maliyet_sonuc.Text = "";
            iyimserlik3_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik3_3_maliyet_pl4.Controls.Add(iyimserlik3_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik3_3_maliyet_sonucbaslik = new Label();
            iyimserlik3_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik3_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik3_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik3_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik3_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik3_3_maliyet_pl4.Controls.Add(iyimserlik3_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik3_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik3_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik3_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik3_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik3_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik3_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik3_3_maliyet_pl28.Controls.Add(iyimserlik3_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri9 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri9.Location = txt_veri9;
            iyimserlik3_3_maliyet_txt_veri9.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl34.Controls.Add(iyimserlik3_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri8 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri8.Location = txt_veri8;
            iyimserlik3_3_maliyet_txt_veri8.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl33.Controls.Add(iyimserlik3_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri7 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri7.Location = txt_veri7;
            iyimserlik3_3_maliyet_txt_veri7.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl32.Controls.Add(iyimserlik3_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik3_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl27.Controls.Add(iyimserlik3_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik3_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl23.Controls.Add(iyimserlik3_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik3_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl22.Controls.Add(iyimserlik3_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik3_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl26.Controls.Add(iyimserlik3_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik3_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl21.Controls.Add(iyimserlik3_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik3_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik3_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik3_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl20.Controls.Add(iyimserlik3_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_f3sonuc = new TextBox();
            iyimserlik3_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            iyimserlik3_3_maliyet_txt_f3sonuc.Text = "0";
            iyimserlik3_3_maliyet_txt_f3sonuc.Enabled = false;
            iyimserlik3_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl35.Controls.Add(iyimserlik3_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik3_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik3_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik3_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik3_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl30.Controls.Add(iyimserlik3_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik3_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik3_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik3_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik3_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik3_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik3_3_maliyet_pl29.Controls.Add(iyimserlik3_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik3_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik3_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik3_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik3_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik3_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik3_3_maliyet_pl24.Controls.Add(iyimserlik3_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik3_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik3_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik3_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik3_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik3_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik3_3_maliyet_pl17.Controls.Add(iyimserlik3_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik3_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik3_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik3_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik3_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik3_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik3_3_maliyet_pl16.Controls.Add(iyimserlik3_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_altbaslik3 = new TextBox();
            iyimserlik3_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            iyimserlik3_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            iyimserlik3_3_maliyet_txt_altbaslik3.Text = "F3";
            iyimserlik3_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_altbaslik3.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_altbaslik3.Multiline = true;
            iyimserlik3_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            iyimserlik3_3_maliyet_pl31.Controls.Add(iyimserlik3_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik3_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik3_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik3_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik3_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik3_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik3_3_maliyet_pl15.Controls.Add(iyimserlik3_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik3_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik3_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik3_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik3_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik3_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik3_3_maliyet_pl14.Controls.Add(iyimserlik3_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik3_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik3_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik3_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik3_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik3_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik3_3_maliyet_pl13.Controls.Add(iyimserlik3_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik3_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik3_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik3_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik3_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik3_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik3_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik3_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik3_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik3_3_maliyet_pl12.Controls.Add(iyimserlik3_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            iyimserlik3_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            iyimserlik3_3_maliyet_pl35.Location = pl35k;
            iyimserlik3_3_maliyet_pl35.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik3_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik3_3_maliyet_pl30.Location = pl30k;
            iyimserlik3_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik3_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik3_3_maliyet_pl29.Location = pl29k;
            iyimserlik3_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik3_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik3_3_maliyet_pl28.Location = pl28k;
            iyimserlik3_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik3_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            iyimserlik3_3_maliyet_pl34.Location = pl34k;
            iyimserlik3_3_maliyet_pl34.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            iyimserlik3_3_maliyet_pl33.Location = pl33k;
            iyimserlik3_3_maliyet_pl33.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            iyimserlik3_3_maliyet_pl32.Location = pl32k;
            iyimserlik3_3_maliyet_pl32.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik3_3_maliyet_pl27.Location = pl27k;
            iyimserlik3_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik3_3_maliyet_pl26.Location = pl26k;
            iyimserlik3_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik3_3_maliyet_pl23.Location = pl23k;
            iyimserlik3_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik3_3_maliyet_pl22.Location = pl22k;
            iyimserlik3_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik3_3_maliyet_pl21.Location = pl21k;
            iyimserlik3_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik3_3_maliyet_pl20.Location = pl20k;
            iyimserlik3_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik3_3_maliyet_pl25.Location = pl25k;
            iyimserlik3_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik3_3_maliyet_pl19.Location = pl19k;
            iyimserlik3_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik3_3_maliyet_pl18.Location = pl18k;
            iyimserlik3_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik3_3_maliyet_pl24.Location = pl24k;
            iyimserlik3_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik3_3_maliyet_pl17.Location = pl17k;
            iyimserlik3_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik3_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik3_3_maliyet_pl16.Location = pl16k;
            iyimserlik3_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik3_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            iyimserlik3_3_maliyet_pl31.Location = pl31k;
            iyimserlik3_3_maliyet_pl31.Size = new Size(168, 33);
            iyimserlik3_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik3_3_maliyet_pl15.Location = pl15k;
            iyimserlik3_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik3_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik3_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik3_3_maliyet_pl14.Location = pl14k;
            iyimserlik3_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik3_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik3_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik3_3_maliyet_pl13.Location = pl13k;
            iyimserlik3_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik3_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik3_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik3_3_maliyet_pl12.Location = pl12k;
            iyimserlik3_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik3_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl5.Controls.Add(iyimserlik3_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik3_3_maliyet_pl11.Name = "pl11";
            iyimserlik3_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik3_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik3_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl11.Click += new EventHandler(iyimserlik3_3_maliyet_pl11_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik3_3_maliyet_pl10.Name = "pl10";
            iyimserlik3_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik3_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl10.Click += new EventHandler(iyimserlik3_3_maliyet_pl10_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik3_3_maliyet_pl9.Name = "pl9";
            iyimserlik3_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik3_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl9.Click += new EventHandler(iyimserlik3_3_maliyet_pl9_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik3_3_maliyet_pl8.Name = "pl8";
            iyimserlik3_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik3_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl8.Click += new EventHandler(iyimserlik3_3_maliyet_pl8_Click);
            iyimserlik3_3_maliyet_pl7.Controls.Add(iyimserlik3_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik3_3_maliyet_pl6.Name = "pl6";
            iyimserlik3_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik3_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl6.Click += new EventHandler(iyimserlik3_3_maliyet_pl6_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik3_3_maliyet_btn3.Name = "btn3";
            iyimserlik3_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik3_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik3_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_btn3.Click += new EventHandler(iyimserlik3_3_maliyet_btn3_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik3_3_maliyet_btn2.Name = "btn2";
            iyimserlik3_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik3_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik3_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik3_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik3_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_btn2.Click += new EventHandler(iyimserlik3_3_maliyet_btn2_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik3_3_maliyet_btn1.Name = "btn1";
            iyimserlik3_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik3_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik3_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik3_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik3_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik3_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik3_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik3_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_btn1.Click += new EventHandler(iyimserlik3_3_maliyet_btn1_Click);
            iyimserlik3_3_maliyet_pl2.Controls.Add(iyimserlik3_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik3_3_maliyet_dr1.Name = "dr1";
            iyimserlik3_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik3_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik3_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik3_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik3_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik3_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik3_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik3_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik3_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik3_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik3_3_maliyet_dr1_CellEnter);
            iyimserlik3_3_maliyet_tb1_2.Controls.Add(iyimserlik3_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik3_3_maliyet_pl7.Name = "pl7";
            iyimserlik3_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik3_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik3_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_tb1_2.Controls.Add(iyimserlik3_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik3_3_maliyet_pl5.Name = "pl5";
            iyimserlik3_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik3_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik3_3_maliyet_pl5.AutoScroll = true;
            iyimserlik3_3_maliyet_pl5.AutoSize = true;
            iyimserlik3_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik3_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_tb1_1.Controls.Add(iyimserlik3_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik3_3_maliyet_rt1.Name = "rt1";
            iyimserlik3_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik3_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik3_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_rt1.Enabled = false;
            iyimserlik3_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik3_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik3_3_maliyet_tb1_3.Controls.Add(iyimserlik3_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik3_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik3_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik3_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik3_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_tb1.Controls.Add(iyimserlik3_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik3_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik3_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik3_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik3_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_tb1.Controls.Add(iyimserlik3_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik3_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik3_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik3_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik3_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_tb1.Controls.Add(iyimserlik3_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik3_3_maliyet_tb1.Name = "tb1";
            iyimserlik3_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik3_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik3_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik3_3_maliyet_pl3.Controls.Add(iyimserlik3_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik3_3_maliyet_pl4.Name = "pl4";
            iyimserlik3_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik3_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik3_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik3_3_maliyet_pl4_MouseUp);
            iyimserlik3_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik3_3_maliyet_pl4_MouseMove);
            iyimserlik3_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik3_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik3_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik3_3_maliyet_pl3.Name = "pl3";
            iyimserlik3_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik3_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik3_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik3_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik3_3_maliyet_pl2.Name = "pl2";
            iyimserlik3_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik3_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik3_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik3_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik3_3_maliyet_pl1.Name = "pl1";
            iyimserlik3_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik3_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik3_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik3_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik3_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik3_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik3_3_maliyet_pl1_MouseUp);
            iyimserlik3_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik3_3_maliyet_pl1_MouseMove);
            iyimserlik3_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik3_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik3_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik4_3_maliyet form nesne tasarımları
        public void iyimserlik4_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik4_3_maliyet_sonuc = new Label();
            iyimserlik4_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik4_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik4_3_maliyet_sonuc.Location = sonuc;
            iyimserlik4_3_maliyet_sonuc.Text = "";
            iyimserlik4_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik4_3_maliyet_pl4.Controls.Add(iyimserlik4_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik4_3_maliyet_sonucbaslik = new Label();
            iyimserlik4_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik4_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik4_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik4_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik4_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik4_3_maliyet_pl4.Controls.Add(iyimserlik4_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik4_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik4_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik4_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik4_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik4_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik4_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik4_3_maliyet_pl28.Controls.Add(iyimserlik4_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri12 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri12.Location = txt_veri12;
            iyimserlik4_3_maliyet_txt_veri12.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl39.Controls.Add(iyimserlik4_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri11 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri11.Location = txt_veri11;
            iyimserlik4_3_maliyet_txt_veri11.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl38.Controls.Add(iyimserlik4_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri10 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri10.Location = txt_veri10;
            iyimserlik4_3_maliyet_txt_veri10.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl37.Controls.Add(iyimserlik4_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri9 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri9.Location = txt_veri9;
            iyimserlik4_3_maliyet_txt_veri9.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl34.Controls.Add(iyimserlik4_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri8 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri8.Location = txt_veri8;
            iyimserlik4_3_maliyet_txt_veri8.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl33.Controls.Add(iyimserlik4_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri7 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri7.Location = txt_veri7;
            iyimserlik4_3_maliyet_txt_veri7.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl32.Controls.Add(iyimserlik4_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik4_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl27.Controls.Add(iyimserlik4_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik4_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl23.Controls.Add(iyimserlik4_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik4_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl22.Controls.Add(iyimserlik4_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik4_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl26.Controls.Add(iyimserlik4_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik4_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl21.Controls.Add(iyimserlik4_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik4_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik4_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik4_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl20.Controls.Add(iyimserlik4_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_f4sonuc = new TextBox();
            iyimserlik4_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            iyimserlik4_3_maliyet_txt_f4sonuc.Text = "0";
            iyimserlik4_3_maliyet_txt_f4sonuc.Enabled = false;
            iyimserlik4_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl40.Controls.Add(iyimserlik4_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_f3sonuc = new TextBox();
            iyimserlik4_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            iyimserlik4_3_maliyet_txt_f3sonuc.Text = "0";
            iyimserlik4_3_maliyet_txt_f3sonuc.Enabled = false;
            iyimserlik4_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl35.Controls.Add(iyimserlik4_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik4_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik4_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik4_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik4_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl30.Controls.Add(iyimserlik4_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik4_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik4_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik4_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik4_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik4_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik4_3_maliyet_pl29.Controls.Add(iyimserlik4_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------
           
            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik4_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik4_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik4_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik4_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik4_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik4_3_maliyet_pl24.Controls.Add(iyimserlik4_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik4_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik4_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik4_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik4_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik4_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik4_3_maliyet_pl17.Controls.Add(iyimserlik4_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik4_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik4_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik4_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik4_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik4_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik4_3_maliyet_pl16.Controls.Add(iyimserlik4_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_altbaslik4 = new TextBox();
            iyimserlik4_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            iyimserlik4_3_maliyet_txt_altbaslik4.Text = "F4";
            iyimserlik4_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_altbaslik4.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_altbaslik4.Multiline = true;
            iyimserlik4_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl36.Controls.Add(iyimserlik4_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_altbaslik3 = new TextBox();
            iyimserlik4_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            iyimserlik4_3_maliyet_txt_altbaslik3.Text = "F3";
            iyimserlik4_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_altbaslik3.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_altbaslik3.Multiline = true;
            iyimserlik4_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl31.Controls.Add(iyimserlik4_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik4_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik4_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik4_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik4_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl15.Controls.Add(iyimserlik4_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik4_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik4_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik4_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik4_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl14.Controls.Add(iyimserlik4_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik4_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik4_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik4_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik4_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl13.Controls.Add(iyimserlik4_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik4_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik4_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik4_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik4_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik4_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik4_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik4_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik4_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik4_3_maliyet_pl12.Controls.Add(iyimserlik4_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            iyimserlik4_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            iyimserlik4_3_maliyet_pl40.Location = pl40k;
            iyimserlik4_3_maliyet_pl40.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            iyimserlik4_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            iyimserlik4_3_maliyet_pl35.Location = pl35k;
            iyimserlik4_3_maliyet_pl35.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik4_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik4_3_maliyet_pl30.Location = pl30k;
            iyimserlik4_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik4_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik4_3_maliyet_pl29.Location = pl29k;
            iyimserlik4_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik4_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik4_3_maliyet_pl28.Location = pl28k;
            iyimserlik4_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik4_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            iyimserlik4_3_maliyet_pl39.Location = pl39k;
            iyimserlik4_3_maliyet_pl39.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            iyimserlik4_3_maliyet_pl38.Location = pl38k;
            iyimserlik4_3_maliyet_pl38.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            iyimserlik4_3_maliyet_pl37.Location = pl37k;
            iyimserlik4_3_maliyet_pl37.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            iyimserlik4_3_maliyet_pl34.Location = pl34k;
            iyimserlik4_3_maliyet_pl34.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            iyimserlik4_3_maliyet_pl33.Location = pl33k;
            iyimserlik4_3_maliyet_pl33.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            iyimserlik4_3_maliyet_pl32.Location = pl32k;
            iyimserlik4_3_maliyet_pl32.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik4_3_maliyet_pl27.Location = pl27k;
            iyimserlik4_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik4_3_maliyet_pl26.Location = pl26k;
            iyimserlik4_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik4_3_maliyet_pl23.Location = pl23k;
            iyimserlik4_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik4_3_maliyet_pl22.Location = pl22k;
            iyimserlik4_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik4_3_maliyet_pl21.Location = pl21k;
            iyimserlik4_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik4_3_maliyet_pl20.Location = pl20k;
            iyimserlik4_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik4_3_maliyet_pl25.Location = pl25k;
            iyimserlik4_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik4_3_maliyet_pl19.Location = pl19k;
            iyimserlik4_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik4_3_maliyet_pl18.Location = pl18k;
            iyimserlik4_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik4_3_maliyet_pl24.Location = pl24k;
            iyimserlik4_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik4_3_maliyet_pl17.Location = pl17k;
            iyimserlik4_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik4_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik4_3_maliyet_pl16.Location = pl16k;
            iyimserlik4_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik4_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            iyimserlik4_3_maliyet_pl36.Location = pl36k;
            iyimserlik4_3_maliyet_pl36.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            iyimserlik4_3_maliyet_pl31.Location = pl31k;
            iyimserlik4_3_maliyet_pl31.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik4_3_maliyet_pl15.Location = pl15k;
            iyimserlik4_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik4_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik4_3_maliyet_pl14.Location = pl14k;
            iyimserlik4_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik4_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik4_3_maliyet_pl13.Location = pl13k;
            iyimserlik4_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik4_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik4_3_maliyet_pl12.Location = pl12k;
            iyimserlik4_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik4_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl5.Controls.Add(iyimserlik4_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik4_3_maliyet_pl11.Name = "pl11";
            iyimserlik4_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik4_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik4_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl11.Click += new EventHandler(iyimserlik4_3_maliyet_pl11_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik4_3_maliyet_pl10.Name = "pl10";
            iyimserlik4_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik4_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl10.Click += new EventHandler(iyimserlik4_3_maliyet_pl10_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik4_3_maliyet_pl9.Name = "pl9";
            iyimserlik4_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik4_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl9.Click += new EventHandler(iyimserlik4_3_maliyet_pl9_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik4_3_maliyet_pl8.Name = "pl8";
            iyimserlik4_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik4_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl8.Click += new EventHandler(iyimserlik4_3_maliyet_pl8_Click);
            iyimserlik4_3_maliyet_pl7.Controls.Add(iyimserlik4_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik4_3_maliyet_pl6.Name = "pl6";
            iyimserlik4_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik4_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl6.Click += new EventHandler(iyimserlik4_3_maliyet_pl6_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik4_3_maliyet_btn3.Name = "btn3";
            iyimserlik4_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik4_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik4_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_btn3.Click += new EventHandler(iyimserlik4_3_maliyet_btn3_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik4_3_maliyet_btn2.Name = "btn2";
            iyimserlik4_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik4_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik4_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik4_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik4_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_btn2.Click += new EventHandler(iyimserlik4_3_maliyet_btn2_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik4_3_maliyet_btn1.Name = "btn1";
            iyimserlik4_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik4_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik4_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik4_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik4_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik4_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik4_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik4_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_btn1.Click += new EventHandler(iyimserlik4_3_maliyet_btn1_Click);
            iyimserlik4_3_maliyet_pl2.Controls.Add(iyimserlik4_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik4_3_maliyet_dr1.Name = "dr1";
            iyimserlik4_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik4_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik4_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik4_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik4_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik4_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik4_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik4_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik4_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik4_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik4_3_maliyet_dr1_CellEnter);
            iyimserlik4_3_maliyet_tb1_2.Controls.Add(iyimserlik4_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik4_3_maliyet_pl7.Name = "pl7";
            iyimserlik4_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik4_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik4_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_tb1_2.Controls.Add(iyimserlik4_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik4_3_maliyet_pl5.Name = "pl5";
            iyimserlik4_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik4_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik4_3_maliyet_pl5.AutoScroll = true;
            iyimserlik4_3_maliyet_pl5.AutoSize = true;
            iyimserlik4_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik4_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_tb1_1.Controls.Add(iyimserlik4_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik4_3_maliyet_rt1.Name = "rt1";
            iyimserlik4_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik4_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik4_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_rt1.Enabled = false;
            iyimserlik4_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik4_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik4_3_maliyet_tb1_3.Controls.Add(iyimserlik4_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik4_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik4_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik4_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik4_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_tb1.Controls.Add(iyimserlik4_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik4_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik4_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik4_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik4_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_tb1.Controls.Add(iyimserlik4_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik4_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik4_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik4_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik4_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_tb1.Controls.Add(iyimserlik4_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik4_3_maliyet_tb1.Name = "tb1";
            iyimserlik4_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik4_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik4_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik4_3_maliyet_pl3.Controls.Add(iyimserlik4_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik4_3_maliyet_pl4.Name = "pl4";
            iyimserlik4_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik4_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik4_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik4_3_maliyet_pl4_MouseUp);
            iyimserlik4_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik4_3_maliyet_pl4_MouseMove);
            iyimserlik4_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik4_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik4_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik4_3_maliyet_pl3.Name = "pl3";
            iyimserlik4_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik4_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik4_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik4_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik4_3_maliyet_pl2.Name = "pl2";
            iyimserlik4_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik4_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik4_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik4_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik4_3_maliyet_pl1.Name = "pl1";
            iyimserlik4_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik4_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik4_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik4_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik4_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik4_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik4_3_maliyet_pl1_MouseUp);
            iyimserlik4_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik4_3_maliyet_pl1_MouseMove);
            iyimserlik4_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik4_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik4_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik5_3_maliyet form nesne tasarımları
        public void iyimserlik5_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik5_3_maliyet_sonuc = new Label();
            iyimserlik5_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik5_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik5_3_maliyet_sonuc.Location = sonuc;
            iyimserlik5_3_maliyet_sonuc.Text = "";
            iyimserlik5_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik5_3_maliyet_pl4.Controls.Add(iyimserlik5_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik5_3_maliyet_sonucbaslik = new Label();
            iyimserlik5_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik5_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik5_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik5_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik5_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik5_3_maliyet_pl4.Controls.Add(iyimserlik5_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik5_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik5_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik5_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik5_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik5_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik5_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik5_3_maliyet_pl28.Controls.Add(iyimserlik5_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri15 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri15.Location = txt_veri15;
            iyimserlik5_3_maliyet_txt_veri15.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl44.Controls.Add(iyimserlik5_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri14 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri14.Location = txt_veri14;
            iyimserlik5_3_maliyet_txt_veri14.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl43.Controls.Add(iyimserlik5_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri13 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri13.Location = txt_veri13;
            iyimserlik5_3_maliyet_txt_veri13.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl42.Controls.Add(iyimserlik5_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri12 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri12.Location = txt_veri12;
            iyimserlik5_3_maliyet_txt_veri12.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl39.Controls.Add(iyimserlik5_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri11 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri11.Location = txt_veri11;
            iyimserlik5_3_maliyet_txt_veri11.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl38.Controls.Add(iyimserlik5_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri10 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri10.Location = txt_veri10;
            iyimserlik5_3_maliyet_txt_veri10.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl37.Controls.Add(iyimserlik5_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri9 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri9.Location = txt_veri9;
            iyimserlik5_3_maliyet_txt_veri9.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl34.Controls.Add(iyimserlik5_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri8 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri8.Location = txt_veri8;
            iyimserlik5_3_maliyet_txt_veri8.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl33.Controls.Add(iyimserlik5_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri7 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri7.Location = txt_veri7;
            iyimserlik5_3_maliyet_txt_veri7.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl32.Controls.Add(iyimserlik5_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik5_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl27.Controls.Add(iyimserlik5_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik5_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl23.Controls.Add(iyimserlik5_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik5_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl22.Controls.Add(iyimserlik5_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik5_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl26.Controls.Add(iyimserlik5_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik5_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl21.Controls.Add(iyimserlik5_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik5_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik5_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik5_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl20.Controls.Add(iyimserlik5_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_f5sonuc = new TextBox();
            iyimserlik5_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            iyimserlik5_3_maliyet_txt_f5sonuc.Text = "0";
            iyimserlik5_3_maliyet_txt_f5sonuc.Enabled = false;
            iyimserlik5_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl45.Controls.Add(iyimserlik5_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_f4sonuc = new TextBox();
            iyimserlik5_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            iyimserlik5_3_maliyet_txt_f4sonuc.Text = "0";
            iyimserlik5_3_maliyet_txt_f4sonuc.Enabled = false;
            iyimserlik5_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl40.Controls.Add(iyimserlik5_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_f3sonuc = new TextBox();
            iyimserlik5_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            iyimserlik5_3_maliyet_txt_f3sonuc.Text = "0";
            iyimserlik5_3_maliyet_txt_f3sonuc.Enabled = false;
            iyimserlik5_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl35.Controls.Add(iyimserlik5_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik5_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik5_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik5_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik5_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl30.Controls.Add(iyimserlik5_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik5_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik5_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik5_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik5_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik5_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik5_3_maliyet_pl29.Controls.Add(iyimserlik5_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------
         
            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik5_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik5_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik5_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik5_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik5_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik5_3_maliyet_pl24.Controls.Add(iyimserlik5_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik5_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik5_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik5_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik5_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik5_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik5_3_maliyet_pl17.Controls.Add(iyimserlik5_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik5_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik5_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik5_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik5_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik5_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik5_3_maliyet_pl16.Controls.Add(iyimserlik5_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_altbaslik5 = new TextBox();
            iyimserlik5_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            iyimserlik5_3_maliyet_txt_altbaslik5.Text = "F5";
            iyimserlik5_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_altbaslik5.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_altbaslik5.Multiline = true;
            iyimserlik5_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl41.Controls.Add(iyimserlik5_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_altbaslik4 = new TextBox();
            iyimserlik5_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            iyimserlik5_3_maliyet_txt_altbaslik4.Text = "F4";
            iyimserlik5_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_altbaslik4.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_altbaslik4.Multiline = true;
            iyimserlik5_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl36.Controls.Add(iyimserlik5_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_altbaslik3 = new TextBox();
            iyimserlik5_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            iyimserlik5_3_maliyet_txt_altbaslik3.Text = "F3";
            iyimserlik5_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_altbaslik3.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_altbaslik3.Multiline = true;
            iyimserlik5_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl31.Controls.Add(iyimserlik5_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik5_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik5_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik5_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik5_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl15.Controls.Add(iyimserlik5_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik5_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik5_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik5_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik5_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl14.Controls.Add(iyimserlik5_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik5_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik5_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik5_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik5_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl13.Controls.Add(iyimserlik5_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik5_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik5_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik5_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik5_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik5_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik5_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik5_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik5_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik5_3_maliyet_pl12.Controls.Add(iyimserlik5_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            iyimserlik5_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            iyimserlik5_3_maliyet_pl45.Location = pl45k;
            iyimserlik5_3_maliyet_pl45.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            iyimserlik5_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            iyimserlik5_3_maliyet_pl40.Location = pl40k;
            iyimserlik5_3_maliyet_pl40.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            iyimserlik5_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            iyimserlik5_3_maliyet_pl35.Location = pl35k;
            iyimserlik5_3_maliyet_pl35.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik5_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik5_3_maliyet_pl30.Location = pl30k;
            iyimserlik5_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik5_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik5_3_maliyet_pl29.Location = pl29k;
            iyimserlik5_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik5_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik5_3_maliyet_pl28.Location = pl28k;
            iyimserlik5_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik5_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            iyimserlik5_3_maliyet_pl44.Location = pl44k;
            iyimserlik5_3_maliyet_pl44.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            iyimserlik5_3_maliyet_pl43.Location = pl43k;
            iyimserlik5_3_maliyet_pl43.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            iyimserlik5_3_maliyet_pl42.Location = pl42k;
            iyimserlik5_3_maliyet_pl42.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            iyimserlik5_3_maliyet_pl39.Location = pl39k;
            iyimserlik5_3_maliyet_pl39.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            iyimserlik5_3_maliyet_pl38.Location = pl38k;
            iyimserlik5_3_maliyet_pl38.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            iyimserlik5_3_maliyet_pl37.Location = pl37k;
            iyimserlik5_3_maliyet_pl37.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            iyimserlik5_3_maliyet_pl34.Location = pl34k;
            iyimserlik5_3_maliyet_pl34.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            iyimserlik5_3_maliyet_pl33.Location = pl33k;
            iyimserlik5_3_maliyet_pl33.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            iyimserlik5_3_maliyet_pl32.Location = pl32k;
            iyimserlik5_3_maliyet_pl32.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik5_3_maliyet_pl27.Location = pl27k;
            iyimserlik5_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik5_3_maliyet_pl26.Location = pl26k;
            iyimserlik5_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik5_3_maliyet_pl23.Location = pl23k;
            iyimserlik5_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik5_3_maliyet_pl22.Location = pl22k;
            iyimserlik5_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik5_3_maliyet_pl21.Location = pl21k;
            iyimserlik5_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik5_3_maliyet_pl20.Location = pl20k;
            iyimserlik5_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik5_3_maliyet_pl25.Location = pl25k;
            iyimserlik5_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik5_3_maliyet_pl19.Location = pl19k;
            iyimserlik5_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik5_3_maliyet_pl18.Location = pl18k;
            iyimserlik5_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik5_3_maliyet_pl24.Location = pl24k;
            iyimserlik5_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik5_3_maliyet_pl17.Location = pl17k;
            iyimserlik5_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik5_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik5_3_maliyet_pl16.Location = pl16k;
            iyimserlik5_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik5_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            iyimserlik5_3_maliyet_pl41.Location = pl41k;
            iyimserlik5_3_maliyet_pl41.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            iyimserlik5_3_maliyet_pl36.Location = pl36k;
            iyimserlik5_3_maliyet_pl36.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            iyimserlik5_3_maliyet_pl31.Location = pl31k;
            iyimserlik5_3_maliyet_pl31.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik5_3_maliyet_pl15.Location = pl15k;
            iyimserlik5_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik5_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik5_3_maliyet_pl14.Location = pl14k;
            iyimserlik5_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik5_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik5_3_maliyet_pl13.Location = pl13k;
            iyimserlik5_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik5_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik5_3_maliyet_pl12.Location = pl12k;
            iyimserlik5_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik5_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl5.Controls.Add(iyimserlik5_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik5_3_maliyet_pl11.Name = "pl11";
            iyimserlik5_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik5_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik5_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl11.Click += new EventHandler(iyimserlik5_3_maliyet_pl11_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik5_3_maliyet_pl10.Name = "pl10";
            iyimserlik5_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik5_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl10.Click += new EventHandler(iyimserlik5_3_maliyet_pl10_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik5_3_maliyet_pl9.Name = "pl9";
            iyimserlik5_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik5_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl9.Click += new EventHandler(iyimserlik5_3_maliyet_pl9_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik5_3_maliyet_pl8.Name = "pl8";
            iyimserlik5_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik5_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl8.Click += new EventHandler(iyimserlik5_3_maliyet_pl8_Click);
            iyimserlik5_3_maliyet_pl7.Controls.Add(iyimserlik5_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik5_3_maliyet_pl6.Name = "pl6";
            iyimserlik5_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik5_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl6.Click += new EventHandler(iyimserlik5_3_maliyet_pl6_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik5_3_maliyet_btn3.Name = "btn3";
            iyimserlik5_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik5_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik5_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_btn3.Click += new EventHandler(iyimserlik5_3_maliyet_btn3_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik5_3_maliyet_btn2.Name = "btn2";
            iyimserlik5_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik5_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik5_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik5_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik5_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_btn2.Click += new EventHandler(iyimserlik5_3_maliyet_btn2_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik5_3_maliyet_btn1.Name = "btn1";
            iyimserlik5_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik5_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik5_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik5_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik5_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik5_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik5_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik5_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_btn1.Click += new EventHandler(iyimserlik5_3_maliyet_btn1_Click);
            iyimserlik5_3_maliyet_pl2.Controls.Add(iyimserlik5_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik5_3_maliyet_dr1.Name = "dr1";
            iyimserlik5_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik5_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik5_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik5_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik5_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik5_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik5_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik5_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik5_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik5_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik5_3_maliyet_dr1_CellEnter);
            iyimserlik5_3_maliyet_tb1_2.Controls.Add(iyimserlik5_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik5_3_maliyet_pl7.Name = "pl7";
            iyimserlik5_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik5_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik5_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_tb1_2.Controls.Add(iyimserlik5_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik5_3_maliyet_pl5.Name = "pl5";
            iyimserlik5_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik5_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik5_3_maliyet_pl5.AutoScroll = true;
            iyimserlik5_3_maliyet_pl5.AutoSize = true;
            iyimserlik5_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik5_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_tb1_1.Controls.Add(iyimserlik5_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik5_3_maliyet_rt1.Name = "rt1";
            iyimserlik5_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik5_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik5_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_rt1.Enabled = false;
            iyimserlik5_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik5_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik5_3_maliyet_tb1_3.Controls.Add(iyimserlik5_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik5_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik5_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik5_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik5_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_tb1.Controls.Add(iyimserlik5_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik5_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik5_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik5_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik5_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_tb1.Controls.Add(iyimserlik5_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik5_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik5_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik5_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik5_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_tb1.Controls.Add(iyimserlik5_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik5_3_maliyet_tb1.Name = "tb1";
            iyimserlik5_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik5_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik5_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik5_3_maliyet_pl3.Controls.Add(iyimserlik5_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik5_3_maliyet_pl4.Name = "pl4";
            iyimserlik5_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik5_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik5_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik5_3_maliyet_pl4_MouseUp);
            iyimserlik5_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik5_3_maliyet_pl4_MouseMove);
            iyimserlik5_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik5_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik5_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik5_3_maliyet_pl3.Name = "pl3";
            iyimserlik5_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik5_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik5_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik5_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik5_3_maliyet_pl2.Name = "pl2";
            iyimserlik5_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik5_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik5_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik5_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik5_3_maliyet_pl1.Name = "pl1";
            iyimserlik5_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik5_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik5_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik5_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik5_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik5_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik5_3_maliyet_pl1_MouseUp);
            iyimserlik5_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik5_3_maliyet_pl1_MouseMove);
            iyimserlik5_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik5_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik5_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik6_3_maliyet form nesne tasarımları
        public void iyimserlik6_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik6_3_maliyet_sonuc = new Label();
            iyimserlik6_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik6_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik6_3_maliyet_sonuc.Location = sonuc;
            iyimserlik6_3_maliyet_sonuc.Text = "";
            iyimserlik6_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik6_3_maliyet_pl4.Controls.Add(iyimserlik6_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik6_3_maliyet_sonucbaslik = new Label();
            iyimserlik6_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik6_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik6_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik6_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik6_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik6_3_maliyet_pl4.Controls.Add(iyimserlik6_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik6_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik6_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik6_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik6_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik6_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik6_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik6_3_maliyet_pl28.Controls.Add(iyimserlik6_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri18 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri18.Location = txt_veri18;
            iyimserlik6_3_maliyet_txt_veri18.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl49.Controls.Add(iyimserlik6_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri17 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri17.Location = txt_veri17;
            iyimserlik6_3_maliyet_txt_veri17.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl48.Controls.Add(iyimserlik6_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri16 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri16.Location = txt_veri16;
            iyimserlik6_3_maliyet_txt_veri16.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl47.Controls.Add(iyimserlik6_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri15 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri15.Location = txt_veri15;
            iyimserlik6_3_maliyet_txt_veri15.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl44.Controls.Add(iyimserlik6_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri14 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri14.Location = txt_veri14;
            iyimserlik6_3_maliyet_txt_veri14.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl43.Controls.Add(iyimserlik6_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri13 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri13.Location = txt_veri13;
            iyimserlik6_3_maliyet_txt_veri13.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl42.Controls.Add(iyimserlik6_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri12 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri12.Location = txt_veri12;
            iyimserlik6_3_maliyet_txt_veri12.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl39.Controls.Add(iyimserlik6_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri11 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri11.Location = txt_veri11;
            iyimserlik6_3_maliyet_txt_veri11.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl38.Controls.Add(iyimserlik6_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri10 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri10.Location = txt_veri10;
            iyimserlik6_3_maliyet_txt_veri10.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl37.Controls.Add(iyimserlik6_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri9 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri9.Location = txt_veri9;
            iyimserlik6_3_maliyet_txt_veri9.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl34.Controls.Add(iyimserlik6_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri8 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri8.Location = txt_veri8;
            iyimserlik6_3_maliyet_txt_veri8.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl33.Controls.Add(iyimserlik6_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri7 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri7.Location = txt_veri7;
            iyimserlik6_3_maliyet_txt_veri7.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl32.Controls.Add(iyimserlik6_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik6_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl27.Controls.Add(iyimserlik6_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik6_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl23.Controls.Add(iyimserlik6_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik6_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl22.Controls.Add(iyimserlik6_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik6_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl26.Controls.Add(iyimserlik6_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik6_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl21.Controls.Add(iyimserlik6_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik6_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik6_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik6_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl20.Controls.Add(iyimserlik6_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f6sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f6sonuc.Location = txt_txtf6sonuc;
            iyimserlik6_3_maliyet_txt_f6sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f6sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f6sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl50.Controls.Add(iyimserlik6_3_maliyet_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f5sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            iyimserlik6_3_maliyet_txt_f5sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f5sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl45.Controls.Add(iyimserlik6_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f4sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            iyimserlik6_3_maliyet_txt_f4sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f4sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl40.Controls.Add(iyimserlik6_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f3sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            iyimserlik6_3_maliyet_txt_f3sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f3sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl35.Controls.Add(iyimserlik6_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik6_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl30.Controls.Add(iyimserlik6_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik6_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik6_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik6_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik6_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik6_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik6_3_maliyet_pl29.Controls.Add(iyimserlik6_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------        

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik6_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik6_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik6_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik6_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik6_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik6_3_maliyet_pl24.Controls.Add(iyimserlik6_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik6_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik6_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik6_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik6_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik6_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik6_3_maliyet_pl17.Controls.Add(iyimserlik6_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik6_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik6_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik6_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik6_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik6_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik6_3_maliyet_pl16.Controls.Add(iyimserlik6_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik6 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            iyimserlik6_3_maliyet_txt_altbaslik6.Text = "F6";
            iyimserlik6_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik6.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik6.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl46.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik5 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            iyimserlik6_3_maliyet_txt_altbaslik5.Text = "F5";
            iyimserlik6_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik5.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik5.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl41.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik4 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            iyimserlik6_3_maliyet_txt_altbaslik4.Text = "F4";
            iyimserlik6_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik4.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik4.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl36.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik3 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            iyimserlik6_3_maliyet_txt_altbaslik3.Text = "F3";
            iyimserlik6_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik3.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik3.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl31.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik6_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik6_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl15.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik6_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik6_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik6_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik6_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl14.Controls.Add(iyimserlik6_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik6_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik6_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik6_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik6_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl13.Controls.Add(iyimserlik6_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik6_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik6_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik6_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik6_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik6_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik6_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik6_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik6_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik6_3_maliyet_pl12.Controls.Add(iyimserlik6_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            iyimserlik6_3_maliyet_pl50.Location = pl50k;
            iyimserlik6_3_maliyet_pl50.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            iyimserlik6_3_maliyet_pl45.Location = pl45k;
            iyimserlik6_3_maliyet_pl45.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            iyimserlik6_3_maliyet_pl40.Location = pl40k;
            iyimserlik6_3_maliyet_pl40.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            iyimserlik6_3_maliyet_pl35.Location = pl35k;
            iyimserlik6_3_maliyet_pl35.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik6_3_maliyet_pl30.Location = pl30k;
            iyimserlik6_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik6_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik6_3_maliyet_pl29.Location = pl29k;
            iyimserlik6_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik6_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik6_3_maliyet_pl28.Location = pl28k;
            iyimserlik6_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik6_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            iyimserlik6_3_maliyet_pl49.Location = pl49k;
            iyimserlik6_3_maliyet_pl49.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            iyimserlik6_3_maliyet_pl48.Location = pl48k;
            iyimserlik6_3_maliyet_pl48.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            iyimserlik6_3_maliyet_pl47.Location = pl47k;
            iyimserlik6_3_maliyet_pl47.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            iyimserlik6_3_maliyet_pl44.Location = pl44k;
            iyimserlik6_3_maliyet_pl44.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            iyimserlik6_3_maliyet_pl43.Location = pl43k;
            iyimserlik6_3_maliyet_pl43.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            iyimserlik6_3_maliyet_pl42.Location = pl42k;
            iyimserlik6_3_maliyet_pl42.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            iyimserlik6_3_maliyet_pl39.Location = pl39k;
            iyimserlik6_3_maliyet_pl39.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            iyimserlik6_3_maliyet_pl38.Location = pl38k;
            iyimserlik6_3_maliyet_pl38.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            iyimserlik6_3_maliyet_pl37.Location = pl37k;
            iyimserlik6_3_maliyet_pl37.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            iyimserlik6_3_maliyet_pl34.Location = pl34k;
            iyimserlik6_3_maliyet_pl34.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            iyimserlik6_3_maliyet_pl33.Location = pl33k;
            iyimserlik6_3_maliyet_pl33.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            iyimserlik6_3_maliyet_pl32.Location = pl32k;
            iyimserlik6_3_maliyet_pl32.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik6_3_maliyet_pl27.Location = pl27k;
            iyimserlik6_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik6_3_maliyet_pl26.Location = pl26k;
            iyimserlik6_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik6_3_maliyet_pl23.Location = pl23k;
            iyimserlik6_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik6_3_maliyet_pl22.Location = pl22k;
            iyimserlik6_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik6_3_maliyet_pl21.Location = pl21k;
            iyimserlik6_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik6_3_maliyet_pl20.Location = pl20k;
            iyimserlik6_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik6_3_maliyet_pl25.Location = pl25k;
            iyimserlik6_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik6_3_maliyet_pl19.Location = pl19k;
            iyimserlik6_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik6_3_maliyet_pl18.Location = pl18k;
            iyimserlik6_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik6_3_maliyet_pl24.Location = pl24k;
            iyimserlik6_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik6_3_maliyet_pl17.Location = pl17k;
            iyimserlik6_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik6_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik6_3_maliyet_pl16.Location = pl16k;
            iyimserlik6_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik6_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            iyimserlik6_3_maliyet_pl46.Location = pl46k;
            iyimserlik6_3_maliyet_pl46.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            iyimserlik6_3_maliyet_pl41.Location = pl41k;
            iyimserlik6_3_maliyet_pl41.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            iyimserlik6_3_maliyet_pl36.Location = pl36k;
            iyimserlik6_3_maliyet_pl36.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            iyimserlik6_3_maliyet_pl31.Location = pl31k;
            iyimserlik6_3_maliyet_pl31.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik6_3_maliyet_pl15.Location = pl15k;
            iyimserlik6_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik6_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik6_3_maliyet_pl14.Location = pl14k;
            iyimserlik6_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik6_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik6_3_maliyet_pl13.Location = pl13k;
            iyimserlik6_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik6_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik6_3_maliyet_pl12.Location = pl12k;
            iyimserlik6_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik6_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl5.Controls.Add(iyimserlik6_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik6_3_maliyet_pl11.Name = "pl11";
            iyimserlik6_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik6_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik6_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl11.Click += new EventHandler(iyimserlik6_3_maliyet_pl11_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik6_3_maliyet_pl10.Name = "pl10";
            iyimserlik6_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik6_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl10.Click += new EventHandler(iyimserlik6_3_maliyet_pl10_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik6_3_maliyet_pl9.Name = "pl9";
            iyimserlik6_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik6_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl9.Click += new EventHandler(iyimserlik6_3_maliyet_pl9_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik6_3_maliyet_pl8.Name = "pl8";
            iyimserlik6_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik6_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl8.Click += new EventHandler(iyimserlik6_3_maliyet_pl8_Click);
            iyimserlik6_3_maliyet_pl7.Controls.Add(iyimserlik6_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik6_3_maliyet_pl6.Name = "pl6";
            iyimserlik6_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik6_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl6.Click += new EventHandler(iyimserlik6_3_maliyet_pl6_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik6_3_maliyet_btn3.Name = "btn3";
            iyimserlik6_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik6_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik6_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_btn3.Click += new EventHandler(iyimserlik6_3_maliyet_btn3_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik6_3_maliyet_btn2.Name = "btn2";
            iyimserlik6_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik6_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik6_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik6_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik6_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_btn2.Click += new EventHandler(iyimserlik6_3_maliyet_btn2_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik6_3_maliyet_btn1.Name = "btn1";
            iyimserlik6_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik6_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik6_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik6_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik6_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik6_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik6_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik6_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_btn1.Click += new EventHandler(iyimserlik6_3_maliyet_btn1_Click);
            iyimserlik6_3_maliyet_pl2.Controls.Add(iyimserlik6_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik6_3_maliyet_dr1.Name = "dr1";
            iyimserlik6_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik6_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik6_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik6_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik6_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik6_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik6_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik6_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik6_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik6_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik6_3_maliyet_dr1_CellEnter);
            iyimserlik6_3_maliyet_tb1_2.Controls.Add(iyimserlik6_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik6_3_maliyet_pl7.Name = "pl7";
            iyimserlik6_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik6_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik6_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_tb1_2.Controls.Add(iyimserlik6_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik6_3_maliyet_pl5.Name = "pl5";
            iyimserlik6_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik6_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik6_3_maliyet_pl5.AutoScroll = true;
            iyimserlik6_3_maliyet_pl5.AutoSize = true;
            iyimserlik6_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik6_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_tb1_1.Controls.Add(iyimserlik6_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik6_3_maliyet_rt1.Name = "rt1";
            iyimserlik6_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik6_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik6_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_rt1.Enabled = false;
            iyimserlik6_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik6_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik6_3_maliyet_tb1_3.Controls.Add(iyimserlik6_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik6_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik6_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik6_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik6_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_tb1.Controls.Add(iyimserlik6_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik6_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik6_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik6_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik6_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_tb1.Controls.Add(iyimserlik6_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik6_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik6_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik6_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik6_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_tb1.Controls.Add(iyimserlik6_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik6_3_maliyet_tb1.Name = "tb1";
            iyimserlik6_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik6_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik6_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik6_3_maliyet_pl3.Controls.Add(iyimserlik6_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik6_3_maliyet_pl4.Name = "pl4";
            iyimserlik6_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik6_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik6_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik6_3_maliyet_pl4_MouseUp);
            iyimserlik6_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik6_3_maliyet_pl4_MouseMove);
            iyimserlik6_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik6_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik6_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik6_3_maliyet_pl3.Name = "pl3";
            iyimserlik6_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik6_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik6_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik6_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik6_3_maliyet_pl2.Name = "pl2";
            iyimserlik6_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik6_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik6_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik6_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik6_3_maliyet_pl1.Name = "pl1";
            iyimserlik6_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik6_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik6_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik6_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik6_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik6_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik6_3_maliyet_pl1_MouseUp);
            iyimserlik6_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik6_3_maliyet_pl1_MouseMove);
            iyimserlik6_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik6_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik6_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik7_3_maliyet form nesne tasarımları
        public void iyimserlik7_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            iyimserlik7_3_maliyet_sonuc = new Label();
            iyimserlik7_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            iyimserlik7_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik7_3_maliyet_sonuc.Location = sonuc;
            iyimserlik7_3_maliyet_sonuc.Text = "";
            iyimserlik7_3_maliyet_sonuc.Size = new Size(650, 13);
            iyimserlik7_3_maliyet_pl4.Controls.Add(iyimserlik7_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            iyimserlik7_3_maliyet_sonucbaslik = new Label();
            iyimserlik7_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            iyimserlik7_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik7_3_maliyet_sonucbaslik.Location = sonucbaslik;
            iyimserlik7_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            iyimserlik7_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            iyimserlik7_3_maliyet_pl4.Controls.Add(iyimserlik7_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            iyimserlik7_3_maliyet_sonuclarortabaslik = new Label();
            iyimserlik7_3_maliyet_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            iyimserlik7_3_maliyet_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            iyimserlik7_3_maliyet_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            iyimserlik7_3_maliyet_sonuclarortabaslik.Text = "Min";
            iyimserlik7_3_maliyet_sonuclarortabaslik.Size = new Size(49, 13);
            iyimserlik7_3_maliyet_pl28.Controls.Add(iyimserlik7_3_maliyet_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri21 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri21.Location = txt_veri21;
            iyimserlik7_3_maliyet_txt_veri21.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl54.Controls.Add(iyimserlik7_3_maliyet_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri20 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri20.Location = txt_veri20;
            iyimserlik7_3_maliyet_txt_veri20.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl53.Controls.Add(iyimserlik7_3_maliyet_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri19 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri19.Location = txt_veri19;
            iyimserlik7_3_maliyet_txt_veri19.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl52.Controls.Add(iyimserlik7_3_maliyet_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri18 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri18.Location = txt_veri18;
            iyimserlik7_3_maliyet_txt_veri18.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl49.Controls.Add(iyimserlik7_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri17 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri17.Location = txt_veri17;
            iyimserlik7_3_maliyet_txt_veri17.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl48.Controls.Add(iyimserlik7_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri16 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri16.Location = txt_veri16;
            iyimserlik7_3_maliyet_txt_veri16.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl47.Controls.Add(iyimserlik7_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri15 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri15.Location = txt_veri15;
            iyimserlik7_3_maliyet_txt_veri15.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl44.Controls.Add(iyimserlik7_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri14 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri14.Location = txt_veri14;
            iyimserlik7_3_maliyet_txt_veri14.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl43.Controls.Add(iyimserlik7_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri13 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri13.Location = txt_veri13;
            iyimserlik7_3_maliyet_txt_veri13.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl42.Controls.Add(iyimserlik7_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri12 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri12.Location = txt_veri12;
            iyimserlik7_3_maliyet_txt_veri12.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl39.Controls.Add(iyimserlik7_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri11 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri11.Location = txt_veri11;
            iyimserlik7_3_maliyet_txt_veri11.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl38.Controls.Add(iyimserlik7_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri10 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri10.Location = txt_veri10;
            iyimserlik7_3_maliyet_txt_veri10.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl37.Controls.Add(iyimserlik7_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri9 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri9.Location = txt_veri9;
            iyimserlik7_3_maliyet_txt_veri9.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl34.Controls.Add(iyimserlik7_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri8 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri8.Location = txt_veri8;
            iyimserlik7_3_maliyet_txt_veri8.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl33.Controls.Add(iyimserlik7_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri7 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri7.Location = txt_veri7;
            iyimserlik7_3_maliyet_txt_veri7.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl32.Controls.Add(iyimserlik7_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri6 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri6.Location = txt_veri6;
            iyimserlik7_3_maliyet_txt_veri6.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl27.Controls.Add(iyimserlik7_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri5 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri5.Location = txt_veri5;
            iyimserlik7_3_maliyet_txt_veri5.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl23.Controls.Add(iyimserlik7_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri4 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri4.Location = txt_veri4;
            iyimserlik7_3_maliyet_txt_veri4.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl22.Controls.Add(iyimserlik7_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri3 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri3.Location = txt_veri3;
            iyimserlik7_3_maliyet_txt_veri3.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl26.Controls.Add(iyimserlik7_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri2 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri2.Location = txt_veri2;
            iyimserlik7_3_maliyet_txt_veri2.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl21.Controls.Add(iyimserlik7_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_veri1 = new NumericUpDown();
            iyimserlik7_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            iyimserlik7_3_maliyet_txt_veri1.Location = txt_veri1;
            iyimserlik7_3_maliyet_txt_veri1.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl20.Controls.Add(iyimserlik7_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel55 içerisine f7sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f7sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f7sonuc.Name = "txtf7sonuc";
            Point txt_txtf7sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f7sonuc.Location = txt_txtf7sonuc;
            iyimserlik7_3_maliyet_txt_f7sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f7sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f7sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl55.Controls.Add(iyimserlik7_3_maliyet_txt_f7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f6sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f6sonuc.Location = txt_txtf6sonuc;
            iyimserlik7_3_maliyet_txt_f6sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f6sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f6sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl50.Controls.Add(iyimserlik7_3_maliyet_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f5sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f5sonuc.Location = txt_txtf5sonuc;
            iyimserlik7_3_maliyet_txt_f5sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f5sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f5sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl45.Controls.Add(iyimserlik7_3_maliyet_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f4sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f4sonuc.Location = txt_txtf4sonuc;
            iyimserlik7_3_maliyet_txt_f4sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f4sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f4sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl40.Controls.Add(iyimserlik7_3_maliyet_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f3sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f3sonuc.Location = txt_txtf3sonuc;
            iyimserlik7_3_maliyet_txt_f3sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f3sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f3sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl35.Controls.Add(iyimserlik7_3_maliyet_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f2sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f2sonuc.Location = txt_txtf2sonuc;
            iyimserlik7_3_maliyet_txt_f2sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f2sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f2sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl30.Controls.Add(iyimserlik7_3_maliyet_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_f1sonuc = new TextBox();
            iyimserlik7_3_maliyet_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            iyimserlik7_3_maliyet_txt_f1sonuc.Location = txt_txtf1sonuc;
            iyimserlik7_3_maliyet_txt_f1sonuc.Text = "0";
            iyimserlik7_3_maliyet_txt_f1sonuc.Enabled = false;
            iyimserlik7_3_maliyet_txt_f1sonuc.Size = new Size(85, 20);
            iyimserlik7_3_maliyet_pl29.Controls.Add(iyimserlik7_3_maliyet_txt_f1sonuc);
            //---------------------------------------------------------------          

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_üstbaslik3 = new TextBox();
            iyimserlik7_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            iyimserlik7_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            iyimserlik7_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            iyimserlik7_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_üstbaslik3.Multiline = true;
            iyimserlik7_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            iyimserlik7_3_maliyet_pl24.Controls.Add(iyimserlik7_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_üstbaslik2 = new TextBox();
            iyimserlik7_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            iyimserlik7_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            iyimserlik7_3_maliyet_txt_üstbaslik2.Text = "Orta";
            iyimserlik7_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_üstbaslik2.Multiline = true;
            iyimserlik7_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            iyimserlik7_3_maliyet_pl17.Controls.Add(iyimserlik7_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_üstbaslik1 = new TextBox();
            iyimserlik7_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            iyimserlik7_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            iyimserlik7_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            iyimserlik7_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_üstbaslik1.Multiline = true;
            iyimserlik7_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            iyimserlik7_3_maliyet_pl16.Controls.Add(iyimserlik7_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik7 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik7.Location = txt_txtaltbaslik7;
            iyimserlik7_3_maliyet_txt_altbaslik7.Text = "F7";
            iyimserlik7_3_maliyet_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik7.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik7.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik7.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl51.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik6 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            iyimserlik7_3_maliyet_txt_altbaslik6.Text = "F6";
            iyimserlik7_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik6.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik6.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl46.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik5 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            iyimserlik7_3_maliyet_txt_altbaslik5.Text = "F5";
            iyimserlik7_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik5.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik5.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl41.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik4 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            iyimserlik7_3_maliyet_txt_altbaslik4.Text = "F4";
            iyimserlik7_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik4.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik4.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl36.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik3 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            iyimserlik7_3_maliyet_txt_altbaslik3.Text = "F3";
            iyimserlik7_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik3.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik3.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl31.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik2 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            iyimserlik7_3_maliyet_txt_altbaslik2.Text = "F2";
            iyimserlik7_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik2.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik2.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl15.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_altbaslik1 = new TextBox();
            iyimserlik7_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            iyimserlik7_3_maliyet_txt_altbaslik1.Text = "F1";
            iyimserlik7_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_altbaslik1.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_altbaslik1.Multiline = true;
            iyimserlik7_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl14.Controls.Add(iyimserlik7_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_baslik2 = new TextBox();
            iyimserlik7_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_baslik2.Location = txt_baslik2;
            iyimserlik7_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            iyimserlik7_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_baslik2.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_baslik2.Multiline = true;
            iyimserlik7_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl13.Controls.Add(iyimserlik7_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            iyimserlik7_3_maliyet_txt_baslik1 = new TextBox();
            iyimserlik7_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            iyimserlik7_3_maliyet_txt_baslik1.Location = txt_baslik1;
            iyimserlik7_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            iyimserlik7_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            iyimserlik7_3_maliyet_txt_baslik1.MaxLength = 30;
            iyimserlik7_3_maliyet_txt_baslik1.Multiline = true;
            iyimserlik7_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            iyimserlik7_3_maliyet_pl12.Controls.Add(iyimserlik7_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel55 oluşturuldu  f7-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            iyimserlik7_3_maliyet_pl55.Location = pl55k;
            iyimserlik7_3_maliyet_pl55.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl55.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            iyimserlik7_3_maliyet_pl50.Location = pl50k;
            iyimserlik7_3_maliyet_pl50.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            iyimserlik7_3_maliyet_pl45.Location = pl45k;
            iyimserlik7_3_maliyet_pl45.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            iyimserlik7_3_maliyet_pl40.Location = pl40k;
            iyimserlik7_3_maliyet_pl40.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            iyimserlik7_3_maliyet_pl35.Location = pl35k;
            iyimserlik7_3_maliyet_pl35.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            iyimserlik7_3_maliyet_pl30.Location = pl30k;
            iyimserlik7_3_maliyet_pl30.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            iyimserlik7_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            iyimserlik7_3_maliyet_pl29.Location = pl29k;
            iyimserlik7_3_maliyet_pl29.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            iyimserlik7_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            iyimserlik7_3_maliyet_pl28.Location = pl28k;
            iyimserlik7_3_maliyet_pl28.Size = new Size(91, 72);
            iyimserlik7_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            iyimserlik7_3_maliyet_pl54.Location = pl54k;
            iyimserlik7_3_maliyet_pl54.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl54.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            iyimserlik7_3_maliyet_pl53.Location = pl53k;
            iyimserlik7_3_maliyet_pl53.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl53.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            iyimserlik7_3_maliyet_pl52.Location = pl52k;
            iyimserlik7_3_maliyet_pl52.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl52.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            iyimserlik7_3_maliyet_pl49.Location = pl49k;
            iyimserlik7_3_maliyet_pl49.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            iyimserlik7_3_maliyet_pl48.Location = pl48k;
            iyimserlik7_3_maliyet_pl48.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            iyimserlik7_3_maliyet_pl47.Location = pl47k;
            iyimserlik7_3_maliyet_pl47.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            iyimserlik7_3_maliyet_pl44.Location = pl44k;
            iyimserlik7_3_maliyet_pl44.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            iyimserlik7_3_maliyet_pl43.Location = pl43k;
            iyimserlik7_3_maliyet_pl43.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            iyimserlik7_3_maliyet_pl42.Location = pl42k;
            iyimserlik7_3_maliyet_pl42.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            iyimserlik7_3_maliyet_pl39.Location = pl39k;
            iyimserlik7_3_maliyet_pl39.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            iyimserlik7_3_maliyet_pl38.Location = pl38k;
            iyimserlik7_3_maliyet_pl38.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            iyimserlik7_3_maliyet_pl37.Location = pl37k;
            iyimserlik7_3_maliyet_pl37.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            iyimserlik7_3_maliyet_pl34.Location = pl34k;
            iyimserlik7_3_maliyet_pl34.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            iyimserlik7_3_maliyet_pl33.Location = pl33k;
            iyimserlik7_3_maliyet_pl33.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            iyimserlik7_3_maliyet_pl32.Location = pl32k;
            iyimserlik7_3_maliyet_pl32.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            iyimserlik7_3_maliyet_pl27.Location = pl27k;
            iyimserlik7_3_maliyet_pl27.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            iyimserlik7_3_maliyet_pl26.Location = pl26k;
            iyimserlik7_3_maliyet_pl26.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            iyimserlik7_3_maliyet_pl23.Location = pl23k;
            iyimserlik7_3_maliyet_pl23.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            iyimserlik7_3_maliyet_pl22.Location = pl22k;
            iyimserlik7_3_maliyet_pl22.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            iyimserlik7_3_maliyet_pl21.Location = pl21k;
            iyimserlik7_3_maliyet_pl21.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            iyimserlik7_3_maliyet_pl20.Location = pl20k;
            iyimserlik7_3_maliyet_pl20.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            iyimserlik7_3_maliyet_pl25.Location = pl25k;
            iyimserlik7_3_maliyet_pl25.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            iyimserlik7_3_maliyet_pl19.Location = pl19k;
            iyimserlik7_3_maliyet_pl19.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            iyimserlik7_3_maliyet_pl18.Location = pl18k;
            iyimserlik7_3_maliyet_pl18.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            iyimserlik7_3_maliyet_pl24.Location = pl24k;
            iyimserlik7_3_maliyet_pl24.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            iyimserlik7_3_maliyet_pl17.Location = pl17k;
            iyimserlik7_3_maliyet_pl17.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            iyimserlik7_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            iyimserlik7_3_maliyet_pl16.Location = pl16k;
            iyimserlik7_3_maliyet_pl16.Size = new Size(91, 33);
            iyimserlik7_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            iyimserlik7_3_maliyet_pl51.Location = pl51k;
            iyimserlik7_3_maliyet_pl51.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl51.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            iyimserlik7_3_maliyet_pl46.Location = pl46k;
            iyimserlik7_3_maliyet_pl46.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            iyimserlik7_3_maliyet_pl41.Location = pl41k;
            iyimserlik7_3_maliyet_pl41.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            iyimserlik7_3_maliyet_pl36.Location = pl36k;
            iyimserlik7_3_maliyet_pl36.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            iyimserlik7_3_maliyet_pl31.Location = pl31k;
            iyimserlik7_3_maliyet_pl31.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            iyimserlik7_3_maliyet_pl15.Location = pl15k;
            iyimserlik7_3_maliyet_pl15.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            iyimserlik7_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            iyimserlik7_3_maliyet_pl14.Location = pl14k;
            iyimserlik7_3_maliyet_pl14.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            iyimserlik7_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            iyimserlik7_3_maliyet_pl13.Location = pl13k;
            iyimserlik7_3_maliyet_pl13.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            iyimserlik7_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            iyimserlik7_3_maliyet_pl12.Location = pl12k;
            iyimserlik7_3_maliyet_pl12.Size = new Size(168, 33);
            iyimserlik7_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl5.Controls.Add(iyimserlik7_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            iyimserlik7_3_maliyet_pl11.Name = "pl11";
            iyimserlik7_3_maliyet_pl11.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_pl11.Dock = DockStyle.Left;
            iyimserlik7_3_maliyet_pl11.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            iyimserlik7_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl11.Click += new EventHandler(iyimserlik7_3_maliyet_pl11_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            iyimserlik7_3_maliyet_pl10.Name = "pl10";
            iyimserlik7_3_maliyet_pl10.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_pl10.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_pl10.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            iyimserlik7_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl10.Click += new EventHandler(iyimserlik7_3_maliyet_pl10_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            iyimserlik7_3_maliyet_pl9.Name = "pl9";
            iyimserlik7_3_maliyet_pl9.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_pl9.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_pl9.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            iyimserlik7_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl9.Click += new EventHandler(iyimserlik7_3_maliyet_pl9_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            iyimserlik7_3_maliyet_pl8.Name = "pl8";
            iyimserlik7_3_maliyet_pl8.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_pl8.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_pl8.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            iyimserlik7_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl8.Click += new EventHandler(iyimserlik7_3_maliyet_pl8_Click);
            iyimserlik7_3_maliyet_pl7.Controls.Add(iyimserlik7_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            iyimserlik7_3_maliyet_pl6.Name = "pl6";
            iyimserlik7_3_maliyet_pl6.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_pl6.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_pl6.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            iyimserlik7_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl6.Click += new EventHandler(iyimserlik7_3_maliyet_pl6_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            iyimserlik7_3_maliyet_btn3.Name = "btn3";
            iyimserlik7_3_maliyet_btn3.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_btn3.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            iyimserlik7_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_btn3.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            iyimserlik7_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_btn3.Click += new EventHandler(iyimserlik7_3_maliyet_btn3_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            iyimserlik7_3_maliyet_btn2.Name = "btn2";
            iyimserlik7_3_maliyet_btn2.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_btn2.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            iyimserlik7_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik7_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik7_3_maliyet_btn2.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            iyimserlik7_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_btn2.Click += new EventHandler(iyimserlik7_3_maliyet_btn2_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            iyimserlik7_3_maliyet_btn1.Name = "btn1";
            iyimserlik7_3_maliyet_btn1.Size = new Size(65, 50);
            iyimserlik7_3_maliyet_btn1.Dock = DockStyle.Right;
            iyimserlik7_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            iyimserlik7_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            iyimserlik7_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            iyimserlik7_3_maliyet_btn1.BackColor = Color.Transparent;
            iyimserlik7_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            iyimserlik7_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_btn1.Click += new EventHandler(iyimserlik7_3_maliyet_btn1_Click);
            iyimserlik7_3_maliyet_pl2.Controls.Add(iyimserlik7_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            iyimserlik7_3_maliyet_dr1.Name = "dr1";
            iyimserlik7_3_maliyet_dr1.Size = new Size(851, 498);
            iyimserlik7_3_maliyet_dr1.Dock = DockStyle.Fill;
            iyimserlik7_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_dr1.AllowUserToAddRows = false;
            iyimserlik7_3_maliyet_dr1.AllowUserToDeleteRows = false;
            iyimserlik7_3_maliyet_dr1.AllowUserToResizeColumns = false;
            iyimserlik7_3_maliyet_dr1.AllowUserToResizeRows = false;
            iyimserlik7_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iyimserlik7_3_maliyet_dr1.RowHeadersVisible = false;
            iyimserlik7_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            iyimserlik7_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(iyimserlik7_3_maliyet_dr1_CellEnter);
            iyimserlik7_3_maliyet_tb1_2.Controls.Add(iyimserlik7_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            iyimserlik7_3_maliyet_pl7.Name = "pl7";
            iyimserlik7_3_maliyet_pl7.Size = new Size(865, 50);
            iyimserlik7_3_maliyet_pl7.Dock = DockStyle.Top;
            iyimserlik7_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_tb1_2.Controls.Add(iyimserlik7_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            iyimserlik7_3_maliyet_pl5.Name = "pl5";
            iyimserlik7_3_maliyet_pl5.Size = new Size(851, 498);
            iyimserlik7_3_maliyet_pl5.Dock = DockStyle.Fill;
            iyimserlik7_3_maliyet_pl5.AutoScroll = true;
            iyimserlik7_3_maliyet_pl5.AutoSize = true;
            iyimserlik7_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            iyimserlik7_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_tb1_1.Controls.Add(iyimserlik7_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            iyimserlik7_3_maliyet_rt1.Name = "rt1";
            iyimserlik7_3_maliyet_rt1.Size = new Size(851, 498);
            iyimserlik7_3_maliyet_rt1.Dock = DockStyle.Fill;
            iyimserlik7_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_rt1.Enabled = false;
            iyimserlik7_3_maliyet_rt1.Text = "•İyimserlik düzeyi en küçük olan seçenek seçilir.\n•Maliyete Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            iyimserlik7_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            iyimserlik7_3_maliyet_tb1_3.Controls.Add(iyimserlik7_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            iyimserlik7_3_maliyet_tb1_1.Name = "tb1_1";
            iyimserlik7_3_maliyet_tb1_1.Text = "Tablo";
            iyimserlik7_3_maliyet_tb1_1.Size = new Size(651, 50);
            iyimserlik7_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_tb1.Controls.Add(iyimserlik7_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            iyimserlik7_3_maliyet_tb1_2.Name = "tb1_2";
            iyimserlik7_3_maliyet_tb1_2.Text = "Veri Tabanı";
            iyimserlik7_3_maliyet_tb1_2.Size = new Size(651, 50);
            iyimserlik7_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_tb1.Controls.Add(iyimserlik7_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            iyimserlik7_3_maliyet_tb1_3.Name = "tb1_3";
            iyimserlik7_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            iyimserlik7_3_maliyet_tb1_3.Size = new Size(651, 50);
            iyimserlik7_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_tb1.Controls.Add(iyimserlik7_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            iyimserlik7_3_maliyet_tb1.Name = "tb1";
            iyimserlik7_3_maliyet_tb1.Size = new Size(651, 50);
            iyimserlik7_3_maliyet_tb1.Dock = DockStyle.Fill;
            iyimserlik7_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            iyimserlik7_3_maliyet_pl3.Controls.Add(iyimserlik7_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            iyimserlik7_3_maliyet_pl4.Name = "pl4";
            iyimserlik7_3_maliyet_pl4.Size = new Size(865, 50);
            iyimserlik7_3_maliyet_pl4.Dock = DockStyle.Bottom;
            iyimserlik7_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl4.MouseUp += new MouseEventHandler(iyimserlik7_3_maliyet_pl4_MouseUp);
            iyimserlik7_3_maliyet_pl4.MouseMove += new MouseEventHandler(iyimserlik7_3_maliyet_pl4_MouseMove);
            iyimserlik7_3_maliyet_pl4.MouseDown += new MouseEventHandler(iyimserlik7_3_maliyet_pl4_MouseDown);
            this.Controls.Add(iyimserlik7_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            iyimserlik7_3_maliyet_pl3.Name = "pl3";
            iyimserlik7_3_maliyet_pl3.Size = new Size(865, 530);
            iyimserlik7_3_maliyet_pl3.Dock = DockStyle.Top;
            iyimserlik7_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik7_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            iyimserlik7_3_maliyet_pl2.Name = "pl2";
            iyimserlik7_3_maliyet_pl2.Size = new Size(865, 50);
            iyimserlik7_3_maliyet_pl2.Dock = DockStyle.Top;
            iyimserlik7_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(iyimserlik7_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            iyimserlik7_3_maliyet_pl1.Name = "pl1";
            iyimserlik7_3_maliyet_pl1.Size = new Size(865, 50);
            iyimserlik7_3_maliyet_pl1.Dock = DockStyle.Top;
            iyimserlik7_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            iyimserlik7_3_maliyet_pl1.BackgroundImage = Properties.Resources.iyimserlikmaliyet;
            iyimserlik7_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            iyimserlik7_3_maliyet_pl1.MouseUp += new MouseEventHandler(iyimserlik7_3_maliyet_pl1_MouseUp);
            iyimserlik7_3_maliyet_pl1.MouseMove += new MouseEventHandler(iyimserlik7_3_maliyet_pl1_MouseMove);
            iyimserlik7_3_maliyet_pl1.MouseDown += new MouseEventHandler(iyimserlik7_3_maliyet_pl1_MouseDown);
            this.Controls.Add(iyimserlik7_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //iyimserlik2_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik2_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik2_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik2_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 16; i++)
            {
                iyimserlik2_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik3_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik3_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik3_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik3_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 21; i++)
            {
                iyimserlik3_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik4_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik4_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik4_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik4_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 26; i++)
            {
                iyimserlik4_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik5_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik5_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik5_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik5_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 31; i++)
            {
                iyimserlik5_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik6_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik6_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik6_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik6_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 36; i++)
            {
                iyimserlik6_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik7_3_maliyet veritabanına listelemek için kullanılır
        public void iyimserlik7_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From iyimserlik7_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            iyimserlik7_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 41; i++)
            {
                iyimserlik7_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //iyimserlik2_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik2_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik2_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik2_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik2_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik2_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik2_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik2_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik2_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik2_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik2_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik2_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik2_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik2_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik2_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik2_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik2_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik2_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik2_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik2_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik2_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik2_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik2_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik2_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik2_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik2_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik2_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik2_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik2_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik2_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik2_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik2_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,sonuc_1,sonuc_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@sonuc_1,@sonuc_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());               
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik2_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");           
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik2_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik2_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik2_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();
             
                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik2_3_maliyet where Id=" + iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik2_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik2_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik2_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik2_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik2_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik2_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik2_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik2_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik2_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                 
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik2_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik2_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    iyimserlik2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik2_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");              
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik2_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik2_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik2_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik2_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik2_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik2_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //iyimserlik3_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik3_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik3_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik3_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik3_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik3_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik3_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik3_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik3_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik3_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik3_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik3_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik3_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik3_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik3_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik3_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik3_3_maliyet_pl32.Controls["txtveri7"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik3_3_maliyet_pl33.Controls["txtveri8"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                iyimserlik3_3_maliyet_pl34.Controls["txtveri9"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                iyimserlik3_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik3_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik3_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik3_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik3_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik3_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik3_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik3_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik3_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik3_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik3_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik3_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik3_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik3_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik3_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik3_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik3_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik3_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------           
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik3_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,sonuc_1,sonuc_2,sonuc_3,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@sonuc_1,@sonuc_2,@sonuc_3,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                   
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik3_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");             
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik3_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik3_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik3_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();
              
                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik3_3_maliyet where Id=" + iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik3_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik3_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik3_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik3_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik3_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik3_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik3_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik3_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik3_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik3_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik3_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------           
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik3_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik3_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik3_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik3_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik3_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");              
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik3_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik3_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik3_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik3_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik3_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik3_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //iyimserlik4_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik4_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik4_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik4_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik4_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik4_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik4_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik4_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik4_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik4_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik4_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik4_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik4_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik4_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik4_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik4_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik4_3_maliyet_pl32.Controls["txtveri7"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                iyimserlik4_3_maliyet_pl33.Controls["txtveri8"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                iyimserlik4_3_maliyet_pl34.Controls["txtveri9"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                iyimserlik4_3_maliyet_pl37.Controls["txtveri10"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                iyimserlik4_3_maliyet_pl38.Controls["txtveri11"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                iyimserlik4_3_maliyet_pl39.Controls["txtveri12"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                iyimserlik4_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik4_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik4_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik4_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik4_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik4_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik4_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik4_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik4_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik4_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik4_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik4_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik4_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik4_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik4_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik4_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik4_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik4_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik4_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik4_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik4_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik4_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,sonuc_1,sonuc_2,sonuc_3,sonuc_4,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                  
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik4_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");             
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik4_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik4_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik4_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik4_3_maliyet where Id=" + iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik4_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik4_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik4_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik4_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik4_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik4_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik4_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik4_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik4_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik4_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik4_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik4_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik4_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik4_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik4_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik4_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik4_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik4_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik4_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik4_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");            
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik4_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik4_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik4_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik4_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik4_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik4_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //iyimserlik5_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik5_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik5_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik5_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik5_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik5_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik5_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik5_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik5_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik5_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik5_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik5_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik5_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik5_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik5_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik5_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                iyimserlik5_3_maliyet_pl32.Controls["txtveri7"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                iyimserlik5_3_maliyet_pl33.Controls["txtveri8"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                iyimserlik5_3_maliyet_pl34.Controls["txtveri9"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                iyimserlik5_3_maliyet_pl37.Controls["txtveri10"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                iyimserlik5_3_maliyet_pl38.Controls["txtveri11"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                iyimserlik5_3_maliyet_pl39.Controls["txtveri12"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                iyimserlik5_3_maliyet_pl42.Controls["txtveri13"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                iyimserlik5_3_maliyet_pl43.Controls["txtveri14"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                iyimserlik5_3_maliyet_pl44.Controls["txtveri15"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                iyimserlik5_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik5_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik5_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik5_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik5_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik5_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik5_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik5_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik5_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik5_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik5_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik5_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik5_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik5_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik5_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik5_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik5_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik5_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik5_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik5_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik5_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik5_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik5_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik5_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik5_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                   
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik5_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");             
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik5_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik5_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik5_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();
               
                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik5_3_maliyet where Id=" + iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik5_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik5_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik5_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik5_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik5_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik5_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik5_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik5_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik5_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik5_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik5_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik5_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik5_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik5_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik5_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik5_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik5_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik5_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                 
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik5_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik5_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik5_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik5_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik5_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik5_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");             
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik5_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik5_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik5_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik5_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik5_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik5_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //iyimserlik6_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik6_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik6_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik6_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik6_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik6_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik6_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik6_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik6_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik6_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik6_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik6_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik6_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik6_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik6_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                iyimserlik6_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                iyimserlik6_3_maliyet_pl32.Controls["txtveri7"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                iyimserlik6_3_maliyet_pl33.Controls["txtveri8"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                iyimserlik6_3_maliyet_pl34.Controls["txtveri9"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                iyimserlik6_3_maliyet_pl37.Controls["txtveri10"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                iyimserlik6_3_maliyet_pl38.Controls["txtveri11"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                iyimserlik6_3_maliyet_pl39.Controls["txtveri12"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                iyimserlik6_3_maliyet_pl42.Controls["txtveri13"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                iyimserlik6_3_maliyet_pl43.Controls["txtveri14"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                iyimserlik6_3_maliyet_pl44.Controls["txtveri15"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                iyimserlik6_3_maliyet_pl47.Controls["txtveri16"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                iyimserlik6_3_maliyet_pl48.Controls["txtveri17"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                iyimserlik6_3_maliyet_pl49.Controls["txtveri18"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                iyimserlik6_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik6_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik6_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik6_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik6_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik6_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik6_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik6_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik6_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik6_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik6_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik6_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik6_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik6_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik6_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik6_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik6_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik6_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik6_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik6_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik6_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik6_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik6_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik6_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(iyimserlik6_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(iyimserlik6_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(iyimserlik6_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 < veri17 && veri16 < veri18)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 < veri16 && veri17 < veri18)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 < veri17 && veri18 < veri16)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik6_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", iyimserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", iyimserlik6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", iyimserlik6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", iyimserlik6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik6_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");            
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik6_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik6_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik6_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();
               
                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik6_3_maliyet where Id=" + iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik6_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik6_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik6_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik6_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik6_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik6_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik6_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik6_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik6_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik6_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik6_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik6_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik6_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik6_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik6_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik6_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik6_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(iyimserlik6_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(iyimserlik6_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(iyimserlik6_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 < veri17 && veri16 < veri18)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 < veri16 && veri17 < veri18)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 < veri17 && veri18 < veri16)
                {
                    iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik6_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", iyimserlik6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                   
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", iyimserlik6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", iyimserlik6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", iyimserlik6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik6_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik6_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik6_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik6_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik6_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", iyimserlik6_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik6_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");             
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik6_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik6_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik6_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik6_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik6_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik6_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //iyimserlik7_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik7_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik7_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik7_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik7_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void iyimserlik7_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void iyimserlik7_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void iyimserlik7_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //iyimserlik7_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void iyimserlik7_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iyimserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                iyimserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                iyimserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                iyimserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                iyimserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                iyimserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                iyimserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                iyimserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                iyimserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                iyimserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                iyimserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                iyimserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                iyimserlik7_3_maliyet_pl20.Controls["txtveri1"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                iyimserlik7_3_maliyet_pl21.Controls["txtveri2"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                iyimserlik7_3_maliyet_pl26.Controls["txtveri3"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                iyimserlik7_3_maliyet_pl22.Controls["txtveri4"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                iyimserlik7_3_maliyet_pl23.Controls["txtveri5"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                iyimserlik7_3_maliyet_pl27.Controls["txtveri6"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                iyimserlik7_3_maliyet_pl32.Controls["txtveri7"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                iyimserlik7_3_maliyet_pl33.Controls["txtveri8"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                iyimserlik7_3_maliyet_pl34.Controls["txtveri9"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                iyimserlik7_3_maliyet_pl37.Controls["txtveri10"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                iyimserlik7_3_maliyet_pl38.Controls["txtveri11"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                iyimserlik7_3_maliyet_pl39.Controls["txtveri12"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                iyimserlik7_3_maliyet_pl42.Controls["txtveri13"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                iyimserlik7_3_maliyet_pl43.Controls["txtveri14"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                iyimserlik7_3_maliyet_pl44.Controls["txtveri15"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                iyimserlik7_3_maliyet_pl47.Controls["txtveri16"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                iyimserlik7_3_maliyet_pl48.Controls["txtveri17"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                iyimserlik7_3_maliyet_pl49.Controls["txtveri18"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                iyimserlik7_3_maliyet_pl52.Controls["txtveri19"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                iyimserlik7_3_maliyet_pl53.Controls["txtveri20"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                iyimserlik7_3_maliyet_pl54.Controls["txtveri21"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
                iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[37].Value.ToString();
                iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[38].Value.ToString();
                iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[39].Value.ToString();
                iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[40].Value.ToString();
                iyimserlik7_3_maliyet_pl4.Controls["sonuc"].Text = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[41].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //iyimserlik7_3_maliyet formu kapatmak için oluşturulmuş button1
        private void iyimserlik7_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //iyimserlik7_3_maliyet formu altaalmak için oluşturulmuş button2
        private void iyimserlik7_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //iyimserlik7_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void iyimserlik7_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //iyimserlik7_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void iyimserlik7_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik7_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik7_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik7_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik7_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik7_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik7_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik7_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik7_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik7_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik7_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik7_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik7_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik7_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik7_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik7_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(iyimserlik7_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(iyimserlik7_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(iyimserlik7_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 < veri17 && veri16 < veri18)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 < veri16 && veri17 < veri18)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 < veri17 && veri18 < veri16)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------     
                //f7sonuc kısmı
                double veri19 = Convert.ToDouble(iyimserlik7_3_maliyet_pl52.Controls["txtveri19"].Text);
                double veri20 = Convert.ToDouble(iyimserlik7_3_maliyet_pl53.Controls["txtveri20"].Text);
                double veri21 = Convert.ToDouble(iyimserlik7_3_maliyet_pl54.Controls["txtveri21"].Text);
                if (veri19 < veri20 && veri19 < veri21)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri19.ToString();
                }
                else if (veri20 < veri19 && veri20 < veri21)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri20.ToString();
                }
                else if (veri21 < veri19 && veri21 < veri20)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri21.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text);
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
                    string sorgu = "Insert into iyimserlik7_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,sonuc_7,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@sonuc_7,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", iyimserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", iyimserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                 
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", iyimserlik7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", iyimserlik7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", iyimserlik7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", iyimserlik7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", iyimserlik7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", iyimserlik7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik7_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");     
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik7_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void iyimserlik7_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //iyimserlik7_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "İyimserlik";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();
              
                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Min";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select sonuc_7 From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From iyimserlik7_3_maliyet where Id=" + iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //iyimserlik7_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void iyimserlik7_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                //f1sonuc kısmı
                double veri1 = Convert.ToDouble(iyimserlik7_3_maliyet_pl20.Controls["txtveri1"].Text);
                double veri2 = Convert.ToDouble(iyimserlik7_3_maliyet_pl21.Controls["txtveri2"].Text);
                double veri3 = Convert.ToDouble(iyimserlik7_3_maliyet_pl26.Controls["txtveri3"].Text);
                if (veri1 < veri2 && veri1 < veri3)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri1.ToString();
                }
                else if (veri2 < veri1 && veri2 < veri3)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri2.ToString();
                }
                else if (veri3 < veri1 && veri3 < veri2)
                {
                    iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text = veri3.ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                double veri4 = Convert.ToDouble(iyimserlik7_3_maliyet_pl22.Controls["txtveri4"].Text);
                double veri5 = Convert.ToDouble(iyimserlik7_3_maliyet_pl23.Controls["txtveri5"].Text);
                double veri6 = Convert.ToDouble(iyimserlik7_3_maliyet_pl27.Controls["txtveri6"].Text);
                if (veri4 < veri5 && veri4 < veri6)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri4.ToString();
                }
                else if (veri5 < veri4 && veri5 < veri6)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri5.ToString();
                }
                else if (veri6 < veri4 && veri6 < veri5)
                {
                    iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text = veri6.ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                double veri7 = Convert.ToDouble(iyimserlik7_3_maliyet_pl32.Controls["txtveri7"].Text);
                double veri8 = Convert.ToDouble(iyimserlik7_3_maliyet_pl33.Controls["txtveri8"].Text);
                double veri9 = Convert.ToDouble(iyimserlik7_3_maliyet_pl34.Controls["txtveri9"].Text);
                if (veri7 < veri8 && veri7 < veri9)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri7.ToString();
                }
                else if (veri8 < veri7 && veri8 < veri9)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri8.ToString();
                }
                else if (veri9 < veri7 && veri9 < veri8)
                {
                    iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text = veri9.ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                double veri10 = Convert.ToDouble(iyimserlik7_3_maliyet_pl37.Controls["txtveri10"].Text);
                double veri11 = Convert.ToDouble(iyimserlik7_3_maliyet_pl38.Controls["txtveri11"].Text);
                double veri12 = Convert.ToDouble(iyimserlik7_3_maliyet_pl39.Controls["txtveri12"].Text);
                if (veri10 < veri11 && veri10 < veri12)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri10.ToString();
                }
                else if (veri11 < veri10 && veri11 < veri12)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri11.ToString();
                }
                else if (veri12 < veri10 && veri12 < veri11)
                {
                    iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text = veri12.ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                double veri13 = Convert.ToDouble(iyimserlik7_3_maliyet_pl42.Controls["txtveri13"].Text);
                double veri14 = Convert.ToDouble(iyimserlik7_3_maliyet_pl43.Controls["txtveri14"].Text);
                double veri15 = Convert.ToDouble(iyimserlik7_3_maliyet_pl44.Controls["txtveri15"].Text);
                if (veri13 < veri14 && veri13 < veri15)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri13.ToString();
                }
                else if (veri14 < veri13 && veri14 < veri15)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri14.ToString();
                }
                else if (veri15 < veri14 && veri15 < veri13)
                {
                    iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text = veri15.ToString();
                }
                //--------------------------------------------          
                //f6sonuc kısmı
                double veri16 = Convert.ToDouble(iyimserlik7_3_maliyet_pl47.Controls["txtveri16"].Text);
                double veri17 = Convert.ToDouble(iyimserlik7_3_maliyet_pl48.Controls["txtveri17"].Text);
                double veri18 = Convert.ToDouble(iyimserlik7_3_maliyet_pl49.Controls["txtveri18"].Text);
                if (veri16 < veri17 && veri16 < veri18)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri16.ToString();
                }
                else if (veri17 < veri16 && veri17 < veri18)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri17.ToString();
                }
                else if (veri18 < veri17 && veri18 < veri16)
                {
                    iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text = veri18.ToString();
                }
                //--------------------------------------------     
                //f7sonuc kısmı
                double veri19 = Convert.ToDouble(iyimserlik7_3_maliyet_pl52.Controls["txtveri19"].Text);
                double veri20 = Convert.ToDouble(iyimserlik7_3_maliyet_pl53.Controls["txtveri20"].Text);
                double veri21 = Convert.ToDouble(iyimserlik7_3_maliyet_pl54.Controls["txtveri21"].Text);
                if (veri19 < veri20 && veri19 < veri21)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri19.ToString();
                }
                else if (veri20 < veri19 && veri20 < veri21)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri20.ToString();
                }
                else if (veri21 < veri19 && veri21 < veri20)
                {
                    iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text = veri21.ToString();
                }
                //--------------------------------------------          
                //hesaplama
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text);
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
                    komut = new OleDbCommand("UPDATE iyimserlik7_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,sonuc_7=@sonuc_7,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", iyimserlik7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", iyimserlik7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", iyimserlik7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", iyimserlik7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", iyimserlik7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", iyimserlik7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", iyimserlik7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", iyimserlik7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", iyimserlik7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", iyimserlik7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", iyimserlik7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", iyimserlik7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());                 
                    komut.Parameters.AddWithValue("@veri_1", iyimserlik7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", iyimserlik7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", iyimserlik7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", iyimserlik7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", iyimserlik7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", iyimserlik7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", iyimserlik7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", iyimserlik7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", iyimserlik7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", iyimserlik7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", iyimserlik7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", iyimserlik7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", iyimserlik7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", iyimserlik7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", iyimserlik7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", iyimserlik7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", iyimserlik7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", iyimserlik7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", iyimserlik7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", iyimserlik7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", iyimserlik7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", iyimserlik7_3_maliyet_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", iyimserlik7_3_maliyet_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", iyimserlik7_3_maliyet_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", iyimserlik7_3_maliyet_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", iyimserlik7_3_maliyet_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", iyimserlik7_3_maliyet_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", iyimserlik7_3_maliyet_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    iyimserlik7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    iyimserlik7_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");              
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //iyimserlik7_3_maliyet silme yapmak için oluşturulmuş panel10
        private void iyimserlik7_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = iyimserlik7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from iyimserlik7_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            iyimserlik7_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //iyimserlik7_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void iyimserlik7_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        private void BelirsizlikAltındaiyimserlikMaliyet_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                iyimserlik2_3_maliyet();
                iyimserlik2_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                iyimserlik3_3_maliyet();
                iyimserlik3_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                iyimserlik4_3_maliyet();
                iyimserlik4_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                iyimserlik5_3_maliyet();
                iyimserlik5_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                iyimserlik6_3_maliyet();
                iyimserlik6_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                iyimserlik7_3_maliyet();
                iyimserlik7_3_maliyet_listele();
            }
        }
    }
}
