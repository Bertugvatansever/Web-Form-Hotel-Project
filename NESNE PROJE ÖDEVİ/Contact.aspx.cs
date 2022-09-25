using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NESNE_PROJE_ÖDEVİ
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Business.iletisim bilgiler = new Business.iletisim();
            bilgiler.ad = isim.Value;
            bilgiler.soyad = soyİsim.Value;
            bilgiler.email = email.Value;
            bilgiler.konu = subject.Value;

        }
    }
}