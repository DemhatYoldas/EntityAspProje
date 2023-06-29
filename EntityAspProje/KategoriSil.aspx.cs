using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPDBEntities db=new ASPDBEntities();
            int X =Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p=db.Tbl_Kategori.Find(X);
            db.Tbl_Kategori.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}