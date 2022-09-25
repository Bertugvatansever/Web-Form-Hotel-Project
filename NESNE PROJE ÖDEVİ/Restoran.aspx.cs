using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NESNE_PROJE_ÖDEVİ
{
    public partial class Restoran : System.Web.UI.Page
    {
        List<Business.Restoran> restoranList = new List<Business.Restoran>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Business.Restoran alanyaGünesi = new Business.Restoran();
            alanyaGünesi.ulkeAdi = "Türkiye";
            alanyaGünesi.sehirAdi = "Alanya";
            alanyaGünesi.restoranAdi = "Alanya Günesi";
            alanyaGünesi.yildiz = 5;
            alanyaGünesi.fiyat = 200;
            restoranList.Add(alanyaGünesi);
            Business.Restoran susona = new Business.Restoran();
            susona.ulkeAdi = "Türkiye";
            susona.sehirAdi = "Bodrum";
            susona.restoranAdi = "Susona";
            susona.yildiz = 4;
            susona.fiyat = 300;
            restoranList.Add(susona);
            Business.Restoran sahil = new Business.Restoran();
            sahil.ulkeAdi = "Türkiye";
            sahil.sehirAdi = "İstanbul";
            sahil.restoranAdi = "Sahil";
            sahil.yildiz = 5;
            sahil.fiyat = 500;
            restoranList.Add(sahil);
            Business.Restoran sevim = new Business.Restoran();
            sevim.ulkeAdi = "Türkiye";
            sevim.sehirAdi = "Aydin";
            sevim.restoranAdi = "Sevim";
            sevim.yildiz = 4;
            sevim.fiyat = 400;
            restoranList.Add(sevim);
            Business.Restoran proveza = new Business.Restoran();
            proveza.ulkeAdi = "Türkiye";
            proveza.sehirAdi = "Marmaris";
            proveza.restoranAdi = "Proveza";
            proveza.yildiz = 4;
            proveza.fiyat = 500;
            restoranList.Add(proveza);
            Business.Restoran collezium = new Business.Restoran();
            collezium.ulkeAdi = "İtalya";
            collezium.sehirAdi = "Roma";
            collezium.restoranAdi = "Collezium";
            collezium.yildiz = 4;
            collezium.fiyat = 200;
            restoranList.Add(collezium);


            repeaterRestoranList.DataSource = restoranList;
            repeaterRestoranList.DataBind();


        }

        

        protected void Btn3_Click(object sender, EventArgs e)
        {
            if (sehir.Value == string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen şehir seçiniz.');</script>");
            }
            if (ulke.Value == string.Empty)
            {
                Response.Write("<script lang='JavaScript'>alert ('Lütfen ülke seçiniz.');</script>");
            }
            if (sehir.Value == "Antalya" && ulke.Value == "Türkiye")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Antalya").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Bodrum" && ulke.Value == "Türkiye")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Bodrum").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "İstanbul" && ulke.Value == "Türkiye")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "İstanbul").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Aydın" && ulke.Value == "Türkiye")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Aydın").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Marmaris" && ulke.Value == "Türkiye")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Marmaris").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Paris" && ulke.Value == "Fransa")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Paris").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Roma" && ulke.Value == "İtalya")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Roma").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Venedik" && ulke.Value == "İtalya")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Venedik").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Tokyo" && ulke.Value == "Japonya")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Tokyo").ToList();
                repeaterRestoranList.DataBind();
            }
           else if (sehir.Value == "Pekin" && ulke.Value == "Çin")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Pekin").ToList();
                repeaterRestoranList.DataBind();
            }
            else if (sehir.Value == "Mumbai" && ulke.Value == "Hindistan")
            {
                repeaterRestoranList.DataSource = restoranList.Where(x => x.sehirAdi == "Mumbai").ToList();
                repeaterRestoranList.DataBind();
            }
            else
            {

            }

        }
    }
}