<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
    <form runat="server" class="fom-group">
        <div>
            <asp:TextBox ID="TextUrunAd" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunMarka" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <br />
         <div>
             <asp:DropDownList ID="TextUrunKategori" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunFiyat" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunStok" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="ButtonUrunGuncelle" runat="server" CssClass="btn btn-warning" Text="Güncelle" OnClick="ButtonUrunGuncelle_Click"/>
        </div>
    </form>

</asp:Content>
