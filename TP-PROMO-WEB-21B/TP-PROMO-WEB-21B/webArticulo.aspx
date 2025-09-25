<%@ Page Title="" Language="C#" MasterPageFile="~/promoMaster.Master" AutoEventWireup="true" CodeBehind="webArticulo.aspx.cs" Inherits="TP_PROMO_WEB_21B.webArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">codigo</label>
                <asp:TextBox runat="server" ID="txtCodigo" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="TxtNombre" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:textBox runat="server" TexMode="MultiLine" ID="TxtDescrpcion" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="TxtPrecio" cssclass="form-control" />
            </div>

            


        </div>
    </div>

</asp:Content>
