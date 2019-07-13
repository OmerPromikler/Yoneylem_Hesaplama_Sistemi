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
    public partial class BelirsizlikAltındaEsolasılıkFayda : Form
    {
        public BelirsizlikAltındaEsolasılıkFayda()
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

        //esolasılık2_3_fayda form nesneleri
        Panel esolasılık2_3_fayda_pl1 = new Panel();
        Panel esolasılık2_3_fayda_pl2 = new Panel();
        Panel esolasılık2_3_fayda_pl3 = new Panel();
        Panel esolasılık2_3_fayda_pl4 = new Panel();
        Panel esolasılık2_3_fayda_pl5 = new Panel();
        Panel esolasılık2_3_fayda_pl6 = new Panel();
        Panel esolasılık2_3_fayda_pl7 = new Panel();
        Panel esolasılık2_3_fayda_pl8 = new Panel();
        Panel esolasılık2_3_fayda_pl9 = new Panel();
        Panel esolasılık2_3_fayda_pl10 = new Panel();
        Panel esolasılık2_3_fayda_pl11 = new Panel();
        Panel esolasılık2_3_fayda_pl12 = new Panel();
        Panel esolasılık2_3_fayda_pl13 = new Panel();
        Panel esolasılık2_3_fayda_pl14 = new Panel();
        Panel esolasılık2_3_fayda_pl15 = new Panel();
        Panel esolasılık2_3_fayda_pl16 = new Panel();
        Panel esolasılık2_3_fayda_pl17 = new Panel();
        Panel esolasılık2_3_fayda_pl18 = new Panel();
        Panel esolasılık2_3_fayda_pl19 = new Panel();
        Panel esolasılık2_3_fayda_pl20 = new Panel();
        Panel esolasılık2_3_fayda_pl21 = new Panel();
        Panel esolasılık2_3_fayda_pl22 = new Panel();
        Panel esolasılık2_3_fayda_pl23 = new Panel();
        Panel esolasılık2_3_fayda_pl24 = new Panel();
        Panel esolasılık2_3_fayda_pl25 = new Panel();
        Panel esolasılık2_3_fayda_pl26 = new Panel();
        Panel esolasılık2_3_fayda_pl27 = new Panel();
        Panel esolasılık2_3_fayda_pl28 = new Panel();
        Panel esolasılık2_3_fayda_pl29 = new Panel();
        Panel esolasılık2_3_fayda_pl30 = new Panel();
        TabControl esolasılık2_3_fayda_tb1 = new TabControl();
        TabPage esolasılık2_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık2_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık2_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık2_3_fayda_txt_baslik1;
        TextBox esolasılık2_3_fayda_txt_baslik2;
        TextBox esolasılık2_3_fayda_txt_altbaslik1;
        TextBox esolasılık2_3_fayda_txt_altbaslik2;
        TextBox esolasılık2_3_fayda_txt_üstbaslik1;
        TextBox esolasılık2_3_fayda_txt_üstbaslik2;
        TextBox esolasılık2_3_fayda_txt_üstbaslik3;
        TextBox esolasılık2_3_fayda_txt_oran1;
        TextBox esolasılık2_3_fayda_txt_oran2;
        TextBox esolasılık2_3_fayda_txt_oran3;
        TextBox esolasılık2_3_fayda_txt_f1sonuc;
        TextBox esolasılık2_3_fayda_txt_f2sonuc;
        NumericUpDown esolasılık2_3_fayda_txt_veri1;
        NumericUpDown esolasılık2_3_fayda_txt_veri2;
        NumericUpDown esolasılık2_3_fayda_txt_veri3;
        NumericUpDown esolasılık2_3_fayda_txt_veri4;
        NumericUpDown esolasılık2_3_fayda_txt_veri5;
        NumericUpDown esolasılık2_3_fayda_txt_veri6;
        Label esolasılık2_3_fayda_sonucbaslik;
        Label esolasılık2_3_fayda_sonuc;
        Label esolasılık2_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık2_3_fayda_dr1 = new DataGridView();
        Button esolasılık2_3_fayda_btn1 = new Button();
        Button esolasılık2_3_fayda_btn2 = new Button();
        Button esolasılık2_3_fayda_btn3 = new Button();
        RichTextBox esolasılık2_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık3_3_fayda form nesneleri
        Panel esolasılık3_3_fayda_pl1 = new Panel();
        Panel esolasılık3_3_fayda_pl2 = new Panel();
        Panel esolasılık3_3_fayda_pl3 = new Panel();
        Panel esolasılık3_3_fayda_pl4 = new Panel();
        Panel esolasılık3_3_fayda_pl5 = new Panel();
        Panel esolasılık3_3_fayda_pl6 = new Panel();
        Panel esolasılık3_3_fayda_pl7 = new Panel();
        Panel esolasılık3_3_fayda_pl8 = new Panel();
        Panel esolasılık3_3_fayda_pl9 = new Panel();
        Panel esolasılık3_3_fayda_pl10 = new Panel();
        Panel esolasılık3_3_fayda_pl11 = new Panel();
        Panel esolasılık3_3_fayda_pl12 = new Panel();
        Panel esolasılık3_3_fayda_pl13 = new Panel();
        Panel esolasılık3_3_fayda_pl14 = new Panel();
        Panel esolasılık3_3_fayda_pl15 = new Panel();
        Panel esolasılık3_3_fayda_pl16 = new Panel();
        Panel esolasılık3_3_fayda_pl17 = new Panel();
        Panel esolasılık3_3_fayda_pl18 = new Panel();
        Panel esolasılık3_3_fayda_pl19 = new Panel();
        Panel esolasılık3_3_fayda_pl20 = new Panel();
        Panel esolasılık3_3_fayda_pl21 = new Panel();
        Panel esolasılık3_3_fayda_pl22 = new Panel();
        Panel esolasılık3_3_fayda_pl23 = new Panel();
        Panel esolasılık3_3_fayda_pl24 = new Panel();
        Panel esolasılık3_3_fayda_pl25 = new Panel();
        Panel esolasılık3_3_fayda_pl26 = new Panel();
        Panel esolasılık3_3_fayda_pl27 = new Panel();
        Panel esolasılık3_3_fayda_pl28 = new Panel();
        Panel esolasılık3_3_fayda_pl29 = new Panel();
        Panel esolasılık3_3_fayda_pl30 = new Panel();
        Panel esolasılık3_3_fayda_pl31 = new Panel();
        Panel esolasılık3_3_fayda_pl32 = new Panel();
        Panel esolasılık3_3_fayda_pl33 = new Panel();
        Panel esolasılık3_3_fayda_pl34 = new Panel();
        Panel esolasılık3_3_fayda_pl35 = new Panel();
        TabControl esolasılık3_3_fayda_tb1 = new TabControl();
        TabPage esolasılık3_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık3_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık3_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık3_3_fayda_txt_baslik1;
        TextBox esolasılık3_3_fayda_txt_baslik2;
        TextBox esolasılık3_3_fayda_txt_altbaslik1;
        TextBox esolasılık3_3_fayda_txt_altbaslik2;
        TextBox esolasılık3_3_fayda_txt_altbaslik3;
        TextBox esolasılık3_3_fayda_txt_üstbaslik1;
        TextBox esolasılık3_3_fayda_txt_üstbaslik2;
        TextBox esolasılık3_3_fayda_txt_üstbaslik3;
        TextBox esolasılık3_3_fayda_txt_oran1;
        TextBox esolasılık3_3_fayda_txt_oran2;
        TextBox esolasılık3_3_fayda_txt_oran3;
        TextBox esolasılık3_3_fayda_txt_f1sonuc;
        TextBox esolasılık3_3_fayda_txt_f2sonuc;
        TextBox esolasılık3_3_fayda_txt_f3sonuc;
        NumericUpDown esolasılık3_3_fayda_txt_veri1;
        NumericUpDown esolasılık3_3_fayda_txt_veri2;
        NumericUpDown esolasılık3_3_fayda_txt_veri3;
        NumericUpDown esolasılık3_3_fayda_txt_veri4;
        NumericUpDown esolasılık3_3_fayda_txt_veri5;
        NumericUpDown esolasılık3_3_fayda_txt_veri6;
        NumericUpDown esolasılık3_3_fayda_txt_veri7;
        NumericUpDown esolasılık3_3_fayda_txt_veri8;
        NumericUpDown esolasılık3_3_fayda_txt_veri9;
        Label esolasılık3_3_fayda_sonucbaslik;
        Label esolasılık3_3_fayda_sonuc;
        Label esolasılık3_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık3_3_fayda_dr1 = new DataGridView();
        Button esolasılık3_3_fayda_btn1 = new Button();
        Button esolasılık3_3_fayda_btn2 = new Button();
        Button esolasılık3_3_fayda_btn3 = new Button();
        RichTextBox esolasılık3_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık4_3_fayda form nesneleri
        Panel esolasılık4_3_fayda_pl1 = new Panel();
        Panel esolasılık4_3_fayda_pl2 = new Panel();
        Panel esolasılık4_3_fayda_pl3 = new Panel();
        Panel esolasılık4_3_fayda_pl4 = new Panel();
        Panel esolasılık4_3_fayda_pl5 = new Panel();
        Panel esolasılık4_3_fayda_pl6 = new Panel();
        Panel esolasılık4_3_fayda_pl7 = new Panel();
        Panel esolasılık4_3_fayda_pl8 = new Panel();
        Panel esolasılık4_3_fayda_pl9 = new Panel();
        Panel esolasılık4_3_fayda_pl10 = new Panel();
        Panel esolasılık4_3_fayda_pl11 = new Panel();
        Panel esolasılık4_3_fayda_pl12 = new Panel();
        Panel esolasılık4_3_fayda_pl13 = new Panel();
        Panel esolasılık4_3_fayda_pl14 = new Panel();
        Panel esolasılık4_3_fayda_pl15 = new Panel();
        Panel esolasılık4_3_fayda_pl16 = new Panel();
        Panel esolasılık4_3_fayda_pl17 = new Panel();
        Panel esolasılık4_3_fayda_pl18 = new Panel();
        Panel esolasılık4_3_fayda_pl19 = new Panel();
        Panel esolasılık4_3_fayda_pl20 = new Panel();
        Panel esolasılık4_3_fayda_pl21 = new Panel();
        Panel esolasılık4_3_fayda_pl22 = new Panel();
        Panel esolasılık4_3_fayda_pl23 = new Panel();
        Panel esolasılık4_3_fayda_pl24 = new Panel();
        Panel esolasılık4_3_fayda_pl25 = new Panel();
        Panel esolasılık4_3_fayda_pl26 = new Panel();
        Panel esolasılık4_3_fayda_pl27 = new Panel();
        Panel esolasılık4_3_fayda_pl28 = new Panel();
        Panel esolasılık4_3_fayda_pl29 = new Panel();
        Panel esolasılık4_3_fayda_pl30 = new Panel();
        Panel esolasılık4_3_fayda_pl31 = new Panel();
        Panel esolasılık4_3_fayda_pl32 = new Panel();
        Panel esolasılık4_3_fayda_pl33 = new Panel();
        Panel esolasılık4_3_fayda_pl34 = new Panel();
        Panel esolasılık4_3_fayda_pl35 = new Panel();
        Panel esolasılık4_3_fayda_pl36 = new Panel();
        Panel esolasılık4_3_fayda_pl37 = new Panel();
        Panel esolasılık4_3_fayda_pl38 = new Panel();
        Panel esolasılık4_3_fayda_pl39 = new Panel();
        Panel esolasılık4_3_fayda_pl40 = new Panel();
        TabControl esolasılık4_3_fayda_tb1 = new TabControl();
        TabPage esolasılık4_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık4_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık4_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık4_3_fayda_txt_baslik1;
        TextBox esolasılık4_3_fayda_txt_baslik2;
        TextBox esolasılık4_3_fayda_txt_altbaslik1;
        TextBox esolasılık4_3_fayda_txt_altbaslik2;
        TextBox esolasılık4_3_fayda_txt_altbaslik3;
        TextBox esolasılık4_3_fayda_txt_altbaslik4;
        TextBox esolasılık4_3_fayda_txt_üstbaslik1;
        TextBox esolasılık4_3_fayda_txt_üstbaslik2;
        TextBox esolasılık4_3_fayda_txt_üstbaslik3;
        TextBox esolasılık4_3_fayda_txt_oran1;
        TextBox esolasılık4_3_fayda_txt_oran2;
        TextBox esolasılık4_3_fayda_txt_oran3;
        TextBox esolasılık4_3_fayda_txt_f1sonuc;
        TextBox esolasılık4_3_fayda_txt_f2sonuc;
        TextBox esolasılık4_3_fayda_txt_f3sonuc;
        TextBox esolasılık4_3_fayda_txt_f4sonuc;
        NumericUpDown esolasılık4_3_fayda_txt_veri1;
        NumericUpDown esolasılık4_3_fayda_txt_veri2;
        NumericUpDown esolasılık4_3_fayda_txt_veri3;
        NumericUpDown esolasılık4_3_fayda_txt_veri4;
        NumericUpDown esolasılık4_3_fayda_txt_veri5;
        NumericUpDown esolasılık4_3_fayda_txt_veri6;
        NumericUpDown esolasılık4_3_fayda_txt_veri7;
        NumericUpDown esolasılık4_3_fayda_txt_veri8;
        NumericUpDown esolasılık4_3_fayda_txt_veri9;
        NumericUpDown esolasılık4_3_fayda_txt_veri10;
        NumericUpDown esolasılık4_3_fayda_txt_veri11;
        NumericUpDown esolasılık4_3_fayda_txt_veri12;
        Label esolasılık4_3_fayda_sonucbaslik;
        Label esolasılık4_3_fayda_sonuc;
        Label esolasılık4_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık4_3_fayda_dr1 = new DataGridView();
        Button esolasılık4_3_fayda_btn1 = new Button();
        Button esolasılık4_3_fayda_btn2 = new Button();
        Button esolasılık4_3_fayda_btn3 = new Button();
        RichTextBox esolasılık4_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık5_3_fayda form nesneleri
        Panel esolasılık5_3_fayda_pl1 = new Panel();
        Panel esolasılık5_3_fayda_pl2 = new Panel();
        Panel esolasılık5_3_fayda_pl3 = new Panel();
        Panel esolasılık5_3_fayda_pl4 = new Panel();
        Panel esolasılık5_3_fayda_pl5 = new Panel();
        Panel esolasılık5_3_fayda_pl6 = new Panel();
        Panel esolasılık5_3_fayda_pl7 = new Panel();
        Panel esolasılık5_3_fayda_pl8 = new Panel();
        Panel esolasılık5_3_fayda_pl9 = new Panel();
        Panel esolasılık5_3_fayda_pl10 = new Panel();
        Panel esolasılık5_3_fayda_pl11 = new Panel();
        Panel esolasılık5_3_fayda_pl12 = new Panel();
        Panel esolasılık5_3_fayda_pl13 = new Panel();
        Panel esolasılık5_3_fayda_pl14 = new Panel();
        Panel esolasılık5_3_fayda_pl15 = new Panel();
        Panel esolasılık5_3_fayda_pl16 = new Panel();
        Panel esolasılık5_3_fayda_pl17 = new Panel();
        Panel esolasılık5_3_fayda_pl18 = new Panel();
        Panel esolasılık5_3_fayda_pl19 = new Panel();
        Panel esolasılık5_3_fayda_pl20 = new Panel();
        Panel esolasılık5_3_fayda_pl21 = new Panel();
        Panel esolasılık5_3_fayda_pl22 = new Panel();
        Panel esolasılık5_3_fayda_pl23 = new Panel();
        Panel esolasılık5_3_fayda_pl24 = new Panel();
        Panel esolasılık5_3_fayda_pl25 = new Panel();
        Panel esolasılık5_3_fayda_pl26 = new Panel();
        Panel esolasılık5_3_fayda_pl27 = new Panel();
        Panel esolasılık5_3_fayda_pl28 = new Panel();
        Panel esolasılık5_3_fayda_pl29 = new Panel();
        Panel esolasılık5_3_fayda_pl30 = new Panel();
        Panel esolasılık5_3_fayda_pl31 = new Panel();
        Panel esolasılık5_3_fayda_pl32 = new Panel();
        Panel esolasılık5_3_fayda_pl33 = new Panel();
        Panel esolasılık5_3_fayda_pl34 = new Panel();
        Panel esolasılık5_3_fayda_pl35 = new Panel();
        Panel esolasılık5_3_fayda_pl36 = new Panel();
        Panel esolasılık5_3_fayda_pl37 = new Panel();
        Panel esolasılık5_3_fayda_pl38 = new Panel();
        Panel esolasılık5_3_fayda_pl39 = new Panel();
        Panel esolasılık5_3_fayda_pl40 = new Panel();
        Panel esolasılık5_3_fayda_pl41 = new Panel();
        Panel esolasılık5_3_fayda_pl42 = new Panel();
        Panel esolasılık5_3_fayda_pl43 = new Panel();
        Panel esolasılık5_3_fayda_pl44 = new Panel();
        Panel esolasılık5_3_fayda_pl45 = new Panel();
        TabControl esolasılık5_3_fayda_tb1 = new TabControl();
        TabPage esolasılık5_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık5_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık5_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık5_3_fayda_txt_baslik1;
        TextBox esolasılık5_3_fayda_txt_baslik2;
        TextBox esolasılık5_3_fayda_txt_altbaslik1;
        TextBox esolasılık5_3_fayda_txt_altbaslik2;
        TextBox esolasılık5_3_fayda_txt_altbaslik3;
        TextBox esolasılık5_3_fayda_txt_altbaslik4;
        TextBox esolasılık5_3_fayda_txt_altbaslik5;
        TextBox esolasılık5_3_fayda_txt_üstbaslik1;
        TextBox esolasılık5_3_fayda_txt_üstbaslik2;
        TextBox esolasılık5_3_fayda_txt_üstbaslik3;
        TextBox esolasılık5_3_fayda_txt_oran1;
        TextBox esolasılık5_3_fayda_txt_oran2;
        TextBox esolasılık5_3_fayda_txt_oran3;
        TextBox esolasılık5_3_fayda_txt_f1sonuc;
        TextBox esolasılık5_3_fayda_txt_f2sonuc;
        TextBox esolasılık5_3_fayda_txt_f3sonuc;
        TextBox esolasılık5_3_fayda_txt_f4sonuc;
        TextBox esolasılık5_3_fayda_txt_f5sonuc;
        NumericUpDown esolasılık5_3_fayda_txt_veri1;
        NumericUpDown esolasılık5_3_fayda_txt_veri2;
        NumericUpDown esolasılık5_3_fayda_txt_veri3;
        NumericUpDown esolasılık5_3_fayda_txt_veri4;
        NumericUpDown esolasılık5_3_fayda_txt_veri5;
        NumericUpDown esolasılık5_3_fayda_txt_veri6;
        NumericUpDown esolasılık5_3_fayda_txt_veri7;
        NumericUpDown esolasılık5_3_fayda_txt_veri8;
        NumericUpDown esolasılık5_3_fayda_txt_veri9;
        NumericUpDown esolasılık5_3_fayda_txt_veri10;
        NumericUpDown esolasılık5_3_fayda_txt_veri11;
        NumericUpDown esolasılık5_3_fayda_txt_veri12;
        NumericUpDown esolasılık5_3_fayda_txt_veri13;
        NumericUpDown esolasılık5_3_fayda_txt_veri14;
        NumericUpDown esolasılık5_3_fayda_txt_veri15;
        Label esolasılık5_3_fayda_sonucbaslik;
        Label esolasılık5_3_fayda_sonuc;
        Label esolasılık5_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık5_3_fayda_dr1 = new DataGridView();
        Button esolasılık5_3_fayda_btn1 = new Button();
        Button esolasılık5_3_fayda_btn2 = new Button();
        Button esolasılık5_3_fayda_btn3 = new Button();
        RichTextBox esolasılık5_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık6_3_fayda form nesneleri
        Panel esolasılık6_3_fayda_pl1 = new Panel();
        Panel esolasılık6_3_fayda_pl2 = new Panel();
        Panel esolasılık6_3_fayda_pl3 = new Panel();
        Panel esolasılık6_3_fayda_pl4 = new Panel();
        Panel esolasılık6_3_fayda_pl5 = new Panel();
        Panel esolasılık6_3_fayda_pl6 = new Panel();
        Panel esolasılık6_3_fayda_pl7 = new Panel();
        Panel esolasılık6_3_fayda_pl8 = new Panel();
        Panel esolasılık6_3_fayda_pl9 = new Panel();
        Panel esolasılık6_3_fayda_pl10 = new Panel();
        Panel esolasılık6_3_fayda_pl11 = new Panel();
        Panel esolasılık6_3_fayda_pl12 = new Panel();
        Panel esolasılık6_3_fayda_pl13 = new Panel();
        Panel esolasılık6_3_fayda_pl14 = new Panel();
        Panel esolasılık6_3_fayda_pl15 = new Panel();
        Panel esolasılık6_3_fayda_pl16 = new Panel();
        Panel esolasılık6_3_fayda_pl17 = new Panel();
        Panel esolasılık6_3_fayda_pl18 = new Panel();
        Panel esolasılık6_3_fayda_pl19 = new Panel();
        Panel esolasılık6_3_fayda_pl20 = new Panel();
        Panel esolasılık6_3_fayda_pl21 = new Panel();
        Panel esolasılık6_3_fayda_pl22 = new Panel();
        Panel esolasılık6_3_fayda_pl23 = new Panel();
        Panel esolasılık6_3_fayda_pl24 = new Panel();
        Panel esolasılık6_3_fayda_pl25 = new Panel();
        Panel esolasılık6_3_fayda_pl26 = new Panel();
        Panel esolasılık6_3_fayda_pl27 = new Panel();
        Panel esolasılık6_3_fayda_pl28 = new Panel();
        Panel esolasılık6_3_fayda_pl29 = new Panel();
        Panel esolasılık6_3_fayda_pl30 = new Panel();
        Panel esolasılık6_3_fayda_pl31 = new Panel();
        Panel esolasılık6_3_fayda_pl32 = new Panel();
        Panel esolasılık6_3_fayda_pl33 = new Panel();
        Panel esolasılık6_3_fayda_pl34 = new Panel();
        Panel esolasılık6_3_fayda_pl35 = new Panel();
        Panel esolasılık6_3_fayda_pl36 = new Panel();
        Panel esolasılık6_3_fayda_pl37 = new Panel();
        Panel esolasılık6_3_fayda_pl38 = new Panel();
        Panel esolasılık6_3_fayda_pl39 = new Panel();
        Panel esolasılık6_3_fayda_pl40 = new Panel();
        Panel esolasılık6_3_fayda_pl41 = new Panel();
        Panel esolasılık6_3_fayda_pl42 = new Panel();
        Panel esolasılık6_3_fayda_pl43 = new Panel();
        Panel esolasılık6_3_fayda_pl44 = new Panel();
        Panel esolasılık6_3_fayda_pl45 = new Panel();
        Panel esolasılık6_3_fayda_pl46 = new Panel();
        Panel esolasılık6_3_fayda_pl47 = new Panel();
        Panel esolasılık6_3_fayda_pl48 = new Panel();
        Panel esolasılık6_3_fayda_pl49 = new Panel();
        Panel esolasılık6_3_fayda_pl50 = new Panel();
        TabControl esolasılık6_3_fayda_tb1 = new TabControl();
        TabPage esolasılık6_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık6_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık6_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık6_3_fayda_txt_baslik1;
        TextBox esolasılık6_3_fayda_txt_baslik2;
        TextBox esolasılık6_3_fayda_txt_altbaslik1;
        TextBox esolasılık6_3_fayda_txt_altbaslik2;
        TextBox esolasılık6_3_fayda_txt_altbaslik3;
        TextBox esolasılık6_3_fayda_txt_altbaslik4;
        TextBox esolasılık6_3_fayda_txt_altbaslik5;
        TextBox esolasılık6_3_fayda_txt_altbaslik6;
        TextBox esolasılık6_3_fayda_txt_üstbaslik1;
        TextBox esolasılık6_3_fayda_txt_üstbaslik2;
        TextBox esolasılık6_3_fayda_txt_üstbaslik3;
        TextBox esolasılık6_3_fayda_txt_oran1;
        TextBox esolasılık6_3_fayda_txt_oran2;
        TextBox esolasılık6_3_fayda_txt_oran3;
        TextBox esolasılık6_3_fayda_txt_f1sonuc;
        TextBox esolasılık6_3_fayda_txt_f2sonuc;
        TextBox esolasılık6_3_fayda_txt_f3sonuc;
        TextBox esolasılık6_3_fayda_txt_f4sonuc;
        TextBox esolasılık6_3_fayda_txt_f5sonuc;
        TextBox esolasılık6_3_fayda_txt_f6sonuc;
        NumericUpDown esolasılık6_3_fayda_txt_veri1;
        NumericUpDown esolasılık6_3_fayda_txt_veri2;
        NumericUpDown esolasılık6_3_fayda_txt_veri3;
        NumericUpDown esolasılık6_3_fayda_txt_veri4;
        NumericUpDown esolasılık6_3_fayda_txt_veri5;
        NumericUpDown esolasılık6_3_fayda_txt_veri6;
        NumericUpDown esolasılık6_3_fayda_txt_veri7;
        NumericUpDown esolasılık6_3_fayda_txt_veri8;
        NumericUpDown esolasılık6_3_fayda_txt_veri9;
        NumericUpDown esolasılık6_3_fayda_txt_veri10;
        NumericUpDown esolasılık6_3_fayda_txt_veri11;
        NumericUpDown esolasılık6_3_fayda_txt_veri12;
        NumericUpDown esolasılık6_3_fayda_txt_veri13;
        NumericUpDown esolasılık6_3_fayda_txt_veri14;
        NumericUpDown esolasılık6_3_fayda_txt_veri15;
        NumericUpDown esolasılık6_3_fayda_txt_veri16;
        NumericUpDown esolasılık6_3_fayda_txt_veri17;
        NumericUpDown esolasılık6_3_fayda_txt_veri18;
        Label esolasılık6_3_fayda_sonucbaslik;
        Label esolasılık6_3_fayda_sonuc;
        Label esolasılık6_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık6_3_fayda_dr1 = new DataGridView();
        Button esolasılık6_3_fayda_btn1 = new Button();
        Button esolasılık6_3_fayda_btn2 = new Button();
        Button esolasılık6_3_fayda_btn3 = new Button();
        RichTextBox esolasılık6_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık7_3_fayda form nesneleri
        Panel esolasılık7_3_fayda_pl1 = new Panel();
        Panel esolasılık7_3_fayda_pl2 = new Panel();
        Panel esolasılık7_3_fayda_pl3 = new Panel();
        Panel esolasılık7_3_fayda_pl4 = new Panel();
        Panel esolasılık7_3_fayda_pl5 = new Panel();
        Panel esolasılık7_3_fayda_pl6 = new Panel();
        Panel esolasılık7_3_fayda_pl7 = new Panel();
        Panel esolasılık7_3_fayda_pl8 = new Panel();
        Panel esolasılık7_3_fayda_pl9 = new Panel();
        Panel esolasılık7_3_fayda_pl10 = new Panel();
        Panel esolasılık7_3_fayda_pl11 = new Panel();
        Panel esolasılık7_3_fayda_pl12 = new Panel();
        Panel esolasılık7_3_fayda_pl13 = new Panel();
        Panel esolasılık7_3_fayda_pl14 = new Panel();
        Panel esolasılık7_3_fayda_pl15 = new Panel();
        Panel esolasılık7_3_fayda_pl16 = new Panel();
        Panel esolasılık7_3_fayda_pl17 = new Panel();
        Panel esolasılık7_3_fayda_pl18 = new Panel();
        Panel esolasılık7_3_fayda_pl19 = new Panel();
        Panel esolasılık7_3_fayda_pl20 = new Panel();
        Panel esolasılık7_3_fayda_pl21 = new Panel();
        Panel esolasılık7_3_fayda_pl22 = new Panel();
        Panel esolasılık7_3_fayda_pl23 = new Panel();
        Panel esolasılık7_3_fayda_pl24 = new Panel();
        Panel esolasılık7_3_fayda_pl25 = new Panel();
        Panel esolasılık7_3_fayda_pl26 = new Panel();
        Panel esolasılık7_3_fayda_pl27 = new Panel();
        Panel esolasılık7_3_fayda_pl28 = new Panel();
        Panel esolasılık7_3_fayda_pl29 = new Panel();
        Panel esolasılık7_3_fayda_pl30 = new Panel();
        Panel esolasılık7_3_fayda_pl31 = new Panel();
        Panel esolasılık7_3_fayda_pl32 = new Panel();
        Panel esolasılık7_3_fayda_pl33 = new Panel();
        Panel esolasılık7_3_fayda_pl34 = new Panel();
        Panel esolasılık7_3_fayda_pl35 = new Panel();
        Panel esolasılık7_3_fayda_pl36 = new Panel();
        Panel esolasılık7_3_fayda_pl37 = new Panel();
        Panel esolasılık7_3_fayda_pl38 = new Panel();
        Panel esolasılık7_3_fayda_pl39 = new Panel();
        Panel esolasılık7_3_fayda_pl40 = new Panel();
        Panel esolasılık7_3_fayda_pl41 = new Panel();
        Panel esolasılık7_3_fayda_pl42 = new Panel();
        Panel esolasılık7_3_fayda_pl43 = new Panel();
        Panel esolasılık7_3_fayda_pl44 = new Panel();
        Panel esolasılık7_3_fayda_pl45 = new Panel();
        Panel esolasılık7_3_fayda_pl46 = new Panel();
        Panel esolasılık7_3_fayda_pl47 = new Panel();
        Panel esolasılık7_3_fayda_pl48 = new Panel();
        Panel esolasılık7_3_fayda_pl49 = new Panel();
        Panel esolasılık7_3_fayda_pl50 = new Panel();
        Panel esolasılık7_3_fayda_pl51 = new Panel();
        Panel esolasılık7_3_fayda_pl52 = new Panel();
        Panel esolasılık7_3_fayda_pl53 = new Panel();
        Panel esolasılık7_3_fayda_pl54 = new Panel();
        Panel esolasılık7_3_fayda_pl55 = new Panel();
        TabControl esolasılık7_3_fayda_tb1 = new TabControl();
        TabPage esolasılık7_3_fayda_tb1_1 = new TabPage();
        TabPage esolasılık7_3_fayda_tb1_2 = new TabPage();
        TabPage esolasılık7_3_fayda_tb1_3 = new TabPage();
        TextBox esolasılık7_3_fayda_txt_baslik1;
        TextBox esolasılık7_3_fayda_txt_baslik2;
        TextBox esolasılık7_3_fayda_txt_altbaslik1;
        TextBox esolasılık7_3_fayda_txt_altbaslik2;
        TextBox esolasılık7_3_fayda_txt_altbaslik3;
        TextBox esolasılık7_3_fayda_txt_altbaslik4;
        TextBox esolasılık7_3_fayda_txt_altbaslik5;
        TextBox esolasılık7_3_fayda_txt_altbaslik6;
        TextBox esolasılık7_3_fayda_txt_altbaslik7;
        TextBox esolasılık7_3_fayda_txt_üstbaslik1;
        TextBox esolasılık7_3_fayda_txt_üstbaslik2;
        TextBox esolasılık7_3_fayda_txt_üstbaslik3;
        TextBox esolasılık7_3_fayda_txt_oran1;
        TextBox esolasılık7_3_fayda_txt_oran2;
        TextBox esolasılık7_3_fayda_txt_oran3;
        TextBox esolasılık7_3_fayda_txt_f1sonuc;
        TextBox esolasılık7_3_fayda_txt_f2sonuc;
        TextBox esolasılık7_3_fayda_txt_f3sonuc;
        TextBox esolasılık7_3_fayda_txt_f4sonuc;
        TextBox esolasılık7_3_fayda_txt_f5sonuc;
        TextBox esolasılık7_3_fayda_txt_f6sonuc;
        TextBox esolasılık7_3_fayda_txt_f7sonuc;
        NumericUpDown esolasılık7_3_fayda_txt_veri1;
        NumericUpDown esolasılık7_3_fayda_txt_veri2;
        NumericUpDown esolasılık7_3_fayda_txt_veri3;
        NumericUpDown esolasılık7_3_fayda_txt_veri4;
        NumericUpDown esolasılık7_3_fayda_txt_veri5;
        NumericUpDown esolasılık7_3_fayda_txt_veri6;
        NumericUpDown esolasılık7_3_fayda_txt_veri7;
        NumericUpDown esolasılık7_3_fayda_txt_veri8;
        NumericUpDown esolasılık7_3_fayda_txt_veri9;
        NumericUpDown esolasılık7_3_fayda_txt_veri10;
        NumericUpDown esolasılık7_3_fayda_txt_veri11;
        NumericUpDown esolasılık7_3_fayda_txt_veri12;
        NumericUpDown esolasılık7_3_fayda_txt_veri13;
        NumericUpDown esolasılık7_3_fayda_txt_veri14;
        NumericUpDown esolasılık7_3_fayda_txt_veri15;
        NumericUpDown esolasılık7_3_fayda_txt_veri16;
        NumericUpDown esolasılık7_3_fayda_txt_veri17;
        NumericUpDown esolasılık7_3_fayda_txt_veri18;
        NumericUpDown esolasılık7_3_fayda_txt_veri19;
        NumericUpDown esolasılık7_3_fayda_txt_veri20;
        NumericUpDown esolasılık7_3_fayda_txt_veri21;
        Label esolasılık7_3_fayda_sonucbaslik;
        Label esolasılık7_3_fayda_sonuc;
        Label esolasılık7_3_fayda_sonuclarortabaslik;
        DataGridView esolasılık7_3_fayda_dr1 = new DataGridView();
        Button esolasılık7_3_fayda_btn1 = new Button();
        Button esolasılık7_3_fayda_btn2 = new Button();
        Button esolasılık7_3_fayda_btn3 = new Button();
        RichTextBox esolasılık7_3_fayda_rt1 = new RichTextBox();
        //-----------------------------------------

        //esolasılık2_3_fayda form nesne tasarımları
        public void esolasılık2_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık2_3_fayda_sonuc = new Label();
            esolasılık2_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık2_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık2_3_fayda_sonuc.Location = sonuc;
            esolasılık2_3_fayda_sonuc.Text = "";
            esolasılık2_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık2_3_fayda_pl4.Controls.Add(esolasılık2_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık2_3_fayda_sonucbaslik = new Label();
            esolasılık2_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık2_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık2_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık2_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık2_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık2_3_fayda_pl4.Controls.Add(esolasılık2_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık2_3_fayda_sonuclarortabaslik = new Label();
            esolasılık2_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık2_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık2_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık2_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık2_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık2_3_fayda_pl28.Controls.Add(esolasılık2_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık2_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl27.Controls.Add(esolasılık2_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık2_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl23.Controls.Add(esolasılık2_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık2_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl22.Controls.Add(esolasılık2_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık2_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl26.Controls.Add(esolasılık2_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık2_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl21.Controls.Add(esolasılık2_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık2_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık2_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık2_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık2_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık2_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl20.Controls.Add(esolasılık2_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık2_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık2_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık2_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık2_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık2_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık2_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl30.Controls.Add(esolasılık2_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık2_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık2_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık2_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık2_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık2_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık2_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık2_3_fayda_pl29.Controls.Add(esolasılık2_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık2_3_fayda_txt_oran3 = new TextBox();
            esolasılık2_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık2_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık2_3_fayda_txt_oran3.Text = "0,33";
            esolasılık2_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık2_3_fayda_txt_oran3.Multiline = true;
            esolasılık2_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl25.Controls.Add(esolasılık2_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık2_3_fayda_txt_oran2 = new TextBox();
            esolasılık2_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık2_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık2_3_fayda_txt_oran2.Text = "0,33";
            esolasılık2_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık2_3_fayda_txt_oran2.Multiline = true;
            esolasılık2_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl19.Controls.Add(esolasılık2_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık2_3_fayda_txt_oran1 = new TextBox();
            esolasılık2_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık2_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık2_3_fayda_txt_oran1.Text = "0,33";
            esolasılık2_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık2_3_fayda_txt_oran1.Multiline = true;
            esolasılık2_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl18.Controls.Add(esolasılık2_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık2_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık2_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık2_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık2_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık2_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık2_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık2_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl24.Controls.Add(esolasılık2_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık2_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık2_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık2_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık2_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık2_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık2_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık2_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl17.Controls.Add(esolasılık2_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık2_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık2_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık2_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık2_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık2_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık2_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık2_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık2_3_fayda_pl16.Controls.Add(esolasılık2_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık2_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık2_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık2_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık2_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık2_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık2_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık2_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık2_3_fayda_pl15.Controls.Add(esolasılık2_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık2_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık2_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık2_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık2_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık2_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık2_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık2_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık2_3_fayda_pl14.Controls.Add(esolasılık2_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık2_3_fayda_txt_baslik2 = new TextBox();
            esolasılık2_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık2_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık2_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık2_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık2_3_fayda_txt_baslik2.Multiline = true;
            esolasılık2_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık2_3_fayda_pl13.Controls.Add(esolasılık2_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık2_3_fayda_txt_baslik1 = new TextBox();
            esolasılık2_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık2_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık2_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık2_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık2_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık2_3_fayda_txt_baslik1.Multiline = true;
            esolasılık2_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık2_3_fayda_pl12.Controls.Add(esolasılık2_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık2_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık2_3_fayda_pl30.Location = pl30k;
            esolasılık2_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık2_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık2_3_fayda_pl29.Location = pl29k;
            esolasılık2_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık2_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık2_3_fayda_pl28.Location = pl28k;
            esolasılık2_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık2_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl28);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık2_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık2_3_fayda_pl27.Location = pl27k;
            esolasılık2_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık2_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık2_3_fayda_pl26.Location = pl26k;
            esolasılık2_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık2_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık2_3_fayda_pl23.Location = pl23k;
            esolasılık2_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık2_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık2_3_fayda_pl22.Location = pl22k;
            esolasılık2_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık2_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık2_3_fayda_pl21.Location = pl21k;
            esolasılık2_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık2_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık2_3_fayda_pl20.Location = pl20k;
            esolasılık2_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık2_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık2_3_fayda_pl25.Location = pl25k;
            esolasılık2_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık2_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık2_3_fayda_pl19.Location = pl19k;
            esolasılık2_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık2_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık2_3_fayda_pl18.Location = pl18k;
            esolasılık2_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık2_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık2_3_fayda_pl24.Location = pl24k;
            esolasılık2_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık2_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık2_3_fayda_pl17.Location = pl17k;
            esolasılık2_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık2_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık2_3_fayda_pl16.Location = pl16k;
            esolasılık2_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık2_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl16);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık2_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık2_3_fayda_pl15.Location = pl15k;
            esolasılık2_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık2_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık2_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık2_3_fayda_pl14.Location = pl14k;
            esolasılık2_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık2_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık2_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık2_3_fayda_pl13.Location = pl13k;
            esolasılık2_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık2_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık2_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık2_3_fayda_pl12.Location = pl12k;
            esolasılık2_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık2_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl5.Controls.Add(esolasılık2_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık2_3_fayda_pl11.Name = "pl11";
            esolasılık2_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık2_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık2_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık2_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık2_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl11.Click += new EventHandler(esolasılık2_3_fayda_pl11_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık2_3_fayda_pl10.Name = "pl10";
            esolasılık2_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık2_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık2_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık2_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık2_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl10.Click += new EventHandler(esolasılık2_3_fayda_pl10_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık2_3_fayda_pl9.Name = "pl9";
            esolasılık2_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık2_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık2_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık2_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık2_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl9.Click += new EventHandler(esolasılık2_3_fayda_pl9_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık2_3_fayda_pl8.Name = "pl8";
            esolasılık2_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık2_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık2_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık2_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık2_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl8.Click += new EventHandler(esolasılık2_3_fayda_pl8_Click);
            esolasılık2_3_fayda_pl7.Controls.Add(esolasılık2_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık2_3_fayda_pl6.Name = "pl6";
            esolasılık2_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık2_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık2_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık2_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık2_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl6.Click += new EventHandler(esolasılık2_3_fayda_pl6_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık2_3_fayda_btn3.Name = "btn3";
            esolasılık2_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık2_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık2_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık2_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık2_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık2_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_btn3.Click += new EventHandler(esolasılık2_3_fayda_btn3_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık2_3_fayda_btn2.Name = "btn2";
            esolasılık2_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık2_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık2_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık2_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık2_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık2_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık2_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık2_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_btn2.Click += new EventHandler(esolasılık2_3_fayda_btn2_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık2_3_fayda_btn1.Name = "btn1";
            esolasılık2_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık2_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık2_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık2_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık2_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık2_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık2_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık2_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_btn1.Click += new EventHandler(esolasılık2_3_fayda_btn1_Click);
            esolasılık2_3_fayda_pl2.Controls.Add(esolasılık2_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık2_3_fayda_dr1.Name = "dr1";
            esolasılık2_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık2_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık2_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık2_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık2_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık2_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık2_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık2_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık2_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık2_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık2_3_fayda_dr1_CellEnter);
            esolasılık2_3_fayda_tb1_2.Controls.Add(esolasılık2_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık2_3_fayda_pl7.Name = "pl7";
            esolasılık2_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık2_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık2_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_tb1_2.Controls.Add(esolasılık2_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık2_3_fayda_pl5.Name = "pl5";
            esolasılık2_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık2_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık2_3_fayda_pl5.AutoScroll = true;
            esolasılık2_3_fayda_pl5.AutoSize = true;
            esolasılık2_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık2_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_tb1_1.Controls.Add(esolasılık2_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık2_3_fayda_rt1.Name = "rt1";
            esolasılık2_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık2_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık2_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_rt1.Enabled = false;
            esolasılık2_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık2_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık2_3_fayda_tb1_3.Controls.Add(esolasılık2_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık2_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık2_3_fayda_tb1_1.Text = "Tablo";
            esolasılık2_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık2_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_tb1.Controls.Add(esolasılık2_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık2_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık2_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık2_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık2_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_tb1.Controls.Add(esolasılık2_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık2_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık2_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık2_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık2_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_tb1.Controls.Add(esolasılık2_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık2_3_fayda_tb1.Name = "tb1";
            esolasılık2_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık2_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık2_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık2_3_fayda_pl3.Controls.Add(esolasılık2_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık2_3_fayda_pl4.Name = "pl4";
            esolasılık2_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık2_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık2_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık2_3_fayda_pl4_MouseUp);
            esolasılık2_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık2_3_fayda_pl4_MouseMove);
            esolasılık2_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık2_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık2_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık2_3_fayda_pl3.Name = "pl3";
            esolasılık2_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık2_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık2_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık2_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık2_3_fayda_pl2.Name = "pl2";
            esolasılık2_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık2_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık2_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık2_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık2_3_fayda_pl1.Name = "pl1";
            esolasılık2_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık2_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık2_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık2_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık2_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık2_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık2_3_fayda_pl1_MouseUp);
            esolasılık2_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık2_3_fayda_pl1_MouseMove);
            esolasılık2_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık2_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık2_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık3_3_fayda form nesne tasarımları
        public void esolasılık3_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık3_3_fayda_sonuc = new Label();
            esolasılık3_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık3_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık3_3_fayda_sonuc.Location = sonuc;
            esolasılık3_3_fayda_sonuc.Text = "";
            esolasılık3_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık3_3_fayda_pl4.Controls.Add(esolasılık3_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık3_3_fayda_sonucbaslik = new Label();
            esolasılık3_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık3_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık3_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık3_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık3_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık3_3_fayda_pl4.Controls.Add(esolasılık3_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık3_3_fayda_sonuclarortabaslik = new Label();
            esolasılık3_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık3_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık3_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık3_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık3_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık3_3_fayda_pl28.Controls.Add(esolasılık3_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri9 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri9.Location = txt_veri9;
            esolasılık3_3_fayda_txt_veri9.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl34.Controls.Add(esolasılık3_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri8 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri8.Location = txt_veri8;
            esolasılık3_3_fayda_txt_veri8.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl33.Controls.Add(esolasılık3_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri7 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri7.Location = txt_veri7;
            esolasılık3_3_fayda_txt_veri7.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl32.Controls.Add(esolasılık3_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık3_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl27.Controls.Add(esolasılık3_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık3_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl23.Controls.Add(esolasılık3_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık3_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl22.Controls.Add(esolasılık3_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık3_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl26.Controls.Add(esolasılık3_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık3_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl21.Controls.Add(esolasılık3_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık3_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık3_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık3_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık3_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık3_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl20.Controls.Add(esolasılık3_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            esolasılık3_3_fayda_txt_f3sonuc = new TextBox();
            esolasılık3_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            esolasılık3_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            esolasılık3_3_fayda_txt_f3sonuc.Text = "0";
            esolasılık3_3_fayda_txt_f3sonuc.Enabled = false;
            esolasılık3_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl35.Controls.Add(esolasılık3_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık3_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık3_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık3_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık3_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık3_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık3_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl30.Controls.Add(esolasılık3_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık3_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık3_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık3_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık3_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık3_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık3_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık3_3_fayda_pl29.Controls.Add(esolasılık3_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık3_3_fayda_txt_oran3 = new TextBox();
            esolasılık3_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık3_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık3_3_fayda_txt_oran3.Text = "0,33";
            esolasılık3_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık3_3_fayda_txt_oran3.Multiline = true;
            esolasılık3_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl25.Controls.Add(esolasılık3_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık3_3_fayda_txt_oran2 = new TextBox();
            esolasılık3_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık3_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık3_3_fayda_txt_oran2.Text = "0,33";
            esolasılık3_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık3_3_fayda_txt_oran2.Multiline = true;
            esolasılık3_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl19.Controls.Add(esolasılık3_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık3_3_fayda_txt_oran1 = new TextBox();
            esolasılık3_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık3_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık3_3_fayda_txt_oran1.Text = "0,33";
            esolasılık3_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık3_3_fayda_txt_oran1.Multiline = true;
            esolasılık3_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl18.Controls.Add(esolasılık3_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık3_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık3_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık3_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık3_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık3_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık3_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık3_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl24.Controls.Add(esolasılık3_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık3_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık3_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık3_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık3_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık3_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık3_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık3_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl17.Controls.Add(esolasılık3_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık3_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık3_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık3_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık3_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık3_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık3_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık3_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık3_3_fayda_pl16.Controls.Add(esolasılık3_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            esolasılık3_3_fayda_txt_altbaslik3 = new TextBox();
            esolasılık3_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            esolasılık3_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            esolasılık3_3_fayda_txt_altbaslik3.Text = "F3";
            esolasılık3_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_altbaslik3.MaxLength = 30;
            esolasılık3_3_fayda_txt_altbaslik3.Multiline = true;
            esolasılık3_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            esolasılık3_3_fayda_pl31.Controls.Add(esolasılık3_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık3_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık3_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık3_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık3_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık3_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık3_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık3_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık3_3_fayda_pl15.Controls.Add(esolasılık3_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık3_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık3_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık3_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık3_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık3_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık3_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık3_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık3_3_fayda_pl14.Controls.Add(esolasılık3_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık3_3_fayda_txt_baslik2 = new TextBox();
            esolasılık3_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık3_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık3_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık3_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık3_3_fayda_txt_baslik2.Multiline = true;
            esolasılık3_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık3_3_fayda_pl13.Controls.Add(esolasılık3_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık3_3_fayda_txt_baslik1 = new TextBox();
            esolasılık3_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık3_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık3_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık3_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık3_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık3_3_fayda_txt_baslik1.Multiline = true;
            esolasılık3_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık3_3_fayda_pl12.Controls.Add(esolasılık3_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            esolasılık3_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            esolasılık3_3_fayda_pl35.Location = pl35k;
            esolasılık3_3_fayda_pl35.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık3_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık3_3_fayda_pl30.Location = pl30k;
            esolasılık3_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık3_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık3_3_fayda_pl29.Location = pl29k;
            esolasılık3_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık3_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık3_3_fayda_pl28.Location = pl28k;
            esolasılık3_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık3_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl28);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            esolasılık3_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            esolasılık3_3_fayda_pl34.Location = pl34k;
            esolasılık3_3_fayda_pl34.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            esolasılık3_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            esolasılık3_3_fayda_pl33.Location = pl33k;
            esolasılık3_3_fayda_pl33.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            esolasılık3_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            esolasılık3_3_fayda_pl32.Location = pl32k;
            esolasılık3_3_fayda_pl32.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık3_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık3_3_fayda_pl27.Location = pl27k;
            esolasılık3_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık3_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık3_3_fayda_pl26.Location = pl26k;
            esolasılık3_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık3_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık3_3_fayda_pl23.Location = pl23k;
            esolasılık3_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık3_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık3_3_fayda_pl22.Location = pl22k;
            esolasılık3_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık3_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık3_3_fayda_pl21.Location = pl21k;
            esolasılık3_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık3_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık3_3_fayda_pl20.Location = pl20k;
            esolasılık3_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık3_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık3_3_fayda_pl25.Location = pl25k;
            esolasılık3_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık3_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık3_3_fayda_pl19.Location = pl19k;
            esolasılık3_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık3_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık3_3_fayda_pl18.Location = pl18k;
            esolasılık3_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık3_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık3_3_fayda_pl24.Location = pl24k;
            esolasılık3_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık3_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık3_3_fayda_pl17.Location = pl17k;
            esolasılık3_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık3_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık3_3_fayda_pl16.Location = pl16k;
            esolasılık3_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık3_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl16);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            esolasılık3_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            esolasılık3_3_fayda_pl31.Location = pl31k;
            esolasılık3_3_fayda_pl31.Size = new Size(168, 33);
            esolasılık3_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık3_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık3_3_fayda_pl15.Location = pl15k;
            esolasılık3_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık3_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık3_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık3_3_fayda_pl14.Location = pl14k;
            esolasılık3_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık3_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık3_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık3_3_fayda_pl13.Location = pl13k;
            esolasılık3_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık3_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık3_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık3_3_fayda_pl12.Location = pl12k;
            esolasılık3_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık3_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl5.Controls.Add(esolasılık3_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık3_3_fayda_pl11.Name = "pl11";
            esolasılık3_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık3_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık3_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık3_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık3_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl11.Click += new EventHandler(esolasılık3_3_fayda_pl11_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık3_3_fayda_pl10.Name = "pl10";
            esolasılık3_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık3_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık3_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık3_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık3_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl10.Click += new EventHandler(esolasılık3_3_fayda_pl10_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık3_3_fayda_pl9.Name = "pl9";
            esolasılık3_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık3_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık3_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık3_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık3_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl9.Click += new EventHandler(esolasılık3_3_fayda_pl9_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık3_3_fayda_pl8.Name = "pl8";
            esolasılık3_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık3_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık3_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık3_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık3_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl8.Click += new EventHandler(esolasılık3_3_fayda_pl8_Click);
            esolasılık3_3_fayda_pl7.Controls.Add(esolasılık3_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık3_3_fayda_pl6.Name = "pl6";
            esolasılık3_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık3_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık3_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık3_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık3_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl6.Click += new EventHandler(esolasılık3_3_fayda_pl6_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık3_3_fayda_btn3.Name = "btn3";
            esolasılık3_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık3_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık3_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık3_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık3_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık3_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_btn3.Click += new EventHandler(esolasılık3_3_fayda_btn3_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık3_3_fayda_btn2.Name = "btn2";
            esolasılık3_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık3_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık3_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık3_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık3_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık3_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık3_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık3_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_btn2.Click += new EventHandler(esolasılık3_3_fayda_btn2_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık3_3_fayda_btn1.Name = "btn1";
            esolasılık3_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık3_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık3_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık3_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık3_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık3_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık3_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık3_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_btn1.Click += new EventHandler(esolasılık3_3_fayda_btn1_Click);
            esolasılık3_3_fayda_pl2.Controls.Add(esolasılık3_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık3_3_fayda_dr1.Name = "dr1";
            esolasılık3_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık3_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık3_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık3_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık3_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık3_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık3_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık3_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık3_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık3_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık3_3_fayda_dr1_CellEnter);
            esolasılık3_3_fayda_tb1_2.Controls.Add(esolasılık3_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık3_3_fayda_pl7.Name = "pl7";
            esolasılık3_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık3_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık3_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_tb1_2.Controls.Add(esolasılık3_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık3_3_fayda_pl5.Name = "pl5";
            esolasılık3_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık3_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık3_3_fayda_pl5.AutoScroll = true;
            esolasılık3_3_fayda_pl5.AutoSize = true;
            esolasılık3_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık3_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_tb1_1.Controls.Add(esolasılık3_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık3_3_fayda_rt1.Name = "rt1";
            esolasılık3_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık3_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık3_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_rt1.Enabled = false;
            esolasılık3_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık3_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık3_3_fayda_tb1_3.Controls.Add(esolasılık3_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık3_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık3_3_fayda_tb1_1.Text = "Tablo";
            esolasılık3_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık3_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_tb1.Controls.Add(esolasılık3_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık3_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık3_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık3_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık3_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_tb1.Controls.Add(esolasılık3_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık3_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık3_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık3_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık3_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_tb1.Controls.Add(esolasılık3_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık3_3_fayda_tb1.Name = "tb1";
            esolasılık3_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık3_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık3_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık3_3_fayda_pl3.Controls.Add(esolasılık3_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık3_3_fayda_pl4.Name = "pl4";
            esolasılık3_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık3_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık3_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık3_3_fayda_pl4_MouseUp);
            esolasılık3_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık3_3_fayda_pl4_MouseMove);
            esolasılık3_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık3_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık3_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık3_3_fayda_pl3.Name = "pl3";
            esolasılık3_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık3_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık3_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık3_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık3_3_fayda_pl2.Name = "pl2";
            esolasılık3_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık3_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık3_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık3_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık3_3_fayda_pl1.Name = "pl1";
            esolasılık3_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık3_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık3_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık3_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık3_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık3_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık3_3_fayda_pl1_MouseUp);
            esolasılık3_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık3_3_fayda_pl1_MouseMove);
            esolasılık3_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık3_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık3_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık4_3_fayda form nesne tasarımları
        public void esolasılık4_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık4_3_fayda_sonuc = new Label();
            esolasılık4_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık4_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık4_3_fayda_sonuc.Location = sonuc;
            esolasılık4_3_fayda_sonuc.Text = "";
            esolasılık4_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık4_3_fayda_pl4.Controls.Add(esolasılık4_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık4_3_fayda_sonucbaslik = new Label();
            esolasılık4_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık4_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık4_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık4_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık4_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık4_3_fayda_pl4.Controls.Add(esolasılık4_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık4_3_fayda_sonuclarortabaslik = new Label();
            esolasılık4_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık4_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık4_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık4_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık4_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık4_3_fayda_pl28.Controls.Add(esolasılık4_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri12 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri12.Location = txt_veri12;
            esolasılık4_3_fayda_txt_veri12.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl39.Controls.Add(esolasılık4_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri11 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri11.Location = txt_veri11;
            esolasılık4_3_fayda_txt_veri11.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl38.Controls.Add(esolasılık4_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri10 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri10.Location = txt_veri10;
            esolasılık4_3_fayda_txt_veri10.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl37.Controls.Add(esolasılık4_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri9 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri9.Location = txt_veri9;
            esolasılık4_3_fayda_txt_veri9.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl34.Controls.Add(esolasılık4_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri8 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri8.Location = txt_veri8;
            esolasılık4_3_fayda_txt_veri8.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl33.Controls.Add(esolasılık4_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri7 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri7.Location = txt_veri7;
            esolasılık4_3_fayda_txt_veri7.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl32.Controls.Add(esolasılık4_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık4_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl27.Controls.Add(esolasılık4_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık4_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl23.Controls.Add(esolasılık4_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık4_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl22.Controls.Add(esolasılık4_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık4_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl26.Controls.Add(esolasılık4_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık4_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl21.Controls.Add(esolasılık4_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık4_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık4_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık4_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık4_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık4_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl20.Controls.Add(esolasılık4_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            esolasılık4_3_fayda_txt_f4sonuc = new TextBox();
            esolasılık4_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            esolasılık4_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            esolasılık4_3_fayda_txt_f4sonuc.Text = "0";
            esolasılık4_3_fayda_txt_f4sonuc.Enabled = false;
            esolasılık4_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl40.Controls.Add(esolasılık4_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            esolasılık4_3_fayda_txt_f3sonuc = new TextBox();
            esolasılık4_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            esolasılık4_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            esolasılık4_3_fayda_txt_f3sonuc.Text = "0";
            esolasılık4_3_fayda_txt_f3sonuc.Enabled = false;
            esolasılık4_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl35.Controls.Add(esolasılık4_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık4_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık4_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık4_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık4_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık4_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık4_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl30.Controls.Add(esolasılık4_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık4_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık4_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık4_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık4_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık4_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık4_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık4_3_fayda_pl29.Controls.Add(esolasılık4_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık4_3_fayda_txt_oran3 = new TextBox();
            esolasılık4_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık4_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık4_3_fayda_txt_oran3.Text = "0,33";
            esolasılık4_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık4_3_fayda_txt_oran3.Multiline = true;
            esolasılık4_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl25.Controls.Add(esolasılık4_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık4_3_fayda_txt_oran2 = new TextBox();
            esolasılık4_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık4_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık4_3_fayda_txt_oran2.Text = "0,33";
            esolasılık4_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık4_3_fayda_txt_oran2.Multiline = true;
            esolasılık4_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl19.Controls.Add(esolasılık4_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık4_3_fayda_txt_oran1 = new TextBox();
            esolasılık4_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık4_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık4_3_fayda_txt_oran1.Text = "0,33";
            esolasılık4_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık4_3_fayda_txt_oran1.Multiline = true;
            esolasılık4_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl18.Controls.Add(esolasılık4_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık4_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık4_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık4_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık4_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık4_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık4_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık4_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl24.Controls.Add(esolasılık4_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık4_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık4_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık4_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık4_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık4_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık4_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık4_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl17.Controls.Add(esolasılık4_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık4_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık4_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık4_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık4_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık4_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık4_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık4_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık4_3_fayda_pl16.Controls.Add(esolasılık4_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            esolasılık4_3_fayda_txt_altbaslik4 = new TextBox();
            esolasılık4_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            esolasılık4_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            esolasılık4_3_fayda_txt_altbaslik4.Text = "F4";
            esolasılık4_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_altbaslik4.MaxLength = 30;
            esolasılık4_3_fayda_txt_altbaslik4.Multiline = true;
            esolasılık4_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl36.Controls.Add(esolasılık4_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            esolasılık4_3_fayda_txt_altbaslik3 = new TextBox();
            esolasılık4_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            esolasılık4_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            esolasılık4_3_fayda_txt_altbaslik3.Text = "F3";
            esolasılık4_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_altbaslik3.MaxLength = 30;
            esolasılık4_3_fayda_txt_altbaslik3.Multiline = true;
            esolasılık4_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl31.Controls.Add(esolasılık4_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık4_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık4_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık4_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık4_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık4_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık4_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık4_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl15.Controls.Add(esolasılık4_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık4_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık4_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık4_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık4_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık4_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık4_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık4_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl14.Controls.Add(esolasılık4_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık4_3_fayda_txt_baslik2 = new TextBox();
            esolasılık4_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık4_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık4_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık4_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık4_3_fayda_txt_baslik2.Multiline = true;
            esolasılık4_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl13.Controls.Add(esolasılık4_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık4_3_fayda_txt_baslik1 = new TextBox();
            esolasılık4_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık4_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık4_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık4_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık4_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık4_3_fayda_txt_baslik1.Multiline = true;
            esolasılık4_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık4_3_fayda_pl12.Controls.Add(esolasılık4_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            esolasılık4_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            esolasılık4_3_fayda_pl40.Location = pl40k;
            esolasılık4_3_fayda_pl40.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            esolasılık4_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            esolasılık4_3_fayda_pl35.Location = pl35k;
            esolasılık4_3_fayda_pl35.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık4_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık4_3_fayda_pl30.Location = pl30k;
            esolasılık4_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık4_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık4_3_fayda_pl29.Location = pl29k;
            esolasılık4_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık4_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık4_3_fayda_pl28.Location = pl28k;
            esolasılık4_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık4_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl28);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            esolasılık4_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            esolasılık4_3_fayda_pl39.Location = pl39k;
            esolasılık4_3_fayda_pl39.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            esolasılık4_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            esolasılık4_3_fayda_pl38.Location = pl38k;
            esolasılık4_3_fayda_pl38.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            esolasılık4_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            esolasılık4_3_fayda_pl37.Location = pl37k;
            esolasılık4_3_fayda_pl37.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            esolasılık4_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            esolasılık4_3_fayda_pl34.Location = pl34k;
            esolasılık4_3_fayda_pl34.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            esolasılık4_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            esolasılık4_3_fayda_pl33.Location = pl33k;
            esolasılık4_3_fayda_pl33.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            esolasılık4_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            esolasılık4_3_fayda_pl32.Location = pl32k;
            esolasılık4_3_fayda_pl32.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık4_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık4_3_fayda_pl27.Location = pl27k;
            esolasılık4_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık4_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık4_3_fayda_pl26.Location = pl26k;
            esolasılık4_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık4_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık4_3_fayda_pl23.Location = pl23k;
            esolasılık4_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık4_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık4_3_fayda_pl22.Location = pl22k;
            esolasılık4_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık4_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık4_3_fayda_pl21.Location = pl21k;
            esolasılık4_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık4_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık4_3_fayda_pl20.Location = pl20k;
            esolasılık4_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık4_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık4_3_fayda_pl25.Location = pl25k;
            esolasılık4_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık4_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık4_3_fayda_pl19.Location = pl19k;
            esolasılık4_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık4_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık4_3_fayda_pl18.Location = pl18k;
            esolasılık4_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık4_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık4_3_fayda_pl24.Location = pl24k;
            esolasılık4_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık4_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık4_3_fayda_pl17.Location = pl17k;
            esolasılık4_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık4_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık4_3_fayda_pl16.Location = pl16k;
            esolasılık4_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık4_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl16);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            esolasılık4_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            esolasılık4_3_fayda_pl36.Location = pl36k;
            esolasılık4_3_fayda_pl36.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            esolasılık4_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            esolasılık4_3_fayda_pl31.Location = pl31k;
            esolasılık4_3_fayda_pl31.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık4_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık4_3_fayda_pl15.Location = pl15k;
            esolasılık4_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık4_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık4_3_fayda_pl14.Location = pl14k;
            esolasılık4_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık4_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık4_3_fayda_pl13.Location = pl13k;
            esolasılık4_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık4_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık4_3_fayda_pl12.Location = pl12k;
            esolasılık4_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık4_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl5.Controls.Add(esolasılık4_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık4_3_fayda_pl11.Name = "pl11";
            esolasılık4_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık4_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık4_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık4_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık4_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl11.Click += new EventHandler(esolasılık4_3_fayda_pl11_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık4_3_fayda_pl10.Name = "pl10";
            esolasılık4_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık4_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık4_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık4_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık4_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl10.Click += new EventHandler(esolasılık4_3_fayda_pl10_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık4_3_fayda_pl9.Name = "pl9";
            esolasılık4_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık4_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık4_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık4_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık4_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl9.Click += new EventHandler(esolasılık4_3_fayda_pl9_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık4_3_fayda_pl8.Name = "pl8";
            esolasılık4_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık4_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık4_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık4_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık4_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl8.Click += new EventHandler(esolasılık4_3_fayda_pl8_Click);
            esolasılık4_3_fayda_pl7.Controls.Add(esolasılık4_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık4_3_fayda_pl6.Name = "pl6";
            esolasılık4_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık4_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık4_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık4_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık4_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl6.Click += new EventHandler(esolasılık4_3_fayda_pl6_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık4_3_fayda_btn3.Name = "btn3";
            esolasılık4_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık4_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık4_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık4_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık4_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık4_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_btn3.Click += new EventHandler(esolasılık4_3_fayda_btn3_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık4_3_fayda_btn2.Name = "btn2";
            esolasılık4_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık4_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık4_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık4_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık4_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık4_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık4_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık4_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_btn2.Click += new EventHandler(esolasılık4_3_fayda_btn2_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık4_3_fayda_btn1.Name = "btn1";
            esolasılık4_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık4_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık4_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık4_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık4_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık4_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık4_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık4_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_btn1.Click += new EventHandler(esolasılık4_3_fayda_btn1_Click);
            esolasılık4_3_fayda_pl2.Controls.Add(esolasılık4_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık4_3_fayda_dr1.Name = "dr1";
            esolasılık4_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık4_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık4_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık4_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık4_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık4_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık4_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık4_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık4_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık4_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık4_3_fayda_dr1_CellEnter);
            esolasılık4_3_fayda_tb1_2.Controls.Add(esolasılık4_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık4_3_fayda_pl7.Name = "pl7";
            esolasılık4_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık4_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık4_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_tb1_2.Controls.Add(esolasılık4_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık4_3_fayda_pl5.Name = "pl5";
            esolasılık4_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık4_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık4_3_fayda_pl5.AutoScroll = true;
            esolasılık4_3_fayda_pl5.AutoSize = true;
            esolasılık4_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık4_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_tb1_1.Controls.Add(esolasılık4_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık4_3_fayda_rt1.Name = "rt1";
            esolasılık4_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık4_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık4_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_rt1.Enabled = false;
            esolasılık4_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık4_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık4_3_fayda_tb1_3.Controls.Add(esolasılık4_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık4_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık4_3_fayda_tb1_1.Text = "Tablo";
            esolasılık4_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık4_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_tb1.Controls.Add(esolasılık4_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık4_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık4_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık4_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık4_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_tb1.Controls.Add(esolasılık4_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık4_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık4_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık4_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık4_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_tb1.Controls.Add(esolasılık4_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık4_3_fayda_tb1.Name = "tb1";
            esolasılık4_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık4_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık4_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık4_3_fayda_pl3.Controls.Add(esolasılık4_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık4_3_fayda_pl4.Name = "pl4";
            esolasılık4_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık4_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık4_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık4_3_fayda_pl4_MouseUp);
            esolasılık4_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık4_3_fayda_pl4_MouseMove);
            esolasılık4_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık4_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık4_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık4_3_fayda_pl3.Name = "pl3";
            esolasılık4_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık4_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık4_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık4_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık4_3_fayda_pl2.Name = "pl2";
            esolasılık4_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık4_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık4_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık4_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık4_3_fayda_pl1.Name = "pl1";
            esolasılık4_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık4_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık4_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık4_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık4_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık4_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık4_3_fayda_pl1_MouseUp);
            esolasılık4_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık4_3_fayda_pl1_MouseMove);
            esolasılık4_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık4_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık4_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık5_3_fayda form nesne tasarımları
        public void esolasılık5_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık5_3_fayda_sonuc = new Label();
            esolasılık5_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık5_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık5_3_fayda_sonuc.Location = sonuc;
            esolasılık5_3_fayda_sonuc.Text = "";
            esolasılık5_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık5_3_fayda_pl4.Controls.Add(esolasılık5_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık5_3_fayda_sonucbaslik = new Label();
            esolasılık5_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık5_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık5_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık5_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık5_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık5_3_fayda_pl4.Controls.Add(esolasılık5_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık5_3_fayda_sonuclarortabaslik = new Label();
            esolasılık5_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık5_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık5_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık5_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık5_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık5_3_fayda_pl28.Controls.Add(esolasılık5_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri15 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri15.Location = txt_veri15;
            esolasılık5_3_fayda_txt_veri15.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl44.Controls.Add(esolasılık5_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri14 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri14.Location = txt_veri14;
            esolasılık5_3_fayda_txt_veri14.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl43.Controls.Add(esolasılık5_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri13 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri13.Location = txt_veri13;
            esolasılık5_3_fayda_txt_veri13.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl42.Controls.Add(esolasılık5_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri12 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri12.Location = txt_veri12;
            esolasılık5_3_fayda_txt_veri12.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl39.Controls.Add(esolasılık5_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri11 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri11.Location = txt_veri11;
            esolasılık5_3_fayda_txt_veri11.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl38.Controls.Add(esolasılık5_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri10 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri10.Location = txt_veri10;
            esolasılık5_3_fayda_txt_veri10.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl37.Controls.Add(esolasılık5_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri9 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri9.Location = txt_veri9;
            esolasılık5_3_fayda_txt_veri9.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl34.Controls.Add(esolasılık5_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri8 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri8.Location = txt_veri8;
            esolasılık5_3_fayda_txt_veri8.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl33.Controls.Add(esolasılık5_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri7 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri7.Location = txt_veri7;
            esolasılık5_3_fayda_txt_veri7.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl32.Controls.Add(esolasılık5_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık5_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl27.Controls.Add(esolasılık5_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık5_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl23.Controls.Add(esolasılık5_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık5_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl22.Controls.Add(esolasılık5_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık5_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl26.Controls.Add(esolasılık5_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık5_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl21.Controls.Add(esolasılık5_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık5_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık5_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık5_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık5_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık5_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl20.Controls.Add(esolasılık5_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            esolasılık5_3_fayda_txt_f5sonuc = new TextBox();
            esolasılık5_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            esolasılık5_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            esolasılık5_3_fayda_txt_f5sonuc.Text = "0";
            esolasılık5_3_fayda_txt_f5sonuc.Enabled = false;
            esolasılık5_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl45.Controls.Add(esolasılık5_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            esolasılık5_3_fayda_txt_f4sonuc = new TextBox();
            esolasılık5_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            esolasılık5_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            esolasılık5_3_fayda_txt_f4sonuc.Text = "0";
            esolasılık5_3_fayda_txt_f4sonuc.Enabled = false;
            esolasılık5_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl40.Controls.Add(esolasılık5_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            esolasılık5_3_fayda_txt_f3sonuc = new TextBox();
            esolasılık5_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            esolasılık5_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            esolasılık5_3_fayda_txt_f3sonuc.Text = "0";
            esolasılık5_3_fayda_txt_f3sonuc.Enabled = false;
            esolasılık5_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl35.Controls.Add(esolasılık5_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık5_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık5_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık5_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık5_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık5_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık5_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl30.Controls.Add(esolasılık5_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık5_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık5_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık5_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık5_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık5_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık5_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık5_3_fayda_pl29.Controls.Add(esolasılık5_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık5_3_fayda_txt_oran3 = new TextBox();
            esolasılık5_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık5_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık5_3_fayda_txt_oran3.Text = "0,33";
            esolasılık5_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık5_3_fayda_txt_oran3.Multiline = true;
            esolasılık5_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl25.Controls.Add(esolasılık5_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık5_3_fayda_txt_oran2 = new TextBox();
            esolasılık5_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık5_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık5_3_fayda_txt_oran2.Text = "0,33";
            esolasılık5_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık5_3_fayda_txt_oran2.Multiline = true;
            esolasılık5_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl19.Controls.Add(esolasılık5_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık5_3_fayda_txt_oran1 = new TextBox();
            esolasılık5_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık5_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık5_3_fayda_txt_oran1.Text = "0,33";
            esolasılık5_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık5_3_fayda_txt_oran1.Multiline = true;
            esolasılık5_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl18.Controls.Add(esolasılık5_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık5_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık5_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık5_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık5_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık5_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık5_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık5_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl24.Controls.Add(esolasılık5_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık5_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık5_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık5_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık5_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık5_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık5_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık5_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl17.Controls.Add(esolasılık5_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık5_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık5_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık5_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık5_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık5_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık5_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık5_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık5_3_fayda_pl16.Controls.Add(esolasılık5_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            esolasılık5_3_fayda_txt_altbaslik5 = new TextBox();
            esolasılık5_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            esolasılık5_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            esolasılık5_3_fayda_txt_altbaslik5.Text = "F5";
            esolasılık5_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_altbaslik5.MaxLength = 30;
            esolasılık5_3_fayda_txt_altbaslik5.Multiline = true;
            esolasılık5_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl41.Controls.Add(esolasılık5_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            esolasılık5_3_fayda_txt_altbaslik4 = new TextBox();
            esolasılık5_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            esolasılık5_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            esolasılık5_3_fayda_txt_altbaslik4.Text = "F4";
            esolasılık5_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_altbaslik4.MaxLength = 30;
            esolasılık5_3_fayda_txt_altbaslik4.Multiline = true;
            esolasılık5_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl36.Controls.Add(esolasılık5_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            esolasılık5_3_fayda_txt_altbaslik3 = new TextBox();
            esolasılık5_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            esolasılık5_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            esolasılık5_3_fayda_txt_altbaslik3.Text = "F3";
            esolasılık5_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_altbaslik3.MaxLength = 30;
            esolasılık5_3_fayda_txt_altbaslik3.Multiline = true;
            esolasılık5_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl31.Controls.Add(esolasılık5_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık5_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık5_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık5_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık5_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık5_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık5_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık5_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl15.Controls.Add(esolasılık5_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık5_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık5_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık5_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık5_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık5_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık5_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık5_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl14.Controls.Add(esolasılık5_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık5_3_fayda_txt_baslik2 = new TextBox();
            esolasılık5_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık5_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık5_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık5_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık5_3_fayda_txt_baslik2.Multiline = true;
            esolasılık5_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl13.Controls.Add(esolasılık5_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık5_3_fayda_txt_baslik1 = new TextBox();
            esolasılık5_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık5_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık5_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık5_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık5_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık5_3_fayda_txt_baslik1.Multiline = true;
            esolasılık5_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık5_3_fayda_pl12.Controls.Add(esolasılık5_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            esolasılık5_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            esolasılık5_3_fayda_pl45.Location = pl45k;
            esolasılık5_3_fayda_pl45.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            esolasılık5_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            esolasılık5_3_fayda_pl40.Location = pl40k;
            esolasılık5_3_fayda_pl40.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            esolasılık5_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            esolasılık5_3_fayda_pl35.Location = pl35k;
            esolasılık5_3_fayda_pl35.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık5_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık5_3_fayda_pl30.Location = pl30k;
            esolasılık5_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık5_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık5_3_fayda_pl29.Location = pl29k;
            esolasılık5_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık5_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık5_3_fayda_pl28.Location = pl28k;
            esolasılık5_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık5_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl28);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            esolasılık5_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            esolasılık5_3_fayda_pl44.Location = pl44k;
            esolasılık5_3_fayda_pl44.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            esolasılık5_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            esolasılık5_3_fayda_pl43.Location = pl43k;
            esolasılık5_3_fayda_pl43.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            esolasılık5_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            esolasılık5_3_fayda_pl42.Location = pl42k;
            esolasılık5_3_fayda_pl42.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            esolasılık5_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            esolasılık5_3_fayda_pl39.Location = pl39k;
            esolasılık5_3_fayda_pl39.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            esolasılık5_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            esolasılık5_3_fayda_pl38.Location = pl38k;
            esolasılık5_3_fayda_pl38.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            esolasılık5_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            esolasılık5_3_fayda_pl37.Location = pl37k;
            esolasılık5_3_fayda_pl37.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            esolasılık5_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            esolasılık5_3_fayda_pl34.Location = pl34k;
            esolasılık5_3_fayda_pl34.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            esolasılık5_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            esolasılık5_3_fayda_pl33.Location = pl33k;
            esolasılık5_3_fayda_pl33.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            esolasılık5_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            esolasılık5_3_fayda_pl32.Location = pl32k;
            esolasılık5_3_fayda_pl32.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık5_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık5_3_fayda_pl27.Location = pl27k;
            esolasılık5_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık5_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık5_3_fayda_pl26.Location = pl26k;
            esolasılık5_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık5_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık5_3_fayda_pl23.Location = pl23k;
            esolasılık5_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık5_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık5_3_fayda_pl22.Location = pl22k;
            esolasılık5_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık5_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık5_3_fayda_pl21.Location = pl21k;
            esolasılık5_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık5_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık5_3_fayda_pl20.Location = pl20k;
            esolasılık5_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık5_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık5_3_fayda_pl25.Location = pl25k;
            esolasılık5_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık5_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık5_3_fayda_pl19.Location = pl19k;
            esolasılık5_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık5_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık5_3_fayda_pl18.Location = pl18k;
            esolasılık5_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık5_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık5_3_fayda_pl24.Location = pl24k;
            esolasılık5_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık5_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık5_3_fayda_pl17.Location = pl17k;
            esolasılık5_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık5_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık5_3_fayda_pl16.Location = pl16k;
            esolasılık5_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık5_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl16);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            esolasılık5_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            esolasılık5_3_fayda_pl41.Location = pl41k;
            esolasılık5_3_fayda_pl41.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            esolasılık5_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            esolasılık5_3_fayda_pl36.Location = pl36k;
            esolasılık5_3_fayda_pl36.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            esolasılık5_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            esolasılık5_3_fayda_pl31.Location = pl31k;
            esolasılık5_3_fayda_pl31.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık5_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık5_3_fayda_pl15.Location = pl15k;
            esolasılık5_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık5_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık5_3_fayda_pl14.Location = pl14k;
            esolasılık5_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık5_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık5_3_fayda_pl13.Location = pl13k;
            esolasılık5_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık5_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık5_3_fayda_pl12.Location = pl12k;
            esolasılık5_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık5_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl5.Controls.Add(esolasılık5_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık5_3_fayda_pl11.Name = "pl11";
            esolasılık5_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık5_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık5_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık5_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık5_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl11.Click += new EventHandler(esolasılık5_3_fayda_pl11_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık5_3_fayda_pl10.Name = "pl10";
            esolasılık5_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık5_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık5_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık5_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık5_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl10.Click += new EventHandler(esolasılık5_3_fayda_pl10_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık5_3_fayda_pl9.Name = "pl9";
            esolasılık5_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık5_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık5_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık5_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık5_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl9.Click += new EventHandler(esolasılık5_3_fayda_pl9_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık5_3_fayda_pl8.Name = "pl8";
            esolasılık5_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık5_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık5_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık5_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık5_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl8.Click += new EventHandler(esolasılık5_3_fayda_pl8_Click);
            esolasılık5_3_fayda_pl7.Controls.Add(esolasılık5_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık5_3_fayda_pl6.Name = "pl6";
            esolasılık5_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık5_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık5_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık5_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık5_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl6.Click += new EventHandler(esolasılık5_3_fayda_pl6_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık5_3_fayda_btn3.Name = "btn3";
            esolasılık5_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık5_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık5_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık5_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık5_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık5_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_btn3.Click += new EventHandler(esolasılık5_3_fayda_btn3_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık5_3_fayda_btn2.Name = "btn2";
            esolasılık5_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık5_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık5_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık5_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık5_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık5_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık5_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık5_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_btn2.Click += new EventHandler(esolasılık5_3_fayda_btn2_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık5_3_fayda_btn1.Name = "btn1";
            esolasılık5_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık5_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık5_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık5_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık5_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık5_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık5_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık5_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_btn1.Click += new EventHandler(esolasılık5_3_fayda_btn1_Click);
            esolasılık5_3_fayda_pl2.Controls.Add(esolasılık5_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık5_3_fayda_dr1.Name = "dr1";
            esolasılık5_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık5_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık5_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık5_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık5_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık5_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık5_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık5_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık5_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık5_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık5_3_fayda_dr1_CellEnter);
            esolasılık5_3_fayda_tb1_2.Controls.Add(esolasılık5_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık5_3_fayda_pl7.Name = "pl7";
            esolasılık5_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık5_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık5_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_tb1_2.Controls.Add(esolasılık5_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık5_3_fayda_pl5.Name = "pl5";
            esolasılık5_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık5_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık5_3_fayda_pl5.AutoScroll = true;
            esolasılık5_3_fayda_pl5.AutoSize = true;
            esolasılık5_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık5_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_tb1_1.Controls.Add(esolasılık5_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık5_3_fayda_rt1.Name = "rt1";
            esolasılık5_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık5_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık5_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_rt1.Enabled = false;
            esolasılık5_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık5_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık5_3_fayda_tb1_3.Controls.Add(esolasılık5_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık5_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık5_3_fayda_tb1_1.Text = "Tablo";
            esolasılık5_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık5_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_tb1.Controls.Add(esolasılık5_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık5_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık5_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık5_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık5_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_tb1.Controls.Add(esolasılık5_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık5_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık5_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık5_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık5_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_tb1.Controls.Add(esolasılık5_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık5_3_fayda_tb1.Name = "tb1";
            esolasılık5_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık5_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık5_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık5_3_fayda_pl3.Controls.Add(esolasılık5_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık5_3_fayda_pl4.Name = "pl4";
            esolasılık5_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık5_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık5_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık5_3_fayda_pl4_MouseUp);
            esolasılık5_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık5_3_fayda_pl4_MouseMove);
            esolasılık5_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık5_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık5_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık5_3_fayda_pl3.Name = "pl3";
            esolasılık5_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık5_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık5_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık5_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık5_3_fayda_pl2.Name = "pl2";
            esolasılık5_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık5_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık5_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık5_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık5_3_fayda_pl1.Name = "pl1";
            esolasılık5_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık5_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık5_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık5_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık5_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık5_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık5_3_fayda_pl1_MouseUp);
            esolasılık5_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık5_3_fayda_pl1_MouseMove);
            esolasılık5_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık5_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık5_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık6_3_fayda form nesne tasarımları
        public void esolasılık6_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık6_3_fayda_sonuc = new Label();
            esolasılık6_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık6_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık6_3_fayda_sonuc.Location = sonuc;
            esolasılık6_3_fayda_sonuc.Text = "";
            esolasılık6_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık6_3_fayda_pl4.Controls.Add(esolasılık6_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık6_3_fayda_sonucbaslik = new Label();
            esolasılık6_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık6_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık6_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık6_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık6_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık6_3_fayda_pl4.Controls.Add(esolasılık6_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık6_3_fayda_sonuclarortabaslik = new Label();
            esolasılık6_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık6_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık6_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık6_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık6_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık6_3_fayda_pl28.Controls.Add(esolasılık6_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri18 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri18.Location = txt_veri18;
            esolasılık6_3_fayda_txt_veri18.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl49.Controls.Add(esolasılık6_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri17 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri17.Location = txt_veri17;
            esolasılık6_3_fayda_txt_veri17.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl48.Controls.Add(esolasılık6_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri16 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri16.Location = txt_veri16;
            esolasılık6_3_fayda_txt_veri16.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl47.Controls.Add(esolasılık6_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri15 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri15.Location = txt_veri15;
            esolasılık6_3_fayda_txt_veri15.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl44.Controls.Add(esolasılık6_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri14 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri14.Location = txt_veri14;
            esolasılık6_3_fayda_txt_veri14.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl43.Controls.Add(esolasılık6_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri13 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri13.Location = txt_veri13;
            esolasılık6_3_fayda_txt_veri13.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl42.Controls.Add(esolasılık6_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri12 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri12.Location = txt_veri12;
            esolasılık6_3_fayda_txt_veri12.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl39.Controls.Add(esolasılık6_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri11 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri11.Location = txt_veri11;
            esolasılık6_3_fayda_txt_veri11.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl38.Controls.Add(esolasılık6_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri10 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri10.Location = txt_veri10;
            esolasılık6_3_fayda_txt_veri10.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl37.Controls.Add(esolasılık6_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri9 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri9.Location = txt_veri9;
            esolasılık6_3_fayda_txt_veri9.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl34.Controls.Add(esolasılık6_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri8 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri8.Location = txt_veri8;
            esolasılık6_3_fayda_txt_veri8.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl33.Controls.Add(esolasılık6_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri7 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri7.Location = txt_veri7;
            esolasılık6_3_fayda_txt_veri7.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl32.Controls.Add(esolasılık6_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık6_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl27.Controls.Add(esolasılık6_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık6_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl23.Controls.Add(esolasılık6_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık6_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl22.Controls.Add(esolasılık6_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık6_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl26.Controls.Add(esolasılık6_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık6_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl21.Controls.Add(esolasılık6_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık6_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık6_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık6_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık6_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık6_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl20.Controls.Add(esolasılık6_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f6sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            esolasılık6_3_fayda_txt_f6sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f6sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl50.Controls.Add(esolasılık6_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f5sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            esolasılık6_3_fayda_txt_f5sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f5sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl45.Controls.Add(esolasılık6_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f4sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            esolasılık6_3_fayda_txt_f4sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f4sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl40.Controls.Add(esolasılık6_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f3sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            esolasılık6_3_fayda_txt_f3sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f3sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl35.Controls.Add(esolasılık6_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık6_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl30.Controls.Add(esolasılık6_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık6_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık6_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık6_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık6_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık6_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık6_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık6_3_fayda_pl29.Controls.Add(esolasılık6_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık6_3_fayda_txt_oran3 = new TextBox();
            esolasılık6_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık6_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık6_3_fayda_txt_oran3.Text = "0,33";
            esolasılık6_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık6_3_fayda_txt_oran3.Multiline = true;
            esolasılık6_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl25.Controls.Add(esolasılık6_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık6_3_fayda_txt_oran2 = new TextBox();
            esolasılık6_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık6_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık6_3_fayda_txt_oran2.Text = "0,33";
            esolasılık6_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık6_3_fayda_txt_oran2.Multiline = true;
            esolasılık6_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl19.Controls.Add(esolasılık6_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık6_3_fayda_txt_oran1 = new TextBox();
            esolasılık6_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık6_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık6_3_fayda_txt_oran1.Text = "0,33";
            esolasılık6_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık6_3_fayda_txt_oran1.Multiline = true;
            esolasılık6_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl18.Controls.Add(esolasılık6_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık6_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık6_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık6_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık6_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık6_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık6_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık6_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl24.Controls.Add(esolasılık6_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık6_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık6_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık6_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık6_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık6_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık6_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık6_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl17.Controls.Add(esolasılık6_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık6_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık6_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık6_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık6_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık6_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık6_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık6_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık6_3_fayda_pl16.Controls.Add(esolasılık6_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik6 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            esolasılık6_3_fayda_txt_altbaslik6.Text = "F6";
            esolasılık6_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik6.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik6.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl46.Controls.Add(esolasılık6_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik5 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            esolasılık6_3_fayda_txt_altbaslik5.Text = "F5";
            esolasılık6_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik5.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik5.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl41.Controls.Add(esolasılık6_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik4 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            esolasılık6_3_fayda_txt_altbaslik4.Text = "F4";
            esolasılık6_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik4.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik4.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl36.Controls.Add(esolasılık6_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik3 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            esolasılık6_3_fayda_txt_altbaslik3.Text = "F3";
            esolasılık6_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik3.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik3.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl31.Controls.Add(esolasılık6_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık6_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık6_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl15.Controls.Add(esolasılık6_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık6_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık6_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık6_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık6_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık6_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık6_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık6_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl14.Controls.Add(esolasılık6_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık6_3_fayda_txt_baslik2 = new TextBox();
            esolasılık6_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık6_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık6_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık6_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık6_3_fayda_txt_baslik2.Multiline = true;
            esolasılık6_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl13.Controls.Add(esolasılık6_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık6_3_fayda_txt_baslik1 = new TextBox();
            esolasılık6_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık6_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık6_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık6_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık6_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık6_3_fayda_txt_baslik1.Multiline = true;
            esolasılık6_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık6_3_fayda_pl12.Controls.Add(esolasılık6_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            esolasılık6_3_fayda_pl50.Location = pl50k;
            esolasılık6_3_fayda_pl50.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            esolasılık6_3_fayda_pl45.Location = pl45k;
            esolasılık6_3_fayda_pl45.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            esolasılık6_3_fayda_pl40.Location = pl40k;
            esolasılık6_3_fayda_pl40.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            esolasılık6_3_fayda_pl35.Location = pl35k;
            esolasılık6_3_fayda_pl35.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık6_3_fayda_pl30.Location = pl30k;
            esolasılık6_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık6_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık6_3_fayda_pl29.Location = pl29k;
            esolasılık6_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık6_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık6_3_fayda_pl28.Location = pl28k;
            esolasılık6_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık6_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl28);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            esolasılık6_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            esolasılık6_3_fayda_pl49.Location = pl49k;
            esolasılık6_3_fayda_pl49.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            esolasılık6_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            esolasılık6_3_fayda_pl48.Location = pl48k;
            esolasılık6_3_fayda_pl48.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            esolasılık6_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            esolasılık6_3_fayda_pl47.Location = pl47k;
            esolasılık6_3_fayda_pl47.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            esolasılık6_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            esolasılık6_3_fayda_pl44.Location = pl44k;
            esolasılık6_3_fayda_pl44.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            esolasılık6_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            esolasılık6_3_fayda_pl43.Location = pl43k;
            esolasılık6_3_fayda_pl43.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            esolasılık6_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            esolasılık6_3_fayda_pl42.Location = pl42k;
            esolasılık6_3_fayda_pl42.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            esolasılık6_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            esolasılık6_3_fayda_pl39.Location = pl39k;
            esolasılık6_3_fayda_pl39.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            esolasılık6_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            esolasılık6_3_fayda_pl38.Location = pl38k;
            esolasılık6_3_fayda_pl38.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            esolasılık6_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            esolasılık6_3_fayda_pl37.Location = pl37k;
            esolasılık6_3_fayda_pl37.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            esolasılık6_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            esolasılık6_3_fayda_pl34.Location = pl34k;
            esolasılık6_3_fayda_pl34.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            esolasılık6_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            esolasılık6_3_fayda_pl33.Location = pl33k;
            esolasılık6_3_fayda_pl33.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            esolasılık6_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            esolasılık6_3_fayda_pl32.Location = pl32k;
            esolasılık6_3_fayda_pl32.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık6_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık6_3_fayda_pl27.Location = pl27k;
            esolasılık6_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık6_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık6_3_fayda_pl26.Location = pl26k;
            esolasılık6_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık6_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık6_3_fayda_pl23.Location = pl23k;
            esolasılık6_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık6_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık6_3_fayda_pl22.Location = pl22k;
            esolasılık6_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık6_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık6_3_fayda_pl21.Location = pl21k;
            esolasılık6_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık6_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık6_3_fayda_pl20.Location = pl20k;
            esolasılık6_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık6_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık6_3_fayda_pl25.Location = pl25k;
            esolasılık6_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık6_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık6_3_fayda_pl19.Location = pl19k;
            esolasılık6_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık6_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık6_3_fayda_pl18.Location = pl18k;
            esolasılık6_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık6_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık6_3_fayda_pl24.Location = pl24k;
            esolasılık6_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık6_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık6_3_fayda_pl17.Location = pl17k;
            esolasılık6_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık6_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık6_3_fayda_pl16.Location = pl16k;
            esolasılık6_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık6_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl16);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            esolasılık6_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            esolasılık6_3_fayda_pl46.Location = pl46k;
            esolasılık6_3_fayda_pl46.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            esolasılık6_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            esolasılık6_3_fayda_pl41.Location = pl41k;
            esolasılık6_3_fayda_pl41.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            esolasılık6_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            esolasılık6_3_fayda_pl36.Location = pl36k;
            esolasılık6_3_fayda_pl36.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            esolasılık6_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            esolasılık6_3_fayda_pl31.Location = pl31k;
            esolasılık6_3_fayda_pl31.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık6_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık6_3_fayda_pl15.Location = pl15k;
            esolasılık6_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık6_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık6_3_fayda_pl14.Location = pl14k;
            esolasılık6_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık6_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık6_3_fayda_pl13.Location = pl13k;
            esolasılık6_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık6_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık6_3_fayda_pl12.Location = pl12k;
            esolasılık6_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık6_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl5.Controls.Add(esolasılık6_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık6_3_fayda_pl11.Name = "pl11";
            esolasılık6_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık6_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık6_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık6_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık6_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl11.Click += new EventHandler(esolasılık6_3_fayda_pl11_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık6_3_fayda_pl10.Name = "pl10";
            esolasılık6_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık6_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık6_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık6_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık6_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl10.Click += new EventHandler(esolasılık6_3_fayda_pl10_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık6_3_fayda_pl9.Name = "pl9";
            esolasılık6_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık6_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık6_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık6_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık6_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl9.Click += new EventHandler(esolasılık6_3_fayda_pl9_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık6_3_fayda_pl8.Name = "pl8";
            esolasılık6_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık6_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık6_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık6_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık6_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl8.Click += new EventHandler(esolasılık6_3_fayda_pl8_Click);
            esolasılık6_3_fayda_pl7.Controls.Add(esolasılık6_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık6_3_fayda_pl6.Name = "pl6";
            esolasılık6_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık6_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık6_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık6_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık6_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl6.Click += new EventHandler(esolasılık6_3_fayda_pl6_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık6_3_fayda_btn3.Name = "btn3";
            esolasılık6_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık6_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık6_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık6_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık6_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık6_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_btn3.Click += new EventHandler(esolasılık6_3_fayda_btn3_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık6_3_fayda_btn2.Name = "btn2";
            esolasılık6_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık6_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık6_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık6_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık6_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık6_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık6_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık6_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_btn2.Click += new EventHandler(esolasılık6_3_fayda_btn2_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık6_3_fayda_btn1.Name = "btn1";
            esolasılık6_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık6_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık6_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık6_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık6_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık6_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık6_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık6_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_btn1.Click += new EventHandler(esolasılık6_3_fayda_btn1_Click);
            esolasılık6_3_fayda_pl2.Controls.Add(esolasılık6_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık6_3_fayda_dr1.Name = "dr1";
            esolasılık6_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık6_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık6_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık6_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık6_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık6_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık6_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık6_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık6_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık6_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık6_3_fayda_dr1_CellEnter);
            esolasılık6_3_fayda_tb1_2.Controls.Add(esolasılık6_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık6_3_fayda_pl7.Name = "pl7";
            esolasılık6_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık6_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık6_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_tb1_2.Controls.Add(esolasılık6_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık6_3_fayda_pl5.Name = "pl5";
            esolasılık6_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık6_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık6_3_fayda_pl5.AutoScroll = true;
            esolasılık6_3_fayda_pl5.AutoSize = true;
            esolasılık6_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık6_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_tb1_1.Controls.Add(esolasılık6_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık6_3_fayda_rt1.Name = "rt1";
            esolasılık6_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık6_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık6_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_rt1.Enabled = false;
            esolasılık6_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık6_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık6_3_fayda_tb1_3.Controls.Add(esolasılık6_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık6_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık6_3_fayda_tb1_1.Text = "Tablo";
            esolasılık6_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık6_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_tb1.Controls.Add(esolasılık6_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık6_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık6_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık6_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık6_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_tb1.Controls.Add(esolasılık6_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık6_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık6_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık6_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık6_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_tb1.Controls.Add(esolasılık6_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık6_3_fayda_tb1.Name = "tb1";
            esolasılık6_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık6_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık6_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık6_3_fayda_pl3.Controls.Add(esolasılık6_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık6_3_fayda_pl4.Name = "pl4";
            esolasılık6_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık6_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık6_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık6_3_fayda_pl4_MouseUp);
            esolasılık6_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık6_3_fayda_pl4_MouseMove);
            esolasılık6_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık6_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık6_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık6_3_fayda_pl3.Name = "pl3";
            esolasılık6_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık6_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık6_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık6_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık6_3_fayda_pl2.Name = "pl2";
            esolasılık6_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık6_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık6_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık6_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık6_3_fayda_pl1.Name = "pl1";
            esolasılık6_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık6_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık6_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık6_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık6_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık6_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık6_3_fayda_pl1_MouseUp);
            esolasılık6_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık6_3_fayda_pl1_MouseMove);
            esolasılık6_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık6_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık6_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık7_3_fayda form nesne tasarımları
        public void esolasılık7_3_fayda()
        {
            // panel4 içerisine Fayda sonucunu Label  olarak yerleştirir
            esolasılık7_3_fayda_sonuc = new Label();
            esolasılık7_3_fayda_sonuc.Name = "sonuc";
            Point sonuc = new Point(116, 17);
            esolasılık7_3_fayda_sonuc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık7_3_fayda_sonuc.Location = sonuc;
            esolasılık7_3_fayda_sonuc.Text = "";
            esolasılık7_3_fayda_sonuc.Size = new Size(650, 13);
            esolasılık7_3_fayda_pl4.Controls.Add(esolasılık7_3_fayda_sonuc);
            //---------------------------------------------------------------

            // panel4 içerisine En Büyük Fayda ismini Label  olarak yerleştirir
            esolasılık7_3_fayda_sonucbaslik = new Label();
            esolasılık7_3_fayda_sonucbaslik.Name = "sonucbaslik";
            Point sonucbaslik = new Point(27, 17);
            esolasılık7_3_fayda_sonucbaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık7_3_fayda_sonucbaslik.Location = sonucbaslik;
            esolasılık7_3_fayda_sonucbaslik.Text = "En Büyük Fayda:";
            esolasılık7_3_fayda_sonucbaslik.Size = new Size(88, 13);
            esolasılık7_3_fayda_pl4.Controls.Add(esolasılık7_3_fayda_sonucbaslik);
            //---------------------------------------------------------------

            // panel28 içerisine sonuçlar Label  olarak yerleştirir
            esolasılık7_3_fayda_sonuclarortabaslik = new Label();
            esolasılık7_3_fayda_sonuclarortabaslik.Name = "sonuclarortabasliklarortabaslik";
            Point sonuclarortabasliklarortabaslik = new Point(17, 29);
            esolasılık7_3_fayda_sonuclarortabaslik.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
            esolasılık7_3_fayda_sonuclarortabaslik.Location = sonuclarortabasliklarortabaslik;
            esolasılık7_3_fayda_sonuclarortabaslik.Text = "Sonuçlar";
            esolasılık7_3_fayda_sonuclarortabaslik.Size = new Size(49, 13);
            esolasılık7_3_fayda_pl28.Controls.Add(esolasılık7_3_fayda_sonuclarortabaslik);
            //---------------------------------------------------------------

            //panel54 içerisine veri-21 satır 9 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri21 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri21.Name = "txtveri21";
            Point txt_veri21 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri21.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri21.Location = txt_veri21;
            esolasılık7_3_fayda_txt_veri21.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl54.Controls.Add(esolasılık7_3_fayda_txt_veri21);
            //---------------------------------------------------------------

            //panel53 içerisine veri-20 satır 9 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri20 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri20.Name = "txtveri20";
            Point txt_veri20 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri20.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri20.Location = txt_veri20;
            esolasılık7_3_fayda_txt_veri20.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl53.Controls.Add(esolasılık7_3_fayda_txt_veri20);
            //---------------------------------------------------------------

            //panel52 içerisine veri-19 satır 9 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri19 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri19.Name = "txtveri19";
            Point txt_veri19 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri19.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri19.Location = txt_veri19;
            esolasılık7_3_fayda_txt_veri19.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl52.Controls.Add(esolasılık7_3_fayda_txt_veri19);
            //---------------------------------------------------------------

            //panel49 içerisine veri-18 satır 8 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri18 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri18.Name = "txtveri18";
            Point txt_veri18 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri18.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri18.Location = txt_veri18;
            esolasılık7_3_fayda_txt_veri18.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl49.Controls.Add(esolasılık7_3_fayda_txt_veri18);
            //---------------------------------------------------------------

            //panel48 içerisine veri-17 satır 8 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri17 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri17.Name = "txtveri17";
            Point txt_veri17 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri17.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri17.Location = txt_veri17;
            esolasılık7_3_fayda_txt_veri17.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl48.Controls.Add(esolasılık7_3_fayda_txt_veri17);
            //---------------------------------------------------------------

            //panel47 içerisine veri-16 satır 8 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri16 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri16.Name = "txtveri16";
            Point txt_veri16 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri16.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri16.Location = txt_veri16;
            esolasılık7_3_fayda_txt_veri16.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl47.Controls.Add(esolasılık7_3_fayda_txt_veri16);
            //---------------------------------------------------------------

            //panel44 içerisine veri-15 satır 7 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri15 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri15.Name = "txtveri15";
            Point txt_veri15 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri15.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri15.Location = txt_veri15;
            esolasılık7_3_fayda_txt_veri15.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl44.Controls.Add(esolasılık7_3_fayda_txt_veri15);
            //---------------------------------------------------------------


            //panel43 içerisine veri-14 satır 7 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri14 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri14.Name = "txtveri14";
            Point txt_veri14 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri14.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri14.Location = txt_veri14;
            esolasılık7_3_fayda_txt_veri14.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl43.Controls.Add(esolasılık7_3_fayda_txt_veri14);
            //---------------------------------------------------------------

            //panel42 içerisine veri-13 satır 7 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri13 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri13.Name = "txtveri13";
            Point txt_veri13 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri13.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri13.Location = txt_veri13;
            esolasılık7_3_fayda_txt_veri13.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl42.Controls.Add(esolasılık7_3_fayda_txt_veri13);
            //---------------------------------------------------------------

            //panel39 içerisine veri-12 satır 6 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri12 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri12.Name = "txtveri12";
            Point txt_veri12 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri12.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri12.Location = txt_veri12;
            esolasılık7_3_fayda_txt_veri12.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl39.Controls.Add(esolasılık7_3_fayda_txt_veri12);
            //---------------------------------------------------------------

            //panel38 içerisine veri-11 satır 6 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri11 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri11.Name = "txtveri11";
            Point txt_veri11 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri11.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri11.Location = txt_veri11;
            esolasılık7_3_fayda_txt_veri11.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl38.Controls.Add(esolasılık7_3_fayda_txt_veri11);
            //---------------------------------------------------------------

            //panel37 içerisine veri-10 satır 6 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri10 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri10.Name = "txtveri10";
            Point txt_veri10 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri10.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri10.Location = txt_veri10;
            esolasılık7_3_fayda_txt_veri10.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl37.Controls.Add(esolasılık7_3_fayda_txt_veri10);
            //---------------------------------------------------------------

            //panel34 içerisine veri-9 satır 5 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri9 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri9.Name = "txtveri9";
            Point txt_veri9 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri9.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri9.Location = txt_veri9;
            esolasılık7_3_fayda_txt_veri9.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl34.Controls.Add(esolasılık7_3_fayda_txt_veri9);
            //---------------------------------------------------------------

            //panel33 içerisine veri-8 satır 5 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri8 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri8.Name = "txtveri8";
            Point txt_veri8 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri8.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri8.Location = txt_veri8;
            esolasılık7_3_fayda_txt_veri8.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl33.Controls.Add(esolasılık7_3_fayda_txt_veri8);
            //---------------------------------------------------------------

            //panel32 içerisine veri-7 satır 5 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri7 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri7.Name = "txtveri7";
            Point txt_veri7 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri7.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri7.Location = txt_veri7;
            esolasılık7_3_fayda_txt_veri7.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl32.Controls.Add(esolasılık7_3_fayda_txt_veri7);
            //---------------------------------------------------------------

            //panel27 içerisine veri-6 satır 4 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri6 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri6.Name = "txtveri6";
            Point txt_veri6 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri6.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri6.Location = txt_veri6;
            esolasılık7_3_fayda_txt_veri6.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl27.Controls.Add(esolasılık7_3_fayda_txt_veri6);
            //---------------------------------------------------------------

            //panel23 içerisine veri-5 satır 4 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri5 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri5.Name = "txtveri5";
            Point txt_veri5 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri5.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri5.Location = txt_veri5;
            esolasılık7_3_fayda_txt_veri5.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl23.Controls.Add(esolasılık7_3_fayda_txt_veri5);
            //---------------------------------------------------------------

            //panel22 içerisine veri-4 satır 4 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri4 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri4.Name = "txtveri4";
            Point txt_veri4 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri4.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri4.Location = txt_veri4;
            esolasılık7_3_fayda_txt_veri4.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl22.Controls.Add(esolasılık7_3_fayda_txt_veri4);
            //---------------------------------------------------------------

            //panel26 içerisine veri-3 satır 3 - sütun 4 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri3 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri3.Name = "txtveri3";
            Point txt_veri3 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri3.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri3.Location = txt_veri3;
            esolasılık7_3_fayda_txt_veri3.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl26.Controls.Add(esolasılık7_3_fayda_txt_veri3);
            //---------------------------------------------------------------

            //panel21 içerisine veri-2 satır 3 - sütun 3 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri2 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri2.Name = "txtveri2";
            Point txt_veri2 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri2.Location = txt_veri2;
            esolasılık7_3_fayda_txt_veri2.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl21.Controls.Add(esolasılık7_3_fayda_txt_veri2);
            //---------------------------------------------------------------

            //panel20 içerisine veri-1 satır 3 - sütun 2 numeric textbox  yerleştirir
            esolasılık7_3_fayda_txt_veri1 = new NumericUpDown();
            esolasılık7_3_fayda_txt_veri1.Name = "txtveri1";
            Point txt_veri1 = new Point(3, 7);
            esolasılık7_3_fayda_txt_veri1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            esolasılık7_3_fayda_txt_veri1.Location = txt_veri1;
            esolasılık7_3_fayda_txt_veri1.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl20.Controls.Add(esolasılık7_3_fayda_txt_veri1);
            //---------------------------------------------------------------

            //panel55 içerisine f7sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f7sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f7sonuc.Name = "txtf7sonuc";
            Point txt_txtf7sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f7sonuc.Location = txt_txtf7sonuc;
            esolasılık7_3_fayda_txt_f7sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f7sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f7sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl55.Controls.Add(esolasılık7_3_fayda_txt_f7sonuc);
            //---------------------------------------------------------------

            //panel50 içerisine f6sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f6sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f6sonuc.Name = "txtf6sonuc";
            Point txt_txtf6sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f6sonuc.Location = txt_txtf6sonuc;
            esolasılık7_3_fayda_txt_f6sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f6sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f6sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl50.Controls.Add(esolasılık7_3_fayda_txt_f6sonuc);
            //---------------------------------------------------------------

            //panel45 içerisine f5sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f5sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f5sonuc.Name = "txtf5sonuc";
            Point txt_txtf5sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f5sonuc.Location = txt_txtf5sonuc;
            esolasılık7_3_fayda_txt_f5sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f5sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f5sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl45.Controls.Add(esolasılık7_3_fayda_txt_f5sonuc);
            //---------------------------------------------------------------

            //panel40 içerisine f4sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f4sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f4sonuc.Name = "txtf4sonuc";
            Point txt_txtf4sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f4sonuc.Location = txt_txtf4sonuc;
            esolasılık7_3_fayda_txt_f4sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f4sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f4sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl40.Controls.Add(esolasılık7_3_fayda_txt_f4sonuc);
            //---------------------------------------------------------------

            //panel35 içerisine f3sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f3sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f3sonuc.Name = "txtf3sonuc";
            Point txt_txtf3sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f3sonuc.Location = txt_txtf3sonuc;
            esolasılık7_3_fayda_txt_f3sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f3sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f3sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl35.Controls.Add(esolasılık7_3_fayda_txt_f3sonuc);
            //---------------------------------------------------------------

            //panel30 içerisine f2sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f2sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f2sonuc.Name = "txtf2sonuc";
            Point txt_txtf2sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f2sonuc.Location = txt_txtf2sonuc;
            esolasılık7_3_fayda_txt_f2sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f2sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f2sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl30.Controls.Add(esolasılık7_3_fayda_txt_f2sonuc);
            //---------------------------------------------------------------

            //panel29 içerisine f1sonuc textbox  yerleştirir
            esolasılık7_3_fayda_txt_f1sonuc = new TextBox();
            esolasılık7_3_fayda_txt_f1sonuc.Name = "txtf1sonuc";
            Point txt_txtf1sonuc = new Point(3, 7);
            esolasılık7_3_fayda_txt_f1sonuc.Location = txt_txtf1sonuc;
            esolasılık7_3_fayda_txt_f1sonuc.Text = "0";
            esolasılık7_3_fayda_txt_f1sonuc.Enabled = false;
            esolasılık7_3_fayda_txt_f1sonuc.Size = new Size(85, 20);
            esolasılık7_3_fayda_pl29.Controls.Add(esolasılık7_3_fayda_txt_f1sonuc);
            //---------------------------------------------------------------

            //panel25 içerisine oran-3 textbox  yerleştirir
            esolasılık7_3_fayda_txt_oran3 = new TextBox();
            esolasılık7_3_fayda_txt_oran3.Name = "txtoran3";
            Point txt_txtoran3 = new Point(3, 10);
            esolasılık7_3_fayda_txt_oran3.Location = txt_txtoran3;
            esolasılık7_3_fayda_txt_oran3.Text = "0,33";
            esolasılık7_3_fayda_txt_oran3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_oran3.MaxLength = 30;
            esolasılık7_3_fayda_txt_oran3.Multiline = true;
            esolasılık7_3_fayda_txt_oran3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_oran3.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl25.Controls.Add(esolasılık7_3_fayda_txt_oran3);
            //---------------------------------------------------------------

            //panel19 içerisine oran-2 textbox  yerleştirir
            esolasılık7_3_fayda_txt_oran2 = new TextBox();
            esolasılık7_3_fayda_txt_oran2.Name = "txtoran2";
            Point txt_txtoran2 = new Point(3, 10);
            esolasılık7_3_fayda_txt_oran2.Location = txt_txtoran2;
            esolasılık7_3_fayda_txt_oran2.Text = "0,33";
            esolasılık7_3_fayda_txt_oran2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_oran2.MaxLength = 30;
            esolasılık7_3_fayda_txt_oran2.Multiline = true;
            esolasılık7_3_fayda_txt_oran2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_oran2.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl19.Controls.Add(esolasılık7_3_fayda_txt_oran2);
            //---------------------------------------------------------------

            //panel18 içerisine oran-1 textbox  yerleştirir
            esolasılık7_3_fayda_txt_oran1 = new TextBox();
            esolasılık7_3_fayda_txt_oran1.Name = "txtoran1";
            Point txt_txtoran1 = new Point(3, 10);
            esolasılık7_3_fayda_txt_oran1.Location = txt_txtoran1;
            esolasılık7_3_fayda_txt_oran1.Text = "0,33";
            esolasılık7_3_fayda_txt_oran1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_oran1.MaxLength = 30;
            esolasılık7_3_fayda_txt_oran1.Multiline = true;
            esolasılık7_3_fayda_txt_oran1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_oran1.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl18.Controls.Add(esolasılık7_3_fayda_txt_oran1);
            //---------------------------------------------------------------

            //panel24 içerisine üstbaslik-3 textbox  yerleştirir
            esolasılık7_3_fayda_txt_üstbaslik3 = new TextBox();
            esolasılık7_3_fayda_txt_üstbaslik3.Name = "txtüstbaslik3";
            Point txt_txtüstbaslik3 = new Point(3, 10);
            esolasılık7_3_fayda_txt_üstbaslik3.Location = txt_txtüstbaslik3;
            esolasılık7_3_fayda_txt_üstbaslik3.Text = "Yüksek";
            esolasılık7_3_fayda_txt_üstbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_üstbaslik3.MaxLength = 30;
            esolasılık7_3_fayda_txt_üstbaslik3.Multiline = true;
            esolasılık7_3_fayda_txt_üstbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_üstbaslik3.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl24.Controls.Add(esolasılık7_3_fayda_txt_üstbaslik3);
            //---------------------------------------------------------------

            //panel17 içerisine üstbaslik-2 textbox  yerleştirir
            esolasılık7_3_fayda_txt_üstbaslik2 = new TextBox();
            esolasılık7_3_fayda_txt_üstbaslik2.Name = "txtüstbaslik2";
            Point txt_txtüstbaslik2 = new Point(3, 10);
            esolasılık7_3_fayda_txt_üstbaslik2.Location = txt_txtüstbaslik2;
            esolasılık7_3_fayda_txt_üstbaslik2.Text = "Orta";
            esolasılık7_3_fayda_txt_üstbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_üstbaslik2.MaxLength = 30;
            esolasılık7_3_fayda_txt_üstbaslik2.Multiline = true;
            esolasılık7_3_fayda_txt_üstbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_üstbaslik2.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl17.Controls.Add(esolasılık7_3_fayda_txt_üstbaslik2);
            //---------------------------------------------------------------

            //panel16 içerisine üstbaslik-1 textbox  yerleştirir
            esolasılık7_3_fayda_txt_üstbaslik1 = new TextBox();
            esolasılık7_3_fayda_txt_üstbaslik1.Name = "txtüstbaslik1";
            Point txt_txtüstbaslik1 = new Point(3, 10);
            esolasılık7_3_fayda_txt_üstbaslik1.Location = txt_txtüstbaslik1;
            esolasılık7_3_fayda_txt_üstbaslik1.Text = "Büyük";
            esolasılık7_3_fayda_txt_üstbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_üstbaslik1.MaxLength = 30;
            esolasılık7_3_fayda_txt_üstbaslik1.Multiline = true;
            esolasılık7_3_fayda_txt_üstbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_üstbaslik1.Size = new Size(85, 13);
            esolasılık7_3_fayda_pl16.Controls.Add(esolasılık7_3_fayda_txt_üstbaslik1);
            //---------------------------------------------------------------

            //panel51 içerisine altbaslik-7 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik7 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik7.Name = "txtaltbaslik7";
            Point txt_txtaltbaslik7 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik7.Location = txt_txtaltbaslik7;
            esolasılık7_3_fayda_txt_altbaslik7.Text = "F7";
            esolasılık7_3_fayda_txt_altbaslik7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik7.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik7.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik7.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik7.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl51.Controls.Add(esolasılık7_3_fayda_txt_altbaslik7);
            //---------------------------------------------------------------

            //panel46 içerisine altbaslik-6 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik6 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik6.Name = "txtaltbaslik6";
            Point txt_txtaltbaslik6 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik6.Location = txt_txtaltbaslik6;
            esolasılık7_3_fayda_txt_altbaslik6.Text = "F6";
            esolasılık7_3_fayda_txt_altbaslik6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik6.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik6.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik6.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik6.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl46.Controls.Add(esolasılık7_3_fayda_txt_altbaslik6);
            //---------------------------------------------------------------

            //panel41 içerisine altbaslik-5 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik5 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik5.Name = "txtaltbaslik5";
            Point txt_txtaltbaslik5 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik5.Location = txt_txtaltbaslik5;
            esolasılık7_3_fayda_txt_altbaslik5.Text = "F5";
            esolasılık7_3_fayda_txt_altbaslik5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik5.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik5.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik5.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik5.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl41.Controls.Add(esolasılık7_3_fayda_txt_altbaslik5);
            //---------------------------------------------------------------

            //panel36 içerisine altbaslik-4 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik4 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik4.Name = "txtaltbaslik4";
            Point txt_txtaltbaslik4 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik4.Location = txt_txtaltbaslik4;
            esolasılık7_3_fayda_txt_altbaslik4.Text = "F4";
            esolasılık7_3_fayda_txt_altbaslik4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik4.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik4.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik4.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl36.Controls.Add(esolasılık7_3_fayda_txt_altbaslik4);
            //---------------------------------------------------------------

            //panel31 içerisine altbaslik-3 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik3 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik3.Name = "txtaltbaslik3";
            Point txt_txtaltbaslik3 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik3.Location = txt_txtaltbaslik3;
            esolasılık7_3_fayda_txt_altbaslik3.Text = "F3";
            esolasılık7_3_fayda_txt_altbaslik3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik3.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik3.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik3.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik3.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl31.Controls.Add(esolasılık7_3_fayda_txt_altbaslik3);
            //---------------------------------------------------------------

            //panel15 içerisine altbaslik-2 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik2 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik2.Name = "txtaltbaslik2";
            Point txt_txtaltbaslik2 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik2.Location = txt_txtaltbaslik2;
            esolasılık7_3_fayda_txt_altbaslik2.Text = "F2";
            esolasılık7_3_fayda_txt_altbaslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik2.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik2.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik2.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl15.Controls.Add(esolasılık7_3_fayda_txt_altbaslik2);
            //---------------------------------------------------------------

            //panel14 içerisine altbaslik-1 textbox  yerleştirir
            esolasılık7_3_fayda_txt_altbaslik1 = new TextBox();
            esolasılık7_3_fayda_txt_altbaslik1.Name = "txtaltbaslik1";
            Point txt_txtaltbaslik1 = new Point(3, 9);
            esolasılık7_3_fayda_txt_altbaslik1.Location = txt_txtaltbaslik1;
            esolasılık7_3_fayda_txt_altbaslik1.Text = "F1";
            esolasılık7_3_fayda_txt_altbaslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_altbaslik1.MaxLength = 30;
            esolasılık7_3_fayda_txt_altbaslik1.Multiline = true;
            esolasılık7_3_fayda_txt_altbaslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_altbaslik1.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl14.Controls.Add(esolasılık7_3_fayda_txt_altbaslik1);
            //---------------------------------------------------------------

            //panel13 içerisine baslik-2 textbox  yerleştirir
            esolasılık7_3_fayda_txt_baslik2 = new TextBox();
            esolasılık7_3_fayda_txt_baslik2.Name = "txtbaslik2";
            Point txt_baslik2 = new Point(3, 9);
            esolasılık7_3_fayda_txt_baslik2.Location = txt_baslik2;
            esolasılık7_3_fayda_txt_baslik2.Text = "Fabrikalar - Oranlar";
            esolasılık7_3_fayda_txt_baslik2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_baslik2.MaxLength = 30;
            esolasılık7_3_fayda_txt_baslik2.Multiline = true;
            esolasılık7_3_fayda_txt_baslik2.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_baslik2.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl13.Controls.Add(esolasılık7_3_fayda_txt_baslik2);
            //---------------------------------------------------------------

            //panel12 içerisine baslik-1 textbox  yerleştirir
            esolasılık7_3_fayda_txt_baslik1 = new TextBox();
            esolasılık7_3_fayda_txt_baslik1.Name = "txtbaslik1";
            Point txt_baslik1 = new Point(3, 9);
            esolasılık7_3_fayda_txt_baslik1.Location = txt_baslik1;
            esolasılık7_3_fayda_txt_baslik1.Text = "Talep Düzeyleri";
            esolasılık7_3_fayda_txt_baslik1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            esolasılık7_3_fayda_txt_baslik1.MaxLength = 30;
            esolasılık7_3_fayda_txt_baslik1.Multiline = true;
            esolasılık7_3_fayda_txt_baslik1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_txt_baslik1.Size = new Size(162, 13);
            esolasılık7_3_fayda_pl12.Controls.Add(esolasılık7_3_fayda_txt_baslik1);
            //---------------------------------------------------------------

            //panel55 oluşturuldu  f7-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl55.Name = "pl55";
            Point pl55k = new Point(470, 315);
            esolasılık7_3_fayda_pl55.Location = pl55k;
            esolasılık7_3_fayda_pl55.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl55.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl55);
            //-----------------------------------------

            //panel50 oluşturuldu  f6-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl50.Name = "pl50";
            Point pl50k = new Point(470, 276);
            esolasılık7_3_fayda_pl50.Location = pl50k;
            esolasılık7_3_fayda_pl50.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl50.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl50);
            //-----------------------------------------

            //panel45 oluşturuldu  f5-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl45.Name = "pl45";
            Point pl45k = new Point(470, 237);
            esolasılık7_3_fayda_pl45.Location = pl45k;
            esolasılık7_3_fayda_pl45.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl45.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl45);
            //-----------------------------------------

            //panel40 oluşturuldu  f4-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl40.Name = "pl40";
            Point pl40k = new Point(470, 198);
            esolasılık7_3_fayda_pl40.Location = pl40k;
            esolasılık7_3_fayda_pl40.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl40.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl40);
            //-----------------------------------------

            //panel35 oluşturuldu  f3-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl35.Name = "pl35";
            Point pl35k = new Point(470, 159);
            esolasılık7_3_fayda_pl35.Location = pl35k;
            esolasılık7_3_fayda_pl35.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl35.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl35);
            //-----------------------------------------

            //panel30 oluşturuldu  f2-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl30.Name = "pl30";
            Point pl30k = new Point(470, 120);
            esolasılık7_3_fayda_pl30.Location = pl30k;
            esolasılık7_3_fayda_pl30.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl30.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl30);
            //-----------------------------------------

            //panel29 oluşturuldu  f1-sonuc arka planı orta kısım 
            esolasılık7_3_fayda_pl29.Name = "pl29";
            Point pl29k = new Point(470, 81);
            esolasılık7_3_fayda_pl29.Location = pl29k;
            esolasılık7_3_fayda_pl29.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl29.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl29);
            //-----------------------------------------

            //panel28 oluşturuldu  sonuc başlık arka planı orta kısım 
            esolasılık7_3_fayda_pl28.Name = "pl28";
            Point pl28k = new Point(470, 3);
            esolasılık7_3_fayda_pl28.Location = pl28k;
            esolasılık7_3_fayda_pl28.Size = new Size(91, 72);
            esolasılık7_3_fayda_pl28.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl28);
            //-----------------------------------------

            //panel54 oluşturuldu  veri-21 sütün 4-satır 9 arka planı orta kısım 
            esolasılık7_3_fayda_pl54.Name = "pl54";
            Point pl54k = new Point(373, 315);
            esolasılık7_3_fayda_pl54.Location = pl54k;
            esolasılık7_3_fayda_pl54.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl54.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl54);
            //-----------------------------------------

            //panel53 oluşturuldu  veri-20 sütün 3-satır 9 arka planı orta kısım 
            esolasılık7_3_fayda_pl53.Name = "pl53";
            Point pl53k = new Point(276, 315);
            esolasılık7_3_fayda_pl53.Location = pl53k;
            esolasılık7_3_fayda_pl53.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl53.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl53);
            //-----------------------------------------

            //panel52 oluşturuldu  veri-19 sütün 2-satır 9 arka planı orta kısım 
            esolasılık7_3_fayda_pl52.Name = "pl52";
            Point pl52k = new Point(179, 315);
            esolasılık7_3_fayda_pl52.Location = pl52k;
            esolasılık7_3_fayda_pl52.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl52.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl52);
            //-----------------------------------------

            //panel49 oluşturuldu  veri-18 sütün 4-satır 8 arka planı orta kısım 
            esolasılık7_3_fayda_pl49.Name = "pl49";
            Point pl49k = new Point(373, 276);
            esolasılık7_3_fayda_pl49.Location = pl49k;
            esolasılık7_3_fayda_pl49.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl49.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl49);
            //-----------------------------------------

            //panel48 oluşturuldu  veri-17 sütün 3-satır 8 arka planı orta kısım 
            esolasılık7_3_fayda_pl48.Name = "pl48";
            Point pl48k = new Point(276, 276);
            esolasılık7_3_fayda_pl48.Location = pl48k;
            esolasılık7_3_fayda_pl48.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl48.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl48);
            //-----------------------------------------

            //panel47 oluşturuldu  veri-16 sütün 2-satır 8 arka planı orta kısım 
            esolasılık7_3_fayda_pl47.Name = "pl47";
            Point pl47k = new Point(179, 276);
            esolasılık7_3_fayda_pl47.Location = pl47k;
            esolasılık7_3_fayda_pl47.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl47.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl47);
            //-----------------------------------------

            //panel44 oluşturuldu  veri-15 sütün 4-satır 7 arka planı orta kısım 
            esolasılık7_3_fayda_pl44.Name = "pl44";
            Point pl44k = new Point(373, 237);
            esolasılık7_3_fayda_pl44.Location = pl44k;
            esolasılık7_3_fayda_pl44.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl44.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl44);
            //-----------------------------------------

            //panel43 oluşturuldu  veri-14 sütün 3-satır 7 arka planı orta kısım 
            esolasılık7_3_fayda_pl43.Name = "pl43";
            Point pl43k = new Point(276, 237);
            esolasılık7_3_fayda_pl43.Location = pl43k;
            esolasılık7_3_fayda_pl43.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl43.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl43);
            //-----------------------------------------

            //panel42 oluşturuldu  veri-13 sütün 2-satır 7 arka planı orta kısım 
            esolasılık7_3_fayda_pl42.Name = "pl42";
            Point pl42k = new Point(179, 237);
            esolasılık7_3_fayda_pl42.Location = pl42k;
            esolasılık7_3_fayda_pl42.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl42.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl42);
            //-----------------------------------------

            //panel39 oluşturuldu  veri-12 sütün 4-satır 6 arka planı orta kısım 
            esolasılık7_3_fayda_pl39.Name = "pl39";
            Point pl39k = new Point(373, 198);
            esolasılık7_3_fayda_pl39.Location = pl39k;
            esolasılık7_3_fayda_pl39.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl39.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl39);
            //-----------------------------------------

            //panel38 oluşturuldu  veri-11 sütün 3-satır 6 arka planı orta kısım 
            esolasılık7_3_fayda_pl38.Name = "pl38";
            Point pl38k = new Point(276, 198);
            esolasılık7_3_fayda_pl38.Location = pl38k;
            esolasılık7_3_fayda_pl38.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl38.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl38);
            //-----------------------------------------

            //panel37 oluşturuldu  veri-10 sütün 2-satır 6 arka planı orta kısım 
            esolasılık7_3_fayda_pl37.Name = "pl37";
            Point pl37k = new Point(179, 198);
            esolasılık7_3_fayda_pl37.Location = pl37k;
            esolasılık7_3_fayda_pl37.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl37.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl37);
            //-----------------------------------------

            //panel34 oluşturuldu  veri-9 sütün 4-satır 5 arka planı orta kısım 
            esolasılık7_3_fayda_pl34.Name = "pl34";
            Point pl34k = new Point(373, 159);
            esolasılık7_3_fayda_pl34.Location = pl34k;
            esolasılık7_3_fayda_pl34.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl34.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl34);
            //-----------------------------------------

            //panel33 oluşturuldu  veri-8 sütün 3-satır 5 arka planı orta kısım 
            esolasılık7_3_fayda_pl33.Name = "pl33";
            Point pl33k = new Point(276, 159);
            esolasılık7_3_fayda_pl33.Location = pl33k;
            esolasılık7_3_fayda_pl33.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl33.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl33);
            //-----------------------------------------

            //panel32 oluşturuldu  veri-7 sütün 2-satır 5 arka planı orta kısım 
            esolasılık7_3_fayda_pl32.Name = "pl32";
            Point pl32k = new Point(179, 159);
            esolasılık7_3_fayda_pl32.Location = pl32k;
            esolasılık7_3_fayda_pl32.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl32.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl32);
            //-----------------------------------------

            //panel27 oluşturuldu  veri-6 sütün 3-satır 4 arka planı orta kısım 
            esolasılık7_3_fayda_pl27.Name = "pl27";
            Point pl27k = new Point(373, 120);
            esolasılık7_3_fayda_pl27.Location = pl27k;
            esolasılık7_3_fayda_pl27.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl27.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl27);
            //-----------------------------------------

            //panel26 oluşturuldu  veri-5 sütün 3-satır 3 arka planı orta kısım 
            esolasılık7_3_fayda_pl26.Name = "pl26";
            Point pl26k = new Point(373, 81);
            esolasılık7_3_fayda_pl26.Location = pl26k;
            esolasılık7_3_fayda_pl26.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl26.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl26);
            //-----------------------------------------

            //panel23 oluşturuldu  veri-4 sütün 2-satır 4 arka planı orta kısım 
            esolasılık7_3_fayda_pl23.Name = "pl23";
            Point pl23k = new Point(276, 120);
            esolasılık7_3_fayda_pl23.Location = pl23k;
            esolasılık7_3_fayda_pl23.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl23.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl23);
            //-----------------------------------------

            //panel22 oluşturuldu  veri-3 sütün 2-satır 4 arka planı orta kısım 
            esolasılık7_3_fayda_pl22.Name = "pl22";
            Point pl22k = new Point(179, 120);
            esolasılık7_3_fayda_pl22.Location = pl22k;
            esolasılık7_3_fayda_pl22.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl22.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl22);
            //-----------------------------------------

            //panel21 oluşturuldu  veri-2 sütün 2-satır 3 arka planı orta kısım 
            esolasılık7_3_fayda_pl21.Name = "pl21";
            Point pl21k = new Point(276, 81);
            esolasılık7_3_fayda_pl21.Location = pl21k;
            esolasılık7_3_fayda_pl21.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl21.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl21);
            //-----------------------------------------

            //panel20 oluşturuldu  veri-1 sütün 2-satır 3 arka planı orta kısım 
            esolasılık7_3_fayda_pl20.Name = "pl20";
            Point pl20k = new Point(179, 81);
            esolasılık7_3_fayda_pl20.Location = pl20k;
            esolasılık7_3_fayda_pl20.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl20.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl20);
            //-----------------------------------------

            //panel25 oluşturuldu  yüzdeoran-3 sütün 3-satır 2 arka planı orta kısım 
            esolasılık7_3_fayda_pl25.Name = "pl25";
            Point pl25k = new Point(373, 42);
            esolasılık7_3_fayda_pl25.Location = pl25k;
            esolasılık7_3_fayda_pl25.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl25.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl25);
            //-----------------------------------------

            //panel19 oluşturuldu  yüzdeoran-2 sütün 2-satır 2 arka planı orta kısım 
            esolasılık7_3_fayda_pl19.Name = "pl19";
            Point pl19k = new Point(276, 42);
            esolasılık7_3_fayda_pl19.Location = pl19k;
            esolasılık7_3_fayda_pl19.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl19.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl19);
            //-----------------------------------------

            //panel18 oluşturuldu  yüzdeoran-1 sütün 2-satır 2 arka planı orta kısım 
            esolasılık7_3_fayda_pl18.Name = "pl18";
            Point pl18k = new Point(179, 42);
            esolasılık7_3_fayda_pl18.Location = pl18k;
            esolasılık7_3_fayda_pl18.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl18.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl18);
            //-----------------------------------------

            //panel24 oluşturuldu  üstbaslik-3 sütün 3-satır 1 arka planı orta kısım 
            esolasılık7_3_fayda_pl24.Name = "pl24";
            Point pl24k = new Point(373, 3);
            esolasılık7_3_fayda_pl24.Location = pl24k;
            esolasılık7_3_fayda_pl24.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl24.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl24);
            //-----------------------------------------

            //panel17 oluşturuldu  üstbaslik-2 sütün 2-satır 1 arka planı orta kısım 
            esolasılık7_3_fayda_pl17.Name = "pl17";
            Point pl17k = new Point(276, 3);
            esolasılık7_3_fayda_pl17.Location = pl17k;
            esolasılık7_3_fayda_pl17.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl17.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl17);
            //-----------------------------------------

            //panel16 oluşturuldu üstbaslik-1 sütün 2-satır 1 isimi arka planı orta kısım 
            esolasılık7_3_fayda_pl16.Name = "pl16";
            Point pl16k = new Point(179, 3);
            esolasılık7_3_fayda_pl16.Location = pl16k;
            esolasılık7_3_fayda_pl16.Size = new Size(91, 33);
            esolasılık7_3_fayda_pl16.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl16);
            //-----------------------------------------

            //panel51 oluşturuldu altbaslik-6 sütün 1-satır 9 arka planı orta kısım 
            esolasılık7_3_fayda_pl51.Name = "pl51";
            Point pl51k = new Point(5, 315);
            esolasılık7_3_fayda_pl51.Location = pl51k;
            esolasılık7_3_fayda_pl51.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl51.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl51);
            //-----------------------------------------

            //panel46 oluşturuldu altbaslik-6 sütün 1-satır 8 arka planı orta kısım 
            esolasılık7_3_fayda_pl46.Name = "pl46";
            Point pl46k = new Point(5, 276);
            esolasılık7_3_fayda_pl46.Location = pl46k;
            esolasılık7_3_fayda_pl46.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl46.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl46);
            //-----------------------------------------

            //panel41 oluşturuldu altbaslik-5 sütün 1-satır 7 arka planı orta kısım 
            esolasılık7_3_fayda_pl41.Name = "pl41";
            Point pl41k = new Point(5, 237);
            esolasılık7_3_fayda_pl41.Location = pl41k;
            esolasılık7_3_fayda_pl41.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl41.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl41);
            //-----------------------------------------

            //panel36 oluşturuldu altbaslik-4 sütün 1-satır 6 arka planı orta kısım 
            esolasılık7_3_fayda_pl36.Name = "pl36";
            Point pl36k = new Point(5, 198);
            esolasılık7_3_fayda_pl36.Location = pl36k;
            esolasılık7_3_fayda_pl36.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl36.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl36);
            //-----------------------------------------

            //panel31 oluşturuldu altbaslik-3 sütün 1-satır 5 arka planı orta kısım 
            esolasılık7_3_fayda_pl31.Name = "pl31";
            Point pl31k = new Point(5, 159);
            esolasılık7_3_fayda_pl31.Location = pl31k;
            esolasılık7_3_fayda_pl31.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl31.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl31);
            //-----------------------------------------

            //panel15 oluşturuldu altbaslik-2 sütün 1-satır 4 arka planı orta kısım 
            esolasılık7_3_fayda_pl15.Name = "pl15";
            Point pl15k = new Point(5, 120);
            esolasılık7_3_fayda_pl15.Location = pl15k;
            esolasılık7_3_fayda_pl15.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl15.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl15);
            //-----------------------------------------

            //panel14 oluşturuldu altbaslik-1 sütün 1-satır 3 isimi arka planı orta kısım 
            esolasılık7_3_fayda_pl14.Name = "pl14";
            Point pl14k = new Point(5, 81);
            esolasılık7_3_fayda_pl14.Location = pl14k;
            esolasılık7_3_fayda_pl14.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl14.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl14);
            //-----------------------------------------

            //panel13 oluşturuldu  başlık-2 sütün 1-satır 2  arka planı orta kısım 
            esolasılık7_3_fayda_pl13.Name = "pl13";
            Point pl13k = new Point(5, 42);
            esolasılık7_3_fayda_pl13.Location = pl13k;
            esolasılık7_3_fayda_pl13.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl13.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl13);
            //-----------------------------------------

            //panel12 oluşturuldu  başlık-1 sütün 1-satır 1 arka planı orta kısım 
            esolasılık7_3_fayda_pl12.Name = "pl12";
            Point pl12k = new Point(5, 3);
            esolasılık7_3_fayda_pl12.Location = pl12k;
            esolasılık7_3_fayda_pl12.Size = new Size(168, 33);
            esolasılık7_3_fayda_pl12.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl5.Controls.Add(esolasılık7_3_fayda_pl12);
            //-----------------------------------------

            //panel11 oluşturuldu panel2 içerisinde hakkında kısmı için
            esolasılık7_3_fayda_pl11.Name = "pl11";
            esolasılık7_3_fayda_pl11.Size = new Size(65, 50);
            esolasılık7_3_fayda_pl11.Dock = DockStyle.Left;
            esolasılık7_3_fayda_pl11.BackColor = Color.Transparent;
            esolasılık7_3_fayda_pl11.BackgroundImage = Properties.Resources.logo;
            esolasılık7_3_fayda_pl11.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl11.Click += new EventHandler(esolasılık7_3_fayda_pl11_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_pl11);
            //------------------------------------------

            //panel10 oluşturuldu panel2 içerisinde silme yapmak için
            esolasılık7_3_fayda_pl10.Name = "pl10";
            esolasılık7_3_fayda_pl10.Size = new Size(65, 50);
            esolasılık7_3_fayda_pl10.Dock = DockStyle.Right;
            esolasılık7_3_fayda_pl10.BackColor = Color.Transparent;
            esolasılık7_3_fayda_pl10.BackgroundImage = Properties.Resources.sil;
            esolasılık7_3_fayda_pl10.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl10.Click += new EventHandler(esolasılık7_3_fayda_pl10_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_pl10);
            //------------------------------------------

            //panel9 oluşturuldu panel2 içerisinde güncelleme yapmak için
            esolasılık7_3_fayda_pl9.Name = "pl9";
            esolasılık7_3_fayda_pl9.Size = new Size(65, 50);
            esolasılık7_3_fayda_pl9.Dock = DockStyle.Right;
            esolasılık7_3_fayda_pl9.BackColor = Color.Transparent;
            esolasılık7_3_fayda_pl9.BackgroundImage = Properties.Resources.güncelle;
            esolasılık7_3_fayda_pl9.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl9.Click += new EventHandler(esolasılık7_3_fayda_pl9_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_pl9);
            //------------------------------------------

            //panel8 oluşturuldu tabpage2-panel7 içerisinde excel aktarımı yapmak için
            esolasılık7_3_fayda_pl8.Name = "pl8";
            esolasılık7_3_fayda_pl8.Size = new Size(65, 50);
            esolasılık7_3_fayda_pl8.Dock = DockStyle.Right;
            esolasılık7_3_fayda_pl8.BackColor = Color.Transparent;
            esolasılık7_3_fayda_pl8.BackgroundImage = Properties.Resources.excel;
            esolasılık7_3_fayda_pl8.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl8.Click += new EventHandler(esolasılık7_3_fayda_pl8_Click);
            esolasılık7_3_fayda_pl7.Controls.Add(esolasılık7_3_fayda_pl8);
            //------------------------------------------

            //panel6 oluşturuldu panel2 içerisinde hesaplama yapmak için
            esolasılık7_3_fayda_pl6.Name = "pl6";
            esolasılık7_3_fayda_pl6.Size = new Size(65, 50);
            esolasılık7_3_fayda_pl6.Dock = DockStyle.Right;
            esolasılık7_3_fayda_pl6.BackColor = Color.Transparent;
            esolasılık7_3_fayda_pl6.BackgroundImage = Properties.Resources.hesapla;
            esolasılık7_3_fayda_pl6.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl6.Click += new EventHandler(esolasılık7_3_fayda_pl6_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_pl6);
            //------------------------------------------

            //button3 oluşturuldu panel2 içerisine        
            esolasılık7_3_fayda_btn3.Name = "btn3";
            esolasılık7_3_fayda_btn3.Size = new Size(65, 50);
            esolasılık7_3_fayda_btn3.Dock = DockStyle.Right;
            esolasılık7_3_fayda_btn3.FlatStyle = FlatStyle.Flat;
            esolasılık7_3_fayda_btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_btn3.BackColor = Color.Transparent;
            esolasılık7_3_fayda_btn3.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_btn3.BackgroundImage = Properties.Resources.geri;
            esolasılık7_3_fayda_btn3.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_btn3.Click += new EventHandler(esolasılık7_3_fayda_btn3_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_btn3);
            //--------------------------------------------------

            //button2 oluşturuldu panel2 içerisine        
            esolasılık7_3_fayda_btn2.Name = "btn2";
            esolasılık7_3_fayda_btn2.Size = new Size(65, 50);
            esolasılık7_3_fayda_btn2.Dock = DockStyle.Right;
            esolasılık7_3_fayda_btn2.FlatStyle = FlatStyle.Flat;
            esolasılık7_3_fayda_btn2.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık7_3_fayda_btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık7_3_fayda_btn2.BackColor = Color.Transparent;
            esolasılık7_3_fayda_btn2.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_btn2.BackgroundImage = Properties.Resources.altaalma;
            esolasılık7_3_fayda_btn2.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_btn2.Click += new EventHandler(esolasılık7_3_fayda_btn2_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_btn2);
            //--------------------------------------------------

            //button1 oluşturuldu panel2 içerisine        
            esolasılık7_3_fayda_btn1.Name = "btn1";
            esolasılık7_3_fayda_btn1.Size = new Size(65, 50);
            esolasılık7_3_fayda_btn1.Dock = DockStyle.Right;
            esolasılık7_3_fayda_btn1.FlatStyle = FlatStyle.Flat;
            esolasılık7_3_fayda_btn1.FlatAppearance.MouseDownBackColor = Color.Red;
            esolasılık7_3_fayda_btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            esolasılık7_3_fayda_btn1.BackColor = Color.Transparent;
            esolasılık7_3_fayda_btn1.FlatAppearance.BorderColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_btn1.BackgroundImage = Properties.Resources.kapat;
            esolasılık7_3_fayda_btn1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_btn1.Click += new EventHandler(esolasılık7_3_fayda_btn1_Click);
            esolasılık7_3_fayda_pl2.Controls.Add(esolasılık7_3_fayda_btn1);
            //--------------------------------------------------

            //DataGridView1 oluşturuldu tabpage2 içerisine        
            esolasılık7_3_fayda_dr1.Name = "dr1";
            esolasılık7_3_fayda_dr1.Size = new Size(851, 498);
            esolasılık7_3_fayda_dr1.Dock = DockStyle.Fill;
            esolasılık7_3_fayda_dr1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_dr1.AllowUserToAddRows = false;
            esolasılık7_3_fayda_dr1.AllowUserToDeleteRows = false;
            esolasılık7_3_fayda_dr1.AllowUserToResizeColumns = false;
            esolasılık7_3_fayda_dr1.AllowUserToResizeRows = false;
            esolasılık7_3_fayda_dr1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            esolasılık7_3_fayda_dr1.RowHeadersVisible = false;
            esolasılık7_3_fayda_dr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            esolasılık7_3_fayda_dr1.CellEnter += new DataGridViewCellEventHandler(esolasılık7_3_fayda_dr1_CellEnter);
            esolasılık7_3_fayda_tb1_2.Controls.Add(esolasılık7_3_fayda_dr1);
            //------------------------------------------

            //panel7 oluşturuldu tabpage2 içerisinde
            esolasılık7_3_fayda_pl7.Name = "pl7";
            esolasılık7_3_fayda_pl7.Size = new Size(865, 50);
            esolasılık7_3_fayda_pl7.Dock = DockStyle.Top;
            esolasılık7_3_fayda_pl7.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_tb1_2.Controls.Add(esolasılık7_3_fayda_pl7);
            //------------------------------------------

            //panel5 oluşturuldu tabpage1 içerisine
            esolasılık7_3_fayda_pl5.Name = "pl5";
            esolasılık7_3_fayda_pl5.Size = new Size(851, 498);
            esolasılık7_3_fayda_pl5.Dock = DockStyle.Fill;
            esolasılık7_3_fayda_pl5.AutoScroll = true;
            esolasılık7_3_fayda_pl5.AutoSize = true;
            esolasılık7_3_fayda_pl5.AutoScrollMargin = new Size(50, 50);
            esolasılık7_3_fayda_pl5.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_tb1_1.Controls.Add(esolasılık7_3_fayda_pl5);
            //------------------------------------------

            //richTextBox oluşturuldu tabpage3 içerisine
            esolasılık7_3_fayda_rt1.Name = "rt1";
            esolasılık7_3_fayda_rt1.Size = new Size(851, 498);
            esolasılık7_3_fayda_rt1.Dock = DockStyle.Fill;
            esolasılık7_3_fayda_rt1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_rt1.Enabled = false;
            esolasılık7_3_fayda_rt1.Text = "•Yeterli bir sebep olmaması halinde olayların olayların olasılıkları eşit kabul edilir.\n•Faydaya Göre Fabrika Ve Büyüklük Oranlarının Çarpımından Çıkan Sonuçların En Büyüğü Seçilir.";
            esolasılık7_3_fayda_rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            esolasılık7_3_fayda_tb1_3.Controls.Add(esolasılık7_3_fayda_rt1);
            //------------------------------------------

            //tabpage1 tabcontrol1 içine oluşturuldu
            esolasılık7_3_fayda_tb1_1.Name = "tb1_1";
            esolasılık7_3_fayda_tb1_1.Text = "Tablo";
            esolasılık7_3_fayda_tb1_1.Size = new Size(651, 50);
            esolasılık7_3_fayda_tb1_1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_tb1.Controls.Add(esolasılık7_3_fayda_tb1_1);
            //------------------------------------------------

            //tabpage2 tabcontrol1 içine oluşturuldu
            esolasılık7_3_fayda_tb1_2.Name = "tb1_2";
            esolasılık7_3_fayda_tb1_2.Text = "Veri Tabanı";
            esolasılık7_3_fayda_tb1_2.Size = new Size(651, 50);
            esolasılık7_3_fayda_tb1_2.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_tb1.Controls.Add(esolasılık7_3_fayda_tb1_2);
            //------------------------------------------------

            //tabpage3 tabcontrol1 içine oluşturuldu
            esolasılık7_3_fayda_tb1_3.Name = "tb1_3";
            esolasılık7_3_fayda_tb1_3.Text = "Konu Anlatımı";
            esolasılık7_3_fayda_tb1_3.Size = new Size(651, 50);
            esolasılık7_3_fayda_tb1_3.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_tb1.Controls.Add(esolasılık7_3_fayda_tb1_3);
            //------------------------------------------------

            //tabcontrol1 olışturuldu panel_3 içine
            esolasılık7_3_fayda_tb1.Name = "tb1";
            esolasılık7_3_fayda_tb1.Size = new Size(651, 50);
            esolasılık7_3_fayda_tb1.Dock = DockStyle.Fill;
            esolasılık7_3_fayda_tb1.BackColor = Color.FromArgb(209, 209, 209);
            esolasılık7_3_fayda_pl3.Controls.Add(esolasılık7_3_fayda_tb1);
            //-----------------------------------------------

            //panel4 oluşturuldu alt kısın
            esolasılık7_3_fayda_pl4.Name = "pl4";
            esolasılık7_3_fayda_pl4.Size = new Size(865, 50);
            esolasılık7_3_fayda_pl4.Dock = DockStyle.Bottom;
            esolasılık7_3_fayda_pl4.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl4.MouseUp += new MouseEventHandler(esolasılık7_3_fayda_pl4_MouseUp);
            esolasılık7_3_fayda_pl4.MouseMove += new MouseEventHandler(esolasılık7_3_fayda_pl4_MouseMove);
            esolasılık7_3_fayda_pl4.MouseDown += new MouseEventHandler(esolasılık7_3_fayda_pl4_MouseDown);
            this.Controls.Add(esolasılık7_3_fayda_pl4);
            //------------------------------------------

            //panel3 oluşturuldu orta kısım
            esolasılık7_3_fayda_pl3.Name = "pl3";
            esolasılık7_3_fayda_pl3.Size = new Size(865, 530);
            esolasılık7_3_fayda_pl3.Dock = DockStyle.Top;
            esolasılık7_3_fayda_pl3.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık7_3_fayda_pl3);
            //------------------------------------------

            //panel2 oluşturuldu üstbaşlıgın altı
            esolasılık7_3_fayda_pl2.Name = "pl2";
            esolasılık7_3_fayda_pl2.Size = new Size(865, 50);
            esolasılık7_3_fayda_pl2.Dock = DockStyle.Top;
            esolasılık7_3_fayda_pl2.BackColor = Color.FromArgb(209, 209, 209);
            this.Controls.Add(esolasılık7_3_fayda_pl2);
            //------------------------------------------

            //panel 1 oluşturuldu üstbaşlık
            esolasılık7_3_fayda_pl1.Name = "pl1";
            esolasılık7_3_fayda_pl1.Size = new Size(865, 50);
            esolasılık7_3_fayda_pl1.Dock = DockStyle.Top;
            esolasılık7_3_fayda_pl1.BackColor = Color.FromArgb(153, 180, 209);
            esolasılık7_3_fayda_pl1.BackgroundImage = Properties.Resources.esolasılıkfayda;
            esolasılık7_3_fayda_pl1.BackgroundImageLayout = ImageLayout.Zoom;
            esolasılık7_3_fayda_pl1.MouseUp += new MouseEventHandler(esolasılık7_3_fayda_pl1_MouseUp);
            esolasılık7_3_fayda_pl1.MouseMove += new MouseEventHandler(esolasılık7_3_fayda_pl1_MouseMove);
            esolasılık7_3_fayda_pl1.MouseDown += new MouseEventHandler(esolasılık7_3_fayda_pl1_MouseDown);
            this.Controls.Add(esolasılık7_3_fayda_pl1);
            //-----------------------------------------
        }
        //-----------------------------------------

        //esolasılık2_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık2_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık2_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık2_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 19; i++)
            {
                esolasılık2_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık3_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık3_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık3_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık3_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 24; i++)
            {
                esolasılık3_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık4_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık4_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık4_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık4_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 29; i++)
            {
                esolasılık4_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık5_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık5_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık5_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık5_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 34; i++)
            {
                esolasılık5_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık6_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık6_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık6_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık6_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 39; i++)
            {
                esolasılık6_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık7_3_fayda veritabanına listelemek için kullanılır
        public void esolasılık7_3_fayda_listele()
        {
            baglanti.Open();
            adp = new OleDbDataAdapter("Select * From esolasılık7_3_fayda", baglanti);
            tablo = new DataTable();
            adp.Fill(tablo);
            esolasılık7_3_fayda_dr1.DataSource = tablo;
            for (int i = 0; i <= 44; i++)
            {
                esolasılık7_3_fayda_dr1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            baglanti.Close();
        }
        //------------------------------------------------

        //esolasılık2_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık2_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık2_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık2_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık2_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık2_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık2_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık2_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık2_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık2_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık2_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık2_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık2_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık2_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık2_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık2_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık2_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık2_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık2_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık2_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık2_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık2_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık2_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık2_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık2_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık2_3_fayda_pl4.Controls["sonuc"].Text = esolasılık2_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık2_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık2_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık2_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık2_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık2_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık2_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık2_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık2_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl27.Controls["txtveri6"].Text)));
                    esolasılık2_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık2_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
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
                    string sorgu = "Insert into esolasılık2_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,sonuc_1,sonuc_2,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@sonuc_1,@sonuc_2,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık2_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık2_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık2_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık2_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık2_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık2_3_fayda where Id=" + esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık2_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık2_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık2_3_fayda_pl27.Controls["txtveri6"].Text)));
                    esolasılık2_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık2_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık2_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık2_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık2_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık2_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık2_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık2_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık2_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık2_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık2_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık2_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık2_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık2_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık2_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık2_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık2_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık2_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık2_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık2_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık2_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    esolasılık2_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık2_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık2_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık2_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık2_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık2_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık2_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık2_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık2_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //esolasılık3_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık3_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık3_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık3_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık3_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık3_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık3_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık3_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık3_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık3_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık3_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık3_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık3_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık3_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık3_3_fayda_pl31.Controls["txtaltbaslik3"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık3_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık3_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık3_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık3_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık3_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık3_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık3_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık3_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık3_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık3_3_fayda_pl32.Controls["txtveri7"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık3_3_fayda_pl33.Controls["txtveri8"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                esolasılık3_3_fayda_pl34.Controls["txtveri9"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                esolasılık3_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                esolasılık3_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                esolasılık3_3_fayda_pl35.Controls["txtf3sonuc"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                esolasılık3_3_fayda_pl4.Controls["sonuc"].Text = esolasılık3_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık3_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık3_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık3_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık3_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık3_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık3_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık3_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık3_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl34.Controls["txtveri9"].Text)));
                    esolasılık3_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık3_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık3_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
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
                    string sorgu = "Insert into esolasılık3_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,sonuc_1,sonuc_2,sonuc_3,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@sonuc_1,@sonuc_2,@sonuc_3,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık3_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık3_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık3_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık3_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık3_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık3_3_fayda where Id=" + esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık3_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık3_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık3_3_fayda_pl34.Controls["txtveri9"].Text)));
                    esolasılık3_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık3_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık3_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık3_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık3_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık3_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık3_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık3_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık3_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık3_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık3_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık3_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık3_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık3_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık3_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık3_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık3_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık3_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık3_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık3_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık3_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık3_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık3_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık3_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık3_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık3_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık3_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık3_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık3_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık3_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık3_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık3_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık3_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık3_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık3_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık3_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //esolasılık4_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık4_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık4_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık4_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık4_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık4_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık4_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık4_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık4_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık4_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık4_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık4_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık4_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık4_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık4_3_fayda_pl31.Controls["txtaltbaslik3"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık4_3_fayda_pl36.Controls["txtaltbaslik4"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık4_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık4_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık4_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık4_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık4_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık4_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık4_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık4_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık4_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık4_3_fayda_pl32.Controls["txtveri7"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                esolasılık4_3_fayda_pl33.Controls["txtveri8"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                esolasılık4_3_fayda_pl34.Controls["txtveri9"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                esolasılık4_3_fayda_pl37.Controls["txtveri10"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                esolasılık4_3_fayda_pl38.Controls["txtveri11"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                esolasılık4_3_fayda_pl39.Controls["txtveri12"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                esolasılık4_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                esolasılık4_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                esolasılık4_3_fayda_pl35.Controls["txtf3sonuc"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                esolasılık4_3_fayda_pl40.Controls["txtf4sonuc"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                esolasılık4_3_fayda_pl4.Controls["sonuc"].Text = esolasılık4_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık4_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık4_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık4_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık4_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık4_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık4_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık4_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık4_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl39.Controls["txtveri12"].Text)));
                    esolasılık4_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık4_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık4_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık4_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
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
                    string sorgu = "Insert into esolasılık4_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,sonuc_1,sonuc_2,sonuc_3,sonuc_4,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık4_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık4_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık4_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık4_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık4_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık4_3_fayda where Id=" + esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık4_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık4_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık4_3_fayda_pl39.Controls["txtveri12"].Text)));
                    esolasılık4_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık4_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık4_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık4_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık4_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık4_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık4_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık4_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık4_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık4_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık4_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık4_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık4_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık4_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık4_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık4_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık4_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık4_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık4_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık4_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık4_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık4_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık4_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık4_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık4_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık4_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık4_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık4_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık4_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık4_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık4_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık4_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık4_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık4_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık4_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık4_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık4_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık4_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık4_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık4_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık4_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık4_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //esolasılık5_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık5_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık5_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık5_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık5_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık5_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık5_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık5_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık5_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık5_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık5_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık5_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık5_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık5_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık5_3_fayda_pl31.Controls["txtaltbaslik3"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık5_3_fayda_pl36.Controls["txtaltbaslik4"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık5_3_fayda_pl41.Controls["txtaltbaslik5"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık5_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık5_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık5_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık5_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık5_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık5_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık5_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık5_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık5_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                esolasılık5_3_fayda_pl32.Controls["txtveri7"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                esolasılık5_3_fayda_pl33.Controls["txtveri8"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                esolasılık5_3_fayda_pl34.Controls["txtveri9"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                esolasılık5_3_fayda_pl37.Controls["txtveri10"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                esolasılık5_3_fayda_pl38.Controls["txtveri11"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                esolasılık5_3_fayda_pl39.Controls["txtveri12"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                esolasılık5_3_fayda_pl42.Controls["txtveri13"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                esolasılık5_3_fayda_pl43.Controls["txtveri14"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                esolasılık5_3_fayda_pl44.Controls["txtveri15"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                esolasılık5_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                esolasılık5_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                esolasılık5_3_fayda_pl35.Controls["txtf3sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                esolasılık5_3_fayda_pl40.Controls["txtf4sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                esolasılık5_3_fayda_pl45.Controls["txtf5sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                esolasılık5_3_fayda_pl4.Controls["sonuc"].Text = esolasılık5_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık5_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık5_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık5_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık5_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık5_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık5_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık5_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık5_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl44.Controls["txtveri15"].Text)));
                    esolasılık5_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık5_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık5_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık5_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık5_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
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
                    string sorgu = "Insert into esolasılık5_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık5_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık5_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık5_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık5_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık5_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık5_3_fayda where Id=" + esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık5_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık5_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık5_3_fayda_pl44.Controls["txtveri15"].Text)));
                    esolasılık5_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık5_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık5_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık5_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık5_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık5_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık5_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık5_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık5_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık5_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık5_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık5_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık5_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık5_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık5_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık5_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık5_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık5_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık5_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık5_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık5_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık5_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık5_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık5_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık5_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık5_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık5_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık5_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık5_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık5_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık5_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık5_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık5_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık5_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık5_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık5_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık5_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık5_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık5_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık5_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık5_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık5_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık5_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık5_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık5_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık5_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık5_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık5_3_fayda_pl11_Click(object sender, EventArgs e)
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


        //esolasılık6_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık6_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık6_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık6_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık6_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık6_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık6_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık6_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık6_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık6_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık6_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık6_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık6_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık6_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık6_3_fayda_pl31.Controls["txtaltbaslik3"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık6_3_fayda_pl36.Controls["txtaltbaslik4"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık6_3_fayda_pl41.Controls["txtaltbaslik5"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık6_3_fayda_pl46.Controls["txtaltbaslik6"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık6_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık6_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık6_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık6_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık6_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık6_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık6_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık6_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                esolasılık6_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                esolasılık6_3_fayda_pl32.Controls["txtveri7"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                esolasılık6_3_fayda_pl33.Controls["txtveri8"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                esolasılık6_3_fayda_pl34.Controls["txtveri9"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                esolasılık6_3_fayda_pl37.Controls["txtveri10"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                esolasılık6_3_fayda_pl38.Controls["txtveri11"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                esolasılık6_3_fayda_pl39.Controls["txtveri12"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                esolasılık6_3_fayda_pl42.Controls["txtveri13"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                esolasılık6_3_fayda_pl43.Controls["txtveri14"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                esolasılık6_3_fayda_pl44.Controls["txtveri15"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                esolasılık6_3_fayda_pl47.Controls["txtveri16"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                esolasılık6_3_fayda_pl48.Controls["txtveri17"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                esolasılık6_3_fayda_pl49.Controls["txtveri18"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                esolasılık6_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                esolasılık6_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                esolasılık6_3_fayda_pl35.Controls["txtf3sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                esolasılık6_3_fayda_pl40.Controls["txtf4sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                esolasılık6_3_fayda_pl45.Controls["txtf5sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                esolasılık6_3_fayda_pl50.Controls["txtf6sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                esolasılık6_3_fayda_pl4.Controls["sonuc"].Text = esolasılık6_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık6_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık6_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık6_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık6_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık6_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık6_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık6_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık6_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl49.Controls["txtveri18"].Text)));
                    esolasılık6_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık6_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık6_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık6_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık6_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    esolasılık6_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
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
                    string sorgu = "Insert into esolasılık6_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", esolasılık6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", esolasılık6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", esolasılık6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", esolasılık6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", esolasılık6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık6_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık6_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık6_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık6_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık6_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık6_3_fayda where Id=" + esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık6_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık6_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık6_3_fayda_pl49.Controls["txtveri18"].Text)));
                    esolasılık6_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık6_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık6_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık6_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık6_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    esolasılık6_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık6_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık6_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık6_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık6_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık6_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık6_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık6_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık6_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", esolasılık6_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık6_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık6_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık6_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık6_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık6_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık6_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık6_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık6_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık6_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık6_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık6_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık6_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık6_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık6_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık6_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık6_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık6_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık6_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık6_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık6_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık6_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", esolasılık6_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", esolasılık6_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", esolasılık6_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık6_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık6_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık6_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık6_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık6_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", esolasılık6_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık6_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık6_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık6_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık6_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık6_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık6_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık6_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık6_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık6_3_fayda_pl11_Click(object sender, EventArgs e)
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

        //esolasılık7_3_fayda panel1 uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık7_3_fayda_pl1_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık7_3_fayda_pl1_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık7_3_fayda_pl1_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık7_3_fayda uzerinde mouse ile tutup formu surukleme eventleri
        private void esolasılık7_3_fayda_pl4_MouseUp(object sender, MouseEventArgs e)
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
        private void esolasılık7_3_fayda_pl4_MouseMove(object sender, MouseEventArgs e)
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
        private void esolasılık7_3_fayda_pl4_MouseDown(object sender, MouseEventArgs e)
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

        //esolasılık7_3_fayda DataGridView üzerinden verileri textbox çekmek için kullanılır
        private void esolasılık7_3_fayda_dr1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                esolasılık7_3_fayda_pl12.Controls["txtbaslik1"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[1].Value.ToString();
                esolasılık7_3_fayda_pl13.Controls["txtbaslik2"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[2].Value.ToString();
                esolasılık7_3_fayda_pl14.Controls["txtaltbaslik1"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[3].Value.ToString();
                esolasılık7_3_fayda_pl15.Controls["txtaltbaslik2"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[4].Value.ToString();
                esolasılık7_3_fayda_pl31.Controls["txtaltbaslik3"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[5].Value.ToString();
                esolasılık7_3_fayda_pl36.Controls["txtaltbaslik4"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[6].Value.ToString();
                esolasılık7_3_fayda_pl41.Controls["txtaltbaslik5"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[7].Value.ToString();
                esolasılık7_3_fayda_pl46.Controls["txtaltbaslik6"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[8].Value.ToString();
                esolasılık7_3_fayda_pl51.Controls["txtaltbaslik7"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[9].Value.ToString();
                esolasılık7_3_fayda_pl16.Controls["txtüstbaslik1"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[10].Value.ToString();
                esolasılık7_3_fayda_pl17.Controls["txtüstbaslik2"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[11].Value.ToString();
                esolasılık7_3_fayda_pl24.Controls["txtüstbaslik3"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[12].Value.ToString();
                esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[13].Value.ToString();
                esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[14].Value.ToString();
                esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[15].Value.ToString();
                esolasılık7_3_fayda_pl20.Controls["txtveri1"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[16].Value.ToString();
                esolasılık7_3_fayda_pl21.Controls["txtveri2"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[17].Value.ToString();
                esolasılık7_3_fayda_pl26.Controls["txtveri3"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[18].Value.ToString();
                esolasılık7_3_fayda_pl22.Controls["txtveri4"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[19].Value.ToString();
                esolasılık7_3_fayda_pl23.Controls["txtveri5"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[20].Value.ToString();
                esolasılık7_3_fayda_pl27.Controls["txtveri6"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[21].Value.ToString();
                esolasılık7_3_fayda_pl32.Controls["txtveri7"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[22].Value.ToString();
                esolasılık7_3_fayda_pl33.Controls["txtveri8"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[23].Value.ToString();
                esolasılık7_3_fayda_pl34.Controls["txtveri9"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[24].Value.ToString();
                esolasılık7_3_fayda_pl37.Controls["txtveri10"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[25].Value.ToString();
                esolasılık7_3_fayda_pl38.Controls["txtveri11"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[26].Value.ToString();
                esolasılık7_3_fayda_pl39.Controls["txtveri12"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[27].Value.ToString();
                esolasılık7_3_fayda_pl42.Controls["txtveri13"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[28].Value.ToString();
                esolasılık7_3_fayda_pl43.Controls["txtveri14"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[29].Value.ToString();
                esolasılık7_3_fayda_pl44.Controls["txtveri15"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[30].Value.ToString();
                esolasılık7_3_fayda_pl47.Controls["txtveri16"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[31].Value.ToString();
                esolasılık7_3_fayda_pl48.Controls["txtveri17"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[32].Value.ToString();
                esolasılık7_3_fayda_pl49.Controls["txtveri18"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[33].Value.ToString();
                esolasılık7_3_fayda_pl52.Controls["txtveri19"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[34].Value.ToString();
                esolasılık7_3_fayda_pl53.Controls["txtveri20"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[35].Value.ToString();
                esolasılık7_3_fayda_pl54.Controls["txtveri21"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[36].Value.ToString();
                esolasılık7_3_fayda_pl29.Controls["txtf1sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[37].Value.ToString();
                esolasılık7_3_fayda_pl30.Controls["txtf2sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[38].Value.ToString();
                esolasılık7_3_fayda_pl35.Controls["txtf3sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[39].Value.ToString();
                esolasılık7_3_fayda_pl40.Controls["txtf4sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[40].Value.ToString();
                esolasılık7_3_fayda_pl45.Controls["txtf5sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[41].Value.ToString();
                esolasılık7_3_fayda_pl50.Controls["txtf6sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[42].Value.ToString();
                esolasılık7_3_fayda_pl55.Controls["txtf7sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[43].Value.ToString();
                esolasılık7_3_fayda_pl4.Controls["sonuc"].Text = esolasılık7_3_fayda_dr1.CurrentRow.Cells[44].Value.ToString();
            }
            catch (Exception hataTuru)
            {
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-----------------------------------------------------------


        //esolasılık7_3_fayda formu kapatmak için oluşturulmuş button1
        private void esolasılık7_3_fayda_btn1_Click(object sender, EventArgs e)
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

        //esolasılık7_3_fayda formu altaalmak için oluşturulmuş button2
        private void esolasılık7_3_fayda_btn2_Click(object sender, EventArgs e)
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

        //esolasılık7_3_fayda fordan bir önceki forma geçmek için oluşturulmuş button3
        private void esolasılık7_3_fayda_btn3_Click(object sender, EventArgs e)
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

        //esolasılık7_3_fayda hesaplama yapmak için oluşturulmuş panel6 
        private void esolasılık7_3_fayda_pl6_Click(object sender, EventArgs e)
        {
            try
            {
                double orantoplam = (Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl49.Controls["txtveri18"].Text)));
                    double f7 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl52.Controls["txtveri19"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl53.Controls["txtveri20"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl54.Controls["txtveri21"].Text)));
                    esolasılık7_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık7_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık7_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık7_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık7_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    esolasılık7_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    esolasılık7_3_fayda_pl55.Controls["txtf7sonuc"].Text = f7.ToString();
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
                    string sorgu = "Insert into esolasılık7_3_fayda(baslik_1,baslik_2,altbaslik_1,altbaslik_2,altbaslik_3,altbaslik_4,altbaslik_5,altbaslik_6,altbaslik_7,ustbaslik_1,ustbaslik_2,ustbaslik_3,oran_1,oran_2,oran_3,veri_1,veri_2,veri_3,veri_4,veri_5,veri_6,veri_7,veri_8,veri_9,veri_10,veri_11,veri_12,veri_13,veri_14,veri_15,veri_16,veri_17,veri_18,veri_19,veri_20,veri_21,sonuc_1,sonuc_2,sonuc_3,sonuc_4,sonuc_5,sonuc_6,sonuc_7,Fayda) values(@baslik_1,@baslik_2,@altbaslik_1,@altbaslik_2,@altbaslik_3,@altbaslik_4,@altbaslik_5,@altbaslik_6,@altbaslik_7,@ustbaslik_1,@ustbaslik_2,@ustbaslik_3,@oran_1,@oran_2,@oran_3,@veri_1,@veri_2,@veri_3,@veri_4,@veri_5,@veri_6,@veri_7,@veri_8,@veri_9,@veri_10,@veri_11,@veri_12,@veri_13,@veri_14,@veri_15,@veri_16,@veri_17,@veri_18,@veri_19,@veri_20,@veri_21,@sonuc_1,@sonuc_2,@sonuc_3,@sonuc_4,@sonuc_5,@sonuc_6,@sonuc_7,@Fayda)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik_1", esolasılık7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", esolasılık7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", esolasılık7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", esolasılık7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", esolasılık7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", esolasılık7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", esolasılık7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", esolasılık7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", esolasılık7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", esolasılık7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", esolasılık7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık7_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık7_3_fayda_listele();
                    MessageBox.Show("Hesaplama İşlemi Tamamlandı Kayıt Yapıldı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık7_3_fayda excel aktarımı yapmak için oluşturulmuş panel8  tabpage2-panel7 içerisinde 
        private void esolasılık7_3_fayda_pl8_Click(object sender, EventArgs e)
        {
            try
            {
                //esolasılık7_3_fayda TABLO verileri excel yazma
                Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                sayfa1.Name = "Eş Olasılık";
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
                OleDbCommand komut1 = new OleDbCommand("Select baslik_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 1];
                baslik1.Value2 = komut1.ExecuteScalar().ToString();

                OleDbCommand komut2 = new OleDbCommand("Select baslik_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range baslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 1];
                baslik2.Value2 = komut2.ExecuteScalar().ToString();

                OleDbCommand komut3 = new OleDbCommand("Select altbaslik_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 1];
                altbaslik1.Value2 = komut3.ExecuteScalar().ToString();

                OleDbCommand komut4 = new OleDbCommand("Select altbaslik_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 1];
                altbaslik2.Value2 = komut4.ExecuteScalar().ToString();

                OleDbCommand komut20 = new OleDbCommand("Select altbaslik_3 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 1];
                altbaslik3.Value2 = komut20.ExecuteScalar().ToString();

                OleDbCommand komut25 = new OleDbCommand("Select altbaslik_4 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 1];
                altbaslik4.Value2 = komut25.ExecuteScalar().ToString();

                OleDbCommand komut30 = new OleDbCommand("Select altbaslik_5 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 1];
                altbaslik5.Value2 = komut30.ExecuteScalar().ToString();

                OleDbCommand komut35 = new OleDbCommand("Select altbaslik_6 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 1];
                altbaslik6.Value2 = komut35.ExecuteScalar().ToString();

                OleDbCommand komut40 = new OleDbCommand("Select altbaslik_7 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range altbaslik7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 1];
                altbaslik7.Value2 = komut40.ExecuteScalar().ToString();

                OleDbCommand komut5 = new OleDbCommand("Select ustbaslik_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2];
                ustbaslik1.Value2 = komut5.ExecuteScalar().ToString();

                OleDbCommand komut6 = new OleDbCommand("Select ustbaslik_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 3];
                ustbaslik2.Value2 = komut6.ExecuteScalar().ToString();

                OleDbCommand komut7 = new OleDbCommand("Select ustbaslik_3 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range ustbaslik3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 4];
                ustbaslik3.Value2 = komut7.ExecuteScalar().ToString();

                OleDbCommand komut8 = new OleDbCommand("Select oran_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 2];
                oran1.Value2 = komut8.ExecuteScalar().ToString();

                OleDbCommand komut9 = new OleDbCommand("Select oran_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 3];
                oran2.Value2 = komut9.ExecuteScalar().ToString();

                OleDbCommand komut10 = new OleDbCommand("Select oran_3 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range oran3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 4];
                oran3.Value2 = komut10.ExecuteScalar().ToString();

                OleDbCommand komut11 = new OleDbCommand("Select veri_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 2];
                veri1.Value2 = komut11.ExecuteScalar().ToString();

                OleDbCommand komut12 = new OleDbCommand("Select veri_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 3];
                veri2.Value2 = komut12.ExecuteScalar().ToString();

                OleDbCommand komut13 = new OleDbCommand("Select veri_3 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 4];
                veri3.Value2 = komut13.ExecuteScalar().ToString();

                OleDbCommand komut14 = new OleDbCommand("Select veri_4 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 2];
                veri4.Value2 = komut14.ExecuteScalar().ToString();

                OleDbCommand komut15 = new OleDbCommand("Select veri_5 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 3];
                veri5.Value2 = komut15.ExecuteScalar().ToString();

                OleDbCommand komut16 = new OleDbCommand("Select veri_6 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 4];
                veri6.Value2 = komut16.ExecuteScalar().ToString();

                OleDbCommand komut21 = new OleDbCommand("Select veri_7 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri7 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 2];
                veri7.Value2 = komut21.ExecuteScalar().ToString();

                OleDbCommand komut22 = new OleDbCommand("Select veri_8 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri8 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 3];
                veri8.Value2 = komut22.ExecuteScalar().ToString();

                OleDbCommand komut23 = new OleDbCommand("Select veri_9 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri9 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 4];
                veri9.Value2 = komut23.ExecuteScalar().ToString();

                OleDbCommand komut26 = new OleDbCommand("Select veri_10 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri10 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 2];
                veri10.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut27 = new OleDbCommand("Select veri_11 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri11 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 3];
                veri11.Value2 = komut26.ExecuteScalar().ToString();

                OleDbCommand komut28 = new OleDbCommand("Select veri_12 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri12 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 4];
                veri12.Value2 = komut28.ExecuteScalar().ToString();

                OleDbCommand komut31 = new OleDbCommand("Select veri_13 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri13 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 2];
                veri13.Value2 = komut31.ExecuteScalar().ToString();

                OleDbCommand komut32 = new OleDbCommand("Select veri_14 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri14 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 3];
                veri14.Value2 = komut32.ExecuteScalar().ToString();

                OleDbCommand komut33 = new OleDbCommand("Select veri_15 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri15 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 4];
                veri15.Value2 = komut33.ExecuteScalar().ToString();

                OleDbCommand komut36 = new OleDbCommand("Select veri_16 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri16 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 2];
                veri16.Value2 = komut36.ExecuteScalar().ToString();

                OleDbCommand komut37 = new OleDbCommand("Select veri_17 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri17 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 3];
                veri17.Value2 = komut37.ExecuteScalar().ToString();

                OleDbCommand komut38 = new OleDbCommand("Select veri_18 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri18 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 4];
                veri18.Value2 = komut38.ExecuteScalar().ToString();

                OleDbCommand komut41 = new OleDbCommand("Select veri_19 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri19 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 2];
                veri19.Value2 = komut41.ExecuteScalar().ToString();

                OleDbCommand komut42 = new OleDbCommand("Select veri_20 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri20 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 3];
                veri20.Value2 = komut42.ExecuteScalar().ToString();

                OleDbCommand komut43 = new OleDbCommand("Select veri_21 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range veri21 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[9, 4];
                veri21.Value2 = komut43.ExecuteScalar().ToString();

                Microsoft.Office.Interop.Excel.Range sonucbaslik = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5];
                sonucbaslik.Value2 = "Sonuçlar";

                OleDbCommand komut17 = new OleDbCommand("Select sonuc_1 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc1 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[3, 5];
                sonuc1.Value2 = komut17.ExecuteScalar().ToString();

                OleDbCommand komut18 = new OleDbCommand("Select sonuc_2 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc2 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[4, 5];
                sonuc2.Value2 = komut18.ExecuteScalar().ToString();

                OleDbCommand komut24 = new OleDbCommand("Select sonuc_3 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc3 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[5, 5];
                sonuc3.Value2 = komut24.ExecuteScalar().ToString();

                OleDbCommand komut29 = new OleDbCommand("Select sonuc_4 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc4 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[6, 5];
                sonuc4.Value2 = komut29.ExecuteScalar().ToString();

                OleDbCommand komut34 = new OleDbCommand("Select sonuc_5 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc5 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[7, 5];
                sonuc5.Value2 = komut34.ExecuteScalar().ToString();

                OleDbCommand komut39 = new OleDbCommand("Select sonuc_6 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
                Microsoft.Office.Interop.Excel.Range sonuc6 = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[8, 5];
                sonuc6.Value2 = komut39.ExecuteScalar().ToString();

                OleDbCommand komut44 = new OleDbCommand("Select sonuc_7 From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

                OleDbCommand komut19 = new OleDbCommand("Select Fayda From esolasılık7_3_fayda where Id=" + esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString() + "", baglanti);
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

        //esolasılık7_3_fayda güncelleme yapmak için oluşturulmuş panel9 
        private void esolasılık7_3_fayda_pl9_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                id = esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

                double orantoplam = (Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) + Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) + Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text));
                if (Convert.ToString(orantoplam) == "0,99")
                {
                    double f1 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl20.Controls["txtveri1"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl21.Controls["txtveri2"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl26.Controls["txtveri3"].Text)));
                    double f2 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl22.Controls["txtveri4"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl23.Controls["txtveri5"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl27.Controls["txtveri6"].Text)));
                    double f3 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl32.Controls["txtveri7"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl33.Controls["txtveri8"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl34.Controls["txtveri9"].Text)));
                    double f4 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl37.Controls["txtveri10"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl38.Controls["txtveri11"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl39.Controls["txtveri12"].Text)));
                    double f5 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl42.Controls["txtveri13"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl43.Controls["txtveri14"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl44.Controls["txtveri15"].Text)));
                    double f6 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl47.Controls["txtveri16"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl48.Controls["txtveri17"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl49.Controls["txtveri18"].Text)));
                    double f7 = ((Convert.ToDouble(esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl52.Controls["txtveri19"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl53.Controls["txtveri20"].Text)) + (Convert.ToDouble(esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text) * Convert.ToDouble(esolasılık7_3_fayda_pl54.Controls["txtveri21"].Text)));
                    esolasılık7_3_fayda_pl29.Controls["txtf1sonuc"].Text = f1.ToString();
                    esolasılık7_3_fayda_pl30.Controls["txtf2sonuc"].Text = f2.ToString();
                    esolasılık7_3_fayda_pl35.Controls["txtf3sonuc"].Text = f3.ToString();
                    esolasılık7_3_fayda_pl40.Controls["txtf4sonuc"].Text = f4.ToString();
                    esolasılık7_3_fayda_pl45.Controls["txtf5sonuc"].Text = f5.ToString();
                    esolasılık7_3_fayda_pl50.Controls["txtf6sonuc"].Text = f6.ToString();
                    esolasılık7_3_fayda_pl55.Controls["txtf7sonuc"].Text = f7.ToString();
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
                    komut = new OleDbCommand("UPDATE esolasılık7_3_fayda SET baslik_1=@baslik_1,baslik_2=@baslik_2,altbaslik_1=@altbaslik_1,altbaslik_2=@altbaslik_2,altbaslik_3=@altbaslik_3,altbaslik_4=@altbaslik_4,altbaslik_5=@altbaslik_5,altbaslik_6=@altbaslik_6,altbaslik_7=@altbaslik_7,ustbaslik_1=@ustbaslik_1,ustbaslik_2=@ustbaslik_2,ustbaslik_3=@ustbaslik_3,oran_1=@oran_1,oran_2=@oran_2,oran_3=@oran_3,veri_1=@veri_1,veri_2=@veri_2,veri_3=@veri_3,veri_4=@veri_4,veri_5=@veri_5,veri_6=@veri_6,veri_7=@veri_7,veri_8=@veri_8,veri_9=@veri_9,veri_10=@veri_10,veri_11=@veri_11,veri_12=@veri_12,veri_13=@veri_13,veri_14=@veri_14,veri_15=@veri_15,veri_16=@veri_16,veri_17=@veri_17,veri_18=@veri_18,veri_19=@veri_19,veri_20=@veri_20,veri_21=@veri_21,sonuc_1=@sonuc_1,sonuc_2=@sonuc_2,sonuc_3=@sonuc_3,sonuc_4=@sonuc_4,sonuc_5=@sonuc_5,sonuc_6=@sonuc_6,sonuc_7=@sonuc_7,Fayda=@Fayda WHERE Id=@Id", baglanti);

                    komut.Parameters.AddWithValue("@baslik_1", esolasılık7_3_fayda_pl12.Controls["txtbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@baslik_2", esolasılık7_3_fayda_pl13.Controls["txtbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_1", esolasılık7_3_fayda_pl14.Controls["txtaltbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_2", esolasılık7_3_fayda_pl15.Controls["txtaltbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_3", esolasılık7_3_fayda_pl31.Controls["txtaltbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_4", esolasılık7_3_fayda_pl36.Controls["txtaltbaslik4"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_5", esolasılık7_3_fayda_pl41.Controls["txtaltbaslik5"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_6", esolasılık7_3_fayda_pl46.Controls["txtaltbaslik6"].Text.ToString());
                    komut.Parameters.AddWithValue("@altbaslik_7", esolasılık7_3_fayda_pl51.Controls["txtaltbaslik7"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_1", esolasılık7_3_fayda_pl16.Controls["txtüstbaslik1"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_2", esolasılık7_3_fayda_pl17.Controls["txtüstbaslik2"].Text.ToString());
                    komut.Parameters.AddWithValue("@ustbaslik_3", esolasılık7_3_fayda_pl24.Controls["txtüstbaslik3"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_1", esolasılık7_3_fayda_pl18.Controls["txtoran1"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_2", esolasılık7_3_fayda_pl19.Controls["txtoran2"].Text.ToString());
                    komut.Parameters.AddWithValue("@oran_3", esolasılık7_3_fayda_pl25.Controls["txtoran3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_1", esolasılık7_3_fayda_pl20.Controls["txtveri1"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_2", esolasılık7_3_fayda_pl21.Controls["txtveri2"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_3", esolasılık7_3_fayda_pl26.Controls["txtveri3"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_4", esolasılık7_3_fayda_pl22.Controls["txtveri4"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_5", esolasılık7_3_fayda_pl23.Controls["txtveri5"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_6", esolasılık7_3_fayda_pl27.Controls["txtveri6"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_7", esolasılık7_3_fayda_pl32.Controls["txtveri7"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_8", esolasılık7_3_fayda_pl33.Controls["txtveri8"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_9", esolasılık7_3_fayda_pl34.Controls["txtveri9"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_10", esolasılık7_3_fayda_pl37.Controls["txtveri10"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_11", esolasılık7_3_fayda_pl38.Controls["txtveri11"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_12", esolasılık7_3_fayda_pl39.Controls["txtveri12"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_13", esolasılık7_3_fayda_pl42.Controls["txtveri13"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_14", esolasılık7_3_fayda_pl43.Controls["txtveri14"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_15", esolasılık7_3_fayda_pl44.Controls["txtveri15"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_16", esolasılık7_3_fayda_pl47.Controls["txtveri16"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_17", esolasılık7_3_fayda_pl48.Controls["txtveri17"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_18", esolasılık7_3_fayda_pl49.Controls["txtveri18"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_19", esolasılık7_3_fayda_pl52.Controls["txtveri19"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_20", esolasılık7_3_fayda_pl53.Controls["txtveri20"].Text.ToString());
                    komut.Parameters.AddWithValue("@veri_21", esolasılık7_3_fayda_pl54.Controls["txtveri21"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_1", esolasılık7_3_fayda_pl29.Controls["txtf1sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_2", esolasılık7_3_fayda_pl30.Controls["txtf2sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_3", esolasılık7_3_fayda_pl35.Controls["txtf3sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_4", esolasılık7_3_fayda_pl40.Controls["txtf4sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_5", esolasılık7_3_fayda_pl45.Controls["txtf5sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_6", esolasılık7_3_fayda_pl50.Controls["txtf6sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@sonuc_7", esolasılık7_3_fayda_pl55.Controls["txtf7sonuc"].Text.ToString());
                    komut.Parameters.AddWithValue("@Fayda", büyükolanibul.ToString());
                    esolasılık7_3_fayda_pl4.Controls["sonuc"].Text = büyükolanibul.ToString();
                    komut.Parameters.AddWithValue("@Id", id.ToString());

                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    tablo.Clear();
                    esolasılık7_3_fayda_listele();
                    MessageBox.Show("Güncelleme  İşlemi Tamamlandı...");
                }
                else
                {
                    MessageBox.Show("Oranlar Toplamı 0,99 Olmalıdır...");
                }
            }
            catch (Exception hataTuru)
            {
                MessageBox.Show("Oran Veya Veri Textleri Karakter İçeremez...");
                string hata = "Hata meydana geldi." + hataTuru;
            }
        }
        //-------------------------------------------------

        //esolasılık7_3_fayda silme yapmak için oluşturulmuş panel10
        private void esolasılık7_3_fayda_pl10_Click(object sender, EventArgs e)
        {
            string id = "0";
            id = esolasılık7_3_fayda_dr1.CurrentRow.Cells[0].Value.ToString();

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from esolasılık7_3_fayda where Id=" + id.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            esolasılık7_3_fayda_listele();
            MessageBox.Show("Silme İşlemi Tamamlandı...");
        }
        //-------------------------------------------------

        //esolasılık7_3_fayda hakkında kısmı için panel11 oluşturuldu
        private void esolasılık7_3_fayda_pl11_Click(object sender, EventArgs e)
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

        private void BelirsizlikAltındaEsolasılıkFayda_Load(object sender, EventArgs e)
        {
            if (Karar_Modelleri.sayı == "Satır:2-Sütun:3")
            {
                formortala();
                esolasılık2_3_fayda();
                esolasılık2_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:3-Sütun:3")
            {
                formortala();
                esolasılık3_3_fayda();
                esolasılık3_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:4-Sütun:3")
            {
                formortala();
                esolasılık4_3_fayda();
                esolasılık4_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:5-Sütun:3")
            {
                formortala();
                esolasılık5_3_fayda();
                esolasılık5_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:6-Sütun:3")
            {
                formortala();
                esolasılık6_3_fayda();
                esolasılık6_3_fayda_listele();
            }
            if (Karar_Modelleri.sayı == "Satır:7-Sütun:3")
            {
                formortala();
                esolasılık7_3_fayda();
                esolasılık7_3_fayda_listele();
            }
        }
    }
}
