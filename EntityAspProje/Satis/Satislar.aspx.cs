using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class Satislar : System.Web.UI.Page
    { 
        /* BU KSIM anonymus oluyor yabi bir sutunda iki tablo çekiyorsun ve çekebilmen için ad veriyorsun 
         * MUSTERI = x.Tbl_Musteri.MUSTERIAD +" "+ x.Tbl_Musteri.MUSTERISOYAD 
         */

        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                var satis = (from x in db.Tbl_Satis.Where(x => x.DURUM == true)
                             select new
                             {
                                 x.SATISID,
                                 x.Tbl_Urun.URUNAD,
                                 x.Tbl_Personel.PERSONELADSOYAD,
                                 MUSTERI = x.Tbl_Musteri.MUSTERIAD +" "+ x.Tbl_Musteri.MUSTERISOYAD,
                                 x.FIYAT
                             }).ToList();
                Repeater1.DataSource = satis;
                Repeater1.DataBind();
            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}