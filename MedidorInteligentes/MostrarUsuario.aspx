<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuario.aspx.cs" Inherits="MedidorInteligentes.MostrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row mt-5">
            <asp:GridView ID="grillaUsuario" CssClass ="table table-hover table-bordered" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="no hay registros" runat="server" OnRowCommand="grillaUsuario_RowCommand">
                
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Rut" DataField="Rut" />
                    <asp:BoundField HeaderText="Correo" DataField="Correo" />
                    <asp:BoundField HeaderText="Medidor" DataField="Medidor.NombreMedidor" />
                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button CssClass="btn btn-danger" runat="server"
                                             CommandName="eliminar" Text="Eliminar"
                                             CommandArgument='<%# Eval("Id")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
