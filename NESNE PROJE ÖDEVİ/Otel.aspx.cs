using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NESNE_PROJE_ÖDEVİ
{
    public partial class Otel : System.Web.UI.Page
    {
        List<Business.Otel> otelList = new List<Business.Otel>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Business.Otel antalyaotel = new Business.Otel();
            antalyaotel.ulkeAdi = "Türkiye";
            antalyaotel.sehirAdi = "Antalya";
            antalyaotel.yildiz = 4;
            antalyaotel.fiyat = 40;
            otelList.Add(antalyaotel);
            Business.Otel bodrumotel = new Business.Otel();
            bodrumotel.ulkeAdi = "Türkiye";
            bodrumotel.sehirAdi = "Bodrum";
            bodrumotel.yildiz = 4;
            bodrumotel.fiyat = 60;
            otelList.Add(bodrumotel);
            Business.Otel istanbulotel = new Business.Otel();
            istanbulotel.ulkeAdi = "Türkiye";
            istanbulotel.sehirAdi = "İstanbul";
            istanbulotel.yildiz = 5;
            istanbulotel.fiyat = 45;
            otelList.Add(istanbulotel);
            Business.Otel aydinotel = new Business.Otel();
            aydinotel.ulkeAdi = "Türkiye";
            aydinotel.sehirAdi = "Aydin";
            aydinotel.yildiz = 4;
            aydinotel.fiyat = 30;
            otelList.Add(aydinotel);
            Business.Otel marmarisotel = new Business.Otel();
            marmarisotel.ulkeAdi = "Türkiye";
            marmarisotel.sehirAdi = "Marmaris";
            marmarisotel.yildiz = 4;
            marmarisotel.fiyat = 60;
            otelList.Add(marmarisotel);
            Business.Otel mumbaiotel = new Business.Otel();
            mumbaiotel.ulkeAdi = "Hindistan";
            mumbaiotel.sehirAdi = "Mumbai";
            mumbaiotel.yildiz = 4;
            mumbaiotel.fiyat = 70;
            otelList.Add(mumbaiotel);
            Business.Otel parisotel = new Business.Otel();
            parisotel.ulkeAdi = "Fransa";
            parisotel.sehirAdi = "Paris";
            parisotel.yildiz = 4;
            parisotel.fiyat = 40;
            otelList.Add(parisotel);
            Business.Otel romaotel = new Business.Otel();
            romaotel.ulkeAdi = "İtalya";
            romaotel.sehirAdi = "Roma";
            romaotel.yildiz = 4;
            romaotel.fiyat = 30;
            otelList.Add(romaotel);
            Business.Otel venedikotel = new Business.Otel();
            venedikotel.ulkeAdi = "İtalya";
            venedikotel.sehirAdi = "Venedik";
            venedikotel.yildiz = 4;
            venedikotel.fiyat =60;
            otelList.Add(venedikotel);
            Business.Otel brükselotel = new Business.Otel();
            brükselotel.ulkeAdi = "Belçika";
            brükselotel.sehirAdi = "Brüksel";
            brükselotel.yildiz = 4;
            brükselotel.fiyat = 45;
            otelList.Add(brükselotel);
            Business.Otel tokyootel = new Business.Otel();
            tokyootel.ulkeAdi = "Japonya";
            tokyootel.sehirAdi = "Tokyo";
            tokyootel.yildiz = 4;
            tokyootel.fiyat = 60;
            otelList.Add(tokyootel);
            Business.Otel pekinotel = new Business.Otel();
            pekinotel.ulkeAdi = "Çin";
            pekinotel.sehirAdi = "Pekin";
            pekinotel.yildiz = 4;
            pekinotel.fiyat = 70;
            otelList.Add(pekinotel);

            repeaterOtelList.DataSource = otelList;
            repeaterOtelList.DataBind();
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            // Ülkeler
            if (sehir.Value == string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen şehir seçiniz.');</script>");
            }
            if (ulke.Value == string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen ülke seçiniz.');</script>");
            }
            // Şehirler
            if (sehir.Value == "Antalya" && ulke.Value == "Türkiye")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Antalya").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Bodrum" && ulke.Value == "Türkiye")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Bodrum").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "İstanbul" && ulke.Value == "Türkiye")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "İstanbul").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Aydın" && ulke.Value == "Türkiye")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Aydın").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Marmaris" && ulke.Value == "Türkiye")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Marmaris").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Paris" && ulke.Value == "Fransa")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Paris").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Roma" && ulke.Value == "İtalya")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Roma").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Venedik" && ulke.Value == "İtalya")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Venedik").ToList();
                repeaterOtelList.DataBind();
            }
            else if (sehir.Value == "Tokyo" && ulke.Value == "Japonya")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Tokyo").ToList();
                repeaterOtelList.DataBind();
            }
           else if (sehir.Value == "Pekin" && ulke.Value == "Çin")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Pekin").ToList();
                repeaterOtelList.DataBind();
            }
            else if (sehir.Value == "Mumbai" && ulke.Value == "Hindistan")
            {
                repeaterOtelList.DataSource = otelList.Where(x => x.sehirAdi == "Mumbai").ToList();
                repeaterOtelList.DataBind();
            }
            else
            {

            }
           
        }
    }
}