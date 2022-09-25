using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NESNE_PROJE_ÖDEVİ
{
    public partial class Tur : System.Web.UI.Page
    {

        List<Business.Tur> turList = new List<Business.Tur>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Business.Tur antalya = new Business.Tur();
            antalya.ulkeAdi = "Türkiye";
            antalya.sehirAdi = "Antalya";
            antalya.yildiz = 5;
            antalya.fiyat = 200;
            turList.Add(antalya);

            Business.Tur Bodrum = new Business.Tur();
            Bodrum.ulkeAdi = "Türkiye";
            Bodrum.sehirAdi = "Bodrum";
            Bodrum.yildiz = 4;
            Bodrum.fiyat = 300;
            turList.Add(Bodrum);

            Business.Tur İstanbul = new Business.Tur();
            İstanbul.ulkeAdi = "Türkiye";
            İstanbul.sehirAdi = "İstanbul";
            İstanbul.yildiz = 5;
            İstanbul.fiyat = 500;
            turList.Add(İstanbul);

            Business.Tur Aydin = new Business.Tur();
            Aydin.ulkeAdi = "Türkiye";
            Aydin.sehirAdi = "Aydın";
            Aydin.yildiz = 4;
            Aydin.fiyat = 400;
            turList.Add(Aydin);
            Business.Tur Marmaris = new Business.Tur();
            Marmaris.ulkeAdi = "Türkiye";
            Marmaris.sehirAdi = "Marmaris";
            Marmaris.yildiz = 4;
            Marmaris.fiyat = 500;
            turList.Add(Marmaris);
            Business.Tur Mumbai = new Business.Tur();
            Mumbai.ulkeAdi = "Hindistan";
            Mumbai.sehirAdi = "Mumbai";
            Mumbai.yildiz = 4;
            Mumbai.fiyat = 200;
            turList.Add(Mumbai);
            Business.Tur Paris = new Business.Tur();
            Paris.ulkeAdi = "Fransa";
            Paris.sehirAdi = "Paris";
            Paris.yildiz = 5;
            Paris.fiyat = 200;
            turList.Add(Paris);
            Business.Tur Roma = new Business.Tur();
            Roma.ulkeAdi = "İtalya";
            Roma.sehirAdi = "Roma";
            Roma.yildiz = 4;
            Roma.fiyat = 300;
            turList.Add(Roma);
            Business.Tur Venedik = new Business.Tur();
            Venedik.ulkeAdi = "İtalya";
            Venedik.sehirAdi = "Venedik";
            Venedik.yildiz = 5;
            Venedik.fiyat = 500;
            turList.Add(Venedik);
            Business.Tur Brüksel = new Business.Tur();
            Brüksel.ulkeAdi = "Belçika";
            Brüksel.sehirAdi = "Brüksel";
            Brüksel.yildiz = 4;
            Brüksel.fiyat = 400;
            turList.Add(Brüksel);
            Business.Tur Tokyo = new Business.Tur();
            Tokyo.ulkeAdi = "Japonya";
            Tokyo.sehirAdi = "Tokyo";
            Tokyo.yildiz = 4;
            Tokyo.fiyat = 500;
            turList.Add(Tokyo);
            Business.Tur Pekin = new Business.Tur();
            Pekin.ulkeAdi = "Çin";
            Pekin.sehirAdi = "Pekin";
            Pekin.yildiz = 4;
            Pekin.fiyat = 200;
            turList.Add(Pekin);

            repeaterTurList.DataSource = turList;
            repeaterTurList.DataBind();


        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            if(sehir.Value==string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen şehir seçiniz.');</script>");
            }
            if(ulke.Value==string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen ülke seçiniz.');</script>");
            }
            // Şehirler
            if (sehir.Value=="Antalya" && ulke.Value=="Türkiye")
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Antalya").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Bodrum" && ulke.Value=="Türkiye" )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Bodrum").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "İstanbul" && ulke.Value == "Türkiye"  )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "İstanbul").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Aydın" && ulke.Value == "Türkiye"  )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Aydın").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Marmaris" && ulke.Value == "Türkiye" )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Marmaris").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Paris" && ulke.Value == "Fransa" )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Paris").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Roma" && ulke.Value == "İtalya" )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Roma").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Venedik" && ulke.Value =="İtalya" )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Venedik").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Tokyo" && ulke.Value == "Japonya"  )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Tokyo").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Pekin" && ulke.Value == "Çin"  )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Pekin").ToList();
                repeaterTurList.DataBind();
            }
           else if (sehir.Value == "Mumbai" && ulke.Value == "Hindistan"  )
            {
                repeaterTurList.DataSource = turList.Where(x => x.sehirAdi == "Mumbai").ToList();
                repeaterTurList.DataBind();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert ('Geçerli şehir veya ülke seçiniz.');</script>");
            }
            
            // yıldız filtrelemesi
            
            


        }
    }
}