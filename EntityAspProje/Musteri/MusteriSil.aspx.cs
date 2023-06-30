using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class MusteriSil : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            var mustri = db.Tbl_Musteri.Find(x);
            mustri.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Musteriler.Aspx");
        }
    }
}