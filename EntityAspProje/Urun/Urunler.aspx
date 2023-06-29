<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAspProje.Urun.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>ÜRÜN MARKA</th>
            <th>ÜRÜN KATEGORİ</th>
            <th>ÜRÜN FİYAT</th>
            <th>ÜRÜN STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID")%></td>
                    <td><%#Eval("URUNAD")%></td>
                    <td><%#Eval("URUNMARKA")%></td>
                    <td><%#Eval("KATEGORIAD")%></td>
                    <td><%#Eval("URUNFİYAT")%></td>
                    <td><%#Eval("URUNSTOK")%></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "~/Urun/UrunSil.Aspx?URUNID=" + Eval("URUNID") %>' ID="HyperLinkSil" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%#"~/Urun/UrunGuncelle.Aspx?URUNID=" + Eval("URUNID") %>' ID="HyperLinkGuncelle" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
       <a href="YeniUrun.Aspx" class="btn btn-info">Yeni Ürün</a>
</asp:Content>
