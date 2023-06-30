using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                var musteri = (from x in db.Tbl_Musteri.Where(x => x.DURUM == true)
                               select new
                               {
                                   x.MUSTERIID,
                                   x.MUSTERIAD,
                                   x.MUSTERISOYAD
                               }).ToList();
                Repeater1.DataSource = musteri;
                Repeater1.DataBind();



            }

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {

            Tbl_Musteri t = new Tbl_Musteri();
            t.MUSTERIAD = TxtAd.Text;
            t.MUSTERISOYAD = TxtSoyad.Text;
            db.Tbl_Musteri.Add(t);
            db.SaveChanges();
            Response.Redirect("Musteriler.Aspx");

        }

    }
}