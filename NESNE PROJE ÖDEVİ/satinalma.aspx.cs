using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NESNE_PROJE_ÖDEVİ
{
    public partial class satinalma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            



        }

        
        

        protected void btn_stn_Click1(object sender, EventArgs e)
        {
            Business.KişiBilgileri Kisi = new Business.KişiBilgileri();
            Kisi.ad = txt_isim.Value;
            Kisi.soyad = txt_soyad.Value;
            Kisi.mail = txt_mail.Value;
            Kisi.kacAdet = Convert.ToInt32(yetiskin.Value) + Convert.ToInt32(cocuk.Value);

            Response.Write("<script lang='JavaScript'>alert ('Başarıyla Bileti Satın Aldınız.');</script>");

           
           
        }
    }
}