<%@ Page Title="" Language="C#" MasterPageFile="~/MasterEmpleados.master" AutoEventWireup="true" CodeFile="ConsultaEmpleados.aspx.cs" Inherits="ConsultaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <div class="container">
        <div class="row">
            <br />
            <label>Departamento: </label>
            <asp:DropDownList CssClass="form-control" ID="ddlDepartamentos" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Value="-1" Text="[Selecciona uno]" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvUno" runat="server" ErrorMessage="Departamento necesario" Text="***" ControlToValidate="ddlDepartamentos" ValidationGroup="Forma" InitialValue="-1"></asp:RequiredFieldValidator>
            <br />
            <label>Puesto</label>
            <asp:DropDownList CssClass="form-control" runat="server" ID="ddlPuestos" AppendDataBoundItems="true">
                <asp:ListItem Value="-1" Text="[Selecciona uno]" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvDos" runat="server" ErrorMessage="Puesto necesario" Text="***" ControlToValidate="ddlPuestos" ValidationGroup="Forma" InitialValue="-1"></asp:RequiredFieldValidator>
            <br />
            <label>Nombre:</label>
            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" PlaceHolder="Ingresa nombre completo." />
            <asp:RequiredFieldValidator ID="rfvTres" runat="server" ErrorMessage="Nombre necesario" Text="***" ControlToValidate="txtNombre" ValidationGroup="Forma" InitialValue="-1"></asp:RequiredFieldValidator>
            <div>
                <asp:Button Text="Buscar" ID="btnBuscar" runat="server" CssClass="btn btn-info" OnClick="btnBuscar_Click" />
                <asp:Button Text="Alta" ID="btnAlta" runat="server" CssClass="btn btn-success" />
            </div>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Forma" />
    </div>
    <div class="container">
        <div class="row">
            <div>
                <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="[Departamento]">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Departamento") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Departamento.Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="[Puesto]">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Puesto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Puesto.Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="[Nombre]">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="[Edición]">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Edicion") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Edicion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
</asp:Content>

