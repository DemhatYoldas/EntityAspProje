<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAspProje.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>Kategori ID</th>
            <th>Kategori ADI</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KATEGORIID")%></td>
                    <td><%#Eval("KATEGORIAD")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLinkSil" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink ID="HyperLinkGuncelle" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="KategoriEkle.Aspx" class="btn btn-info">Yeni Kategori</a>
</asp:Content>
