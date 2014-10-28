<%@ Page Title="Pagos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagos.aspx.cs" Inherits="WebApp.Pagos" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class="row">
        <section class="col-md-4">
        <asp:Label ID="User" runat="server" Text=""></asp:Label>
        <h4>Metodo de pago</h4>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="&quot;&quot;">Metodos de pago</asp:ListItem>
            <asp:ListItem Selected="True" Value="Credito">Targeta de Credito</asp:ListItem>
            <asp:ListItem Value="Debito">Targeta Debito</asp:ListItem>
        </asp:DropDownList>
            <br />
            
            <table>
                

            </table>
            <br />
        </section>
    </div>
    </asp:Content>
