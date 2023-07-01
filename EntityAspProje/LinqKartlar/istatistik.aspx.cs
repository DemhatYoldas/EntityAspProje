using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinqKartlar
{
    public partial class istatistik : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text=db.Tbl_Urun.Count().ToString();
            Label2.Text=db.Tbl_Musteri.Count().ToString();
            Label3.Text = db.Tbl_Satis.Sum(x => x.FIYAT).ToString();
            Label4.Text=db.Tbl_Kategori.Count().ToString();
            Label5.Text=db.Tbl_Urun.Count(x=>x.DURUM==true).ToString();
            Label6.Text=db.Tbl_Urun.Count(x=>x.DURUM==false).ToString();
            Label7.Text = (from x in db.Tbl_Urun orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
            Label8.Text = (from d1 in db.Tbl_Urun
                           join d2 in db.Tbl_Kategori on
                           d1.URUNKATEGORİ equals d2.KATEGORIID
                           group d1 by d2 into g
                           orderby g.Count() descending
                           select g.Key.KATEGORIAD).FirstOrDefault();

        }
    }
}