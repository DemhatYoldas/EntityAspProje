using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.Tbl_Urun.Where(x=>x.DURUM==true).ToList();
            var urunler = (from x in db.Tbl_Urun.Where(x=>x.DURUM==true) select  new 
            {
                x.URUNID,
                x.URUNAD,
                x.URUNMARKA,
                x.Tbl_Kategori.KATEGORIAD,
                x.URUNFİYAT,
                x.URUNSTOK
            }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}