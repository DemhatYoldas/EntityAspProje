using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtId.Text = x.ToString();
                var ktgr = db.Tbl_Kategori.Find(x);
                TxtAd.Text = ktgr.KATEGORIAD;

            }


        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.KATEGORIAD = TxtAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}