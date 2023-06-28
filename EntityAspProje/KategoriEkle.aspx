<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="EntityAspProje.KategoriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="fom-group">
        <div>
            <asp:TextBox ID="TextBoxKategori" runat="server" CssClass="form-control" placeholder="Kategori Adını Girin ..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Buttonekle" runat="server" CssClass="btn btn-success" Text="Kategori Ekle" OnClick="Buttonekle_Click"  />
        </div>
    </form>
</asp:Content>
