<%@ Page Title="" Language="C#" MasterPageFile="~/promoMaster.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="TP_PROMO_WEB_21B.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvArticulos" CssClass="table table-dark table-bordered" runat="server"></asp:GridView>
</asp:Content>
