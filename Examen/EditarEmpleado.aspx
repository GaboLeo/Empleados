<%@ Page Title="" Language="C#" MasterPageFile="~/MasterEmpleados.master" AutoEventWireup="true" CodeFile="EditarEmpleado.aspx.cs" Inherits="EditarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">
        <div class="row">

            <br />
            <label>Nombre:</label>
            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" PlaceHolder="Ingresa nombre completo." />
            <br />
            <label>Puesto</label>
            <asp:DropDownList CssClass="form-control" runat="server" ID="ddlPuestos" AppendDataBoundItems="true">
                <asp:ListItem Value="-1" Text="[Selecciona uno]" />
            </asp:DropDownList>
            <br />
            <label>Departamento: </label>
            <asp:DropDownList CssClass="form-control" ID="ddlDepartamentos" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Value="-1" Text="[Selecciona uno]" />
            </asp:DropDownList>
            <div>
                <asp:Button Text="Guardar" ID="btnGuardar" runat="server" CssClass="btn btn-info" />
            </div>
        </div>
    </div>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</asp:Content>

