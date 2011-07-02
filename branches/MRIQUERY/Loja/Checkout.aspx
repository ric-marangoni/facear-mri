<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Loja.Checkout" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="titulo-paginas">Carrinho de Compras</h1>            
        <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="updListaCarrinho" runat="server">
            <ProgressTemplate>
                <div style="text-align: center"><img src="imagens/loading.gif" alt="" /></div>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="updListaCarrinho" runat="server">
            <ContentTemplate>
                <div ID="listaCarrinho" class="lista-carrinho" runat="server">        
                    <asp:GridView ID="grvProdutos" BorderWidth="0" CssClass=""  runat="server"></asp:GridView>
                    <div class="carrinho-total">TOTAL: <asp:Label ID="precoFinal" runat="server"></asp:Label></div>
                </div>
            </ContentTemplate>        
        </asp:UpdatePanel>    
    <div class="alinha-direita">
        <asp:ImageButton ID="continuarCompra" runat="server" ImageUrl="~/imagens/bt_continuar_comprando.png" OnClick="continuarCompra_Click"></asp:ImageButton>
        <asp:ImageButton ID="limparCarrinho" runat="server" ImageUrl="~/imagens/bt_limpar_carrinho.png" OnClick="limparCarrinho_Click"></asp:ImageButton>
        <asp:ImageButton ID="prosseguirCompra" runat="server" ImageUrl="~/imagens/bt_prosseguir.png" PostBackUrl="#"></asp:ImageButton>
    </div>
</asp:Content>
