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
    public partial class BelirsizlikAltındaHurwiczMaliyet : Form
    {
        public BelirsizlikAltındaHurwiczMaliyet()
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

        //Hurwicz2_3_maliyet form nesneleri
        Panel Hurwicz2_3_maliyet_pl1 = new Panel();
        Panel Hurwicz2_3_maliyet_pl2 = new Panel();
        Panel Hurwicz2_3_maliyet_pl3 = new Panel();
        Panel Hurwicz2_3_maliyet_pl4 = new Panel();
        Panel Hurwicz2_3_maliyet_pl5 = new Panel();
        Panel Hurwicz2_3_maliyet_pl6 = new Panel();
        Panel Hurwicz2_3_maliyet_pl7 = new Panel();
        Panel Hurwicz2_3_maliyet_pl8 = new Panel();
        Panel Hurwicz2_3_maliyet_pl9 = new Panel();
        Panel Hurwicz2_3_maliyet_pl10 = new Panel();
        Panel Hurwicz2_3_maliyet_pl11 = new Panel();
        Panel Hurwicz2_3_maliyet_pl12 = new Panel();
        Panel Hurwicz2_3_maliyet_pl13 = new Panel();
        Panel Hurwicz2_3_maliyet_pl14 = new Panel();
        Panel Hurwicz2_3_maliyet_pl15 = new Panel();
        Panel Hurwicz2_3_maliyet_pl16 = new Panel();
        Panel Hurwicz2_3_maliyet_pl17 = new Panel();
        Panel Hurwicz2_3_maliyet_pl18 = new Panel();
        Panel Hurwicz2_3_maliyet_pl19 = new Panel();
        Panel Hurwicz2_3_maliyet_pl20 = new Panel();
        Panel Hurwicz2_3_maliyet_pl21 = new Panel();
        Panel Hurwicz2_3_maliyet_pl22 = new Panel();
        Panel Hurwicz2_3_maliyet_pl23 = new Panel();
        Panel Hurwicz2_3_maliyet_pl24 = new Panel();
        Panel Hurwicz2_3_maliyet_pl25 = new Panel();
        Panel Hurwicz2_3_maliyet_pl26 = new Panel();
        Panel Hurwicz2_3_maliyet_pl27 = new Panel();
        Panel Hurwicz2_3_maliyet_pl28 = new Panel();
        Panel Hurwicz2_3_maliyet_pl29 = new Panel();
        Panel Hurwicz2_3_maliyet_pl30 = new Panel();
        Panel Hurwicz2_3_maliyet_pl31 = new Panel();
        Panel Hurwicz2_3_maliyet_pl32 = new Panel();
        Panel Hurwicz2_3_maliyet_pl33 = new Panel();
        Panel Hurwicz2_3_maliyet_pl34 = new Panel();
        Panel Hurwicz2_3_maliyet_pl35 = new Panel();
        Panel Hurwicz2_3_maliyet_pl36 = new Panel();
        TabControl Hurwicz2_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz2_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz2_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz2_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz2_3_maliyet_txt_baslik1;
        TextBox Hurwicz2_3_maliyet_txt_baslik2;
        TextBox Hurwicz2_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz2_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz2_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz2_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz2_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz2_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz2_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz2_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz2_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz2_3_maliyet_txt_altoran1;
        TextBox Hurwicz2_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz2_3_maliyet_txt_veri6;
        Label Hurwicz2_3_maliyet_sonucbaslik;
        Label Hurwicz2_3_maliyet_sonuc;
        Label Hurwicz2_3_maliyet_Maxsonucbaslik;
        Label Hurwicz2_3_maliyet_Minsonucbaslik;
        Label Hurwicz2_3_maliyet_altoranbaslik;
        DataGridView Hurwicz2_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz2_3_maliyet_btn1 = new Button();
        Button Hurwicz2_3_maliyet_btn2 = new Button();
        Button Hurwicz2_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz2_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz3_3_maliyet form nesneleri
        Panel Hurwicz3_3_maliyet_pl1 = new Panel();
        Panel Hurwicz3_3_maliyet_pl2 = new Panel();
        Panel Hurwicz3_3_maliyet_pl3 = new Panel();
        Panel Hurwicz3_3_maliyet_pl4 = new Panel();
        Panel Hurwicz3_3_maliyet_pl5 = new Panel();
        Panel Hurwicz3_3_maliyet_pl6 = new Panel();
        Panel Hurwicz3_3_maliyet_pl7 = new Panel();
        Panel Hurwicz3_3_maliyet_pl8 = new Panel();
        Panel Hurwicz3_3_maliyet_pl9 = new Panel();
        Panel Hurwicz3_3_maliyet_pl10 = new Panel();
        Panel Hurwicz3_3_maliyet_pl11 = new Panel();
        Panel Hurwicz3_3_maliyet_pl12 = new Panel();
        Panel Hurwicz3_3_maliyet_pl13 = new Panel();
        Panel Hurwicz3_3_maliyet_pl14 = new Panel();
        Panel Hurwicz3_3_maliyet_pl15 = new Panel();
        Panel Hurwicz3_3_maliyet_pl16 = new Panel();
        Panel Hurwicz3_3_maliyet_pl17 = new Panel();
        Panel Hurwicz3_3_maliyet_pl18 = new Panel();
        Panel Hurwicz3_3_maliyet_pl19 = new Panel();
        Panel Hurwicz3_3_maliyet_pl20 = new Panel();
        Panel Hurwicz3_3_maliyet_pl21 = new Panel();
        Panel Hurwicz3_3_maliyet_pl22 = new Panel();
        Panel Hurwicz3_3_maliyet_pl23 = new Panel();
        Panel Hurwicz3_3_maliyet_pl24 = new Panel();
        Panel Hurwicz3_3_maliyet_pl25 = new Panel();
        Panel Hurwicz3_3_maliyet_pl26 = new Panel();
        Panel Hurwicz3_3_maliyet_pl27 = new Panel();
        Panel Hurwicz3_3_maliyet_pl28 = new Panel();
        Panel Hurwicz3_3_maliyet_pl29 = new Panel();
        Panel Hurwicz3_3_maliyet_pl30 = new Panel();
        Panel Hurwicz3_3_maliyet_pl31 = new Panel();
        Panel Hurwicz3_3_maliyet_pl32 = new Panel();
        Panel Hurwicz3_3_maliyet_pl33 = new Panel();
        Panel Hurwicz3_3_maliyet_pl34 = new Panel();
        Panel Hurwicz3_3_maliyet_pl35 = new Panel();
        Panel Hurwicz3_3_maliyet_pl36 = new Panel();
        Panel Hurwicz3_3_maliyet_pl37 = new Panel();
        Panel Hurwicz3_3_maliyet_pl38 = new Panel();
        Panel Hurwicz3_3_maliyet_pl39 = new Panel();
        Panel Hurwicz3_3_maliyet_pl40 = new Panel();
        Panel Hurwicz3_3_maliyet_pl41 = new Panel();
        Panel Hurwicz3_3_maliyet_pl42 = new Panel();
        TabControl Hurwicz3_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz3_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz3_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz3_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz3_3_maliyet_txt_baslik1;
        TextBox Hurwicz3_3_maliyet_txt_baslik2;
        TextBox Hurwicz3_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz3_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz3_3_maliyet_txt_altbaslik3;
        TextBox Hurwicz3_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz3_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz3_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz3_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz3_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz3_3_maliyet_txt_Maxf3sonuc;
        TextBox Hurwicz3_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz3_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz3_3_maliyet_txt_Minf3sonuc;
        TextBox Hurwicz3_3_maliyet_txt_altoran1;
        TextBox Hurwicz3_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri6;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri7;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri8;
        NumericUpDown Hurwicz3_3_maliyet_txt_veri9;
        Label Hurwicz3_3_maliyet_sonucbaslik;
        Label Hurwicz3_3_maliyet_sonuc;
        Label Hurwicz3_3_maliyet_Maxsonucbaslik;
        Label Hurwicz3_3_maliyet_Minsonucbaslik;
        Label Hurwicz3_3_maliyet_altoranbaslik;
        DataGridView Hurwicz3_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz3_3_maliyet_btn1 = new Button();
        Button Hurwicz3_3_maliyet_btn2 = new Button();
        Button Hurwicz3_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz3_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz4_3_maliyet form nesneleri
        Panel Hurwicz4_3_maliyet_pl1 = new Panel();
        Panel Hurwicz4_3_maliyet_pl2 = new Panel();
        Panel Hurwicz4_3_maliyet_pl3 = new Panel();
        Panel Hurwicz4_3_maliyet_pl4 = new Panel();
        Panel Hurwicz4_3_maliyet_pl5 = new Panel();
        Panel Hurwicz4_3_maliyet_pl6 = new Panel();
        Panel Hurwicz4_3_maliyet_pl7 = new Panel();
        Panel Hurwicz4_3_maliyet_pl8 = new Panel();
        Panel Hurwicz4_3_maliyet_pl9 = new Panel();
        Panel Hurwicz4_3_maliyet_pl10 = new Panel();
        Panel Hurwicz4_3_maliyet_pl11 = new Panel();
        Panel Hurwicz4_3_maliyet_pl12 = new Panel();
        Panel Hurwicz4_3_maliyet_pl13 = new Panel();
        Panel Hurwicz4_3_maliyet_pl14 = new Panel();
        Panel Hurwicz4_3_maliyet_pl15 = new Panel();
        Panel Hurwicz4_3_maliyet_pl16 = new Panel();
        Panel Hurwicz4_3_maliyet_pl17 = new Panel();
        Panel Hurwicz4_3_maliyet_pl18 = new Panel();
        Panel Hurwicz4_3_maliyet_pl19 = new Panel();
        Panel Hurwicz4_3_maliyet_pl20 = new Panel();
        Panel Hurwicz4_3_maliyet_pl21 = new Panel();
        Panel Hurwicz4_3_maliyet_pl22 = new Panel();
        Panel Hurwicz4_3_maliyet_pl23 = new Panel();
        Panel Hurwicz4_3_maliyet_pl24 = new Panel();
        Panel Hurwicz4_3_maliyet_pl25 = new Panel();
        Panel Hurwicz4_3_maliyet_pl26 = new Panel();
        Panel Hurwicz4_3_maliyet_pl27 = new Panel();
        Panel Hurwicz4_3_maliyet_pl28 = new Panel();
        Panel Hurwicz4_3_maliyet_pl29 = new Panel();
        Panel Hurwicz4_3_maliyet_pl30 = new Panel();
        Panel Hurwicz4_3_maliyet_pl31 = new Panel();
        Panel Hurwicz4_3_maliyet_pl32 = new Panel();
        Panel Hurwicz4_3_maliyet_pl33 = new Panel();
        Panel Hurwicz4_3_maliyet_pl34 = new Panel();
        Panel Hurwicz4_3_maliyet_pl35 = new Panel();
        Panel Hurwicz4_3_maliyet_pl36 = new Panel();
        Panel Hurwicz4_3_maliyet_pl37 = new Panel();
        Panel Hurwicz4_3_maliyet_pl38 = new Panel();
        Panel Hurwicz4_3_maliyet_pl39 = new Panel();
        Panel Hurwicz4_3_maliyet_pl40 = new Panel();
        Panel Hurwicz4_3_maliyet_pl41 = new Panel();
        Panel Hurwicz4_3_maliyet_pl42 = new Panel();
        Panel Hurwicz4_3_maliyet_pl43 = new Panel();
        Panel Hurwicz4_3_maliyet_pl44 = new Panel();
        Panel Hurwicz4_3_maliyet_pl45 = new Panel();
        Panel Hurwicz4_3_maliyet_pl46 = new Panel();
        Panel Hurwicz4_3_maliyet_pl47 = new Panel();
        Panel Hurwicz4_3_maliyet_pl48 = new Panel();
        TabControl Hurwicz4_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz4_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz4_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz4_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz4_3_maliyet_txt_baslik1;
        TextBox Hurwicz4_3_maliyet_txt_baslik2;
        TextBox Hurwicz4_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz4_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz4_3_maliyet_txt_altbaslik3;
        TextBox Hurwicz4_3_maliyet_txt_altbaslik4;
        TextBox Hurwicz4_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz4_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz4_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz4_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Maxf3sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Maxf4sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Minf3sonuc;
        TextBox Hurwicz4_3_maliyet_txt_Minf4sonuc;
        TextBox Hurwicz4_3_maliyet_txt_altoran1;
        TextBox Hurwicz4_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri6;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri7;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri8;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri9;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri10;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri11;
        NumericUpDown Hurwicz4_3_maliyet_txt_veri12;
        Label Hurwicz4_3_maliyet_sonucbaslik;
        Label Hurwicz4_3_maliyet_sonuc;
        Label Hurwicz4_3_maliyet_Maxsonucbaslik;
        Label Hurwicz4_3_maliyet_Minsonucbaslik;
        Label Hurwicz4_3_maliyet_altoranbaslik;
        DataGridView Hurwicz4_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz4_3_maliyet_btn1 = new Button();
        Button Hurwicz4_3_maliyet_btn2 = new Button();
        Button Hurwicz4_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz4_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz5_3_maliyet form nesneleri
        Panel Hurwicz5_3_maliyet_pl1 = new Panel();
        Panel Hurwicz5_3_maliyet_pl2 = new Panel();
        Panel Hurwicz5_3_maliyet_pl3 = new Panel();
        Panel Hurwicz5_3_maliyet_pl4 = new Panel();
        Panel Hurwicz5_3_maliyet_pl5 = new Panel();
        Panel Hurwicz5_3_maliyet_pl6 = new Panel();
        Panel Hurwicz5_3_maliyet_pl7 = new Panel();
        Panel Hurwicz5_3_maliyet_pl8 = new Panel();
        Panel Hurwicz5_3_maliyet_pl9 = new Panel();
        Panel Hurwicz5_3_maliyet_pl10 = new Panel();
        Panel Hurwicz5_3_maliyet_pl11 = new Panel();
        Panel Hurwicz5_3_maliyet_pl12 = new Panel();
        Panel Hurwicz5_3_maliyet_pl13 = new Panel();
        Panel Hurwicz5_3_maliyet_pl14 = new Panel();
        Panel Hurwicz5_3_maliyet_pl15 = new Panel();
        Panel Hurwicz5_3_maliyet_pl16 = new Panel();
        Panel Hurwicz5_3_maliyet_pl17 = new Panel();
        Panel Hurwicz5_3_maliyet_pl18 = new Panel();
        Panel Hurwicz5_3_maliyet_pl19 = new Panel();
        Panel Hurwicz5_3_maliyet_pl20 = new Panel();
        Panel Hurwicz5_3_maliyet_pl21 = new Panel();
        Panel Hurwicz5_3_maliyet_pl22 = new Panel();
        Panel Hurwicz5_3_maliyet_pl23 = new Panel();
        Panel Hurwicz5_3_maliyet_pl24 = new Panel();
        Panel Hurwicz5_3_maliyet_pl25 = new Panel();
        Panel Hurwicz5_3_maliyet_pl26 = new Panel();
        Panel Hurwicz5_3_maliyet_pl27 = new Panel();
        Panel Hurwicz5_3_maliyet_pl28 = new Panel();
        Panel Hurwicz5_3_maliyet_pl29 = new Panel();
        Panel Hurwicz5_3_maliyet_pl30 = new Panel();
        Panel Hurwicz5_3_maliyet_pl31 = new Panel();
        Panel Hurwicz5_3_maliyet_pl32 = new Panel();
        Panel Hurwicz5_3_maliyet_pl33 = new Panel();
        Panel Hurwicz5_3_maliyet_pl34 = new Panel();
        Panel Hurwicz5_3_maliyet_pl35 = new Panel();
        Panel Hurwicz5_3_maliyet_pl36 = new Panel();
        Panel Hurwicz5_3_maliyet_pl37 = new Panel();
        Panel Hurwicz5_3_maliyet_pl38 = new Panel();
        Panel Hurwicz5_3_maliyet_pl39 = new Panel();
        Panel Hurwicz5_3_maliyet_pl40 = new Panel();
        Panel Hurwicz5_3_maliyet_pl41 = new Panel();
        Panel Hurwicz5_3_maliyet_pl42 = new Panel();
        Panel Hurwicz5_3_maliyet_pl43 = new Panel();
        Panel Hurwicz5_3_maliyet_pl44 = new Panel();
        Panel Hurwicz5_3_maliyet_pl45 = new Panel();
        Panel Hurwicz5_3_maliyet_pl46 = new Panel();
        Panel Hurwicz5_3_maliyet_pl47 = new Panel();
        Panel Hurwicz5_3_maliyet_pl48 = new Panel();
        Panel Hurwicz5_3_maliyet_pl49 = new Panel();
        Panel Hurwicz5_3_maliyet_pl50 = new Panel();
        Panel Hurwicz5_3_maliyet_pl51 = new Panel();
        Panel Hurwicz5_3_maliyet_pl52 = new Panel();
        Panel Hurwicz5_3_maliyet_pl53 = new Panel();
        Panel Hurwicz5_3_maliyet_pl54 = new Panel();
        TabControl Hurwicz5_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz5_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz5_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz5_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz5_3_maliyet_txt_baslik1;
        TextBox Hurwicz5_3_maliyet_txt_baslik2;
        TextBox Hurwicz5_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz5_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz5_3_maliyet_txt_altbaslik3;
        TextBox Hurwicz5_3_maliyet_txt_altbaslik4;
        TextBox Hurwicz5_3_maliyet_txt_altbaslik5;
        TextBox Hurwicz5_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz5_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz5_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz5_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Maxf3sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Maxf4sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Maxf5sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Minf3sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Minf4sonuc;
        TextBox Hurwicz5_3_maliyet_txt_Minf5sonuc;
        TextBox Hurwicz5_3_maliyet_txt_altoran1;
        TextBox Hurwicz5_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri6;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri7;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri8;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri9;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri10;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri11;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri12;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri13;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri14;
        NumericUpDown Hurwicz5_3_maliyet_txt_veri15;
        Label Hurwicz5_3_maliyet_sonucbaslik;
        Label Hurwicz5_3_maliyet_sonuc;
        Label Hurwicz5_3_maliyet_Maxsonucbaslik;
        Label Hurwicz5_3_maliyet_Minsonucbaslik;
        Label Hurwicz5_3_maliyet_altoranbaslik;
        DataGridView Hurwicz5_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz5_3_maliyet_btn1 = new Button();
        Button Hurwicz5_3_maliyet_btn2 = new Button();
        Button Hurwicz5_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz5_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz6_3_maliyet form nesneleri
        Panel Hurwicz6_3_maliyet_pl1 = new Panel();
        Panel Hurwicz6_3_maliyet_pl2 = new Panel();
        Panel Hurwicz6_3_maliyet_pl3 = new Panel();
        Panel Hurwicz6_3_maliyet_pl4 = new Panel();
        Panel Hurwicz6_3_maliyet_pl5 = new Panel();
        Panel Hurwicz6_3_maliyet_pl6 = new Panel();
        Panel Hurwicz6_3_maliyet_pl7 = new Panel();
        Panel Hurwicz6_3_maliyet_pl8 = new Panel();
        Panel Hurwicz6_3_maliyet_pl9 = new Panel();
        Panel Hurwicz6_3_maliyet_pl10 = new Panel();
        Panel Hurwicz6_3_maliyet_pl11 = new Panel();
        Panel Hurwicz6_3_maliyet_pl12 = new Panel();
        Panel Hurwicz6_3_maliyet_pl13 = new Panel();
        Panel Hurwicz6_3_maliyet_pl14 = new Panel();
        Panel Hurwicz6_3_maliyet_pl15 = new Panel();
        Panel Hurwicz6_3_maliyet_pl16 = new Panel();
        Panel Hurwicz6_3_maliyet_pl17 = new Panel();
        Panel Hurwicz6_3_maliyet_pl18 = new Panel();
        Panel Hurwicz6_3_maliyet_pl19 = new Panel();
        Panel Hurwicz6_3_maliyet_pl20 = new Panel();
        Panel Hurwicz6_3_maliyet_pl21 = new Panel();
        Panel Hurwicz6_3_maliyet_pl22 = new Panel();
        Panel Hurwicz6_3_maliyet_pl23 = new Panel();
        Panel Hurwicz6_3_maliyet_pl24 = new Panel();
        Panel Hurwicz6_3_maliyet_pl25 = new Panel();
        Panel Hurwicz6_3_maliyet_pl26 = new Panel();
        Panel Hurwicz6_3_maliyet_pl27 = new Panel();
        Panel Hurwicz6_3_maliyet_pl28 = new Panel();
        Panel Hurwicz6_3_maliyet_pl29 = new Panel();
        Panel Hurwicz6_3_maliyet_pl30 = new Panel();
        Panel Hurwicz6_3_maliyet_pl31 = new Panel();
        Panel Hurwicz6_3_maliyet_pl32 = new Panel();
        Panel Hurwicz6_3_maliyet_pl33 = new Panel();
        Panel Hurwicz6_3_maliyet_pl34 = new Panel();
        Panel Hurwicz6_3_maliyet_pl35 = new Panel();
        Panel Hurwicz6_3_maliyet_pl36 = new Panel();
        Panel Hurwicz6_3_maliyet_pl37 = new Panel();
        Panel Hurwicz6_3_maliyet_pl38 = new Panel();
        Panel Hurwicz6_3_maliyet_pl39 = new Panel();
        Panel Hurwicz6_3_maliyet_pl40 = new Panel();
        Panel Hurwicz6_3_maliyet_pl41 = new Panel();
        Panel Hurwicz6_3_maliyet_pl42 = new Panel();
        Panel Hurwicz6_3_maliyet_pl43 = new Panel();
        Panel Hurwicz6_3_maliyet_pl44 = new Panel();
        Panel Hurwicz6_3_maliyet_pl45 = new Panel();
        Panel Hurwicz6_3_maliyet_pl46 = new Panel();
        Panel Hurwicz6_3_maliyet_pl47 = new Panel();
        Panel Hurwicz6_3_maliyet_pl48 = new Panel();
        Panel Hurwicz6_3_maliyet_pl49 = new Panel();
        Panel Hurwicz6_3_maliyet_pl50 = new Panel();
        Panel Hurwicz6_3_maliyet_pl51 = new Panel();
        Panel Hurwicz6_3_maliyet_pl52 = new Panel();
        Panel Hurwicz6_3_maliyet_pl53 = new Panel();
        Panel Hurwicz6_3_maliyet_pl54 = new Panel();
        Panel Hurwicz6_3_maliyet_pl55 = new Panel();
        Panel Hurwicz6_3_maliyet_pl56 = new Panel();
        Panel Hurwicz6_3_maliyet_pl57 = new Panel();
        Panel Hurwicz6_3_maliyet_pl58 = new Panel();
        Panel Hurwicz6_3_maliyet_pl59 = new Panel();
        Panel Hurwicz6_3_maliyet_pl60 = new Panel();
        TabControl Hurwicz6_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz6_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz6_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz6_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz6_3_maliyet_txt_baslik1;
        TextBox Hurwicz6_3_maliyet_txt_baslik2;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik3;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik4;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik5;
        TextBox Hurwicz6_3_maliyet_txt_altbaslik6;
        TextBox Hurwicz6_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz6_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz6_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz6_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Maxf3sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Maxf4sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Maxf5sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Maxf6sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf3sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf4sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf5sonuc;
        TextBox Hurwicz6_3_maliyet_txt_Minf6sonuc;
        TextBox Hurwicz6_3_maliyet_txt_altoran1;
        TextBox Hurwicz6_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri6;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri7;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri8;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri9;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri10;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri11;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri12;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri13;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri14;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri15;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri16;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri17;
        NumericUpDown Hurwicz6_3_maliyet_txt_veri18;
        Label Hurwicz6_3_maliyet_sonucbaslik;
        Label Hurwicz6_3_maliyet_sonuc;
        Label Hurwicz6_3_maliyet_Maxsonucbaslik;
        Label Hurwicz6_3_maliyet_Minsonucbaslik;
        Label Hurwicz6_3_maliyet_altoranbaslik;
        DataGridView Hurwicz6_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz6_3_maliyet_btn1 = new Button();
        Button Hurwicz6_3_maliyet_btn2 = new Button();
        Button Hurwicz6_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz6_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz7_3_maliyet form nesneleri
        Panel Hurwicz7_3_maliyet_pl1 = new Panel();
        Panel Hurwicz7_3_maliyet_pl2 = new Panel();
        Panel Hurwicz7_3_maliyet_pl3 = new Panel();
        Panel Hurwicz7_3_maliyet_pl4 = new Panel();
        Panel Hurwicz7_3_maliyet_pl5 = new Panel();
        Panel Hurwicz7_3_maliyet_pl6 = new Panel();
        Panel Hurwicz7_3_maliyet_pl7 = new Panel();
        Panel Hurwicz7_3_maliyet_pl8 = new Panel();
        Panel Hurwicz7_3_maliyet_pl9 = new Panel();
        Panel Hurwicz7_3_maliyet_pl10 = new Panel();
        Panel Hurwicz7_3_maliyet_pl11 = new Panel();
        Panel Hurwicz7_3_maliyet_pl12 = new Panel();
        Panel Hurwicz7_3_maliyet_pl13 = new Panel();
        Panel Hurwicz7_3_maliyet_pl14 = new Panel();
        Panel Hurwicz7_3_maliyet_pl15 = new Panel();
        Panel Hurwicz7_3_maliyet_pl16 = new Panel();
        Panel Hurwicz7_3_maliyet_pl17 = new Panel();
        Panel Hurwicz7_3_maliyet_pl18 = new Panel();
        Panel Hurwicz7_3_maliyet_pl19 = new Panel();
        Panel Hurwicz7_3_maliyet_pl20 = new Panel();
        Panel Hurwicz7_3_maliyet_pl21 = new Panel();
        Panel Hurwicz7_3_maliyet_pl22 = new Panel();
        Panel Hurwicz7_3_maliyet_pl23 = new Panel();
        Panel Hurwicz7_3_maliyet_pl24 = new Panel();
        Panel Hurwicz7_3_maliyet_pl25 = new Panel();
        Panel Hurwicz7_3_maliyet_pl26 = new Panel();
        Panel Hurwicz7_3_maliyet_pl27 = new Panel();
        Panel Hurwicz7_3_maliyet_pl28 = new Panel();
        Panel Hurwicz7_3_maliyet_pl29 = new Panel();
        Panel Hurwicz7_3_maliyet_pl30 = new Panel();
        Panel Hurwicz7_3_maliyet_pl31 = new Panel();
        Panel Hurwicz7_3_maliyet_pl32 = new Panel();
        Panel Hurwicz7_3_maliyet_pl33 = new Panel();
        Panel Hurwicz7_3_maliyet_pl34 = new Panel();
        Panel Hurwicz7_3_maliyet_pl35 = new Panel();
        Panel Hurwicz7_3_maliyet_pl36 = new Panel();
        Panel Hurwicz7_3_maliyet_pl37 = new Panel();
        Panel Hurwicz7_3_maliyet_pl38 = new Panel();
        Panel Hurwicz7_3_maliyet_pl39 = new Panel();
        Panel Hurwicz7_3_maliyet_pl40 = new Panel();
        Panel Hurwicz7_3_maliyet_pl41 = new Panel();
        Panel Hurwicz7_3_maliyet_pl42 = new Panel();
        Panel Hurwicz7_3_maliyet_pl43 = new Panel();
        Panel Hurwicz7_3_maliyet_pl44 = new Panel();
        Panel Hurwicz7_3_maliyet_pl45 = new Panel();
        Panel Hurwicz7_3_maliyet_pl46 = new Panel();
        Panel Hurwicz7_3_maliyet_pl47 = new Panel();
        Panel Hurwicz7_3_maliyet_pl48 = new Panel();
        Panel Hurwicz7_3_maliyet_pl49 = new Panel();
        Panel Hurwicz7_3_maliyet_pl50 = new Panel();
        Panel Hurwicz7_3_maliyet_pl51 = new Panel();
        Panel Hurwicz7_3_maliyet_pl52 = new Panel();
        Panel Hurwicz7_3_maliyet_pl53 = new Panel();
        Panel Hurwicz7_3_maliyet_pl54 = new Panel();
        Panel Hurwicz7_3_maliyet_pl55 = new Panel();
        Panel Hurwicz7_3_maliyet_pl56 = new Panel();
        Panel Hurwicz7_3_maliyet_pl57 = new Panel();
        Panel Hurwicz7_3_maliyet_pl58 = new Panel();
        Panel Hurwicz7_3_maliyet_pl59 = new Panel();
        Panel Hurwicz7_3_maliyet_pl60 = new Panel();
        Panel Hurwicz7_3_maliyet_pl61 = new Panel();
        Panel Hurwicz7_3_maliyet_pl62 = new Panel();
        Panel Hurwicz7_3_maliyet_pl63 = new Panel();
        Panel Hurwicz7_3_maliyet_pl64 = new Panel();
        Panel Hurwicz7_3_maliyet_pl65 = new Panel();
        Panel Hurwicz7_3_maliyet_pl66 = new Panel();
        TabControl Hurwicz7_3_maliyet_tb1 = new TabControl();
        TabPage Hurwicz7_3_maliyet_tb1_1 = new TabPage();
        TabPage Hurwicz7_3_maliyet_tb1_2 = new TabPage();
        TabPage Hurwicz7_3_maliyet_tb1_3 = new TabPage();
        TextBox Hurwicz7_3_maliyet_txt_baslik1;
        TextBox Hurwicz7_3_maliyet_txt_baslik2;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik1;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik2;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik3;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik4;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik5;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik6;
        TextBox Hurwicz7_3_maliyet_txt_altbaslik7;
        TextBox Hurwicz7_3_maliyet_txt_üstbaslik1;
        TextBox Hurwicz7_3_maliyet_txt_üstbaslik2;
        TextBox Hurwicz7_3_maliyet_txt_üstbaslik3;
        TextBox Hurwicz7_3_maliyet_txt_Maxf1sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf2sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf3sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf4sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf5sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf6sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Maxf7sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf1sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf2sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf3sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf4sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf5sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf6sonuc;
        TextBox Hurwicz7_3_maliyet_txt_Minf7sonuc;
        TextBox Hurwicz7_3_maliyet_txt_altoran1;
        TextBox Hurwicz7_3_maliyet_txt_altoran2;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri1;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri2;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri3;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri4;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri5;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri6;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri7;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri8;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri9;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri10;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri11;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri12;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri13;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri14;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri15;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri16;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri17;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri18;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri19;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri20;
        NumericUpDown Hurwicz7_3_maliyet_txt_veri21;
        Label Hurwicz7_3_maliyet_sonucbaslik;
        Label Hurwicz7_3_maliyet_sonuc;
        Label Hurwicz7_3_maliyet_Maxsonucbaslik;
        Label Hurwicz7_3_maliyet_Minsonucbaslik;
        Label Hurwicz7_3_maliyet_altoranbaslik;
        DataGridView Hurwicz7_3_maliyet_dr1 = new DataGridView();
        Button Hurwicz7_3_maliyet_btn1 = new Button();
        Button Hurwicz7_3_maliyet_btn2 = new Button();
        Button Hurwicz7_3_maliyet_btn3 = new Button();
        RichTextBox Hurwicz7_3_maliyet_rt1 = new RichTextBox();
        //-----------------------------------------

        //Hurwicz2_3_maliyet form nesne tasarımları
        public void Hurwicz2_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz2_3_maliyet_sonuc = new Label();
            Hurwicz2_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz2_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_sonuc.Location = sonuc;
            Hurwicz2_3_maliyet_sonuc.Text = "";
            Hurwicz2_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz2_3_maliyet_pl4.Controls.Add(Hurwicz2_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük maliyet ismini Label  olarak yerleştirir
            Hurwicz2_3_maliyet_sonucbaslik = new Label();
            Hurwicz2_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz2_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz2_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz2_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz2_3_maliyet_pl4.Controls.Add(Hurwicz2_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel34 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz2_3_maliyet_altoranbaslik = new Label();
            Hurwicz2_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz2_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz2_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz2_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz2_3_maliyet_pl34.Controls.Add(Hurwicz2_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel31 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz2_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz2_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz2_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz2_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz2_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz2_3_maliyet_pl31.Controls.Add(Hurwicz2_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz2_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz2_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz2_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz2_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz2_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz2_3_maliyet_pl28.Controls.Add(Hurwicz2_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel36 içerisine altoran-2 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz2_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz2_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz2_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz2_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz2_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz2_3_maliyet_pl36.Controls.Add(Hurwicz2_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel35 içerisine altoran-1 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz2_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz2_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz2_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz2_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz2_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz2_3_maliyet_pl35.Controls.Add(Hurwicz2_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz2_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl27.Controls.Add(Hurwicz2_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz2_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl23.Controls.Add(Hurwicz2_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz2_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl22.Controls.Add(Hurwicz2_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz2_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl26.Controls.Add(Hurwicz2_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz2_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl21.Controls.Add(Hurwicz2_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz2_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz2_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz2_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl20.Controls.Add(Hurwicz2_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel33 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz2_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz2_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz2_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz2_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl33.Controls.Add(Hurwicz2_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel32 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz2_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz2_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz2_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz2_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl32.Controls.Add(Hurwicz2_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz2_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz2_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz2_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz2_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl30.Controls.Add(Hurwicz2_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz2_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz2_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz2_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz2_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz2_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz2_3_maliyet_pl29.Controls.Add(Hurwicz2_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz2_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz2_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz2_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz2_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz2_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz2_3_maliyet_pl24.Controls.Add(Hurwicz2_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz2_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz2_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz2_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz2_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz2_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz2_3_maliyet_pl17.Controls.Add(Hurwicz2_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz2_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz2_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz2_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz2_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz2_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz2_3_maliyet_pl16.Controls.Add(Hurwicz2_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz2_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz2_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz2_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz2_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz2_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz2_3_maliyet_pl15.Controls.Add(Hurwicz2_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz2_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz2_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz2_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz2_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz2_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz2_3_maliyet_pl14.Controls.Add(Hurwicz2_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz2_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz2_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz2_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz2_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz2_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz2_3_maliyet_pl13.Controls.Add(Hurwicz2_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz2_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz2_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz2_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz2_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz2_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz2_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz2_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz2_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz2_3_maliyet_pl12.Controls.Add(Hurwicz2_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel36 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(567, 159);
            Hurwicz2_3_maliyet_pl36.Location = pl36k;
            Hurwicz2_3_maliyet_pl36.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl36);
            //-----------------------------------------

            //panel35 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz2_3_maliyet_pl35.Location = pl35k;
            Hurwicz2_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl35);
            //-----------------------------------------

            //panel34 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz2_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(179, 159);
            Hurwicz2_3_maliyet_pl34.Location = pl34k;
            Hurwicz2_3_maliyet_pl34.Size = new Size(285, 33);
            Hurwicz2_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz2_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(567, 120);
            Hurwicz2_3_maliyet_pl33.Location = pl33k;
            Hurwicz2_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz2_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(567, 81);
            Hurwicz2_3_maliyet_pl32.Location = pl32k;
            Hurwicz2_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl32);
            //-----------------------------------------

            //panel31 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz2_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(567, 3);
            Hurwicz2_3_maliyet_pl31.Location = pl31k;
            Hurwicz2_3_maliyet_pl31.Size = new Size(91, 72);
            Hurwicz2_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl31);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz2_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz2_3_maliyet_pl30.Location = pl30k;
            Hurwicz2_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz2_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz2_3_maliyet_pl29.Location = pl29k;
            Hurwicz2_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz2_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz2_3_maliyet_pl28.Location = pl28k;
            Hurwicz2_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz2_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz2_3_maliyet_pl27.Location = pl27k;
            Hurwicz2_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz2_3_maliyet_pl26.Location = pl26k;
            Hurwicz2_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz2_3_maliyet_pl23.Location = pl23k;
            Hurwicz2_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz2_3_maliyet_pl22.Location = pl22k;
            Hurwicz2_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz2_3_maliyet_pl21.Location = pl21k;
            Hurwicz2_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz2_3_maliyet_pl20.Location = pl20k;
            Hurwicz2_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu sütün 3-satır 2 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz2_3_maliyet_pl25.Location = pl25k;
            Hurwicz2_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu sütün 2-satır 2 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz2_3_maliyet_pl19.Location = pl19k;
            Hurwicz2_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu sütün 2-satır 2 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz2_3_maliyet_pl18.Location = pl18k;
            Hurwicz2_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz2_3_maliyet_pl24.Location = pl24k;
            Hurwicz2_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz2_3_maliyet_pl17.Location = pl17k;
            Hurwicz2_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz2_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz2_3_maliyet_pl16.Location = pl16k;
            Hurwicz2_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz2_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz2_3_maliyet_pl15.Location = pl15k;
            Hurwicz2_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz2_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz2_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz2_3_maliyet_pl14.Location = pl14k;
            Hurwicz2_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz2_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz2_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz2_3_maliyet_pl13.Location = pl13k;
            Hurwicz2_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz2_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz2_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz2_3_maliyet_pl12.Location = pl12k;
            Hurwicz2_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz2_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl5.Controls.Add(Hurwicz2_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz2_3_maliyet_pl11.Name = "pl11";
            Hurwicz2_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz2_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz2_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl11.Click += new EventHandler(Hurwicz2_3_maliyet_pl11_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz2_3_maliyet_pl10.Name = "pl10";
            Hurwicz2_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz2_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl10.Click += new EventHandler(Hurwicz2_3_maliyet_pl10_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz2_3_maliyet_pl9.Name = "pl9";
            Hurwicz2_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz2_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl9.Click += new EventHandler(Hurwicz2_3_maliyet_pl9_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz2_3_maliyet_pl8.Name = "pl8";
            Hurwicz2_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz2_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl8.Click += new EventHandler(Hurwicz2_3_maliyet_pl8_Click);
            Hurwicz2_3_maliyet_pl7.Controls.Add(Hurwicz2_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz2_3_maliyet_pl6.Name = "pl6";
            Hurwicz2_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz2_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl6.Click += new EventHandler(Hurwicz2_3_maliyet_pl6_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz2_3_maliyet_btn3.Name = "btn3";
            Hurwicz2_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz2_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz2_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_btn3.Click += new EventHandler(Hurwicz2_3_maliyet_btn3_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz2_3_maliyet_btn2.Name = "btn2";
            Hurwicz2_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz2_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz2_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz2_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz2_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_btn2.Click += new EventHandler(Hurwicz2_3_maliyet_btn2_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz2_3_maliyet_btn1.Name = "btn1";
            Hurwicz2_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz2_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz2_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz2_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz2_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz2_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz2_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz2_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_btn1.Click += new EventHandler(Hurwicz2_3_maliyet_btn1_Click);
            Hurwicz2_3_maliyet_pl2.Controls.Add(Hurwicz2_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz2_3_maliyet_dr1.Name = "dr1";
            Hurwicz2_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz2_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz2_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz2_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz2_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz2_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz2_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz2_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz2_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz2_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz2_3_maliyet_dr1_CellEnter);
            Hurwicz2_3_maliyet_tb1_2.Controls.Add(Hurwicz2_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz2_3_maliyet_pl7.Name = "pl7";
            Hurwicz2_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz2_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz2_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_tb1_2.Controls.Add(Hurwicz2_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz2_3_maliyet_pl5.Name = "pl5";
            Hurwicz2_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz2_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz2_3_maliyet_pl5.AutoScroll = true;
            Hurwicz2_3_maliyet_pl5.AutoSize = true;
            Hurwicz2_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz2_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_tb1_1.Controls.Add(Hurwicz2_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz2_3_maliyet_rt1.Name = "rt1";
            Hurwicz2_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz2_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz2_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_rt1.Enabled = false;
            Hurwicz2_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz2_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz2_3_maliyet_tb1_3.Controls.Add(Hurwicz2_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz2_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz2_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz2_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz2_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_tb1.Controls.Add(Hurwicz2_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz2_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz2_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz2_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz2_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_tb1.Controls.Add(Hurwicz2_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz2_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz2_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz2_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz2_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_tb1.Controls.Add(Hurwicz2_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz2_3_maliyet_tb1.Name = "tb1";
            Hurwicz2_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz2_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz2_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz2_3_maliyet_pl3.Controls.Add(Hurwicz2_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz2_3_maliyet_pl4.Name = "pl4";
            Hurwicz2_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz2_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz2_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz2_3_maliyet_pl4_MouseUp);
            Hurwicz2_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz2_3_maliyet_pl4_MouseMove);
            Hurwicz2_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz2_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz2_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz2_3_maliyet_pl3.Name = "pl3";
            Hurwicz2_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz2_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz2_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz2_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz2_3_maliyet_pl2.Name = "pl2";
            Hurwicz2_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz2_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz2_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz2_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz2_3_maliyet_pl1.Name = "pl1";
            Hurwicz2_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz2_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz2_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz2_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz2_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz2_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz2_3_maliyet_pl1_MouseUp);
            Hurwicz2_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz2_3_maliyet_pl1_MouseMove);
            Hurwicz2_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz2_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz2_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz3_3_maliyet form nesne tasarımları
        public void Hurwicz3_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz3_3_maliyet_sonuc = new Label();
            Hurwicz3_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz3_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_sonuc.Location = sonuc;
            Hurwicz3_3_maliyet_sonuc.Text = "";
            Hurwicz3_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz3_3_maliyet_pl4.Controls.Add(Hurwicz3_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Küçük maliyet ismini Label  olarak yerleştirir
            Hurwicz3_3_maliyet_sonucbaslik = new Label();
            Hurwicz3_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz3_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz3_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz3_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz3_3_maliyet_pl4.Controls.Add(Hurwicz3_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel40 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz3_3_maliyet_altoranbaslik = new Label();
            Hurwicz3_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz3_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz3_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz3_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz3_3_maliyet_pl40.Controls.Add(Hurwicz3_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel36 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz3_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz3_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz3_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz3_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz3_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz3_3_maliyet_pl36.Controls.Add(Hurwicz3_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz3_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz3_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz3_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz3_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz3_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz3_3_maliyet_pl28.Controls.Add(Hurwicz3_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel42 içerisine altoran-2 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz3_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz3_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz3_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz3_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz3_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz3_3_maliyet_pl42.Controls.Add(Hurwicz3_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel41 içerisine altoran-1 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz3_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz3_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz3_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz3_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz3_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz3_3_maliyet_pl41.Controls.Add(Hurwicz3_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri9 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri9.Location = txt_veri9;
            Hurwicz3_3_maliyet_txt_veri9.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl34.Controls.Add(Hurwicz3_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri8 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri8.Location = txt_veri8;
            Hurwicz3_3_maliyet_txt_veri8.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl33.Controls.Add(Hurwicz3_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri7 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri7.Location = txt_veri7;
            Hurwicz3_3_maliyet_txt_veri7.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl32.Controls.Add(Hurwicz3_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz3_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl27.Controls.Add(Hurwicz3_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz3_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl23.Controls.Add(Hurwicz3_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz3_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl22.Controls.Add(Hurwicz3_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz3_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl26.Controls.Add(Hurwicz3_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz3_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl21.Controls.Add(Hurwicz3_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz3_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz3_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz3_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl20.Controls.Add(Hurwicz3_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel39 içerisine Minf3sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Minf3sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Minf3sonuc.Name = "txtMinf3sonuc";
            Point txt_txtMinf3sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Minf3sonuc.Location = txt_txtMinf3sonuc;
            Hurwicz3_3_maliyet_txt_Minf3sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Minf3sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Minf3sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl39.Controls.Add(Hurwicz3_3_maliyet_txt_Minf3sonuc);
            //---------------------------------------------------------------

            //panel38 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz3_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl38.Controls.Add(Hurwicz3_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel37 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz3_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl37.Controls.Add(Hurwicz3_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine Maxf3sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Maxf3sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Maxf3sonuc.Name = "txtMaxf3sonuc";
            Point txt_txtMaxf3sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Maxf3sonuc.Location = txt_txtMaxf3sonuc;
            Hurwicz3_3_maliyet_txt_Maxf3sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Maxf3sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Maxf3sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl35.Controls.Add(Hurwicz3_3_maliyet_txt_Maxf3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz3_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl30.Controls.Add(Hurwicz3_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz3_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz3_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz3_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz3_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz3_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz3_3_maliyet_pl29.Controls.Add(Hurwicz3_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz3_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz3_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz3_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz3_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz3_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz3_3_maliyet_pl24.Controls.Add(Hurwicz3_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz3_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz3_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz3_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz3_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz3_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz3_3_maliyet_pl17.Controls.Add(Hurwicz3_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz3_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz3_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz3_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz3_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz3_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz3_3_maliyet_pl16.Controls.Add(Hurwicz3_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_altbaslik3 = new TextBox();
            Hurwicz3_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            Hurwicz3_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            Hurwicz3_3_maliyet_txt_altbaslik3.Text = "F3";
            Hurwicz3_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_altbaslik3.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_altbaslik3.Multiline = true;
            Hurwicz3_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            Hurwicz3_3_maliyet_pl31.Controls.Add(Hurwicz3_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz3_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz3_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz3_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz3_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz3_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz3_3_maliyet_pl15.Controls.Add(Hurwicz3_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz3_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz3_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz3_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz3_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz3_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz3_3_maliyet_pl14.Controls.Add(Hurwicz3_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz3_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz3_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz3_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz3_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz3_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz3_3_maliyet_pl13.Controls.Add(Hurwicz3_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz3_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz3_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz3_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz3_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz3_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz3_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz3_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz3_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz3_3_maliyet_pl12.Controls.Add(Hurwicz3_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel42 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(567, 198);
            Hurwicz3_3_maliyet_pl42.Location = pl42k;
            Hurwicz3_3_maliyet_pl42.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl42);
            //-----------------------------------------

            //panel41 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(470, 198);
            Hurwicz3_3_maliyet_pl41.Location = pl41k;
            Hurwicz3_3_maliyet_pl41.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl41);
            //-----------------------------------------

            //panel40 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz3_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(179, 198);
            Hurwicz3_3_maliyet_pl40.Location = pl40k;
            Hurwicz3_3_maliyet_pl40.Size = new Size(285, 33);
            Hurwicz3_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl40);
            //-----------------------------------------

            //panel39 oluşturuldu  f3Min-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(567, 159);
            Hurwicz3_3_maliyet_pl39.Location = pl39k;
            Hurwicz3_3_maliyet_pl39.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(567, 120);
            Hurwicz3_3_maliyet_pl38.Location = pl38k;
            Hurwicz3_3_maliyet_pl38.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(567, 81);
            Hurwicz3_3_maliyet_pl37.Location = pl37k;
            Hurwicz3_3_maliyet_pl37.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl37);
            //-----------------------------------------

            //panel36 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz3_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(567, 3);
            Hurwicz3_3_maliyet_pl36.Location = pl36k;
            Hurwicz3_3_maliyet_pl36.Size = new Size(91, 72);
            Hurwicz3_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl36);
            //-----------------------------------------

            //panel35 oluşturuldu  f3Max-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz3_3_maliyet_pl35.Location = pl35k;
            Hurwicz3_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz3_3_maliyet_pl30.Location = pl30k;
            Hurwicz3_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz3_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz3_3_maliyet_pl29.Location = pl29k;
            Hurwicz3_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz3_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz3_3_maliyet_pl28.Location = pl28k;
            Hurwicz3_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz3_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            Hurwicz3_3_maliyet_pl34.Location = pl34k;
            Hurwicz3_3_maliyet_pl34.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            Hurwicz3_3_maliyet_pl33.Location = pl33k;
            Hurwicz3_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            Hurwicz3_3_maliyet_pl32.Location = pl32k;
            Hurwicz3_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz3_3_maliyet_pl27.Location = pl27k;
            Hurwicz3_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz3_3_maliyet_pl26.Location = pl26k;
            Hurwicz3_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz3_3_maliyet_pl23.Location = pl23k;
            Hurwicz3_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz3_3_maliyet_pl22.Location = pl22k;
            Hurwicz3_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz3_3_maliyet_pl21.Location = pl21k;
            Hurwicz3_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz3_3_maliyet_pl20.Location = pl20k;
            Hurwicz3_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz3_3_maliyet_pl25.Location = pl25k;
            Hurwicz3_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz3_3_maliyet_pl19.Location = pl19k;
            Hurwicz3_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz3_3_maliyet_pl18.Location = pl18k;
            Hurwicz3_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz3_3_maliyet_pl24.Location = pl24k;
            Hurwicz3_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz3_3_maliyet_pl17.Location = pl17k;
            Hurwicz3_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz3_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz3_3_maliyet_pl16.Location = pl16k;
            Hurwicz3_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz3_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            Hurwicz3_3_maliyet_pl31.Location = pl31k;
            Hurwicz3_3_maliyet_pl31.Size = new Size(168, 33);
            Hurwicz3_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz3_3_maliyet_pl15.Location = pl15k;
            Hurwicz3_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz3_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz3_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz3_3_maliyet_pl14.Location = pl14k;
            Hurwicz3_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz3_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz3_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz3_3_maliyet_pl13.Location = pl13k;
            Hurwicz3_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz3_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz3_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz3_3_maliyet_pl12.Location = pl12k;
            Hurwicz3_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz3_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl5.Controls.Add(Hurwicz3_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz3_3_maliyet_pl11.Name = "pl11";
            Hurwicz3_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz3_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz3_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl11.Click += new EventHandler(Hurwicz3_3_maliyet_pl11_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz3_3_maliyet_pl10.Name = "pl10";
            Hurwicz3_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz3_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl10.Click += new EventHandler(Hurwicz3_3_maliyet_pl10_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz3_3_maliyet_pl9.Name = "pl9";
            Hurwicz3_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz3_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl9.Click += new EventHandler(Hurwicz3_3_maliyet_pl9_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz3_3_maliyet_pl8.Name = "pl8";
            Hurwicz3_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz3_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl8.Click += new EventHandler(Hurwicz3_3_maliyet_pl8_Click);
            Hurwicz3_3_maliyet_pl7.Controls.Add(Hurwicz3_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz3_3_maliyet_pl6.Name = "pl6";
            Hurwicz3_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz3_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl6.Click += new EventHandler(Hurwicz3_3_maliyet_pl6_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz3_3_maliyet_btn3.Name = "btn3";
            Hurwicz3_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz3_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz3_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_btn3.Click += new EventHandler(Hurwicz3_3_maliyet_btn3_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz3_3_maliyet_btn2.Name = "btn2";
            Hurwicz3_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz3_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz3_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz3_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz3_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_btn2.Click += new EventHandler(Hurwicz3_3_maliyet_btn2_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz3_3_maliyet_btn1.Name = "btn1";
            Hurwicz3_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz3_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz3_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz3_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz3_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz3_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz3_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz3_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_btn1.Click += new EventHandler(Hurwicz3_3_maliyet_btn1_Click);
            Hurwicz3_3_maliyet_pl2.Controls.Add(Hurwicz3_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz3_3_maliyet_dr1.Name = "dr1";
            Hurwicz3_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz3_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz3_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz3_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz3_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz3_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz3_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz3_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz3_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz3_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz3_3_maliyet_dr1_CellEnter);
            Hurwicz3_3_maliyet_tb1_2.Controls.Add(Hurwicz3_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz3_3_maliyet_pl7.Name = "pl7";
            Hurwicz3_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz3_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz3_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_tb1_2.Controls.Add(Hurwicz3_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz3_3_maliyet_pl5.Name = "pl5";
            Hurwicz3_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz3_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz3_3_maliyet_pl5.AutoScroll = true;
            Hurwicz3_3_maliyet_pl5.AutoSize = true;
            Hurwicz3_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz3_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_tb1_1.Controls.Add(Hurwicz3_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz3_3_maliyet_rt1.Name = "rt1";
            Hurwicz3_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz3_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz3_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_rt1.Enabled = false;
            Hurwicz3_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz3_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz3_3_maliyet_tb1_3.Controls.Add(Hurwicz3_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz3_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz3_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz3_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz3_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_tb1.Controls.Add(Hurwicz3_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz3_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz3_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz3_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz3_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_tb1.Controls.Add(Hurwicz3_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz3_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz3_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz3_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz3_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_tb1.Controls.Add(Hurwicz3_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz3_3_maliyet_tb1.Name = "tb1";
            Hurwicz3_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz3_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz3_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz3_3_maliyet_pl3.Controls.Add(Hurwicz3_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz3_3_maliyet_pl4.Name = "pl4";
            Hurwicz3_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz3_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz3_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz3_3_maliyet_pl4_MouseUp);
            Hurwicz3_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz3_3_maliyet_pl4_MouseMove);
            Hurwicz3_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz3_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz3_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz3_3_maliyet_pl3.Name = "pl3";
            Hurwicz3_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz3_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz3_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz3_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz3_3_maliyet_pl2.Name = "pl2";
            Hurwicz3_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz3_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz3_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz3_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz3_3_maliyet_pl1.Name = "pl1";
            Hurwicz3_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz3_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz3_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz3_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz3_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz3_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz3_3_maliyet_pl1_MouseUp);
            Hurwicz3_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz3_3_maliyet_pl1_MouseMove);
            Hurwicz3_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz3_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz3_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz4_3_maliyet form nesne tasarımları
        public void Hurwicz4_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz4_3_maliyet_sonuc = new Label();
            Hurwicz4_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz4_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_sonuc.Location = sonuc;
            Hurwicz4_3_maliyet_sonuc.Text = "";
            Hurwicz4_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz4_3_maliyet_pl4.Controls.Add(Hurwicz4_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Küçük maliyet ismini Label  olarak yerleştirir
            Hurwicz4_3_maliyet_sonucbaslik = new Label();
            Hurwicz4_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz4_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz4_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz4_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz4_3_maliyet_pl4.Controls.Add(Hurwicz4_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel46 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz4_3_maliyet_altoranbaslik = new Label();
            Hurwicz4_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz4_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz4_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz4_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz4_3_maliyet_pl46.Controls.Add(Hurwicz4_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel41 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz4_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz4_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz4_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz4_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz4_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz4_3_maliyet_pl41.Controls.Add(Hurwicz4_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz4_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz4_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz4_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz4_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz4_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz4_3_maliyet_pl28.Controls.Add(Hurwicz4_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel48 içerisine altoran-2 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz4_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz4_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz4_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz4_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz4_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz4_3_maliyet_pl48.Controls.Add(Hurwicz4_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel47 içerisine altoran-1 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz4_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz4_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz4_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz4_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz4_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz4_3_maliyet_pl47.Controls.Add(Hurwicz4_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri12 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri12.Location = txt_veri12;
            Hurwicz4_3_maliyet_txt_veri12.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl39.Controls.Add(Hurwicz4_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri11 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri11.Location = txt_veri11;
            Hurwicz4_3_maliyet_txt_veri11.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl38.Controls.Add(Hurwicz4_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri10 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri10.Location = txt_veri10;
            Hurwicz4_3_maliyet_txt_veri10.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl37.Controls.Add(Hurwicz4_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri9 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri9.Location = txt_veri9;
            Hurwicz4_3_maliyet_txt_veri9.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl34.Controls.Add(Hurwicz4_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri8 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri8.Location = txt_veri8;
            Hurwicz4_3_maliyet_txt_veri8.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl33.Controls.Add(Hurwicz4_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri7 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri7.Location = txt_veri7;
            Hurwicz4_3_maliyet_txt_veri7.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl32.Controls.Add(Hurwicz4_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz4_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl27.Controls.Add(Hurwicz4_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz4_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl23.Controls.Add(Hurwicz4_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz4_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl22.Controls.Add(Hurwicz4_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz4_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl26.Controls.Add(Hurwicz4_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz4_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl21.Controls.Add(Hurwicz4_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz4_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz4_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz4_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl20.Controls.Add(Hurwicz4_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel45 içerisine Minf4sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Minf4sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Minf4sonuc.Name = "txtMinf4sonuc";
            Point txt_txtMinf4sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Minf4sonuc.Location = txt_txtMinf4sonuc;
            Hurwicz4_3_maliyet_txt_Minf4sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Minf4sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Minf4sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl45.Controls.Add(Hurwicz4_3_maliyet_txt_Minf4sonuc);
            //---------------------------------------------------------------

            //panel44 içerisine Minf3sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Minf3sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Minf3sonuc.Name = "txtMinf3sonuc";
            Point txt_txtMinf3sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Minf3sonuc.Location = txt_txtMinf3sonuc;
            Hurwicz4_3_maliyet_txt_Minf3sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Minf3sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Minf3sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl44.Controls.Add(Hurwicz4_3_maliyet_txt_Minf3sonuc);
            //---------------------------------------------------------------

            //panel43 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz4_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl43.Controls.Add(Hurwicz4_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel42 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz4_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl42.Controls.Add(Hurwicz4_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine Maxf4sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Maxf4sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Maxf4sonuc.Name = "txtMaxf4sonuc";
            Point txt_txtMaxf4sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Maxf4sonuc.Location = txt_txtMaxf4sonuc;
            Hurwicz4_3_maliyet_txt_Maxf4sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Maxf4sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Maxf4sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl40.Controls.Add(Hurwicz4_3_maliyet_txt_Maxf4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine Maxf3sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Maxf3sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Maxf3sonuc.Name = "txtMaxf3sonuc";
            Point txt_txtMaxf3sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Maxf3sonuc.Location = txt_txtMaxf3sonuc;
            Hurwicz4_3_maliyet_txt_Maxf3sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Maxf3sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Maxf3sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl35.Controls.Add(Hurwicz4_3_maliyet_txt_Maxf3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz4_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl30.Controls.Add(Hurwicz4_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz4_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz4_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz4_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz4_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz4_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz4_3_maliyet_pl29.Controls.Add(Hurwicz4_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz4_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz4_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz4_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz4_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz4_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz4_3_maliyet_pl24.Controls.Add(Hurwicz4_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz4_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz4_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz4_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz4_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz4_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz4_3_maliyet_pl17.Controls.Add(Hurwicz4_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz4_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz4_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz4_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz4_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz4_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz4_3_maliyet_pl16.Controls.Add(Hurwicz4_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altbaslik4 = new TextBox();
            Hurwicz4_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            Hurwicz4_3_maliyet_txt_altbaslik4.Text = "F4";
            Hurwicz4_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altbaslik4.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altbaslik4.Multiline = true;
            Hurwicz4_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl36.Controls.Add(Hurwicz4_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altbaslik3 = new TextBox();
            Hurwicz4_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            Hurwicz4_3_maliyet_txt_altbaslik3.Text = "F3";
            Hurwicz4_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altbaslik3.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altbaslik3.Multiline = true;
            Hurwicz4_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl31.Controls.Add(Hurwicz4_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz4_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz4_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz4_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz4_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl15.Controls.Add(Hurwicz4_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz4_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz4_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz4_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz4_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl14.Controls.Add(Hurwicz4_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz4_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz4_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz4_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz4_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl13.Controls.Add(Hurwicz4_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz4_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz4_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz4_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz4_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz4_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz4_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz4_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz4_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz4_3_maliyet_pl12.Controls.Add(Hurwicz4_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel48 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(567, 237);
            Hurwicz4_3_maliyet_pl48.Location = pl48k;
            Hurwicz4_3_maliyet_pl48.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(470, 237);
            Hurwicz4_3_maliyet_pl47.Location = pl47k;
            Hurwicz4_3_maliyet_pl47.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl47);
            //-----------------------------------------

            //panel46 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz4_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(179, 237);
            Hurwicz4_3_maliyet_pl46.Location = pl46k;
            Hurwicz4_3_maliyet_pl46.Size = new Size(285, 33);
            Hurwicz4_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl46);
            //-----------------------------------------

            //panel45 oluşturuldu  f4Min-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(567, 198);
            Hurwicz4_3_maliyet_pl45.Location = pl45k;
            Hurwicz4_3_maliyet_pl45.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl45);
            //-----------------------------------------

            //panel44 oluşturuldu  f3Min-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(567, 159);
            Hurwicz4_3_maliyet_pl44.Location = pl44k;
            Hurwicz4_3_maliyet_pl44.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(567, 120);
            Hurwicz4_3_maliyet_pl43.Location = pl43k;
            Hurwicz4_3_maliyet_pl43.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(567, 81);
            Hurwicz4_3_maliyet_pl42.Location = pl42k;
            Hurwicz4_3_maliyet_pl42.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl42);
            //-----------------------------------------

            //panel41 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz4_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(567, 3);
            Hurwicz4_3_maliyet_pl41.Location = pl41k;
            Hurwicz4_3_maliyet_pl41.Size = new Size(91, 72);
            Hurwicz4_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl41);
            //-----------------------------------------

            //panel40 oluşturuldu  f4Max-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            Hurwicz4_3_maliyet_pl40.Location = pl40k;
            Hurwicz4_3_maliyet_pl40.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3Max-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz4_3_maliyet_pl35.Location = pl35k;
            Hurwicz4_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz4_3_maliyet_pl30.Location = pl30k;
            Hurwicz4_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz4_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz4_3_maliyet_pl29.Location = pl29k;
            Hurwicz4_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz4_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz4_3_maliyet_pl28.Location = pl28k;
            Hurwicz4_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz4_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            Hurwicz4_3_maliyet_pl39.Location = pl39k;
            Hurwicz4_3_maliyet_pl39.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            Hurwicz4_3_maliyet_pl38.Location = pl38k;
            Hurwicz4_3_maliyet_pl38.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            Hurwicz4_3_maliyet_pl37.Location = pl37k;
            Hurwicz4_3_maliyet_pl37.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            Hurwicz4_3_maliyet_pl34.Location = pl34k;
            Hurwicz4_3_maliyet_pl34.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            Hurwicz4_3_maliyet_pl33.Location = pl33k;
            Hurwicz4_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            Hurwicz4_3_maliyet_pl32.Location = pl32k;
            Hurwicz4_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz4_3_maliyet_pl27.Location = pl27k;
            Hurwicz4_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz4_3_maliyet_pl26.Location = pl26k;
            Hurwicz4_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz4_3_maliyet_pl23.Location = pl23k;
            Hurwicz4_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz4_3_maliyet_pl22.Location = pl22k;
            Hurwicz4_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz4_3_maliyet_pl21.Location = pl21k;
            Hurwicz4_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz4_3_maliyet_pl20.Location = pl20k;
            Hurwicz4_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz4_3_maliyet_pl25.Location = pl25k;
            Hurwicz4_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz4_3_maliyet_pl19.Location = pl19k;
            Hurwicz4_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz4_3_maliyet_pl18.Location = pl18k;
            Hurwicz4_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz4_3_maliyet_pl24.Location = pl24k;
            Hurwicz4_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz4_3_maliyet_pl17.Location = pl17k;
            Hurwicz4_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz4_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz4_3_maliyet_pl16.Location = pl16k;
            Hurwicz4_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz4_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            Hurwicz4_3_maliyet_pl36.Location = pl36k;
            Hurwicz4_3_maliyet_pl36.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            Hurwicz4_3_maliyet_pl31.Location = pl31k;
            Hurwicz4_3_maliyet_pl31.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz4_3_maliyet_pl15.Location = pl15k;
            Hurwicz4_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz4_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz4_3_maliyet_pl14.Location = pl14k;
            Hurwicz4_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz4_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz4_3_maliyet_pl13.Location = pl13k;
            Hurwicz4_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz4_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz4_3_maliyet_pl12.Location = pl12k;
            Hurwicz4_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz4_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl5.Controls.Add(Hurwicz4_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz4_3_maliyet_pl11.Name = "pl11";
            Hurwicz4_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz4_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz4_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl11.Click += new EventHandler(Hurwicz4_3_maliyet_pl11_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz4_3_maliyet_pl10.Name = "pl10";
            Hurwicz4_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz4_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl10.Click += new EventHandler(Hurwicz4_3_maliyet_pl10_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz4_3_maliyet_pl9.Name = "pl9";
            Hurwicz4_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz4_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl9.Click += new EventHandler(Hurwicz4_3_maliyet_pl9_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz4_3_maliyet_pl8.Name = "pl8";
            Hurwicz4_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz4_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl8.Click += new EventHandler(Hurwicz4_3_maliyet_pl8_Click);
            Hurwicz4_3_maliyet_pl7.Controls.Add(Hurwicz4_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz4_3_maliyet_pl6.Name = "pl6";
            Hurwicz4_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz4_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl6.Click += new EventHandler(Hurwicz4_3_maliyet_pl6_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz4_3_maliyet_btn3.Name = "btn3";
            Hurwicz4_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz4_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz4_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_btn3.Click += new EventHandler(Hurwicz4_3_maliyet_btn3_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz4_3_maliyet_btn2.Name = "btn2";
            Hurwicz4_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz4_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz4_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz4_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz4_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_btn2.Click += new EventHandler(Hurwicz4_3_maliyet_btn2_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz4_3_maliyet_btn1.Name = "btn1";
            Hurwicz4_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz4_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz4_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz4_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz4_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz4_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz4_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz4_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_btn1.Click += new EventHandler(Hurwicz4_3_maliyet_btn1_Click);
            Hurwicz4_3_maliyet_pl2.Controls.Add(Hurwicz4_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz4_3_maliyet_dr1.Name = "dr1";
            Hurwicz4_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz4_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz4_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz4_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz4_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz4_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz4_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz4_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz4_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz4_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz4_3_maliyet_dr1_CellEnter);
            Hurwicz4_3_maliyet_tb1_2.Controls.Add(Hurwicz4_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz4_3_maliyet_pl7.Name = "pl7";
            Hurwicz4_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz4_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz4_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_tb1_2.Controls.Add(Hurwicz4_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz4_3_maliyet_pl5.Name = "pl5";
            Hurwicz4_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz4_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz4_3_maliyet_pl5.AutoScroll = true;
            Hurwicz4_3_maliyet_pl5.AutoSize = true;
            Hurwicz4_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz4_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_tb1_1.Controls.Add(Hurwicz4_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz4_3_maliyet_rt1.Name = "rt1";
            Hurwicz4_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz4_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz4_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_rt1.Enabled = false;
            Hurwicz4_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz4_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz4_3_maliyet_tb1_3.Controls.Add(Hurwicz4_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz4_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz4_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz4_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz4_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_tb1.Controls.Add(Hurwicz4_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz4_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz4_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz4_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz4_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_tb1.Controls.Add(Hurwicz4_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz4_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz4_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz4_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz4_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_tb1.Controls.Add(Hurwicz4_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz4_3_maliyet_tb1.Name = "tb1";
            Hurwicz4_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz4_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz4_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz4_3_maliyet_pl3.Controls.Add(Hurwicz4_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz4_3_maliyet_pl4.Name = "pl4";
            Hurwicz4_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz4_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz4_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz4_3_maliyet_pl4_MouseUp);
            Hurwicz4_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz4_3_maliyet_pl4_MouseMove);
            Hurwicz4_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz4_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz4_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz4_3_maliyet_pl3.Name = "pl3";
            Hurwicz4_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz4_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz4_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz4_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz4_3_maliyet_pl2.Name = "pl2";
            Hurwicz4_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz4_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz4_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz4_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz4_3_maliyet_pl1.Name = "pl1";
            Hurwicz4_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz4_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz4_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz4_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz4_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz4_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz4_3_maliyet_pl1_MouseUp);
            Hurwicz4_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz4_3_maliyet_pl1_MouseMove);
            Hurwicz4_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz4_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz4_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz5_3_maliyet form nesne tasarımları
        public void Hurwicz5_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz5_3_maliyet_sonuc = new Label();
            Hurwicz5_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz5_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_sonuc.Location = sonuc;
            Hurwicz5_3_maliyet_sonuc.Text = "";
            Hurwicz5_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz5_3_maliyet_pl4.Controls.Add(Hurwicz5_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Küçük maliyet ismini Label  olarak yerleştirir
            Hurwicz5_3_maliyet_sonucbaslik = new Label();
            Hurwicz5_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz5_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz5_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz5_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz5_3_maliyet_pl4.Controls.Add(Hurwicz5_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel52 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz5_3_maliyet_altoranbaslik = new Label();
            Hurwicz5_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz5_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz5_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz5_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz5_3_maliyet_pl52.Controls.Add(Hurwicz5_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel46 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz5_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz5_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz5_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz5_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz5_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz5_3_maliyet_pl46.Controls.Add(Hurwicz5_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz5_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz5_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz5_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz5_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz5_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz5_3_maliyet_pl28.Controls.Add(Hurwicz5_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel54 içerisine altoran-2 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz5_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz5_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz5_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz5_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz5_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz5_3_maliyet_pl54.Controls.Add(Hurwicz5_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel53 içerisine altoran-1 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz5_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz5_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz5_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz5_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz5_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz5_3_maliyet_pl53.Controls.Add(Hurwicz5_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri15 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri15.Location = txt_veri15;
            Hurwicz5_3_maliyet_txt_veri15.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl44.Controls.Add(Hurwicz5_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri14 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri14.Location = txt_veri14;
            Hurwicz5_3_maliyet_txt_veri14.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl43.Controls.Add(Hurwicz5_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri13 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri13.Location = txt_veri13;
            Hurwicz5_3_maliyet_txt_veri13.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl42.Controls.Add(Hurwicz5_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri12 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri12.Location = txt_veri12;
            Hurwicz5_3_maliyet_txt_veri12.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl39.Controls.Add(Hurwicz5_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri11 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri11.Location = txt_veri11;
            Hurwicz5_3_maliyet_txt_veri11.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl38.Controls.Add(Hurwicz5_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri10 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri10.Location = txt_veri10;
            Hurwicz5_3_maliyet_txt_veri10.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl37.Controls.Add(Hurwicz5_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri9 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri9.Location = txt_veri9;
            Hurwicz5_3_maliyet_txt_veri9.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl34.Controls.Add(Hurwicz5_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri8 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri8.Location = txt_veri8;
            Hurwicz5_3_maliyet_txt_veri8.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl33.Controls.Add(Hurwicz5_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri7 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri7.Location = txt_veri7;
            Hurwicz5_3_maliyet_txt_veri7.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl32.Controls.Add(Hurwicz5_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz5_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl27.Controls.Add(Hurwicz5_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz5_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl23.Controls.Add(Hurwicz5_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz5_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl22.Controls.Add(Hurwicz5_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz5_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl26.Controls.Add(Hurwicz5_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz5_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl21.Controls.Add(Hurwicz5_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz5_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz5_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz5_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl20.Controls.Add(Hurwicz5_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel51 içerisine Minf5sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Minf5sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Minf5sonuc.Name = "txtMinf5sonuc";
            Point txt_txtMinf5sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Minf5sonuc.Location = txt_txtMinf5sonuc;
            Hurwicz5_3_maliyet_txt_Minf5sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Minf5sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Minf5sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl51.Controls.Add(Hurwicz5_3_maliyet_txt_Minf5sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine Minf4sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Minf4sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Minf4sonuc.Name = "txtMinf4sonuc";
            Point txt_txtMinf4sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Minf4sonuc.Location = txt_txtMinf4sonuc;
            Hurwicz5_3_maliyet_txt_Minf4sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Minf4sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Minf4sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl50.Controls.Add(Hurwicz5_3_maliyet_txt_Minf4sonuc);
            //---------------------------------------------------------------

            //panel49 içerisine Minf3sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Minf3sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Minf3sonuc.Name = "txtMinf3sonuc";
            Point txt_txtMinf3sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Minf3sonuc.Location = txt_txtMinf3sonuc;
            Hurwicz5_3_maliyet_txt_Minf3sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Minf3sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Minf3sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl49.Controls.Add(Hurwicz5_3_maliyet_txt_Minf3sonuc);
            //---------------------------------------------------------------

            //panel48 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz5_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl48.Controls.Add(Hurwicz5_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel47 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz5_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl47.Controls.Add(Hurwicz5_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine Maxf5sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Maxf5sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Maxf5sonuc.Name = "txtMaxf5sonuc";
            Point txt_txtMaxf5sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Maxf5sonuc.Location = txt_txtMaxf5sonuc;
            Hurwicz5_3_maliyet_txt_Maxf5sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Maxf5sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Maxf5sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl45.Controls.Add(Hurwicz5_3_maliyet_txt_Maxf5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine Maxf4sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Maxf4sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Maxf4sonuc.Name = "txtMaxf4sonuc";
            Point txt_txtMaxf4sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Maxf4sonuc.Location = txt_txtMaxf4sonuc;
            Hurwicz5_3_maliyet_txt_Maxf4sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Maxf4sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Maxf4sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl40.Controls.Add(Hurwicz5_3_maliyet_txt_Maxf4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine Maxf3sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Maxf3sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Maxf3sonuc.Name = "txtMaxf3sonuc";
            Point txt_txtMaxf3sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Maxf3sonuc.Location = txt_txtMaxf3sonuc;
            Hurwicz5_3_maliyet_txt_Maxf3sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Maxf3sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Maxf3sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl35.Controls.Add(Hurwicz5_3_maliyet_txt_Maxf3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz5_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl30.Controls.Add(Hurwicz5_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz5_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz5_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz5_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz5_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz5_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz5_3_maliyet_pl29.Controls.Add(Hurwicz5_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz5_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz5_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz5_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz5_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz5_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz5_3_maliyet_pl24.Controls.Add(Hurwicz5_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz5_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz5_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz5_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz5_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz5_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz5_3_maliyet_pl17.Controls.Add(Hurwicz5_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz5_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz5_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz5_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz5_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz5_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz5_3_maliyet_pl16.Controls.Add(Hurwicz5_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altbaslik5 = new TextBox();
            Hurwicz5_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            Hurwicz5_3_maliyet_txt_altbaslik5.Text = "F5";
            Hurwicz5_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altbaslik5.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altbaslik5.Multiline = true;
            Hurwicz5_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl41.Controls.Add(Hurwicz5_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altbaslik4 = new TextBox();
            Hurwicz5_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            Hurwicz5_3_maliyet_txt_altbaslik4.Text = "F4";
            Hurwicz5_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altbaslik4.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altbaslik4.Multiline = true;
            Hurwicz5_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl36.Controls.Add(Hurwicz5_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altbaslik3 = new TextBox();
            Hurwicz5_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            Hurwicz5_3_maliyet_txt_altbaslik3.Text = "F3";
            Hurwicz5_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altbaslik3.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altbaslik3.Multiline = true;
            Hurwicz5_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl31.Controls.Add(Hurwicz5_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz5_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz5_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz5_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz5_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl15.Controls.Add(Hurwicz5_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz5_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz5_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz5_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz5_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl14.Controls.Add(Hurwicz5_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz5_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz5_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz5_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz5_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl13.Controls.Add(Hurwicz5_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz5_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz5_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz5_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz5_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz5_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz5_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz5_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz5_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz5_3_maliyet_pl12.Controls.Add(Hurwicz5_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel54 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl54.Name = "pl54";
            Point pl54k = new Point(567, 276);
            Hurwicz5_3_maliyet_pl54.Location = pl54k;
            Hurwicz5_3_maliyet_pl54.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl54.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl53.Name = "pl53";
            Point pl53k = new Point(470, 276);
            Hurwicz5_3_maliyet_pl53.Location = pl53k;
            Hurwicz5_3_maliyet_pl53.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl53.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz5_3_maliyet_pl52.Name = "pl52";
            Point pl52k = new Point(179, 276);
            Hurwicz5_3_maliyet_pl52.Location = pl52k;
            Hurwicz5_3_maliyet_pl52.Size = new Size(285, 33);
            Hurwicz5_3_maliyet_pl52.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl52);
            //-----------------------------------------

            //panel51 oluşturuldu  f5Min-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl51.Name = "pl51";
            Point pl51k = new Point(567, 237);
            Hurwicz5_3_maliyet_pl51.Location = pl51k;
            Hurwicz5_3_maliyet_pl51.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl51.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl51);
            //-----------------------------------------

            //panel50 oluşturuldu  f4Min-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(567, 198);
            Hurwicz5_3_maliyet_pl50.Location = pl50k;
            Hurwicz5_3_maliyet_pl50.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl50);
            //-----------------------------------------

            //panel49 oluşturuldu  f3Min-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(567, 159);
            Hurwicz5_3_maliyet_pl49.Location = pl49k;
            Hurwicz5_3_maliyet_pl49.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(567, 120);
            Hurwicz5_3_maliyet_pl48.Location = pl48k;
            Hurwicz5_3_maliyet_pl48.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(567, 81);
            Hurwicz5_3_maliyet_pl47.Location = pl47k;
            Hurwicz5_3_maliyet_pl47.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl47);
            //-----------------------------------------

            //panel46 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz5_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(567, 3);
            Hurwicz5_3_maliyet_pl46.Location = pl46k;
            Hurwicz5_3_maliyet_pl46.Size = new Size(91, 72);
            Hurwicz5_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl46);
            //-----------------------------------------

            //panel45 oluşturuldu  f5Max-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            Hurwicz5_3_maliyet_pl45.Location = pl45k;
            Hurwicz5_3_maliyet_pl45.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4Max-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            Hurwicz5_3_maliyet_pl40.Location = pl40k;
            Hurwicz5_3_maliyet_pl40.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3Max-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz5_3_maliyet_pl35.Location = pl35k;
            Hurwicz5_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz5_3_maliyet_pl30.Location = pl30k;
            Hurwicz5_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz5_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz5_3_maliyet_pl29.Location = pl29k;
            Hurwicz5_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz5_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz5_3_maliyet_pl28.Location = pl28k;
            Hurwicz5_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz5_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            Hurwicz5_3_maliyet_pl44.Location = pl44k;
            Hurwicz5_3_maliyet_pl44.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            Hurwicz5_3_maliyet_pl43.Location = pl43k;
            Hurwicz5_3_maliyet_pl43.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            Hurwicz5_3_maliyet_pl42.Location = pl42k;
            Hurwicz5_3_maliyet_pl42.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            Hurwicz5_3_maliyet_pl39.Location = pl39k;
            Hurwicz5_3_maliyet_pl39.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            Hurwicz5_3_maliyet_pl38.Location = pl38k;
            Hurwicz5_3_maliyet_pl38.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            Hurwicz5_3_maliyet_pl37.Location = pl37k;
            Hurwicz5_3_maliyet_pl37.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            Hurwicz5_3_maliyet_pl34.Location = pl34k;
            Hurwicz5_3_maliyet_pl34.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            Hurwicz5_3_maliyet_pl33.Location = pl33k;
            Hurwicz5_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            Hurwicz5_3_maliyet_pl32.Location = pl32k;
            Hurwicz5_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz5_3_maliyet_pl27.Location = pl27k;
            Hurwicz5_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz5_3_maliyet_pl26.Location = pl26k;
            Hurwicz5_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz5_3_maliyet_pl23.Location = pl23k;
            Hurwicz5_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz5_3_maliyet_pl22.Location = pl22k;
            Hurwicz5_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz5_3_maliyet_pl21.Location = pl21k;
            Hurwicz5_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz5_3_maliyet_pl20.Location = pl20k;
            Hurwicz5_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz5_3_maliyet_pl25.Location = pl25k;
            Hurwicz5_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz5_3_maliyet_pl19.Location = pl19k;
            Hurwicz5_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz5_3_maliyet_pl18.Location = pl18k;
            Hurwicz5_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz5_3_maliyet_pl24.Location = pl24k;
            Hurwicz5_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz5_3_maliyet_pl17.Location = pl17k;
            Hurwicz5_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz5_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz5_3_maliyet_pl16.Location = pl16k;
            Hurwicz5_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz5_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            Hurwicz5_3_maliyet_pl41.Location = pl41k;
            Hurwicz5_3_maliyet_pl41.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            Hurwicz5_3_maliyet_pl36.Location = pl36k;
            Hurwicz5_3_maliyet_pl36.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            Hurwicz5_3_maliyet_pl31.Location = pl31k;
            Hurwicz5_3_maliyet_pl31.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz5_3_maliyet_pl15.Location = pl15k;
            Hurwicz5_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz5_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz5_3_maliyet_pl14.Location = pl14k;
            Hurwicz5_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz5_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz5_3_maliyet_pl13.Location = pl13k;
            Hurwicz5_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz5_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz5_3_maliyet_pl12.Location = pl12k;
            Hurwicz5_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz5_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl5.Controls.Add(Hurwicz5_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz5_3_maliyet_pl11.Name = "pl11";
            Hurwicz5_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz5_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz5_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl11.Click += new EventHandler(Hurwicz5_3_maliyet_pl11_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz5_3_maliyet_pl10.Name = "pl10";
            Hurwicz5_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz5_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl10.Click += new EventHandler(Hurwicz5_3_maliyet_pl10_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz5_3_maliyet_pl9.Name = "pl9";
            Hurwicz5_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz5_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl9.Click += new EventHandler(Hurwicz5_3_maliyet_pl9_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz5_3_maliyet_pl8.Name = "pl8";
            Hurwicz5_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz5_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl8.Click += new EventHandler(Hurwicz5_3_maliyet_pl8_Click);
            Hurwicz5_3_maliyet_pl7.Controls.Add(Hurwicz5_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz5_3_maliyet_pl6.Name = "pl6";
            Hurwicz5_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz5_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl6.Click += new EventHandler(Hurwicz5_3_maliyet_pl6_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz5_3_maliyet_btn3.Name = "btn3";
            Hurwicz5_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz5_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz5_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_btn3.Click += new EventHandler(Hurwicz5_3_maliyet_btn3_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz5_3_maliyet_btn2.Name = "btn2";
            Hurwicz5_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz5_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz5_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz5_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz5_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_btn2.Click += new EventHandler(Hurwicz5_3_maliyet_btn2_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz5_3_maliyet_btn1.Name = "btn1";
            Hurwicz5_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz5_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz5_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz5_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz5_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz5_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz5_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz5_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_btn1.Click += new EventHandler(Hurwicz5_3_maliyet_btn1_Click);
            Hurwicz5_3_maliyet_pl2.Controls.Add(Hurwicz5_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz5_3_maliyet_dr1.Name = "dr1";
            Hurwicz5_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz5_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz5_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz5_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz5_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz5_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz5_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz5_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz5_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz5_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz5_3_maliyet_dr1_CellEnter);
            Hurwicz5_3_maliyet_tb1_2.Controls.Add(Hurwicz5_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz5_3_maliyet_pl7.Name = "pl7";
            Hurwicz5_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz5_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz5_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_tb1_2.Controls.Add(Hurwicz5_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz5_3_maliyet_pl5.Name = "pl5";
            Hurwicz5_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz5_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz5_3_maliyet_pl5.AutoScroll = true;
            Hurwicz5_3_maliyet_pl5.AutoSize = true;
            Hurwicz5_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz5_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_tb1_1.Controls.Add(Hurwicz5_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz5_3_maliyet_rt1.Name = "rt1";
            Hurwicz5_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz5_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz5_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_rt1.Enabled = false;
            Hurwicz5_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz5_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz5_3_maliyet_tb1_3.Controls.Add(Hurwicz5_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz5_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz5_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz5_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz5_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_tb1.Controls.Add(Hurwicz5_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz5_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz5_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz5_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz5_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_tb1.Controls.Add(Hurwicz5_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz5_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz5_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz5_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz5_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_tb1.Controls.Add(Hurwicz5_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz5_3_maliyet_tb1.Name = "tb1";
            Hurwicz5_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz5_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz5_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz5_3_maliyet_pl3.Controls.Add(Hurwicz5_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz5_3_maliyet_pl4.Name = "pl4";
            Hurwicz5_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz5_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz5_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz5_3_maliyet_pl4_MouseUp);
            Hurwicz5_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz5_3_maliyet_pl4_MouseMove);
            Hurwicz5_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz5_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz5_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz5_3_maliyet_pl3.Name = "pl3";
            Hurwicz5_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz5_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz5_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz5_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz5_3_maliyet_pl2.Name = "pl2";
            Hurwicz5_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz5_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz5_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz5_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz5_3_maliyet_pl1.Name = "pl1";
            Hurwicz5_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz5_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz5_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz5_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz5_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz5_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz5_3_maliyet_pl1_MouseUp);
            Hurwicz5_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz5_3_maliyet_pl1_MouseMove);
            Hurwicz5_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz5_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz5_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz6_3_maliyet form nesne tasarımları
        public void Hurwicz6_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz6_3_maliyet_sonuc = new Label();
            Hurwicz6_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz6_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_sonuc.Location = sonuc;
            Hurwicz6_3_maliyet_sonuc.Text = "";
            Hurwicz6_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz6_3_maliyet_pl4.Controls.Add(Hurwicz6_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Küçük maliyet ismini Label  olarak yerleştirir
            Hurwicz6_3_maliyet_sonucbaslik = new Label();
            Hurwicz6_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz6_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz6_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz6_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz6_3_maliyet_pl4.Controls.Add(Hurwicz6_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel58 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz6_3_maliyet_altoranbaslik = new Label();
            Hurwicz6_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz6_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz6_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz6_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz6_3_maliyet_pl58.Controls.Add(Hurwicz6_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel51 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz6_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz6_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz6_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz6_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz6_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz6_3_maliyet_pl51.Controls.Add(Hurwicz6_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz6_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz6_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz6_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz6_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz6_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz6_3_maliyet_pl28.Controls.Add(Hurwicz6_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel60 içerisine altoran-2 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz6_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz6_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz6_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz6_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz6_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz6_3_maliyet_pl60.Controls.Add(Hurwicz6_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel59 içerisine altoran-1 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz6_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz6_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz6_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz6_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz6_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz6_3_maliyet_pl59.Controls.Add(Hurwicz6_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri18 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri18.Location = txt_veri18;
            Hurwicz6_3_maliyet_txt_veri18.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl49.Controls.Add(Hurwicz6_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri17 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri17.Location = txt_veri17;
            Hurwicz6_3_maliyet_txt_veri17.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl48.Controls.Add(Hurwicz6_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri16 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri16.Location = txt_veri16;
            Hurwicz6_3_maliyet_txt_veri16.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl47.Controls.Add(Hurwicz6_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri15 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri15.Location = txt_veri15;
            Hurwicz6_3_maliyet_txt_veri15.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl44.Controls.Add(Hurwicz6_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri14 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri14.Location = txt_veri14;
            Hurwicz6_3_maliyet_txt_veri14.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl43.Controls.Add(Hurwicz6_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri13 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri13.Location = txt_veri13;
            Hurwicz6_3_maliyet_txt_veri13.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl42.Controls.Add(Hurwicz6_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri12 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri12.Location = txt_veri12;
            Hurwicz6_3_maliyet_txt_veri12.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl39.Controls.Add(Hurwicz6_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri11 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri11.Location = txt_veri11;
            Hurwicz6_3_maliyet_txt_veri11.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl38.Controls.Add(Hurwicz6_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri10 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri10.Location = txt_veri10;
            Hurwicz6_3_maliyet_txt_veri10.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl37.Controls.Add(Hurwicz6_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri9 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri9.Location = txt_veri9;
            Hurwicz6_3_maliyet_txt_veri9.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl34.Controls.Add(Hurwicz6_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri8 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri8.Location = txt_veri8;
            Hurwicz6_3_maliyet_txt_veri8.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl33.Controls.Add(Hurwicz6_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri7 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri7.Location = txt_veri7;
            Hurwicz6_3_maliyet_txt_veri7.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl32.Controls.Add(Hurwicz6_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz6_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl27.Controls.Add(Hurwicz6_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz6_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl23.Controls.Add(Hurwicz6_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz6_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl22.Controls.Add(Hurwicz6_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz6_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl26.Controls.Add(Hurwicz6_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz6_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl21.Controls.Add(Hurwicz6_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz6_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz6_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz6_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl20.Controls.Add(Hurwicz6_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel57 içerisine Minf6sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf6sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf6sonuc.Name = "txtMinf6sonuc";
            Point txt_txtMinf6sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf6sonuc.Location = txt_txtMinf6sonuc;
            Hurwicz6_3_maliyet_txt_Minf6sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf6sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf6sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl57.Controls.Add(Hurwicz6_3_maliyet_txt_Minf6sonuc);
            //---------------------------------------------------------------

            //panel56 içerisine Minf5sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf5sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf5sonuc.Name = "txtMinf5sonuc";
            Point txt_txtMinf5sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf5sonuc.Location = txt_txtMinf5sonuc;
            Hurwicz6_3_maliyet_txt_Minf5sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf5sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf5sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl56.Controls.Add(Hurwicz6_3_maliyet_txt_Minf5sonuc);
            //---------------------------------------------------------------

            //panel55 içerisine Minf4sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf4sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf4sonuc.Name = "txtMinf4sonuc";
            Point txt_txtMinf4sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf4sonuc.Location = txt_txtMinf4sonuc;
            Hurwicz6_3_maliyet_txt_Minf4sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf4sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf4sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl55.Controls.Add(Hurwicz6_3_maliyet_txt_Minf4sonuc);
            //---------------------------------------------------------------

            //panel54 içerisine Minf3sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf3sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf3sonuc.Name = "txtMinf3sonuc";
            Point txt_txtMinf3sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf3sonuc.Location = txt_txtMinf3sonuc;
            Hurwicz6_3_maliyet_txt_Minf3sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf3sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf3sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl54.Controls.Add(Hurwicz6_3_maliyet_txt_Minf3sonuc);
            //---------------------------------------------------------------

            //panel53 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz6_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl53.Controls.Add(Hurwicz6_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel52 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz6_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl52.Controls.Add(Hurwicz6_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine Maxf6sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf6sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf6sonuc.Name = "txtMaxf6sonuc";
            Point txt_txtMaxf6sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf6sonuc.Location = txt_txtMaxf6sonuc;
            Hurwicz6_3_maliyet_txt_Maxf6sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf6sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf6sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl50.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine Maxf5sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf5sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf5sonuc.Name = "txtMaxf5sonuc";
            Point txt_txtMaxf5sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf5sonuc.Location = txt_txtMaxf5sonuc;
            Hurwicz6_3_maliyet_txt_Maxf5sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf5sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf5sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl45.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine Maxf4sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf4sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf4sonuc.Name = "txtMaxf4sonuc";
            Point txt_txtMaxf4sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf4sonuc.Location = txt_txtMaxf4sonuc;
            Hurwicz6_3_maliyet_txt_Maxf4sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf4sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf4sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl40.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine Maxf3sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf3sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf3sonuc.Name = "txtMaxf3sonuc";
            Point txt_txtMaxf3sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf3sonuc.Location = txt_txtMaxf3sonuc;
            Hurwicz6_3_maliyet_txt_Maxf3sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf3sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf3sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl35.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz6_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl30.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz6_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz6_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz6_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz6_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz6_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz6_3_maliyet_pl29.Controls.Add(Hurwicz6_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz6_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz6_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz6_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz6_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz6_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz6_3_maliyet_pl24.Controls.Add(Hurwicz6_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz6_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz6_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz6_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz6_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz6_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz6_3_maliyet_pl17.Controls.Add(Hurwicz6_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz6_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz6_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz6_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz6_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz6_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz6_3_maliyet_pl16.Controls.Add(Hurwicz6_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik6 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            Hurwicz6_3_maliyet_txt_altbaslik6.Text = "F6";
            Hurwicz6_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik6.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik6.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl46.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik5 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            Hurwicz6_3_maliyet_txt_altbaslik5.Text = "F5";
            Hurwicz6_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik5.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik5.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl41.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik4 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            Hurwicz6_3_maliyet_txt_altbaslik4.Text = "F4";
            Hurwicz6_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik4.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik4.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl36.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik3 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            Hurwicz6_3_maliyet_txt_altbaslik3.Text = "F3";
            Hurwicz6_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik3.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik3.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl31.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz6_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz6_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl15.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz6_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz6_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz6_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz6_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl14.Controls.Add(Hurwicz6_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz6_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz6_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz6_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz6_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl13.Controls.Add(Hurwicz6_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz6_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz6_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz6_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz6_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz6_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz6_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz6_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz6_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz6_3_maliyet_pl12.Controls.Add(Hurwicz6_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel60 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl60.Name = "pl60";
            Point pl60k = new Point(567, 315);
            Hurwicz6_3_maliyet_pl60.Location = pl60k;
            Hurwicz6_3_maliyet_pl60.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl60.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl60);
            //-----------------------------------------

            //panel59 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl59.Name = "pl59";
            Point pl59k = new Point(470, 315);
            Hurwicz6_3_maliyet_pl59.Location = pl59k;
            Hurwicz6_3_maliyet_pl59.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl59.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl59);
            //-----------------------------------------

            //panel58 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz6_3_maliyet_pl58.Name = "pl58";
            Point pl58k = new Point(179, 315);
            Hurwicz6_3_maliyet_pl58.Location = pl58k;
            Hurwicz6_3_maliyet_pl58.Size = new Size(285, 33);
            Hurwicz6_3_maliyet_pl58.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl58);
            //-----------------------------------------

            //panel57 oluşturuldu  f6Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl57.Name = "pl57";
            Point pl57k = new Point(567, 276);
            Hurwicz6_3_maliyet_pl57.Location = pl57k;
            Hurwicz6_3_maliyet_pl57.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl57.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl57);
            //-----------------------------------------

            //panel56 oluşturuldu  f5Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl56.Name = "pl56";
            Point pl56k = new Point(567, 237);
            Hurwicz6_3_maliyet_pl56.Location = pl56k;
            Hurwicz6_3_maliyet_pl56.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl56.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl56);
            //-----------------------------------------

            //panel55 oluşturuldu  f4Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl55.Name = "pl55";
            Point pl55k = new Point(567, 198);
            Hurwicz6_3_maliyet_pl55.Location = pl55k;
            Hurwicz6_3_maliyet_pl55.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl55.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl55);
            //-----------------------------------------

            //panel54 oluşturuldu  f3Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl54.Name = "pl54";
            Point pl54k = new Point(567, 159);
            Hurwicz6_3_maliyet_pl54.Location = pl54k;
            Hurwicz6_3_maliyet_pl54.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl54.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl53.Name = "pl53";
            Point pl53k = new Point(567, 120);
            Hurwicz6_3_maliyet_pl53.Location = pl53k;
            Hurwicz6_3_maliyet_pl53.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl53.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl52.Name = "pl52";
            Point pl52k = new Point(567, 81);
            Hurwicz6_3_maliyet_pl52.Location = pl52k;
            Hurwicz6_3_maliyet_pl52.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl52.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl52);
            //-----------------------------------------

            //panel51 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz6_3_maliyet_pl51.Name = "pl51";
            Point pl51k = new Point(567, 3);
            Hurwicz6_3_maliyet_pl51.Location = pl51k;
            Hurwicz6_3_maliyet_pl51.Size = new Size(91, 72);
            Hurwicz6_3_maliyet_pl51.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl51);
            //-----------------------------------------

            //panel50 oluşturuldu  f6Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            Hurwicz6_3_maliyet_pl50.Location = pl50k;
            Hurwicz6_3_maliyet_pl50.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            Hurwicz6_3_maliyet_pl45.Location = pl45k;
            Hurwicz6_3_maliyet_pl45.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            Hurwicz6_3_maliyet_pl40.Location = pl40k;
            Hurwicz6_3_maliyet_pl40.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz6_3_maliyet_pl35.Location = pl35k;
            Hurwicz6_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz6_3_maliyet_pl30.Location = pl30k;
            Hurwicz6_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz6_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz6_3_maliyet_pl29.Location = pl29k;
            Hurwicz6_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz6_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz6_3_maliyet_pl28.Location = pl28k;
            Hurwicz6_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz6_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            Hurwicz6_3_maliyet_pl49.Location = pl49k;
            Hurwicz6_3_maliyet_pl49.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            Hurwicz6_3_maliyet_pl48.Location = pl48k;
            Hurwicz6_3_maliyet_pl48.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            Hurwicz6_3_maliyet_pl47.Location = pl47k;
            Hurwicz6_3_maliyet_pl47.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            Hurwicz6_3_maliyet_pl44.Location = pl44k;
            Hurwicz6_3_maliyet_pl44.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            Hurwicz6_3_maliyet_pl43.Location = pl43k;
            Hurwicz6_3_maliyet_pl43.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            Hurwicz6_3_maliyet_pl42.Location = pl42k;
            Hurwicz6_3_maliyet_pl42.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            Hurwicz6_3_maliyet_pl39.Location = pl39k;
            Hurwicz6_3_maliyet_pl39.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            Hurwicz6_3_maliyet_pl38.Location = pl38k;
            Hurwicz6_3_maliyet_pl38.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            Hurwicz6_3_maliyet_pl37.Location = pl37k;
            Hurwicz6_3_maliyet_pl37.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            Hurwicz6_3_maliyet_pl34.Location = pl34k;
            Hurwicz6_3_maliyet_pl34.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            Hurwicz6_3_maliyet_pl33.Location = pl33k;
            Hurwicz6_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            Hurwicz6_3_maliyet_pl32.Location = pl32k;
            Hurwicz6_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz6_3_maliyet_pl27.Location = pl27k;
            Hurwicz6_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz6_3_maliyet_pl26.Location = pl26k;
            Hurwicz6_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz6_3_maliyet_pl23.Location = pl23k;
            Hurwicz6_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz6_3_maliyet_pl22.Location = pl22k;
            Hurwicz6_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz6_3_maliyet_pl21.Location = pl21k;
            Hurwicz6_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz6_3_maliyet_pl20.Location = pl20k;
            Hurwicz6_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz6_3_maliyet_pl25.Location = pl25k;
            Hurwicz6_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz6_3_maliyet_pl19.Location = pl19k;
            Hurwicz6_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz6_3_maliyet_pl18.Location = pl18k;
            Hurwicz6_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz6_3_maliyet_pl24.Location = pl24k;
            Hurwicz6_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz6_3_maliyet_pl17.Location = pl17k;
            Hurwicz6_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz6_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz6_3_maliyet_pl16.Location = pl16k;
            Hurwicz6_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz6_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            Hurwicz6_3_maliyet_pl46.Location = pl46k;
            Hurwicz6_3_maliyet_pl46.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            Hurwicz6_3_maliyet_pl41.Location = pl41k;
            Hurwicz6_3_maliyet_pl41.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            Hurwicz6_3_maliyet_pl36.Location = pl36k;
            Hurwicz6_3_maliyet_pl36.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            Hurwicz6_3_maliyet_pl31.Location = pl31k;
            Hurwicz6_3_maliyet_pl31.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz6_3_maliyet_pl15.Location = pl15k;
            Hurwicz6_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz6_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz6_3_maliyet_pl14.Location = pl14k;
            Hurwicz6_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz6_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz6_3_maliyet_pl13.Location = pl13k;
            Hurwicz6_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz6_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz6_3_maliyet_pl12.Location = pl12k;
            Hurwicz6_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz6_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl5.Controls.Add(Hurwicz6_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz6_3_maliyet_pl11.Name = "pl11";
            Hurwicz6_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz6_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz6_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl11.Click += new EventHandler(Hurwicz6_3_maliyet_pl11_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz6_3_maliyet_pl10.Name = "pl10";
            Hurwicz6_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz6_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl10.Click += new EventHandler(Hurwicz6_3_maliyet_pl10_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz6_3_maliyet_pl9.Name = "pl9";
            Hurwicz6_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz6_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl9.Click += new EventHandler(Hurwicz6_3_maliyet_pl9_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz6_3_maliyet_pl8.Name = "pl8";
            Hurwicz6_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz6_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl8.Click += new EventHandler(Hurwicz6_3_maliyet_pl8_Click);
            Hurwicz6_3_maliyet_pl7.Controls.Add(Hurwicz6_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz6_3_maliyet_pl6.Name = "pl6";
            Hurwicz6_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz6_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl6.Click += new EventHandler(Hurwicz6_3_maliyet_pl6_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz6_3_maliyet_btn3.Name = "btn3";
            Hurwicz6_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz6_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz6_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_btn3.Click += new EventHandler(Hurwicz6_3_maliyet_btn3_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz6_3_maliyet_btn2.Name = "btn2";
            Hurwicz6_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz6_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz6_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz6_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz6_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_btn2.Click += new EventHandler(Hurwicz6_3_maliyet_btn2_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz6_3_maliyet_btn1.Name = "btn1";
            Hurwicz6_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz6_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz6_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz6_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz6_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz6_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz6_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz6_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_btn1.Click += new EventHandler(Hurwicz6_3_maliyet_btn1_Click);
            Hurwicz6_3_maliyet_pl2.Controls.Add(Hurwicz6_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz6_3_maliyet_dr1.Name = "dr1";
            Hurwicz6_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz6_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz6_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz6_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz6_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz6_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz6_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz6_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz6_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz6_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz6_3_maliyet_dr1_CellEnter);
            Hurwicz6_3_maliyet_tb1_2.Controls.Add(Hurwicz6_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz6_3_maliyet_pl7.Name = "pl7";
            Hurwicz6_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz6_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz6_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_tb1_2.Controls.Add(Hurwicz6_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz6_3_maliyet_pl5.Name = "pl5";
            Hurwicz6_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz6_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz6_3_maliyet_pl5.AutoScroll = true;
            Hurwicz6_3_maliyet_pl5.AutoSize = true;
            Hurwicz6_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz6_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_tb1_1.Controls.Add(Hurwicz6_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz6_3_maliyet_rt1.Name = "rt1";
            Hurwicz6_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz6_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz6_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_rt1.Enabled = false;
            Hurwicz6_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz6_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz6_3_maliyet_tb1_3.Controls.Add(Hurwicz6_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz6_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz6_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz6_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz6_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_tb1.Controls.Add(Hurwicz6_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz6_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz6_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz6_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz6_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_tb1.Controls.Add(Hurwicz6_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz6_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz6_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz6_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz6_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_tb1.Controls.Add(Hurwicz6_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz6_3_maliyet_tb1.Name = "tb1";
            Hurwicz6_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz6_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz6_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz6_3_maliyet_pl3.Controls.Add(Hurwicz6_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz6_3_maliyet_pl4.Name = "pl4";
            Hurwicz6_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz6_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz6_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz6_3_maliyet_pl4_MouseUp);
            Hurwicz6_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz6_3_maliyet_pl4_MouseMove);
            Hurwicz6_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz6_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz6_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz6_3_maliyet_pl3.Name = "pl3";
            Hurwicz6_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz6_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz6_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz6_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz6_3_maliyet_pl2.Name = "pl2";
            Hurwicz6_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz6_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz6_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz6_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz6_3_maliyet_pl1.Name = "pl1";
            Hurwicz6_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz6_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz6_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz6_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz6_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz6_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz6_3_maliyet_pl1_MouseUp);
            Hurwicz6_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz6_3_maliyet_pl1_MouseMove);
            Hurwicz6_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz6_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz6_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz7_3_maliyet form nesne tasarımları
        public void Hurwicz7_3_maliyet()
        {
            // panel4 içerisine maliyet sonucunu Label  olarak yerleştirir
            Hurwicz7_3_maliyet_sonuc = new Label();
            Hurwicz7_3_maliyet_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            Hurwicz7_3_maliyet_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_sonuc.Location = sonuc;
            Hurwicz7_3_maliyet_sonuc.Text = "";
            Hurwicz7_3_maliyet_sonuc.Size = new Size(650, 13);
            Hurwicz7_3_maliyet_pl4.Controls.Add(Hurwicz7_3_maliyet_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Küçük maliyet ismini Label  olarak yerleştirir
            Hurwicz7_3_maliyet_sonucbaslik = new Label();
            Hurwicz7_3_maliyet_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            Hurwicz7_3_maliyet_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_sonucbaslik.Location = sonucbaslik;
            Hurwicz7_3_maliyet_sonucbaslik.Text = "En Küçük Maliyet:";
            Hurwicz7_3_maliyet_sonucbaslik.Size = new Size(93, 13);
            Hurwicz7_3_maliyet_pl4.Controls.Add(Hurwicz7_3_maliyet_sonucbaslik);
            //---------------------------------------------------------------

            // panel64 içerisine altoranbaslik Label  olarak yerleştirir
            Hurwicz7_3_maliyet_altoranbaslik = new Label();
            Hurwicz7_3_maliyet_altoranbaslik.Name = "altoranbaslik";
            Point altoranbaslik = new Point(115, 9);
            Hurwicz7_3_maliyet_altoranbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_altoranbaslik.Location = altoranbaslik;
            Hurwicz7_3_maliyet_altoranbaslik.Text = "Oranlar";
            Hurwicz7_3_maliyet_altoranbaslik.Size = new Size(41, 13);
            Hurwicz7_3_maliyet_pl64.Controls.Add(Hurwicz7_3_maliyet_altoranbaslik);
            //---------------------------------------------------------------

            // panel56 içerisine Minsonucbaslik Label  olarak yerleştirir
            Hurwicz7_3_maliyet_Minsonucbaslik = new Label();
            Hurwicz7_3_maliyet_Minsonucbaslik.Name = "Minsonucbaslik";
            Point Minsonucbaslik = new Point(28, 29);
            Hurwicz7_3_maliyet_Minsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_Minsonucbaslik.Location = Minsonucbaslik;
            Hurwicz7_3_maliyet_Minsonucbaslik.Text = "Min";
            Hurwicz7_3_maliyet_Minsonucbaslik.Size = new Size(24, 13);
            Hurwicz7_3_maliyet_pl56.Controls.Add(Hurwicz7_3_maliyet_Minsonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine Maxsonucbaslik Label  olarak yerleştirir
            Hurwicz7_3_maliyet_Maxsonucbaslik = new Label();
            Hurwicz7_3_maliyet_Maxsonucbaslik.Name = "Maxsonucbaslik";
            Point Maxsonucbaslik = new Point(30, 29);
            Hurwicz7_3_maliyet_Maxsonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_Maxsonucbaslik.Location = Maxsonucbaslik;
            Hurwicz7_3_maliyet_Maxsonucbaslik.Text = "Max";
            Hurwicz7_3_maliyet_Maxsonucbaslik.Size = new Size(27, 13);
            Hurwicz7_3_maliyet_pl28.Controls.Add(Hurwicz7_3_maliyet_Maxsonucbaslik);
            //---------------------------------------------------------------

            //panel66 içerisine altoran-2 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altoran2 = new TextBox();
            Hurwicz7_3_maliyet_txt_altoran2.Name = "altoran2";
            Point txt_txtaltoran2 = new Point(3, 10);
            Hurwicz7_3_maliyet_txt_altoran2.Location = txt_txtaltoran2;
            Hurwicz7_3_maliyet_txt_altoran2.Text = "0,30";
            Hurwicz7_3_maliyet_txt_altoran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altoran2.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altoran2.Multiline = true;
            Hurwicz7_3_maliyet_txt_altoran2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altoran2.Size = new Size(85, 13);
            Hurwicz7_3_maliyet_pl66.Controls.Add(Hurwicz7_3_maliyet_txt_altoran2);
            //---------------------------------------------------------------

            //panel65 içerisine altoran-1 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altoran1 = new TextBox();
            Hurwicz7_3_maliyet_txt_altoran1.Name = "altoran1";
            Point txt_txtaltoran1 = new Point(3, 10);
            Hurwicz7_3_maliyet_txt_altoran1.Location = txt_txtaltoran1;
            Hurwicz7_3_maliyet_txt_altoran1.Text = "0,70";
            Hurwicz7_3_maliyet_txt_altoran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altoran1.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altoran1.Multiline = true;
            Hurwicz7_3_maliyet_txt_altoran1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altoran1.Size = new Size(85, 13);
            Hurwicz7_3_maliyet_pl65.Controls.Add(Hurwicz7_3_maliyet_txt_altoran1);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri21 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri21.Location = txt_veri21;
            Hurwicz7_3_maliyet_txt_veri21.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl54.Controls.Add(Hurwicz7_3_maliyet_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri20 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri20.Location = txt_veri20;
            Hurwicz7_3_maliyet_txt_veri20.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl53.Controls.Add(Hurwicz7_3_maliyet_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri19 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri19.Location = txt_veri19;
            Hurwicz7_3_maliyet_txt_veri19.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl52.Controls.Add(Hurwicz7_3_maliyet_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri18 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri18.Location = txt_veri18;
            Hurwicz7_3_maliyet_txt_veri18.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl49.Controls.Add(Hurwicz7_3_maliyet_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri17 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri17.Location = txt_veri17;
            Hurwicz7_3_maliyet_txt_veri17.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl48.Controls.Add(Hurwicz7_3_maliyet_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri16 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri16.Location = txt_veri16;
            Hurwicz7_3_maliyet_txt_veri16.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl47.Controls.Add(Hurwicz7_3_maliyet_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri15 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri15.Location = txt_veri15;
            Hurwicz7_3_maliyet_txt_veri15.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl44.Controls.Add(Hurwicz7_3_maliyet_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri14 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri14.Location = txt_veri14;
            Hurwicz7_3_maliyet_txt_veri14.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl43.Controls.Add(Hurwicz7_3_maliyet_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri13 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri13.Location = txt_veri13;
            Hurwicz7_3_maliyet_txt_veri13.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl42.Controls.Add(Hurwicz7_3_maliyet_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri12 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri12.Location = txt_veri12;
            Hurwicz7_3_maliyet_txt_veri12.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl39.Controls.Add(Hurwicz7_3_maliyet_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri11 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri11.Location = txt_veri11;
            Hurwicz7_3_maliyet_txt_veri11.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl38.Controls.Add(Hurwicz7_3_maliyet_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri10 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri10.Location = txt_veri10;
            Hurwicz7_3_maliyet_txt_veri10.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl37.Controls.Add(Hurwicz7_3_maliyet_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri9 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri9.Location = txt_veri9;
            Hurwicz7_3_maliyet_txt_veri9.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl34.Controls.Add(Hurwicz7_3_maliyet_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri8 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri8.Location = txt_veri8;
            Hurwicz7_3_maliyet_txt_veri8.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl33.Controls.Add(Hurwicz7_3_maliyet_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri7 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri7.Location = txt_veri7;
            Hurwicz7_3_maliyet_txt_veri7.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl32.Controls.Add(Hurwicz7_3_maliyet_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri6 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri6.Location = txt_veri6;
            Hurwicz7_3_maliyet_txt_veri6.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl27.Controls.Add(Hurwicz7_3_maliyet_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri5 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri5.Location = txt_veri5;
            Hurwicz7_3_maliyet_txt_veri5.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl23.Controls.Add(Hurwicz7_3_maliyet_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri4 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri4.Location = txt_veri4;
            Hurwicz7_3_maliyet_txt_veri4.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl22.Controls.Add(Hurwicz7_3_maliyet_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri3 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri3.Location = txt_veri3;
            Hurwicz7_3_maliyet_txt_veri3.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl26.Controls.Add(Hurwicz7_3_maliyet_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri2 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri2.Location = txt_veri2;
            Hurwicz7_3_maliyet_txt_veri2.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl21.Controls.Add(Hurwicz7_3_maliyet_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_veri1 = new NumericUpDown();
            Hurwicz7_3_maliyet_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            Hurwicz7_3_maliyet_txt_veri1.Location = txt_veri1;
            Hurwicz7_3_maliyet_txt_veri1.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl20.Controls.Add(Hurwicz7_3_maliyet_txt_veri1);
            //---------------------------------------------------------------

            //panel63 içerisine Minf7sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf7sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf7sonuc.Name = "txtMinf7sonuc";
            Point txt_txtMinf7sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf7sonuc.Location = txt_txtMinf7sonuc;
            Hurwicz7_3_maliyet_txt_Minf7sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf7sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf7sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl63.Controls.Add(Hurwicz7_3_maliyet_txt_Minf7sonuc);
            //---------------------------------------------------------------

            //panel62 içerisine Minf6sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf6sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf6sonuc.Name = "txtMinf6sonuc";
            Point txt_txtMinf6sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf6sonuc.Location = txt_txtMinf6sonuc;
            Hurwicz7_3_maliyet_txt_Minf6sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf6sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf6sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl62.Controls.Add(Hurwicz7_3_maliyet_txt_Minf6sonuc);
            //---------------------------------------------------------------

            //panel61 içerisine Minf5sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf5sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf5sonuc.Name = "txtMinf5sonuc";
            Point txt_txtMinf5sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf5sonuc.Location = txt_txtMinf5sonuc;
            Hurwicz7_3_maliyet_txt_Minf5sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf5sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf5sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl61.Controls.Add(Hurwicz7_3_maliyet_txt_Minf5sonuc);
            //---------------------------------------------------------------

            //panel60 içerisine Minf4sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf4sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf4sonuc.Name = "txtMinf4sonuc";
            Point txt_txtMinf4sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf4sonuc.Location = txt_txtMinf4sonuc;
            Hurwicz7_3_maliyet_txt_Minf4sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf4sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf4sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl60.Controls.Add(Hurwicz7_3_maliyet_txt_Minf4sonuc);
            //---------------------------------------------------------------

            //panel59 içerisine Minf3sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf3sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf3sonuc.Name = "txtMinf3sonuc";
            Point txt_txtMinf3sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf3sonuc.Location = txt_txtMinf3sonuc;
            Hurwicz7_3_maliyet_txt_Minf3sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf3sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf3sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl59.Controls.Add(Hurwicz7_3_maliyet_txt_Minf3sonuc);
            //---------------------------------------------------------------

            //panel58 içerisine Minf2sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf2sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf2sonuc.Name = "txtMinf2sonuc";
            Point txt_txtMinf2sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf2sonuc.Location = txt_txtMinf2sonuc;
            Hurwicz7_3_maliyet_txt_Minf2sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf2sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf2sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl58.Controls.Add(Hurwicz7_3_maliyet_txt_Minf2sonuc);
            //---------------------------------------------------------------

            //panel57 içerisine Minf1sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Minf1sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Minf1sonuc.Name = "txtMinf1sonuc";
            Point txt_txtMinf1sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Minf1sonuc.Location = txt_txtMinf1sonuc;
            Hurwicz7_3_maliyet_txt_Minf1sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Minf1sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Minf1sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl57.Controls.Add(Hurwicz7_3_maliyet_txt_Minf1sonuc);
            //---------------------------------------------------------------

            //panel55 içerisine Maxf7sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf7sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf7sonuc.Name = "txtMaxf7sonuc";
            Point txt_txtMaxf7sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf7sonuc.Location = txt_txtMaxf7sonuc;
            Hurwicz7_3_maliyet_txt_Maxf7sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf7sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf7sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl55.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine Maxf6sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf6sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf6sonuc.Name = "txtMaxf6sonuc";
            Point txt_txtMaxf6sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf6sonuc.Location = txt_txtMaxf6sonuc;
            Hurwicz7_3_maliyet_txt_Maxf6sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf6sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf6sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl50.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine Maxf5sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf5sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf5sonuc.Name = "txtMaxf5sonuc";
            Point txt_txtMaxf5sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf5sonuc.Location = txt_txtMaxf5sonuc;
            Hurwicz7_3_maliyet_txt_Maxf5sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf5sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf5sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl45.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine Maxf4sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf4sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf4sonuc.Name = "txtMaxf4sonuc";
            Point txt_txtMaxf4sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf4sonuc.Location = txt_txtMaxf4sonuc;
            Hurwicz7_3_maliyet_txt_Maxf4sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf4sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf4sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl40.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine Maxf3sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf3sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf3sonuc.Name = "txtMaxf3sonuc";
            Point txt_txtMaxf3sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf3sonuc.Location = txt_txtMaxf3sonuc;
            Hurwicz7_3_maliyet_txt_Maxf3sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf3sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf3sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl35.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine Maxf2sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf2sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf2sonuc.Name = "txtMaxf2sonuc";
            Point txt_txtMaxf2sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf2sonuc.Location = txt_txtMaxf2sonuc;
            Hurwicz7_3_maliyet_txt_Maxf2sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf2sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf2sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl30.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine Maxf1sonuc textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_Maxf1sonuc = new TextBox();
            Hurwicz7_3_maliyet_txt_Maxf1sonuc.Name = "txtMaxf1sonuc";
            Point txt_txtMaxf1sonuc = new Point(3, 7);
            Hurwicz7_3_maliyet_txt_Maxf1sonuc.Location = txt_txtMaxf1sonuc;
            Hurwicz7_3_maliyet_txt_Maxf1sonuc.Text = "0";
            Hurwicz7_3_maliyet_txt_Maxf1sonuc.Enabled = false;
            Hurwicz7_3_maliyet_txt_Maxf1sonuc.Size = new Size(85, 20);
            Hurwicz7_3_maliyet_pl29.Controls.Add(Hurwicz7_3_maliyet_txt_Maxf1sonuc);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_üstbaslik3 = new TextBox();
            Hurwicz7_3_maliyet_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            Hurwicz7_3_maliyet_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            Hurwicz7_3_maliyet_txt_üstbaslik3.Text = "Yüksek";
            Hurwicz7_3_maliyet_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_üstbaslik3.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_üstbaslik3.Multiline = true;
            Hurwicz7_3_maliyet_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_üstbaslik3.Size = new Size(85, 13);
            Hurwicz7_3_maliyet_pl24.Controls.Add(Hurwicz7_3_maliyet_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_üstbaslik2 = new TextBox();
            Hurwicz7_3_maliyet_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            Hurwicz7_3_maliyet_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            Hurwicz7_3_maliyet_txt_üstbaslik2.Text = "Orta";
            Hurwicz7_3_maliyet_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_üstbaslik2.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_üstbaslik2.Multiline = true;
            Hurwicz7_3_maliyet_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_üstbaslik2.Size = new Size(85, 13);
            Hurwicz7_3_maliyet_pl17.Controls.Add(Hurwicz7_3_maliyet_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_üstbaslik1 = new TextBox();
            Hurwicz7_3_maliyet_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            Hurwicz7_3_maliyet_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            Hurwicz7_3_maliyet_txt_üstbaslik1.Text = "Büyük";
            Hurwicz7_3_maliyet_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_üstbaslik1.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_üstbaslik1.Multiline = true;
            Hurwicz7_3_maliyet_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_üstbaslik1.Size = new Size(85, 13);
            Hurwicz7_3_maliyet_pl16.Controls.Add(Hurwicz7_3_maliyet_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik7 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik7.Location = txt_txtaltbaslik7;
            Hurwicz7_3_maliyet_txt_altbaslik7.Text = "F7";
            Hurwicz7_3_maliyet_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik7.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik7.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik7.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl51.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik6 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik6.Location = txt_txtaltbaslik6;
            Hurwicz7_3_maliyet_txt_altbaslik6.Text = "F6";
            Hurwicz7_3_maliyet_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik6.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik6.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik6.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl46.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik5 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik5.Location = txt_txtaltbaslik5;
            Hurwicz7_3_maliyet_txt_altbaslik5.Text = "F5";
            Hurwicz7_3_maliyet_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik5.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik5.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik5.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl41.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik4 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik4.Location = txt_txtaltbaslik4;
            Hurwicz7_3_maliyet_txt_altbaslik4.Text = "F4";
            Hurwicz7_3_maliyet_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik4.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik4.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik4.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl36.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik3 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik3.Location = txt_txtaltbaslik3;
            Hurwicz7_3_maliyet_txt_altbaslik3.Text = "F3";
            Hurwicz7_3_maliyet_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik3.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik3.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik3.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl31.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik2 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik2.Location = txt_txtaltbaslik2;
            Hurwicz7_3_maliyet_txt_altbaslik2.Text = "F2";
            Hurwicz7_3_maliyet_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik2.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik2.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik2.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl15.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_altbaslik1 = new TextBox();
            Hurwicz7_3_maliyet_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_altbaslik1.Location = txt_txtaltbaslik1;
            Hurwicz7_3_maliyet_txt_altbaslik1.Text = "F1";
            Hurwicz7_3_maliyet_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_altbaslik1.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_altbaslik1.Multiline = true;
            Hurwicz7_3_maliyet_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_altbaslik1.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl14.Controls.Add(Hurwicz7_3_maliyet_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_baslik2 = new TextBox();
            Hurwicz7_3_maliyet_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_baslik2.Location = txt_baslik2;
            Hurwicz7_3_maliyet_txt_baslik2.Text = "Fabrikalar";
            Hurwicz7_3_maliyet_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_baslik2.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_baslik2.Multiline = true;
            Hurwicz7_3_maliyet_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_baslik2.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl13.Controls.Add(Hurwicz7_3_maliyet_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            Hurwicz7_3_maliyet_txt_baslik1 = new TextBox();
            Hurwicz7_3_maliyet_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            Hurwicz7_3_maliyet_txt_baslik1.Location = txt_baslik1;
            Hurwicz7_3_maliyet_txt_baslik1.Text = "Talep Düzeyleri";
            Hurwicz7_3_maliyet_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Hurwicz7_3_maliyet_txt_baslik1.MaxLength = 30;
            Hurwicz7_3_maliyet_txt_baslik1.Multiline = true;
            Hurwicz7_3_maliyet_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_txt_baslik1.Size = new Size(162, 13);
            Hurwicz7_3_maliyet_pl12.Controls.Add(Hurwicz7_3_maliyet_txt_baslik1);
            //---------------------------------------------------------------

            //panel66 oluşturuldu  altoran-2 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl66.Name = "pl66";
            Point pl66k = new Point(567, 354);
            Hurwicz7_3_maliyet_pl66.Location = pl66k;
            Hurwicz7_3_maliyet_pl66.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl66.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl66);
            //-----------------------------------------

            //panel65 oluşturuldu  altoran-1 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl65.Name = "pl65";
            Point pl65k = new Point(470, 354);
            Hurwicz7_3_maliyet_pl65.Location = pl65k;
            Hurwicz7_3_maliyet_pl65.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl65.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl65);
            //-----------------------------------------

            //panel64 oluşturuldu  altoran başlığı arka planı orta kısım 
            Hurwicz7_3_maliyet_pl64.Name = "pl64";
            Point pl64k = new Point(179, 354);
            Hurwicz7_3_maliyet_pl64.Location = pl64k;
            Hurwicz7_3_maliyet_pl64.Size = new Size(285, 33);
            Hurwicz7_3_maliyet_pl64.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl64);
            //-----------------------------------------

            //panel63 oluşturuldu  f7Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl63.Name = "pl63";
            Point pl63k = new Point(567, 315);
            Hurwicz7_3_maliyet_pl63.Location = pl63k;
            Hurwicz7_3_maliyet_pl63.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl63.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl63);
            //-----------------------------------------

            //panel62 oluşturuldu  f6Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl62.Name = "pl62";
            Point pl62k = new Point(567, 276);
            Hurwicz7_3_maliyet_pl62.Location = pl62k;
            Hurwicz7_3_maliyet_pl62.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl62.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl62);
            //-----------------------------------------

            //panel61 oluşturuldu  f5Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl61.Name = "pl61";
            Point pl61k = new Point(567, 237);
            Hurwicz7_3_maliyet_pl61.Location = pl61k;
            Hurwicz7_3_maliyet_pl61.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl61.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl61);
            //-----------------------------------------

            //panel60 oluşturuldu  f4Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl60.Name = "pl60";
            Point pl60k = new Point(567, 198);
            Hurwicz7_3_maliyet_pl60.Location = pl60k;
            Hurwicz7_3_maliyet_pl60.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl60.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl60);
            //-----------------------------------------

            //panel59 oluşturuldu  f3Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl59.Name = "pl59";
            Point pl59k = new Point(567, 159);
            Hurwicz7_3_maliyet_pl59.Location = pl59k;
            Hurwicz7_3_maliyet_pl59.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl59.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl59);
            //-----------------------------------------

            //panel58 oluşturuldu  f2Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl58.Name = "pl58";
            Point pl58k = new Point(567, 120);
            Hurwicz7_3_maliyet_pl58.Location = pl58k;
            Hurwicz7_3_maliyet_pl58.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl58.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl58);
            //-----------------------------------------

            //panel57 oluşturuldu  f1Min-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl57.Name = "pl57";
            Point pl57k = new Point(567, 81);
            Hurwicz7_3_maliyet_pl57.Location = pl57k;
            Hurwicz7_3_maliyet_pl57.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl57.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl57);
            //-----------------------------------------

            //panel56 oluşturuldu  Min sonuc başlık arka planı orta kısım 
            Hurwicz7_3_maliyet_pl56.Name = "pl56";
            Point pl56k = new Point(567, 3);
            Hurwicz7_3_maliyet_pl56.Location = pl56k;
            Hurwicz7_3_maliyet_pl56.Size = new Size(91, 72);
            Hurwicz7_3_maliyet_pl56.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl56);
            //-----------------------------------------

            //panel55 oluşturuldu  f7Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            Hurwicz7_3_maliyet_pl55.Location = pl55k;
            Hurwicz7_3_maliyet_pl55.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl55.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            Hurwicz7_3_maliyet_pl50.Location = pl50k;
            Hurwicz7_3_maliyet_pl50.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl50.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            Hurwicz7_3_maliyet_pl45.Location = pl45k;
            Hurwicz7_3_maliyet_pl45.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl45.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            Hurwicz7_3_maliyet_pl40.Location = pl40k;
            Hurwicz7_3_maliyet_pl40.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl40.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            Hurwicz7_3_maliyet_pl35.Location = pl35k;
            Hurwicz7_3_maliyet_pl35.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl35.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            Hurwicz7_3_maliyet_pl30.Location = pl30k;
            Hurwicz7_3_maliyet_pl30.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl30.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1Max-sonuc arka planı orta kısım 
            Hurwicz7_3_maliyet_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            Hurwicz7_3_maliyet_pl29.Location = pl29k;
            Hurwicz7_3_maliyet_pl29.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl29.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  Max sonuc başlık arka planı orta kısım 
            Hurwicz7_3_maliyet_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            Hurwicz7_3_maliyet_pl28.Location = pl28k;
            Hurwicz7_3_maliyet_pl28.Size = new Size(91, 72);
            Hurwicz7_3_maliyet_pl28.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            Hurwicz7_3_maliyet_pl54.Location = pl54k;
            Hurwicz7_3_maliyet_pl54.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl54.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            Hurwicz7_3_maliyet_pl53.Location = pl53k;
            Hurwicz7_3_maliyet_pl53.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl53.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            Hurwicz7_3_maliyet_pl52.Location = pl52k;
            Hurwicz7_3_maliyet_pl52.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl52.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            Hurwicz7_3_maliyet_pl49.Location = pl49k;
            Hurwicz7_3_maliyet_pl49.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl49.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            Hurwicz7_3_maliyet_pl48.Location = pl48k;
            Hurwicz7_3_maliyet_pl48.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl48.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            Hurwicz7_3_maliyet_pl47.Location = pl47k;
            Hurwicz7_3_maliyet_pl47.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl47.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            Hurwicz7_3_maliyet_pl44.Location = pl44k;
            Hurwicz7_3_maliyet_pl44.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl44.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            Hurwicz7_3_maliyet_pl43.Location = pl43k;
            Hurwicz7_3_maliyet_pl43.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl43.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            Hurwicz7_3_maliyet_pl42.Location = pl42k;
            Hurwicz7_3_maliyet_pl42.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl42.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            Hurwicz7_3_maliyet_pl39.Location = pl39k;
            Hurwicz7_3_maliyet_pl39.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl39.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            Hurwicz7_3_maliyet_pl38.Location = pl38k;
            Hurwicz7_3_maliyet_pl38.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl38.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            Hurwicz7_3_maliyet_pl37.Location = pl37k;
            Hurwicz7_3_maliyet_pl37.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl37.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            Hurwicz7_3_maliyet_pl34.Location = pl34k;
            Hurwicz7_3_maliyet_pl34.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl34.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            Hurwicz7_3_maliyet_pl33.Location = pl33k;
            Hurwicz7_3_maliyet_pl33.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl33.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            Hurwicz7_3_maliyet_pl32.Location = pl32k;
            Hurwicz7_3_maliyet_pl32.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl32.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            Hurwicz7_3_maliyet_pl27.Location = pl27k;
            Hurwicz7_3_maliyet_pl27.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl27.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            Hurwicz7_3_maliyet_pl26.Location = pl26k;
            Hurwicz7_3_maliyet_pl26.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl26.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            Hurwicz7_3_maliyet_pl23.Location = pl23k;
            Hurwicz7_3_maliyet_pl23.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl23.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            Hurwicz7_3_maliyet_pl22.Location = pl22k;
            Hurwicz7_3_maliyet_pl22.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl22.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            Hurwicz7_3_maliyet_pl21.Location = pl21k;
            Hurwicz7_3_maliyet_pl21.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl21.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            Hurwicz7_3_maliyet_pl20.Location = pl20k;
            Hurwicz7_3_maliyet_pl20.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl20.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            Hurwicz7_3_maliyet_pl25.Location = pl25k;
            Hurwicz7_3_maliyet_pl25.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl25.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            Hurwicz7_3_maliyet_pl19.Location = pl19k;
            Hurwicz7_3_maliyet_pl19.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl19.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            Hurwicz7_3_maliyet_pl18.Location = pl18k;
            Hurwicz7_3_maliyet_pl18.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl18.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            Hurwicz7_3_maliyet_pl24.Location = pl24k;
            Hurwicz7_3_maliyet_pl24.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl24.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            Hurwicz7_3_maliyet_pl17.Location = pl17k;
            Hurwicz7_3_maliyet_pl17.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl17.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            Hurwicz7_3_maliyet_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            Hurwicz7_3_maliyet_pl16.Location = pl16k;
            Hurwicz7_3_maliyet_pl16.Size = new Size(91, 33);
            Hurwicz7_3_maliyet_pl16.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            Hurwicz7_3_maliyet_pl51.Location = pl51k;
            Hurwicz7_3_maliyet_pl51.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl51.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            Hurwicz7_3_maliyet_pl46.Location = pl46k;
            Hurwicz7_3_maliyet_pl46.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl46.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            Hurwicz7_3_maliyet_pl41.Location = pl41k;
            Hurwicz7_3_maliyet_pl41.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl41.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            Hurwicz7_3_maliyet_pl36.Location = pl36k;
            Hurwicz7_3_maliyet_pl36.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl36.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            Hurwicz7_3_maliyet_pl31.Location = pl31k;
            Hurwicz7_3_maliyet_pl31.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl31.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            Hurwicz7_3_maliyet_pl15.Location = pl15k;
            Hurwicz7_3_maliyet_pl15.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl15.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            Hurwicz7_3_maliyet_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            Hurwicz7_3_maliyet_pl14.Location = pl14k;
            Hurwicz7_3_maliyet_pl14.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl14.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            Hurwicz7_3_maliyet_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            Hurwicz7_3_maliyet_pl13.Location = pl13k;
            Hurwicz7_3_maliyet_pl13.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl13.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            Hurwicz7_3_maliyet_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            Hurwicz7_3_maliyet_pl12.Location = pl12k;
            Hurwicz7_3_maliyet_pl12.Size = new Size(168, 33);
            Hurwicz7_3_maliyet_pl12.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl5.Controls.Add(Hurwicz7_3_maliyet_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            Hurwicz7_3_maliyet_pl11.Name = "pl11";
            Hurwicz7_3_maliyet_pl11.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_pl11.Dock = DockStyle.Left;
            Hurwicz7_3_maliyet_pl11.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_pl11.BackgroundImage = Properties.Resources.logo;
            Hurwicz7_3_maliyet_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl11.Click += new EventHandler(Hurwicz7_3_maliyet_pl11_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            Hurwicz7_3_maliyet_pl10.Name = "pl10";
            Hurwicz7_3_maliyet_pl10.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_pl10.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_pl10.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_pl10.BackgroundImage = Properties.Resources.sil;
            Hurwicz7_3_maliyet_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl10.Click += new EventHandler(Hurwicz7_3_maliyet_pl10_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            Hurwicz7_3_maliyet_pl9.Name = "pl9";
            Hurwicz7_3_maliyet_pl9.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_pl9.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_pl9.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_pl9.BackgroundImage = Properties.Resources.güncelle;
            Hurwicz7_3_maliyet_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl9.Click += new EventHandler(Hurwicz7_3_maliyet_pl9_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            Hurwicz7_3_maliyet_pl8.Name = "pl8";
            Hurwicz7_3_maliyet_pl8.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_pl8.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_pl8.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_pl8.BackgroundImage = Properties.Resources.excel;
            Hurwicz7_3_maliyet_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl8.Click += new EventHandler(Hurwicz7_3_maliyet_pl8_Click);
            Hurwicz7_3_maliyet_pl7.Controls.Add(Hurwicz7_3_maliyet_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            Hurwicz7_3_maliyet_pl6.Name = "pl6";
            Hurwicz7_3_maliyet_pl6.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_pl6.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_pl6.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_pl6.BackgroundImage = Properties.Resources.hesapla;
            Hurwicz7_3_maliyet_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl6.Click += new EventHandler(Hurwicz7_3_maliyet_pl6_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            Hurwicz7_3_maliyet_btn3.Name = "btn3";
            Hurwicz7_3_maliyet_btn3.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_btn3.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_btn3.FlatStyle = FlatStyle.Flat;
            Hurwicz7_3_maliyet_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_btn3.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_btn3.BackgroundImage = Properties.Resources.geri;
            Hurwicz7_3_maliyet_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_btn3.Click += new EventHandler(Hurwicz7_3_maliyet_btn3_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            Hurwicz7_3_maliyet_btn2.Name = "btn2";
            Hurwicz7_3_maliyet_btn2.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_btn2.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_btn2.FlatStyle = FlatStyle.Flat;
            Hurwicz7_3_maliyet_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz7_3_maliyet_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz7_3_maliyet_btn2.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_btn2.BackgroundImage = Properties.Resources.altaalma;
            Hurwicz7_3_maliyet_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_btn2.Click += new EventHandler(Hurwicz7_3_maliyet_btn2_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            Hurwicz7_3_maliyet_btn1.Name = "btn1";
            Hurwicz7_3_maliyet_btn1.Size = new Size(65, 50);
            Hurwicz7_3_maliyet_btn1.Dock = DockStyle.Right;
            Hurwicz7_3_maliyet_btn1.FlatStyle = FlatStyle.Flat;
            Hurwicz7_3_maliyet_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            Hurwicz7_3_maliyet_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            Hurwicz7_3_maliyet_btn1.BackColor = Color.Transparent;
            Hurwicz7_3_maliyet_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_btn1.BackgroundImage = Properties.Resources.kapat;
            Hurwicz7_3_maliyet_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_btn1.Click += new EventHandler(Hurwicz7_3_maliyet_btn1_Click);
            Hurwicz7_3_maliyet_pl2.Controls.Add(Hurwicz7_3_maliyet_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            Hurwicz7_3_maliyet_dr1.Name = "dr1";
            Hurwicz7_3_maliyet_dr1.Size = new Size(851, 498);
            Hurwicz7_3_maliyet_dr1.Dock = DockStyle.Fill;
            Hurwicz7_3_maliyet_dr1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_dr1.AllowUserToAddRows = false;
            Hurwicz7_3_maliyet_dr1.AllowUserToDeleteRows = false;
            Hurwicz7_3_maliyet_dr1.AllowUserToResizeColumns = false;
            Hurwicz7_3_maliyet_dr1.AllowUserToResizeRows = false;
            Hurwicz7_3_maliyet_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hurwicz7_3_maliyet_dr1.RowHeadersVisible = false;
            Hurwicz7_3_maliyet_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Hurwicz7_3_maliyet_dr1.CellEnter += new DataGridViewCellEventHandler(Hurwicz7_3_maliyet_dr1_CellEnter);
            Hurwicz7_3_maliyet_tb1_2.Controls.Add(Hurwicz7_3_maliyet_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            Hurwicz7_3_maliyet_pl7.Name = "pl7";
            Hurwicz7_3_maliyet_pl7.Size = new Size(865, 50);
            Hurwicz7_3_maliyet_pl7.Dock = DockStyle.Top;
            Hurwicz7_3_maliyet_pl7.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_tb1_2.Controls.Add(Hurwicz7_3_maliyet_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            Hurwicz7_3_maliyet_pl5.Name = "pl5";
            Hurwicz7_3_maliyet_pl5.Size = new Size(851, 498);
            Hurwicz7_3_maliyet_pl5.Dock = DockStyle.Fill;
            Hurwicz7_3_maliyet_pl5.AutoScroll = true;
            Hurwicz7_3_maliyet_pl5.AutoSize = true;
            Hurwicz7_3_maliyet_pl5.AutoScrollMargin = new Size(50, 50);
            Hurwicz7_3_maliyet_pl5.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_tb1_1.Controls.Add(Hurwicz7_3_maliyet_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            Hurwicz7_3_maliyet_rt1.Name = "rt1";
            Hurwicz7_3_maliyet_rt1.Size = new Size(851, 498);
            Hurwicz7_3_maliyet_rt1.Dock = DockStyle.Fill;
            Hurwicz7_3_maliyet_rt1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_rt1.Enabled = false;
            Hurwicz7_3_maliyet_rt1.Text = "•Hurwicz Kriterine Göre Kişi Kendisini Ne Kadar Şanslı Hissederse o Derece İyimser Hareket Eder.";
            Hurwicz7_3_maliyet_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Hurwicz7_3_maliyet_tb1_3.Controls.Add(Hurwicz7_3_maliyet_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            Hurwicz7_3_maliyet_tb1_1.Name = "tb1_1";
            Hurwicz7_3_maliyet_tb1_1.Text = "Tablo";
            Hurwicz7_3_maliyet_tb1_1.Size = new Size(651, 50);
            Hurwicz7_3_maliyet_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_tb1.Controls.Add(Hurwicz7_3_maliyet_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            Hurwicz7_3_maliyet_tb1_2.Name = "tb1_2";
            Hurwicz7_3_maliyet_tb1_2.Text = "Veri Tabanı";
            Hurwicz7_3_maliyet_tb1_2.Size = new Size(651, 50);
            Hurwicz7_3_maliyet_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_tb1.Controls.Add(Hurwicz7_3_maliyet_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            Hurwicz7_3_maliyet_tb1_3.Name = "tb1_3";
            Hurwicz7_3_maliyet_tb1_3.Text = "Konu Anlatımı";
            Hurwicz7_3_maliyet_tb1_3.Size = new Size(651, 50);
            Hurwicz7_3_maliyet_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_tb1.Controls.Add(Hurwicz7_3_maliyet_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            Hurwicz7_3_maliyet_tb1.Name = "tb1";
            Hurwicz7_3_maliyet_tb1.Size = new Size(651, 50);
            Hurwicz7_3_maliyet_tb1.Dock = DockStyle.Fill;
            Hurwicz7_3_maliyet_tb1.BackColor = Color.FromArgb(209, 209, 209);
            Hurwicz7_3_maliyet_pl3.Controls.Add(Hurwicz7_3_maliyet_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            Hurwicz7_3_maliyet_pl4.Name = "pl4";
            Hurwicz7_3_maliyet_pl4.Size = new Size(865, 50);
            Hurwicz7_3_maliyet_pl4.Dock = DockStyle.Bottom;
            Hurwicz7_3_maliyet_pl4.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl4.MouseUp += new MouseEventHandler(Hurwicz7_3_maliyet_pl4_MouseUp);
            Hurwicz7_3_maliyet_pl4.MouseMove += new MouseEventHandler(Hurwicz7_3_maliyet_pl4_MouseMove);
            Hurwicz7_3_maliyet_pl4.MouseDown += new MouseEventHandler(Hurwicz7_3_maliyet_pl4_MouseDown);
            this.Controls.Add(Hurwicz7_3_maliyet_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            Hurwicz7_3_maliyet_pl3.Name = "pl3";
            Hurwicz7_3_maliyet_pl3.Size = new Size(865, 530);
            Hurwicz7_3_maliyet_pl3.Dock = DockStyle.Top;
            Hurwicz7_3_maliyet_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz7_3_maliyet_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            Hurwicz7_3_maliyet_pl2.Name = "pl2";
            Hurwicz7_3_maliyet_pl2.Size = new Size(865, 50);
            Hurwicz7_3_maliyet_pl2.Dock = DockStyle.Top;
            Hurwicz7_3_maliyet_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(Hurwicz7_3_maliyet_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            Hurwicz7_3_maliyet_pl1.Name = "pl1";
            Hurwicz7_3_maliyet_pl1.Size = new Size(865, 50);
            Hurwicz7_3_maliyet_pl1.Dock = DockStyle.Top;
            Hurwicz7_3_maliyet_pl1.BackColor = Color.FromArgb(153, 180, 209);
            Hurwicz7_3_maliyet_pl1.BackgroundImage = Properties.Resources.Hurwiczmaliyet;
            Hurwicz7_3_maliyet_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            Hurwicz7_3_maliyet_pl1.MouseUp += new MouseEventHandler(Hurwicz7_3_maliyet_pl1_MouseUp);
            Hurwicz7_3_maliyet_pl1.MouseMove += new MouseEventHandler(Hurwicz7_3_maliyet_pl1_MouseMove);
            Hurwicz7_3_maliyet_pl1.MouseDown += new MouseEventHandler(Hurwicz7_3_maliyet_pl1_MouseDown);
            this.Controls.Add(Hurwicz7_3_maliyet_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //Hurwicz2_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz2_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz2_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz2_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 20; i++)
            {
                Hurwicz2_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz3_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz3_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz3_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz3_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 26; i++)
            {
                Hurwicz3_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz4_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz4_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz4_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz4_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 32; i++)
            {
                Hurwicz4_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz5_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz5_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz5_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz5_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 38; i++)
            {
                Hurwicz5_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz6_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz6_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz6_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz6_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 44; i++)
            {
                Hurwicz6_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz7_3_maliyet veritabanına listelemek için kullanılır
        public void Hurwicz7_3_maliyet_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From Hurwicz7_3_maliyet", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            Hurwicz7_3_maliyet_dr1.DataSource = tablo;
            for (int i = 0; i <= 50; i++)
            {
                Hurwicz7_3_maliyet_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //Hurwicz2_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz2_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz2_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz2_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz2_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz2_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz2_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz2_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz2_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz2_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz2_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz2_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz2_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz2_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz2_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz2_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz2_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz2_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz2_3_maliyet_pl35.Controls["altoran1"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz2_3_maliyet_pl36.Controls["altoran2"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz2_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------

        //Hurwicz2_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz2_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz2_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz2_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz2_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz2_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz2_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz2_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz2_3_maliyet_pl35.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz2_3_maliyet_pl36.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz2_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz2_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz2_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz2_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz2_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz2_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text);


                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1)
                    {
                        kucukolanibul = f2;
                    }
                    //---------------------------------------
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz2_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,Maxsonuc_1,Maxsonuc_2,Minsonuc_1,Minsonuc_2,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@Maxsonuc_1,@Maxsonuc_2,@Minsonuc_1,@Minsonuc_2,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz2_3_maliyet_pl35.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz2_3_maliyet_pl36.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz2_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz2_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz2_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz2_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz2_3_maliyet_Maxsonucbaslik.Text;

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz2_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                altoranbaslik.Value2 = Hurwicz2_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut17 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut19 = new OleDbCommand("Select Minsonuc_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut19.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select Minsonuc_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select altoran_1 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                altoran_1.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select altoran_2 From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                altoran_2.Value2 = komut22.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut23 = new OleDbCommand("Select maliyet From Hurwicz2_3_maliyet where Id=" + Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                maliyet.Value2 = komut23.ExecuteScalar().ToString();
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

        //Hurwicz2_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz2_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz2_3_maliyet_pl35.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz2_3_maliyet_pl36.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz2_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz2_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz2_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz2_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz2_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz2_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text);


                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1)
                    {
                        kucukolanibul = f2;
                    }
                    //---------------------------------------
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz2_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz2_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz2_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz2_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz2_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz2_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz2_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz2_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz2_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz2_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz2_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz2_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz2_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz2_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz2_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz2_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz2_3_maliyet_pl32.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz2_3_maliyet_pl33.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz2_3_maliyet_pl35.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz2_3_maliyet_pl36.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    Hurwicz2_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz2_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz2_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz2_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz2_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz2_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz2_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz2_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz2_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //Hurwicz3_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz3_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz3_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz3_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz3_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz3_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz3_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz3_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz3_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz3_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz3_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz3_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz3_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz3_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz3_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz3_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz3_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz3_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz3_3_maliyet_pl32.Controls["txtveri7"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz3_3_maliyet_pl33.Controls["txtveri8"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz3_3_maliyet_pl34.Controls["txtveri9"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                Hurwicz3_3_maliyet_pl41.Controls["altoran1"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                Hurwicz3_3_maliyet_pl42.Controls["altoran2"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                Hurwicz3_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //Hurwicz3_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz3_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz3_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz3_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz3_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz3_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz3_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz3_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz3_3_maliyet_pl41.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz3_3_maliyet_pl42.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz3_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz3_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz3_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz3_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz3_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz3_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz3_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz3_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz3_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2)
                    {
                        kucukolanibul = f3;
                    }
                    //---------------------------------------              
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz3_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,Maxsonuc_1,Maxsonuc_2,Maxsonuc_3,Minsonuc_1,Minsonuc_2,Minsonuc_3,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@Maxsonuc_1,@Maxsonuc_2,@Maxsonuc_3,@Minsonuc_1,@Minsonuc_2,@Minsonuc_3,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz3_3_maliyet_pl41.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz3_3_maliyet_pl42.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz3_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz3_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz3_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz3_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz3_3_maliyet_Maxsonucbaslik.Text;


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 5; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz3_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                altoranbaslik.Value2 = Hurwicz3_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut24 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select Maxsonuc_3 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                Maxsonuc_3.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select Minsonuc_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select Minsonuc_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select Minsonuc_3 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                Minsonuc_3.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altoran_1 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                altoran_1.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select altoran_2 From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 6];
                altoran_2.Value2 = komut31.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From Hurwicz3_3_maliyet where Id=" + Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //Hurwicz3_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz3_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz3_3_maliyet_pl41.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz3_3_maliyet_pl42.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz3_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz3_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz3_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz3_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz3_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz3_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz3_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz3_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz3_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2)
                    {
                        kucukolanibul = f3;
                    }
                    //---------------------------------------              
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz3_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Maxsonuc_3=@Maxsonuc_3,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,Minsonuc_3=@Minsonuc_3,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz3_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz3_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz3_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz3_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz3_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz3_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz3_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz3_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz3_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz3_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz3_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz3_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz3_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz3_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz3_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz3_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz3_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz3_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz3_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz3_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz3_3_maliyet_pl37.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz3_3_maliyet_pl38.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz3_3_maliyet_pl39.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz3_3_maliyet_pl41.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz3_3_maliyet_pl42.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz3_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz3_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz3_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz3_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz3_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz3_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz3_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz3_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz3_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //Hurwicz4_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz4_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz4_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz4_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz4_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz4_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz4_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz4_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz4_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz4_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz4_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz4_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz4_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz4_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz4_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz4_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz4_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz4_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz4_3_maliyet_pl32.Controls["txtveri7"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz4_3_maliyet_pl33.Controls["txtveri8"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz4_3_maliyet_pl34.Controls["txtveri9"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz4_3_maliyet_pl37.Controls["txtveri10"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz4_3_maliyet_pl38.Controls["txtveri11"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                Hurwicz4_3_maliyet_pl39.Controls["txtveri12"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                Hurwicz4_3_maliyet_pl47.Controls["altoran1"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                Hurwicz4_3_maliyet_pl48.Controls["altoran2"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                Hurwicz4_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //Hurwicz4_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz4_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz4_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz4_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz4_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz4_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz4_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz4_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz4_3_maliyet_pl47.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz4_3_maliyet_pl48.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz4_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz4_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz4_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz4_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz4_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz4_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz4_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz4_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz4_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc kısmı
                    double veri10 = Convert.ToDouble(Hurwicz4_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz4_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz4_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3)
                    {
                        kucukolanibul = f4;
                    }
                    //---------------------------------------                    
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz4_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,Maxsonuc_1,Maxsonuc_2,Maxsonuc_3,Maxsonuc_4,Minsonuc_1,Minsonuc_2,Minsonuc_3,Minsonuc_4,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@Maxsonuc_1,@Maxsonuc_2,@Maxsonuc_3,@Maxsonuc_4,@Minsonuc_1,@Minsonuc_2,@Minsonuc_3,@Minsonuc_4,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz4_3_maliyet_pl47.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz4_3_maliyet_pl48.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz4_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz4_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz4_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz4_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz4_3_maliyet_Maxsonucbaslik.Text;


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz4_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                altoranbaslik.Value2 = Hurwicz4_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut29 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select Maxsonuc_3 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                Maxsonuc_3.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select Maxsonuc_4 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                Maxsonuc_4.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select Minsonuc_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select Minsonuc_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select Minsonuc_3 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                Minsonuc_3.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select Minsonuc_4 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 6];
                Minsonuc_4.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select altoran_1 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                altoran_1.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select altoran_2 From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 6];
                altoran_2.Value2 = komut38.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From Hurwicz4_3_maliyet where Id=" + Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //Hurwicz4_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz4_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz4_3_maliyet_pl47.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz4_3_maliyet_pl48.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz4_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz4_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz4_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz4_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz4_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz4_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz4_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz4_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz4_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc kısmı
                    double veri10 = Convert.ToDouble(Hurwicz4_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz4_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz4_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3)
                    {
                        kucukolanibul = f4;
                    }
                    //---------------------------------------      
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz4_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Maxsonuc_3=@Maxsonuc_3,Maxsonuc_4=@Maxsonuc_4,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,Minsonuc_3=@Minsonuc_3,Minsonuc_4=@Minsonuc_4,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz4_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz4_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz4_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz4_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz4_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz4_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz4_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz4_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz4_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz4_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz4_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz4_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz4_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz4_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz4_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz4_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz4_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz4_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz4_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz4_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz4_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz4_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz4_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz4_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz4_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz4_3_maliyet_pl42.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz4_3_maliyet_pl43.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz4_3_maliyet_pl44.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz4_3_maliyet_pl45.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz4_3_maliyet_pl47.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz4_3_maliyet_pl48.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz4_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz4_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz4_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz4_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz4_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz4_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz4_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz4_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz4_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //Hurwicz5_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz5_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz5_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz5_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz5_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz5_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz5_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz5_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz5_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz5_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz5_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz5_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz5_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz5_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz5_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz5_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz5_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz5_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz5_3_maliyet_pl32.Controls["txtveri7"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz5_3_maliyet_pl33.Controls["txtveri8"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz5_3_maliyet_pl34.Controls["txtveri9"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz5_3_maliyet_pl37.Controls["txtveri10"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                Hurwicz5_3_maliyet_pl38.Controls["txtveri11"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                Hurwicz5_3_maliyet_pl39.Controls["txtveri12"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                Hurwicz5_3_maliyet_pl42.Controls["txtveri13"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                Hurwicz5_3_maliyet_pl43.Controls["txtveri14"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                Hurwicz5_3_maliyet_pl44.Controls["txtveri15"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                Hurwicz5_3_maliyet_pl53.Controls["altoran1"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
                Hurwicz5_3_maliyet_pl54.Controls["altoran2"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[37].Value.ToString();
                Hurwicz5_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[38].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //Hurwicz5_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz5_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz5_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz5_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz5_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz5_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz5_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz5_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz5_3_maliyet_pl53.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz5_3_maliyet_pl54.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz5_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz5_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz5_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz5_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz5_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz5_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz5_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz5_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz5_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz5_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz5_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz5_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz5_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz5_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz5_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4)
                    {
                        kucukolanibul = f5;
                    }
                    //---------------------------------------                                                         
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz5_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,Maxsonuc_1,Maxsonuc_2,Maxsonuc_3,Maxsonuc_4,Maxsonuc_5,Minsonuc_1,Minsonuc_2,Minsonuc_3,Minsonuc_4,Minsonuc_5,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@Maxsonuc_1,@Maxsonuc_2,@Maxsonuc_3,@Maxsonuc_4,@Maxsonuc_5,@Minsonuc_1,@Minsonuc_2,@Minsonuc_3,@Minsonuc_4,@Minsonuc_5,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz5_3_maliyet_pl53.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz5_3_maliyet_pl54.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz5_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz5_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz5_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz5_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz5_3_maliyet_Maxsonucbaslik.Text;


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 7; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz5_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                altoranbaslik.Value2 = Hurwicz5_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut34 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select Maxsonuc_3 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                Maxsonuc_3.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select Maxsonuc_4 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                Maxsonuc_4.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select Maxsonuc_5 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                Maxsonuc_5.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select Minsonuc_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select Minsonuc_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select Minsonuc_3 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                Minsonuc_3.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select Minsonuc_4 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 6];
                Minsonuc_4.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select Minsonuc_5 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 6];
                Minsonuc_5.Value2 = komut43.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select altoran_1 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                altoran_1.Value2 = komut44.ExecuteScalar().ToString();

                OleDbCommand komut45 = new OleDbCommand("Select altoran_2 From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 6];
                altoran_2.Value2 = komut45.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From Hurwicz5_3_maliyet where Id=" + Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //Hurwicz5_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz5_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz5_3_maliyet_pl53.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz5_3_maliyet_pl54.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz5_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz5_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz5_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz5_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz5_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz5_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz5_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz5_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz5_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz5_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz5_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz5_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz5_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz5_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz5_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4)
                    {
                        kucukolanibul = f5;
                    }
                    //---------------------------------------            
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz5_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Maxsonuc_3=@Maxsonuc_3,Maxsonuc_4=@Maxsonuc_4,Maxsonuc_5=@Maxsonuc_5,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,Minsonuc_3=@Minsonuc_3,Minsonuc_4=@Minsonuc_4,Minsonuc_5=@Minsonuc_5,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz5_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz5_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz5_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz5_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz5_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz5_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz5_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz5_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz5_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz5_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz5_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz5_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz5_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz5_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz5_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz5_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz5_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz5_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz5_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz5_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz5_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz5_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz5_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz5_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz5_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz5_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz5_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz5_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz5_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz5_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz5_3_maliyet_pl47.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz5_3_maliyet_pl48.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz5_3_maliyet_pl49.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz5_3_maliyet_pl50.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz5_3_maliyet_pl51.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz5_3_maliyet_pl53.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz5_3_maliyet_pl54.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz5_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz5_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz5_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz5_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz5_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz5_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz5_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz5_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz5_3_maliyet_pl11_Click(object sender, EventArgs e)
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


        //Hurwicz6_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz6_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz6_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz6_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz6_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz6_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz6_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz6_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz6_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz6_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz6_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz6_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz6_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz6_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz6_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz6_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz6_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz6_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz6_3_maliyet_pl32.Controls["txtveri7"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz6_3_maliyet_pl33.Controls["txtveri8"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz6_3_maliyet_pl34.Controls["txtveri9"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                Hurwicz6_3_maliyet_pl37.Controls["txtveri10"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                Hurwicz6_3_maliyet_pl38.Controls["txtveri11"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                Hurwicz6_3_maliyet_pl39.Controls["txtveri12"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                Hurwicz6_3_maliyet_pl42.Controls["txtveri13"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                Hurwicz6_3_maliyet_pl43.Controls["txtveri14"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                Hurwicz6_3_maliyet_pl44.Controls["txtveri15"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                Hurwicz6_3_maliyet_pl47.Controls["txtveri16"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                Hurwicz6_3_maliyet_pl48.Controls["txtveri17"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                Hurwicz6_3_maliyet_pl49.Controls["txtveri18"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
                Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[37].Value.ToString();
                Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[38].Value.ToString();
                Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[39].Value.ToString();
                Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[40].Value.ToString();
                Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[41].Value.ToString();
                Hurwicz6_3_maliyet_pl59.Controls["altoran1"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[42].Value.ToString();
                Hurwicz6_3_maliyet_pl60.Controls["altoran2"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[43].Value.ToString();
                Hurwicz6_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[44].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //Hurwicz6_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz6_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz6_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz6_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz6_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz6_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz6_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz6_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz6_3_maliyet_pl59.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz6_3_maliyet_pl60.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz6_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz6_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz6_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz6_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz6_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz6_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz6_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz6_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz6_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz6_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz6_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz6_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz6_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz6_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz6_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //f6sonuc Max-Min kısmı
                    double veri16 = Convert.ToDouble(Hurwicz6_3_maliyet_pl47.Controls["txtveri16"].Text);
                    double veri17 = Convert.ToDouble(Hurwicz6_3_maliyet_pl48.Controls["txtveri17"].Text);
                    double veri18 = Convert.ToDouble(Hurwicz6_3_maliyet_pl49.Controls["txtveri18"].Text);
                    if (veri16 > veri17 && veri16 > veri18)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 > veri16 && veri17 > veri18)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 > veri17 && veri18 > veri16)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri18.ToString();
                    }

                    if (veri16 < veri17 && veri16 < veri18)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 < veri16 && veri17 < veri18)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 < veri17 && veri18 < veri16)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri18.ToString();
                    }
                    //--------------------------------------------   

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Maxf6sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text);
                    double Minf6sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));
                    double f6 = ((Maxf6sonuc * altoran1) + (Minf6sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5 && f1 < f6)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5 && f2 < f6)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5 && f3 < f6)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5 && f4 < f6)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4 && f5 < f6)
                    {
                        kucukolanibul = f5;
                    }
                    else if (f6 < f1 && f6 < f2 && f6 < f3 && f6 < f4 && f6 < f5)
                    {
                        kucukolanibul = f6;
                    }
                    //---------------------------------------                                                                    
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz6_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,Maxsonuc_1,Maxsonuc_2,Maxsonuc_3,Maxsonuc_4,Maxsonuc_5,Maxsonuc_6,Minsonuc_1,Minsonuc_2,Minsonuc_3,Minsonuc_4,Minsonuc_5,Minsonuc_6,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@Maxsonuc_1,@Maxsonuc_2,@Maxsonuc_3,@Maxsonuc_4,@Maxsonuc_5,@Maxsonuc_6,@Minsonuc_1,@Minsonuc_2,@Minsonuc_3,@Minsonuc_4,@Minsonuc_5,@Minsonuc_6,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", Hurwicz6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", Hurwicz6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", Hurwicz6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", Hurwicz6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_6", Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_6", Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz6_3_maliyet_pl59.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz6_3_maliyet_pl60.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz6_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz6_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz6_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz6_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz6_3_maliyet_Maxsonucbaslik.Text;


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 8; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz6_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                altoranbaslik.Value2 = Hurwicz6_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut39 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select Maxsonuc_3 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                Maxsonuc_3.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select Maxsonuc_4 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                Maxsonuc_4.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select Maxsonuc_5 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                Maxsonuc_5.Value2 = komut43.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select Maxsonuc_6 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                Maxsonuc_6.Value2 = komut44.ExecuteScalar().ToString();

                OleDbCommand komut45 = new OleDbCommand("Select Minsonuc_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut45.ExecuteScalar().ToString();

                OleDbCommand komut46 = new OleDbCommand("Select Minsonuc_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut46.ExecuteScalar().ToString();

                OleDbCommand komut47 = new OleDbCommand("Select Minsonuc_3 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                Minsonuc_3.Value2 = komut47.ExecuteScalar().ToString();

                OleDbCommand komut48 = new OleDbCommand("Select Minsonuc_4 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 6];
                Minsonuc_4.Value2 = komut48.ExecuteScalar().ToString();

                OleDbCommand komut49 = new OleDbCommand("Select Minsonuc_5 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 6];
                Minsonuc_5.Value2 = komut49.ExecuteScalar().ToString();

                OleDbCommand komut50 = new OleDbCommand("Select Minsonuc_6 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 6];
                Minsonuc_6.Value2 = komut50.ExecuteScalar().ToString();

                OleDbCommand komut51 = new OleDbCommand("Select altoran_1 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 5];
                altoran_1.Value2 = komut51.ExecuteScalar().ToString();

                OleDbCommand komut52 = new OleDbCommand("Select altoran_2 From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 6];
                altoran_2.Value2 = komut52.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From Hurwicz6_3_maliyet where Id=" + Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //Hurwicz6_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz6_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz6_3_maliyet_pl59.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz6_3_maliyet_pl60.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz6_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz6_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz6_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz6_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz6_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz6_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz6_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz6_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz6_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz6_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz6_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz6_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz6_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz6_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz6_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //f6sonuc Max-Min kısmı
                    double veri16 = Convert.ToDouble(Hurwicz6_3_maliyet_pl47.Controls["txtveri16"].Text);
                    double veri17 = Convert.ToDouble(Hurwicz6_3_maliyet_pl48.Controls["txtveri17"].Text);
                    double veri18 = Convert.ToDouble(Hurwicz6_3_maliyet_pl49.Controls["txtveri18"].Text);
                    if (veri16 > veri17 && veri16 > veri18)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 > veri16 && veri17 > veri18)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 > veri17 && veri18 > veri16)
                    {
                        Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri18.ToString();
                    }

                    if (veri16 < veri17 && veri16 < veri18)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 < veri16 && veri17 < veri18)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 < veri17 && veri18 < veri16)
                    {
                        Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text = veri18.ToString();
                    }
                    //--------------------------------------------   

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Maxf6sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text);
                    double Minf6sonuc = Convert.ToDouble(Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));
                    double f6 = ((Maxf6sonuc * altoran1) + (Minf6sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5 && f1 < f6)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5 && f2 < f6)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5 && f3 < f6)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5 && f4 < f6)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4 && f5 < f6)
                    {
                        kucukolanibul = f5;
                    }
                    else if (f6 < f1 && f6 < f2 && f6 < f3 && f6 < f4 && f6 < f5)
                    {
                        kucukolanibul = f6;
                    }
                    //---------------------------------------        
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz6_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Maxsonuc_3=@Maxsonuc_3,Maxsonuc_4=@Maxsonuc_4,Maxsonuc_5=@Maxsonuc_5,Maxsonuc_6=@Maxsonuc_6,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,Minsonuc_3=@Minsonuc_3,Minsonuc_4=@Minsonuc_4,Minsonuc_5=@Minsonuc_5,Minsonuc_6=@Minsonuc_6,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz6_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz6_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz6_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz6_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz6_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz6_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz6_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", Hurwicz6_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz6_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz6_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz6_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz6_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz6_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz6_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz6_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz6_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz6_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz6_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz6_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz6_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz6_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz6_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz6_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz6_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz6_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz6_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", Hurwicz6_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", Hurwicz6_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", Hurwicz6_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz6_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz6_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz6_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz6_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz6_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_6", Hurwicz6_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz6_3_maliyet_pl52.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz6_3_maliyet_pl53.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz6_3_maliyet_pl54.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz6_3_maliyet_pl55.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz6_3_maliyet_pl56.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_6", Hurwicz6_3_maliyet_pl57.Controls["txtMinf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz6_3_maliyet_pl59.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz6_3_maliyet_pl60.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz6_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz6_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz6_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz6_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz6_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz6_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz6_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz6_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz6_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        //Hurwicz7_3_maliyet panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz7_3_maliyet_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz7_3_maliyet_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz7_3_maliyet_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz7_3_maliyet uzerinde mouse ile tutup formu surukleme eventleri
        private void Hurwicz7_3_maliyet_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void Hurwicz7_3_maliyet_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void Hurwicz7_3_maliyet_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //Hurwicz7_3_maliyet DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void Hurwicz7_3_maliyet_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Hurwicz7_3_maliyet_pl12.Controls["txtbaslik1"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[1].Value.ToString();
                Hurwicz7_3_maliyet_pl13.Controls["txtbaslik2"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[2].Value.ToString();
                Hurwicz7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[3].Value.ToString();
                Hurwicz7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[4].Value.ToString();
                Hurwicz7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[5].Value.ToString();
                Hurwicz7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[6].Value.ToString();
                Hurwicz7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[7].Value.ToString();
                Hurwicz7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[8].Value.ToString();
                Hurwicz7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[9].Value.ToString();
                Hurwicz7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[10].Value.ToString();
                Hurwicz7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[11].Value.ToString();
                Hurwicz7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[12].Value.ToString();
                Hurwicz7_3_maliyet_pl20.Controls["txtveri1"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[13].Value.ToString();
                Hurwicz7_3_maliyet_pl21.Controls["txtveri2"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[14].Value.ToString();
                Hurwicz7_3_maliyet_pl26.Controls["txtveri3"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[15].Value.ToString();
                Hurwicz7_3_maliyet_pl22.Controls["txtveri4"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[16].Value.ToString();
                Hurwicz7_3_maliyet_pl23.Controls["txtveri5"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[17].Value.ToString();
                Hurwicz7_3_maliyet_pl27.Controls["txtveri6"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[18].Value.ToString();
                Hurwicz7_3_maliyet_pl32.Controls["txtveri7"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[19].Value.ToString();
                Hurwicz7_3_maliyet_pl33.Controls["txtveri8"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[20].Value.ToString();
                Hurwicz7_3_maliyet_pl34.Controls["txtveri9"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[21].Value.ToString();
                Hurwicz7_3_maliyet_pl37.Controls["txtveri10"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[22].Value.ToString();
                Hurwicz7_3_maliyet_pl38.Controls["txtveri11"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[23].Value.ToString();
                Hurwicz7_3_maliyet_pl39.Controls["txtveri12"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[24].Value.ToString();
                Hurwicz7_3_maliyet_pl42.Controls["txtveri13"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[25].Value.ToString();
                Hurwicz7_3_maliyet_pl43.Controls["txtveri14"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[26].Value.ToString();
                Hurwicz7_3_maliyet_pl44.Controls["txtveri15"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[27].Value.ToString();
                Hurwicz7_3_maliyet_pl47.Controls["txtveri16"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[28].Value.ToString();
                Hurwicz7_3_maliyet_pl48.Controls["txtveri17"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[29].Value.ToString();
                Hurwicz7_3_maliyet_pl49.Controls["txtveri18"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[30].Value.ToString();
                Hurwicz7_3_maliyet_pl52.Controls["txtveri19"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[31].Value.ToString();
                Hurwicz7_3_maliyet_pl53.Controls["txtveri20"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[32].Value.ToString();
                Hurwicz7_3_maliyet_pl54.Controls["txtveri21"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[33].Value.ToString();
                Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[34].Value.ToString();
                Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[35].Value.ToString();
                Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[36].Value.ToString();
                Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[37].Value.ToString();
                Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[38].Value.ToString();
                Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[39].Value.ToString();
                Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[40].Value.ToString();
                Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[41].Value.ToString();
                Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[42].Value.ToString();
                Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[43].Value.ToString();
                Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[44].Value.ToString();
                Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[45].Value.ToString();
                Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[46].Value.ToString();
                Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[47].Value.ToString();
                Hurwicz7_3_maliyet_pl65.Controls["altoran1"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[48].Value.ToString();
                Hurwicz7_3_maliyet_pl66.Controls["altoran2"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[49].Value.ToString();
                Hurwicz7_3_maliyet_pl4.Controls["sonuc"].Text = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[50].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //Hurwicz7_3_maliyet formu kapatmak için oluşturulmuş button1
        private void Hurwicz7_3_maliyet_btn1_Click(object sender, EventArgs e)
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

        //Hurwicz7_3_maliyet formu altaalmak için oluşturulmuş button2
        private void Hurwicz7_3_maliyet_btn2_Click(object sender, EventArgs e)
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

        //Hurwicz7_3_maliyet fordan bir önceki forma geçmek için oluşturulmuş button3
        private void Hurwicz7_3_maliyet_btn3_Click(object sender, EventArgs e)
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

        //Hurwicz7_3_maliyet hesaplama yapmak için oluşturulmuş panel6 
        private void Hurwicz7_3_maliyet_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double altoran1 = Convert.ToDouble(Hurwicz7_3_maliyet_pl65.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz7_3_maliyet_pl66.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz7_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz7_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz7_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz7_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz7_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz7_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz7_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz7_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz7_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz7_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz7_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz7_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz7_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz7_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz7_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //f6sonuc Max-Min kısmı
                    double veri16 = Convert.ToDouble(Hurwicz7_3_maliyet_pl47.Controls["txtveri16"].Text);
                    double veri17 = Convert.ToDouble(Hurwicz7_3_maliyet_pl48.Controls["txtveri17"].Text);
                    double veri18 = Convert.ToDouble(Hurwicz7_3_maliyet_pl49.Controls["txtveri18"].Text);
                    if (veri16 > veri17 && veri16 > veri18)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 > veri16 && veri17 > veri18)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 > veri17 && veri18 > veri16)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri18.ToString();
                    }

                    if (veri16 < veri17 && veri16 < veri18)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 < veri16 && veri17 < veri18)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 < veri17 && veri18 < veri16)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri18.ToString();
                    }
                    //--------------------------------------------   

                    //f7sonuc  Max-Min kısmı
                    double veri19 = Convert.ToDouble(Hurwicz7_3_maliyet_pl52.Controls["txtveri19"].Text);
                    double veri20 = Convert.ToDouble(Hurwicz7_3_maliyet_pl53.Controls["txtveri20"].Text);
                    double veri21 = Convert.ToDouble(Hurwicz7_3_maliyet_pl54.Controls["txtveri21"].Text);
                    if (veri19 > veri20 && veri19 > veri21)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri19.ToString();
                    }
                    else if (veri20 > veri19 && veri20 > veri21)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri20.ToString();
                    }
                    else if (veri21 > veri19 && veri21 > veri20)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri21.ToString();
                    }

                    if (veri19 < veri20 && veri19 < veri21)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri19.ToString();
                    }
                    else if (veri20 < veri19 && veri20 < veri21)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri20.ToString();
                    }
                    else if (veri21 < veri19 && veri21 < veri20)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri21.ToString();
                    }
                    //--------------------------------------------   

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Maxf6sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text);
                    double Maxf7sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text);
                    double Minf6sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text);
                    double Minf7sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));
                    double f6 = ((Maxf6sonuc * altoran1) + (Minf6sonuc * altoran2));
                    double f7 = ((Maxf7sonuc * altoran1) + (Minf7sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5 && f1 < f6 && f1 < f7)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5 && f2 < f6 && f2 < f7)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5 && f3 < f6 && f3 < f7)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5 && f4 < f6 && f4 < f7)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4 && f5 < f6 && f5 < f7)
                    {
                        kucukolanibul = f5;
                    }
                    else if (f6 < f1 && f6 < f2 && f6 < f3 && f6 < f4 && f6 < f5 && f6 < f7)
                    {
                        kucukolanibul = f6;
                    }
                    else if (f7 < f1 && f7 < f2 && f7 < f3 && f7 < f4 && f7 < f5 && f7 < f6)
                    {
                        kucukolanibul = f7;
                    }
                    //---------------------------------------                                
                    baglanti.Open();
                    string sorgu = "Insert into Hurwicz7_3_maliyet(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,Maxsonuc_1,Maxsonuc_2,Maxsonuc_3,Maxsonuc_4,Maxsonuc_5,Maxsonuc_6,Maxsonuc_7,Minsonuc_1,Minsonuc_2,Minsonuc_3,Minsonuc_4,Minsonuc_5,Minsonuc_6,Minsonuc_7,altoran_1,altoran_2,maliyet) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@Maxsonuc_1,@Maxsonuc_2,@Maxsonuc_3,@Maxsonuc_4,@Maxsonuc_5,@Maxsonuc_6,@Maxsonuc_7,@Minsonuc_1,@Minsonuc_2,@Minsonuc_3,@Minsonuc_4,@Minsonuc_5,@Minsonuc_6,@Minsonuc_7,@altoran_1,@altoran_2,@maliyet)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", Hurwicz7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", Hurwicz7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", Hurwicz7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", Hurwicz7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", Hurwicz7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", Hurwicz7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", Hurwicz7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", Hurwicz7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_6", Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_7", Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_6", Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_7", Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz7_3_maliyet_pl65.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz7_3_maliyet_pl66.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz7_3_maliyet_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz7_3_maliyet excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void Hurwicz7_3_maliyet_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //Hurwicz7_3_maliyet TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Hurwicz";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut27.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range maxbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                maxbaslik.Value2 = Hurwicz7_3_maliyet_Maxsonucbaslik.Text;


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucbaslikrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucbaslikrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 192, 128);
                }

                for (int i = 3; i <= 9; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i, 6];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(169, 165, 163);
                }

                Microsoft.Office.Interop.Excel.Range minbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 6];
                minbaslik.Value2 = Hurwicz7_3_maliyet_Minsonucbaslik.Text;

                Microsoft.Office.Interop.Excel.Range altoranbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                altoranbaslik.Value2 = Hurwicz7_3_maliyet_altoranbaslik.Text;

                OleDbCommand komut44 = new OleDbCommand("Select Maxsonuc_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                Maxsonuc_1.Value2 = komut44.ExecuteScalar().ToString();

                OleDbCommand komut45 = new OleDbCommand("Select Maxsonuc_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                Maxsonuc_2.Value2 = komut45.ExecuteScalar().ToString();

                OleDbCommand komut46 = new OleDbCommand("Select Maxsonuc_3 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                Maxsonuc_3.Value2 = komut46.ExecuteScalar().ToString();

                OleDbCommand komut47 = new OleDbCommand("Select Maxsonuc_4 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                Maxsonuc_4.Value2 = komut47.ExecuteScalar().ToString();

                OleDbCommand komut48 = new OleDbCommand("Select Maxsonuc_5 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                Maxsonuc_5.Value2 = komut48.ExecuteScalar().ToString();

                OleDbCommand komut49 = new OleDbCommand("Select Maxsonuc_6 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                Maxsonuc_6.Value2 = komut49.ExecuteScalar().ToString();

                OleDbCommand komut50 = new OleDbCommand("Select Maxsonuc_7 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Maxsonuc_7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 5];
                Maxsonuc_7.Value2 = komut50.ExecuteScalar().ToString();

                OleDbCommand komut51 = new OleDbCommand("Select Minsonuc_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 6];
                Minsonuc_1.Value2 = komut51.ExecuteScalar().ToString();

                OleDbCommand komut52 = new OleDbCommand("Select Minsonuc_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 6];
                Minsonuc_2.Value2 = komut52.ExecuteScalar().ToString();

                OleDbCommand komut53 = new OleDbCommand("Select Minsonuc_3 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 6];
                Minsonuc_3.Value2 = komut53.ExecuteScalar().ToString();

                OleDbCommand komut54 = new OleDbCommand("Select Minsonuc_4 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 6];
                Minsonuc_4.Value2 = komut54.ExecuteScalar().ToString();

                OleDbCommand komut55 = new OleDbCommand("Select Minsonuc_5 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 6];
                Minsonuc_5.Value2 = komut55.ExecuteScalar().ToString();

                OleDbCommand komut56 = new OleDbCommand("Select Minsonuc_6 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 6];
                Minsonuc_6.Value2 = komut56.ExecuteScalar().ToString();

                OleDbCommand komut57 = new OleDbCommand("Select Minsonuc_7 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range Minsonuc_7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 6];
                Minsonuc_7.Value2 = komut57.ExecuteScalar().ToString();

                OleDbCommand komut58 = new OleDbCommand("Select altoran_1 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 5];
                altoran_1.Value2 = komut58.ExecuteScalar().ToString();

                OleDbCommand komut59 = new OleDbCommand("Select altoran_2 From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altoran_2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 6];
                altoran_2.Value2 = komut59.ExecuteScalar().ToString();

                for (int i = 2; i <= 4; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(229, 196, 163);
                }

                for (int i = 5; i <= 6; i++)
                {
                    Microsoft.Office.Interop.Excel.Range sonucrenk = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    sonucrenk.Interior.Color = System.Drawing.Color.FromArgb(255, 111, 97);
                }


                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 1];
                alan1.Value2 = "En Küçük Maliyet:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select maliyet From Hurwicz7_3_maliyet where Id=" + Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range maliyet = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[12, 3];
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

        //Hurwicz7_3_maliyet güncelleme yapmak için oluşturulmuş panel9 
        private void Hurwicz7_3_maliyet_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

                double altoran1 = Convert.ToDouble(Hurwicz7_3_maliyet_pl65.Controls["altoran1"].Text);
                double altoran2 = Convert.ToDouble(Hurwicz7_3_maliyet_pl66.Controls["altoran2"].Text);
                double orantoplam = altoran1 + altoran2;
                if (orantoplam == 1)
                {
                    //f1sonuc Max-Min kısmı
                    double veri1 = Convert.ToDouble(Hurwicz7_3_maliyet_pl20.Controls["txtveri1"].Text);
                    double veri2 = Convert.ToDouble(Hurwicz7_3_maliyet_pl21.Controls["txtveri2"].Text);
                    double veri3 = Convert.ToDouble(Hurwicz7_3_maliyet_pl26.Controls["txtveri3"].Text);
                    if (veri1 > veri2 && veri1 > veri3)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 > veri1 && veri2 > veri3)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 > veri1 && veri3 > veri2)
                    {
                        Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text = veri3.ToString();
                    }

                    if (veri1 < veri2 && veri1 < veri3)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri1.ToString();
                    }
                    else if (veri2 < veri1 && veri2 < veri3)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri2.ToString();
                    }
                    else if (veri3 < veri1 && veri3 < veri2)
                    {
                        Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text = veri3.ToString();
                    }
                    //--------------------------------------------

                    //f2sonuc Max-Min kısmı
                    double veri4 = Convert.ToDouble(Hurwicz7_3_maliyet_pl22.Controls["txtveri4"].Text);
                    double veri5 = Convert.ToDouble(Hurwicz7_3_maliyet_pl23.Controls["txtveri5"].Text);
                    double veri6 = Convert.ToDouble(Hurwicz7_3_maliyet_pl27.Controls["txtveri6"].Text);
                    if (veri4 > veri5 && veri4 > veri6)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 > veri4 && veri5 > veri6)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 > veri4 && veri6 > veri5)
                    {
                        Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text = veri6.ToString();
                    }

                    if (veri4 < veri5 && veri4 < veri6)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri4.ToString();
                    }
                    else if (veri5 < veri4 && veri5 < veri6)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri5.ToString();
                    }
                    else if (veri6 < veri4 && veri6 < veri5)
                    {
                        Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text = veri6.ToString();
                    }
                    //--------------------------------------------

                    //f3sonuc Max-Min kısmı
                    double veri7 = Convert.ToDouble(Hurwicz7_3_maliyet_pl32.Controls["txtveri7"].Text);
                    double veri8 = Convert.ToDouble(Hurwicz7_3_maliyet_pl33.Controls["txtveri8"].Text);
                    double veri9 = Convert.ToDouble(Hurwicz7_3_maliyet_pl34.Controls["txtveri9"].Text);
                    if (veri7 > veri8 && veri7 > veri9)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 > veri7 && veri8 > veri9)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 > veri7 && veri9 > veri8)
                    {
                        Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text = veri9.ToString();
                    }

                    if (veri7 < veri8 && veri7 < veri9)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri7.ToString();
                    }
                    else if (veri8 < veri7 && veri8 < veri9)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri8.ToString();
                    }
                    else if (veri9 < veri7 && veri9 < veri8)
                    {
                        Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text = veri9.ToString();
                    }
                    //--------------------------------------------    

                    //f4sonuc Max-Min kısmı
                    double veri10 = Convert.ToDouble(Hurwicz7_3_maliyet_pl37.Controls["txtveri10"].Text);
                    double veri11 = Convert.ToDouble(Hurwicz7_3_maliyet_pl38.Controls["txtveri11"].Text);
                    double veri12 = Convert.ToDouble(Hurwicz7_3_maliyet_pl39.Controls["txtveri12"].Text);
                    if (veri10 > veri11 && veri10 > veri12)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 > veri10 && veri11 > veri12)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 > veri10 && veri12 > veri11)
                    {
                        Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text = veri12.ToString();
                    }

                    if (veri10 < veri11 && veri10 < veri12)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri10.ToString();
                    }
                    else if (veri11 < veri10 && veri11 < veri12)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri11.ToString();
                    }
                    else if (veri12 < veri10 && veri12 < veri11)
                    {
                        Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text = veri12.ToString();
                    }
                    //--------------------------------------------          

                    //f5sonuc Max-Min kısmı
                    double veri13 = Convert.ToDouble(Hurwicz7_3_maliyet_pl42.Controls["txtveri13"].Text);
                    double veri14 = Convert.ToDouble(Hurwicz7_3_maliyet_pl43.Controls["txtveri14"].Text);
                    double veri15 = Convert.ToDouble(Hurwicz7_3_maliyet_pl44.Controls["txtveri15"].Text);
                    if (veri13 > veri14 && veri13 > veri15)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 > veri13 && veri14 > veri15)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 > veri14 && veri15 > veri13)
                    {
                        Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text = veri15.ToString();
                    }


                    if (veri13 < veri14 && veri13 < veri15)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri13.ToString();
                    }
                    else if (veri14 < veri13 && veri14 < veri15)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri14.ToString();
                    }
                    else if (veri15 < veri14 && veri15 < veri13)
                    {
                        Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text = veri15.ToString();
                    }
                    //--------------------------------------------     

                    //f6sonuc Max-Min kısmı
                    double veri16 = Convert.ToDouble(Hurwicz7_3_maliyet_pl47.Controls["txtveri16"].Text);
                    double veri17 = Convert.ToDouble(Hurwicz7_3_maliyet_pl48.Controls["txtveri17"].Text);
                    double veri18 = Convert.ToDouble(Hurwicz7_3_maliyet_pl49.Controls["txtveri18"].Text);
                    if (veri16 > veri17 && veri16 > veri18)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 > veri16 && veri17 > veri18)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 > veri17 && veri18 > veri16)
                    {
                        Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text = veri18.ToString();
                    }

                    if (veri16 < veri17 && veri16 < veri18)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri16.ToString();
                    }
                    else if (veri17 < veri16 && veri17 < veri18)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri17.ToString();
                    }
                    else if (veri18 < veri17 && veri18 < veri16)
                    {
                        Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text = veri18.ToString();
                    }
                    //--------------------------------------------   

                    //f7sonuc  Max-Min kısmı
                    double veri19 = Convert.ToDouble(Hurwicz7_3_maliyet_pl52.Controls["txtveri19"].Text);
                    double veri20 = Convert.ToDouble(Hurwicz7_3_maliyet_pl53.Controls["txtveri20"].Text);
                    double veri21 = Convert.ToDouble(Hurwicz7_3_maliyet_pl54.Controls["txtveri21"].Text);
                    if (veri19 > veri20 && veri19 > veri21)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri19.ToString();
                    }
                    else if (veri20 > veri19 && veri20 > veri21)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri20.ToString();
                    }
                    else if (veri21 > veri19 && veri21 > veri20)
                    {
                        Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text = veri21.ToString();
                    }

                    if (veri19 < veri20 && veri19 < veri21)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri19.ToString();
                    }
                    else if (veri20 < veri19 && veri20 < veri21)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri20.ToString();
                    }
                    else if (veri21 < veri19 && veri21 < veri20)
                    {
                        Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text = veri21.ToString();
                    }
                    //--------------------------------------------   

                    //hesaplama           
                    double Maxf1sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text);
                    double Maxf2sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text);
                    double Maxf3sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text);
                    double Maxf4sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text);
                    double Maxf5sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text);
                    double Maxf6sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text);
                    double Maxf7sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text);
                    double Minf1sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text);
                    double Minf2sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text);
                    double Minf3sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text);
                    double Minf4sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text);
                    double Minf5sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text);
                    double Minf6sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text);
                    double Minf7sonuc = Convert.ToDouble(Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text);

                    double f1 = ((Maxf1sonuc * altoran1) + (Minf1sonuc * altoran2));
                    double f2 = ((Maxf2sonuc * altoran1) + (Minf2sonuc * altoran2));
                    double f3 = ((Maxf3sonuc * altoran1) + (Minf3sonuc * altoran2));
                    double f4 = ((Maxf4sonuc * altoran1) + (Minf4sonuc * altoran2));
                    double f5 = ((Maxf5sonuc * altoran1) + (Minf5sonuc * altoran2));
                    double f6 = ((Maxf6sonuc * altoran1) + (Minf6sonuc * altoran2));
                    double f7 = ((Maxf7sonuc * altoran1) + (Minf7sonuc * altoran2));

                    double kucukolanibul = 0;
                    if (f1 < f2 && f1 < f3 && f1 < f4 && f1 < f5 && f1 < f6 && f1 < f7)
                    {
                        kucukolanibul = f1;
                    }
                    else if (f2 < f1 && f2 < f3 && f2 < f4 && f2 < f5 && f2 < f6 && f2 < f7)
                    {
                        kucukolanibul = f2;
                    }
                    else if (f3 < f1 && f3 < f2 && f3 < f4 && f3 < f5 && f3 < f6 && f3 < f7)
                    {
                        kucukolanibul = f3;
                    }
                    else if (f4 < f1 && f4 < f2 && f4 < f3 && f4 < f5 && f4 < f6 && f4 < f7)
                    {
                        kucukolanibul = f4;
                    }
                    else if (f5 < f1 && f5 < f2 && f5 < f3 && f5 < f4 && f5 < f6 && f5 < f7)
                    {
                        kucukolanibul = f5;
                    }
                    else if (f6 < f1 && f6 < f2 && f6 < f3 && f6 < f4 && f6 < f5 && f6 < f7)
                    {
                        kucukolanibul = f6;
                    }
                    else if (f7 < f1 && f7 < f2 && f7 < f3 && f7 < f4 && f7 < f5 && f7 < f6)
                    {
                        kucukolanibul = f7;
                    }
                    //---------------------------------------                    
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE Hurwicz7_3_maliyet SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,Maxsonuc_1=@Maxsonuc_1,Maxsonuc_2=@Maxsonuc_2,Maxsonuc_3=@Maxsonuc_3,Maxsonuc_4=@Maxsonuc_4,Maxsonuc_5=@Maxsonuc_5,Maxsonuc_6=@Maxsonuc_6,Maxsonuc_7=@Maxsonuc_7,Minsonuc_1=@Minsonuc_1,Minsonuc_2=@Minsonuc_2,Minsonuc_3=@Minsonuc_3,Minsonuc_4=@Minsonuc_4,Minsonuc_5=@Minsonuc_5,Minsonuc_6=@Minsonuc_6,Minsonuc_7=@Minsonuc_7,altoran_1=@altoran_1,altoran_2=@altoran_2,maliyet=@maliyet WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", Hurwicz7_3_maliyet_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", Hurwicz7_3_maliyet_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", Hurwicz7_3_maliyet_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", Hurwicz7_3_maliyet_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", Hurwicz7_3_maliyet_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", Hurwicz7_3_maliyet_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", Hurwicz7_3_maliyet_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", Hurwicz7_3_maliyet_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", Hurwicz7_3_maliyet_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", Hurwicz7_3_maliyet_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", Hurwicz7_3_maliyet_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", Hurwicz7_3_maliyet_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", Hurwicz7_3_maliyet_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", Hurwicz7_3_maliyet_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", Hurwicz7_3_maliyet_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", Hurwicz7_3_maliyet_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", Hurwicz7_3_maliyet_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", Hurwicz7_3_maliyet_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", Hurwicz7_3_maliyet_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", Hurwicz7_3_maliyet_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", Hurwicz7_3_maliyet_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", Hurwicz7_3_maliyet_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", Hurwicz7_3_maliyet_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", Hurwicz7_3_maliyet_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", Hurwicz7_3_maliyet_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", Hurwicz7_3_maliyet_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", Hurwicz7_3_maliyet_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", Hurwicz7_3_maliyet_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", Hurwicz7_3_maliyet_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", Hurwicz7_3_maliyet_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", Hurwicz7_3_maliyet_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", Hurwicz7_3_maliyet_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", Hurwicz7_3_maliyet_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_1", Hurwicz7_3_maliyet_pl29.Controls["txtMaxf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_2", Hurwicz7_3_maliyet_pl30.Controls["txtMaxf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_3", Hurwicz7_3_maliyet_pl35.Controls["txtMaxf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_4", Hurwicz7_3_maliyet_pl40.Controls["txtMaxf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_5", Hurwicz7_3_maliyet_pl45.Controls["txtMaxf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_6", Hurwicz7_3_maliyet_pl50.Controls["txtMaxf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Maxsonuc_7", Hurwicz7_3_maliyet_pl55.Controls["txtMaxf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_1", Hurwicz7_3_maliyet_pl57.Controls["txtMinf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_2", Hurwicz7_3_maliyet_pl58.Controls["txtMinf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_3", Hurwicz7_3_maliyet_pl59.Controls["txtMinf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_4", Hurwicz7_3_maliyet_pl60.Controls["txtMinf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_5", Hurwicz7_3_maliyet_pl61.Controls["txtMinf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_6", Hurwicz7_3_maliyet_pl62.Controls["txtMinf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Minsonuc_7", Hurwicz7_3_maliyet_pl63.Controls["txtMinf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_1", Hurwicz7_3_maliyet_pl65.Controls["altoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altoran_2", Hurwicz7_3_maliyet_pl66.Controls["altoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@maliyet", kucukolanibul.ToString());
                    Hurwicz7_3_maliyet_pl4.Controls["sonuc"].Text = kucukolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    Hurwicz7_3_maliyet_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //Hurwicz7_3_maliyet silme yapmak için oluşturulmuş panel10
        private void Hurwicz7_3_maliyet_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = Hurwicz7_3_maliyet_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Hurwicz7_3_maliyet where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Hurwicz7_3_maliyet_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //Hurwicz7_3_maliyet hakkında kısmı için panel11 oluşturuldu
        private void Hurwicz7_3_maliyet_pl11_Click(object sender, EventArgs e)
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

        private void BelirsizlikAltındaHurwiczMaliyet_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                Hurwicz2_3_maliyet();
                Hurwicz2_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                Hurwicz3_3_maliyet();
                Hurwicz3_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                Hurwicz4_3_maliyet();
                Hurwicz4_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                Hurwicz5_3_maliyet();
                Hurwicz5_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                Hurwicz6_3_maliyet();
                Hurwicz6_3_maliyet_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                Hurwicz7_3_maliyet();
                Hurwicz7_3_maliyet_listele();
            }
        }
    }
}
