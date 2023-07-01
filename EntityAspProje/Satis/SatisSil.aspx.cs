using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class SatisSil : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();   
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["SATISID"]);
            var satis = db.Tbl_Satis.Find(x);
            satis.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Satislar.Aspx");
        }
    }
}