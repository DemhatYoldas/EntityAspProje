using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Login : System.Web.UI.Page
    {
        ASPDBEntities db=new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where
                      x.KULLANICI == Txtkullaniciad.Text &&
                      x.SIFRE == Txtkullanicisifre.Text select x;
            if (sorgu.Any())// sorgu içersinde bir şey gerçekleştiyse 
            {
                Response.Redirect("Kategoriler.Aspx");
            }
            else
            {
                
                Response.Write("Kullanıcı adı veya Şifre Hatalı !!! ");
            }
        }
    }
}