<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="EntityAspProje.KategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="fom-group">
        <div>
            <asp:TextBox ID="TxtId" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control" placeholder="Kategori Adını Girin"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="ButtonGuncelle" runat="server" CssClass="btn btn-success" Text="Kategori Güncelle" OnClick="ButtonGuncelle_Click"/>
        </div>
    </form>

</asp:Content>
