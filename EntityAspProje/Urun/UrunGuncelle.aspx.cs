using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kate = (from s in db.Tbl_Kategori select new { s.KATEGORIID, s.KATEGORIAD }).ToList();
                TextUrunKategori.DataTextField = "KATEGORIAD";
                TextUrunKategori.DataValueField = "KATEGORIID";
                TextUrunKategori.DataSource = kate;
                TextUrunKategori.DataBind();

                int x = Convert.ToInt32(Request.QueryString["URUNID"]);
                var p = db.Tbl_Urun.Find(x);
                TextUrunAd.Text = p.URUNAD;
                TextUrunMarka.Text = p.URUNMARKA;
                TextUrunKategori.Text = p.URUNKATEGORİ.ToString();
                TextUrunFiyat.Text=p.URUNFİYAT.ToString(); 
                TextUrunStok.Text=p.URUNSTOK.ToString();
                TextUrunKategori.SelectedValue = p.URUNKATEGORİ.ToString();
            }

        }

        protected void ButtonUrunGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urn = db.Tbl_Urun.Find(x);
            urn.URUNAD = TextUrunAd.Text;
            urn.URUNMARKA= TextUrunMarka.Text;
            urn.URUNKATEGORİ =byte.Parse(TextUrunKategori.SelectedValue.ToString());
            urn.URUNFİYAT = decimal.Parse(TextUrunFiyat.Text);
            urn.URUNSTOK = short.Parse(TextUrunStok.Text);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}