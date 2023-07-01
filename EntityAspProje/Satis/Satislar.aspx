<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="EntityAspProje.Satis.Satislar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#ModalSatisEkle">
        Yeni Satış Tanımla
    </button>
    <div class="modal" id="ModalSatisEkle">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Yeni Satış Paneli</h2>
                </div>
                <form runat="server">
                    <div class="modal-body">
                        <label>
                            Ürün Adı
                        </label>
                        <div>
                            <asp:DropDownList ID="TextUrunAdi" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                        <br />
                        <label>
                            Personel Adı
                        </label>
                        <div>
                            <asp:DropDownList ID="TextPersonelAdi" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                        <br />
                        <label>
                            Musteri Adı
                        </label>
                        <div>
                            <asp:DropDownList ID="TextMusteriAdi" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                        <br />
                        <label>
                            Fiyat
                        </label>
                        <asp:TextBox ID="TxtFiyat" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="BtnKaydet_Click" />
                        <asp:Button ID="Btnvazgec" runat="server" Text="Vazgeç" CssClass="btn btn-danger" data-dismiss="modal" />
                    </div>
                </form>
            </div>
        </div>
    </div>



    <table class="table table-bordered" style="margin-top: 20px">
        <tr>
            <th>SATIŞ ID</th>
            <th>ÜRÜN ADI</th>
            <th>PERSONEL </th>
            <th>MÜŞTERİ </th>
            <th>FİYAT</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SATISID")%></td>
                    <td><%#Eval("URUNAD")%></td>
                    <td><%#Eval("PERSONELADSOYAD")%></td>
                    <td><%#Eval("MUSTERI")%></td>
                    <td><%#Eval("FIYAT")%></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "~/Satis/SatisSil.Aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLinkSil" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%#"~/Satis/SatisGuncelle.Aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLinkGuncelle" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
