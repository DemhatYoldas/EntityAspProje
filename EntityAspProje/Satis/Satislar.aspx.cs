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

                var urn = (from x in db.Tbl_Urun select new { x.URUNID, x.URUNAD }).ToList();
                TextUrunAdi.DataTextField = "URUNAD";
                TextUrunAdi.DataValueField = "URUNID";
                TextUrunAdi.DataSource = urn;
                TextUrunAdi.DataBind();

                var pers = (from x in db.Tbl_Personel select new { x.PERSONELID, x.PERSONELADSOYAD }).ToList();
                TextPersonelAdi.DataTextField = "PERSONELADSOYAD";
                TextPersonelAdi.DataValueField = "PERSONELID";
                TextPersonelAdi.DataSource = pers;
                TextPersonelAdi.DataBind();

                var msteri = (from x in db.Tbl_Musteri select new { x.MUSTERIID, MUSTERI=x.MUSTERIAD+" " +x.MUSTERISOYAD }).ToList();
                TextMusteriAdi.DataTextField = "MUSTERI";
                TextMusteriAdi.DataValueField = "MUSTERIID";
                TextMusteriAdi.DataSource = msteri;
                TextMusteriAdi.DataBind();

            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            Tbl_Satis s = new Tbl_Satis();
            s.URUN = int.Parse(TextUrunAdi.Text);
            s.PERSONEL =byte.Parse(TextPersonelAdi.Text);
            s.MUSTERI =int.Parse(TextMusteriAdi.Text);
            s.FIYAT = int.Parse(TxtFiyat.Text);
            s.DURUM = true;
            db.Tbl_Satis.Add(s);
            db.SaveChanges();
            Response.Redirect("Satislar.Aspx");
        }
    }
}