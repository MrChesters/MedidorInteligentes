<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="MedidorInteligentes.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="nombreTxt" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar nombre"></asp:RequiredFieldValidator>
                    </div>

                   <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ControlToValidate="rutTxt" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un rut valido"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label for="contraTxt">Contraseña</label>
                        <asp:TextBox ID="contraTxt" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="contraTxt" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Ingrese una contraseña correctamente"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label for="correoTxt">Email</label>
                        <asp:TextBox ID="correoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="correoTxt" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Ingrese un correo correctamente"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for ="medidorDDL">Medidor</label>
                        <asp:DropDownList ID="medidorDDL" runat="server"></asp:DropDownList>
                    </div>

                    <asp:Button OnClick="ingresarBtn_Click" runat="server" ID="ingresarBtn" Text="Ingresar" />

                </div>
            </div>
        </div>
    </div>
</asp:Content>
