using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urn = db.Tbl_Urun.Find(x);
            urn.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}