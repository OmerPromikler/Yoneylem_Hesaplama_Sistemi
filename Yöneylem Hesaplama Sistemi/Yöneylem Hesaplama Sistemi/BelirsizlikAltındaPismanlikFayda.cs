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
    public partial class BelirsizlikAltındaPismanlikFayda : Form
    {
        public BelirsizlikAltındaPismanlikFayda()
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

        //pismanlik2_3_fayda form nesneleri
        Panel pismanlik2_3_fayda_pl1 = new Panel();
        Panel pismanlik2_3_fayda_pl2 = new Panel();
        Panel pismanlik2_3_fayda_pl3 = new Panel();
        Panel pismanlik2_3_fayda_pl4 = new Panel();
        Panel pismanlik2_3_fayda_pl5 = new Panel();
        Panel pismanlik2_3_fayda_pl6 = new Panel();
        Panel pismanlik2_3_fayda_pl7 = new Panel();
        Panel pismanlik2_3_fayda_pl8 = new Panel();
        Panel pismanlik2_3_fayda_pl9 = new Panel();
        Panel pismanlik2_3_fayda_pl10 = new Panel();
        Panel pismanlik2_3_fayda_pl11 = new Panel();
        Panel pismanlik2_3_fayda_pl12 = new Panel();
        Panel pismanlik2_3_fayda_pl13 = new Panel();
        Panel pismanlik2_3_fayda_pl14 = new Panel();
        Panel pismanlik2_3_fayda_pl15 = new Panel();
        Panel pismanlik2_3_fayda_pl16 = new Panel();
        Panel pismanlik2_3_fayda_pl17 = new Panel();
        Panel pismanlik2_3_fayda_pl18 = new Panel();
        Panel pismanlik2_3_fayda_pl19 = new Panel();
        Panel pismanlik2_3_fayda_pl20 = new Panel();
        Panel pismanlik2_3_fayda_pl21 = new Panel();
        Panel pismanlik2_3_fayda_pl22 = new Panel();
        Panel pismanlik2_3_fayda_pl23 = new Panel();
        Panel pismanlik2_3_fayda_pl24 = new Panel();
        Panel pismanlik2_3_fayda_pl25 = new Panel();
        Panel pismanlik2_3_fayda_pl26 = new Panel();
        Panel pismanlik2_3_fayda_pl27 = new Panel();
        Panel pismanlik2_3_fayda_pl28 = new Panel();
        Panel pismanlik2_3_fayda_pl29 = new Panel();
        Panel pismanlik2_3_fayda_pl30 = new Panel();
        Panel pismanlik2_3_fayda_pl31 = new Panel();
        Panel pismanlik2_3_fayda_pl32 = new Panel();
        Panel pismanlik2_3_fayda_pl33 = new Panel();
        Panel pismanlik2_3_fayda_pl34 = new Panel();
        TabControl pismanlik2_3_fayda_tb1 = new TabControl();
        TabPage pismanlik2_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik2_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik2_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik2_3_fayda_txt_baslik1;
        TextBox pismanlik2_3_fayda_txt_baslik2;
        TextBox pismanlik2_3_fayda_txt_altbaslik1;
        TextBox pismanlik2_3_fayda_txt_altbaslik2;
        TextBox pismanlik2_3_fayda_txt_üstbaslik1;
        TextBox pismanlik2_3_fayda_txt_üstbaslik2;
        TextBox pismanlik2_3_fayda_txt_üstbaslik3;
        TextBox pismanlik2_3_fayda_txt_f1sonuc;
        TextBox pismanlik2_3_fayda_txt_f2sonuc;
        TextBox pismanlik2_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik2_3_fayda_txt_ortafsonuc;
        TextBox pismanlik2_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik2_3_fayda_txt_veri1;
        NumericUpDown pismanlik2_3_fayda_txt_veri2;
        NumericUpDown pismanlik2_3_fayda_txt_veri3;
        NumericUpDown pismanlik2_3_fayda_txt_veri4;
        NumericUpDown pismanlik2_3_fayda_txt_veri5;
        NumericUpDown pismanlik2_3_fayda_txt_veri6;
        Label pismanlik2_3_fayda_sonucbaslik;
        Label pismanlik2_3_fayda_sonuc;
        Label pismanlik2_3_fayda_sonuclarortabaslik;
        Label pismanlik2_3_fayda_altsonucbaslik;
        DataGridView pismanlik2_3_fayda_dr1 = new DataGridView();
        Button pismanlik2_3_fayda_btn1 = new Button();
        Button pismanlik2_3_fayda_btn2 = new Button();
        Button pismanlik2_3_fayda_btn3 = new Button();
        RichTextBox pismanlik2_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik3_3_fayda form nesneleri
        Panel pismanlik3_3_fayda_pl1 = new Panel();
        Panel pismanlik3_3_fayda_pl2 = new Panel();
        Panel pismanlik3_3_fayda_pl3 = new Panel();
        Panel pismanlik3_3_fayda_pl4 = new Panel();
        Panel pismanlik3_3_fayda_pl5 = new Panel();
        Panel pismanlik3_3_fayda_pl6 = new Panel();
        Panel pismanlik3_3_fayda_pl7 = new Panel();
        Panel pismanlik3_3_fayda_pl8 = new Panel();
        Panel pismanlik3_3_fayda_pl9 = new Panel();
        Panel pismanlik3_3_fayda_pl10 = new Panel();
        Panel pismanlik3_3_fayda_pl11 = new Panel();
        Panel pismanlik3_3_fayda_pl12 = new Panel();
        Panel pismanlik3_3_fayda_pl13 = new Panel();
        Panel pismanlik3_3_fayda_pl14 = new Panel();
        Panel pismanlik3_3_fayda_pl15 = new Panel();
        Panel pismanlik3_3_fayda_pl16 = new Panel();
        Panel pismanlik3_3_fayda_pl17 = new Panel();
        Panel pismanlik3_3_fayda_pl18 = new Panel();
        Panel pismanlik3_3_fayda_pl19 = new Panel();
        Panel pismanlik3_3_fayda_pl20 = new Panel();
        Panel pismanlik3_3_fayda_pl21 = new Panel();
        Panel pismanlik3_3_fayda_pl22 = new Panel();
        Panel pismanlik3_3_fayda_pl23 = new Panel();
        Panel pismanlik3_3_fayda_pl24 = new Panel();
        Panel pismanlik3_3_fayda_pl25 = new Panel();
        Panel pismanlik3_3_fayda_pl26 = new Panel();
        Panel pismanlik3_3_fayda_pl27 = new Panel();
        Panel pismanlik3_3_fayda_pl28 = new Panel();
        Panel pismanlik3_3_fayda_pl29 = new Panel();
        Panel pismanlik3_3_fayda_pl30 = new Panel();
        Panel pismanlik3_3_fayda_pl31 = new Panel();
        Panel pismanlik3_3_fayda_pl32 = new Panel();
        Panel pismanlik3_3_fayda_pl33 = new Panel();
        Panel pismanlik3_3_fayda_pl34 = new Panel();
        Panel pismanlik3_3_fayda_pl35 = new Panel();
        Panel pismanlik3_3_fayda_pl36 = new Panel();
        Panel pismanlik3_3_fayda_pl37 = new Panel();
        Panel pismanlik3_3_fayda_pl38 = new Panel();
        Panel pismanlik3_3_fayda_pl39 = new Panel();
        TabControl pismanlik3_3_fayda_tb1 = new TabControl();
        TabPage pismanlik3_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik3_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik3_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik3_3_fayda_txt_baslik1;
        TextBox pismanlik3_3_fayda_txt_baslik2;
        TextBox pismanlik3_3_fayda_txt_altbaslik1;
        TextBox pismanlik3_3_fayda_txt_altbaslik2;
        TextBox pismanlik3_3_fayda_txt_altbaslik3;
        TextBox pismanlik3_3_fayda_txt_üstbaslik1;
        TextBox pismanlik3_3_fayda_txt_üstbaslik2;
        TextBox pismanlik3_3_fayda_txt_üstbaslik3;
        TextBox pismanlik3_3_fayda_txt_f1sonuc;
        TextBox pismanlik3_3_fayda_txt_f2sonuc;
        TextBox pismanlik3_3_fayda_txt_f3sonuc;
        TextBox pismanlik3_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik3_3_fayda_txt_ortafsonuc;
        TextBox pismanlik3_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik3_3_fayda_txt_veri1;
        NumericUpDown pismanlik3_3_fayda_txt_veri2;
        NumericUpDown pismanlik3_3_fayda_txt_veri3;
        NumericUpDown pismanlik3_3_fayda_txt_veri4;
        NumericUpDown pismanlik3_3_fayda_txt_veri5;
        NumericUpDown pismanlik3_3_fayda_txt_veri6;
        NumericUpDown pismanlik3_3_fayda_txt_veri7;
        NumericUpDown pismanlik3_3_fayda_txt_veri8;
        NumericUpDown pismanlik3_3_fayda_txt_veri9;
        Label pismanlik3_3_fayda_sonucbaslik;
        Label pismanlik3_3_fayda_sonuc;
        Label pismanlik3_3_fayda_sonuclarortabaslik;
        Label pismanlik3_3_fayda_altsonucbaslik;
        DataGridView pismanlik3_3_fayda_dr1 = new DataGridView();
        Button pismanlik3_3_fayda_btn1 = new Button();
        Button pismanlik3_3_fayda_btn2 = new Button();
        Button pismanlik3_3_fayda_btn3 = new Button();
        RichTextBox pismanlik3_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik4_3_fayda form nesneleri
        Panel pismanlik4_3_fayda_pl1 = new Panel();
        Panel pismanlik4_3_fayda_pl2 = new Panel();
        Panel pismanlik4_3_fayda_pl3 = new Panel();
        Panel pismanlik4_3_fayda_pl4 = new Panel();
        Panel pismanlik4_3_fayda_pl5 = new Panel();
        Panel pismanlik4_3_fayda_pl6 = new Panel();
        Panel pismanlik4_3_fayda_pl7 = new Panel();
        Panel pismanlik4_3_fayda_pl8 = new Panel();
        Panel pismanlik4_3_fayda_pl9 = new Panel();
        Panel pismanlik4_3_fayda_pl10 = new Panel();
        Panel pismanlik4_3_fayda_pl11 = new Panel();
        Panel pismanlik4_3_fayda_pl12 = new Panel();
        Panel pismanlik4_3_fayda_pl13 = new Panel();
        Panel pismanlik4_3_fayda_pl14 = new Panel();
        Panel pismanlik4_3_fayda_pl15 = new Panel();
        Panel pismanlik4_3_fayda_pl16 = new Panel();
        Panel pismanlik4_3_fayda_pl17 = new Panel();
        Panel pismanlik4_3_fayda_pl18 = new Panel();
        Panel pismanlik4_3_fayda_pl19 = new Panel();
        Panel pismanlik4_3_fayda_pl20 = new Panel();
        Panel pismanlik4_3_fayda_pl21 = new Panel();
        Panel pismanlik4_3_fayda_pl22 = new Panel();
        Panel pismanlik4_3_fayda_pl23 = new Panel();
        Panel pismanlik4_3_fayda_pl24 = new Panel();
        Panel pismanlik4_3_fayda_pl25 = new Panel();
        Panel pismanlik4_3_fayda_pl26 = new Panel();
        Panel pismanlik4_3_fayda_pl27 = new Panel();
        Panel pismanlik4_3_fayda_pl28 = new Panel();
        Panel pismanlik4_3_fayda_pl29 = new Panel();
        Panel pismanlik4_3_fayda_pl30 = new Panel();
        Panel pismanlik4_3_fayda_pl31 = new Panel();
        Panel pismanlik4_3_fayda_pl32 = new Panel();
        Panel pismanlik4_3_fayda_pl33 = new Panel();
        Panel pismanlik4_3_fayda_pl34 = new Panel();
        Panel pismanlik4_3_fayda_pl35 = new Panel();
        Panel pismanlik4_3_fayda_pl36 = new Panel();
        Panel pismanlik4_3_fayda_pl37 = new Panel();
        Panel pismanlik4_3_fayda_pl38 = new Panel();
        Panel pismanlik4_3_fayda_pl39 = new Panel();
        Panel pismanlik4_3_fayda_pl40 = new Panel();
        Panel pismanlik4_3_fayda_pl41 = new Panel();
        Panel pismanlik4_3_fayda_pl42 = new Panel();
        Panel pismanlik4_3_fayda_pl43 = new Panel();
        Panel pismanlik4_3_fayda_pl44 = new Panel();
        TabControl pismanlik4_3_fayda_tb1 = new TabControl();
        TabPage pismanlik4_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik4_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik4_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik4_3_fayda_txt_baslik1;
        TextBox pismanlik4_3_fayda_txt_baslik2;
        TextBox pismanlik4_3_fayda_txt_altbaslik1;
        TextBox pismanlik4_3_fayda_txt_altbaslik2;
        TextBox pismanlik4_3_fayda_txt_altbaslik3;
        TextBox pismanlik4_3_fayda_txt_altbaslik4;
        TextBox pismanlik4_3_fayda_txt_üstbaslik1;
        TextBox pismanlik4_3_fayda_txt_üstbaslik2;
        TextBox pismanlik4_3_fayda_txt_üstbaslik3;
        TextBox pismanlik4_3_fayda_txt_f1sonuc;
        TextBox pismanlik4_3_fayda_txt_f2sonuc;
        TextBox pismanlik4_3_fayda_txt_f3sonuc;
        TextBox pismanlik4_3_fayda_txt_f4sonuc;
        TextBox pismanlik4_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik4_3_fayda_txt_ortafsonuc;
        TextBox pismanlik4_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik4_3_fayda_txt_veri1;
        NumericUpDown pismanlik4_3_fayda_txt_veri2;
        NumericUpDown pismanlik4_3_fayda_txt_veri3;
        NumericUpDown pismanlik4_3_fayda_txt_veri4;
        NumericUpDown pismanlik4_3_fayda_txt_veri5;
        NumericUpDown pismanlik4_3_fayda_txt_veri6;
        NumericUpDown pismanlik4_3_fayda_txt_veri7;
        NumericUpDown pismanlik4_3_fayda_txt_veri8;
        NumericUpDown pismanlik4_3_fayda_txt_veri9;
        NumericUpDown pismanlik4_3_fayda_txt_veri10;
        NumericUpDown pismanlik4_3_fayda_txt_veri11;
        NumericUpDown pismanlik4_3_fayda_txt_veri12;
        Label pismanlik4_3_fayda_sonucbaslik;
        Label pismanlik4_3_fayda_sonuc;
        Label pismanlik4_3_fayda_sonuclarortabaslik;
        Label pismanlik4_3_fayda_altsonucbaslik;
        DataGridView pismanlik4_3_fayda_dr1 = new DataGridView();
        Button pismanlik4_3_fayda_btn1 = new Button();
        Button pismanlik4_3_fayda_btn2 = new Button();
        Button pismanlik4_3_fayda_btn3 = new Button();
        RichTextBox pismanlik4_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik5_3_fayda form nesneleri
        Panel pismanlik5_3_fayda_pl1 = new Panel();
        Panel pismanlik5_3_fayda_pl2 = new Panel();
        Panel pismanlik5_3_fayda_pl3 = new Panel();
        Panel pismanlik5_3_fayda_pl4 = new Panel();
        Panel pismanlik5_3_fayda_pl5 = new Panel();
        Panel pismanlik5_3_fayda_pl6 = new Panel();
        Panel pismanlik5_3_fayda_pl7 = new Panel();
        Panel pismanlik5_3_fayda_pl8 = new Panel();
        Panel pismanlik5_3_fayda_pl9 = new Panel();
        Panel pismanlik5_3_fayda_pl10 = new Panel();
        Panel pismanlik5_3_fayda_pl11 = new Panel();
        Panel pismanlik5_3_fayda_pl12 = new Panel();
        Panel pismanlik5_3_fayda_pl13 = new Panel();
        Panel pismanlik5_3_fayda_pl14 = new Panel();
        Panel pismanlik5_3_fayda_pl15 = new Panel();
        Panel pismanlik5_3_fayda_pl16 = new Panel();
        Panel pismanlik5_3_fayda_pl17 = new Panel();
        Panel pismanlik5_3_fayda_pl18 = new Panel();
        Panel pismanlik5_3_fayda_pl19 = new Panel();
        Panel pismanlik5_3_fayda_pl20 = new Panel();
        Panel pismanlik5_3_fayda_pl21 = new Panel();
        Panel pismanlik5_3_fayda_pl22 = new Panel();
        Panel pismanlik5_3_fayda_pl23 = new Panel();
        Panel pismanlik5_3_fayda_pl24 = new Panel();
        Panel pismanlik5_3_fayda_pl25 = new Panel();
        Panel pismanlik5_3_fayda_pl26 = new Panel();
        Panel pismanlik5_3_fayda_pl27 = new Panel();
        Panel pismanlik5_3_fayda_pl28 = new Panel();
        Panel pismanlik5_3_fayda_pl29 = new Panel();
        Panel pismanlik5_3_fayda_pl30 = new Panel();
        Panel pismanlik5_3_fayda_pl31 = new Panel();
        Panel pismanlik5_3_fayda_pl32 = new Panel();
        Panel pismanlik5_3_fayda_pl33 = new Panel();
        Panel pismanlik5_3_fayda_pl34 = new Panel();
        Panel pismanlik5_3_fayda_pl35 = new Panel();
        Panel pismanlik5_3_fayda_pl36 = new Panel();
        Panel pismanlik5_3_fayda_pl37 = new Panel();
        Panel pismanlik5_3_fayda_pl38 = new Panel();
        Panel pismanlik5_3_fayda_pl39 = new Panel();
        Panel pismanlik5_3_fayda_pl40 = new Panel();
        Panel pismanlik5_3_fayda_pl41 = new Panel();
        Panel pismanlik5_3_fayda_pl42 = new Panel();
        Panel pismanlik5_3_fayda_pl43 = new Panel();
        Panel pismanlik5_3_fayda_pl44 = new Panel();
        Panel pismanlik5_3_fayda_pl45 = new Panel();
        Panel pismanlik5_3_fayda_pl46 = new Panel();
        Panel pismanlik5_3_fayda_pl47 = new Panel();
        Panel pismanlik5_3_fayda_pl48 = new Panel();
        Panel pismanlik5_3_fayda_pl49 = new Panel();
        TabControl pismanlik5_3_fayda_tb1 = new TabControl();
        TabPage pismanlik5_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik5_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik5_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik5_3_fayda_txt_baslik1;
        TextBox pismanlik5_3_fayda_txt_baslik2;
        TextBox pismanlik5_3_fayda_txt_altbaslik1;
        TextBox pismanlik5_3_fayda_txt_altbaslik2;
        TextBox pismanlik5_3_fayda_txt_altbaslik3;
        TextBox pismanlik5_3_fayda_txt_altbaslik4;
        TextBox pismanlik5_3_fayda_txt_altbaslik5;
        TextBox pismanlik5_3_fayda_txt_üstbaslik1;
        TextBox pismanlik5_3_fayda_txt_üstbaslik2;
        TextBox pismanlik5_3_fayda_txt_üstbaslik3;
        TextBox pismanlik5_3_fayda_txt_f1sonuc;
        TextBox pismanlik5_3_fayda_txt_f2sonuc;
        TextBox pismanlik5_3_fayda_txt_f3sonuc;
        TextBox pismanlik5_3_fayda_txt_f4sonuc;
        TextBox pismanlik5_3_fayda_txt_f5sonuc;
        TextBox pismanlik5_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik5_3_fayda_txt_ortafsonuc;
        TextBox pismanlik5_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik5_3_fayda_txt_veri1;
        NumericUpDown pismanlik5_3_fayda_txt_veri2;
        NumericUpDown pismanlik5_3_fayda_txt_veri3;
        NumericUpDown pismanlik5_3_fayda_txt_veri4;
        NumericUpDown pismanlik5_3_fayda_txt_veri5;
        NumericUpDown pismanlik5_3_fayda_txt_veri6;
        NumericUpDown pismanlik5_3_fayda_txt_veri7;
        NumericUpDown pismanlik5_3_fayda_txt_veri8;
        NumericUpDown pismanlik5_3_fayda_txt_veri9;
        NumericUpDown pismanlik5_3_fayda_txt_veri10;
        NumericUpDown pismanlik5_3_fayda_txt_veri11;
        NumericUpDown pismanlik5_3_fayda_txt_veri12;
        NumericUpDown pismanlik5_3_fayda_txt_veri13;
        NumericUpDown pismanlik5_3_fayda_txt_veri14;
        NumericUpDown pismanlik5_3_fayda_txt_veri15;
        Label pismanlik5_3_fayda_sonucbaslik;
        Label pismanlik5_3_fayda_sonuc;
        Label pismanlik5_3_fayda_sonuclarortabaslik;
        Label pismanlik5_3_fayda_altsonucbaslik;
        DataGridView pismanlik5_3_fayda_dr1 = new DataGridView();
        Button pismanlik5_3_fayda_btn1 = new Button();
        Button pismanlik5_3_fayda_btn2 = new Button();
        Button pismanlik5_3_fayda_btn3 = new Button();
        RichTextBox pismanlik5_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik6_3_fayda form nesneleri
        Panel pismanlik6_3_fayda_pl1 = new Panel();
        Panel pismanlik6_3_fayda_pl2 = new Panel();
        Panel pismanlik6_3_fayda_pl3 = new Panel();
        Panel pismanlik6_3_fayda_pl4 = new Panel();
        Panel pismanlik6_3_fayda_pl5 = new Panel();
        Panel pismanlik6_3_fayda_pl6 = new Panel();
        Panel pismanlik6_3_fayda_pl7 = new Panel();
        Panel pismanlik6_3_fayda_pl8 = new Panel();
        Panel pismanlik6_3_fayda_pl9 = new Panel();
        Panel pismanlik6_3_fayda_pl10 = new Panel();
        Panel pismanlik6_3_fayda_pl11 = new Panel();
        Panel pismanlik6_3_fayda_pl12 = new Panel();
        Panel pismanlik6_3_fayda_pl13 = new Panel();
        Panel pismanlik6_3_fayda_pl14 = new Panel();
        Panel pismanlik6_3_fayda_pl15 = new Panel();
        Panel pismanlik6_3_fayda_pl16 = new Panel();
        Panel pismanlik6_3_fayda_pl17 = new Panel();
        Panel pismanlik6_3_fayda_pl18 = new Panel();
        Panel pismanlik6_3_fayda_pl19 = new Panel();
        Panel pismanlik6_3_fayda_pl20 = new Panel();
        Panel pismanlik6_3_fayda_pl21 = new Panel();
        Panel pismanlik6_3_fayda_pl22 = new Panel();
        Panel pismanlik6_3_fayda_pl23 = new Panel();
        Panel pismanlik6_3_fayda_pl24 = new Panel();
        Panel pismanlik6_3_fayda_pl25 = new Panel();
        Panel pismanlik6_3_fayda_pl26 = new Panel();
        Panel pismanlik6_3_fayda_pl27 = new Panel();
        Panel pismanlik6_3_fayda_pl28 = new Panel();
        Panel pismanlik6_3_fayda_pl29 = new Panel();
        Panel pismanlik6_3_fayda_pl30 = new Panel();
        Panel pismanlik6_3_fayda_pl31 = new Panel();
        Panel pismanlik6_3_fayda_pl32 = new Panel();
        Panel pismanlik6_3_fayda_pl33 = new Panel();
        Panel pismanlik6_3_fayda_pl34 = new Panel();
        Panel pismanlik6_3_fayda_pl35 = new Panel();
        Panel pismanlik6_3_fayda_pl36 = new Panel();
        Panel pismanlik6_3_fayda_pl37 = new Panel();
        Panel pismanlik6_3_fayda_pl38 = new Panel();
        Panel pismanlik6_3_fayda_pl39 = new Panel();
        Panel pismanlik6_3_fayda_pl40 = new Panel();
        Panel pismanlik6_3_fayda_pl41 = new Panel();
        Panel pismanlik6_3_fayda_pl42 = new Panel();
        Panel pismanlik6_3_fayda_pl43 = new Panel();
        Panel pismanlik6_3_fayda_pl44 = new Panel();
        Panel pismanlik6_3_fayda_pl45 = new Panel();
        Panel pismanlik6_3_fayda_pl46 = new Panel();
        Panel pismanlik6_3_fayda_pl47 = new Panel();
        Panel pismanlik6_3_fayda_pl48 = new Panel();
        Panel pismanlik6_3_fayda_pl49 = new Panel();
        Panel pismanlik6_3_fayda_pl50 = new Panel();
        Panel pismanlik6_3_fayda_pl51 = new Panel();
        Panel pismanlik6_3_fayda_pl52 = new Panel();
        Panel pismanlik6_3_fayda_pl53 = new Panel();
        Panel pismanlik6_3_fayda_pl54 = new Panel();
        TabControl pismanlik6_3_fayda_tb1 = new TabControl();
        TabPage pismanlik6_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik6_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik6_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik6_3_fayda_txt_baslik1;
        TextBox pismanlik6_3_fayda_txt_baslik2;
        TextBox pismanlik6_3_fayda_txt_altbaslik1;
        TextBox pismanlik6_3_fayda_txt_altbaslik2;
        TextBox pismanlik6_3_fayda_txt_altbaslik3;
        TextBox pismanlik6_3_fayda_txt_altbaslik4;
        TextBox pismanlik6_3_fayda_txt_altbaslik5;
        TextBox pismanlik6_3_fayda_txt_altbaslik6;
        TextBox pismanlik6_3_fayda_txt_üstbaslik1;
        TextBox pismanlik6_3_fayda_txt_üstbaslik2;
        TextBox pismanlik6_3_fayda_txt_üstbaslik3;
        TextBox pismanlik6_3_fayda_txt_f1sonuc;
        TextBox pismanlik6_3_fayda_txt_f2sonuc;
        TextBox pismanlik6_3_fayda_txt_f3sonuc;
        TextBox pismanlik6_3_fayda_txt_f4sonuc;
        TextBox pismanlik6_3_fayda_txt_f5sonuc;
        TextBox pismanlik6_3_fayda_txt_f6sonuc;
        TextBox pismanlik6_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik6_3_fayda_txt_ortafsonuc;
        TextBox pismanlik6_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik6_3_fayda_txt_veri1;
        NumericUpDown pismanlik6_3_fayda_txt_veri2;
        NumericUpDown pismanlik6_3_fayda_txt_veri3;
        NumericUpDown pismanlik6_3_fayda_txt_veri4;
        NumericUpDown pismanlik6_3_fayda_txt_veri5;
        NumericUpDown pismanlik6_3_fayda_txt_veri6;
        NumericUpDown pismanlik6_3_fayda_txt_veri7;
        NumericUpDown pismanlik6_3_fayda_txt_veri8;
        NumericUpDown pismanlik6_3_fayda_txt_veri9;
        NumericUpDown pismanlik6_3_fayda_txt_veri10;
        NumericUpDown pismanlik6_3_fayda_txt_veri11;
        NumericUpDown pismanlik6_3_fayda_txt_veri12;
        NumericUpDown pismanlik6_3_fayda_txt_veri13;
        NumericUpDown pismanlik6_3_fayda_txt_veri14;
        NumericUpDown pismanlik6_3_fayda_txt_veri15;
        NumericUpDown pismanlik6_3_fayda_txt_veri16;
        NumericUpDown pismanlik6_3_fayda_txt_veri17;
        NumericUpDown pismanlik6_3_fayda_txt_veri18;
        Label pismanlik6_3_fayda_sonucbaslik;
        Label pismanlik6_3_fayda_sonuc;
        Label pismanlik6_3_fayda_sonuclarortabaslik;
        Label pismanlik6_3_fayda_altsonucbaslik;
        DataGridView pismanlik6_3_fayda_dr1 = new DataGridView();
        Button pismanlik6_3_fayda_btn1 = new Button();
        Button pismanlik6_3_fayda_btn2 = new Button();
        Button pismanlik6_3_fayda_btn3 = new Button();
        RichTextBox pismanlik6_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik7_3_fayda form nesneleri
        Panel pismanlik7_3_fayda_pl1 = new Panel();
        Panel pismanlik7_3_fayda_pl2 = new Panel();
        Panel pismanlik7_3_fayda_pl3 = new Panel();
        Panel pismanlik7_3_fayda_pl4 = new Panel();
        Panel pismanlik7_3_fayda_pl5 = new Panel();
        Panel pismanlik7_3_fayda_pl6 = new Panel();
        Panel pismanlik7_3_fayda_pl7 = new Panel();
        Panel pismanlik7_3_fayda_pl8 = new Panel();
        Panel pismanlik7_3_fayda_pl9 = new Panel();
        Panel pismanlik7_3_fayda_pl10 = new Panel();
        Panel pismanlik7_3_fayda_pl11 = new Panel();
        Panel pismanlik7_3_fayda_pl12 = new Panel();
        Panel pismanlik7_3_fayda_pl13 = new Panel();
        Panel pismanlik7_3_fayda_pl14 = new Panel();
        Panel pismanlik7_3_fayda_pl15 = new Panel();
        Panel pismanlik7_3_fayda_pl16 = new Panel();
        Panel pismanlik7_3_fayda_pl17 = new Panel();
        Panel pismanlik7_3_fayda_pl18 = new Panel();
        Panel pismanlik7_3_fayda_pl19 = new Panel();
        Panel pismanlik7_3_fayda_pl20 = new Panel();
        Panel pismanlik7_3_fayda_pl21 = new Panel();
        Panel pismanlik7_3_fayda_pl22 = new Panel();
        Panel pismanlik7_3_fayda_pl23 = new Panel();
        Panel pismanlik7_3_fayda_pl24 = new Panel();
        Panel pismanlik7_3_fayda_pl25 = new Panel();
        Panel pismanlik7_3_fayda_pl26 = new Panel();
        Panel pismanlik7_3_fayda_pl27 = new Panel();
        Panel pismanlik7_3_fayda_pl28 = new Panel();
        Panel pismanlik7_3_fayda_pl29 = new Panel();
        Panel pismanlik7_3_fayda_pl30 = new Panel();
        Panel pismanlik7_3_fayda_pl31 = new Panel();
        Panel pismanlik7_3_fayda_pl32 = new Panel();
        Panel pismanlik7_3_fayda_pl33 = new Panel();
        Panel pismanlik7_3_fayda_pl34 = new Panel();
        Panel pismanlik7_3_fayda_pl35 = new Panel();
        Panel pismanlik7_3_fayda_pl36 = new Panel();
        Panel pismanlik7_3_fayda_pl37 = new Panel();
        Panel pismanlik7_3_fayda_pl38 = new Panel();
        Panel pismanlik7_3_fayda_pl39 = new Panel();
        Panel pismanlik7_3_fayda_pl40 = new Panel();
        Panel pismanlik7_3_fayda_pl41 = new Panel();
        Panel pismanlik7_3_fayda_pl42 = new Panel();
        Panel pismanlik7_3_fayda_pl43 = new Panel();
        Panel pismanlik7_3_fayda_pl44 = new Panel();
        Panel pismanlik7_3_fayda_pl45 = new Panel();
        Panel pismanlik7_3_fayda_pl46 = new Panel();
        Panel pismanlik7_3_fayda_pl47 = new Panel();
        Panel pismanlik7_3_fayda_pl48 = new Panel();
        Panel pismanlik7_3_fayda_pl49 = new Panel();
        Panel pismanlik7_3_fayda_pl50 = new Panel();
        Panel pismanlik7_3_fayda_pl51 = new Panel();
        Panel pismanlik7_3_fayda_pl52 = new Panel();
        Panel pismanlik7_3_fayda_pl53 = new Panel();
        Panel pismanlik7_3_fayda_pl54 = new Panel();
        Panel pismanlik7_3_fayda_pl55 = new Panel();
        Panel pismanlik7_3_fayda_pl56 = new Panel();
        Panel pismanlik7_3_fayda_pl57 = new Panel();
        Panel pismanlik7_3_fayda_pl58 = new Panel();
        Panel pismanlik7_3_fayda_pl59 = new Panel();
        TabControl pismanlik7_3_fayda_tb1 = new TabControl();
        TabPage pismanlik7_3_fayda_tb1_1 = new TabPage();
        TabPage pismanlik7_3_fayda_tb1_2 = new TabPage();
        TabPage pismanlik7_3_fayda_tb1_3 = new TabPage();
        TextBox pismanlik7_3_fayda_txt_baslik1;
        TextBox pismanlik7_3_fayda_txt_baslik2;
        TextBox pismanlik7_3_fayda_txt_altbaslik1;
        TextBox pismanlik7_3_fayda_txt_altbaslik2;
        TextBox pismanlik7_3_fayda_txt_altbaslik3;
        TextBox pismanlik7_3_fayda_txt_altbaslik4;
        TextBox pismanlik7_3_fayda_txt_altbaslik5;
        TextBox pismanlik7_3_fayda_txt_altbaslik6;
        TextBox pismanlik7_3_fayda_txt_altbaslik7;
        TextBox pismanlik7_3_fayda_txt_üstbaslik1;
        TextBox pismanlik7_3_fayda_txt_üstbaslik2;
        TextBox pismanlik7_3_fayda_txt_üstbaslik3;
        TextBox pismanlik7_3_fayda_txt_f1sonuc;
        TextBox pismanlik7_3_fayda_txt_f2sonuc;
        TextBox pismanlik7_3_fayda_txt_f3sonuc;
        TextBox pismanlik7_3_fayda_txt_f4sonuc;
        TextBox pismanlik7_3_fayda_txt_f5sonuc;
        TextBox pismanlik7_3_fayda_txt_f6sonuc;
        TextBox pismanlik7_3_fayda_txt_f7sonuc;
        TextBox pismanlik7_3_fayda_txt_buyukfsonuc;
        TextBox pismanlik7_3_fayda_txt_ortafsonuc;
        TextBox pismanlik7_3_fayda_txt_yuksekfsonuc;
        NumericUpDown pismanlik7_3_fayda_txt_veri1;
        NumericUpDown pismanlik7_3_fayda_txt_veri2;
        NumericUpDown pismanlik7_3_fayda_txt_veri3;
        NumericUpDown pismanlik7_3_fayda_txt_veri4;
        NumericUpDown pismanlik7_3_fayda_txt_veri5;
        NumericUpDown pismanlik7_3_fayda_txt_veri6;
        NumericUpDown pismanlik7_3_fayda_txt_veri7;
        NumericUpDown pismanlik7_3_fayda_txt_veri8;
        NumericUpDown pismanlik7_3_fayda_txt_veri9;
        NumericUpDown pismanlik7_3_fayda_txt_veri10;
        NumericUpDown pismanlik7_3_fayda_txt_veri11;
        NumericUpDown pismanlik7_3_fayda_txt_veri12;
        NumericUpDown pismanlik7_3_fayda_txt_veri13;
        NumericUpDown pismanlik7_3_fayda_txt_veri14;
        NumericUpDown pismanlik7_3_fayda_txt_veri15;
        NumericUpDown pismanlik7_3_fayda_txt_veri16;
        NumericUpDown pismanlik7_3_fayda_txt_veri17;
        NumericUpDown pismanlik7_3_fayda_txt_veri18;
        NumericUpDown pismanlik7_3_fayda_txt_veri19;
        NumericUpDown pismanlik7_3_fayda_txt_veri20;
        NumericUpDown pismanlik7_3_fayda_txt_veri21;
        Label pismanlik7_3_fayda_sonucbaslik;
        Label pismanlik7_3_fayda_sonuc;
        Label pismanlik7_3_fayda_sonuclarortabaslik;
        Label pismanlik7_3_fayda_altsonucbaslik;
        DataGridView pismanlik7_3_fayda_dr1 = new DataGridView();
        Button pismanlik7_3_fayda_btn1 = new Button();
        Button pismanlik7_3_fayda_btn2 = new Button();
        Button pismanlik7_3_fayda_btn3 = new Button();
        RichTextBox pismanlik7_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //pismanlik2_3_fayda form nesne tasarımları
        public void pismanlik2_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik2_3_fayda_sonuc = new Label();
            pismanlik2_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik2_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik2_3_fayda_sonuc.Location = sonuc;
            pismanlik2_3_fayda_sonuc.Text = "";
            pismanlik2_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik2_3_fayda_pl4.Controls.Add(pismanlik2_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            pismanlik2_3_fayda_sonucbaslik = new Label();
            pismanlik2_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik2_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik2_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik2_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            pismanlik2_3_fayda_sonucbaslik.Size = new Size(88, 13);
            pismanlik2_3_fayda_pl4.Controls.Add(pismanlik2_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            pismanlik2_3_fayda_sonuclarortabaslik = new Label();
            pismanlik2_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik2_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik2_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik2_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik2_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik2_3_fayda_pl28.Controls.Add(pismanlik2_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel31 içerisine altsonuc Label  olarak yerleştirir
            pismanlik2_3_fayda_altsonucbaslik = new Label();
            pismanlik2_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik2_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik2_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik2_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik2_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik2_3_fayda_pl31.Controls.Add(pismanlik2_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik2_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl27.Controls.Add(pismanlik2_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik2_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl23.Controls.Add(pismanlik2_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik2_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl22.Controls.Add(pismanlik2_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik2_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl26.Controls.Add(pismanlik2_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik2_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl21.Controls.Add(pismanlik2_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik2_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik2_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik2_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik2_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik2_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl20.Controls.Add(pismanlik2_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel34 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik2_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik2_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik2_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik2_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik2_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik2_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl34.Controls.Add(pismanlik2_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel33 içerisine ortafsonuc textbox  yerleştirir
            pismanlik2_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik2_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik2_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik2_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik2_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik2_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl33.Controls.Add(pismanlik2_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel32 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik2_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik2_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik2_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik2_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik2_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik2_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl32.Controls.Add(pismanlik2_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik2_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik2_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik2_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik2_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik2_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik2_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl30.Controls.Add(pismanlik2_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik2_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik2_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik2_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik2_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik2_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik2_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik2_3_fayda_pl29.Controls.Add(pismanlik2_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik2_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik2_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik2_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik2_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik2_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik2_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik2_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik2_3_fayda_pl24.Controls.Add(pismanlik2_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik2_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik2_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik2_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik2_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik2_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik2_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik2_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik2_3_fayda_pl17.Controls.Add(pismanlik2_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik2_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik2_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik2_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik2_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik2_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik2_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik2_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik2_3_fayda_pl16.Controls.Add(pismanlik2_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik2_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik2_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik2_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik2_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik2_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik2_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik2_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik2_3_fayda_pl15.Controls.Add(pismanlik2_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik2_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik2_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik2_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik2_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik2_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik2_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik2_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik2_3_fayda_pl14.Controls.Add(pismanlik2_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik2_3_fayda_txt_baslik2 = new TextBox();
            pismanlik2_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik2_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik2_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik2_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik2_3_fayda_txt_baslik2.Multiline = true;
            pismanlik2_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik2_3_fayda_pl13.Controls.Add(pismanlik2_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik2_3_fayda_txt_baslik1 = new TextBox();
            pismanlik2_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik2_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik2_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik2_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik2_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik2_3_fayda_txt_baslik1.Multiline = true;
            pismanlik2_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik2_3_fayda_pl12.Controls.Add(pismanlik2_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel34 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik2_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik2_3_fayda_pl34.Location = pl34k;
            pismanlik2_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik2_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik2_3_fayda_pl33.Location = pl33k;
            pismanlik2_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik2_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik2_3_fayda_pl32.Location = pl32k;
            pismanlik2_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl32);
            //-----------------------------------------

            //panel31 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik2_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik2_3_fayda_pl31.Location = pl31k;
            pismanlik2_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik2_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl31);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik2_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik2_3_fayda_pl30.Location = pl30k;
            pismanlik2_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik2_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik2_3_fayda_pl29.Location = pl29k;
            pismanlik2_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik2_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik2_3_fayda_pl28.Location = pl28k;
            pismanlik2_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik2_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik2_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik2_3_fayda_pl27.Location = pl27k;
            pismanlik2_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik2_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik2_3_fayda_pl26.Location = pl26k;
            pismanlik2_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik2_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik2_3_fayda_pl23.Location = pl23k;
            pismanlik2_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik2_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik2_3_fayda_pl22.Location = pl22k;
            pismanlik2_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik2_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik2_3_fayda_pl21.Location = pl21k;
            pismanlik2_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik2_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik2_3_fayda_pl20.Location = pl20k;
            pismanlik2_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik2_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik2_3_fayda_pl25.Location = pl25k;
            pismanlik2_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik2_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik2_3_fayda_pl19.Location = pl19k;
            pismanlik2_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik2_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik2_3_fayda_pl18.Location = pl18k;
            pismanlik2_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik2_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik2_3_fayda_pl24.Location = pl24k;
            pismanlik2_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik2_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik2_3_fayda_pl17.Location = pl17k;
            pismanlik2_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik2_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik2_3_fayda_pl16.Location = pl16k;
            pismanlik2_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik2_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik2_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik2_3_fayda_pl15.Location = pl15k;
            pismanlik2_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik2_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik2_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik2_3_fayda_pl14.Location = pl14k;
            pismanlik2_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik2_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik2_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik2_3_fayda_pl13.Location = pl13k;
            pismanlik2_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik2_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik2_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik2_3_fayda_pl12.Location = pl12k;
            pismanlik2_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik2_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl5.Controls.Add(pismanlik2_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik2_3_fayda_pl11.Name = "pl11";
            pismanlik2_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik2_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik2_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik2_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik2_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl11.Click += new EventHandler(pismanlik2_3_fayda_pl11_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik2_3_fayda_pl10.Name = "pl10";
            pismanlik2_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik2_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik2_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik2_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik2_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl10.Click += new EventHandler(pismanlik2_3_fayda_pl10_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik2_3_fayda_pl9.Name = "pl9";
            pismanlik2_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik2_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik2_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik2_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik2_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl9.Click += new EventHandler(pismanlik2_3_fayda_pl9_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik2_3_fayda_pl8.Name = "pl8";
            pismanlik2_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik2_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik2_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik2_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik2_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl8.Click += new EventHandler(pismanlik2_3_fayda_pl8_Click);
            pismanlik2_3_fayda_pl7.Controls.Add(pismanlik2_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik2_3_fayda_pl6.Name = "pl6";
            pismanlik2_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik2_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik2_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik2_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik2_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl6.Click += new EventHandler(pismanlik2_3_fayda_pl6_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik2_3_fayda_btn3.Name = "btn3";
            pismanlik2_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik2_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik2_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik2_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik2_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik2_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_btn3.Click += new EventHandler(pismanlik2_3_fayda_btn3_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik2_3_fayda_btn2.Name = "btn2";
            pismanlik2_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik2_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik2_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik2_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik2_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik2_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik2_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik2_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_btn2.Click += new EventHandler(pismanlik2_3_fayda_btn2_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik2_3_fayda_btn1.Name = "btn1";
            pismanlik2_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik2_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik2_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik2_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik2_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik2_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik2_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik2_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_btn1.Click += new EventHandler(pismanlik2_3_fayda_btn1_Click);
            pismanlik2_3_fayda_pl2.Controls.Add(pismanlik2_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik2_3_fayda_dr1.Name = "dr1";
            pismanlik2_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik2_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik2_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik2_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik2_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik2_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik2_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik2_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik2_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik2_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik2_3_fayda_dr1_CellEnter);
            pismanlik2_3_fayda_tb1_2.Controls.Add(pismanlik2_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik2_3_fayda_pl7.Name = "pl7";
            pismanlik2_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik2_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik2_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_tb1_2.Controls.Add(pismanlik2_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik2_3_fayda_pl5.Name = "pl5";
            pismanlik2_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik2_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik2_3_fayda_pl5.AutoScroll = true;
            pismanlik2_3_fayda_pl5.AutoSize = true;
            pismanlik2_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik2_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_tb1_1.Controls.Add(pismanlik2_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik2_3_fayda_rt1.Name = "rt1";
            pismanlik2_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik2_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik2_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_rt1.Enabled = false;
            pismanlik2_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik2_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik2_3_fayda_tb1_3.Controls.Add(pismanlik2_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik2_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik2_3_fayda_tb1_1.Text = "Tablo";
            pismanlik2_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik2_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_tb1.Controls.Add(pismanlik2_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik2_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik2_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik2_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik2_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_tb1.Controls.Add(pismanlik2_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik2_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik2_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik2_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik2_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_tb1.Controls.Add(pismanlik2_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik2_3_fayda_tb1.Name = "tb1";
            pismanlik2_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik2_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik2_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik2_3_fayda_pl3.Controls.Add(pismanlik2_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik2_3_fayda_pl4.Name = "pl4";
            pismanlik2_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik2_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik2_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik2_3_fayda_pl4_MouseUp);
            pismanlik2_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik2_3_fayda_pl4_MouseMove);
            pismanlik2_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik2_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik2_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik2_3_fayda_pl3.Name = "pl3";
            pismanlik2_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik2_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik2_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik2_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik2_3_fayda_pl2.Name = "pl2";
            pismanlik2_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik2_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik2_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik2_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik2_3_fayda_pl1.Name = "pl1";
            pismanlik2_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik2_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik2_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik2_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik2_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik2_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik2_3_fayda_pl1_MouseUp);
            pismanlik2_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik2_3_fayda_pl1_MouseMove);
            pismanlik2_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik2_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik2_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik3_3_fayda form nesne tasarımları
        public void pismanlik3_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik3_3_fayda_sonuc = new Label();
            pismanlik3_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik3_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik3_3_fayda_sonuc.Location = sonuc;
            pismanlik3_3_fayda_sonuc.Text = "";
            pismanlik3_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik3_3_fayda_pl4.Controls.Add(pismanlik3_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük fayda ismini Label  olarak yerleştirir
            pismanlik3_3_fayda_sonucbaslik = new Label();
            pismanlik3_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik3_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik3_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik3_3_fayda_sonucbaslik.Text = "En Küçük Fayda:";
            pismanlik3_3_fayda_sonucbaslik.Size = new Size(93, 13);
            pismanlik3_3_fayda_pl4.Controls.Add(pismanlik3_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maximax Label  olarak yerleştirir
            pismanlik3_3_fayda_sonuclarortabaslik = new Label();
            pismanlik3_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik3_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik3_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik3_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik3_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik3_3_fayda_pl28.Controls.Add(pismanlik3_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel36 içerisine altsonuc Label  olarak yerleştirir
            pismanlik3_3_fayda_altsonucbaslik = new Label();
            pismanlik3_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik3_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik3_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik3_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik3_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik3_3_fayda_pl36.Controls.Add(pismanlik3_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri9 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri9.Location = txt_veri9;
            pismanlik3_3_fayda_txt_veri9.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl34.Controls.Add(pismanlik3_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri8 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri8.Location = txt_veri8;
            pismanlik3_3_fayda_txt_veri8.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl33.Controls.Add(pismanlik3_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri7 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri7.Location = txt_veri7;
            pismanlik3_3_fayda_txt_veri7.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl32.Controls.Add(pismanlik3_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik3_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl27.Controls.Add(pismanlik3_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik3_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl23.Controls.Add(pismanlik3_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik3_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl22.Controls.Add(pismanlik3_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik3_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl26.Controls.Add(pismanlik3_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik3_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl21.Controls.Add(pismanlik3_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik3_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik3_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik3_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik3_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik3_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl20.Controls.Add(pismanlik3_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel39 içerisine yuksekfsonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik3_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik3_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik3_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik3_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl39.Controls.Add(pismanlik3_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel38 içerisine ortafsonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik3_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik3_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik3_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik3_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl38.Controls.Add(pismanlik3_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel37 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik3_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik3_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik3_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik3_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl37.Controls.Add(pismanlik3_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------


            //panel35 içerisine f3sonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_f3sonuc = new TextBox();
            pismanlik3_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            pismanlik3_3_fayda_txt_f3sonuc.Text = "0";
            pismanlik3_3_fayda_txt_f3sonuc.Enabled = false;
            pismanlik3_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl35.Controls.Add(pismanlik3_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik3_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik3_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik3_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik3_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl30.Controls.Add(pismanlik3_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik3_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik3_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik3_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik3_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik3_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik3_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik3_3_fayda_pl29.Controls.Add(pismanlik3_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik3_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik3_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik3_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik3_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik3_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik3_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik3_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik3_3_fayda_pl24.Controls.Add(pismanlik3_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik3_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik3_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik3_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik3_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik3_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik3_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik3_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik3_3_fayda_pl17.Controls.Add(pismanlik3_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik3_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik3_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik3_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik3_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik3_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik3_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik3_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik3_3_fayda_pl16.Controls.Add(pismanlik3_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            pismanlik3_3_fayda_txt_altbaslik3 = new TextBox();
            pismanlik3_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            pismanlik3_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            pismanlik3_3_fayda_txt_altbaslik3.Text = "F3";
            pismanlik3_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_altbaslik3.MaxLength = 30;
            pismanlik3_3_fayda_txt_altbaslik3.Multiline = true;
            pismanlik3_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            pismanlik3_3_fayda_pl31.Controls.Add(pismanlik3_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik3_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik3_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik3_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik3_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik3_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik3_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik3_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik3_3_fayda_pl15.Controls.Add(pismanlik3_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik3_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik3_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik3_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik3_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik3_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik3_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik3_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik3_3_fayda_pl14.Controls.Add(pismanlik3_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik3_3_fayda_txt_baslik2 = new TextBox();
            pismanlik3_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik3_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik3_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik3_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik3_3_fayda_txt_baslik2.Multiline = true;
            pismanlik3_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik3_3_fayda_pl13.Controls.Add(pismanlik3_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik3_3_fayda_txt_baslik1 = new TextBox();
            pismanlik3_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik3_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik3_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik3_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik3_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik3_3_fayda_txt_baslik1.Multiline = true;
            pismanlik3_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik3_3_fayda_pl12.Controls.Add(pismanlik3_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel39 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik3_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            pismanlik3_3_fayda_pl39.Location = pl39k;
            pismanlik3_3_fayda_pl39.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik3_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            pismanlik3_3_fayda_pl38.Location = pl38k;
            pismanlik3_3_fayda_pl38.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik3_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            pismanlik3_3_fayda_pl37.Location = pl37k;
            pismanlik3_3_fayda_pl37.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl37);
            //-----------------------------------------

            //panel36 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik3_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            pismanlik3_3_fayda_pl36.Location = pl36k;
            pismanlik3_3_fayda_pl36.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl36);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            pismanlik3_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            pismanlik3_3_fayda_pl35.Location = pl35k;
            pismanlik3_3_fayda_pl35.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik3_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik3_3_fayda_pl30.Location = pl30k;
            pismanlik3_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik3_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik3_3_fayda_pl29.Location = pl29k;
            pismanlik3_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik3_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik3_3_fayda_pl28.Location = pl28k;
            pismanlik3_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik3_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            pismanlik3_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik3_3_fayda_pl34.Location = pl34k;
            pismanlik3_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            pismanlik3_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik3_3_fayda_pl33.Location = pl33k;
            pismanlik3_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            pismanlik3_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik3_3_fayda_pl32.Location = pl32k;
            pismanlik3_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik3_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik3_3_fayda_pl27.Location = pl27k;
            pismanlik3_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik3_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik3_3_fayda_pl26.Location = pl26k;
            pismanlik3_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik3_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik3_3_fayda_pl23.Location = pl23k;
            pismanlik3_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik3_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik3_3_fayda_pl22.Location = pl22k;
            pismanlik3_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik3_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik3_3_fayda_pl21.Location = pl21k;
            pismanlik3_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik3_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik3_3_fayda_pl20.Location = pl20k;
            pismanlik3_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik3_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik3_3_fayda_pl25.Location = pl25k;
            pismanlik3_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik3_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik3_3_fayda_pl19.Location = pl19k;
            pismanlik3_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik3_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik3_3_fayda_pl18.Location = pl18k;
            pismanlik3_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik3_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik3_3_fayda_pl24.Location = pl24k;
            pismanlik3_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik3_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik3_3_fayda_pl17.Location = pl17k;
            pismanlik3_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik3_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik3_3_fayda_pl16.Location = pl16k;
            pismanlik3_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik3_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            pismanlik3_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik3_3_fayda_pl31.Location = pl31k;
            pismanlik3_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik3_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik3_3_fayda_pl15.Location = pl15k;
            pismanlik3_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik3_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik3_3_fayda_pl14.Location = pl14k;
            pismanlik3_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik3_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik3_3_fayda_pl13.Location = pl13k;
            pismanlik3_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik3_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik3_3_fayda_pl12.Location = pl12k;
            pismanlik3_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik3_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl5.Controls.Add(pismanlik3_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik3_3_fayda_pl11.Name = "pl11";
            pismanlik3_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik3_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik3_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik3_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik3_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl11.Click += new EventHandler(pismanlik3_3_fayda_pl11_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik3_3_fayda_pl10.Name = "pl10";
            pismanlik3_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik3_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik3_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik3_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik3_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl10.Click += new EventHandler(pismanlik3_3_fayda_pl10_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik3_3_fayda_pl9.Name = "pl9";
            pismanlik3_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik3_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik3_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik3_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik3_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl9.Click += new EventHandler(pismanlik3_3_fayda_pl9_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik3_3_fayda_pl8.Name = "pl8";
            pismanlik3_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik3_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik3_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik3_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik3_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl8.Click += new EventHandler(pismanlik3_3_fayda_pl8_Click);
            pismanlik3_3_fayda_pl7.Controls.Add(pismanlik3_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik3_3_fayda_pl6.Name = "pl6";
            pismanlik3_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik3_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik3_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik3_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik3_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl6.Click += new EventHandler(pismanlik3_3_fayda_pl6_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik3_3_fayda_btn3.Name = "btn3";
            pismanlik3_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik3_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik3_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik3_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik3_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik3_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_btn3.Click += new EventHandler(pismanlik3_3_fayda_btn3_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik3_3_fayda_btn2.Name = "btn2";
            pismanlik3_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik3_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik3_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik3_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik3_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik3_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik3_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik3_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_btn2.Click += new EventHandler(pismanlik3_3_fayda_btn2_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik3_3_fayda_btn1.Name = "btn1";
            pismanlik3_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik3_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik3_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik3_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik3_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik3_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik3_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik3_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_btn1.Click += new EventHandler(pismanlik3_3_fayda_btn1_Click);
            pismanlik3_3_fayda_pl2.Controls.Add(pismanlik3_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik3_3_fayda_dr1.Name = "dr1";
            pismanlik3_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik3_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik3_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik3_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik3_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik3_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik3_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik3_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik3_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik3_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik3_3_fayda_dr1_CellEnter);
            pismanlik3_3_fayda_tb1_2.Controls.Add(pismanlik3_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik3_3_fayda_pl7.Name = "pl7";
            pismanlik3_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik3_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik3_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_tb1_2.Controls.Add(pismanlik3_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik3_3_fayda_pl5.Name = "pl5";
            pismanlik3_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik3_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik3_3_fayda_pl5.AutoScroll = true;
            pismanlik3_3_fayda_pl5.AutoSize = true;
            pismanlik3_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik3_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_tb1_1.Controls.Add(pismanlik3_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik3_3_fayda_rt1.Name = "rt1";
            pismanlik3_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik3_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik3_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_rt1.Enabled = false;
            pismanlik3_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik3_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik3_3_fayda_tb1_3.Controls.Add(pismanlik3_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik3_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik3_3_fayda_tb1_1.Text = "Tablo";
            pismanlik3_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik3_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_tb1.Controls.Add(pismanlik3_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik3_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik3_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik3_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik3_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_tb1.Controls.Add(pismanlik3_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik3_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik3_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik3_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik3_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_tb1.Controls.Add(pismanlik3_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik3_3_fayda_tb1.Name = "tb1";
            pismanlik3_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik3_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik3_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik3_3_fayda_pl3.Controls.Add(pismanlik3_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik3_3_fayda_pl4.Name = "pl4";
            pismanlik3_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik3_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik3_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik3_3_fayda_pl4_MouseUp);
            pismanlik3_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik3_3_fayda_pl4_MouseMove);
            pismanlik3_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik3_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik3_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik3_3_fayda_pl3.Name = "pl3";
            pismanlik3_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik3_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik3_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik3_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik3_3_fayda_pl2.Name = "pl2";
            pismanlik3_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik3_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik3_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik3_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik3_3_fayda_pl1.Name = "pl1";
            pismanlik3_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik3_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik3_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik3_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik3_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik3_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik3_3_fayda_pl1_MouseUp);
            pismanlik3_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik3_3_fayda_pl1_MouseMove);
            pismanlik3_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik3_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik3_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik4_3_fayda form nesne tasarımları
        public void pismanlik4_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik4_3_fayda_sonuc = new Label();
            pismanlik4_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik4_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik4_3_fayda_sonuc.Location = sonuc;
            pismanlik4_3_fayda_sonuc.Text = "";
            pismanlik4_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik4_3_fayda_pl4.Controls.Add(pismanlik4_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük fayda ismini Label  olarak yerleştirir
            pismanlik4_3_fayda_sonucbaslik = new Label();
            pismanlik4_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik4_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik4_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik4_3_fayda_sonucbaslik.Text = "En Küçük Fayda:";
            pismanlik4_3_fayda_sonucbaslik.Size = new Size(93, 13);
            pismanlik4_3_fayda_pl4.Controls.Add(pismanlik4_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            pismanlik4_3_fayda_sonuclarortabaslik = new Label();
            pismanlik4_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik4_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik4_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik4_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik4_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik4_3_fayda_pl28.Controls.Add(pismanlik4_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel41 içerisine altsonuc Label  olarak yerleştirir
            pismanlik4_3_fayda_altsonucbaslik = new Label();
            pismanlik4_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik4_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik4_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik4_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik4_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik4_3_fayda_pl41.Controls.Add(pismanlik4_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri12 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri12.Location = txt_veri12;
            pismanlik4_3_fayda_txt_veri12.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl39.Controls.Add(pismanlik4_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri11 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri11.Location = txt_veri11;
            pismanlik4_3_fayda_txt_veri11.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl38.Controls.Add(pismanlik4_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri10 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri10.Location = txt_veri10;
            pismanlik4_3_fayda_txt_veri10.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl37.Controls.Add(pismanlik4_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri9 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri9.Location = txt_veri9;
            pismanlik4_3_fayda_txt_veri9.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl34.Controls.Add(pismanlik4_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri8 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri8.Location = txt_veri8;
            pismanlik4_3_fayda_txt_veri8.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl33.Controls.Add(pismanlik4_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri7 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri7.Location = txt_veri7;
            pismanlik4_3_fayda_txt_veri7.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl32.Controls.Add(pismanlik4_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik4_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl27.Controls.Add(pismanlik4_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik4_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl23.Controls.Add(pismanlik4_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik4_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl22.Controls.Add(pismanlik4_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik4_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl26.Controls.Add(pismanlik4_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik4_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl21.Controls.Add(pismanlik4_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik4_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik4_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik4_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik4_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik4_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl20.Controls.Add(pismanlik4_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel44 içerisine yuksekfsonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik4_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik4_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik4_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik4_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl44.Controls.Add(pismanlik4_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel43 içerisine ortafsonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik4_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik4_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik4_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik4_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl43.Controls.Add(pismanlik4_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel42 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik4_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik4_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik4_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik4_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl42.Controls.Add(pismanlik4_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_f4sonuc = new TextBox();
            pismanlik4_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            pismanlik4_3_fayda_txt_f4sonuc.Text = "0";
            pismanlik4_3_fayda_txt_f4sonuc.Enabled = false;
            pismanlik4_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl40.Controls.Add(pismanlik4_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_f3sonuc = new TextBox();
            pismanlik4_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            pismanlik4_3_fayda_txt_f3sonuc.Text = "0";
            pismanlik4_3_fayda_txt_f3sonuc.Enabled = false;
            pismanlik4_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl35.Controls.Add(pismanlik4_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik4_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik4_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik4_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik4_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl30.Controls.Add(pismanlik4_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik4_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik4_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik4_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik4_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik4_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik4_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik4_3_fayda_pl29.Controls.Add(pismanlik4_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik4_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik4_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik4_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik4_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik4_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik4_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik4_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik4_3_fayda_pl24.Controls.Add(pismanlik4_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik4_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik4_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik4_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik4_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik4_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik4_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik4_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik4_3_fayda_pl17.Controls.Add(pismanlik4_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik4_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik4_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik4_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik4_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik4_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik4_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik4_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik4_3_fayda_pl16.Controls.Add(pismanlik4_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            pismanlik4_3_fayda_txt_altbaslik4 = new TextBox();
            pismanlik4_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            pismanlik4_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            pismanlik4_3_fayda_txt_altbaslik4.Text = "F4";
            pismanlik4_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_altbaslik4.MaxLength = 30;
            pismanlik4_3_fayda_txt_altbaslik4.Multiline = true;
            pismanlik4_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl36.Controls.Add(pismanlik4_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            pismanlik4_3_fayda_txt_altbaslik3 = new TextBox();
            pismanlik4_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            pismanlik4_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            pismanlik4_3_fayda_txt_altbaslik3.Text = "F3";
            pismanlik4_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_altbaslik3.MaxLength = 30;
            pismanlik4_3_fayda_txt_altbaslik3.Multiline = true;
            pismanlik4_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl31.Controls.Add(pismanlik4_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik4_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik4_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik4_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik4_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik4_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik4_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik4_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl15.Controls.Add(pismanlik4_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik4_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik4_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik4_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik4_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik4_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik4_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik4_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl14.Controls.Add(pismanlik4_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik4_3_fayda_txt_baslik2 = new TextBox();
            pismanlik4_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik4_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik4_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik4_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik4_3_fayda_txt_baslik2.Multiline = true;
            pismanlik4_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl13.Controls.Add(pismanlik4_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik4_3_fayda_txt_baslik1 = new TextBox();
            pismanlik4_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik4_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik4_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik4_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik4_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik4_3_fayda_txt_baslik1.Multiline = true;
            pismanlik4_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik4_3_fayda_pl12.Controls.Add(pismanlik4_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel44 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik4_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            pismanlik4_3_fayda_pl44.Location = pl44k;
            pismanlik4_3_fayda_pl44.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik4_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            pismanlik4_3_fayda_pl43.Location = pl43k;
            pismanlik4_3_fayda_pl43.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik4_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            pismanlik4_3_fayda_pl42.Location = pl42k;
            pismanlik4_3_fayda_pl42.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl42);
            //-----------------------------------------

            //panel41 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik4_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            pismanlik4_3_fayda_pl41.Location = pl41k;
            pismanlik4_3_fayda_pl41.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl41);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            pismanlik4_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            pismanlik4_3_fayda_pl40.Location = pl40k;
            pismanlik4_3_fayda_pl40.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            pismanlik4_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            pismanlik4_3_fayda_pl35.Location = pl35k;
            pismanlik4_3_fayda_pl35.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik4_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik4_3_fayda_pl30.Location = pl30k;
            pismanlik4_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik4_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik4_3_fayda_pl29.Location = pl29k;
            pismanlik4_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik4_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik4_3_fayda_pl28.Location = pl28k;
            pismanlik4_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik4_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            pismanlik4_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            pismanlik4_3_fayda_pl39.Location = pl39k;
            pismanlik4_3_fayda_pl39.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            pismanlik4_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            pismanlik4_3_fayda_pl38.Location = pl38k;
            pismanlik4_3_fayda_pl38.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            pismanlik4_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            pismanlik4_3_fayda_pl37.Location = pl37k;
            pismanlik4_3_fayda_pl37.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            pismanlik4_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik4_3_fayda_pl34.Location = pl34k;
            pismanlik4_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            pismanlik4_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik4_3_fayda_pl33.Location = pl33k;
            pismanlik4_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            pismanlik4_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik4_3_fayda_pl32.Location = pl32k;
            pismanlik4_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik4_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik4_3_fayda_pl27.Location = pl27k;
            pismanlik4_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik4_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik4_3_fayda_pl26.Location = pl26k;
            pismanlik4_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik4_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik4_3_fayda_pl23.Location = pl23k;
            pismanlik4_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik4_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik4_3_fayda_pl22.Location = pl22k;
            pismanlik4_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik4_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik4_3_fayda_pl21.Location = pl21k;
            pismanlik4_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik4_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik4_3_fayda_pl20.Location = pl20k;
            pismanlik4_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik4_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik4_3_fayda_pl25.Location = pl25k;
            pismanlik4_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik4_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik4_3_fayda_pl19.Location = pl19k;
            pismanlik4_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik4_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik4_3_fayda_pl18.Location = pl18k;
            pismanlik4_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik4_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik4_3_fayda_pl24.Location = pl24k;
            pismanlik4_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik4_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik4_3_fayda_pl17.Location = pl17k;
            pismanlik4_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik4_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik4_3_fayda_pl16.Location = pl16k;
            pismanlik4_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik4_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            pismanlik4_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            pismanlik4_3_fayda_pl36.Location = pl36k;
            pismanlik4_3_fayda_pl36.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            pismanlik4_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik4_3_fayda_pl31.Location = pl31k;
            pismanlik4_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik4_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik4_3_fayda_pl15.Location = pl15k;
            pismanlik4_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik4_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik4_3_fayda_pl14.Location = pl14k;
            pismanlik4_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik4_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik4_3_fayda_pl13.Location = pl13k;
            pismanlik4_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik4_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik4_3_fayda_pl12.Location = pl12k;
            pismanlik4_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik4_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl5.Controls.Add(pismanlik4_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik4_3_fayda_pl11.Name = "pl11";
            pismanlik4_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik4_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik4_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik4_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik4_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl11.Click += new EventHandler(pismanlik4_3_fayda_pl11_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik4_3_fayda_pl10.Name = "pl10";
            pismanlik4_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik4_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik4_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik4_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik4_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl10.Click += new EventHandler(pismanlik4_3_fayda_pl10_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik4_3_fayda_pl9.Name = "pl9";
            pismanlik4_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik4_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik4_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik4_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik4_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl9.Click += new EventHandler(pismanlik4_3_fayda_pl9_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik4_3_fayda_pl8.Name = "pl8";
            pismanlik4_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik4_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik4_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik4_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik4_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl8.Click += new EventHandler(pismanlik4_3_fayda_pl8_Click);
            pismanlik4_3_fayda_pl7.Controls.Add(pismanlik4_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik4_3_fayda_pl6.Name = "pl6";
            pismanlik4_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik4_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik4_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik4_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik4_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl6.Click += new EventHandler(pismanlik4_3_fayda_pl6_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik4_3_fayda_btn3.Name = "btn3";
            pismanlik4_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik4_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik4_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik4_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik4_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik4_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_btn3.Click += new EventHandler(pismanlik4_3_fayda_btn3_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik4_3_fayda_btn2.Name = "btn2";
            pismanlik4_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik4_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik4_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik4_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik4_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik4_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik4_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik4_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_btn2.Click += new EventHandler(pismanlik4_3_fayda_btn2_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik4_3_fayda_btn1.Name = "btn1";
            pismanlik4_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik4_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik4_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik4_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik4_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik4_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik4_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik4_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_btn1.Click += new EventHandler(pismanlik4_3_fayda_btn1_Click);
            pismanlik4_3_fayda_pl2.Controls.Add(pismanlik4_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik4_3_fayda_dr1.Name = "dr1";
            pismanlik4_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik4_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik4_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik4_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik4_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik4_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik4_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik4_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik4_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik4_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik4_3_fayda_dr1_CellEnter);
            pismanlik4_3_fayda_tb1_2.Controls.Add(pismanlik4_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik4_3_fayda_pl7.Name = "pl7";
            pismanlik4_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik4_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik4_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_tb1_2.Controls.Add(pismanlik4_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik4_3_fayda_pl5.Name = "pl5";
            pismanlik4_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik4_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik4_3_fayda_pl5.AutoScroll = true;
            pismanlik4_3_fayda_pl5.AutoSize = true;
            pismanlik4_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik4_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_tb1_1.Controls.Add(pismanlik4_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik4_3_fayda_rt1.Name = "rt1";
            pismanlik4_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik4_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik4_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_rt1.Enabled = false;
            pismanlik4_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik4_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik4_3_fayda_tb1_3.Controls.Add(pismanlik4_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik4_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik4_3_fayda_tb1_1.Text = "Tablo";
            pismanlik4_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik4_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_tb1.Controls.Add(pismanlik4_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik4_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik4_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik4_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik4_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_tb1.Controls.Add(pismanlik4_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik4_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik4_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik4_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik4_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_tb1.Controls.Add(pismanlik4_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik4_3_fayda_tb1.Name = "tb1";
            pismanlik4_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik4_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik4_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik4_3_fayda_pl3.Controls.Add(pismanlik4_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik4_3_fayda_pl4.Name = "pl4";
            pismanlik4_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik4_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik4_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik4_3_fayda_pl4_MouseUp);
            pismanlik4_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik4_3_fayda_pl4_MouseMove);
            pismanlik4_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik4_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik4_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik4_3_fayda_pl3.Name = "pl3";
            pismanlik4_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik4_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik4_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik4_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik4_3_fayda_pl2.Name = "pl2";
            pismanlik4_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik4_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik4_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik4_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik4_3_fayda_pl1.Name = "pl1";
            pismanlik4_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik4_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik4_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik4_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik4_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik4_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik4_3_fayda_pl1_MouseUp);
            pismanlik4_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik4_3_fayda_pl1_MouseMove);
            pismanlik4_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik4_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik4_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik5_3_fayda form nesne tasarımları
        public void pismanlik5_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik5_3_fayda_sonuc = new Label();
            pismanlik5_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik5_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik5_3_fayda_sonuc.Location = sonuc;
            pismanlik5_3_fayda_sonuc.Text = "";
            pismanlik5_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik5_3_fayda_pl4.Controls.Add(pismanlik5_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük fayda ismini Label  olarak yerleştirir
            pismanlik5_3_fayda_sonucbaslik = new Label();
            pismanlik5_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik5_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik5_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik5_3_fayda_sonucbaslik.Text = "En Küçük Fayda:";
            pismanlik5_3_fayda_sonucbaslik.Size = new Size(93, 13);
            pismanlik5_3_fayda_pl4.Controls.Add(pismanlik5_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            pismanlik5_3_fayda_sonuclarortabaslik = new Label();
            pismanlik5_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik5_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik5_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik5_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik5_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik5_3_fayda_pl28.Controls.Add(pismanlik5_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel46 içerisine altsonuc Label  olarak yerleştirir
            pismanlik5_3_fayda_altsonucbaslik = new Label();
            pismanlik5_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik5_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik5_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik5_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik5_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik5_3_fayda_pl46.Controls.Add(pismanlik5_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri15 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri15.Location = txt_veri15;
            pismanlik5_3_fayda_txt_veri15.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl44.Controls.Add(pismanlik5_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri14 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri14.Location = txt_veri14;
            pismanlik5_3_fayda_txt_veri14.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl43.Controls.Add(pismanlik5_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri13 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri13.Location = txt_veri13;
            pismanlik5_3_fayda_txt_veri13.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl42.Controls.Add(pismanlik5_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri12 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri12.Location = txt_veri12;
            pismanlik5_3_fayda_txt_veri12.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl39.Controls.Add(pismanlik5_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri11 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri11.Location = txt_veri11;
            pismanlik5_3_fayda_txt_veri11.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl38.Controls.Add(pismanlik5_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri10 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri10.Location = txt_veri10;
            pismanlik5_3_fayda_txt_veri10.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl37.Controls.Add(pismanlik5_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri9 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri9.Location = txt_veri9;
            pismanlik5_3_fayda_txt_veri9.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl34.Controls.Add(pismanlik5_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri8 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri8.Location = txt_veri8;
            pismanlik5_3_fayda_txt_veri8.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl33.Controls.Add(pismanlik5_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri7 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri7.Location = txt_veri7;
            pismanlik5_3_fayda_txt_veri7.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl32.Controls.Add(pismanlik5_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik5_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl27.Controls.Add(pismanlik5_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik5_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl23.Controls.Add(pismanlik5_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik5_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl22.Controls.Add(pismanlik5_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik5_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl26.Controls.Add(pismanlik5_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik5_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl21.Controls.Add(pismanlik5_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik5_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik5_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik5_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik5_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik5_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl20.Controls.Add(pismanlik5_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel49 içerisine yuksekfsonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik5_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik5_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik5_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik5_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl49.Controls.Add(pismanlik5_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel48 içerisine ortafsonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik5_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik5_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik5_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik5_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl48.Controls.Add(pismanlik5_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel47 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik5_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik5_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik5_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik5_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl47.Controls.Add(pismanlik5_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_f5sonuc = new TextBox();
            pismanlik5_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            pismanlik5_3_fayda_txt_f5sonuc.Text = "0";
            pismanlik5_3_fayda_txt_f5sonuc.Enabled = false;
            pismanlik5_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl45.Controls.Add(pismanlik5_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_f4sonuc = new TextBox();
            pismanlik5_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            pismanlik5_3_fayda_txt_f4sonuc.Text = "0";
            pismanlik5_3_fayda_txt_f4sonuc.Enabled = false;
            pismanlik5_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl40.Controls.Add(pismanlik5_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_f3sonuc = new TextBox();
            pismanlik5_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            pismanlik5_3_fayda_txt_f3sonuc.Text = "0";
            pismanlik5_3_fayda_txt_f3sonuc.Enabled = false;
            pismanlik5_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl35.Controls.Add(pismanlik5_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik5_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik5_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik5_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik5_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl30.Controls.Add(pismanlik5_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik5_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik5_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik5_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik5_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik5_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik5_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik5_3_fayda_pl29.Controls.Add(pismanlik5_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik5_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik5_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik5_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik5_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik5_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik5_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik5_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik5_3_fayda_pl24.Controls.Add(pismanlik5_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik5_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik5_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik5_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik5_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik5_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik5_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik5_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik5_3_fayda_pl17.Controls.Add(pismanlik5_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik5_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik5_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik5_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik5_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik5_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik5_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik5_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik5_3_fayda_pl16.Controls.Add(pismanlik5_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            pismanlik5_3_fayda_txt_altbaslik5 = new TextBox();
            pismanlik5_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            pismanlik5_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            pismanlik5_3_fayda_txt_altbaslik5.Text = "F5";
            pismanlik5_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_altbaslik5.MaxLength = 30;
            pismanlik5_3_fayda_txt_altbaslik5.Multiline = true;
            pismanlik5_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl41.Controls.Add(pismanlik5_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            pismanlik5_3_fayda_txt_altbaslik4 = new TextBox();
            pismanlik5_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            pismanlik5_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            pismanlik5_3_fayda_txt_altbaslik4.Text = "F4";
            pismanlik5_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_altbaslik4.MaxLength = 30;
            pismanlik5_3_fayda_txt_altbaslik4.Multiline = true;
            pismanlik5_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl36.Controls.Add(pismanlik5_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            pismanlik5_3_fayda_txt_altbaslik3 = new TextBox();
            pismanlik5_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            pismanlik5_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            pismanlik5_3_fayda_txt_altbaslik3.Text = "F3";
            pismanlik5_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_altbaslik3.MaxLength = 30;
            pismanlik5_3_fayda_txt_altbaslik3.Multiline = true;
            pismanlik5_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl31.Controls.Add(pismanlik5_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik5_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik5_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik5_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik5_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik5_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik5_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik5_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl15.Controls.Add(pismanlik5_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik5_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik5_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik5_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik5_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik5_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik5_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik5_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl14.Controls.Add(pismanlik5_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik5_3_fayda_txt_baslik2 = new TextBox();
            pismanlik5_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik5_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik5_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik5_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik5_3_fayda_txt_baslik2.Multiline = true;
            pismanlik5_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl13.Controls.Add(pismanlik5_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik5_3_fayda_txt_baslik1 = new TextBox();
            pismanlik5_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik5_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik5_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik5_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik5_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik5_3_fayda_txt_baslik1.Multiline = true;
            pismanlik5_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik5_3_fayda_pl12.Controls.Add(pismanlik5_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel49 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik5_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            pismanlik5_3_fayda_pl49.Location = pl49k;
            pismanlik5_3_fayda_pl49.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik5_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            pismanlik5_3_fayda_pl48.Location = pl48k;
            pismanlik5_3_fayda_pl48.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik5_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            pismanlik5_3_fayda_pl47.Location = pl47k;
            pismanlik5_3_fayda_pl47.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl47);
            //-----------------------------------------

            //panel46 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik5_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            pismanlik5_3_fayda_pl46.Location = pl46k;
            pismanlik5_3_fayda_pl46.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl46);
            //-----------------------------------------


            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            pismanlik5_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            pismanlik5_3_fayda_pl45.Location = pl45k;
            pismanlik5_3_fayda_pl45.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            pismanlik5_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            pismanlik5_3_fayda_pl40.Location = pl40k;
            pismanlik5_3_fayda_pl40.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            pismanlik5_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            pismanlik5_3_fayda_pl35.Location = pl35k;
            pismanlik5_3_fayda_pl35.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik5_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik5_3_fayda_pl30.Location = pl30k;
            pismanlik5_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik5_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik5_3_fayda_pl29.Location = pl29k;
            pismanlik5_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik5_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik5_3_fayda_pl28.Location = pl28k;
            pismanlik5_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik5_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            pismanlik5_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            pismanlik5_3_fayda_pl44.Location = pl44k;
            pismanlik5_3_fayda_pl44.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            pismanlik5_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            pismanlik5_3_fayda_pl43.Location = pl43k;
            pismanlik5_3_fayda_pl43.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            pismanlik5_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            pismanlik5_3_fayda_pl42.Location = pl42k;
            pismanlik5_3_fayda_pl42.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            pismanlik5_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            pismanlik5_3_fayda_pl39.Location = pl39k;
            pismanlik5_3_fayda_pl39.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            pismanlik5_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            pismanlik5_3_fayda_pl38.Location = pl38k;
            pismanlik5_3_fayda_pl38.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            pismanlik5_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            pismanlik5_3_fayda_pl37.Location = pl37k;
            pismanlik5_3_fayda_pl37.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            pismanlik5_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik5_3_fayda_pl34.Location = pl34k;
            pismanlik5_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            pismanlik5_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik5_3_fayda_pl33.Location = pl33k;
            pismanlik5_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            pismanlik5_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik5_3_fayda_pl32.Location = pl32k;
            pismanlik5_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik5_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik5_3_fayda_pl27.Location = pl27k;
            pismanlik5_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik5_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik5_3_fayda_pl26.Location = pl26k;
            pismanlik5_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik5_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik5_3_fayda_pl23.Location = pl23k;
            pismanlik5_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik5_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik5_3_fayda_pl22.Location = pl22k;
            pismanlik5_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik5_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik5_3_fayda_pl21.Location = pl21k;
            pismanlik5_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik5_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik5_3_fayda_pl20.Location = pl20k;
            pismanlik5_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik5_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik5_3_fayda_pl25.Location = pl25k;
            pismanlik5_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik5_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik5_3_fayda_pl19.Location = pl19k;
            pismanlik5_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik5_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik5_3_fayda_pl18.Location = pl18k;
            pismanlik5_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik5_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik5_3_fayda_pl24.Location = pl24k;
            pismanlik5_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik5_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik5_3_fayda_pl17.Location = pl17k;
            pismanlik5_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik5_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik5_3_fayda_pl16.Location = pl16k;
            pismanlik5_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik5_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            pismanlik5_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            pismanlik5_3_fayda_pl41.Location = pl41k;
            pismanlik5_3_fayda_pl41.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            pismanlik5_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            pismanlik5_3_fayda_pl36.Location = pl36k;
            pismanlik5_3_fayda_pl36.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            pismanlik5_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik5_3_fayda_pl31.Location = pl31k;
            pismanlik5_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik5_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik5_3_fayda_pl15.Location = pl15k;
            pismanlik5_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik5_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik5_3_fayda_pl14.Location = pl14k;
            pismanlik5_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik5_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik5_3_fayda_pl13.Location = pl13k;
            pismanlik5_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik5_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik5_3_fayda_pl12.Location = pl12k;
            pismanlik5_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik5_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl5.Controls.Add(pismanlik5_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik5_3_fayda_pl11.Name = "pl11";
            pismanlik5_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik5_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik5_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik5_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik5_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl11.Click += new EventHandler(pismanlik5_3_fayda_pl11_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik5_3_fayda_pl10.Name = "pl10";
            pismanlik5_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik5_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik5_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik5_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik5_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl10.Click += new EventHandler(pismanlik5_3_fayda_pl10_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik5_3_fayda_pl9.Name = "pl9";
            pismanlik5_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik5_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik5_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik5_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik5_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl9.Click += new EventHandler(pismanlik5_3_fayda_pl9_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik5_3_fayda_pl8.Name = "pl8";
            pismanlik5_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik5_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik5_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik5_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik5_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl8.Click += new EventHandler(pismanlik5_3_fayda_pl8_Click);
            pismanlik5_3_fayda_pl7.Controls.Add(pismanlik5_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik5_3_fayda_pl6.Name = "pl6";
            pismanlik5_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik5_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik5_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik5_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik5_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl6.Click += new EventHandler(pismanlik5_3_fayda_pl6_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik5_3_fayda_btn3.Name = "btn3";
            pismanlik5_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik5_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik5_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik5_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik5_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik5_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_btn3.Click += new EventHandler(pismanlik5_3_fayda_btn3_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik5_3_fayda_btn2.Name = "btn2";
            pismanlik5_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik5_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik5_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik5_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik5_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik5_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik5_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik5_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_btn2.Click += new EventHandler(pismanlik5_3_fayda_btn2_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik5_3_fayda_btn1.Name = "btn1";
            pismanlik5_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik5_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik5_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik5_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik5_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik5_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik5_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik5_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_btn1.Click += new EventHandler(pismanlik5_3_fayda_btn1_Click);
            pismanlik5_3_fayda_pl2.Controls.Add(pismanlik5_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik5_3_fayda_dr1.Name = "dr1";
            pismanlik5_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik5_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik5_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik5_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik5_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik5_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik5_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik5_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik5_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik5_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik5_3_fayda_dr1_CellEnter);
            pismanlik5_3_fayda_tb1_2.Controls.Add(pismanlik5_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik5_3_fayda_pl7.Name = "pl7";
            pismanlik5_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik5_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik5_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_tb1_2.Controls.Add(pismanlik5_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik5_3_fayda_pl5.Name = "pl5";
            pismanlik5_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik5_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik5_3_fayda_pl5.AutoScroll = true;
            pismanlik5_3_fayda_pl5.AutoSize = true;
            pismanlik5_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik5_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_tb1_1.Controls.Add(pismanlik5_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik5_3_fayda_rt1.Name = "rt1";
            pismanlik5_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik5_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik5_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_rt1.Enabled = false;
            pismanlik5_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik5_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik5_3_fayda_tb1_3.Controls.Add(pismanlik5_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik5_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik5_3_fayda_tb1_1.Text = "Tablo";
            pismanlik5_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik5_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_tb1.Controls.Add(pismanlik5_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik5_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik5_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik5_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik5_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_tb1.Controls.Add(pismanlik5_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik5_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik5_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik5_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik5_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_tb1.Controls.Add(pismanlik5_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik5_3_fayda_tb1.Name = "tb1";
            pismanlik5_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik5_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik5_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik5_3_fayda_pl3.Controls.Add(pismanlik5_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik5_3_fayda_pl4.Name = "pl4";
            pismanlik5_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik5_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik5_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik5_3_fayda_pl4_MouseUp);
            pismanlik5_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik5_3_fayda_pl4_MouseMove);
            pismanlik5_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik5_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik5_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik5_3_fayda_pl3.Name = "pl3";
            pismanlik5_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik5_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik5_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik5_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik5_3_fayda_pl2.Name = "pl2";
            pismanlik5_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik5_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik5_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik5_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik5_3_fayda_pl1.Name = "pl1";
            pismanlik5_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik5_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik5_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik5_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik5_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik5_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik5_3_fayda_pl1_MouseUp);
            pismanlik5_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik5_3_fayda_pl1_MouseMove);
            pismanlik5_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik5_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik5_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik6_3_fayda form nesne tasarımları
        public void pismanlik6_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik6_3_fayda_sonuc = new Label();
            pismanlik6_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik6_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik6_3_fayda_sonuc.Location = sonuc;
            pismanlik6_3_fayda_sonuc.Text = "";
            pismanlik6_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik6_3_fayda_pl4.Controls.Add(pismanlik6_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük fayda ismini Label  olarak yerleştirir
            pismanlik6_3_fayda_sonucbaslik = new Label();
            pismanlik6_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik6_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik6_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik6_3_fayda_sonucbaslik.Text = "En Küçük Fayda:";
            pismanlik6_3_fayda_sonucbaslik.Size = new Size(93, 13);
            pismanlik6_3_fayda_pl4.Controls.Add(pismanlik6_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            pismanlik6_3_fayda_sonuclarortabaslik = new Label();
            pismanlik6_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik6_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik6_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik6_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik6_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik6_3_fayda_pl28.Controls.Add(pismanlik6_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel51 içerisine altsonuc Label  olarak yerleştirir
            pismanlik6_3_fayda_altsonucbaslik = new Label();
            pismanlik6_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik6_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik6_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik6_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik6_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik6_3_fayda_pl51.Controls.Add(pismanlik6_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri18 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri18.Location = txt_veri18;
            pismanlik6_3_fayda_txt_veri18.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl49.Controls.Add(pismanlik6_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri17 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri17.Location = txt_veri17;
            pismanlik6_3_fayda_txt_veri17.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl48.Controls.Add(pismanlik6_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri16 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri16.Location = txt_veri16;
            pismanlik6_3_fayda_txt_veri16.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl47.Controls.Add(pismanlik6_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri15 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri15.Location = txt_veri15;
            pismanlik6_3_fayda_txt_veri15.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl44.Controls.Add(pismanlik6_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri14 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri14.Location = txt_veri14;
            pismanlik6_3_fayda_txt_veri14.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl43.Controls.Add(pismanlik6_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri13 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri13.Location = txt_veri13;
            pismanlik6_3_fayda_txt_veri13.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl42.Controls.Add(pismanlik6_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri12 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri12.Location = txt_veri12;
            pismanlik6_3_fayda_txt_veri12.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl39.Controls.Add(pismanlik6_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri11 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri11.Location = txt_veri11;
            pismanlik6_3_fayda_txt_veri11.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl38.Controls.Add(pismanlik6_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri10 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri10.Location = txt_veri10;
            pismanlik6_3_fayda_txt_veri10.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl37.Controls.Add(pismanlik6_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri9 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri9.Location = txt_veri9;
            pismanlik6_3_fayda_txt_veri9.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl34.Controls.Add(pismanlik6_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri8 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri8.Location = txt_veri8;
            pismanlik6_3_fayda_txt_veri8.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl33.Controls.Add(pismanlik6_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri7 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri7.Location = txt_veri7;
            pismanlik6_3_fayda_txt_veri7.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl32.Controls.Add(pismanlik6_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik6_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl27.Controls.Add(pismanlik6_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik6_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl23.Controls.Add(pismanlik6_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik6_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl22.Controls.Add(pismanlik6_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik6_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl26.Controls.Add(pismanlik6_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik6_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl21.Controls.Add(pismanlik6_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik6_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik6_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik6_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik6_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik6_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl20.Controls.Add(pismanlik6_3_fayda_txt_veri1);
            //---------------------------------------------------------------


            //panel54 içerisine yuksekfsonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik6_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik6_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik6_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik6_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl54.Controls.Add(pismanlik6_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel53 içerisine ortafsonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik6_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik6_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik6_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik6_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl53.Controls.Add(pismanlik6_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel52 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik6_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik6_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik6_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik6_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl52.Controls.Add(pismanlik6_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f6sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            pismanlik6_3_fayda_txt_f6sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f6sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl50.Controls.Add(pismanlik6_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f5sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            pismanlik6_3_fayda_txt_f5sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f5sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl45.Controls.Add(pismanlik6_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f4sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            pismanlik6_3_fayda_txt_f4sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f4sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl40.Controls.Add(pismanlik6_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f3sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            pismanlik6_3_fayda_txt_f3sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f3sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl35.Controls.Add(pismanlik6_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik6_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl30.Controls.Add(pismanlik6_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik6_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik6_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik6_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik6_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik6_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik6_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik6_3_fayda_pl29.Controls.Add(pismanlik6_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------        

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik6_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik6_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik6_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik6_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik6_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik6_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik6_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik6_3_fayda_pl24.Controls.Add(pismanlik6_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik6_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik6_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik6_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik6_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik6_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik6_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik6_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik6_3_fayda_pl17.Controls.Add(pismanlik6_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik6_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik6_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik6_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik6_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik6_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik6_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik6_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik6_3_fayda_pl16.Controls.Add(pismanlik6_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik6 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            pismanlik6_3_fayda_txt_altbaslik6.Text = "F6";
            pismanlik6_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik6.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik6.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl46.Controls.Add(pismanlik6_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik5 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            pismanlik6_3_fayda_txt_altbaslik5.Text = "F5";
            pismanlik6_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik5.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik5.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl41.Controls.Add(pismanlik6_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik4 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            pismanlik6_3_fayda_txt_altbaslik4.Text = "F4";
            pismanlik6_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik4.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik4.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl36.Controls.Add(pismanlik6_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik3 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            pismanlik6_3_fayda_txt_altbaslik3.Text = "F3";
            pismanlik6_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik3.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik3.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl31.Controls.Add(pismanlik6_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik6_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik6_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl15.Controls.Add(pismanlik6_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik6_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik6_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik6_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik6_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik6_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik6_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik6_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl14.Controls.Add(pismanlik6_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik6_3_fayda_txt_baslik2 = new TextBox();
            pismanlik6_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik6_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik6_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik6_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik6_3_fayda_txt_baslik2.Multiline = true;
            pismanlik6_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl13.Controls.Add(pismanlik6_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik6_3_fayda_txt_baslik1 = new TextBox();
            pismanlik6_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik6_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik6_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik6_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik6_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik6_3_fayda_txt_baslik1.Multiline = true;
            pismanlik6_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik6_3_fayda_pl12.Controls.Add(pismanlik6_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel54 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik6_3_fayda_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            pismanlik6_3_fayda_pl54.Location = pl54k;
            pismanlik6_3_fayda_pl54.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl54.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik6_3_fayda_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            pismanlik6_3_fayda_pl53.Location = pl53k;
            pismanlik6_3_fayda_pl53.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl53.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik6_3_fayda_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            pismanlik6_3_fayda_pl52.Location = pl52k;
            pismanlik6_3_fayda_pl52.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl52.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl52);
            //-----------------------------------------

            //panel51 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik6_3_fayda_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            pismanlik6_3_fayda_pl51.Location = pl51k;
            pismanlik6_3_fayda_pl51.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl51.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl51);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            pismanlik6_3_fayda_pl50.Location = pl50k;
            pismanlik6_3_fayda_pl50.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            pismanlik6_3_fayda_pl45.Location = pl45k;
            pismanlik6_3_fayda_pl45.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            pismanlik6_3_fayda_pl40.Location = pl40k;
            pismanlik6_3_fayda_pl40.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            pismanlik6_3_fayda_pl35.Location = pl35k;
            pismanlik6_3_fayda_pl35.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik6_3_fayda_pl30.Location = pl30k;
            pismanlik6_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik6_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik6_3_fayda_pl29.Location = pl29k;
            pismanlik6_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik6_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik6_3_fayda_pl28.Location = pl28k;
            pismanlik6_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik6_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            pismanlik6_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            pismanlik6_3_fayda_pl49.Location = pl49k;
            pismanlik6_3_fayda_pl49.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            pismanlik6_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            pismanlik6_3_fayda_pl48.Location = pl48k;
            pismanlik6_3_fayda_pl48.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            pismanlik6_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            pismanlik6_3_fayda_pl47.Location = pl47k;
            pismanlik6_3_fayda_pl47.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            pismanlik6_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            pismanlik6_3_fayda_pl44.Location = pl44k;
            pismanlik6_3_fayda_pl44.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            pismanlik6_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            pismanlik6_3_fayda_pl43.Location = pl43k;
            pismanlik6_3_fayda_pl43.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            pismanlik6_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            pismanlik6_3_fayda_pl42.Location = pl42k;
            pismanlik6_3_fayda_pl42.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            pismanlik6_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            pismanlik6_3_fayda_pl39.Location = pl39k;
            pismanlik6_3_fayda_pl39.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            pismanlik6_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            pismanlik6_3_fayda_pl38.Location = pl38k;
            pismanlik6_3_fayda_pl38.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            pismanlik6_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            pismanlik6_3_fayda_pl37.Location = pl37k;
            pismanlik6_3_fayda_pl37.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            pismanlik6_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik6_3_fayda_pl34.Location = pl34k;
            pismanlik6_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            pismanlik6_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik6_3_fayda_pl33.Location = pl33k;
            pismanlik6_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            pismanlik6_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik6_3_fayda_pl32.Location = pl32k;
            pismanlik6_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik6_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik6_3_fayda_pl27.Location = pl27k;
            pismanlik6_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik6_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik6_3_fayda_pl26.Location = pl26k;
            pismanlik6_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik6_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik6_3_fayda_pl23.Location = pl23k;
            pismanlik6_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik6_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik6_3_fayda_pl22.Location = pl22k;
            pismanlik6_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik6_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik6_3_fayda_pl21.Location = pl21k;
            pismanlik6_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik6_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik6_3_fayda_pl20.Location = pl20k;
            pismanlik6_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik6_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik6_3_fayda_pl25.Location = pl25k;
            pismanlik6_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik6_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik6_3_fayda_pl19.Location = pl19k;
            pismanlik6_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik6_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik6_3_fayda_pl18.Location = pl18k;
            pismanlik6_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik6_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik6_3_fayda_pl24.Location = pl24k;
            pismanlik6_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik6_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik6_3_fayda_pl17.Location = pl17k;
            pismanlik6_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik6_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik6_3_fayda_pl16.Location = pl16k;
            pismanlik6_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik6_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            pismanlik6_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            pismanlik6_3_fayda_pl46.Location = pl46k;
            pismanlik6_3_fayda_pl46.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            pismanlik6_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            pismanlik6_3_fayda_pl41.Location = pl41k;
            pismanlik6_3_fayda_pl41.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            pismanlik6_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            pismanlik6_3_fayda_pl36.Location = pl36k;
            pismanlik6_3_fayda_pl36.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            pismanlik6_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik6_3_fayda_pl31.Location = pl31k;
            pismanlik6_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik6_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik6_3_fayda_pl15.Location = pl15k;
            pismanlik6_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik6_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik6_3_fayda_pl14.Location = pl14k;
            pismanlik6_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik6_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik6_3_fayda_pl13.Location = pl13k;
            pismanlik6_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik6_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik6_3_fayda_pl12.Location = pl12k;
            pismanlik6_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik6_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl5.Controls.Add(pismanlik6_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik6_3_fayda_pl11.Name = "pl11";
            pismanlik6_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik6_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik6_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik6_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik6_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl11.Click += new EventHandler(pismanlik6_3_fayda_pl11_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik6_3_fayda_pl10.Name = "pl10";
            pismanlik6_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik6_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik6_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik6_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik6_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl10.Click += new EventHandler(pismanlik6_3_fayda_pl10_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik6_3_fayda_pl9.Name = "pl9";
            pismanlik6_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik6_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik6_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik6_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik6_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl9.Click += new EventHandler(pismanlik6_3_fayda_pl9_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik6_3_fayda_pl8.Name = "pl8";
            pismanlik6_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik6_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik6_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik6_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik6_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl8.Click += new EventHandler(pismanlik6_3_fayda_pl8_Click);
            pismanlik6_3_fayda_pl7.Controls.Add(pismanlik6_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik6_3_fayda_pl6.Name = "pl6";
            pismanlik6_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik6_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik6_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik6_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik6_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl6.Click += new EventHandler(pismanlik6_3_fayda_pl6_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik6_3_fayda_btn3.Name = "btn3";
            pismanlik6_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik6_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik6_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik6_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik6_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik6_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_btn3.Click += new EventHandler(pismanlik6_3_fayda_btn3_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik6_3_fayda_btn2.Name = "btn2";
            pismanlik6_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik6_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik6_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik6_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik6_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik6_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik6_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik6_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_btn2.Click += new EventHandler(pismanlik6_3_fayda_btn2_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik6_3_fayda_btn1.Name = "btn1";
            pismanlik6_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik6_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik6_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik6_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik6_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik6_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik6_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik6_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_btn1.Click += new EventHandler(pismanlik6_3_fayda_btn1_Click);
            pismanlik6_3_fayda_pl2.Controls.Add(pismanlik6_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik6_3_fayda_dr1.Name = "dr1";
            pismanlik6_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik6_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik6_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik6_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik6_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik6_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik6_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik6_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik6_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik6_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik6_3_fayda_dr1_CellEnter);
            pismanlik6_3_fayda_tb1_2.Controls.Add(pismanlik6_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik6_3_fayda_pl7.Name = "pl7";
            pismanlik6_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik6_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik6_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_tb1_2.Controls.Add(pismanlik6_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik6_3_fayda_pl5.Name = "pl5";
            pismanlik6_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik6_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik6_3_fayda_pl5.AutoScroll = true;
            pismanlik6_3_fayda_pl5.AutoSize = true;
            pismanlik6_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik6_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_tb1_1.Controls.Add(pismanlik6_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik6_3_fayda_rt1.Name = "rt1";
            pismanlik6_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik6_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik6_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_rt1.Enabled = false;
            pismanlik6_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik6_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik6_3_fayda_tb1_3.Controls.Add(pismanlik6_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik6_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik6_3_fayda_tb1_1.Text = "Tablo";
            pismanlik6_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik6_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_tb1.Controls.Add(pismanlik6_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik6_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik6_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik6_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik6_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_tb1.Controls.Add(pismanlik6_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik6_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik6_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik6_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik6_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_tb1.Controls.Add(pismanlik6_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik6_3_fayda_tb1.Name = "tb1";
            pismanlik6_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik6_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik6_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik6_3_fayda_pl3.Controls.Add(pismanlik6_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik6_3_fayda_pl4.Name = "pl4";
            pismanlik6_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik6_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik6_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik6_3_fayda_pl4_MouseUp);
            pismanlik6_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik6_3_fayda_pl4_MouseMove);
            pismanlik6_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik6_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik6_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik6_3_fayda_pl3.Name = "pl3";
            pismanlik6_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik6_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik6_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik6_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik6_3_fayda_pl2.Name = "pl2";
            pismanlik6_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik6_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik6_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik6_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik6_3_fayda_pl1.Name = "pl1";
            pismanlik6_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik6_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik6_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik6_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik6_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik6_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik6_3_fayda_pl1_MouseUp);
            pismanlik6_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik6_3_fayda_pl1_MouseMove);
            pismanlik6_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik6_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik6_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik7_3_fayda form nesne tasarımları
        public void pismanlik7_3_fayda()
        {
            // panel4 içerisine fayda sonucunu Label  olarak yerleştirir
            pismanlik7_3_fayda_sonuc = new Label();
            pismanlik7_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            pismanlik7_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik7_3_fayda_sonuc.Location = sonuc;
            pismanlik7_3_fayda_sonuc.Text = "";
            pismanlik7_3_fayda_sonuc.Size = new Size(650, 13);
            pismanlik7_3_fayda_pl4.Controls.Add(pismanlik7_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük fayda ismini Label  olarak yerleştirir
            pismanlik7_3_fayda_sonucbaslik = new Label();
            pismanlik7_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            pismanlik7_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik7_3_fayda_sonucbaslik.Location = sonucbaslik;
            pismanlik7_3_fayda_sonucbaslik.Text = "En Küçük Fayda:";
            pismanlik7_3_fayda_sonucbaslik.Size = new Size(93, 13);
            pismanlik7_3_fayda_pl4.Controls.Add(pismanlik7_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Min Label  olarak yerleştirir
            pismanlik7_3_fayda_sonuclarortabaslik = new Label();
            pismanlik7_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            pismanlik7_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik7_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            pismanlik7_3_fayda_sonuclarortabaslik.Text = "Minimum";
            pismanlik7_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            pismanlik7_3_fayda_pl28.Controls.Add(pismanlik7_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            // panel56 içerisine altsonuc Label  olarak yerleştirir
            pismanlik7_3_fayda_altsonucbaslik = new Label();
            pismanlik7_3_fayda_altsonucbaslik.Name = "altsonucbaslik";
            Point altsonucbaslik = new Point(57, 10);
            pismanlik7_3_fayda_altsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            pismanlik7_3_fayda_altsonucbaslik.Location = altsonucbaslik;
            pismanlik7_3_fayda_altsonucbaslik.Text = "Maximax";
            pismanlik7_3_fayda_altsonucbaslik.Size = new Size(57, 13);
            pismanlik7_3_fayda_pl56.Controls.Add(pismanlik7_3_fayda_altsonucbaslik);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri21 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri21.Location = txt_veri21;
            pismanlik7_3_fayda_txt_veri21.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl54.Controls.Add(pismanlik7_3_fayda_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri20 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri20.Location = txt_veri20;
            pismanlik7_3_fayda_txt_veri20.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl53.Controls.Add(pismanlik7_3_fayda_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri19 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri19.Location = txt_veri19;
            pismanlik7_3_fayda_txt_veri19.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl52.Controls.Add(pismanlik7_3_fayda_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri18 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri18.Location = txt_veri18;
            pismanlik7_3_fayda_txt_veri18.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl49.Controls.Add(pismanlik7_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri17 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri17.Location = txt_veri17;
            pismanlik7_3_fayda_txt_veri17.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl48.Controls.Add(pismanlik7_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri16 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri16.Location = txt_veri16;
            pismanlik7_3_fayda_txt_veri16.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl47.Controls.Add(pismanlik7_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri15 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri15.Location = txt_veri15;
            pismanlik7_3_fayda_txt_veri15.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl44.Controls.Add(pismanlik7_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri14 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri14.Location = txt_veri14;
            pismanlik7_3_fayda_txt_veri14.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl43.Controls.Add(pismanlik7_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri13 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri13.Location = txt_veri13;
            pismanlik7_3_fayda_txt_veri13.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl42.Controls.Add(pismanlik7_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri12 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri12.Location = txt_veri12;
            pismanlik7_3_fayda_txt_veri12.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl39.Controls.Add(pismanlik7_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri11 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri11.Location = txt_veri11;
            pismanlik7_3_fayda_txt_veri11.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl38.Controls.Add(pismanlik7_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri10 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri10.Location = txt_veri10;
            pismanlik7_3_fayda_txt_veri10.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl37.Controls.Add(pismanlik7_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri9 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri9.Location = txt_veri9;
            pismanlik7_3_fayda_txt_veri9.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl34.Controls.Add(pismanlik7_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri8 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri8.Location = txt_veri8;
            pismanlik7_3_fayda_txt_veri8.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl33.Controls.Add(pismanlik7_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri7 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri7.Location = txt_veri7;
            pismanlik7_3_fayda_txt_veri7.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl32.Controls.Add(pismanlik7_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri6 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri6.Location = txt_veri6;
            pismanlik7_3_fayda_txt_veri6.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl27.Controls.Add(pismanlik7_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri5 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri5.Location = txt_veri5;
            pismanlik7_3_fayda_txt_veri5.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl23.Controls.Add(pismanlik7_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri4 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri4.Location = txt_veri4;
            pismanlik7_3_fayda_txt_veri4.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl22.Controls.Add(pismanlik7_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri3 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri3.Location = txt_veri3;
            pismanlik7_3_fayda_txt_veri3.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl26.Controls.Add(pismanlik7_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri2 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri2.Location = txt_veri2;
            pismanlik7_3_fayda_txt_veri2.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl21.Controls.Add(pismanlik7_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            pismanlik7_3_fayda_txt_veri1 = new NumericUpDown();
            pismanlik7_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            pismanlik7_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            pismanlik7_3_fayda_txt_veri1.Location = txt_veri1;
            pismanlik7_3_fayda_txt_veri1.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl20.Controls.Add(pismanlik7_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel59 içerisine yuksekfsonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_yuksekfsonuc = new TextBox();
            pismanlik7_3_fayda_txt_yuksekfsonuc.Name = "txtyuksekfsonuc";
            Point txt_txtyuksekfsonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_yuksekfsonuc.Location = txt_txtyuksekfsonuc;
            pismanlik7_3_fayda_txt_yuksekfsonuc.Text = "0";
            pismanlik7_3_fayda_txt_yuksekfsonuc.Enabled = false;
            pismanlik7_3_fayda_txt_yuksekfsonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl59.Controls.Add(pismanlik7_3_fayda_txt_yuksekfsonuc);
            //---------------------------------------------------------------

            //panel58 içerisine ortafsonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_ortafsonuc = new TextBox();
            pismanlik7_3_fayda_txt_ortafsonuc.Name = "txtortafsonuc";
            Point txt_txtortafsonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_ortafsonuc.Location = txt_txtortafsonuc;
            pismanlik7_3_fayda_txt_ortafsonuc.Text = "0";
            pismanlik7_3_fayda_txt_ortafsonuc.Enabled = false;
            pismanlik7_3_fayda_txt_ortafsonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl58.Controls.Add(pismanlik7_3_fayda_txt_ortafsonuc);
            //---------------------------------------------------------------

            //panel57 içerisine buyukfsonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_buyukfsonuc = new TextBox();
            pismanlik7_3_fayda_txt_buyukfsonuc.Name = "txtbuyukfsonuc";
            Point txt_txtbuyukfsonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_buyukfsonuc.Location = txt_txtbuyukfsonuc;
            pismanlik7_3_fayda_txt_buyukfsonuc.Text = "0";
            pismanlik7_3_fayda_txt_buyukfsonuc.Enabled = false;
            pismanlik7_3_fayda_txt_buyukfsonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl57.Controls.Add(pismanlik7_3_fayda_txt_buyukfsonuc);
            //---------------------------------------------------------------

            //panel55 içerisine f7sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f7sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f7sonuc.Name = "txtf7sonuc";
            Point txt_txtf7sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f7sonuc.Location = txt_txtf7sonuc;
            pismanlik7_3_fayda_txt_f7sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f7sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f7sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl55.Controls.Add(pismanlik7_3_fayda_txt_f7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f6sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            pismanlik7_3_fayda_txt_f6sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f6sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl50.Controls.Add(pismanlik7_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f5sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            pismanlik7_3_fayda_txt_f5sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f5sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl45.Controls.Add(pismanlik7_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f4sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            pismanlik7_3_fayda_txt_f4sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f4sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl40.Controls.Add(pismanlik7_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f3sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            pismanlik7_3_fayda_txt_f3sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f3sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl35.Controls.Add(pismanlik7_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f2sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            pismanlik7_3_fayda_txt_f2sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f2sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl30.Controls.Add(pismanlik7_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            pismanlik7_3_fayda_txt_f1sonuc = new TextBox();
            pismanlik7_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            pismanlik7_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            pismanlik7_3_fayda_txt_f1sonuc.Text = "0";
            pismanlik7_3_fayda_txt_f1sonuc.Enabled = false;
            pismanlik7_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            pismanlik7_3_fayda_pl29.Controls.Add(pismanlik7_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------          

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            pismanlik7_3_fayda_txt_üstbaslik3 = new TextBox();
            pismanlik7_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            pismanlik7_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            pismanlik7_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            pismanlik7_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_üstbaslik3.MaxLength = 30;
            pismanlik7_3_fayda_txt_üstbaslik3.Multiline = true;
            pismanlik7_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            pismanlik7_3_fayda_pl24.Controls.Add(pismanlik7_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            pismanlik7_3_fayda_txt_üstbaslik2 = new TextBox();
            pismanlik7_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            pismanlik7_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            pismanlik7_3_fayda_txt_üstbaslik2.Text = "Orta";
            pismanlik7_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_üstbaslik2.MaxLength = 30;
            pismanlik7_3_fayda_txt_üstbaslik2.Multiline = true;
            pismanlik7_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            pismanlik7_3_fayda_pl17.Controls.Add(pismanlik7_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            pismanlik7_3_fayda_txt_üstbaslik1 = new TextBox();
            pismanlik7_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            pismanlik7_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            pismanlik7_3_fayda_txt_üstbaslik1.Text = "Büyük";
            pismanlik7_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_üstbaslik1.MaxLength = 30;
            pismanlik7_3_fayda_txt_üstbaslik1.Multiline = true;
            pismanlik7_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            pismanlik7_3_fayda_pl16.Controls.Add(pismanlik7_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik7 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik7.Location = txt_txtaltbaslik7;
            pismanlik7_3_fayda_txt_altbaslik7.Text = "F7";
            pismanlik7_3_fayda_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik7.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik7.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik7.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl51.Controls.Add(pismanlik7_3_fayda_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik6 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            pismanlik7_3_fayda_txt_altbaslik6.Text = "F6";
            pismanlik7_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik6.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik6.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl46.Controls.Add(pismanlik7_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik5 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            pismanlik7_3_fayda_txt_altbaslik5.Text = "F5";
            pismanlik7_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik5.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik5.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl41.Controls.Add(pismanlik7_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik4 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            pismanlik7_3_fayda_txt_altbaslik4.Text = "F4";
            pismanlik7_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik4.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik4.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl36.Controls.Add(pismanlik7_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik3 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            pismanlik7_3_fayda_txt_altbaslik3.Text = "F3";
            pismanlik7_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik3.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik3.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl31.Controls.Add(pismanlik7_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik2 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            pismanlik7_3_fayda_txt_altbaslik2.Text = "F2";
            pismanlik7_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik2.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik2.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl15.Controls.Add(pismanlik7_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            pismanlik7_3_fayda_txt_altbaslik1 = new TextBox();
            pismanlik7_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            pismanlik7_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            pismanlik7_3_fayda_txt_altbaslik1.Text = "F1";
            pismanlik7_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_altbaslik1.MaxLength = 30;
            pismanlik7_3_fayda_txt_altbaslik1.Multiline = true;
            pismanlik7_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl14.Controls.Add(pismanlik7_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            pismanlik7_3_fayda_txt_baslik2 = new TextBox();
            pismanlik7_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            pismanlik7_3_fayda_txt_baslik2.Location = txt_baslik2;
            pismanlik7_3_fayda_txt_baslik2.Text = "Fabrikalar";
            pismanlik7_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_baslik2.MaxLength = 30;
            pismanlik7_3_fayda_txt_baslik2.Multiline = true;
            pismanlik7_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_baslik2.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl13.Controls.Add(pismanlik7_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            pismanlik7_3_fayda_txt_baslik1 = new TextBox();
            pismanlik7_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            pismanlik7_3_fayda_txt_baslik1.Location = txt_baslik1;
            pismanlik7_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            pismanlik7_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pismanlik7_3_fayda_txt_baslik1.MaxLength = 30;
            pismanlik7_3_fayda_txt_baslik1.Multiline = true;
            pismanlik7_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_txt_baslik1.Size = new Size(162, 13);
            pismanlik7_3_fayda_pl12.Controls.Add(pismanlik7_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel59 oluşturuldu  Yüksek fabrika arka planı orta kısım 
            pismanlik7_3_fayda_pl59.Name = "pl59";
            Point pl59k = new Point(373, 354);
            pismanlik7_3_fayda_pl59.Location = pl59k;
            pismanlik7_3_fayda_pl59.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl59.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl59);
            //-----------------------------------------

            //panel58 oluşturuldu  Orta fabrika arka planı orta kısım 
            pismanlik7_3_fayda_pl58.Name = "pl58";
            Point pl58k = new Point(276, 354);
            pismanlik7_3_fayda_pl58.Location = pl58k;
            pismanlik7_3_fayda_pl58.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl58.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl58);
            //-----------------------------------------

            //panel57 oluşturuldu  Büyük fabrika arka planı orta kısım 
            pismanlik7_3_fayda_pl57.Name = "pl57";
            Point pl57k = new Point(179, 354);
            pismanlik7_3_fayda_pl57.Location = pl57k;
            pismanlik7_3_fayda_pl57.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl57.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl57);
            //-----------------------------------------

            //panel56 oluşturuldu  Maksimum isim arka planı orta kısım 
            pismanlik7_3_fayda_pl56.Name = "pl56";
            Point pl56k = new Point(5, 354);
            pismanlik7_3_fayda_pl56.Location = pl56k;
            pismanlik7_3_fayda_pl56.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl56.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl56);
            //-----------------------------------------

            //panel55 oluşturuldu  f7-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            pismanlik7_3_fayda_pl55.Location = pl55k;
            pismanlik7_3_fayda_pl55.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl55.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            pismanlik7_3_fayda_pl50.Location = pl50k;
            pismanlik7_3_fayda_pl50.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            pismanlik7_3_fayda_pl45.Location = pl45k;
            pismanlik7_3_fayda_pl45.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            pismanlik7_3_fayda_pl40.Location = pl40k;
            pismanlik7_3_fayda_pl40.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            pismanlik7_3_fayda_pl35.Location = pl35k;
            pismanlik7_3_fayda_pl35.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            pismanlik7_3_fayda_pl30.Location = pl30k;
            pismanlik7_3_fayda_pl30.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            pismanlik7_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            pismanlik7_3_fayda_pl29.Location = pl29k;
            pismanlik7_3_fayda_pl29.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            pismanlik7_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            pismanlik7_3_fayda_pl28.Location = pl28k;
            pismanlik7_3_fayda_pl28.Size = new Size(91, 72);
            pismanlik7_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            pismanlik7_3_fayda_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            pismanlik7_3_fayda_pl54.Location = pl54k;
            pismanlik7_3_fayda_pl54.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl54.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            pismanlik7_3_fayda_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            pismanlik7_3_fayda_pl53.Location = pl53k;
            pismanlik7_3_fayda_pl53.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl53.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            pismanlik7_3_fayda_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            pismanlik7_3_fayda_pl52.Location = pl52k;
            pismanlik7_3_fayda_pl52.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl52.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            pismanlik7_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            pismanlik7_3_fayda_pl49.Location = pl49k;
            pismanlik7_3_fayda_pl49.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            pismanlik7_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            pismanlik7_3_fayda_pl48.Location = pl48k;
            pismanlik7_3_fayda_pl48.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            pismanlik7_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            pismanlik7_3_fayda_pl47.Location = pl47k;
            pismanlik7_3_fayda_pl47.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            pismanlik7_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            pismanlik7_3_fayda_pl44.Location = pl44k;
            pismanlik7_3_fayda_pl44.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            pismanlik7_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            pismanlik7_3_fayda_pl43.Location = pl43k;
            pismanlik7_3_fayda_pl43.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            pismanlik7_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            pismanlik7_3_fayda_pl42.Location = pl42k;
            pismanlik7_3_fayda_pl42.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            pismanlik7_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            pismanlik7_3_fayda_pl39.Location = pl39k;
            pismanlik7_3_fayda_pl39.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            pismanlik7_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            pismanlik7_3_fayda_pl38.Location = pl38k;
            pismanlik7_3_fayda_pl38.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            pismanlik7_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            pismanlik7_3_fayda_pl37.Location = pl37k;
            pismanlik7_3_fayda_pl37.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            pismanlik7_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            pismanlik7_3_fayda_pl34.Location = pl34k;
            pismanlik7_3_fayda_pl34.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            pismanlik7_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            pismanlik7_3_fayda_pl33.Location = pl33k;
            pismanlik7_3_fayda_pl33.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            pismanlik7_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            pismanlik7_3_fayda_pl32.Location = pl32k;
            pismanlik7_3_fayda_pl32.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            pismanlik7_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            pismanlik7_3_fayda_pl27.Location = pl27k;
            pismanlik7_3_fayda_pl27.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            pismanlik7_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            pismanlik7_3_fayda_pl26.Location = pl26k;
            pismanlik7_3_fayda_pl26.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            pismanlik7_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            pismanlik7_3_fayda_pl23.Location = pl23k;
            pismanlik7_3_fayda_pl23.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            pismanlik7_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            pismanlik7_3_fayda_pl22.Location = pl22k;
            pismanlik7_3_fayda_pl22.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            pismanlik7_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            pismanlik7_3_fayda_pl21.Location = pl21k;
            pismanlik7_3_fayda_pl21.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            pismanlik7_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            pismanlik7_3_fayda_pl20.Location = pl20k;
            pismanlik7_3_fayda_pl20.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            pismanlik7_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            pismanlik7_3_fayda_pl25.Location = pl25k;
            pismanlik7_3_fayda_pl25.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            pismanlik7_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            pismanlik7_3_fayda_pl19.Location = pl19k;
            pismanlik7_3_fayda_pl19.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            pismanlik7_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            pismanlik7_3_fayda_pl18.Location = pl18k;
            pismanlik7_3_fayda_pl18.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            pismanlik7_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            pismanlik7_3_fayda_pl24.Location = pl24k;
            pismanlik7_3_fayda_pl24.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            pismanlik7_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            pismanlik7_3_fayda_pl17.Location = pl17k;
            pismanlik7_3_fayda_pl17.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            pismanlik7_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            pismanlik7_3_fayda_pl16.Location = pl16k;
            pismanlik7_3_fayda_pl16.Size = new Size(91, 33);
            pismanlik7_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            pismanlik7_3_fayda_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            pismanlik7_3_fayda_pl51.Location = pl51k;
            pismanlik7_3_fayda_pl51.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl51.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            pismanlik7_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            pismanlik7_3_fayda_pl46.Location = pl46k;
            pismanlik7_3_fayda_pl46.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            pismanlik7_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            pismanlik7_3_fayda_pl41.Location = pl41k;
            pismanlik7_3_fayda_pl41.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            pismanlik7_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            pismanlik7_3_fayda_pl36.Location = pl36k;
            pismanlik7_3_fayda_pl36.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            pismanlik7_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            pismanlik7_3_fayda_pl31.Location = pl31k;
            pismanlik7_3_fayda_pl31.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            pismanlik7_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            pismanlik7_3_fayda_pl15.Location = pl15k;
            pismanlik7_3_fayda_pl15.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            pismanlik7_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            pismanlik7_3_fayda_pl14.Location = pl14k;
            pismanlik7_3_fayda_pl14.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            pismanlik7_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            pismanlik7_3_fayda_pl13.Location = pl13k;
            pismanlik7_3_fayda_pl13.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            pismanlik7_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            pismanlik7_3_fayda_pl12.Location = pl12k;
            pismanlik7_3_fayda_pl12.Size = new Size(168, 33);
            pismanlik7_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl5.Controls.Add(pismanlik7_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            pismanlik7_3_fayda_pl11.Name = "pl11";
            pismanlik7_3_fayda_pl11.Size = new Size(65, 50);
            pismanlik7_3_fayda_pl11.Dock = DockStyle.Left;
            pismanlik7_3_fayda_pl11.BackColor = Color.Transparent;
            pismanlik7_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            pismanlik7_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl11.Click += new EventHandler(pismanlik7_3_fayda_pl11_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            pismanlik7_3_fayda_pl10.Name = "pl10";
            pismanlik7_3_fayda_pl10.Size = new Size(65, 50);
            pismanlik7_3_fayda_pl10.Dock = DockStyle.Right;
            pismanlik7_3_fayda_pl10.BackColor = Color.Transparent;
            pismanlik7_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            pismanlik7_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl10.Click += new EventHandler(pismanlik7_3_fayda_pl10_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            pismanlik7_3_fayda_pl9.Name = "pl9";
            pismanlik7_3_fayda_pl9.Size = new Size(65, 50);
            pismanlik7_3_fayda_pl9.Dock = DockStyle.Right;
            pismanlik7_3_fayda_pl9.BackColor = Color.Transparent;
            pismanlik7_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            pismanlik7_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl9.Click += new EventHandler(pismanlik7_3_fayda_pl9_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            pismanlik7_3_fayda_pl8.Name = "pl8";
            pismanlik7_3_fayda_pl8.Size = new Size(65, 50);
            pismanlik7_3_fayda_pl8.Dock = DockStyle.Right;
            pismanlik7_3_fayda_pl8.BackColor = Color.Transparent;
            pismanlik7_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            pismanlik7_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl8.Click += new EventHandler(pismanlik7_3_fayda_pl8_Click);
            pismanlik7_3_fayda_pl7.Controls.Add(pismanlik7_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            pismanlik7_3_fayda_pl6.Name = "pl6";
            pismanlik7_3_fayda_pl6.Size = new Size(65, 50);
            pismanlik7_3_fayda_pl6.Dock = DockStyle.Right;
            pismanlik7_3_fayda_pl6.BackColor = Color.Transparent;
            pismanlik7_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            pismanlik7_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl6.Click += new EventHandler(pismanlik7_3_fayda_pl6_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            pismanlik7_3_fayda_btn3.Name = "btn3";
            pismanlik7_3_fayda_btn3.Size = new Size(65, 50);
            pismanlik7_3_fayda_btn3.Dock = DockStyle.Right;
            pismanlik7_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            pismanlik7_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_btn3.BackColor = Color.Transparent;
            pismanlik7_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            pismanlik7_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_btn3.Click += new EventHandler(pismanlik7_3_fayda_btn3_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            pismanlik7_3_fayda_btn2.Name = "btn2";
            pismanlik7_3_fayda_btn2.Size = new Size(65, 50);
            pismanlik7_3_fayda_btn2.Dock = DockStyle.Right;
            pismanlik7_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            pismanlik7_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik7_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik7_3_fayda_btn2.BackColor = Color.Transparent;
            pismanlik7_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            pismanlik7_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_btn2.Click += new EventHandler(pismanlik7_3_fayda_btn2_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            pismanlik7_3_fayda_btn1.Name = "btn1";
            pismanlik7_3_fayda_btn1.Size = new Size(65, 50);
            pismanlik7_3_fayda_btn1.Dock = DockStyle.Right;
            pismanlik7_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            pismanlik7_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            pismanlik7_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            pismanlik7_3_fayda_btn1.BackColor = Color.Transparent;
            pismanlik7_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            pismanlik7_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_btn1.Click += new EventHandler(pismanlik7_3_fayda_btn1_Click);
            pismanlik7_3_fayda_pl2.Controls.Add(pismanlik7_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            pismanlik7_3_fayda_dr1.Name = "dr1";
            pismanlik7_3_fayda_dr1.Size = new Size(851, 498);
            pismanlik7_3_fayda_dr1.Dock = DockStyle.Fill;
            pismanlik7_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_dr1.AllowUserToAddRows = false;
            pismanlik7_3_fayda_dr1.AllowUserToDeleteRows = false;
            pismanlik7_3_fayda_dr1.AllowUserToResizeColumns = false;
            pismanlik7_3_fayda_dr1.AllowUserToResizeRows = false;
            pismanlik7_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pismanlik7_3_fayda_dr1.RowHeadersVisible = false;
            pismanlik7_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pismanlik7_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(pismanlik7_3_fayda_dr1_CellEnter);
            pismanlik7_3_fayda_tb1_2.Controls.Add(pismanlik7_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            pismanlik7_3_fayda_pl7.Name = "pl7";
            pismanlik7_3_fayda_pl7.Size = new Size(865, 50);
            pismanlik7_3_fayda_pl7.Dock = DockStyle.Top;
            pismanlik7_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_tb1_2.Controls.Add(pismanlik7_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            pismanlik7_3_fayda_pl5.Name = "pl5";
            pismanlik7_3_fayda_pl5.Size = new Size(851, 498);
            pismanlik7_3_fayda_pl5.Dock = DockStyle.Fill;
            pismanlik7_3_fayda_pl5.AutoScroll = true;
            pismanlik7_3_fayda_pl5.AutoSize = true;
            pismanlik7_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            pismanlik7_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_tb1_1.Controls.Add(pismanlik7_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            pismanlik7_3_fayda_rt1.Name = "rt1";
            pismanlik7_3_fayda_rt1.Size = new Size(851, 498);
            pismanlik7_3_fayda_rt1.Dock = DockStyle.Fill;
            pismanlik7_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_rt1.Enabled = false;
            pismanlik7_3_fayda_rt1.Text = "•En kötü (en büyük) pişmanlığı en küçük olan seçenek seçilir.\n•Faydaya Göre Fabrika Ve Büyüklükleri Arasından En Küçüğü Seçilir.";
            pismanlik7_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pismanlik7_3_fayda_tb1_3.Controls.Add(pismanlik7_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            pismanlik7_3_fayda_tb1_1.Name = "tb1_1";
            pismanlik7_3_fayda_tb1_1.Text = "Tablo";
            pismanlik7_3_fayda_tb1_1.Size = new Size(651, 50);
            pismanlik7_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_tb1.Controls.Add(pismanlik7_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            pismanlik7_3_fayda_tb1_2.Name = "tb1_2";
            pismanlik7_3_fayda_tb1_2.Text = "Veri Tabanı";
            pismanlik7_3_fayda_tb1_2.Size = new Size(651, 50);
            pismanlik7_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_tb1.Controls.Add(pismanlik7_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            pismanlik7_3_fayda_tb1_3.Name = "tb1_3";
            pismanlik7_3_fayda_tb1_3.Text = "Konu Anlatımı";
            pismanlik7_3_fayda_tb1_3.Size = new Size(651, 50);
            pismanlik7_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_tb1.Controls.Add(pismanlik7_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            pismanlik7_3_fayda_tb1.Name = "tb1";
            pismanlik7_3_fayda_tb1.Size = new Size(651, 50);
            pismanlik7_3_fayda_tb1.Dock = DockStyle.Fill;
            pismanlik7_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            pismanlik7_3_fayda_pl3.Controls.Add(pismanlik7_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            pismanlik7_3_fayda_pl4.Name = "pl4";
            pismanlik7_3_fayda_pl4.Size = new Size(865, 50);
            pismanlik7_3_fayda_pl4.Dock = DockStyle.Bottom;
            pismanlik7_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl4.MouseUp += new MouseEventHandler(pismanlik7_3_fayda_pl4_MouseUp);
            pismanlik7_3_fayda_pl4.MouseMove += new MouseEventHandler(pismanlik7_3_fayda_pl4_MouseMove);
            pismanlik7_3_fayda_pl4.MouseDown += new MouseEventHandler(pismanlik7_3_fayda_pl4_MouseDown);
            this.Controls.Add(pismanlik7_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            pismanlik7_3_fayda_pl3.Name = "pl3";
            pismanlik7_3_fayda_pl3.Size = new Size(865, 530);
            pismanlik7_3_fayda_pl3.Dock = DockStyle.Top;
            pismanlik7_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik7_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            pismanlik7_3_fayda_pl2.Name = "pl2";
            pismanlik7_3_fayda_pl2.Size = new Size(865, 50);
            pismanlik7_3_fayda_pl2.Dock = DockStyle.Top;
            pismanlik7_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(pismanlik7_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            pismanlik7_3_fayda_pl1.Name = "pl1";
            pismanlik7_3_fayda_pl1.Size = new Size(865, 50);
            pismanlik7_3_fayda_pl1.Dock = DockStyle.Top;
            pismanlik7_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            pismanlik7_3_fayda_pl1.BackgroundImage = Properties.Resources.pismanlikfayda;
            pismanlik7_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            pismanlik7_3_fayda_pl1.MouseUp += new MouseEventHandler(pismanlik7_3_fayda_pl1_MouseUp);
            pismanlik7_3_fayda_pl1.MouseMove += new MouseEventHandler(pismanlik7_3_fayda_pl1_MouseMove);
            pismanlik7_3_fayda_pl1.MouseDown += new MouseEventHandler(pismanlik7_3_fayda_pl1_MouseDown);
            this.Controls.Add(pismanlik7_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //pismanlik2_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik2_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik2_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik2_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 19; i++)
            {
                pismanlik2_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik3_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik3_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik3_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik3_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 24; i++)
            {
                pismanlik3_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik4_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik4_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik4_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik4_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 29; i++)
            {
                pismanlik4_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik5_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik5_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik5_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik5_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 34; i++)
            {
                pismanlik5_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik6_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik6_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik6_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik6_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 39; i++)
            {
                pismanlik6_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik7_3_fayda veritabanına listelemek için kullanılır
        public void pismanlik7_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From pismanlik7_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            pismanlik7_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 44; i++)
            {
                pismanlik7_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //pismanlik2_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik2_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik2_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik2_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik2_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik2_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik2_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik2_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik2_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik2_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik2_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik2_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik2_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik2_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik2_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik2_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik2_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik2_3_fayda_pl4.Controls["sonuc"].Text = pismanlik2_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik2_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik2_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik2_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik2_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik2_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik2_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik2_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik2_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text))
                {
                    pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text))
                {
                    pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı              
                if (Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı              
                if (Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------

                ////hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text);
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
                string sorgu = "Insert into pismanlik2_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,sonuc_1,sonuc_2,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@sonuc_1,@sonuc_2,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik2_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik2_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik2_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik2_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik2_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik2_3_fayda_sonuclarortabaslik.Text;

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altsonucbaslik.Value2 = pismanlik2_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut19 = new OleDbCommand("Select D1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                d1.Value2 = komut19.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select D2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                d2.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select D3 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                d3.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut22 = new OleDbCommand("Select fayda From pismanlik2_3_fayda where Id=" + pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                fayda.Value2 = komut22.ExecuteScalar().ToString();
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

        //pismanlik2_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik2_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text))
                {
                    pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text))
                {
                    pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı              
                if (Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı              
                if (Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------

                ////hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik2_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik2_3_fayda_pl32.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik2_3_fayda_pl33.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik2_3_fayda_pl34.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                komut.Parameters.AddWithValue("@Id", id.ToString());

                pismanlik2_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik2_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik2_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik2_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik2_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik2_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik2_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik2_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //pismanlik3_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik3_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik3_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik3_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik3_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik3_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik3_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik3_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik3_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik3_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik3_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik3_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik3_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik3_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik3_3_fayda_pl31.Controls["txtaltbaslik3"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik3_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik3_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik3_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                pismanlik3_3_fayda_pl4.Controls["sonuc"].Text = pismanlik3_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik3_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik3_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik3_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik3_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik3_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik3_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik3_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik3_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------           
                //hesaplama -2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text);
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
                string sorgu = "Insert into pismanlik3_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,sonuc_1,sonuc_2,sonuc_3,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@sonuc_1,@sonuc_2,@sonuc_3,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik3_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik3_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik3_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik3_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik3_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik3_3_fayda_sonuclarortabaslik.Text;

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altsonucbaslik.Value2 = pismanlik3_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut25 = new OleDbCommand("Select D1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                d1.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select D2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                d2.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select D3 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                d3.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select fayda From pismanlik3_3_fayda where Id=" + pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                fayda.Value2 = komut19.ExecuteScalar().ToString();
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

        //pismanlik3_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik3_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text))
                {
                    pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------           
                //hesaplama -2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik3_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik3_3_fayda_pl37.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik3_3_fayda_pl38.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik3_3_fayda_pl39.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik3_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik3_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik3_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik3_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik3_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik3_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik3_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik3_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //pismanlik4_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik4_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik4_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik4_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik4_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik4_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik4_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik4_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik4_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik4_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik4_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik4_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik4_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik4_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik4_3_fayda_pl31.Controls["txtaltbaslik3"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik4_3_fayda_pl36.Controls["txtaltbaslik4"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik4_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik4_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik4_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                pismanlik4_3_fayda_pl4.Controls["sonuc"].Text = pismanlik4_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik4_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik4_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik4_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik4_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik4_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik4_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik4_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik4_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text);
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
                string sorgu = "Insert into pismanlik4_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,sonuc_1,sonuc_2,sonuc_3,sonuc_4,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik4_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik4_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik4_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik4_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik4_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik4_3_fayda_sonuclarortabaslik.Text;

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altsonucbaslik.Value2 = pismanlik4_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut30 = new OleDbCommand("Select D1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                d1.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select D2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                d2.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select D3 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                d3.Value2 = komut32.ExecuteScalar().ToString();


                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select fayda From pismanlik4_3_fayda where Id=" + pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                fayda.Value2 = komut19.ExecuteScalar().ToString();
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

        //pismanlik4_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik4_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text))
                {
                    pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------

                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik4_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik4_3_fayda_pl42.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik4_3_fayda_pl43.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik4_3_fayda_pl44.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik4_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik4_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik4_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik4_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik4_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik4_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik4_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik4_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //pismanlik5_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik5_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik5_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik5_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik5_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik5_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik5_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik5_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik5_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik5_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik5_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik5_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik5_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik5_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik5_3_fayda_pl31.Controls["txtaltbaslik3"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik5_3_fayda_pl36.Controls["txtaltbaslik4"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik5_3_fayda_pl41.Controls["txtaltbaslik5"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik5_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik5_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik5_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                pismanlik5_3_fayda_pl4.Controls["sonuc"].Text = pismanlik5_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik5_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik5_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik5_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik5_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik5_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik5_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik5_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik5_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text);
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
                string sorgu = "Insert into pismanlik5_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik5_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik5_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik5_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik5_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik5_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik5_3_fayda_sonuclarortabaslik.Text;


                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altsonucbaslik.Value2 = pismanlik5_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut35 = new OleDbCommand("Select D1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                d1.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select D2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                d2.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select D3 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                d3.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select fayda From pismanlik5_3_fayda where Id=" + pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                fayda.Value2 = komut19.ExecuteScalar().ToString();
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

        //pismanlik5_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik5_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text))
                {
                    pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik5_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik5_3_fayda_pl47.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik5_3_fayda_pl48.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik5_3_fayda_pl49.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik5_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik5_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik5_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik5_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik5_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik5_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik5_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik5_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //pismanlik6_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik6_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik6_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik6_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik6_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik6_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik6_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik6_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik6_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik6_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik6_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik6_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik6_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik6_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik6_3_fayda_pl31.Controls["txtaltbaslik3"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik6_3_fayda_pl36.Controls["txtaltbaslik4"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik6_3_fayda_pl41.Controls["txtaltbaslik5"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik6_3_fayda_pl46.Controls["txtaltbaslik6"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik6_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik6_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik6_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                pismanlik6_3_fayda_pl4.Controls["sonuc"].Text = pismanlik6_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik6_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik6_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik6_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik6_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik6_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik6_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik6_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik6_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //-------------------------------------------- 

                //f6sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text);
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
                string sorgu = "Insert into pismanlik6_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", pismanlik6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik6_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik6_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik6_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik6_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik6_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik6_3_fayda_sonuclarortabaslik.Text;

                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altsonucbaslik.Value2 = pismanlik6_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut40 = new OleDbCommand("Select D1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                d1.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select D2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                d2.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select D3 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                d3.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select fayda From pismanlik6_3_fayda where Id=" + pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                fayda.Value2 = komut19.ExecuteScalar().ToString();
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

        //pismanlik6_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik6_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text))
                {
                    pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //-------------------------------------------- 

                //f6sonuc kısmı
                if (Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik6_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", pismanlik6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", pismanlik6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", pismanlik6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", pismanlik6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", pismanlik6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik6_3_fayda_pl52.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik6_3_fayda_pl53.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik6_3_fayda_pl54.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik6_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik6_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik6_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik6_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik6_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik6_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik6_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik6_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //pismanlik7_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik7_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik7_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik7_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik7_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void pismanlik7_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void pismanlik7_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void pismanlik7_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //pismanlik7_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void pismanlik7_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pismanlik7_3_fayda_pl12.Controls["txtbaslik1"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                pismanlik7_3_fayda_pl13.Controls["txtbaslik2"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                pismanlik7_3_fayda_pl14.Controls["txtaltbaslik1"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                pismanlik7_3_fayda_pl15.Controls["txtaltbaslik2"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                pismanlik7_3_fayda_pl31.Controls["txtaltbaslik3"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                pismanlik7_3_fayda_pl36.Controls["txtaltbaslik4"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                pismanlik7_3_fayda_pl41.Controls["txtaltbaslik5"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                pismanlik7_3_fayda_pl46.Controls["txtaltbaslik6"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                pismanlik7_3_fayda_pl51.Controls["txtaltbaslik7"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                pismanlik7_3_fayda_pl16.Controls["txtüstbaslik1"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                pismanlik7_3_fayda_pl17.Controls["txtüstbaslik2"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                pismanlik7_3_fayda_pl24.Controls["txtüstbaslik3"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
                pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[40].Value.ToString();
                pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[41].Value.ToString();
                pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[42].Value.ToString();
                pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[43].Value.ToString();
                pismanlik7_3_fayda_pl4.Controls["sonuc"].Text = pismanlik7_3_fayda_dr1.CurrentRow.Cells[44].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //pismanlik7_3_fayda formu kapatmak için oluşturulmuş button1
        private void pismanlik7_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //pismanlik7_3_fayda formu altaalmak için oluşturulmuş button2
        private void pismanlik7_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //pismanlik7_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void pismanlik7_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //pismanlik7_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void pismanlik7_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text)) ).ToString();
                pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text)) ).ToString();
                pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text)) ).ToString();
                pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //-------------------------------------------- 

                //f6sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------          

                //f7sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text);
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
                string sorgu = "Insert into pismanlik7_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,sonuc_7,D1,D2,D3,fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@sonuc_7,@D1,@D2,@D3,@fayda)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@baslik_1", pismanlik7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", pismanlik7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_7", pismanlik7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_19", pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_20", pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_21", pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_7", pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik7_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                pismanlik7_3_fayda_listele();
                MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik7_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void pismanlik7_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //pismanlik7_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Pişmanlık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = pismanlik7_3_fayda_sonuclarortabaslik.Text;


                for (int i = 1; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(241, 229, 192);
                }

                Microsoft.Office.Interop.Excel.Range altsonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                altsonucbaslik.Value2 = pismanlik7_3_fayda_altsonucbaslik.Text;

                OleDbCommand komut45 = new OleDbCommand("Select D1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 2];
                d1.Value2 = komut45.ExecuteScalar().ToString();

                OleDbCommand komut46 = new OleDbCommand("Select D2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                d2.Value2 = komut46.ExecuteScalar().ToString();

                OleDbCommand komut47 = new OleDbCommand("Select D3 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range d3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 4];
                d3.Value2 = komut47.ExecuteScalar().ToString();

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select sonuc_7 From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 5];
                sonuc7.Value2 = komut44.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 1];
                alan1.Value2 = "En Küçük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select fayda From pismanlik7_3_fayda where Id=" + pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 3];
                fayda.Value2 = komut19.ExecuteScalar().ToString();
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

        //pismanlik7_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void pismanlik7_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                //D1 sonuc kısmı             
                if (Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text).ToString();
                }
                //--------------------------------------------
                //D2 sonuc kısmı               
                if (Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text))
                {
                    pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text).ToString();
                }
                //--------------------------------------------
                //D3 sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text).ToString();
                }
                //--------------------------------------------

                //hesaplama-1          
                double buyuksonuc = Convert.ToDouble(pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text);
                double ortasonuc = Convert.ToDouble(pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text);
                double yukseksonuc = Convert.ToDouble(pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text);
                //buyuksonuc kısmı
                pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text)) ).ToString();
                pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text)) ).ToString();
                pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text)) ).ToString();
                pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text)) ).ToString();
                pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text)) ).ToString();
                pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text)) ).ToString();
                pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text = ((Convert.ToInt32(buyuksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text)) ).ToString();
                //-------------------------------
                //ortasonuc kısmı
                pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text)) ).ToString();
                pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text)) ).ToString();
                pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text)) ).ToString();
                pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text)) ).ToString();
                pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text)) ).ToString();
                pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text)) ).ToString();
                pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text = ((Convert.ToInt32(ortasonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text)) ).ToString();
                //-------------------------------
                //yukseksonuc kısmı
                pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text)) ).ToString();
                pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text)) ).ToString();
                pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text)) ).ToString();
                pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text)) ).ToString();
                pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text)) ).ToString();
                pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text)) ).ToString();
                pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text = ((Convert.ToInt32(yukseksonuc) - Convert.ToInt32(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text)) ).ToString();
                //-------------------------------
                //---------------------------------------


                //f1sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text))
                {
                    pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text).ToString();
                }
                //--------------------------------------------
                //f2sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text))
                {
                    pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text).ToString();
                }
                //--------------------------------------------
                //f3sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text))
                {
                    pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text).ToString();
                }
                //--------------------------------------------      
                //f4sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text))
                {
                    pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text).ToString();
                }
                //--------------------------------------------          
                //f5sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text))
                {
                    pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text).ToString();
                }
                //-------------------------------------------- 

                //f6sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text))
                {
                    pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text).ToString();
                }
                //--------------------------------------------          

                //f7sonuc kısmı
                if (Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text).ToString();
                }
                else if (Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text) && Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text) > Convert.ToDouble(pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text))
                {
                    pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text = Convert.ToDouble(pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text).ToString();
                }
                //--------------------------------------------          
                //hesaplama-2
                double kucukolanibul = 0;
                double f1sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text);
                double f2sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text);
                double f3sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text);
                double f4sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text);
                double f5sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text);
                double f6sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text);
                double f7sonuc = Convert.ToDouble(pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text);
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
                komut = new OleDbCommand("UPDATE pismanlik7_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,sonuc_7=@sonuc_7,D1=@D1,D2=@D2,D3=@D3,fayda=@fayda WHERE Id=@Id", baglanti);

                komut.Parameters.AddWithValue("@baslik_1", pismanlik7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@baslik_2", pismanlik7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_1", pismanlik7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_2", pismanlik7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_3", pismanlik7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_4", pismanlik7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_5", pismanlik7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_6", pismanlik7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                komut.Parameters.AddWithValue("@altbaslik_7", pismanlik7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_1", pismanlik7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_2", pismanlik7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                komut.Parameters.AddWithValue("@ustbaslik_3", pismanlik7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_1", pismanlik7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_2", pismanlik7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_3", pismanlik7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_4", pismanlik7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_5", pismanlik7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_6", pismanlik7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_7", pismanlik7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_8", pismanlik7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_9", pismanlik7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_10", pismanlik7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_11", pismanlik7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_12", pismanlik7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_13", pismanlik7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_14", pismanlik7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_15", pismanlik7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_16", pismanlik7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_17", pismanlik7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_18", pismanlik7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_19", pismanlik7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_20", pismanlik7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                komut.Parameters.AddWithValue("@veri_21", pismanlik7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_1", pismanlik7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_2", pismanlik7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_3", pismanlik7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_4", pismanlik7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_5", pismanlik7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_6", pismanlik7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@sonuc_7", pismanlik7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D1", pismanlik7_3_fayda_pl57.Controls["txtbuyukfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D2", pismanlik7_3_fayda_pl58.Controls["txtortafsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@D3", pismanlik7_3_fayda_pl59.Controls["txtyuksekfsonuc"].Text.ToString());
                komut.Parameters.AddWithValue("@fayda", kucukolanibul.ToString());
                pismanlik7_3_fayda_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                komut.Parameters.AddWithValue("@Id", id.ToString());

                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                tablo.Clear();
                pismanlik7_3_fayda_listele();
                MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //pismanlik7_3_fayda silme yapmak için oluşturulmuş panel10
        private void pismanlik7_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = pismanlik7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from pismanlik7_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            pismanlik7_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //pismanlik7_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void pismanlik7_3_fayda_pl11_Click(object sender, EventArgs e)
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


        private void BelirsizlikAltındaPismanlikFayda_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                pismanlik2_3_fayda();
                pismanlik2_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                pismanlik3_3_fayda();
                pismanlik3_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                pismanlik4_3_fayda();
                pismanlik4_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                pismanlik5_3_fayda();
                pismanlik5_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                pismanlik6_3_fayda();
                pismanlik6_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                pismanlik7_3_fayda();
                pismanlik7_3_fayda_listele();
            }
        }
    }
}
