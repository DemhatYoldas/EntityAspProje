<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniUrun.aspx.cs" Inherits="EntityAspProje.Urun.YeniUrun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="fom-group">
        <div>
            <asp:TextBox ID="TextUrunAd" runat="server" CssClass="form-control" placeholder="Ürün Adını Girin ..."></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunMarka" runat="server" CssClass="form-control" placeholder="Marka Adını Girin ..."></asp:TextBox>
        </div>
        <br />
         <div>
             <asp:DropDownList ID="TextUrunKategori" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunFiyat" runat="server" CssClass="form-control" placeholder="Fiyat Girin ..."></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextUrunStok" runat="server" CssClass="form-control" placeholder="Stok Adedi Girin ..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="ButtonUrunekle" runat="server" CssClass="btn btn-primary" Text="Ürün Ekle" OnClick="Buttonekle_Click"/>
        </div>
    </form>

</asp:Content>
