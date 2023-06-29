using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YeniUrun : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                var kate = (from x in db.Tbl_Kategori select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                TextUrunKategori.DataTextField = "KATEGORIAD";
                TextUrunKategori.DataValueField = "KATEGORIID";
                TextUrunKategori.DataSource = kate;
                TextUrunKategori.DataBind();
            }
           
        }

        protected void Buttonekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.URUNAD = TextUrunAd.Text;
            t.URUNMARKA = TextUrunMarka.Text;
            t.URUNKATEGORİ = byte.Parse(TextUrunKategori.SelectedValue.ToString());
            t.URUNFİYAT = decimal.Parse(TextUrunFiyat.Text);
            t.URUNSTOK =short.Parse(TextUrunStok.Text);
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}