/*****************************************************
**             SAKARYA ÜNİVERSİTESİ
**     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**        NESNEYE DAYALI PROGRAMLAMA DERSİ
**             2018-2019 BAHAR DÖNEMİ
**
**             PROJE
**             ÖĞRENCİ ADI........:AHMET SELİM ÖZTRÜK
**             ÖĞRENCİ NUMARASI...:G181210082
**             DERSİNİ ALDIĞI GRUP:B
****************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        int kasa_toplam = 0;

        Tavuk tavuk = new Tavuk();
        Keci keci = new Keci();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();

        public Form1()
        {
            InitializeComponent();
            tavukprogessbar.Value = tavuk.Enerji;
            keciprogessbar.Value = keci.Enerji;
            ördekprogessbar.Value = ordek.Enerji;
            inekprogessbar.Value = inek.Enerji;
            saniyelbl.Text = 0 + " SN";
            lbltavukyumurtasi.Text = 0 + " ADET";
            lblineksutu.Text = 0 + " KG";
            lblkecisutu.Text = 0 + " KG";
            lblordekyumurtasi.Text = 0 + " ADET";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gecensure_Tick(object sender, EventArgs e)
        {
            sayac++;

            saniyelbl.Text = Convert.ToString(sayac) + " SN";



            //TAVUK
            //tavuğa ait Yasam methodu true döndürüyorsa tavuğun enerji azalmaya devam edecek.
            if (tavuk.Yasam() == true)
            {
                tavukprogessbar.Value = tavuk.EnerjiHarcama();
            }
            //tavuğa ait Yasam methodu false döndürüyorsa tavuk ölecek ve ölürken ses çıkarcak.
            else
            {
                //tavuğun sadece bir kez ses çıkarması için tavuğun tavukkontrol değişkenini ilk başta true yaptık.Tavuk ses çıkardıktan sonra
                //tavukkontorlü false yaptık ve while döngüsünün sadece bir kez çalışmasını sağladık.
                while (tavuk.tavukkontrol == true)
                {
                    tavuk.Ses();
                }
                lbltavukyasam.Text = "ÖLDÜ";
                tavukyemverbtn.Enabled = false;
            }



            //İNEK
            //ineğe ait Yasam methodu true döndürüyorsa ineğin enerji azalmaya devam edecek.
            if (inek.Yasam() == true)
            {
                inekprogessbar.Value = inek.EnerjiHarcama();
            }
            //ineğe ait Yasam methodu false döndürüyorsa inek ölecek ve ölürken ses çıkarcak.
            else
            {
                //ineğin sadece bir kez ses çıkarması için ineğin inekkontrol değişkenini ilk başta true yaptık.İnek ses çıkardıktan sonra
                //inekkontorlü false yaptık ve while döngüsünün sadece bir kez çalışmasını sağladık.
                while (inek.inekkontrol == true)
                {
                    inek.Ses();
                }
                lblinekyasam.Text = "ÖLDÜ";
                inekyemverbtn.Enabled = false;
            }



            //ÖRDEK
            //ördeğe ait Yasam methodu true döndürüyorsa ördeğin enerji azalmaya devam edecek.
            if (ordek.Yasam() == true)
            {
                ördekprogessbar.Value = ordek.EnerjiHarcama();
            }
            //ördeğe ait Yasam methodu false döndürüyorsa ördek ölecek ve ölürken ses çıkarcak.
            else
            {
                //ördeğin sadece bir kez ses çıkarması için ördeğin ördekkontrol değişkenini ilk başta true yaptık.Ördek ses çıkardıktan sonra
                //ördekkontorlü false yaptık ve while döngüsünün sadece bir kez çalışmasını sağladık.
                while (ordek.ordekkontrol == true)
                {
                    ordek.Ses();
                }
                lblordekyasam.Text = "ÖLDÜ";
                ordekyemverbtn.Enabled = false;
            }



            //KEÇİ
            //keciye ait Yasam methodu true döndürüyorsa kecinin enerji azalmaya devam edecek.
            if (keci.Yasam() == true)
            {

                keciprogessbar.Value = keci.EnerjiHarcama();
            }
            //keciye ait Yasam methodu false döndürüyorsa keci ölecek ve ölürken ses çıkarcak.
            else
            {
                //kecinin sadece bir kez ses çıkarması için kecinin kecikontrol değişkenini ilk başta true yaptık.Keçi ses çıkardıktan sonra
                //keçikontorlü false yaptık ve while döngüsünün sadece bir kez çalışmasını sağladık.
                while (keci.kecikontrol == true)
                {
                    keci.Ses();
                }
                lblkeciyasam.Text = "ÖLDÜ";
                keciyemverbtn.Enabled = false;
            }



            //ÜRÜN ARTIŞI
            //sayacın 3'e bölümünden kalan 0'sa tavuğun ürün methodu çalışacak.
            if (sayac % 3 == 0)
            {
                lbltavukyumurtasi.Text = Convert.ToString(tavuk.Urun()) + " KG";
            }
            //sayacın 7'ye bölümünden kalan 0'sa keçinin ürün methodu çalışacak.
            if (sayac % 7 == 0)
            {
                lblkecisutu.Text = Convert.ToString(keci.Urun()) + " KG";
            }
            //sayacın 5'e bölümünden kalan 0'sa ördeğin ürün methodu çalışacak.
            if (sayac % 5 == 0)
            {
                lblordekyumurtasi.Text = Convert.ToString(ordek.Urun()) + " KG";
            }
            //sayacın 8'e bölümünden kalan 0'sa ineğin ürün methodu çalışacak.
            if (sayac % 8 == 0)
            {
                lblineksutu.Text = Convert.ToString(inek.Urun()) + " KG";
            }
        }

        //-------------------------------------------------------------------------------------------------------//

        //YEM VER METHODLARI
        private void tavukyemverbtn_Click(object sender, EventArgs e)
        {
            tavukprogessbar.Value = tavuk.CanBas();
        }
        private void inekyemverbtn_Click(object sender, EventArgs e)
        {
            inekprogessbar.Value = inek.CanBas();
        }
        private void ordekyemverbtn_Click(object sender, EventArgs e)
        {
            ördekprogessbar.Value = ordek.CanBas();
        }
        private void keciyemverbtn_Click(object sender, EventArgs e)
        {
            keciprogessbar.Value = keci.CanBas();
        }

        //-------------------------------------------------------------------------------------------------------//
        //ÜRÜN SATIŞI
        private void btntavukyumurtasisat_Click(object sender, EventArgs e)
        {
            kasa_toplam += tavuk.Gelir();
            lblkasatoplam.Text = Convert.ToString(kasa_toplam) + " ₺";
            lbltavukyumurtasi.Text = 0 + " ADET";
        }

        private void btnordekyumurtasisat_Click(object sender, EventArgs e)
        {
            kasa_toplam += ordek.Gelir();
            lblkasatoplam.Text = Convert.ToString(kasa_toplam) + " ₺";
            lblordekyumurtasi.Text = 0 + " ADET";
        }

        private void btnineksutusat_Click(object sender, EventArgs e)
        {
            kasa_toplam += inek.Gelir();
            lblkasatoplam.Text = Convert.ToString(kasa_toplam) + " ₺";
            lblineksutu.Text = 0 + " KG";
        }

        private void btnkecisutusat_Click(object sender, EventArgs e)
        {
            kasa_toplam += keci.Gelir();
            lblkasatoplam.Text = Convert.ToString(kasa_toplam) + " ₺";
            lblkecisutu.Text = 0 + " KG";
        }

        //-------------------------------------------------------------------------------------------------------//
    }
}
