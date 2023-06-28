using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonekle_Click(object sender, EventArgs e)
        {
            ASPDBEntities db = new ASPDBEntities();
            Tbl_Kategori t = new Tbl_Kategori();
            t.KATEGORIAD = TextBoxKategori.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}