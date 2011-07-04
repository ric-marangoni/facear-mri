﻿<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Loja.WebForm1" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="banner-home">
		<p class="slide-prev">
			<a href="#"></a>
		</p>
		<ul class="jcarousel-banner">
			<li>
				<a href="#">
					<img src="imagens/java_banner.jpg" alt="Curso de Java" width="605" height="240" />
				</a>
			</li>
			<li>
				<a href="#">
					<img src="imagens/webdesign_banner.png" alt="Curso de Web Design" width="605" height="240" />	
				</a>
			</li>
			<li>
				<a href="#">
					<img src="imagens/banner_prestashop.jpg" alt="Prestashop" width="605" height="240" />
				</a>
			</li>
			<li>
				<a href="#">
					<img src="imagens/banner_virtuemart.jpg" alt="Virtue Mart" width="605" height="240" />	
				</a>
			</li>
		</ul>
		<p class="slide-next">
			<a href="#"></a>
		</p>
	</div>    
	<div class="border-shadow"></div>	
	<asp:UpdatePanel ID="boxConteudo" runat="server" UpdateMode="Always">		
		<ContentTemplate>
		    <h1>Revistas</h1>
            <asp:DataList ID="dtlProdutos" CssClass="produtos" runat="server" OnItemCommand="dtlProdutos_ItemCommand" OnCancelCommand="dtlProdutos_CancelCommand" OnDeleteCommand="dtlProdutos_DeleteCommand"
                DataKeyField="Id">
                <ItemTemplate>
                    <asp:TextBox Text='<%#Eval("Id") %>' Visible="false" ID="ProductID" runat="server"></asp:TextBox>                   
                    <asp:Image ID="imgProduto" ImageUrl='<%#Eval("Imagem") %>' runat="server" /> 
                    <h2><asp:LinkButton ID="lnkNomeProduto" runat="server" CommandName="Item" Text='<%#Eval("Titulo") %>'></asp:LinkButton></h2>                    
                    <h3>R$<asp:Label ID="lblPreco" Text='<%#Eval("Preco") %>' runat="server"></asp:Label>/mês</h3>
                    <asp:LinkButton ID="btnAdicionar" runat="server" CssClass="carrinho" CommandName="Delete" />
                    <asp:LinkButton ID="btnCancelar" runat="server"  CssClass="removerCarrinho" Visible="false" CommandName="Cancel" />                                        
                    
                </ItemTemplate>
            </asp:DataList>
            <asp:HiddenField ID="ProductItemBound" runat="server" />           
            <h1>Jornais</h1>             
            <asp:ModalPopupExtender ID="mpeViewProduto" runat="server" TargetControlID="ProductItemBound" PopupControlID="pnlDados"
                        BackgroundCssClass="modalBackground" DropShadow="true" CancelControlID="btnSair"
                        DynamicServicePath="" Enabled="True">
            </asp:ModalPopupExtender>
            <asp:Panel ID="pnlDados" runat="server" CssClass="modalPopup">
                <asp:ImageButton ImageUrl="~/imagens/ico_remove.png" ID="btnSair" runat="server" />
                <asp:Label ID="lblTitulo" runat="server" ></asp:Label>
                <asp:Image ID="pnlImg" runat="server" />                
            </asp:Panel>
        </ContentTemplate>        
    </asp:UpdatePanel>	    
</asp:Content>