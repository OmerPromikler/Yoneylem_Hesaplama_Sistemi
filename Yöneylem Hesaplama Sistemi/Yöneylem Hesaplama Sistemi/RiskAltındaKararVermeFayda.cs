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
    public partial class RiskAltındaKararVermeFayda : Form
    {
        public RiskAltındaKararVermeFayda()
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

        //risk2_3_fayda form nesneleri
        Panel risk2_3_fayda_pl1 = new Panel();
        Panel risk2_3_fayda_pl2 = new Panel();
        Panel risk2_3_fayda_pl3 = new Panel();
        Panel risk2_3_fayda_pl4 = new Panel();
        Panel risk2_3_fayda_pl5 = new Panel();
        Panel risk2_3_fayda_pl6 = new Panel();
        Panel risk2_3_fayda_pl7 = new Panel();
        Panel risk2_3_fayda_pl8 = new Panel();
        Panel risk2_3_fayda_pl9 = new Panel();
        Panel risk2_3_fayda_pl10 = new Panel();
        Panel risk2_3_fayda_pl11 = new Panel();
        Panel risk2_3_fayda_pl12 = new Panel();
        Panel risk2_3_fayda_pl13 = new Panel();
        Panel risk2_3_fayda_pl14 = new Panel();
        Panel risk2_3_fayda_pl15 = new Panel();
        Panel risk2_3_fayda_pl16 = new Panel();
        Panel risk2_3_fayda_pl17 = new Panel();
        Panel risk2_3_fayda_pl18 = new Panel();
        Panel risk2_3_fayda_pl19 = new Panel();
        Panel risk2_3_fayda_pl20 = new Panel();
        Panel risk2_3_fayda_pl21 = new Panel();
        Panel risk2_3_fayda_pl22 = new Panel();
        Panel risk2_3_fayda_pl23 = new Panel();
        Panel risk2_3_fayda_pl24 = new Panel();
        Panel risk2_3_fayda_pl25 = new Panel();
        Panel risk2_3_fayda_pl26 = new Panel();
        Panel risk2_3_fayda_pl27 = new Panel();
        Panel risk2_3_fayda_pl28 = new Panel();
        Panel risk2_3_fayda_pl29 = new Panel();
        Panel risk2_3_fayda_pl30 = new Panel();
        TabControl risk2_3_fayda_tb1 = new TabControl();
        TabPage risk2_3_fayda_tb1_1 = new TabPage();
        TabPage risk2_3_fayda_tb1_2 = new TabPage();
        TabPage risk2_3_fayda_tb1_3 = new TabPage();
        TextBox risk2_3_fayda_txt_baslik1;
        TextBox risk2_3_fayda_txt_baslik2;
        TextBox risk2_3_fayda_txt_altbaslik1;
        TextBox risk2_3_fayda_txt_altbaslik2;
        TextBox risk2_3_fayda_txt_üstbaslik1;
        TextBox risk2_3_fayda_txt_üstbaslik2;
        TextBox risk2_3_fayda_txt_üstbaslik3;
        TextBox risk2_3_fayda_txt_oran1;
        TextBox risk2_3_fayda_txt_oran2;
        TextBox risk2_3_fayda_txt_oran3;
        TextBox risk2_3_fayda_txt_f1sonuc;
        TextBox risk2_3_fayda_txt_f2sonuc;
        NumericUpDown risk2_3_fayda_txt_veri1;
        NumericUpDown risk2_3_fayda_txt_veri2;
        NumericUpDown risk2_3_fayda_txt_veri3;
        NumericUpDown risk2_3_fayda_txt_veri4;
        NumericUpDown risk2_3_fayda_txt_veri5;
        NumericUpDown risk2_3_fayda_txt_veri6;
        Label risk2_3_fayda_sonucbaslik;
        Label risk2_3_fayda_sonuc;
        Label risk2_3_fayda_sonuclarortabaslik;
        DataGridView risk2_3_fayda_dr1 = new DataGridView();
        Button risk2_3_fayda_btn1 = new Button();
        Button risk2_3_fayda_btn2 = new Button();
        Button risk2_3_fayda_btn3 = new Button();
        RichTextBox risk2_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk3_3_fayda form nesneleri
        Panel risk3_3_fayda_pl1 = new Panel();
        Panel risk3_3_fayda_pl2 = new Panel();
        Panel risk3_3_fayda_pl3 = new Panel();
        Panel risk3_3_fayda_pl4 = new Panel();
        Panel risk3_3_fayda_pl5 = new Panel();
        Panel risk3_3_fayda_pl6 = new Panel();
        Panel risk3_3_fayda_pl7 = new Panel();
        Panel risk3_3_fayda_pl8 = new Panel();
        Panel risk3_3_fayda_pl9 = new Panel();
        Panel risk3_3_fayda_pl10 = new Panel();
        Panel risk3_3_fayda_pl11 = new Panel();
        Panel risk3_3_fayda_pl12 = new Panel();
        Panel risk3_3_fayda_pl13 = new Panel();
        Panel risk3_3_fayda_pl14 = new Panel();
        Panel risk3_3_fayda_pl15 = new Panel();
        Panel risk3_3_fayda_pl16 = new Panel();
        Panel risk3_3_fayda_pl17 = new Panel();
        Panel risk3_3_fayda_pl18 = new Panel();
        Panel risk3_3_fayda_pl19 = new Panel();
        Panel risk3_3_fayda_pl20 = new Panel();
        Panel risk3_3_fayda_pl21 = new Panel();
        Panel risk3_3_fayda_pl22 = new Panel();
        Panel risk3_3_fayda_pl23 = new Panel();
        Panel risk3_3_fayda_pl24 = new Panel();
        Panel risk3_3_fayda_pl25 = new Panel();
        Panel risk3_3_fayda_pl26 = new Panel();
        Panel risk3_3_fayda_pl27 = new Panel();
        Panel risk3_3_fayda_pl28 = new Panel();
        Panel risk3_3_fayda_pl29 = new Panel();
        Panel risk3_3_fayda_pl30 = new Panel();
        Panel risk3_3_fayda_pl31 = new Panel();
        Panel risk3_3_fayda_pl32 = new Panel();
        Panel risk3_3_fayda_pl33 = new Panel();
        Panel risk3_3_fayda_pl34 = new Panel();
        Panel risk3_3_fayda_pl35 = new Panel();
        TabControl risk3_3_fayda_tb1 = new TabControl();
        TabPage risk3_3_fayda_tb1_1 = new TabPage();
        TabPage risk3_3_fayda_tb1_2 = new TabPage();
        TabPage risk3_3_fayda_tb1_3 = new TabPage();
        TextBox risk3_3_fayda_txt_baslik1;
        TextBox risk3_3_fayda_txt_baslik2;
        TextBox risk3_3_fayda_txt_altbaslik1;
        TextBox risk3_3_fayda_txt_altbaslik2;
        TextBox risk3_3_fayda_txt_altbaslik3;
        TextBox risk3_3_fayda_txt_üstbaslik1;
        TextBox risk3_3_fayda_txt_üstbaslik2;
        TextBox risk3_3_fayda_txt_üstbaslik3;
        TextBox risk3_3_fayda_txt_oran1;
        TextBox risk3_3_fayda_txt_oran2;
        TextBox risk3_3_fayda_txt_oran3;
        TextBox risk3_3_fayda_txt_f1sonuc;
        TextBox risk3_3_fayda_txt_f2sonuc;
        TextBox risk3_3_fayda_txt_f3sonuc;
        NumericUpDown risk3_3_fayda_txt_veri1;
        NumericUpDown risk3_3_fayda_txt_veri2;
        NumericUpDown risk3_3_fayda_txt_veri3;
        NumericUpDown risk3_3_fayda_txt_veri4;
        NumericUpDown risk3_3_fayda_txt_veri5;
        NumericUpDown risk3_3_fayda_txt_veri6;
        NumericUpDown risk3_3_fayda_txt_veri7;
        NumericUpDown risk3_3_fayda_txt_veri8;
        NumericUpDown risk3_3_fayda_txt_veri9;
        Label risk3_3_fayda_sonucbaslik;
        Label risk3_3_fayda_sonuc;
        Label risk3_3_fayda_sonuclarortabaslik;
        DataGridView risk3_3_fayda_dr1 = new DataGridView();
        Button risk3_3_fayda_btn1 = new Button();
        Button risk3_3_fayda_btn2 = new Button();
        Button risk3_3_fayda_btn3 = new Button();
        RichTextBox risk3_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk4_3_fayda form nesneleri
        Panel risk4_3_fayda_pl1 = new Panel();
        Panel risk4_3_fayda_pl2 = new Panel();
        Panel risk4_3_fayda_pl3 = new Panel();
        Panel risk4_3_fayda_pl4 = new Panel();
        Panel risk4_3_fayda_pl5 = new Panel();
        Panel risk4_3_fayda_pl6 = new Panel();
        Panel risk4_3_fayda_pl7 = new Panel();
        Panel risk4_3_fayda_pl8 = new Panel();
        Panel risk4_3_fayda_pl9 = new Panel();
        Panel risk4_3_fayda_pl10 = new Panel();
        Panel risk4_3_fayda_pl11 = new Panel();
        Panel risk4_3_fayda_pl12 = new Panel();
        Panel risk4_3_fayda_pl13 = new Panel();
        Panel risk4_3_fayda_pl14 = new Panel();
        Panel risk4_3_fayda_pl15 = new Panel();
        Panel risk4_3_fayda_pl16 = new Panel();
        Panel risk4_3_fayda_pl17 = new Panel();
        Panel risk4_3_fayda_pl18 = new Panel();
        Panel risk4_3_fayda_pl19 = new Panel();
        Panel risk4_3_fayda_pl20 = new Panel();
        Panel risk4_3_fayda_pl21 = new Panel();
        Panel risk4_3_fayda_pl22 = new Panel();
        Panel risk4_3_fayda_pl23 = new Panel();
        Panel risk4_3_fayda_pl24 = new Panel();
        Panel risk4_3_fayda_pl25 = new Panel();
        Panel risk4_3_fayda_pl26 = new Panel();
        Panel risk4_3_fayda_pl27 = new Panel();
        Panel risk4_3_fayda_pl28 = new Panel();
        Panel risk4_3_fayda_pl29 = new Panel();
        Panel risk4_3_fayda_pl30 = new Panel();
        Panel risk4_3_fayda_pl31 = new Panel();
        Panel risk4_3_fayda_pl32 = new Panel();
        Panel risk4_3_fayda_pl33 = new Panel();
        Panel risk4_3_fayda_pl34 = new Panel();
        Panel risk4_3_fayda_pl35 = new Panel();
        Panel risk4_3_fayda_pl36 = new Panel();
        Panel risk4_3_fayda_pl37 = new Panel();
        Panel risk4_3_fayda_pl38 = new Panel();
        Panel risk4_3_fayda_pl39 = new Panel();
        Panel risk4_3_fayda_pl40 = new Panel();
        TabControl risk4_3_fayda_tb1 = new TabControl();
        TabPage risk4_3_fayda_tb1_1 = new TabPage();
        TabPage risk4_3_fayda_tb1_2 = new TabPage();
        TabPage risk4_3_fayda_tb1_3 = new TabPage();
        TextBox risk4_3_fayda_txt_baslik1;
        TextBox risk4_3_fayda_txt_baslik2;
        TextBox risk4_3_fayda_txt_altbaslik1;
        TextBox risk4_3_fayda_txt_altbaslik2;
        TextBox risk4_3_fayda_txt_altbaslik3;
        TextBox risk4_3_fayda_txt_altbaslik4;
        TextBox risk4_3_fayda_txt_üstbaslik1;
        TextBox risk4_3_fayda_txt_üstbaslik2;
        TextBox risk4_3_fayda_txt_üstbaslik3;
        TextBox risk4_3_fayda_txt_oran1;
        TextBox risk4_3_fayda_txt_oran2;
        TextBox risk4_3_fayda_txt_oran3;
        TextBox risk4_3_fayda_txt_f1sonuc;
        TextBox risk4_3_fayda_txt_f2sonuc;
        TextBox risk4_3_fayda_txt_f3sonuc;
        TextBox risk4_3_fayda_txt_f4sonuc;
        NumericUpDown risk4_3_fayda_txt_veri1;
        NumericUpDown risk4_3_fayda_txt_veri2;
        NumericUpDown risk4_3_fayda_txt_veri3;
        NumericUpDown risk4_3_fayda_txt_veri4;
        NumericUpDown risk4_3_fayda_txt_veri5;
        NumericUpDown risk4_3_fayda_txt_veri6;
        NumericUpDown risk4_3_fayda_txt_veri7;
        NumericUpDown risk4_3_fayda_txt_veri8;
        NumericUpDown risk4_3_fayda_txt_veri9;
        NumericUpDown risk4_3_fayda_txt_veri10;
        NumericUpDown risk4_3_fayda_txt_veri11;
        NumericUpDown risk4_3_fayda_txt_veri12;
        Label risk4_3_fayda_sonucbaslik;
        Label risk4_3_fayda_sonuc;
        Label risk4_3_fayda_sonuclarortabaslik;
        DataGridView risk4_3_fayda_dr1 = new DataGridView();
        Button risk4_3_fayda_btn1 = new Button();
        Button risk4_3_fayda_btn2 = new Button();
        Button risk4_3_fayda_btn3 = new Button();
        RichTextBox risk4_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk5_3_fayda form nesneleri
        Panel risk5_3_fayda_pl1 = new Panel();
        Panel risk5_3_fayda_pl2 = new Panel();
        Panel risk5_3_fayda_pl3 = new Panel();
        Panel risk5_3_fayda_pl4 = new Panel();
        Panel risk5_3_fayda_pl5 = new Panel();
        Panel risk5_3_fayda_pl6 = new Panel();
        Panel risk5_3_fayda_pl7 = new Panel();
        Panel risk5_3_fayda_pl8 = new Panel();
        Panel risk5_3_fayda_pl9 = new Panel();
        Panel risk5_3_fayda_pl10 = new Panel();
        Panel risk5_3_fayda_pl11 = new Panel();
        Panel risk5_3_fayda_pl12 = new Panel();
        Panel risk5_3_fayda_pl13 = new Panel();
        Panel risk5_3_fayda_pl14 = new Panel();
        Panel risk5_3_fayda_pl15 = new Panel();
        Panel risk5_3_fayda_pl16 = new Panel();
        Panel risk5_3_fayda_pl17 = new Panel();
        Panel risk5_3_fayda_pl18 = new Panel();
        Panel risk5_3_fayda_pl19 = new Panel();
        Panel risk5_3_fayda_pl20 = new Panel();
        Panel risk5_3_fayda_pl21 = new Panel();
        Panel risk5_3_fayda_pl22 = new Panel();
        Panel risk5_3_fayda_pl23 = new Panel();
        Panel risk5_3_fayda_pl24 = new Panel();
        Panel risk5_3_fayda_pl25 = new Panel();
        Panel risk5_3_fayda_pl26 = new Panel();
        Panel risk5_3_fayda_pl27 = new Panel();
        Panel risk5_3_fayda_pl28 = new Panel();
        Panel risk5_3_fayda_pl29 = new Panel();
        Panel risk5_3_fayda_pl30 = new Panel();
        Panel risk5_3_fayda_pl31 = new Panel();
        Panel risk5_3_fayda_pl32 = new Panel();
        Panel risk5_3_fayda_pl33 = new Panel();
        Panel risk5_3_fayda_pl34 = new Panel();
        Panel risk5_3_fayda_pl35 = new Panel();
        Panel risk5_3_fayda_pl36 = new Panel();
        Panel risk5_3_fayda_pl37 = new Panel();
        Panel risk5_3_fayda_pl38 = new Panel();
        Panel risk5_3_fayda_pl39 = new Panel();
        Panel risk5_3_fayda_pl40 = new Panel();
        Panel risk5_3_fayda_pl41 = new Panel();
        Panel risk5_3_fayda_pl42 = new Panel();
        Panel risk5_3_fayda_pl43 = new Panel();
        Panel risk5_3_fayda_pl44 = new Panel();
        Panel risk5_3_fayda_pl45 = new Panel();
        TabControl risk5_3_fayda_tb1 = new TabControl();
        TabPage risk5_3_fayda_tb1_1 = new TabPage();
        TabPage risk5_3_fayda_tb1_2 = new TabPage();
        TabPage risk5_3_fayda_tb1_3 = new TabPage();
        TextBox risk5_3_fayda_txt_baslik1;
        TextBox risk5_3_fayda_txt_baslik2;
        TextBox risk5_3_fayda_txt_altbaslik1;
        TextBox risk5_3_fayda_txt_altbaslik2;
        TextBox risk5_3_fayda_txt_altbaslik3;
        TextBox risk5_3_fayda_txt_altbaslik4;
        TextBox risk5_3_fayda_txt_altbaslik5;
        TextBox risk5_3_fayda_txt_üstbaslik1;
        TextBox risk5_3_fayda_txt_üstbaslik2;
        TextBox risk5_3_fayda_txt_üstbaslik3;
        TextBox risk5_3_fayda_txt_oran1;
        TextBox risk5_3_fayda_txt_oran2;
        TextBox risk5_3_fayda_txt_oran3;
        TextBox risk5_3_fayda_txt_f1sonuc;
        TextBox risk5_3_fayda_txt_f2sonuc;
        TextBox risk5_3_fayda_txt_f3sonuc;
        TextBox risk5_3_fayda_txt_f4sonuc;
        TextBox risk5_3_fayda_txt_f5sonuc;
        NumericUpDown risk5_3_fayda_txt_veri1;
        NumericUpDown risk5_3_fayda_txt_veri2;
        NumericUpDown risk5_3_fayda_txt_veri3;
        NumericUpDown risk5_3_fayda_txt_veri4;
        NumericUpDown risk5_3_fayda_txt_veri5;
        NumericUpDown risk5_3_fayda_txt_veri6;
        NumericUpDown risk5_3_fayda_txt_veri7;
        NumericUpDown risk5_3_fayda_txt_veri8;
        NumericUpDown risk5_3_fayda_txt_veri9;
        NumericUpDown risk5_3_fayda_txt_veri10;
        NumericUpDown risk5_3_fayda_txt_veri11;
        NumericUpDown risk5_3_fayda_txt_veri12;
        NumericUpDown risk5_3_fayda_txt_veri13;
        NumericUpDown risk5_3_fayda_txt_veri14;
        NumericUpDown risk5_3_fayda_txt_veri15;
        Label risk5_3_fayda_sonucbaslik;
        Label risk5_3_fayda_sonuc;
        Label risk5_3_fayda_sonuclarortabaslik;
        DataGridView risk5_3_fayda_dr1 = new DataGridView();
        Button risk5_3_fayda_btn1 = new Button();
        Button risk5_3_fayda_btn2 = new Button();
        Button risk5_3_fayda_btn3 = new Button();
        RichTextBox risk5_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk6_3_fayda form nesneleri
        Panel risk6_3_fayda_pl1 = new Panel();
        Panel risk6_3_fayda_pl2 = new Panel();
        Panel risk6_3_fayda_pl3 = new Panel();
        Panel risk6_3_fayda_pl4 = new Panel();
        Panel risk6_3_fayda_pl5 = new Panel();
        Panel risk6_3_fayda_pl6 = new Panel();
        Panel risk6_3_fayda_pl7 = new Panel();
        Panel risk6_3_fayda_pl8 = new Panel();
        Panel risk6_3_fayda_pl9 = new Panel();
        Panel risk6_3_fayda_pl10 = new Panel();
        Panel risk6_3_fayda_pl11 = new Panel();
        Panel risk6_3_fayda_pl12 = new Panel();
        Panel risk6_3_fayda_pl13 = new Panel();
        Panel risk6_3_fayda_pl14 = new Panel();
        Panel risk6_3_fayda_pl15 = new Panel();
        Panel risk6_3_fayda_pl16 = new Panel();
        Panel risk6_3_fayda_pl17 = new Panel();
        Panel risk6_3_fayda_pl18 = new Panel();
        Panel risk6_3_fayda_pl19 = new Panel();
        Panel risk6_3_fayda_pl20 = new Panel();
        Panel risk6_3_fayda_pl21 = new Panel();
        Panel risk6_3_fayda_pl22 = new Panel();
        Panel risk6_3_fayda_pl23 = new Panel();
        Panel risk6_3_fayda_pl24 = new Panel();
        Panel risk6_3_fayda_pl25 = new Panel();
        Panel risk6_3_fayda_pl26 = new Panel();
        Panel risk6_3_fayda_pl27 = new Panel();
        Panel risk6_3_fayda_pl28 = new Panel();
        Panel risk6_3_fayda_pl29 = new Panel();
        Panel risk6_3_fayda_pl30 = new Panel();
        Panel risk6_3_fayda_pl31 = new Panel();
        Panel risk6_3_fayda_pl32 = new Panel();
        Panel risk6_3_fayda_pl33 = new Panel();
        Panel risk6_3_fayda_pl34 = new Panel();
        Panel risk6_3_fayda_pl35 = new Panel();
        Panel risk6_3_fayda_pl36 = new Panel();
        Panel risk6_3_fayda_pl37 = new Panel();
        Panel risk6_3_fayda_pl38 = new Panel();
        Panel risk6_3_fayda_pl39 = new Panel();
        Panel risk6_3_fayda_pl40 = new Panel();
        Panel risk6_3_fayda_pl41 = new Panel();
        Panel risk6_3_fayda_pl42 = new Panel();
        Panel risk6_3_fayda_pl43 = new Panel();
        Panel risk6_3_fayda_pl44 = new Panel();
        Panel risk6_3_fayda_pl45 = new Panel();
        Panel risk6_3_fayda_pl46 = new Panel();
        Panel risk6_3_fayda_pl47 = new Panel();
        Panel risk6_3_fayda_pl48 = new Panel();
        Panel risk6_3_fayda_pl49 = new Panel();
        Panel risk6_3_fayda_pl50 = new Panel();
        TabControl risk6_3_fayda_tb1 = new TabControl();
        TabPage risk6_3_fayda_tb1_1 = new TabPage();
        TabPage risk6_3_fayda_tb1_2 = new TabPage();
        TabPage risk6_3_fayda_tb1_3 = new TabPage();
        TextBox risk6_3_fayda_txt_baslik1;
        TextBox risk6_3_fayda_txt_baslik2;
        TextBox risk6_3_fayda_txt_altbaslik1;
        TextBox risk6_3_fayda_txt_altbaslik2;
        TextBox risk6_3_fayda_txt_altbaslik3;
        TextBox risk6_3_fayda_txt_altbaslik4;
        TextBox risk6_3_fayda_txt_altbaslik5;
        TextBox risk6_3_fayda_txt_altbaslik6;
        TextBox risk6_3_fayda_txt_üstbaslik1;
        TextBox risk6_3_fayda_txt_üstbaslik2;
        TextBox risk6_3_fayda_txt_üstbaslik3;
        TextBox risk6_3_fayda_txt_oran1;
        TextBox risk6_3_fayda_txt_oran2;
        TextBox risk6_3_fayda_txt_oran3;
        TextBox risk6_3_fayda_txt_f1sonuc;
        TextBox risk6_3_fayda_txt_f2sonuc;
        TextBox risk6_3_fayda_txt_f3sonuc;
        TextBox risk6_3_fayda_txt_f4sonuc;
        TextBox risk6_3_fayda_txt_f5sonuc;
        TextBox risk6_3_fayda_txt_f6sonuc;
        NumericUpDown risk6_3_fayda_txt_veri1;
        NumericUpDown risk6_3_fayda_txt_veri2;
        NumericUpDown risk6_3_fayda_txt_veri3;
        NumericUpDown risk6_3_fayda_txt_veri4;
        NumericUpDown risk6_3_fayda_txt_veri5;
        NumericUpDown risk6_3_fayda_txt_veri6;
        NumericUpDown risk6_3_fayda_txt_veri7;
        NumericUpDown risk6_3_fayda_txt_veri8;
        NumericUpDown risk6_3_fayda_txt_veri9;
        NumericUpDown risk6_3_fayda_txt_veri10;
        NumericUpDown risk6_3_fayda_txt_veri11;
        NumericUpDown risk6_3_fayda_txt_veri12;
        NumericUpDown risk6_3_fayda_txt_veri13;
        NumericUpDown risk6_3_fayda_txt_veri14;
        NumericUpDown risk6_3_fayda_txt_veri15;
        NumericUpDown risk6_3_fayda_txt_veri16;
        NumericUpDown risk6_3_fayda_txt_veri17;
        NumericUpDown risk6_3_fayda_txt_veri18;
        Label risk6_3_fayda_sonucbaslik;
        Label risk6_3_fayda_sonuc;
        Label risk6_3_fayda_sonuclarortabaslik;
        DataGridView risk6_3_fayda_dr1 = new DataGridView();
        Button risk6_3_fayda_btn1 = new Button();
        Button risk6_3_fayda_btn2 = new Button();
        Button risk6_3_fayda_btn3 = new Button();
        RichTextBox risk6_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk7_3_fayda form nesneleri
        Panel risk7_3_fayda_pl1 = new Panel();
        Panel risk7_3_fayda_pl2 = new Panel();
        Panel risk7_3_fayda_pl3 = new Panel();
        Panel risk7_3_fayda_pl4 = new Panel();
        Panel risk7_3_fayda_pl5 = new Panel();
        Panel risk7_3_fayda_pl6 = new Panel();
        Panel risk7_3_fayda_pl7 = new Panel();
        Panel risk7_3_fayda_pl8 = new Panel();
        Panel risk7_3_fayda_pl9 = new Panel();
        Panel risk7_3_fayda_pl10 = new Panel();
        Panel risk7_3_fayda_pl11 = new Panel();
        Panel risk7_3_fayda_pl12 = new Panel();
        Panel risk7_3_fayda_pl13 = new Panel();
        Panel risk7_3_fayda_pl14 = new Panel();
        Panel risk7_3_fayda_pl15 = new Panel();
        Panel risk7_3_fayda_pl16 = new Panel();
        Panel risk7_3_fayda_pl17 = new Panel();
        Panel risk7_3_fayda_pl18 = new Panel();
        Panel risk7_3_fayda_pl19 = new Panel();
        Panel risk7_3_fayda_pl20 = new Panel();
        Panel risk7_3_fayda_pl21 = new Panel();
        Panel risk7_3_fayda_pl22 = new Panel();
        Panel risk7_3_fayda_pl23 = new Panel();
        Panel risk7_3_fayda_pl24 = new Panel();
        Panel risk7_3_fayda_pl25 = new Panel();
        Panel risk7_3_fayda_pl26 = new Panel();
        Panel risk7_3_fayda_pl27 = new Panel();
        Panel risk7_3_fayda_pl28 = new Panel();
        Panel risk7_3_fayda_pl29 = new Panel();
        Panel risk7_3_fayda_pl30 = new Panel();
        Panel risk7_3_fayda_pl31 = new Panel();
        Panel risk7_3_fayda_pl32 = new Panel();
        Panel risk7_3_fayda_pl33 = new Panel();
        Panel risk7_3_fayda_pl34 = new Panel();
        Panel risk7_3_fayda_pl35 = new Panel();
        Panel risk7_3_fayda_pl36 = new Panel();
        Panel risk7_3_fayda_pl37 = new Panel();
        Panel risk7_3_fayda_pl38 = new Panel();
        Panel risk7_3_fayda_pl39 = new Panel();
        Panel risk7_3_fayda_pl40 = new Panel();
        Panel risk7_3_fayda_pl41 = new Panel();
        Panel risk7_3_fayda_pl42 = new Panel();
        Panel risk7_3_fayda_pl43 = new Panel();
        Panel risk7_3_fayda_pl44 = new Panel();
        Panel risk7_3_fayda_pl45 = new Panel();
        Panel risk7_3_fayda_pl46 = new Panel();
        Panel risk7_3_fayda_pl47 = new Panel();
        Panel risk7_3_fayda_pl48 = new Panel();
        Panel risk7_3_fayda_pl49 = new Panel();
        Panel risk7_3_fayda_pl50 = new Panel();
        Panel risk7_3_fayda_pl51 = new Panel();
        Panel risk7_3_fayda_pl52 = new Panel();
        Panel risk7_3_fayda_pl53 = new Panel();
        Panel risk7_3_fayda_pl54 = new Panel();
        Panel risk7_3_fayda_pl55 = new Panel();
        TabControl risk7_3_fayda_tb1 = new TabControl();
        TabPage risk7_3_fayda_tb1_1 = new TabPage();
        TabPage risk7_3_fayda_tb1_2 = new TabPage();
        TabPage risk7_3_fayda_tb1_3 = new TabPage();
        TextBox risk7_3_fayda_txt_baslik1;
        TextBox risk7_3_fayda_txt_baslik2;
        TextBox risk7_3_fayda_txt_altbaslik1;
        TextBox risk7_3_fayda_txt_altbaslik2;
        TextBox risk7_3_fayda_txt_altbaslik3;
        TextBox risk7_3_fayda_txt_altbaslik4;
        TextBox risk7_3_fayda_txt_altbaslik5;
        TextBox risk7_3_fayda_txt_altbaslik6;
        TextBox risk7_3_fayda_txt_altbaslik7;
        TextBox risk7_3_fayda_txt_üstbaslik1;
        TextBox risk7_3_fayda_txt_üstbaslik2;
        TextBox risk7_3_fayda_txt_üstbaslik3;
        TextBox risk7_3_fayda_txt_oran1;
        TextBox risk7_3_fayda_txt_oran2;
        TextBox risk7_3_fayda_txt_oran3;
        TextBox risk7_3_fayda_txt_f1sonuc;
        TextBox risk7_3_fayda_txt_f2sonuc;
        TextBox risk7_3_fayda_txt_f3sonuc;
        TextBox risk7_3_fayda_txt_f4sonuc;
        TextBox risk7_3_fayda_txt_f5sonuc;
        TextBox risk7_3_fayda_txt_f6sonuc;
        TextBox risk7_3_fayda_txt_f7sonuc;
        NumericUpDown risk7_3_fayda_txt_veri1;
        NumericUpDown risk7_3_fayda_txt_veri2;
        NumericUpDown risk7_3_fayda_txt_veri3;
        NumericUpDown risk7_3_fayda_txt_veri4;
        NumericUpDown risk7_3_fayda_txt_veri5;
        NumericUpDown risk7_3_fayda_txt_veri6;
        NumericUpDown risk7_3_fayda_txt_veri7;
        NumericUpDown risk7_3_fayda_txt_veri8;
        NumericUpDown risk7_3_fayda_txt_veri9;
        NumericUpDown risk7_3_fayda_txt_veri10;
        NumericUpDown risk7_3_fayda_txt_veri11;
        NumericUpDown risk7_3_fayda_txt_veri12;
        NumericUpDown risk7_3_fayda_txt_veri13;
        NumericUpDown risk7_3_fayda_txt_veri14;
        NumericUpDown risk7_3_fayda_txt_veri15;
        NumericUpDown risk7_3_fayda_txt_veri16;
        NumericUpDown risk7_3_fayda_txt_veri17;
        NumericUpDown risk7_3_fayda_txt_veri18;
        NumericUpDown risk7_3_fayda_txt_veri19;
        NumericUpDown risk7_3_fayda_txt_veri20;
        NumericUpDown risk7_3_fayda_txt_veri21;
        Label risk7_3_fayda_sonucbaslik;
        Label risk7_3_fayda_sonuc;
        Label risk7_3_fayda_sonuclarortabaslik;
        DataGridView risk7_3_fayda_dr1 = new DataGridView();
        Button risk7_3_fayda_btn1 = new Button();
        Button risk7_3_fayda_btn2 = new Button();
        Button risk7_3_fayda_btn3 = new Button();
        RichTextBox risk7_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //risk2_3_fayda form nesne tasarımları
        public void risk2_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk2_3_fayda_sonuc = new Label();
            risk2_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk2_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk2_3_fayda_sonuc.Location = sonuc;
            risk2_3_fayda_sonuc.Text = "";
            risk2_3_fayda_sonuc.Size = new Size(650, 13);
            risk2_3_fayda_pl4.Controls.Add(risk2_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk2_3_fayda_sonucbaslik = new Label();
            risk2_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk2_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk2_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk2_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk2_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk2_3_fayda_pl4.Controls.Add(risk2_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk2_3_fayda_sonuclarortabaslik = new Label();
            risk2_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk2_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk2_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk2_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk2_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk2_3_fayda_pl28.Controls.Add(risk2_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri6 = new NumericUpDown();
            risk2_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk2_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri6.Location = txt_veri6;
            risk2_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk2_3_fayda_pl27.Controls.Add(risk2_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri5 = new NumericUpDown();
            risk2_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk2_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri5.Location = txt_veri5;
            risk2_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk2_3_fayda_pl23.Controls.Add(risk2_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri4 = new NumericUpDown();
            risk2_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk2_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri4.Location = txt_veri4;
            risk2_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk2_3_fayda_pl22.Controls.Add(risk2_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri3 = new NumericUpDown();
            risk2_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk2_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri3.Location = txt_veri3;
            risk2_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk2_3_fayda_pl26.Controls.Add(risk2_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri2 = new NumericUpDown();
            risk2_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk2_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri2.Location = txt_veri2;
            risk2_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk2_3_fayda_pl21.Controls.Add(risk2_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk2_3_fayda_txt_veri1 = new NumericUpDown();
            risk2_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk2_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk2_3_fayda_txt_veri1.Location = txt_veri1;
            risk2_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk2_3_fayda_pl20.Controls.Add(risk2_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk2_3_fayda_txt_f2sonuc = new TextBox();
            risk2_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk2_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk2_3_fayda_txt_f2sonuc.Text = "0";
            risk2_3_fayda_txt_f2sonuc.Enabled = false;
            risk2_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk2_3_fayda_pl30.Controls.Add(risk2_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk2_3_fayda_txt_f1sonuc = new TextBox();
            risk2_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk2_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk2_3_fayda_txt_f1sonuc.Text = "0";
            risk2_3_fayda_txt_f1sonuc.Enabled = false;
            risk2_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk2_3_fayda_pl29.Controls.Add(risk2_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk2_3_fayda_txt_oran3 = new TextBox();
            risk2_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk2_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk2_3_fayda_txt_oran3.Text = "0,30";
            risk2_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_oran3.MaxLength = 30;
            risk2_3_fayda_txt_oran3.Multiline = true;
            risk2_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk2_3_fayda_pl25.Controls.Add(risk2_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk2_3_fayda_txt_oran2 = new TextBox();
            risk2_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk2_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk2_3_fayda_txt_oran2.Text = "0,20";
            risk2_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_oran2.MaxLength = 30;
            risk2_3_fayda_txt_oran2.Multiline = true;
            risk2_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk2_3_fayda_pl19.Controls.Add(risk2_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk2_3_fayda_txt_oran1 = new TextBox();
            risk2_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk2_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk2_3_fayda_txt_oran1.Text = "0,50";
            risk2_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_oran1.MaxLength = 30;
            risk2_3_fayda_txt_oran1.Multiline = true;
            risk2_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk2_3_fayda_pl18.Controls.Add(risk2_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk2_3_fayda_txt_üstbaslik3 = new TextBox();
            risk2_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk2_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk2_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk2_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk2_3_fayda_txt_üstbaslik3.Multiline = true;
            risk2_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk2_3_fayda_pl24.Controls.Add(risk2_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk2_3_fayda_txt_üstbaslik2 = new TextBox();
            risk2_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk2_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk2_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk2_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk2_3_fayda_txt_üstbaslik2.Multiline = true;
            risk2_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk2_3_fayda_pl17.Controls.Add(risk2_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk2_3_fayda_txt_üstbaslik1 = new TextBox();
            risk2_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk2_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk2_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk2_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk2_3_fayda_txt_üstbaslik1.Multiline = true;
            risk2_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk2_3_fayda_pl16.Controls.Add(risk2_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk2_3_fayda_txt_altbaslik2 = new TextBox();
            risk2_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk2_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk2_3_fayda_txt_altbaslik2.Text = "F2";
            risk2_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk2_3_fayda_txt_altbaslik2.Multiline = true;
            risk2_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk2_3_fayda_pl15.Controls.Add(risk2_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk2_3_fayda_txt_altbaslik1 = new TextBox();
            risk2_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk2_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk2_3_fayda_txt_altbaslik1.Text = "F1";
            risk2_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk2_3_fayda_txt_altbaslik1.Multiline = true;
            risk2_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk2_3_fayda_pl14.Controls.Add(risk2_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk2_3_fayda_txt_baslik2 = new TextBox();
            risk2_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk2_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk2_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk2_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_baslik2.MaxLength = 30;
            risk2_3_fayda_txt_baslik2.Multiline = true;
            risk2_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk2_3_fayda_pl13.Controls.Add(risk2_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk2_3_fayda_txt_baslik1 = new TextBox();
            risk2_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk2_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk2_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk2_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk2_3_fayda_txt_baslik1.MaxLength = 30;
            risk2_3_fayda_txt_baslik1.Multiline = true;
            risk2_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk2_3_fayda_pl12.Controls.Add(risk2_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk2_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk2_3_fayda_pl30.Location = pl30k;
            risk2_3_fayda_pl30.Size = new Size(91, 33);
            risk2_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk2_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk2_3_fayda_pl29.Location = pl29k;
            risk2_3_fayda_pl29.Size = new Size(91, 33);
            risk2_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk2_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk2_3_fayda_pl28.Location = pl28k;
            risk2_3_fayda_pl28.Size = new Size(91, 72);
            risk2_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk2_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk2_3_fayda_pl27.Location = pl27k;
            risk2_3_fayda_pl27.Size = new Size(91, 33);
            risk2_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk2_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk2_3_fayda_pl26.Location = pl26k;
            risk2_3_fayda_pl26.Size = new Size(91, 33);
            risk2_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk2_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk2_3_fayda_pl23.Location = pl23k;
            risk2_3_fayda_pl23.Size = new Size(91, 33);
            risk2_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk2_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk2_3_fayda_pl22.Location = pl22k;
            risk2_3_fayda_pl22.Size = new Size(91, 33);
            risk2_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk2_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk2_3_fayda_pl21.Location = pl21k;
            risk2_3_fayda_pl21.Size = new Size(91, 33);
            risk2_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk2_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk2_3_fayda_pl20.Location = pl20k;
            risk2_3_fayda_pl20.Size = new Size(91, 33);
            risk2_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk2_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk2_3_fayda_pl25.Location = pl25k;
            risk2_3_fayda_pl25.Size = new Size(91, 33);
            risk2_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk2_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk2_3_fayda_pl19.Location = pl19k;
            risk2_3_fayda_pl19.Size = new Size(91, 33);
            risk2_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk2_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk2_3_fayda_pl18.Location = pl18k;
            risk2_3_fayda_pl18.Size = new Size(91, 33);
            risk2_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk2_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk2_3_fayda_pl24.Location = pl24k;
            risk2_3_fayda_pl24.Size = new Size(91, 33);
            risk2_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk2_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk2_3_fayda_pl17.Location = pl17k;
            risk2_3_fayda_pl17.Size = new Size(91, 33);
            risk2_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk2_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk2_3_fayda_pl16.Location = pl16k;
            risk2_3_fayda_pl16.Size = new Size(91, 33);
            risk2_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk2_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5,120);
            risk2_3_fayda_pl15.Location = pl15k;
            risk2_3_fayda_pl15.Size = new Size(168, 33);
            risk2_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk2_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk2_3_fayda_pl14.Location = pl14k;
            risk2_3_fayda_pl14.Size = new Size(168, 33);
            risk2_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk2_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk2_3_fayda_pl13.Location = pl13k;
            risk2_3_fayda_pl13.Size = new Size(168, 33);
            risk2_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk2_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk2_3_fayda_pl12.Location = pl12k;
            risk2_3_fayda_pl12.Size = new Size(168, 33);
            risk2_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl5.Controls.Add(risk2_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk2_3_fayda_pl11.Name = "pl11";
            risk2_3_fayda_pl11.Size = new Size(65, 50);
            risk2_3_fayda_pl11.Dock = DockStyle.Left;
            risk2_3_fayda_pl11.BackColor = Color.Transparent;
            risk2_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk2_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl11.Click += new EventHandler(risk2_3_fayda_pl11_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk2_3_fayda_pl10.Name = "pl10";
            risk2_3_fayda_pl10.Size = new Size(65, 50);
            risk2_3_fayda_pl10.Dock = DockStyle.Right;
            risk2_3_fayda_pl10.BackColor = Color.Transparent;
            risk2_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk2_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl10.Click += new EventHandler(risk2_3_fayda_pl10_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk2_3_fayda_pl9.Name = "pl9";
            risk2_3_fayda_pl9.Size = new Size(65, 50);
            risk2_3_fayda_pl9.Dock = DockStyle.Right;
            risk2_3_fayda_pl9.BackColor = Color.Transparent;
            risk2_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk2_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl9.Click += new EventHandler(risk2_3_fayda_pl9_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk2_3_fayda_pl8.Name = "pl8";
            risk2_3_fayda_pl8.Size = new Size(65, 50);
            risk2_3_fayda_pl8.Dock = DockStyle.Right;
            risk2_3_fayda_pl8.BackColor = Color.Transparent;
            risk2_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk2_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl8.Click += new EventHandler(risk2_3_fayda_pl8_Click);
            risk2_3_fayda_pl7.Controls.Add(risk2_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk2_3_fayda_pl6.Name = "pl6";
            risk2_3_fayda_pl6.Size = new Size(65, 50);
            risk2_3_fayda_pl6.Dock = DockStyle.Right;
            risk2_3_fayda_pl6.BackColor = Color.Transparent;
            risk2_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk2_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl6.Click += new EventHandler(risk2_3_fayda_pl6_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk2_3_fayda_btn3.Name = "btn3";
            risk2_3_fayda_btn3.Size = new Size(65, 50);
            risk2_3_fayda_btn3.Dock = DockStyle.Right;
            risk2_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk2_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_btn3.BackColor = Color.Transparent;
            risk2_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk2_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_btn3.Click += new EventHandler(risk2_3_fayda_btn3_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk2_3_fayda_btn2.Name = "btn2";
            risk2_3_fayda_btn2.Size = new Size(65, 50);
            risk2_3_fayda_btn2.Dock = DockStyle.Right;
            risk2_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk2_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk2_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk2_3_fayda_btn2.BackColor = Color.Transparent;
            risk2_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk2_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_btn2.Click += new EventHandler(risk2_3_fayda_btn2_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk2_3_fayda_btn1.Name = "btn1";
            risk2_3_fayda_btn1.Size = new Size(65, 50);
            risk2_3_fayda_btn1.Dock = DockStyle.Right;
            risk2_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk2_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk2_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk2_3_fayda_btn1.BackColor = Color.Transparent;
            risk2_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk2_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_btn1.Click += new EventHandler(risk2_3_fayda_btn1_Click);
            risk2_3_fayda_pl2.Controls.Add(risk2_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk2_3_fayda_dr1.Name = "dr1";
            risk2_3_fayda_dr1.Size = new Size(851, 498);
            risk2_3_fayda_dr1.Dock = DockStyle.Fill;
            risk2_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_dr1.AllowUserToAddRows = false;
            risk2_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk2_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk2_3_fayda_dr1.AllowUserToResizeRows = false;
            risk2_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk2_3_fayda_dr1.RowHeadersVisible = false;
            risk2_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk2_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk2_3_fayda_dr1_CellEnter);
            risk2_3_fayda_tb1_2.Controls.Add(risk2_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk2_3_fayda_pl7.Name = "pl7";
            risk2_3_fayda_pl7.Size = new Size(865, 50);
            risk2_3_fayda_pl7.Dock = DockStyle.Top;
            risk2_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_tb1_2.Controls.Add(risk2_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk2_3_fayda_pl5.Name = "pl5";
            risk2_3_fayda_pl5.Size = new Size(851, 498);
            risk2_3_fayda_pl5.Dock = DockStyle.Fill;
            risk2_3_fayda_pl5.AutoScroll = true;
            risk2_3_fayda_pl5.AutoSize = true;
            risk2_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk2_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_tb1_1.Controls.Add(risk2_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk2_3_fayda_rt1.Name = "rt1";
            risk2_3_fayda_rt1.Size = new Size(851, 498);
            risk2_3_fayda_rt1.Dock = DockStyle.Fill;
            risk2_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_rt1.Enabled = false;
            risk2_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk2_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk2_3_fayda_tb1_3.Controls.Add(risk2_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk2_3_fayda_tb1_1.Name = "tb1_1";
            risk2_3_fayda_tb1_1.Text = "Tablo";
            risk2_3_fayda_tb1_1.Size = new Size(651, 50);
            risk2_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_tb1.Controls.Add(risk2_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk2_3_fayda_tb1_2.Name = "tb1_2";
            risk2_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk2_3_fayda_tb1_2.Size = new Size(651, 50);
            risk2_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_tb1.Controls.Add(risk2_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk2_3_fayda_tb1_3.Name = "tb1_3";
            risk2_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk2_3_fayda_tb1_3.Size = new Size(651, 50);
            risk2_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_tb1.Controls.Add(risk2_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk2_3_fayda_tb1.Name = "tb1";
            risk2_3_fayda_tb1.Size = new Size(651, 50);
            risk2_3_fayda_tb1.Dock = DockStyle.Fill;
            risk2_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk2_3_fayda_pl3.Controls.Add(risk2_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk2_3_fayda_pl4.Name = "pl4";
            risk2_3_fayda_pl4.Size = new Size(865, 50);
            risk2_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk2_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl4.MouseUp += new MouseEventHandler(risk2_3_fayda_pl4_MouseUp);
            risk2_3_fayda_pl4.MouseMove += new MouseEventHandler(risk2_3_fayda_pl4_MouseMove);
            risk2_3_fayda_pl4.MouseDown += new MouseEventHandler(risk2_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk2_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk2_3_fayda_pl3.Name = "pl3";
            risk2_3_fayda_pl3.Size = new Size(865, 530);
            risk2_3_fayda_pl3.Dock = DockStyle.Top;
            risk2_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk2_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk2_3_fayda_pl2.Name = "pl2";
            risk2_3_fayda_pl2.Size = new Size(865, 50);
            risk2_3_fayda_pl2.Dock = DockStyle.Top;
            risk2_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk2_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk2_3_fayda_pl1.Name = "pl1";
            risk2_3_fayda_pl1.Size = new Size(865, 50);
            risk2_3_fayda_pl1.Dock = DockStyle.Top;
            risk2_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk2_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk2_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk2_3_fayda_pl1.MouseUp += new MouseEventHandler(risk2_3_fayda_pl1_MouseUp);
            risk2_3_fayda_pl1.MouseMove += new MouseEventHandler(risk2_3_fayda_pl1_MouseMove);
            risk2_3_fayda_pl1.MouseDown += new MouseEventHandler(risk2_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk2_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk3_3_fayda form nesne tasarımları
        public void risk3_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk3_3_fayda_sonuc = new Label();
            risk3_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk3_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk3_3_fayda_sonuc.Location = sonuc;
            risk3_3_fayda_sonuc.Text = "";
            risk3_3_fayda_sonuc.Size = new Size(650, 13);
            risk3_3_fayda_pl4.Controls.Add(risk3_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk3_3_fayda_sonucbaslik = new Label();
            risk3_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk3_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk3_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk3_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk3_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk3_3_fayda_pl4.Controls.Add(risk3_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk3_3_fayda_sonuclarortabaslik = new Label();
            risk3_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk3_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk3_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk3_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk3_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk3_3_fayda_pl28.Controls.Add(risk3_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri9 = new NumericUpDown();
            risk3_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            risk3_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri9.Location = txt_veri9;
            risk3_3_fayda_txt_veri9.Size = new Size(85, 20);
            risk3_3_fayda_pl34.Controls.Add(risk3_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri8 = new NumericUpDown();
            risk3_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            risk3_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri8.Location = txt_veri8;
            risk3_3_fayda_txt_veri8.Size = new Size(85, 20);
            risk3_3_fayda_pl33.Controls.Add(risk3_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri7 = new NumericUpDown();
            risk3_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            risk3_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri7.Location = txt_veri7;
            risk3_3_fayda_txt_veri7.Size = new Size(85, 20);
            risk3_3_fayda_pl32.Controls.Add(risk3_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri6 = new NumericUpDown();
            risk3_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk3_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri6.Location = txt_veri6;
            risk3_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk3_3_fayda_pl27.Controls.Add(risk3_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri5 = new NumericUpDown();
            risk3_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk3_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri5.Location = txt_veri5;
            risk3_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk3_3_fayda_pl23.Controls.Add(risk3_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri4 = new NumericUpDown();
            risk3_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk3_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri4.Location = txt_veri4;
            risk3_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk3_3_fayda_pl22.Controls.Add(risk3_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri3 = new NumericUpDown();
            risk3_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk3_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri3.Location = txt_veri3;
            risk3_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk3_3_fayda_pl26.Controls.Add(risk3_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri2 = new NumericUpDown();
            risk3_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk3_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri2.Location = txt_veri2;
            risk3_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk3_3_fayda_pl21.Controls.Add(risk3_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk3_3_fayda_txt_veri1 = new NumericUpDown();
            risk3_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk3_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk3_3_fayda_txt_veri1.Location = txt_veri1;
            risk3_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk3_3_fayda_pl20.Controls.Add(risk3_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            risk3_3_fayda_txt_f3sonuc = new TextBox();
            risk3_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            risk3_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            risk3_3_fayda_txt_f3sonuc.Text = "0";
            risk3_3_fayda_txt_f3sonuc.Enabled = false;
            risk3_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            risk3_3_fayda_pl35.Controls.Add(risk3_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk3_3_fayda_txt_f2sonuc = new TextBox();
            risk3_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk3_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk3_3_fayda_txt_f2sonuc.Text = "0";
            risk3_3_fayda_txt_f2sonuc.Enabled = false;
            risk3_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk3_3_fayda_pl30.Controls.Add(risk3_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk3_3_fayda_txt_f1sonuc = new TextBox();
            risk3_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk3_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk3_3_fayda_txt_f1sonuc.Text = "0";
            risk3_3_fayda_txt_f1sonuc.Enabled = false;
            risk3_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk3_3_fayda_pl29.Controls.Add(risk3_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk3_3_fayda_txt_oran3 = new TextBox();
            risk3_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk3_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk3_3_fayda_txt_oran3.Text = "0,30";
            risk3_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_oran3.MaxLength = 30;
            risk3_3_fayda_txt_oran3.Multiline = true;
            risk3_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk3_3_fayda_pl25.Controls.Add(risk3_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk3_3_fayda_txt_oran2 = new TextBox();
            risk3_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk3_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk3_3_fayda_txt_oran2.Text = "0,20";
            risk3_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_oran2.MaxLength = 30;
            risk3_3_fayda_txt_oran2.Multiline = true;
            risk3_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk3_3_fayda_pl19.Controls.Add(risk3_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk3_3_fayda_txt_oran1 = new TextBox();
            risk3_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk3_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk3_3_fayda_txt_oran1.Text = "0,50";
            risk3_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_oran1.MaxLength = 30;
            risk3_3_fayda_txt_oran1.Multiline = true;
            risk3_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk3_3_fayda_pl18.Controls.Add(risk3_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk3_3_fayda_txt_üstbaslik3 = new TextBox();
            risk3_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk3_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk3_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk3_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk3_3_fayda_txt_üstbaslik3.Multiline = true;
            risk3_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk3_3_fayda_pl24.Controls.Add(risk3_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk3_3_fayda_txt_üstbaslik2 = new TextBox();
            risk3_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk3_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk3_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk3_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk3_3_fayda_txt_üstbaslik2.Multiline = true;
            risk3_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk3_3_fayda_pl17.Controls.Add(risk3_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk3_3_fayda_txt_üstbaslik1 = new TextBox();
            risk3_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk3_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk3_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk3_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk3_3_fayda_txt_üstbaslik1.Multiline = true;
            risk3_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk3_3_fayda_pl16.Controls.Add(risk3_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            risk3_3_fayda_txt_altbaslik3 = new TextBox();
            risk3_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            risk3_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            risk3_3_fayda_txt_altbaslik3.Text = "F3";
            risk3_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_altbaslik3.MaxLength = 30;
            risk3_3_fayda_txt_altbaslik3.Multiline = true;
            risk3_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            risk3_3_fayda_pl31.Controls.Add(risk3_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk3_3_fayda_txt_altbaslik2 = new TextBox();
            risk3_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk3_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk3_3_fayda_txt_altbaslik2.Text = "F2";
            risk3_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk3_3_fayda_txt_altbaslik2.Multiline = true;
            risk3_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk3_3_fayda_pl15.Controls.Add(risk3_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk3_3_fayda_txt_altbaslik1 = new TextBox();
            risk3_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk3_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk3_3_fayda_txt_altbaslik1.Text = "F1";
            risk3_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk3_3_fayda_txt_altbaslik1.Multiline = true;
            risk3_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk3_3_fayda_pl14.Controls.Add(risk3_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk3_3_fayda_txt_baslik2 = new TextBox();
            risk3_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk3_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk3_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk3_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_baslik2.MaxLength = 30;
            risk3_3_fayda_txt_baslik2.Multiline = true;
            risk3_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk3_3_fayda_pl13.Controls.Add(risk3_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk3_3_fayda_txt_baslik1 = new TextBox();
            risk3_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk3_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk3_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk3_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk3_3_fayda_txt_baslik1.MaxLength = 30;
            risk3_3_fayda_txt_baslik1.Multiline = true;
            risk3_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk3_3_fayda_pl12.Controls.Add(risk3_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            risk3_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            risk3_3_fayda_pl35.Location = pl35k;
            risk3_3_fayda_pl35.Size = new Size(91, 33);
            risk3_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk3_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk3_3_fayda_pl30.Location = pl30k;
            risk3_3_fayda_pl30.Size = new Size(91, 33);
            risk3_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk3_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk3_3_fayda_pl29.Location = pl29k;
            risk3_3_fayda_pl29.Size = new Size(91, 33);
            risk3_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk3_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk3_3_fayda_pl28.Location = pl28k;
            risk3_3_fayda_pl28.Size = new Size(91, 72);
            risk3_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            risk3_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            risk3_3_fayda_pl34.Location = pl34k;
            risk3_3_fayda_pl34.Size = new Size(91, 33);
            risk3_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            risk3_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            risk3_3_fayda_pl33.Location = pl33k;
            risk3_3_fayda_pl33.Size = new Size(91, 33);
            risk3_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            risk3_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            risk3_3_fayda_pl32.Location = pl32k;
            risk3_3_fayda_pl32.Size = new Size(91, 33);
            risk3_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk3_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk3_3_fayda_pl27.Location = pl27k;
            risk3_3_fayda_pl27.Size = new Size(91, 33);
            risk3_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk3_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk3_3_fayda_pl26.Location = pl26k;
            risk3_3_fayda_pl26.Size = new Size(91, 33);
            risk3_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk3_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk3_3_fayda_pl23.Location = pl23k;
            risk3_3_fayda_pl23.Size = new Size(91, 33);
            risk3_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk3_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk3_3_fayda_pl22.Location = pl22k;
            risk3_3_fayda_pl22.Size = new Size(91, 33);
            risk3_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk3_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk3_3_fayda_pl21.Location = pl21k;
            risk3_3_fayda_pl21.Size = new Size(91, 33);
            risk3_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk3_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk3_3_fayda_pl20.Location = pl20k;
            risk3_3_fayda_pl20.Size = new Size(91, 33);
            risk3_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk3_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk3_3_fayda_pl25.Location = pl25k;
            risk3_3_fayda_pl25.Size = new Size(91, 33);
            risk3_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk3_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk3_3_fayda_pl19.Location = pl19k;
            risk3_3_fayda_pl19.Size = new Size(91, 33);
            risk3_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk3_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk3_3_fayda_pl18.Location = pl18k;
            risk3_3_fayda_pl18.Size = new Size(91, 33);
            risk3_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk3_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk3_3_fayda_pl24.Location = pl24k;
            risk3_3_fayda_pl24.Size = new Size(91, 33);
            risk3_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk3_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk3_3_fayda_pl17.Location = pl17k;
            risk3_3_fayda_pl17.Size = new Size(91, 33);
            risk3_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk3_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk3_3_fayda_pl16.Location = pl16k;
            risk3_3_fayda_pl16.Size = new Size(91, 33);
            risk3_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            risk3_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            risk3_3_fayda_pl31.Location = pl31k;
            risk3_3_fayda_pl31.Size = new Size(168, 33);
            risk3_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk3_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            risk3_3_fayda_pl15.Location = pl15k;
            risk3_3_fayda_pl15.Size = new Size(168, 33);
            risk3_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk3_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk3_3_fayda_pl14.Location = pl14k;
            risk3_3_fayda_pl14.Size = new Size(168, 33);
            risk3_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk3_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk3_3_fayda_pl13.Location = pl13k;
            risk3_3_fayda_pl13.Size = new Size(168, 33);
            risk3_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk3_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk3_3_fayda_pl12.Location = pl12k;
            risk3_3_fayda_pl12.Size = new Size(168, 33);
            risk3_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl5.Controls.Add(risk3_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk3_3_fayda_pl11.Name = "pl11";
            risk3_3_fayda_pl11.Size = new Size(65, 50);
            risk3_3_fayda_pl11.Dock = DockStyle.Left;
            risk3_3_fayda_pl11.BackColor = Color.Transparent;
            risk3_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk3_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl11.Click += new EventHandler(risk3_3_fayda_pl11_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk3_3_fayda_pl10.Name = "pl10";
            risk3_3_fayda_pl10.Size = new Size(65, 50);
            risk3_3_fayda_pl10.Dock = DockStyle.Right;
            risk3_3_fayda_pl10.BackColor = Color.Transparent;
            risk3_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk3_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl10.Click += new EventHandler(risk3_3_fayda_pl10_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk3_3_fayda_pl9.Name = "pl9";
            risk3_3_fayda_pl9.Size = new Size(65, 50);
            risk3_3_fayda_pl9.Dock = DockStyle.Right;
            risk3_3_fayda_pl9.BackColor = Color.Transparent;
            risk3_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk3_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl9.Click += new EventHandler(risk3_3_fayda_pl9_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk3_3_fayda_pl8.Name = "pl8";
            risk3_3_fayda_pl8.Size = new Size(65, 50);
            risk3_3_fayda_pl8.Dock = DockStyle.Right;
            risk3_3_fayda_pl8.BackColor = Color.Transparent;
            risk3_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk3_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl8.Click += new EventHandler(risk3_3_fayda_pl8_Click);
            risk3_3_fayda_pl7.Controls.Add(risk3_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk3_3_fayda_pl6.Name = "pl6";
            risk3_3_fayda_pl6.Size = new Size(65, 50);
            risk3_3_fayda_pl6.Dock = DockStyle.Right;
            risk3_3_fayda_pl6.BackColor = Color.Transparent;
            risk3_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk3_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl6.Click += new EventHandler(risk3_3_fayda_pl6_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk3_3_fayda_btn3.Name = "btn3";
            risk3_3_fayda_btn3.Size = new Size(65, 50);
            risk3_3_fayda_btn3.Dock = DockStyle.Right;
            risk3_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk3_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_btn3.BackColor = Color.Transparent;
            risk3_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk3_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_btn3.Click += new EventHandler(risk3_3_fayda_btn3_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk3_3_fayda_btn2.Name = "btn2";
            risk3_3_fayda_btn2.Size = new Size(65, 50);
            risk3_3_fayda_btn2.Dock = DockStyle.Right;
            risk3_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk3_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk3_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk3_3_fayda_btn2.BackColor = Color.Transparent;
            risk3_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk3_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_btn2.Click += new EventHandler(risk3_3_fayda_btn2_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk3_3_fayda_btn1.Name = "btn1";
            risk3_3_fayda_btn1.Size = new Size(65, 50);
            risk3_3_fayda_btn1.Dock = DockStyle.Right;
            risk3_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk3_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk3_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk3_3_fayda_btn1.BackColor = Color.Transparent;
            risk3_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk3_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_btn1.Click += new EventHandler(risk3_3_fayda_btn1_Click);
            risk3_3_fayda_pl2.Controls.Add(risk3_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk3_3_fayda_dr1.Name = "dr1";
            risk3_3_fayda_dr1.Size = new Size(851, 498);
            risk3_3_fayda_dr1.Dock = DockStyle.Fill;
            risk3_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_dr1.AllowUserToAddRows = false;
            risk3_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk3_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk3_3_fayda_dr1.AllowUserToResizeRows = false;
            risk3_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk3_3_fayda_dr1.RowHeadersVisible = false;
            risk3_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk3_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk3_3_fayda_dr1_CellEnter);
            risk3_3_fayda_tb1_2.Controls.Add(risk3_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk3_3_fayda_pl7.Name = "pl7";
            risk3_3_fayda_pl7.Size = new Size(865, 50);
            risk3_3_fayda_pl7.Dock = DockStyle.Top;
            risk3_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_tb1_2.Controls.Add(risk3_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk3_3_fayda_pl5.Name = "pl5";
            risk3_3_fayda_pl5.Size = new Size(851, 498);
            risk3_3_fayda_pl5.Dock = DockStyle.Fill;
            risk3_3_fayda_pl5.AutoScroll = true;
            risk3_3_fayda_pl5.AutoSize = true;
            risk3_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk3_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_tb1_1.Controls.Add(risk3_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk3_3_fayda_rt1.Name = "rt1";
            risk3_3_fayda_rt1.Size = new Size(851, 498);
            risk3_3_fayda_rt1.Dock = DockStyle.Fill;
            risk3_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_rt1.Enabled = false;
            risk3_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk3_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk3_3_fayda_tb1_3.Controls.Add(risk3_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk3_3_fayda_tb1_1.Name = "tb1_1";
            risk3_3_fayda_tb1_1.Text = "Tablo";
            risk3_3_fayda_tb1_1.Size = new Size(651, 50);
            risk3_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_tb1.Controls.Add(risk3_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk3_3_fayda_tb1_2.Name = "tb1_2";
            risk3_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk3_3_fayda_tb1_2.Size = new Size(651, 50);
            risk3_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_tb1.Controls.Add(risk3_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk3_3_fayda_tb1_3.Name = "tb1_3";
            risk3_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk3_3_fayda_tb1_3.Size = new Size(651, 50);
            risk3_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_tb1.Controls.Add(risk3_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk3_3_fayda_tb1.Name = "tb1";
            risk3_3_fayda_tb1.Size = new Size(651, 50);
            risk3_3_fayda_tb1.Dock = DockStyle.Fill;
            risk3_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk3_3_fayda_pl3.Controls.Add(risk3_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk3_3_fayda_pl4.Name = "pl4";
            risk3_3_fayda_pl4.Size = new Size(865, 50);
            risk3_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk3_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl4.MouseUp += new MouseEventHandler(risk3_3_fayda_pl4_MouseUp);
            risk3_3_fayda_pl4.MouseMove += new MouseEventHandler(risk3_3_fayda_pl4_MouseMove);
            risk3_3_fayda_pl4.MouseDown += new MouseEventHandler(risk3_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk3_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk3_3_fayda_pl3.Name = "pl3";
            risk3_3_fayda_pl3.Size = new Size(865, 530);
            risk3_3_fayda_pl3.Dock = DockStyle.Top;
            risk3_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk3_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk3_3_fayda_pl2.Name = "pl2";
            risk3_3_fayda_pl2.Size = new Size(865, 50);
            risk3_3_fayda_pl2.Dock = DockStyle.Top;
            risk3_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk3_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk3_3_fayda_pl1.Name = "pl1";
            risk3_3_fayda_pl1.Size = new Size(865, 50);
            risk3_3_fayda_pl1.Dock = DockStyle.Top;
            risk3_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk3_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk3_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk3_3_fayda_pl1.MouseUp += new MouseEventHandler(risk3_3_fayda_pl1_MouseUp);
            risk3_3_fayda_pl1.MouseMove += new MouseEventHandler(risk3_3_fayda_pl1_MouseMove);
            risk3_3_fayda_pl1.MouseDown += new MouseEventHandler(risk3_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk3_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk4_3_fayda form nesne tasarımları
        public void risk4_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk4_3_fayda_sonuc = new Label();
            risk4_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk4_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk4_3_fayda_sonuc.Location = sonuc;
            risk4_3_fayda_sonuc.Text = "";
            risk4_3_fayda_sonuc.Size = new Size(650, 13);
            risk4_3_fayda_pl4.Controls.Add(risk4_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk4_3_fayda_sonucbaslik = new Label();
            risk4_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk4_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk4_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk4_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk4_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk4_3_fayda_pl4.Controls.Add(risk4_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk4_3_fayda_sonuclarortabaslik = new Label();
            risk4_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk4_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk4_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk4_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk4_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk4_3_fayda_pl28.Controls.Add(risk4_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri12 = new NumericUpDown();
            risk4_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            risk4_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri12.Location = txt_veri12;
            risk4_3_fayda_txt_veri12.Size = new Size(85, 20);
            risk4_3_fayda_pl39.Controls.Add(risk4_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri11 = new NumericUpDown();
            risk4_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            risk4_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri11.Location = txt_veri11;
            risk4_3_fayda_txt_veri11.Size = new Size(85, 20);
            risk4_3_fayda_pl38.Controls.Add(risk4_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri10 = new NumericUpDown();
            risk4_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            risk4_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri10.Location = txt_veri10;
            risk4_3_fayda_txt_veri10.Size = new Size(85, 20);
            risk4_3_fayda_pl37.Controls.Add(risk4_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri9 = new NumericUpDown();
            risk4_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            risk4_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri9.Location = txt_veri9;
            risk4_3_fayda_txt_veri9.Size = new Size(85, 20);
            risk4_3_fayda_pl34.Controls.Add(risk4_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri8 = new NumericUpDown();
            risk4_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            risk4_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri8.Location = txt_veri8;
            risk4_3_fayda_txt_veri8.Size = new Size(85, 20);
            risk4_3_fayda_pl33.Controls.Add(risk4_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri7 = new NumericUpDown();
            risk4_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            risk4_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri7.Location = txt_veri7;
            risk4_3_fayda_txt_veri7.Size = new Size(85, 20);
            risk4_3_fayda_pl32.Controls.Add(risk4_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri6 = new NumericUpDown();
            risk4_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk4_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri6.Location = txt_veri6;
            risk4_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk4_3_fayda_pl27.Controls.Add(risk4_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri5 = new NumericUpDown();
            risk4_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk4_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri5.Location = txt_veri5;
            risk4_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk4_3_fayda_pl23.Controls.Add(risk4_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri4 = new NumericUpDown();
            risk4_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk4_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri4.Location = txt_veri4;
            risk4_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk4_3_fayda_pl22.Controls.Add(risk4_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri3 = new NumericUpDown();
            risk4_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk4_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri3.Location = txt_veri3;
            risk4_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk4_3_fayda_pl26.Controls.Add(risk4_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri2 = new NumericUpDown();
            risk4_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk4_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri2.Location = txt_veri2;
            risk4_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk4_3_fayda_pl21.Controls.Add(risk4_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk4_3_fayda_txt_veri1 = new NumericUpDown();
            risk4_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk4_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk4_3_fayda_txt_veri1.Location = txt_veri1;
            risk4_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk4_3_fayda_pl20.Controls.Add(risk4_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            risk4_3_fayda_txt_f4sonuc = new TextBox();
            risk4_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            risk4_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            risk4_3_fayda_txt_f4sonuc.Text = "0";
            risk4_3_fayda_txt_f4sonuc.Enabled = false;
            risk4_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            risk4_3_fayda_pl40.Controls.Add(risk4_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            risk4_3_fayda_txt_f3sonuc = new TextBox();
            risk4_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            risk4_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            risk4_3_fayda_txt_f3sonuc.Text = "0";
            risk4_3_fayda_txt_f3sonuc.Enabled = false;
            risk4_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            risk4_3_fayda_pl35.Controls.Add(risk4_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk4_3_fayda_txt_f2sonuc = new TextBox();
            risk4_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk4_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk4_3_fayda_txt_f2sonuc.Text = "0";
            risk4_3_fayda_txt_f2sonuc.Enabled = false;
            risk4_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk4_3_fayda_pl30.Controls.Add(risk4_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk4_3_fayda_txt_f1sonuc = new TextBox();
            risk4_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk4_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk4_3_fayda_txt_f1sonuc.Text = "0";
            risk4_3_fayda_txt_f1sonuc.Enabled = false;
            risk4_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk4_3_fayda_pl29.Controls.Add(risk4_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk4_3_fayda_txt_oran3 = new TextBox();
            risk4_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk4_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk4_3_fayda_txt_oran3.Text = "0,30";
            risk4_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_oran3.MaxLength = 30;
            risk4_3_fayda_txt_oran3.Multiline = true;
            risk4_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk4_3_fayda_pl25.Controls.Add(risk4_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk4_3_fayda_txt_oran2 = new TextBox();
            risk4_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk4_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk4_3_fayda_txt_oran2.Text = "0,20";
            risk4_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_oran2.MaxLength = 30;
            risk4_3_fayda_txt_oran2.Multiline = true;
            risk4_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk4_3_fayda_pl19.Controls.Add(risk4_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk4_3_fayda_txt_oran1 = new TextBox();
            risk4_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk4_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk4_3_fayda_txt_oran1.Text = "0,50";
            risk4_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_oran1.MaxLength = 30;
            risk4_3_fayda_txt_oran1.Multiline = true;
            risk4_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk4_3_fayda_pl18.Controls.Add(risk4_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk4_3_fayda_txt_üstbaslik3 = new TextBox();
            risk4_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk4_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk4_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk4_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk4_3_fayda_txt_üstbaslik3.Multiline = true;
            risk4_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk4_3_fayda_pl24.Controls.Add(risk4_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk4_3_fayda_txt_üstbaslik2 = new TextBox();
            risk4_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk4_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk4_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk4_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk4_3_fayda_txt_üstbaslik2.Multiline = true;
            risk4_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk4_3_fayda_pl17.Controls.Add(risk4_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk4_3_fayda_txt_üstbaslik1 = new TextBox();
            risk4_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk4_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk4_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk4_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk4_3_fayda_txt_üstbaslik1.Multiline = true;
            risk4_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk4_3_fayda_pl16.Controls.Add(risk4_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            risk4_3_fayda_txt_altbaslik4 = new TextBox();
            risk4_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            risk4_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            risk4_3_fayda_txt_altbaslik4.Text = "F4";
            risk4_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_altbaslik4.MaxLength = 30;
            risk4_3_fayda_txt_altbaslik4.Multiline = true;
            risk4_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            risk4_3_fayda_pl36.Controls.Add(risk4_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            risk4_3_fayda_txt_altbaslik3 = new TextBox();
            risk4_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            risk4_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            risk4_3_fayda_txt_altbaslik3.Text = "F3";
            risk4_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_altbaslik3.MaxLength = 30;
            risk4_3_fayda_txt_altbaslik3.Multiline = true;
            risk4_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            risk4_3_fayda_pl31.Controls.Add(risk4_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk4_3_fayda_txt_altbaslik2 = new TextBox();
            risk4_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk4_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk4_3_fayda_txt_altbaslik2.Text = "F2";
            risk4_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk4_3_fayda_txt_altbaslik2.Multiline = true;
            risk4_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk4_3_fayda_pl15.Controls.Add(risk4_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk4_3_fayda_txt_altbaslik1 = new TextBox();
            risk4_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk4_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk4_3_fayda_txt_altbaslik1.Text = "F1";
            risk4_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk4_3_fayda_txt_altbaslik1.Multiline = true;
            risk4_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk4_3_fayda_pl14.Controls.Add(risk4_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk4_3_fayda_txt_baslik2 = new TextBox();
            risk4_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk4_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk4_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk4_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_baslik2.MaxLength = 30;
            risk4_3_fayda_txt_baslik2.Multiline = true;
            risk4_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk4_3_fayda_pl13.Controls.Add(risk4_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk4_3_fayda_txt_baslik1 = new TextBox();
            risk4_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk4_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk4_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk4_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk4_3_fayda_txt_baslik1.MaxLength = 30;
            risk4_3_fayda_txt_baslik1.Multiline = true;
            risk4_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk4_3_fayda_pl12.Controls.Add(risk4_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            risk4_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            risk4_3_fayda_pl40.Location = pl40k;
            risk4_3_fayda_pl40.Size = new Size(91, 33);
            risk4_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            risk4_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            risk4_3_fayda_pl35.Location = pl35k;
            risk4_3_fayda_pl35.Size = new Size(91, 33);
            risk4_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk4_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk4_3_fayda_pl30.Location = pl30k;
            risk4_3_fayda_pl30.Size = new Size(91, 33);
            risk4_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk4_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk4_3_fayda_pl29.Location = pl29k;
            risk4_3_fayda_pl29.Size = new Size(91, 33);
            risk4_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk4_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk4_3_fayda_pl28.Location = pl28k;
            risk4_3_fayda_pl28.Size = new Size(91, 72);
            risk4_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            risk4_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            risk4_3_fayda_pl39.Location = pl39k;
            risk4_3_fayda_pl39.Size = new Size(91, 33);
            risk4_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            risk4_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            risk4_3_fayda_pl38.Location = pl38k;
            risk4_3_fayda_pl38.Size = new Size(91, 33);
            risk4_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            risk4_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            risk4_3_fayda_pl37.Location = pl37k;
            risk4_3_fayda_pl37.Size = new Size(91, 33);
            risk4_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            risk4_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            risk4_3_fayda_pl34.Location = pl34k;
            risk4_3_fayda_pl34.Size = new Size(91, 33);
            risk4_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            risk4_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            risk4_3_fayda_pl33.Location = pl33k;
            risk4_3_fayda_pl33.Size = new Size(91, 33);
            risk4_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            risk4_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            risk4_3_fayda_pl32.Location = pl32k;
            risk4_3_fayda_pl32.Size = new Size(91, 33);
            risk4_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk4_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk4_3_fayda_pl27.Location = pl27k;
            risk4_3_fayda_pl27.Size = new Size(91, 33);
            risk4_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk4_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk4_3_fayda_pl26.Location = pl26k;
            risk4_3_fayda_pl26.Size = new Size(91, 33);
            risk4_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk4_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk4_3_fayda_pl23.Location = pl23k;
            risk4_3_fayda_pl23.Size = new Size(91, 33);
            risk4_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk4_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk4_3_fayda_pl22.Location = pl22k;
            risk4_3_fayda_pl22.Size = new Size(91, 33);
            risk4_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk4_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk4_3_fayda_pl21.Location = pl21k;
            risk4_3_fayda_pl21.Size = new Size(91, 33);
            risk4_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk4_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk4_3_fayda_pl20.Location = pl20k;
            risk4_3_fayda_pl20.Size = new Size(91, 33);
            risk4_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk4_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk4_3_fayda_pl25.Location = pl25k;
            risk4_3_fayda_pl25.Size = new Size(91, 33);
            risk4_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk4_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk4_3_fayda_pl19.Location = pl19k;
            risk4_3_fayda_pl19.Size = new Size(91, 33);
            risk4_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk4_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk4_3_fayda_pl18.Location = pl18k;
            risk4_3_fayda_pl18.Size = new Size(91, 33);
            risk4_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk4_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk4_3_fayda_pl24.Location = pl24k;
            risk4_3_fayda_pl24.Size = new Size(91, 33);
            risk4_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk4_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk4_3_fayda_pl17.Location = pl17k;
            risk4_3_fayda_pl17.Size = new Size(91, 33);
            risk4_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk4_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk4_3_fayda_pl16.Location = pl16k;
            risk4_3_fayda_pl16.Size = new Size(91, 33);
            risk4_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            risk4_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            risk4_3_fayda_pl36.Location = pl36k;
            risk4_3_fayda_pl36.Size = new Size(168, 33);
            risk4_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            risk4_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            risk4_3_fayda_pl31.Location = pl31k;
            risk4_3_fayda_pl31.Size = new Size(168, 33);
            risk4_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk4_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            risk4_3_fayda_pl15.Location = pl15k;
            risk4_3_fayda_pl15.Size = new Size(168, 33);
            risk4_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk4_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk4_3_fayda_pl14.Location = pl14k;
            risk4_3_fayda_pl14.Size = new Size(168, 33);
            risk4_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk4_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk4_3_fayda_pl13.Location = pl13k;
            risk4_3_fayda_pl13.Size = new Size(168, 33);
            risk4_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk4_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk4_3_fayda_pl12.Location = pl12k;
            risk4_3_fayda_pl12.Size = new Size(168, 33);
            risk4_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl5.Controls.Add(risk4_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk4_3_fayda_pl11.Name = "pl11";
            risk4_3_fayda_pl11.Size = new Size(65, 50);
            risk4_3_fayda_pl11.Dock = DockStyle.Left;
            risk4_3_fayda_pl11.BackColor = Color.Transparent;
            risk4_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk4_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl11.Click += new EventHandler(risk4_3_fayda_pl11_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk4_3_fayda_pl10.Name = "pl10";
            risk4_3_fayda_pl10.Size = new Size(65, 50);
            risk4_3_fayda_pl10.Dock = DockStyle.Right;
            risk4_3_fayda_pl10.BackColor = Color.Transparent;
            risk4_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk4_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl10.Click += new EventHandler(risk4_3_fayda_pl10_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk4_3_fayda_pl9.Name = "pl9";
            risk4_3_fayda_pl9.Size = new Size(65, 50);
            risk4_3_fayda_pl9.Dock = DockStyle.Right;
            risk4_3_fayda_pl9.BackColor = Color.Transparent;
            risk4_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk4_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl9.Click += new EventHandler(risk4_3_fayda_pl9_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk4_3_fayda_pl8.Name = "pl8";
            risk4_3_fayda_pl8.Size = new Size(65, 50);
            risk4_3_fayda_pl8.Dock = DockStyle.Right;
            risk4_3_fayda_pl8.BackColor = Color.Transparent;
            risk4_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk4_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl8.Click += new EventHandler(risk4_3_fayda_pl8_Click);
            risk4_3_fayda_pl7.Controls.Add(risk4_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk4_3_fayda_pl6.Name = "pl6";
            risk4_3_fayda_pl6.Size = new Size(65, 50);
            risk4_3_fayda_pl6.Dock = DockStyle.Right;
            risk4_3_fayda_pl6.BackColor = Color.Transparent;
            risk4_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk4_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl6.Click += new EventHandler(risk4_3_fayda_pl6_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk4_3_fayda_btn3.Name = "btn3";
            risk4_3_fayda_btn3.Size = new Size(65, 50);
            risk4_3_fayda_btn3.Dock = DockStyle.Right;
            risk4_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk4_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_btn3.BackColor = Color.Transparent;
            risk4_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk4_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_btn3.Click += new EventHandler(risk4_3_fayda_btn3_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk4_3_fayda_btn2.Name = "btn2";
            risk4_3_fayda_btn2.Size = new Size(65, 50);
            risk4_3_fayda_btn2.Dock = DockStyle.Right;
            risk4_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk4_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk4_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk4_3_fayda_btn2.BackColor = Color.Transparent;
            risk4_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk4_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_btn2.Click += new EventHandler(risk4_3_fayda_btn2_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk4_3_fayda_btn1.Name = "btn1";
            risk4_3_fayda_btn1.Size = new Size(65, 50);
            risk4_3_fayda_btn1.Dock = DockStyle.Right;
            risk4_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk4_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk4_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk4_3_fayda_btn1.BackColor = Color.Transparent;
            risk4_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk4_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_btn1.Click += new EventHandler(risk4_3_fayda_btn1_Click);
            risk4_3_fayda_pl2.Controls.Add(risk4_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk4_3_fayda_dr1.Name = "dr1";
            risk4_3_fayda_dr1.Size = new Size(851, 498);
            risk4_3_fayda_dr1.Dock = DockStyle.Fill;
            risk4_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_dr1.AllowUserToAddRows = false;
            risk4_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk4_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk4_3_fayda_dr1.AllowUserToResizeRows = false;
            risk4_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk4_3_fayda_dr1.RowHeadersVisible = false;
            risk4_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk4_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk4_3_fayda_dr1_CellEnter);
            risk4_3_fayda_tb1_2.Controls.Add(risk4_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk4_3_fayda_pl7.Name = "pl7";
            risk4_3_fayda_pl7.Size = new Size(865, 50);
            risk4_3_fayda_pl7.Dock = DockStyle.Top;
            risk4_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_tb1_2.Controls.Add(risk4_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk4_3_fayda_pl5.Name = "pl5";
            risk4_3_fayda_pl5.Size = new Size(851, 498);
            risk4_3_fayda_pl5.Dock = DockStyle.Fill;
            risk4_3_fayda_pl5.AutoScroll = true;
            risk4_3_fayda_pl5.AutoSize = true;
            risk4_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk4_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_tb1_1.Controls.Add(risk4_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk4_3_fayda_rt1.Name = "rt1";
            risk4_3_fayda_rt1.Size = new Size(851, 498);
            risk4_3_fayda_rt1.Dock = DockStyle.Fill;
            risk4_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_rt1.Enabled = false;
            risk4_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk4_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk4_3_fayda_tb1_3.Controls.Add(risk4_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk4_3_fayda_tb1_1.Name = "tb1_1";
            risk4_3_fayda_tb1_1.Text = "Tablo";
            risk4_3_fayda_tb1_1.Size = new Size(651, 50);
            risk4_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_tb1.Controls.Add(risk4_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk4_3_fayda_tb1_2.Name = "tb1_2";
            risk4_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk4_3_fayda_tb1_2.Size = new Size(651, 50);
            risk4_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_tb1.Controls.Add(risk4_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk4_3_fayda_tb1_3.Name = "tb1_3";
            risk4_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk4_3_fayda_tb1_3.Size = new Size(651, 50);
            risk4_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_tb1.Controls.Add(risk4_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk4_3_fayda_tb1.Name = "tb1";
            risk4_3_fayda_tb1.Size = new Size(651, 50);
            risk4_3_fayda_tb1.Dock = DockStyle.Fill;
            risk4_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk4_3_fayda_pl3.Controls.Add(risk4_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk4_3_fayda_pl4.Name = "pl4";
            risk4_3_fayda_pl4.Size = new Size(865, 50);
            risk4_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk4_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl4.MouseUp += new MouseEventHandler(risk4_3_fayda_pl4_MouseUp);
            risk4_3_fayda_pl4.MouseMove += new MouseEventHandler(risk4_3_fayda_pl4_MouseMove);
            risk4_3_fayda_pl4.MouseDown += new MouseEventHandler(risk4_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk4_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk4_3_fayda_pl3.Name = "pl3";
            risk4_3_fayda_pl3.Size = new Size(865, 530);
            risk4_3_fayda_pl3.Dock = DockStyle.Top;
            risk4_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk4_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk4_3_fayda_pl2.Name = "pl2";
            risk4_3_fayda_pl2.Size = new Size(865, 50);
            risk4_3_fayda_pl2.Dock = DockStyle.Top;
            risk4_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk4_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk4_3_fayda_pl1.Name = "pl1";
            risk4_3_fayda_pl1.Size = new Size(865, 50);
            risk4_3_fayda_pl1.Dock = DockStyle.Top;
            risk4_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk4_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk4_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk4_3_fayda_pl1.MouseUp += new MouseEventHandler(risk4_3_fayda_pl1_MouseUp);
            risk4_3_fayda_pl1.MouseMove += new MouseEventHandler(risk4_3_fayda_pl1_MouseMove);
            risk4_3_fayda_pl1.MouseDown += new MouseEventHandler(risk4_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk4_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk5_3_fayda form nesne tasarımları
        public void risk5_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk5_3_fayda_sonuc = new Label();
            risk5_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk5_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk5_3_fayda_sonuc.Location = sonuc;
            risk5_3_fayda_sonuc.Text = "";
            risk5_3_fayda_sonuc.Size = new Size(650, 13);
            risk5_3_fayda_pl4.Controls.Add(risk5_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk5_3_fayda_sonucbaslik = new Label();
            risk5_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk5_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk5_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk5_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk5_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk5_3_fayda_pl4.Controls.Add(risk5_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk5_3_fayda_sonuclarortabaslik = new Label();
            risk5_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk5_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk5_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk5_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk5_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk5_3_fayda_pl28.Controls.Add(risk5_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri15 = new NumericUpDown();
            risk5_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            risk5_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri15.Location = txt_veri15;
            risk5_3_fayda_txt_veri15.Size = new Size(85, 20);
            risk5_3_fayda_pl44.Controls.Add(risk5_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri14 = new NumericUpDown();
            risk5_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            risk5_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri14.Location = txt_veri14;
            risk5_3_fayda_txt_veri14.Size = new Size(85, 20);
            risk5_3_fayda_pl43.Controls.Add(risk5_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri13 = new NumericUpDown();
            risk5_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            risk5_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri13.Location = txt_veri13;
            risk5_3_fayda_txt_veri13.Size = new Size(85, 20);
            risk5_3_fayda_pl42.Controls.Add(risk5_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri12 = new NumericUpDown();
            risk5_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            risk5_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri12.Location = txt_veri12;
            risk5_3_fayda_txt_veri12.Size = new Size(85, 20);
            risk5_3_fayda_pl39.Controls.Add(risk5_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri11 = new NumericUpDown();
            risk5_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            risk5_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri11.Location = txt_veri11;
            risk5_3_fayda_txt_veri11.Size = new Size(85, 20);
            risk5_3_fayda_pl38.Controls.Add(risk5_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri10 = new NumericUpDown();
            risk5_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            risk5_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri10.Location = txt_veri10;
            risk5_3_fayda_txt_veri10.Size = new Size(85, 20);
            risk5_3_fayda_pl37.Controls.Add(risk5_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri9 = new NumericUpDown();
            risk5_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            risk5_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri9.Location = txt_veri9;
            risk5_3_fayda_txt_veri9.Size = new Size(85, 20);
            risk5_3_fayda_pl34.Controls.Add(risk5_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri8 = new NumericUpDown();
            risk5_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            risk5_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri8.Location = txt_veri8;
            risk5_3_fayda_txt_veri8.Size = new Size(85, 20);
            risk5_3_fayda_pl33.Controls.Add(risk5_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri7 = new NumericUpDown();
            risk5_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            risk5_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri7.Location = txt_veri7;
            risk5_3_fayda_txt_veri7.Size = new Size(85, 20);
            risk5_3_fayda_pl32.Controls.Add(risk5_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri6 = new NumericUpDown();
            risk5_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk5_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri6.Location = txt_veri6;
            risk5_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk5_3_fayda_pl27.Controls.Add(risk5_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri5 = new NumericUpDown();
            risk5_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk5_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri5.Location = txt_veri5;
            risk5_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk5_3_fayda_pl23.Controls.Add(risk5_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri4 = new NumericUpDown();
            risk5_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk5_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri4.Location = txt_veri4;
            risk5_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk5_3_fayda_pl22.Controls.Add(risk5_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri3 = new NumericUpDown();
            risk5_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk5_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri3.Location = txt_veri3;
            risk5_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk5_3_fayda_pl26.Controls.Add(risk5_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri2 = new NumericUpDown();
            risk5_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk5_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri2.Location = txt_veri2;
            risk5_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk5_3_fayda_pl21.Controls.Add(risk5_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk5_3_fayda_txt_veri1 = new NumericUpDown();
            risk5_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk5_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk5_3_fayda_txt_veri1.Location = txt_veri1;
            risk5_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk5_3_fayda_pl20.Controls.Add(risk5_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            risk5_3_fayda_txt_f5sonuc = new TextBox();
            risk5_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            risk5_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            risk5_3_fayda_txt_f5sonuc.Text = "0";
            risk5_3_fayda_txt_f5sonuc.Enabled = false;
            risk5_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            risk5_3_fayda_pl45.Controls.Add(risk5_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            risk5_3_fayda_txt_f4sonuc = new TextBox();
            risk5_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            risk5_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            risk5_3_fayda_txt_f4sonuc.Text = "0";
            risk5_3_fayda_txt_f4sonuc.Enabled = false;
            risk5_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            risk5_3_fayda_pl40.Controls.Add(risk5_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            risk5_3_fayda_txt_f3sonuc = new TextBox();
            risk5_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            risk5_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            risk5_3_fayda_txt_f3sonuc.Text = "0";
            risk5_3_fayda_txt_f3sonuc.Enabled = false;
            risk5_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            risk5_3_fayda_pl35.Controls.Add(risk5_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk5_3_fayda_txt_f2sonuc = new TextBox();
            risk5_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk5_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk5_3_fayda_txt_f2sonuc.Text = "0";
            risk5_3_fayda_txt_f2sonuc.Enabled = false;
            risk5_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk5_3_fayda_pl30.Controls.Add(risk5_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk5_3_fayda_txt_f1sonuc = new TextBox();
            risk5_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk5_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk5_3_fayda_txt_f1sonuc.Text = "0";
            risk5_3_fayda_txt_f1sonuc.Enabled = false;
            risk5_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk5_3_fayda_pl29.Controls.Add(risk5_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk5_3_fayda_txt_oran3 = new TextBox();
            risk5_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk5_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk5_3_fayda_txt_oran3.Text = "0,30";
            risk5_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_oran3.MaxLength = 30;
            risk5_3_fayda_txt_oran3.Multiline = true;
            risk5_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk5_3_fayda_pl25.Controls.Add(risk5_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk5_3_fayda_txt_oran2 = new TextBox();
            risk5_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk5_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk5_3_fayda_txt_oran2.Text = "0,20";
            risk5_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_oran2.MaxLength = 30;
            risk5_3_fayda_txt_oran2.Multiline = true;
            risk5_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk5_3_fayda_pl19.Controls.Add(risk5_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk5_3_fayda_txt_oran1 = new TextBox();
            risk5_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk5_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk5_3_fayda_txt_oran1.Text = "0,50";
            risk5_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_oran1.MaxLength = 30;
            risk5_3_fayda_txt_oran1.Multiline = true;
            risk5_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk5_3_fayda_pl18.Controls.Add(risk5_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk5_3_fayda_txt_üstbaslik3 = new TextBox();
            risk5_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk5_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk5_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk5_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk5_3_fayda_txt_üstbaslik3.Multiline = true;
            risk5_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk5_3_fayda_pl24.Controls.Add(risk5_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk5_3_fayda_txt_üstbaslik2 = new TextBox();
            risk5_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk5_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk5_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk5_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk5_3_fayda_txt_üstbaslik2.Multiline = true;
            risk5_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk5_3_fayda_pl17.Controls.Add(risk5_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk5_3_fayda_txt_üstbaslik1 = new TextBox();
            risk5_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk5_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk5_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk5_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk5_3_fayda_txt_üstbaslik1.Multiline = true;
            risk5_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk5_3_fayda_pl16.Controls.Add(risk5_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            risk5_3_fayda_txt_altbaslik5 = new TextBox();
            risk5_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            risk5_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            risk5_3_fayda_txt_altbaslik5.Text = "F5";
            risk5_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_altbaslik5.MaxLength = 30;
            risk5_3_fayda_txt_altbaslik5.Multiline = true;
            risk5_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            risk5_3_fayda_pl41.Controls.Add(risk5_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            risk5_3_fayda_txt_altbaslik4 = new TextBox();
            risk5_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            risk5_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            risk5_3_fayda_txt_altbaslik4.Text = "F4";
            risk5_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_altbaslik4.MaxLength = 30;
            risk5_3_fayda_txt_altbaslik4.Multiline = true;
            risk5_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            risk5_3_fayda_pl36.Controls.Add(risk5_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            risk5_3_fayda_txt_altbaslik3 = new TextBox();
            risk5_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            risk5_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            risk5_3_fayda_txt_altbaslik3.Text = "F3";
            risk5_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_altbaslik3.MaxLength = 30;
            risk5_3_fayda_txt_altbaslik3.Multiline = true;
            risk5_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            risk5_3_fayda_pl31.Controls.Add(risk5_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk5_3_fayda_txt_altbaslik2 = new TextBox();
            risk5_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk5_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk5_3_fayda_txt_altbaslik2.Text = "F2";
            risk5_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk5_3_fayda_txt_altbaslik2.Multiline = true;
            risk5_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk5_3_fayda_pl15.Controls.Add(risk5_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk5_3_fayda_txt_altbaslik1 = new TextBox();
            risk5_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk5_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk5_3_fayda_txt_altbaslik1.Text = "F1";
            risk5_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk5_3_fayda_txt_altbaslik1.Multiline = true;
            risk5_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk5_3_fayda_pl14.Controls.Add(risk5_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk5_3_fayda_txt_baslik2 = new TextBox();
            risk5_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk5_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk5_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk5_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_baslik2.MaxLength = 30;
            risk5_3_fayda_txt_baslik2.Multiline = true;
            risk5_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk5_3_fayda_pl13.Controls.Add(risk5_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk5_3_fayda_txt_baslik1 = new TextBox();
            risk5_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk5_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk5_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk5_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk5_3_fayda_txt_baslik1.MaxLength = 30;
            risk5_3_fayda_txt_baslik1.Multiline = true;
            risk5_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk5_3_fayda_pl12.Controls.Add(risk5_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            risk5_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            risk5_3_fayda_pl45.Location = pl45k;
            risk5_3_fayda_pl45.Size = new Size(91, 33);
            risk5_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            risk5_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            risk5_3_fayda_pl40.Location = pl40k;
            risk5_3_fayda_pl40.Size = new Size(91, 33);
            risk5_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            risk5_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            risk5_3_fayda_pl35.Location = pl35k;
            risk5_3_fayda_pl35.Size = new Size(91, 33);
            risk5_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk5_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk5_3_fayda_pl30.Location = pl30k;
            risk5_3_fayda_pl30.Size = new Size(91, 33);
            risk5_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk5_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk5_3_fayda_pl29.Location = pl29k;
            risk5_3_fayda_pl29.Size = new Size(91, 33);
            risk5_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk5_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk5_3_fayda_pl28.Location = pl28k;
            risk5_3_fayda_pl28.Size = new Size(91, 72);
            risk5_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            risk5_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            risk5_3_fayda_pl44.Location = pl44k;
            risk5_3_fayda_pl44.Size = new Size(91, 33);
            risk5_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            risk5_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            risk5_3_fayda_pl43.Location = pl43k;
            risk5_3_fayda_pl43.Size = new Size(91, 33);
            risk5_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            risk5_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            risk5_3_fayda_pl42.Location = pl42k;
            risk5_3_fayda_pl42.Size = new Size(91, 33);
            risk5_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            risk5_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            risk5_3_fayda_pl39.Location = pl39k;
            risk5_3_fayda_pl39.Size = new Size(91, 33);
            risk5_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            risk5_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            risk5_3_fayda_pl38.Location = pl38k;
            risk5_3_fayda_pl38.Size = new Size(91, 33);
            risk5_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            risk5_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            risk5_3_fayda_pl37.Location = pl37k;
            risk5_3_fayda_pl37.Size = new Size(91, 33);
            risk5_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            risk5_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            risk5_3_fayda_pl34.Location = pl34k;
            risk5_3_fayda_pl34.Size = new Size(91, 33);
            risk5_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            risk5_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            risk5_3_fayda_pl33.Location = pl33k;
            risk5_3_fayda_pl33.Size = new Size(91, 33);
            risk5_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            risk5_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            risk5_3_fayda_pl32.Location = pl32k;
            risk5_3_fayda_pl32.Size = new Size(91, 33);
            risk5_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk5_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk5_3_fayda_pl27.Location = pl27k;
            risk5_3_fayda_pl27.Size = new Size(91, 33);
            risk5_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk5_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk5_3_fayda_pl26.Location = pl26k;
            risk5_3_fayda_pl26.Size = new Size(91, 33);
            risk5_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk5_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk5_3_fayda_pl23.Location = pl23k;
            risk5_3_fayda_pl23.Size = new Size(91, 33);
            risk5_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk5_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk5_3_fayda_pl22.Location = pl22k;
            risk5_3_fayda_pl22.Size = new Size(91, 33);
            risk5_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk5_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk5_3_fayda_pl21.Location = pl21k;
            risk5_3_fayda_pl21.Size = new Size(91, 33);
            risk5_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk5_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk5_3_fayda_pl20.Location = pl20k;
            risk5_3_fayda_pl20.Size = new Size(91, 33);
            risk5_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk5_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk5_3_fayda_pl25.Location = pl25k;
            risk5_3_fayda_pl25.Size = new Size(91, 33);
            risk5_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk5_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk5_3_fayda_pl19.Location = pl19k;
            risk5_3_fayda_pl19.Size = new Size(91, 33);
            risk5_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk5_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk5_3_fayda_pl18.Location = pl18k;
            risk5_3_fayda_pl18.Size = new Size(91, 33);
            risk5_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk5_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk5_3_fayda_pl24.Location = pl24k;
            risk5_3_fayda_pl24.Size = new Size(91, 33);
            risk5_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk5_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk5_3_fayda_pl17.Location = pl17k;
            risk5_3_fayda_pl17.Size = new Size(91, 33);
            risk5_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk5_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk5_3_fayda_pl16.Location = pl16k;
            risk5_3_fayda_pl16.Size = new Size(91, 33);
            risk5_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            risk5_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            risk5_3_fayda_pl41.Location = pl41k;
            risk5_3_fayda_pl41.Size = new Size(168, 33);
            risk5_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            risk5_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            risk5_3_fayda_pl36.Location = pl36k;
            risk5_3_fayda_pl36.Size = new Size(168, 33);
            risk5_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            risk5_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            risk5_3_fayda_pl31.Location = pl31k;
            risk5_3_fayda_pl31.Size = new Size(168, 33);
            risk5_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk5_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            risk5_3_fayda_pl15.Location = pl15k;
            risk5_3_fayda_pl15.Size = new Size(168, 33);
            risk5_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk5_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk5_3_fayda_pl14.Location = pl14k;
            risk5_3_fayda_pl14.Size = new Size(168, 33);
            risk5_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk5_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk5_3_fayda_pl13.Location = pl13k;
            risk5_3_fayda_pl13.Size = new Size(168, 33);
            risk5_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk5_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk5_3_fayda_pl12.Location = pl12k;
            risk5_3_fayda_pl12.Size = new Size(168, 33);
            risk5_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl5.Controls.Add(risk5_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk5_3_fayda_pl11.Name = "pl11";
            risk5_3_fayda_pl11.Size = new Size(65, 50);
            risk5_3_fayda_pl11.Dock = DockStyle.Left;
            risk5_3_fayda_pl11.BackColor = Color.Transparent;
            risk5_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk5_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl11.Click += new EventHandler(risk5_3_fayda_pl11_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk5_3_fayda_pl10.Name = "pl10";
            risk5_3_fayda_pl10.Size = new Size(65, 50);
            risk5_3_fayda_pl10.Dock = DockStyle.Right;
            risk5_3_fayda_pl10.BackColor = Color.Transparent;
            risk5_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk5_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl10.Click += new EventHandler(risk5_3_fayda_pl10_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk5_3_fayda_pl9.Name = "pl9";
            risk5_3_fayda_pl9.Size = new Size(65, 50);
            risk5_3_fayda_pl9.Dock = DockStyle.Right;
            risk5_3_fayda_pl9.BackColor = Color.Transparent;
            risk5_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk5_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl9.Click += new EventHandler(risk5_3_fayda_pl9_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk5_3_fayda_pl8.Name = "pl8";
            risk5_3_fayda_pl8.Size = new Size(65, 50);
            risk5_3_fayda_pl8.Dock = DockStyle.Right;
            risk5_3_fayda_pl8.BackColor = Color.Transparent;
            risk5_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk5_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl8.Click += new EventHandler(risk5_3_fayda_pl8_Click);
            risk5_3_fayda_pl7.Controls.Add(risk5_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk5_3_fayda_pl6.Name = "pl6";
            risk5_3_fayda_pl6.Size = new Size(65, 50);
            risk5_3_fayda_pl6.Dock = DockStyle.Right;
            risk5_3_fayda_pl6.BackColor = Color.Transparent;
            risk5_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk5_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl6.Click += new EventHandler(risk5_3_fayda_pl6_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk5_3_fayda_btn3.Name = "btn3";
            risk5_3_fayda_btn3.Size = new Size(65, 50);
            risk5_3_fayda_btn3.Dock = DockStyle.Right;
            risk5_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk5_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_btn3.BackColor = Color.Transparent;
            risk5_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk5_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_btn3.Click += new EventHandler(risk5_3_fayda_btn3_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk5_3_fayda_btn2.Name = "btn2";
            risk5_3_fayda_btn2.Size = new Size(65, 50);
            risk5_3_fayda_btn2.Dock = DockStyle.Right;
            risk5_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk5_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk5_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk5_3_fayda_btn2.BackColor = Color.Transparent;
            risk5_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk5_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_btn2.Click += new EventHandler(risk5_3_fayda_btn2_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk5_3_fayda_btn1.Name = "btn1";
            risk5_3_fayda_btn1.Size = new Size(65, 50);
            risk5_3_fayda_btn1.Dock = DockStyle.Right;
            risk5_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk5_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk5_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk5_3_fayda_btn1.BackColor = Color.Transparent;
            risk5_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk5_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_btn1.Click += new EventHandler(risk5_3_fayda_btn1_Click);
            risk5_3_fayda_pl2.Controls.Add(risk5_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk5_3_fayda_dr1.Name = "dr1";
            risk5_3_fayda_dr1.Size = new Size(851, 498);
            risk5_3_fayda_dr1.Dock = DockStyle.Fill;
            risk5_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_dr1.AllowUserToAddRows = false;
            risk5_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk5_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk5_3_fayda_dr1.AllowUserToResizeRows = false;
            risk5_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk5_3_fayda_dr1.RowHeadersVisible = false;
            risk5_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk5_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk5_3_fayda_dr1_CellEnter);
            risk5_3_fayda_tb1_2.Controls.Add(risk5_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk5_3_fayda_pl7.Name = "pl7";
            risk5_3_fayda_pl7.Size = new Size(865, 50);
            risk5_3_fayda_pl7.Dock = DockStyle.Top;
            risk5_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_tb1_2.Controls.Add(risk5_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk5_3_fayda_pl5.Name = "pl5";
            risk5_3_fayda_pl5.Size = new Size(851, 498);
            risk5_3_fayda_pl5.Dock = DockStyle.Fill;
            risk5_3_fayda_pl5.AutoScroll = true;
            risk5_3_fayda_pl5.AutoSize = true;
            risk5_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk5_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_tb1_1.Controls.Add(risk5_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk5_3_fayda_rt1.Name = "rt1";
            risk5_3_fayda_rt1.Size = new Size(851, 498);
            risk5_3_fayda_rt1.Dock = DockStyle.Fill;
            risk5_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_rt1.Enabled = false;
            risk5_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk5_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk5_3_fayda_tb1_3.Controls.Add(risk5_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk5_3_fayda_tb1_1.Name = "tb1_1";
            risk5_3_fayda_tb1_1.Text = "Tablo";
            risk5_3_fayda_tb1_1.Size = new Size(651, 50);
            risk5_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_tb1.Controls.Add(risk5_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk5_3_fayda_tb1_2.Name = "tb1_2";
            risk5_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk5_3_fayda_tb1_2.Size = new Size(651, 50);
            risk5_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_tb1.Controls.Add(risk5_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk5_3_fayda_tb1_3.Name = "tb1_3";
            risk5_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk5_3_fayda_tb1_3.Size = new Size(651, 50);
            risk5_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_tb1.Controls.Add(risk5_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk5_3_fayda_tb1.Name = "tb1";
            risk5_3_fayda_tb1.Size = new Size(651, 50);
            risk5_3_fayda_tb1.Dock = DockStyle.Fill;
            risk5_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk5_3_fayda_pl3.Controls.Add(risk5_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk5_3_fayda_pl4.Name = "pl4";
            risk5_3_fayda_pl4.Size = new Size(865, 50);
            risk5_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk5_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl4.MouseUp += new MouseEventHandler(risk5_3_fayda_pl4_MouseUp);
            risk5_3_fayda_pl4.MouseMove += new MouseEventHandler(risk5_3_fayda_pl4_MouseMove);
            risk5_3_fayda_pl4.MouseDown += new MouseEventHandler(risk5_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk5_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk5_3_fayda_pl3.Name = "pl3";
            risk5_3_fayda_pl3.Size = new Size(865, 530);
            risk5_3_fayda_pl3.Dock = DockStyle.Top;
            risk5_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk5_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk5_3_fayda_pl2.Name = "pl2";
            risk5_3_fayda_pl2.Size = new Size(865, 50);
            risk5_3_fayda_pl2.Dock = DockStyle.Top;
            risk5_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk5_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk5_3_fayda_pl1.Name = "pl1";
            risk5_3_fayda_pl1.Size = new Size(865, 50);
            risk5_3_fayda_pl1.Dock = DockStyle.Top;
            risk5_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk5_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk5_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk5_3_fayda_pl1.MouseUp += new MouseEventHandler(risk5_3_fayda_pl1_MouseUp);
            risk5_3_fayda_pl1.MouseMove += new MouseEventHandler(risk5_3_fayda_pl1_MouseMove);
            risk5_3_fayda_pl1.MouseDown += new MouseEventHandler(risk5_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk5_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk6_3_fayda form nesne tasarımları
        public void risk6_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk6_3_fayda_sonuc = new Label();
            risk6_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk6_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk6_3_fayda_sonuc.Location = sonuc;
            risk6_3_fayda_sonuc.Text = "";
            risk6_3_fayda_sonuc.Size = new Size(650, 13);
            risk6_3_fayda_pl4.Controls.Add(risk6_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk6_3_fayda_sonucbaslik = new Label();
            risk6_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk6_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk6_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk6_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk6_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk6_3_fayda_pl4.Controls.Add(risk6_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk6_3_fayda_sonuclarortabaslik = new Label();
            risk6_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk6_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk6_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk6_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk6_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk6_3_fayda_pl28.Controls.Add(risk6_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri18 = new NumericUpDown();
            risk6_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            risk6_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri18.Location = txt_veri18;
            risk6_3_fayda_txt_veri18.Size = new Size(85, 20);
            risk6_3_fayda_pl49.Controls.Add(risk6_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri17 = new NumericUpDown();
            risk6_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            risk6_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri17.Location = txt_veri17;
            risk6_3_fayda_txt_veri17.Size = new Size(85, 20);
            risk6_3_fayda_pl48.Controls.Add(risk6_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri16 = new NumericUpDown();
            risk6_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            risk6_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri16.Location = txt_veri16;
            risk6_3_fayda_txt_veri16.Size = new Size(85, 20);
            risk6_3_fayda_pl47.Controls.Add(risk6_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri15 = new NumericUpDown();
            risk6_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            risk6_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri15.Location = txt_veri15;
            risk6_3_fayda_txt_veri15.Size = new Size(85, 20);
            risk6_3_fayda_pl44.Controls.Add(risk6_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri14 = new NumericUpDown();
            risk6_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            risk6_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri14.Location = txt_veri14;
            risk6_3_fayda_txt_veri14.Size = new Size(85, 20);
            risk6_3_fayda_pl43.Controls.Add(risk6_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri13 = new NumericUpDown();
            risk6_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            risk6_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri13.Location = txt_veri13;
            risk6_3_fayda_txt_veri13.Size = new Size(85, 20);
            risk6_3_fayda_pl42.Controls.Add(risk6_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri12 = new NumericUpDown();
            risk6_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            risk6_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri12.Location = txt_veri12;
            risk6_3_fayda_txt_veri12.Size = new Size(85, 20);
            risk6_3_fayda_pl39.Controls.Add(risk6_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri11 = new NumericUpDown();
            risk6_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            risk6_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri11.Location = txt_veri11;
            risk6_3_fayda_txt_veri11.Size = new Size(85, 20);
            risk6_3_fayda_pl38.Controls.Add(risk6_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri10 = new NumericUpDown();
            risk6_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            risk6_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri10.Location = txt_veri10;
            risk6_3_fayda_txt_veri10.Size = new Size(85, 20);
            risk6_3_fayda_pl37.Controls.Add(risk6_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri9 = new NumericUpDown();
            risk6_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            risk6_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri9.Location = txt_veri9;
            risk6_3_fayda_txt_veri9.Size = new Size(85, 20);
            risk6_3_fayda_pl34.Controls.Add(risk6_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri8 = new NumericUpDown();
            risk6_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            risk6_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri8.Location = txt_veri8;
            risk6_3_fayda_txt_veri8.Size = new Size(85, 20);
            risk6_3_fayda_pl33.Controls.Add(risk6_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri7 = new NumericUpDown();
            risk6_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            risk6_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri7.Location = txt_veri7;
            risk6_3_fayda_txt_veri7.Size = new Size(85, 20);
            risk6_3_fayda_pl32.Controls.Add(risk6_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri6 = new NumericUpDown();
            risk6_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk6_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri6.Location = txt_veri6;
            risk6_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk6_3_fayda_pl27.Controls.Add(risk6_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri5 = new NumericUpDown();
            risk6_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk6_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri5.Location = txt_veri5;
            risk6_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk6_3_fayda_pl23.Controls.Add(risk6_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri4 = new NumericUpDown();
            risk6_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk6_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri4.Location = txt_veri4;
            risk6_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk6_3_fayda_pl22.Controls.Add(risk6_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri3 = new NumericUpDown();
            risk6_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk6_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri3.Location = txt_veri3;
            risk6_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk6_3_fayda_pl26.Controls.Add(risk6_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri2 = new NumericUpDown();
            risk6_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk6_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri2.Location = txt_veri2;
            risk6_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk6_3_fayda_pl21.Controls.Add(risk6_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk6_3_fayda_txt_veri1 = new NumericUpDown();
            risk6_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk6_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk6_3_fayda_txt_veri1.Location = txt_veri1;
            risk6_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk6_3_fayda_pl20.Controls.Add(risk6_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f6sonuc = new TextBox();
            risk6_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            risk6_3_fayda_txt_f6sonuc.Text = "0";
            risk6_3_fayda_txt_f6sonuc.Enabled = false;
            risk6_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl50.Controls.Add(risk6_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f5sonuc = new TextBox();
            risk6_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            risk6_3_fayda_txt_f5sonuc.Text = "0";
            risk6_3_fayda_txt_f5sonuc.Enabled = false;
            risk6_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl45.Controls.Add(risk6_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f4sonuc = new TextBox();
            risk6_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            risk6_3_fayda_txt_f4sonuc.Text = "0";
            risk6_3_fayda_txt_f4sonuc.Enabled = false;
            risk6_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl40.Controls.Add(risk6_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f3sonuc = new TextBox();
            risk6_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            risk6_3_fayda_txt_f3sonuc.Text = "0";
            risk6_3_fayda_txt_f3sonuc.Enabled = false;
            risk6_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl35.Controls.Add(risk6_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f2sonuc = new TextBox();
            risk6_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk6_3_fayda_txt_f2sonuc.Text = "0";
            risk6_3_fayda_txt_f2sonuc.Enabled = false;
            risk6_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl30.Controls.Add(risk6_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk6_3_fayda_txt_f1sonuc = new TextBox();
            risk6_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk6_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk6_3_fayda_txt_f1sonuc.Text = "0";
            risk6_3_fayda_txt_f1sonuc.Enabled = false;
            risk6_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk6_3_fayda_pl29.Controls.Add(risk6_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk6_3_fayda_txt_oran3 = new TextBox();
            risk6_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk6_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk6_3_fayda_txt_oran3.Text = "0,30";
            risk6_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_oran3.MaxLength = 30;
            risk6_3_fayda_txt_oran3.Multiline = true;
            risk6_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk6_3_fayda_pl25.Controls.Add(risk6_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk6_3_fayda_txt_oran2 = new TextBox();
            risk6_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk6_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk6_3_fayda_txt_oran2.Text = "0,20";
            risk6_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_oran2.MaxLength = 30;
            risk6_3_fayda_txt_oran2.Multiline = true;
            risk6_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk6_3_fayda_pl19.Controls.Add(risk6_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk6_3_fayda_txt_oran1 = new TextBox();
            risk6_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk6_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk6_3_fayda_txt_oran1.Text = "0,50";
            risk6_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_oran1.MaxLength = 30;
            risk6_3_fayda_txt_oran1.Multiline = true;
            risk6_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk6_3_fayda_pl18.Controls.Add(risk6_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk6_3_fayda_txt_üstbaslik3 = new TextBox();
            risk6_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk6_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk6_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk6_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk6_3_fayda_txt_üstbaslik3.Multiline = true;
            risk6_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk6_3_fayda_pl24.Controls.Add(risk6_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk6_3_fayda_txt_üstbaslik2 = new TextBox();
            risk6_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk6_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk6_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk6_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk6_3_fayda_txt_üstbaslik2.Multiline = true;
            risk6_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk6_3_fayda_pl17.Controls.Add(risk6_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk6_3_fayda_txt_üstbaslik1 = new TextBox();
            risk6_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk6_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk6_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk6_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk6_3_fayda_txt_üstbaslik1.Multiline = true;
            risk6_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk6_3_fayda_pl16.Controls.Add(risk6_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik6 = new TextBox();
            risk6_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            risk6_3_fayda_txt_altbaslik6.Text = "F6";
            risk6_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik6.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik6.Multiline = true;
            risk6_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            risk6_3_fayda_pl46.Controls.Add(risk6_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik5 = new TextBox();
            risk6_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            risk6_3_fayda_txt_altbaslik5.Text = "F5";
            risk6_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik5.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik5.Multiline = true;
            risk6_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            risk6_3_fayda_pl41.Controls.Add(risk6_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik4 = new TextBox();
            risk6_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            risk6_3_fayda_txt_altbaslik4.Text = "F4";
            risk6_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik4.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik4.Multiline = true;
            risk6_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            risk6_3_fayda_pl36.Controls.Add(risk6_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik3 = new TextBox();
            risk6_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            risk6_3_fayda_txt_altbaslik3.Text = "F3";
            risk6_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik3.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik3.Multiline = true;
            risk6_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            risk6_3_fayda_pl31.Controls.Add(risk6_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik2 = new TextBox();
            risk6_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk6_3_fayda_txt_altbaslik2.Text = "F2";
            risk6_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik2.Multiline = true;
            risk6_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk6_3_fayda_pl15.Controls.Add(risk6_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk6_3_fayda_txt_altbaslik1 = new TextBox();
            risk6_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk6_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk6_3_fayda_txt_altbaslik1.Text = "F1";
            risk6_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk6_3_fayda_txt_altbaslik1.Multiline = true;
            risk6_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk6_3_fayda_pl14.Controls.Add(risk6_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk6_3_fayda_txt_baslik2 = new TextBox();
            risk6_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk6_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk6_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk6_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_baslik2.MaxLength = 30;
            risk6_3_fayda_txt_baslik2.Multiline = true;
            risk6_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk6_3_fayda_pl13.Controls.Add(risk6_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk6_3_fayda_txt_baslik1 = new TextBox();
            risk6_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk6_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk6_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk6_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk6_3_fayda_txt_baslik1.MaxLength = 30;
            risk6_3_fayda_txt_baslik1.Multiline = true;
            risk6_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk6_3_fayda_pl12.Controls.Add(risk6_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            risk6_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            risk6_3_fayda_pl50.Location = pl50k;
            risk6_3_fayda_pl50.Size = new Size(91, 33);
            risk6_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            risk6_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            risk6_3_fayda_pl45.Location = pl45k;
            risk6_3_fayda_pl45.Size = new Size(91, 33);
            risk6_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            risk6_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            risk6_3_fayda_pl40.Location = pl40k;
            risk6_3_fayda_pl40.Size = new Size(91, 33);
            risk6_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            risk6_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            risk6_3_fayda_pl35.Location = pl35k;
            risk6_3_fayda_pl35.Size = new Size(91, 33);
            risk6_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk6_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk6_3_fayda_pl30.Location = pl30k;
            risk6_3_fayda_pl30.Size = new Size(91, 33);
            risk6_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk6_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk6_3_fayda_pl29.Location = pl29k;
            risk6_3_fayda_pl29.Size = new Size(91, 33);
            risk6_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk6_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk6_3_fayda_pl28.Location = pl28k;
            risk6_3_fayda_pl28.Size = new Size(91, 72);
            risk6_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            risk6_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            risk6_3_fayda_pl49.Location = pl49k;
            risk6_3_fayda_pl49.Size = new Size(91, 33);
            risk6_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            risk6_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            risk6_3_fayda_pl48.Location = pl48k;
            risk6_3_fayda_pl48.Size = new Size(91, 33);
            risk6_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            risk6_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            risk6_3_fayda_pl47.Location = pl47k;
            risk6_3_fayda_pl47.Size = new Size(91, 33);
            risk6_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            risk6_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            risk6_3_fayda_pl44.Location = pl44k;
            risk6_3_fayda_pl44.Size = new Size(91, 33);
            risk6_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            risk6_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            risk6_3_fayda_pl43.Location = pl43k;
            risk6_3_fayda_pl43.Size = new Size(91, 33);
            risk6_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            risk6_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            risk6_3_fayda_pl42.Location = pl42k;
            risk6_3_fayda_pl42.Size = new Size(91, 33);
            risk6_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            risk6_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            risk6_3_fayda_pl39.Location = pl39k;
            risk6_3_fayda_pl39.Size = new Size(91, 33);
            risk6_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            risk6_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            risk6_3_fayda_pl38.Location = pl38k;
            risk6_3_fayda_pl38.Size = new Size(91, 33);
            risk6_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            risk6_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            risk6_3_fayda_pl37.Location = pl37k;
            risk6_3_fayda_pl37.Size = new Size(91, 33);
            risk6_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            risk6_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            risk6_3_fayda_pl34.Location = pl34k;
            risk6_3_fayda_pl34.Size = new Size(91, 33);
            risk6_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            risk6_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            risk6_3_fayda_pl33.Location = pl33k;
            risk6_3_fayda_pl33.Size = new Size(91, 33);
            risk6_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            risk6_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            risk6_3_fayda_pl32.Location = pl32k;
            risk6_3_fayda_pl32.Size = new Size(91, 33);
            risk6_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk6_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk6_3_fayda_pl27.Location = pl27k;
            risk6_3_fayda_pl27.Size = new Size(91, 33);
            risk6_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk6_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk6_3_fayda_pl26.Location = pl26k;
            risk6_3_fayda_pl26.Size = new Size(91, 33);
            risk6_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk6_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk6_3_fayda_pl23.Location = pl23k;
            risk6_3_fayda_pl23.Size = new Size(91, 33);
            risk6_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk6_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk6_3_fayda_pl22.Location = pl22k;
            risk6_3_fayda_pl22.Size = new Size(91, 33);
            risk6_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk6_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk6_3_fayda_pl21.Location = pl21k;
            risk6_3_fayda_pl21.Size = new Size(91, 33);
            risk6_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk6_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk6_3_fayda_pl20.Location = pl20k;
            risk6_3_fayda_pl20.Size = new Size(91, 33);
            risk6_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk6_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk6_3_fayda_pl25.Location = pl25k;
            risk6_3_fayda_pl25.Size = new Size(91, 33);
            risk6_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk6_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk6_3_fayda_pl19.Location = pl19k;
            risk6_3_fayda_pl19.Size = new Size(91, 33);
            risk6_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk6_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk6_3_fayda_pl18.Location = pl18k;
            risk6_3_fayda_pl18.Size = new Size(91, 33);
            risk6_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk6_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk6_3_fayda_pl24.Location = pl24k;
            risk6_3_fayda_pl24.Size = new Size(91, 33);
            risk6_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk6_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk6_3_fayda_pl17.Location = pl17k;
            risk6_3_fayda_pl17.Size = new Size(91, 33);
            risk6_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk6_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk6_3_fayda_pl16.Location = pl16k;
            risk6_3_fayda_pl16.Size = new Size(91, 33);
            risk6_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            risk6_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            risk6_3_fayda_pl46.Location = pl46k;
            risk6_3_fayda_pl46.Size = new Size(168, 33);
            risk6_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            risk6_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            risk6_3_fayda_pl41.Location = pl41k;
            risk6_3_fayda_pl41.Size = new Size(168, 33);
            risk6_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            risk6_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            risk6_3_fayda_pl36.Location = pl36k;
            risk6_3_fayda_pl36.Size = new Size(168, 33);
            risk6_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            risk6_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            risk6_3_fayda_pl31.Location = pl31k;
            risk6_3_fayda_pl31.Size = new Size(168, 33);
            risk6_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk6_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            risk6_3_fayda_pl15.Location = pl15k;
            risk6_3_fayda_pl15.Size = new Size(168, 33);
            risk6_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk6_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk6_3_fayda_pl14.Location = pl14k;
            risk6_3_fayda_pl14.Size = new Size(168, 33);
            risk6_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk6_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk6_3_fayda_pl13.Location = pl13k;
            risk6_3_fayda_pl13.Size = new Size(168, 33);
            risk6_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk6_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk6_3_fayda_pl12.Location = pl12k;
            risk6_3_fayda_pl12.Size = new Size(168, 33);
            risk6_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl5.Controls.Add(risk6_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk6_3_fayda_pl11.Name = "pl11";
            risk6_3_fayda_pl11.Size = new Size(65, 50);
            risk6_3_fayda_pl11.Dock = DockStyle.Left;
            risk6_3_fayda_pl11.BackColor = Color.Transparent;
            risk6_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk6_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl11.Click += new EventHandler(risk6_3_fayda_pl11_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk6_3_fayda_pl10.Name = "pl10";
            risk6_3_fayda_pl10.Size = new Size(65, 50);
            risk6_3_fayda_pl10.Dock = DockStyle.Right;
            risk6_3_fayda_pl10.BackColor = Color.Transparent;
            risk6_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk6_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl10.Click += new EventHandler(risk6_3_fayda_pl10_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk6_3_fayda_pl9.Name = "pl9";
            risk6_3_fayda_pl9.Size = new Size(65, 50);
            risk6_3_fayda_pl9.Dock = DockStyle.Right;
            risk6_3_fayda_pl9.BackColor = Color.Transparent;
            risk6_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk6_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl9.Click += new EventHandler(risk6_3_fayda_pl9_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk6_3_fayda_pl8.Name = "pl8";
            risk6_3_fayda_pl8.Size = new Size(65, 50);
            risk6_3_fayda_pl8.Dock = DockStyle.Right;
            risk6_3_fayda_pl8.BackColor = Color.Transparent;
            risk6_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk6_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl8.Click += new EventHandler(risk6_3_fayda_pl8_Click);
            risk6_3_fayda_pl7.Controls.Add(risk6_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk6_3_fayda_pl6.Name = "pl6";
            risk6_3_fayda_pl6.Size = new Size(65, 50);
            risk6_3_fayda_pl6.Dock = DockStyle.Right;
            risk6_3_fayda_pl6.BackColor = Color.Transparent;
            risk6_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk6_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl6.Click += new EventHandler(risk6_3_fayda_pl6_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk6_3_fayda_btn3.Name = "btn3";
            risk6_3_fayda_btn3.Size = new Size(65, 50);
            risk6_3_fayda_btn3.Dock = DockStyle.Right;
            risk6_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk6_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_btn3.BackColor = Color.Transparent;
            risk6_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk6_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_btn3.Click += new EventHandler(risk6_3_fayda_btn3_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk6_3_fayda_btn2.Name = "btn2";
            risk6_3_fayda_btn2.Size = new Size(65, 50);
            risk6_3_fayda_btn2.Dock = DockStyle.Right;
            risk6_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk6_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk6_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk6_3_fayda_btn2.BackColor = Color.Transparent;
            risk6_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk6_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_btn2.Click += new EventHandler(risk6_3_fayda_btn2_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk6_3_fayda_btn1.Name = "btn1";
            risk6_3_fayda_btn1.Size = new Size(65, 50);
            risk6_3_fayda_btn1.Dock = DockStyle.Right;
            risk6_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk6_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk6_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk6_3_fayda_btn1.BackColor = Color.Transparent;
            risk6_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk6_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_btn1.Click += new EventHandler(risk6_3_fayda_btn1_Click);
            risk6_3_fayda_pl2.Controls.Add(risk6_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk6_3_fayda_dr1.Name = "dr1";
            risk6_3_fayda_dr1.Size = new Size(851, 498);
            risk6_3_fayda_dr1.Dock = DockStyle.Fill;
            risk6_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_dr1.AllowUserToAddRows = false;
            risk6_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk6_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk6_3_fayda_dr1.AllowUserToResizeRows = false;
            risk6_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk6_3_fayda_dr1.RowHeadersVisible = false;
            risk6_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk6_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk6_3_fayda_dr1_CellEnter);
            risk6_3_fayda_tb1_2.Controls.Add(risk6_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk6_3_fayda_pl7.Name = "pl7";
            risk6_3_fayda_pl7.Size = new Size(865, 50);
            risk6_3_fayda_pl7.Dock = DockStyle.Top;
            risk6_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_tb1_2.Controls.Add(risk6_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk6_3_fayda_pl5.Name = "pl5";
            risk6_3_fayda_pl5.Size = new Size(851, 498);
            risk6_3_fayda_pl5.Dock = DockStyle.Fill;
            risk6_3_fayda_pl5.AutoScroll = true;
            risk6_3_fayda_pl5.AutoSize = true;
            risk6_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk6_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_tb1_1.Controls.Add(risk6_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk6_3_fayda_rt1.Name = "rt1";
            risk6_3_fayda_rt1.Size = new Size(851, 498);
            risk6_3_fayda_rt1.Dock = DockStyle.Fill;
            risk6_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_rt1.Enabled = false;
            risk6_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk6_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk6_3_fayda_tb1_3.Controls.Add(risk6_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk6_3_fayda_tb1_1.Name = "tb1_1";
            risk6_3_fayda_tb1_1.Text = "Tablo";
            risk6_3_fayda_tb1_1.Size = new Size(651, 50);
            risk6_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_tb1.Controls.Add(risk6_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk6_3_fayda_tb1_2.Name = "tb1_2";
            risk6_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk6_3_fayda_tb1_2.Size = new Size(651, 50);
            risk6_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_tb1.Controls.Add(risk6_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk6_3_fayda_tb1_3.Name = "tb1_3";
            risk6_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk6_3_fayda_tb1_3.Size = new Size(651, 50);
            risk6_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_tb1.Controls.Add(risk6_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk6_3_fayda_tb1.Name = "tb1";
            risk6_3_fayda_tb1.Size = new Size(651, 50);
            risk6_3_fayda_tb1.Dock = DockStyle.Fill;
            risk6_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk6_3_fayda_pl3.Controls.Add(risk6_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk6_3_fayda_pl4.Name = "pl4";
            risk6_3_fayda_pl4.Size = new Size(865, 50);
            risk6_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk6_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl4.MouseUp += new MouseEventHandler(risk6_3_fayda_pl4_MouseUp);
            risk6_3_fayda_pl4.MouseMove += new MouseEventHandler(risk6_3_fayda_pl4_MouseMove);
            risk6_3_fayda_pl4.MouseDown += new MouseEventHandler(risk6_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk6_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk6_3_fayda_pl3.Name = "pl3";
            risk6_3_fayda_pl3.Size = new Size(865, 530);
            risk6_3_fayda_pl3.Dock = DockStyle.Top;
            risk6_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk6_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk6_3_fayda_pl2.Name = "pl2";
            risk6_3_fayda_pl2.Size = new Size(865, 50);
            risk6_3_fayda_pl2.Dock = DockStyle.Top;
            risk6_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk6_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk6_3_fayda_pl1.Name = "pl1";
            risk6_3_fayda_pl1.Size = new Size(865, 50);
            risk6_3_fayda_pl1.Dock = DockStyle.Top;
            risk6_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk6_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk6_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk6_3_fayda_pl1.MouseUp += new MouseEventHandler(risk6_3_fayda_pl1_MouseUp);
            risk6_3_fayda_pl1.MouseMove += new MouseEventHandler(risk6_3_fayda_pl1_MouseMove);
            risk6_3_fayda_pl1.MouseDown += new MouseEventHandler(risk6_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk6_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk7_3_fayda form nesne tasarımları
        public void risk7_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            risk7_3_fayda_sonuc = new Label();
            risk7_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            risk7_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk7_3_fayda_sonuc.Location = sonuc;
            risk7_3_fayda_sonuc.Text = "";
            risk7_3_fayda_sonuc.Size = new Size(650, 13);
            risk7_3_fayda_pl4.Controls.Add(risk7_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            risk7_3_fayda_sonucbaslik = new Label();
            risk7_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            risk7_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk7_3_fayda_sonucbaslik.Location = sonucbaslik;
            risk7_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            risk7_3_fayda_sonucbaslik.Size = new Size(88, 13);
            risk7_3_fayda_pl4.Controls.Add(risk7_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            risk7_3_fayda_sonuclarortabaslik = new Label();
            risk7_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            risk7_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            risk7_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            risk7_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            risk7_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            risk7_3_fayda_pl28.Controls.Add(risk7_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri21 = new NumericUpDown();
            risk7_3_fayda_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            risk7_3_fayda_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri21.Location = txt_veri21;
            risk7_3_fayda_txt_veri21.Size = new Size(85, 20);
            risk7_3_fayda_pl54.Controls.Add(risk7_3_fayda_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri20 = new NumericUpDown();
            risk7_3_fayda_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            risk7_3_fayda_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri20.Location = txt_veri20;
            risk7_3_fayda_txt_veri20.Size = new Size(85, 20);
            risk7_3_fayda_pl53.Controls.Add(risk7_3_fayda_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri19 = new NumericUpDown();
            risk7_3_fayda_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            risk7_3_fayda_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri19.Location = txt_veri19;
            risk7_3_fayda_txt_veri19.Size = new Size(85, 20);
            risk7_3_fayda_pl52.Controls.Add(risk7_3_fayda_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri18 = new NumericUpDown();
            risk7_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            risk7_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri18.Location = txt_veri18;
            risk7_3_fayda_txt_veri18.Size = new Size(85, 20);
            risk7_3_fayda_pl49.Controls.Add(risk7_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri17 = new NumericUpDown();
            risk7_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            risk7_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri17.Location = txt_veri17;
            risk7_3_fayda_txt_veri17.Size = new Size(85, 20);
            risk7_3_fayda_pl48.Controls.Add(risk7_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri16 = new NumericUpDown();
            risk7_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            risk7_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri16.Location = txt_veri16;
            risk7_3_fayda_txt_veri16.Size = new Size(85, 20);
            risk7_3_fayda_pl47.Controls.Add(risk7_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri15 = new NumericUpDown();
            risk7_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            risk7_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri15.Location = txt_veri15;
            risk7_3_fayda_txt_veri15.Size = new Size(85, 20);
            risk7_3_fayda_pl44.Controls.Add(risk7_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri14 = new NumericUpDown();
            risk7_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            risk7_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri14.Location = txt_veri14;
            risk7_3_fayda_txt_veri14.Size = new Size(85, 20);
            risk7_3_fayda_pl43.Controls.Add(risk7_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri13 = new NumericUpDown();
            risk7_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            risk7_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri13.Location = txt_veri13;
            risk7_3_fayda_txt_veri13.Size = new Size(85, 20);
            risk7_3_fayda_pl42.Controls.Add(risk7_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri12 = new NumericUpDown();
            risk7_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            risk7_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri12.Location = txt_veri12;
            risk7_3_fayda_txt_veri12.Size = new Size(85, 20);
            risk7_3_fayda_pl39.Controls.Add(risk7_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri11 = new NumericUpDown();
            risk7_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            risk7_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri11.Location = txt_veri11;
            risk7_3_fayda_txt_veri11.Size = new Size(85, 20);
            risk7_3_fayda_pl38.Controls.Add(risk7_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri10 = new NumericUpDown();
            risk7_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            risk7_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri10.Location = txt_veri10;
            risk7_3_fayda_txt_veri10.Size = new Size(85, 20);
            risk7_3_fayda_pl37.Controls.Add(risk7_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri9 = new NumericUpDown();
            risk7_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            risk7_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri9.Location = txt_veri9;
            risk7_3_fayda_txt_veri9.Size = new Size(85, 20);
            risk7_3_fayda_pl34.Controls.Add(risk7_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri8 = new NumericUpDown();
            risk7_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            risk7_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri8.Location = txt_veri8;
            risk7_3_fayda_txt_veri8.Size = new Size(85, 20);
            risk7_3_fayda_pl33.Controls.Add(risk7_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri7 = new NumericUpDown();
            risk7_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            risk7_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri7.Location = txt_veri7;
            risk7_3_fayda_txt_veri7.Size = new Size(85, 20);
            risk7_3_fayda_pl32.Controls.Add(risk7_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri6 = new NumericUpDown();
            risk7_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            risk7_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri6.Location = txt_veri6;
            risk7_3_fayda_txt_veri6.Size = new Size(85, 20);
            risk7_3_fayda_pl27.Controls.Add(risk7_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri5 = new NumericUpDown();
            risk7_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            risk7_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri5.Location = txt_veri5;
            risk7_3_fayda_txt_veri5.Size = new Size(85, 20);
            risk7_3_fayda_pl23.Controls.Add(risk7_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri4 = new NumericUpDown();
            risk7_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            risk7_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri4.Location = txt_veri4;
            risk7_3_fayda_txt_veri4.Size = new Size(85, 20);
            risk7_3_fayda_pl22.Controls.Add(risk7_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri3 = new NumericUpDown();
            risk7_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            risk7_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri3.Location = txt_veri3;
            risk7_3_fayda_txt_veri3.Size = new Size(85, 20);
            risk7_3_fayda_pl26.Controls.Add(risk7_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri2 = new NumericUpDown();
            risk7_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            risk7_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri2.Location = txt_veri2;
            risk7_3_fayda_txt_veri2.Size = new Size(85, 20);
            risk7_3_fayda_pl21.Controls.Add(risk7_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            risk7_3_fayda_txt_veri1 = new NumericUpDown();
            risk7_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            risk7_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            risk7_3_fayda_txt_veri1.Location = txt_veri1;
            risk7_3_fayda_txt_veri1.Size = new Size(85, 20);
            risk7_3_fayda_pl20.Controls.Add(risk7_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel55 içerisine f7sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f7sonuc = new TextBox();
            risk7_3_fayda_txt_f7sonuc.Name = "txtf7sonuc";
            Point txt_txtf7sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f7sonuc.Location = txt_txtf7sonuc;
            risk7_3_fayda_txt_f7sonuc.Text = "0";
            risk7_3_fayda_txt_f7sonuc.Enabled = false;
            risk7_3_fayda_txt_f7sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl55.Controls.Add(risk7_3_fayda_txt_f7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f6sonuc = new TextBox();
            risk7_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            risk7_3_fayda_txt_f6sonuc.Text = "0";
            risk7_3_fayda_txt_f6sonuc.Enabled = false;
            risk7_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl50.Controls.Add(risk7_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f5sonuc = new TextBox();
            risk7_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            risk7_3_fayda_txt_f5sonuc.Text = "0";
            risk7_3_fayda_txt_f5sonuc.Enabled = false;
            risk7_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl45.Controls.Add(risk7_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f4sonuc = new TextBox();
            risk7_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            risk7_3_fayda_txt_f4sonuc.Text = "0";
            risk7_3_fayda_txt_f4sonuc.Enabled = false;
            risk7_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl40.Controls.Add(risk7_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f3sonuc = new TextBox();
            risk7_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            risk7_3_fayda_txt_f3sonuc.Text = "0";
            risk7_3_fayda_txt_f3sonuc.Enabled = false;
            risk7_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl35.Controls.Add(risk7_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f2sonuc = new TextBox();
            risk7_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            risk7_3_fayda_txt_f2sonuc.Text = "0";
            risk7_3_fayda_txt_f2sonuc.Enabled = false;
            risk7_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl30.Controls.Add(risk7_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            risk7_3_fayda_txt_f1sonuc = new TextBox();
            risk7_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            risk7_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            risk7_3_fayda_txt_f1sonuc.Text = "0";
            risk7_3_fayda_txt_f1sonuc.Enabled = false;
            risk7_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            risk7_3_fayda_pl29.Controls.Add(risk7_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            risk7_3_fayda_txt_oran3 = new TextBox();
            risk7_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            risk7_3_fayda_txt_oran3.Location = txt_txtoran3;
            risk7_3_fayda_txt_oran3.Text = "0,30";
            risk7_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_oran3.MaxLength = 30;
            risk7_3_fayda_txt_oran3.Multiline = true;
            risk7_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_oran3.Size = new Size(85, 13);
            risk7_3_fayda_pl25.Controls.Add(risk7_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            risk7_3_fayda_txt_oran2 = new TextBox();
            risk7_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            risk7_3_fayda_txt_oran2.Location = txt_txtoran2;
            risk7_3_fayda_txt_oran2.Text = "0,20";
            risk7_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_oran2.MaxLength = 30;
            risk7_3_fayda_txt_oran2.Multiline = true;
            risk7_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_oran2.Size = new Size(85, 13);
            risk7_3_fayda_pl19.Controls.Add(risk7_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            risk7_3_fayda_txt_oran1 = new TextBox();
            risk7_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            risk7_3_fayda_txt_oran1.Location = txt_txtoran1;
            risk7_3_fayda_txt_oran1.Text = "0,50";
            risk7_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_oran1.MaxLength = 30;
            risk7_3_fayda_txt_oran1.Multiline = true;
            risk7_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_oran1.Size = new Size(85, 13);
            risk7_3_fayda_pl18.Controls.Add(risk7_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            risk7_3_fayda_txt_üstbaslik3 = new TextBox();
            risk7_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            risk7_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            risk7_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            risk7_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_üstbaslik3.MaxLength = 30;
            risk7_3_fayda_txt_üstbaslik3.Multiline = true;
            risk7_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            risk7_3_fayda_pl24.Controls.Add(risk7_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            risk7_3_fayda_txt_üstbaslik2 = new TextBox();
            risk7_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            risk7_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            risk7_3_fayda_txt_üstbaslik2.Text = "Orta";
            risk7_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_üstbaslik2.MaxLength = 30;
            risk7_3_fayda_txt_üstbaslik2.Multiline = true;
            risk7_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            risk7_3_fayda_pl17.Controls.Add(risk7_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            risk7_3_fayda_txt_üstbaslik1 = new TextBox();
            risk7_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            risk7_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            risk7_3_fayda_txt_üstbaslik1.Text = "Büyük";
            risk7_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_üstbaslik1.MaxLength = 30;
            risk7_3_fayda_txt_üstbaslik1.Multiline = true;
            risk7_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            risk7_3_fayda_pl16.Controls.Add(risk7_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik7 = new TextBox();
            risk7_3_fayda_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik7.Location = txt_txtaltbaslik7;
            risk7_3_fayda_txt_altbaslik7.Text = "F7";
            risk7_3_fayda_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik7.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik7.Multiline = true;
            risk7_3_fayda_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik7.Size = new Size(162, 13);
            risk7_3_fayda_pl51.Controls.Add(risk7_3_fayda_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik6 = new TextBox();
            risk7_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            risk7_3_fayda_txt_altbaslik6.Text = "F6";
            risk7_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik6.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik6.Multiline = true;
            risk7_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            risk7_3_fayda_pl46.Controls.Add(risk7_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik5 = new TextBox();
            risk7_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            risk7_3_fayda_txt_altbaslik5.Text = "F5";
            risk7_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik5.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik5.Multiline = true;
            risk7_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            risk7_3_fayda_pl41.Controls.Add(risk7_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik4 = new TextBox();
            risk7_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            risk7_3_fayda_txt_altbaslik4.Text = "F4";
            risk7_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik4.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik4.Multiline = true;
            risk7_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            risk7_3_fayda_pl36.Controls.Add(risk7_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik3 = new TextBox();
            risk7_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            risk7_3_fayda_txt_altbaslik3.Text = "F3";
            risk7_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik3.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik3.Multiline = true;
            risk7_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            risk7_3_fayda_pl31.Controls.Add(risk7_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik2 = new TextBox();
            risk7_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            risk7_3_fayda_txt_altbaslik2.Text = "F2";
            risk7_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik2.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik2.Multiline = true;
            risk7_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            risk7_3_fayda_pl15.Controls.Add(risk7_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            risk7_3_fayda_txt_altbaslik1 = new TextBox();
            risk7_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            risk7_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            risk7_3_fayda_txt_altbaslik1.Text = "F1";
            risk7_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_altbaslik1.MaxLength = 30;
            risk7_3_fayda_txt_altbaslik1.Multiline = true;
            risk7_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            risk7_3_fayda_pl14.Controls.Add(risk7_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            risk7_3_fayda_txt_baslik2 = new TextBox();
            risk7_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            risk7_3_fayda_txt_baslik2.Location = txt_baslik2;
            risk7_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            risk7_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_baslik2.MaxLength = 30;
            risk7_3_fayda_txt_baslik2.Multiline = true;
            risk7_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_baslik2.Size = new Size(162, 13);
            risk7_3_fayda_pl13.Controls.Add(risk7_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            risk7_3_fayda_txt_baslik1 = new TextBox();
            risk7_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            risk7_3_fayda_txt_baslik1.Location = txt_baslik1;
            risk7_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            risk7_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            risk7_3_fayda_txt_baslik1.MaxLength = 30;
            risk7_3_fayda_txt_baslik1.Multiline = true;
            risk7_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_txt_baslik1.Size = new Size(162, 13);
            risk7_3_fayda_pl12.Controls.Add(risk7_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel55 oluşturuldu  f7-sonuc arka planı orta kısım 
            risk7_3_fayda_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            risk7_3_fayda_pl55.Location = pl55k;
            risk7_3_fayda_pl55.Size = new Size(91, 33);
            risk7_3_fayda_pl55.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            risk7_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            risk7_3_fayda_pl50.Location = pl50k;
            risk7_3_fayda_pl50.Size = new Size(91, 33);
            risk7_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            risk7_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            risk7_3_fayda_pl45.Location = pl45k;
            risk7_3_fayda_pl45.Size = new Size(91, 33);
            risk7_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            risk7_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            risk7_3_fayda_pl40.Location = pl40k;
            risk7_3_fayda_pl40.Size = new Size(91, 33);
            risk7_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            risk7_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            risk7_3_fayda_pl35.Location = pl35k;
            risk7_3_fayda_pl35.Size = new Size(91, 33);
            risk7_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            risk7_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            risk7_3_fayda_pl30.Location = pl30k;
            risk7_3_fayda_pl30.Size = new Size(91, 33);
            risk7_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            risk7_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            risk7_3_fayda_pl29.Location = pl29k;
            risk7_3_fayda_pl29.Size = new Size(91, 33);
            risk7_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            risk7_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            risk7_3_fayda_pl28.Location = pl28k;
            risk7_3_fayda_pl28.Size = new Size(91, 72);
            risk7_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            risk7_3_fayda_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            risk7_3_fayda_pl54.Location = pl54k;
            risk7_3_fayda_pl54.Size = new Size(91, 33);
            risk7_3_fayda_pl54.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            risk7_3_fayda_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            risk7_3_fayda_pl53.Location = pl53k;
            risk7_3_fayda_pl53.Size = new Size(91, 33);
            risk7_3_fayda_pl53.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            risk7_3_fayda_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            risk7_3_fayda_pl52.Location = pl52k;
            risk7_3_fayda_pl52.Size = new Size(91, 33);
            risk7_3_fayda_pl52.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            risk7_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            risk7_3_fayda_pl49.Location = pl49k;
            risk7_3_fayda_pl49.Size = new Size(91, 33);
            risk7_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            risk7_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            risk7_3_fayda_pl48.Location = pl48k;
            risk7_3_fayda_pl48.Size = new Size(91, 33);
            risk7_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            risk7_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            risk7_3_fayda_pl47.Location = pl47k;
            risk7_3_fayda_pl47.Size = new Size(91, 33);
            risk7_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            risk7_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            risk7_3_fayda_pl44.Location = pl44k;
            risk7_3_fayda_pl44.Size = new Size(91, 33);
            risk7_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            risk7_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            risk7_3_fayda_pl43.Location = pl43k;
            risk7_3_fayda_pl43.Size = new Size(91, 33);
            risk7_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            risk7_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            risk7_3_fayda_pl42.Location = pl42k;
            risk7_3_fayda_pl42.Size = new Size(91, 33);
            risk7_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            risk7_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            risk7_3_fayda_pl39.Location = pl39k;
            risk7_3_fayda_pl39.Size = new Size(91, 33);
            risk7_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            risk7_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            risk7_3_fayda_pl38.Location = pl38k;
            risk7_3_fayda_pl38.Size = new Size(91, 33);
            risk7_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            risk7_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            risk7_3_fayda_pl37.Location = pl37k;
            risk7_3_fayda_pl37.Size = new Size(91, 33);
            risk7_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            risk7_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            risk7_3_fayda_pl34.Location = pl34k;
            risk7_3_fayda_pl34.Size = new Size(91, 33);
            risk7_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            risk7_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            risk7_3_fayda_pl33.Location = pl33k;
            risk7_3_fayda_pl33.Size = new Size(91, 33);
            risk7_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            risk7_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            risk7_3_fayda_pl32.Location = pl32k;
            risk7_3_fayda_pl32.Size = new Size(91, 33);
            risk7_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            risk7_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            risk7_3_fayda_pl27.Location = pl27k;
            risk7_3_fayda_pl27.Size = new Size(91, 33);
            risk7_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            risk7_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            risk7_3_fayda_pl26.Location = pl26k;
            risk7_3_fayda_pl26.Size = new Size(91, 33);
            risk7_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            risk7_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            risk7_3_fayda_pl23.Location = pl23k;
            risk7_3_fayda_pl23.Size = new Size(91, 33);
            risk7_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            risk7_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            risk7_3_fayda_pl22.Location = pl22k;
            risk7_3_fayda_pl22.Size = new Size(91, 33);
            risk7_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            risk7_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            risk7_3_fayda_pl21.Location = pl21k;
            risk7_3_fayda_pl21.Size = new Size(91, 33);
            risk7_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            risk7_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            risk7_3_fayda_pl20.Location = pl20k;
            risk7_3_fayda_pl20.Size = new Size(91, 33);
            risk7_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            risk7_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            risk7_3_fayda_pl25.Location = pl25k;
            risk7_3_fayda_pl25.Size = new Size(91, 33);
            risk7_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            risk7_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            risk7_3_fayda_pl19.Location = pl19k;
            risk7_3_fayda_pl19.Size = new Size(91, 33);
            risk7_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            risk7_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            risk7_3_fayda_pl18.Location = pl18k;
            risk7_3_fayda_pl18.Size = new Size(91, 33);
            risk7_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            risk7_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            risk7_3_fayda_pl24.Location = pl24k;
            risk7_3_fayda_pl24.Size = new Size(91, 33);
            risk7_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            risk7_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            risk7_3_fayda_pl17.Location = pl17k;
            risk7_3_fayda_pl17.Size = new Size(91, 33);
            risk7_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            risk7_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            risk7_3_fayda_pl16.Location = pl16k;
            risk7_3_fayda_pl16.Size = new Size(91, 33);
            risk7_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            risk7_3_fayda_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            risk7_3_fayda_pl51.Location = pl51k;
            risk7_3_fayda_pl51.Size = new Size(168, 33);
            risk7_3_fayda_pl51.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            risk7_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            risk7_3_fayda_pl46.Location = pl46k;
            risk7_3_fayda_pl46.Size = new Size(168, 33);
            risk7_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            risk7_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            risk7_3_fayda_pl41.Location = pl41k;
            risk7_3_fayda_pl41.Size = new Size(168, 33);
            risk7_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            risk7_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            risk7_3_fayda_pl36.Location = pl36k;
            risk7_3_fayda_pl36.Size = new Size(168, 33);
            risk7_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            risk7_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            risk7_3_fayda_pl31.Location = pl31k;
            risk7_3_fayda_pl31.Size = new Size(168, 33);
            risk7_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            risk7_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            risk7_3_fayda_pl15.Location = pl15k;
            risk7_3_fayda_pl15.Size = new Size(168, 33);
            risk7_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            risk7_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            risk7_3_fayda_pl14.Location = pl14k;
            risk7_3_fayda_pl14.Size = new Size(168, 33);
            risk7_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            risk7_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            risk7_3_fayda_pl13.Location = pl13k;
            risk7_3_fayda_pl13.Size = new Size(168, 33);
            risk7_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            risk7_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            risk7_3_fayda_pl12.Location = pl12k;
            risk7_3_fayda_pl12.Size = new Size(168, 33);
            risk7_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl5.Controls.Add(risk7_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            risk7_3_fayda_pl11.Name = "pl11";
            risk7_3_fayda_pl11.Size = new Size(65, 50);
            risk7_3_fayda_pl11.Dock = DockStyle.Left;
            risk7_3_fayda_pl11.BackColor = Color.Transparent;
            risk7_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            risk7_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl11.Click += new EventHandler(risk7_3_fayda_pl11_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            risk7_3_fayda_pl10.Name = "pl10";
            risk7_3_fayda_pl10.Size = new Size(65, 50);
            risk7_3_fayda_pl10.Dock = DockStyle.Right;
            risk7_3_fayda_pl10.BackColor = Color.Transparent;
            risk7_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            risk7_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl10.Click += new EventHandler(risk7_3_fayda_pl10_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            risk7_3_fayda_pl9.Name = "pl9";
            risk7_3_fayda_pl9.Size = new Size(65, 50);
            risk7_3_fayda_pl9.Dock = DockStyle.Right;
            risk7_3_fayda_pl9.BackColor = Color.Transparent;
            risk7_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            risk7_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl9.Click += new EventHandler(risk7_3_fayda_pl9_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            risk7_3_fayda_pl8.Name = "pl8";
            risk7_3_fayda_pl8.Size = new Size(65, 50);
            risk7_3_fayda_pl8.Dock = DockStyle.Right;
            risk7_3_fayda_pl8.BackColor = Color.Transparent;
            risk7_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            risk7_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl8.Click += new EventHandler(risk7_3_fayda_pl8_Click);
            risk7_3_fayda_pl7.Controls.Add(risk7_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            risk7_3_fayda_pl6.Name = "pl6";
            risk7_3_fayda_pl6.Size = new Size(65, 50);
            risk7_3_fayda_pl6.Dock = DockStyle.Right;
            risk7_3_fayda_pl6.BackColor = Color.Transparent;
            risk7_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            risk7_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl6.Click += new EventHandler(risk7_3_fayda_pl6_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            risk7_3_fayda_btn3.Name = "btn3";
            risk7_3_fayda_btn3.Size = new Size(65, 50);
            risk7_3_fayda_btn3.Dock = DockStyle.Right;
            risk7_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            risk7_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_btn3.BackColor = Color.Transparent;
            risk7_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            risk7_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_btn3.Click += new EventHandler(risk7_3_fayda_btn3_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            risk7_3_fayda_btn2.Name = "btn2";
            risk7_3_fayda_btn2.Size = new Size(65, 50);
            risk7_3_fayda_btn2.Dock = DockStyle.Right;
            risk7_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            risk7_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            risk7_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            risk7_3_fayda_btn2.BackColor = Color.Transparent;
            risk7_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            risk7_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_btn2.Click += new EventHandler(risk7_3_fayda_btn2_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            risk7_3_fayda_btn1.Name = "btn1";
            risk7_3_fayda_btn1.Size = new Size(65, 50);
            risk7_3_fayda_btn1.Dock = DockStyle.Right;
            risk7_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            risk7_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            risk7_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            risk7_3_fayda_btn1.BackColor = Color.Transparent;
            risk7_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            risk7_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_btn1.Click += new EventHandler(risk7_3_fayda_btn1_Click);
            risk7_3_fayda_pl2.Controls.Add(risk7_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            risk7_3_fayda_dr1.Name = "dr1";
            risk7_3_fayda_dr1.Size = new Size(851, 498);
            risk7_3_fayda_dr1.Dock = DockStyle.Fill;
            risk7_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_dr1.AllowUserToAddRows = false;
            risk7_3_fayda_dr1.AllowUserToDeleteRows = false;
            risk7_3_fayda_dr1.AllowUserToResizeColumns = false;
            risk7_3_fayda_dr1.AllowUserToResizeRows = false;
            risk7_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            risk7_3_fayda_dr1.RowHeadersVisible = false;
            risk7_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            risk7_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(risk7_3_fayda_dr1_CellEnter);
            risk7_3_fayda_tb1_2.Controls.Add(risk7_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            risk7_3_fayda_pl7.Name = "pl7";
            risk7_3_fayda_pl7.Size = new Size(865, 50);
            risk7_3_fayda_pl7.Dock = DockStyle.Top;
            risk7_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_tb1_2.Controls.Add(risk7_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            risk7_3_fayda_pl5.Name = "pl5";
            risk7_3_fayda_pl5.Size = new Size(851, 498);
            risk7_3_fayda_pl5.Dock = DockStyle.Fill;
            risk7_3_fayda_pl5.AutoScroll = true;
            risk7_3_fayda_pl5.AutoSize = true;
            risk7_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            risk7_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_tb1_1.Controls.Add(risk7_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            risk7_3_fayda_rt1.Name = "rt1";
            risk7_3_fayda_rt1.Size = new Size(851, 498);
            risk7_3_fayda_rt1.Dock = DockStyle.Fill;
            risk7_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_rt1.Enabled = false;
            risk7_3_fayda_rt1.Text = "•KV doğanın sunduğu olayların olasılıklarını bilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            risk7_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            risk7_3_fayda_tb1_3.Controls.Add(risk7_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            risk7_3_fayda_tb1_1.Name = "tb1_1";
            risk7_3_fayda_tb1_1.Text = "Tablo";
            risk7_3_fayda_tb1_1.Size = new Size(651, 50);
            risk7_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_tb1.Controls.Add(risk7_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            risk7_3_fayda_tb1_2.Name = "tb1_2";
            risk7_3_fayda_tb1_2.Text = "Veri Tabanı";
            risk7_3_fayda_tb1_2.Size = new Size(651, 50);
            risk7_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_tb1.Controls.Add(risk7_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            risk7_3_fayda_tb1_3.Name = "tb1_3";
            risk7_3_fayda_tb1_3.Text = "Konu Anlatımı";
            risk7_3_fayda_tb1_3.Size = new Size(651, 50);
            risk7_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_tb1.Controls.Add(risk7_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            risk7_3_fayda_tb1.Name = "tb1";
            risk7_3_fayda_tb1.Size = new Size(651, 50);
            risk7_3_fayda_tb1.Dock = DockStyle.Fill;
            risk7_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            risk7_3_fayda_pl3.Controls.Add(risk7_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            risk7_3_fayda_pl4.Name = "pl4";
            risk7_3_fayda_pl4.Size = new Size(865, 50);
            risk7_3_fayda_pl4.Dock = DockStyle.Bottom;
            risk7_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl4.MouseUp += new MouseEventHandler(risk7_3_fayda_pl4_MouseUp);
            risk7_3_fayda_pl4.MouseMove += new MouseEventHandler(risk7_3_fayda_pl4_MouseMove);
            risk7_3_fayda_pl4.MouseDown += new MouseEventHandler(risk7_3_fayda_pl4_MouseDown);
            this.Controls.Add(risk7_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            risk7_3_fayda_pl3.Name = "pl3";
            risk7_3_fayda_pl3.Size = new Size(865, 530);
            risk7_3_fayda_pl3.Dock = DockStyle.Top;
            risk7_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk7_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            risk7_3_fayda_pl2.Name = "pl2";
            risk7_3_fayda_pl2.Size = new Size(865, 50);
            risk7_3_fayda_pl2.Dock = DockStyle.Top;
            risk7_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(risk7_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            risk7_3_fayda_pl1.Name = "pl1";
            risk7_3_fayda_pl1.Size = new Size(865, 50);
            risk7_3_fayda_pl1.Dock = DockStyle.Top;
            risk7_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            risk7_3_fayda_pl1.BackgroundImage = Properties.Resources.riskaltındafaydabaslik;
            risk7_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            risk7_3_fayda_pl1.MouseUp += new MouseEventHandler(risk7_3_fayda_pl1_MouseUp);
            risk7_3_fayda_pl1.MouseMove += new MouseEventHandler(risk7_3_fayda_pl1_MouseMove);
            risk7_3_fayda_pl1.MouseDown += new MouseEventHandler(risk7_3_fayda_pl1_MouseDown);
            this.Controls.Add(risk7_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //risk2_3_fayda veritabanına listelemek için kullanılır
        public void risk2_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk2_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk2_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 19; i++)
            {
                risk2_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk3_3_fayda veritabanına listelemek için kullanılır
        public void risk3_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk3_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk3_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 24; i++)
            {
                risk3_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk4_3_fayda veritabanına listelemek için kullanılır
        public void risk4_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk4_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk4_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 29; i++)
            {
                risk4_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk5_3_fayda veritabanına listelemek için kullanılır
        public void risk5_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk5_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk5_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 34; i++)
            {
                risk5_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk6_3_fayda veritabanına listelemek için kullanılır
        public void risk6_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk6_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk6_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 39; i++)
            {
                risk6_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk7_3_fayda veritabanına listelemek için kullanılır
        public void risk7_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From risk7_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            risk7_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 44; i++)
            {
                risk7_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //risk2_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk2_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk2_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk2_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk2_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk2_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk2_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk2_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk2_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk2_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk2_3_fayda_pl12.Controls["txtbaslik1"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk2_3_fayda_pl13.Controls["txtbaslik2"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();          
                risk2_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk2_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk2_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk2_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk2_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk2_3_fayda_pl18.Controls["txtoran1"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk2_3_fayda_pl19.Controls["txtoran2"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk2_3_fayda_pl25.Controls["txtoran3"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk2_3_fayda_pl20.Controls["txtveri1"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk2_3_fayda_pl21.Controls["txtveri2"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk2_3_fayda_pl26.Controls["txtveri3"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk2_3_fayda_pl22.Controls["txtveri4"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk2_3_fayda_pl23.Controls["txtveri5"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk2_3_fayda_pl27.Controls["txtveri6"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk2_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk2_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk2_3_fayda_pl4.Controls["sonuc"].Text = risk2_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk2_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk2_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk2_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk2_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk2_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk2_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk2_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk2_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {              
                double orantoplam = (Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text)+ Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text)+ Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text));        
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text)* Convert.ToDouble(risk2_3_fayda_pl20.Controls["txtveri1"].Text))+ (Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk2_3_fayda_pl21.Controls["txtveri2"].Text))+ (Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk2_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk2_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk2_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk2_3_fayda_pl27.Controls["txtveri6"].Text)));
                    risk2_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk2_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1)
                    {
                        büyükolanibul = f2;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk2_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,sonuc_1,sonuc_2,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@sonuc_1,@sonuc_2,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk2_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk2_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk2_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk2_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk2_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }               
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk2_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk2_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk2_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";              
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3,2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2,5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1= (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3,5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk2_3_fayda where Id=" + risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
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

        //risk2_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk2_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk2_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk2_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk2_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk2_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk2_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk2_3_fayda_pl27.Controls["txtveri6"].Text)));
                    risk2_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk2_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1)
                    {
                        büyükolanibul = f2;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk2_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk2_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk2_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk2_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    risk2_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk2_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk2_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk2_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk2_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk2_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk2_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk2_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //risk3_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk3_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk3_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk3_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk3_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk3_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk3_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk3_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk3_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk3_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk3_3_fayda_pl12.Controls["txtbaslik1"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk3_3_fayda_pl13.Controls["txtbaslik2"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                risk3_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk3_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk3_3_fayda_pl31.Controls["txtaltbaslik3"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk3_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk3_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk3_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk3_3_fayda_pl18.Controls["txtoran1"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk3_3_fayda_pl19.Controls["txtoran2"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk3_3_fayda_pl25.Controls["txtoran3"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk3_3_fayda_pl20.Controls["txtveri1"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk3_3_fayda_pl21.Controls["txtveri2"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk3_3_fayda_pl26.Controls["txtveri3"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk3_3_fayda_pl22.Controls["txtveri4"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk3_3_fayda_pl23.Controls["txtveri5"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk3_3_fayda_pl27.Controls["txtveri6"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk3_3_fayda_pl32.Controls["txtveri7"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk3_3_fayda_pl33.Controls["txtveri8"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                risk3_3_fayda_pl34.Controls["txtveri9"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                risk3_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                risk3_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                risk3_3_fayda_pl35.Controls["txtf3sonuc"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                risk3_3_fayda_pl4.Controls["sonuc"].Text = risk3_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk3_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk3_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk3_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk3_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk3_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk3_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk3_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk3_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl34.Controls["txtveri9"].Text)));
                    risk3_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk3_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk3_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1>f3)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2>f3)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3>f2)
                    {
                        büyükolanibul = f3;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk3_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,sonuc_1,sonuc_2,sonuc_3,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@sonuc_1,@sonuc_2,@sonuc_3,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk3_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk3_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk3_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk3_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk3_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk3_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk3_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk3_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk3_3_fayda where Id=" + risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range fayda = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
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

        //risk3_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk3_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk3_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk3_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk3_3_fayda_pl34.Controls["txtveri9"].Text)));
                    risk3_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk3_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk3_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2)
                    {
                        büyükolanibul = f3;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk3_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk3_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk3_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk3_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk3_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());
                                    
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk3_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk3_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk3_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk3_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk3_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk3_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk3_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //risk4_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk4_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk4_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk4_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk4_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk4_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk4_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk4_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk4_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk4_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk4_3_fayda_pl12.Controls["txtbaslik1"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk4_3_fayda_pl13.Controls["txtbaslik2"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                risk4_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk4_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk4_3_fayda_pl31.Controls["txtaltbaslik3"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk4_3_fayda_pl36.Controls["txtaltbaslik4"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk4_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk4_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk4_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk4_3_fayda_pl18.Controls["txtoran1"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk4_3_fayda_pl19.Controls["txtoran2"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk4_3_fayda_pl25.Controls["txtoran3"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk4_3_fayda_pl20.Controls["txtveri1"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk4_3_fayda_pl21.Controls["txtveri2"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk4_3_fayda_pl26.Controls["txtveri3"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk4_3_fayda_pl22.Controls["txtveri4"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk4_3_fayda_pl23.Controls["txtveri5"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk4_3_fayda_pl27.Controls["txtveri6"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk4_3_fayda_pl32.Controls["txtveri7"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                risk4_3_fayda_pl33.Controls["txtveri8"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                risk4_3_fayda_pl34.Controls["txtveri9"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                risk4_3_fayda_pl37.Controls["txtveri10"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                risk4_3_fayda_pl38.Controls["txtveri11"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                risk4_3_fayda_pl39.Controls["txtveri12"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                risk4_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                risk4_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                risk4_3_fayda_pl35.Controls["txtf3sonuc"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                risk4_3_fayda_pl40.Controls["txtf4sonuc"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                risk4_3_fayda_pl4.Controls["sonuc"].Text = risk4_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk4_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk4_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk4_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk4_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk4_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk4_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk4_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk4_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl39.Controls["txtveri12"].Text)));
                    risk4_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk4_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk4_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk4_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1>f4)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2>f4)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3>f4)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3)
                    {
                        büyükolanibul = f4;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk4_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,sonuc_1,sonuc_2,sonuc_3,sonuc_4,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk4_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk4_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk4_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk4_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk4_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk4_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk4_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk4_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk4_3_fayda where Id=" + risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //risk4_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk4_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk4_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk4_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk4_3_fayda_pl39.Controls["txtveri12"].Text)));
                    risk4_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk4_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk4_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk4_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3)
                    {
                        büyükolanibul = f4;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk4_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk4_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk4_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk4_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk4_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk4_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk4_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk4_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk4_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk4_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk4_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk4_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //risk5_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk5_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk5_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk5_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk5_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk5_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk5_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk5_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk5_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk5_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk5_3_fayda_pl12.Controls["txtbaslik1"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk5_3_fayda_pl13.Controls["txtbaslik2"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                risk5_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk5_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk5_3_fayda_pl31.Controls["txtaltbaslik3"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk5_3_fayda_pl36.Controls["txtaltbaslik4"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk5_3_fayda_pl41.Controls["txtaltbaslik5"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk5_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk5_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk5_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk5_3_fayda_pl18.Controls["txtoran1"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk5_3_fayda_pl19.Controls["txtoran2"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk5_3_fayda_pl25.Controls["txtoran3"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk5_3_fayda_pl20.Controls["txtveri1"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk5_3_fayda_pl21.Controls["txtveri2"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk5_3_fayda_pl26.Controls["txtveri3"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk5_3_fayda_pl22.Controls["txtveri4"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk5_3_fayda_pl23.Controls["txtveri5"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk5_3_fayda_pl27.Controls["txtveri6"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                risk5_3_fayda_pl32.Controls["txtveri7"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                risk5_3_fayda_pl33.Controls["txtveri8"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                risk5_3_fayda_pl34.Controls["txtveri9"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                risk5_3_fayda_pl37.Controls["txtveri10"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                risk5_3_fayda_pl38.Controls["txtveri11"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                risk5_3_fayda_pl39.Controls["txtveri12"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                risk5_3_fayda_pl42.Controls["txtveri13"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                risk5_3_fayda_pl43.Controls["txtveri14"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                risk5_3_fayda_pl44.Controls["txtveri15"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                risk5_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                risk5_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                risk5_3_fayda_pl35.Controls["txtf3sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                risk5_3_fayda_pl40.Controls["txtf4sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                risk5_3_fayda_pl45.Controls["txtf5sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                risk5_3_fayda_pl4.Controls["sonuc"].Text = risk5_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk5_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk5_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk5_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk5_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk5_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk5_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk5_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk5_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl44.Controls["txtveri15"].Text)));
                    risk5_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk5_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk5_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk5_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk5_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1>f5)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2>f5)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3>f5)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4>f5)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4)
                    {
                        büyükolanibul = f5;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk5_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk5_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk5_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk5_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk5_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk5_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk5_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk5_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk5_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31= new OleDbCommand("Select veri_13 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();
                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk5_3_fayda where Id=" + risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //risk5_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk5_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk5_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk5_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk5_3_fayda_pl44.Controls["txtveri15"].Text)));
                    risk5_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk5_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk5_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk5_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk5_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1 > f5)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2 > f5)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3 > f5)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4 > f5)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4)
                    {
                        büyükolanibul = f5;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk5_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk5_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk5_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk5_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk5_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk5_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk5_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk5_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk5_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk5_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk5_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk5_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //risk6_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk6_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk6_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk6_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk6_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk6_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk6_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk6_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk6_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk6_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk6_3_fayda_pl12.Controls["txtbaslik1"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk6_3_fayda_pl13.Controls["txtbaslik2"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                risk6_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk6_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk6_3_fayda_pl31.Controls["txtaltbaslik3"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk6_3_fayda_pl36.Controls["txtaltbaslik4"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk6_3_fayda_pl41.Controls["txtaltbaslik5"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk6_3_fayda_pl46.Controls["txtaltbaslik6"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk6_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk6_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk6_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk6_3_fayda_pl18.Controls["txtoran1"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk6_3_fayda_pl19.Controls["txtoran2"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk6_3_fayda_pl25.Controls["txtoran3"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk6_3_fayda_pl20.Controls["txtveri1"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk6_3_fayda_pl21.Controls["txtveri2"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk6_3_fayda_pl26.Controls["txtveri3"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk6_3_fayda_pl22.Controls["txtveri4"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk6_3_fayda_pl23.Controls["txtveri5"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                risk6_3_fayda_pl27.Controls["txtveri6"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                risk6_3_fayda_pl32.Controls["txtveri7"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                risk6_3_fayda_pl33.Controls["txtveri8"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                risk6_3_fayda_pl34.Controls["txtveri9"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                risk6_3_fayda_pl37.Controls["txtveri10"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                risk6_3_fayda_pl38.Controls["txtveri11"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                risk6_3_fayda_pl39.Controls["txtveri12"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                risk6_3_fayda_pl42.Controls["txtveri13"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                risk6_3_fayda_pl43.Controls["txtveri14"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                risk6_3_fayda_pl44.Controls["txtveri15"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                risk6_3_fayda_pl47.Controls["txtveri16"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                risk6_3_fayda_pl48.Controls["txtveri17"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                risk6_3_fayda_pl49.Controls["txtveri18"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                risk6_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                risk6_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                risk6_3_fayda_pl35.Controls["txtf3sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                risk6_3_fayda_pl40.Controls["txtf4sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                risk6_3_fayda_pl45.Controls["txtf5sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                risk6_3_fayda_pl50.Controls["txtf6sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                risk6_3_fayda_pl4.Controls["sonuc"].Text = risk6_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk6_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk6_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk6_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk6_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk6_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk6_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk6_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk6_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl49.Controls["txtveri18"].Text)));
                    risk6_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk6_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk6_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk6_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk6_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    risk6_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1 > f5 && f1>f6)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2 > f5 && f2>f6)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3 > f5 && f3>f6)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4 > f5 && f4>f6)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4 && f5>f6)
                    {
                        büyükolanibul = f5;
                    }
                    else if (f6 > f1 && f6 > f2 && f6 > f3 && f6 > f4 && f6 > f5)
                    {
                        büyükolanibul = f6;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk6_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", risk6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk6_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk6_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk6_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", risk6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", risk6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", risk6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", risk6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk6_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk6_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk6_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk6_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk6_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6= (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[10, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk6_3_fayda where Id=" + risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //risk6_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk6_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(risk6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk6_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk6_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(risk6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk6_3_fayda_pl49.Controls["txtveri18"].Text)));
                    risk6_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk6_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk6_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk6_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk6_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    risk6_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1 > f5 && f1 > f6)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2 > f5 && f2 > f6)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3 > f5 && f3 > f6)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4 > f5 && f4 > f6)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4 && f5 > f6)
                    {
                        büyükolanibul = f5;
                    }
                    else if (f6 > f1 && f6 > f2 && f6 > f3 && f6 > f4 && f6 > f5)
                    {
                        büyükolanibul = f6;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk6_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", risk6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk6_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk6_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk6_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", risk6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", risk6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", risk6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", risk6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk6_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk6_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk6_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk6_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk6_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk6_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk6_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk6_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //risk7_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void risk7_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void risk7_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void risk7_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //risk7_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void risk7_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void risk7_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void risk7_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //risk7_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void risk7_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                risk7_3_fayda_pl12.Controls["txtbaslik1"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                risk7_3_fayda_pl13.Controls["txtbaslik2"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                risk7_3_fayda_pl14.Controls["txtaltbaslik1"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                risk7_3_fayda_pl15.Controls["txtaltbaslik2"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                risk7_3_fayda_pl31.Controls["txtaltbaslik3"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                risk7_3_fayda_pl36.Controls["txtaltbaslik4"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                risk7_3_fayda_pl41.Controls["txtaltbaslik5"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                risk7_3_fayda_pl46.Controls["txtaltbaslik6"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                risk7_3_fayda_pl51.Controls["txtaltbaslik7"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                risk7_3_fayda_pl16.Controls["txtüstbaslik1"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                risk7_3_fayda_pl17.Controls["txtüstbaslik2"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                risk7_3_fayda_pl24.Controls["txtüstbaslik3"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                risk7_3_fayda_pl18.Controls["txtoran1"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                risk7_3_fayda_pl19.Controls["txtoran2"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                risk7_3_fayda_pl25.Controls["txtoran3"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                risk7_3_fayda_pl20.Controls["txtveri1"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                risk7_3_fayda_pl21.Controls["txtveri2"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                risk7_3_fayda_pl26.Controls["txtveri3"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                risk7_3_fayda_pl22.Controls["txtveri4"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                risk7_3_fayda_pl23.Controls["txtveri5"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                risk7_3_fayda_pl27.Controls["txtveri6"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                risk7_3_fayda_pl32.Controls["txtveri7"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                risk7_3_fayda_pl33.Controls["txtveri8"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                risk7_3_fayda_pl34.Controls["txtveri9"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                risk7_3_fayda_pl37.Controls["txtveri10"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                risk7_3_fayda_pl38.Controls["txtveri11"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                risk7_3_fayda_pl39.Controls["txtveri12"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                risk7_3_fayda_pl42.Controls["txtveri13"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                risk7_3_fayda_pl43.Controls["txtveri14"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                risk7_3_fayda_pl44.Controls["txtveri15"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                risk7_3_fayda_pl47.Controls["txtveri16"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                risk7_3_fayda_pl48.Controls["txtveri17"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                risk7_3_fayda_pl49.Controls["txtveri18"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                risk7_3_fayda_pl52.Controls["txtveri19"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                risk7_3_fayda_pl53.Controls["txtveri20"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                risk7_3_fayda_pl54.Controls["txtveri21"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                risk7_3_fayda_pl29.Controls["txtf1sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                risk7_3_fayda_pl30.Controls["txtf2sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                risk7_3_fayda_pl35.Controls["txtf3sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
                risk7_3_fayda_pl40.Controls["txtf4sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[40].Value.ToString();
                risk7_3_fayda_pl45.Controls["txtf5sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[41].Value.ToString();
                risk7_3_fayda_pl50.Controls["txtf6sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[42].Value.ToString();
                risk7_3_fayda_pl55.Controls["txtf7sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[43].Value.ToString();
                risk7_3_fayda_pl4.Controls["sonuc"].Text = risk7_3_fayda_dr1.CurrentRow.Cells[44].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //risk7_3_fayda formu kapatmak için oluşturulmuş button1
        private void risk7_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //risk7_3_fayda formu altaalmak için oluşturulmuş button2
        private void risk7_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //risk7_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void risk7_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //risk7_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void risk7_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl49.Controls["txtveri18"].Text)));
                    double f7 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl52.Controls["txtveri19"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl53.Controls["txtveri20"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl54.Controls["txtveri21"].Text)));
                    risk7_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk7_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk7_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk7_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk7_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    risk7_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    risk7_3_fayda_pl55.Controls["txtf7sonuc"].Text = f7.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1 > f5 && f1 > f6 && f1>f7)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2 > f5 && f2 > f6 && f2>f7)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3 > f5 && f3 > f6 && f3> f7)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4 > f5 && f4 > f6 && f4>f7)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4 && f5 > f6 && f5>f7)
                    {
                        büyükolanibul = f5;
                    }
                    else if (f6 > f1 && f6 > f2 && f6 > f3 && f6 > f4 && f6 > f5 && f6>f7)
                    {
                        büyükolanibul = f6;
                    }
                    else if (f7 > f1 && f7 > f2 && f7 > f3 && f7 > f4 && f7 > f5 && f7 > f6)
                    {
                        büyükolanibul = f7;
                    }
                    baglanti.Open();
                    string sorgu = "Insert into risk7_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,sonuc_7,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@sonuc_7,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", risk7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", risk7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", risk7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk7_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk7_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk7_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", risk7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", risk7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", risk7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", risk7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", risk7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", risk7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", risk7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", risk7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk7_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    risk7_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk7_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void risk7_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //risk7_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Risk Altında Karar Verme";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21= (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select sonuc_7 From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 5];
                sonuc7.Value2 = komut44.ExecuteScalar().ToString();

                for (int i = 1; i <= 2; i++)
                {
                    Microsoft.Office.Interop.Excel.Range alan3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, i];
                    alan3.Interior.Color = System.Drawing.Color.FromArgb(222, 150, 150);
                }

                Microsoft.Office.Interop.Excel.Range alan1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 1];
                alan1.Value2 = "En Büyük Fayda:";

                Microsoft.Office.Interop.Excel.Range alan2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[11, 3];
                alan2.Interior.Color = System.Drawing.Color.FromArgb(192, 192, 255);

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From risk7_3_fayda where Id=" + risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //risk7_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void risk7_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text));
                if (orantoplam == 1)
                {
                    double f1 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl49.Controls["txtveri18"].Text)));
                    double f7 = ((Convert.ToDouble(risk7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(risk7_3_fayda_pl52.Controls["txtveri19"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(risk7_3_fayda_pl53.Controls["txtveri20"].Text)) + (Convert.ToDouble(risk7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(risk7_3_fayda_pl54.Controls["txtveri21"].Text)));
                    risk7_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    risk7_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    risk7_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    risk7_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    risk7_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    risk7_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    risk7_3_fayda_pl55.Controls["txtf7sonuc"].Text = f7.ToString();
                    double büyükolanibul = 0;
                    if (f1 > f2 && f1 > f3 && f1 > f4 && f1 > f5 && f1 > f6 && f1 > f7)
                    {
                        büyükolanibul = f1;
                    }
                    else if (f2 > f1 && f2 > f3 && f2 > f4 && f2 > f5 && f2 > f6 && f2 > f7)
                    {
                        büyükolanibul = f2;
                    }
                    else if (f3 > f1 && f3 > f2 && f3 > f4 && f3 > f5 && f3 > f6 && f3 > f7)
                    {
                        büyükolanibul = f3;
                    }
                    else if (f4 > f1 && f4 > f2 && f4 > f3 && f4 > f5 && f4 > f6 && f4 > f7)
                    {
                        büyükolanibul = f4;
                    }
                    else if (f5 > f1 && f5 > f2 && f5 > f3 && f5 > f4 && f5 > f6 && f5 > f7)
                    {
                        büyükolanibul = f5;
                    }
                    else if (f6 > f1 && f6 > f2 && f6 > f3 && f6 > f4 && f6 > f5 && f6 > f7)
                    {
                        büyükolanibul = f6;
                    }
                    else if (f7 > f1 && f7 > f2 && f7 > f3 && f7 > f4 && f7 > f5 && f7 > f6)
                    {
                        büyükolanibul = f7;
                    }
                    baglanti.Open();
                    komut = new OleDbCommand("UPDATE risk7_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,sonuc_7=@sonuc_7,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", risk7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", risk7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", risk7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", risk7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", risk7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", risk7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", risk7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", risk7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", risk7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", risk7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", risk7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", risk7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", risk7_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", risk7_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", risk7_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", risk7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", risk7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", risk7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", risk7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", risk7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", risk7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", risk7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", risk7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", risk7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", risk7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", risk7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", risk7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", risk7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", risk7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", risk7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", risk7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", risk7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", risk7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", risk7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", risk7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", risk7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", risk7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", risk7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", risk7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", risk7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", risk7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", risk7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", risk7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    risk7_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    risk7_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 1 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //risk7_3_fayda silme yapmak için oluşturulmuş panel10
        private void risk7_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = risk7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from risk7_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            risk7_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //risk7_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void risk7_3_fayda_pl11_Click(object sender, EventArgs e)
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

        private void RiskAltındaKararVermeFayda_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                risk2_3_fayda();
                risk2_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                risk3_3_fayda();
                risk3_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                risk4_3_fayda();
                risk4_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                risk5_3_fayda();
                risk5_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                risk6_3_fayda();
                risk6_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                risk7_3_fayda();
                risk7_3_fayda_listele();
            }
        }
    }
}
