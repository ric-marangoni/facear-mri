<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Loja.WebForm1" Title="Untitled Page" %>
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
	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
	<asp:UpdatePanel ID="boxConteudo" runat="server" UpdateMode="Always">		
		<ContentTemplate>
		    <h1>Revistas</h1>
		    <ul class="produtos">
			    <li>
				    <a href="#">
					    <img src="imagens/revistas/capa_info.jpg" alt="" />
				    </a>
				    <h2>
					    <a href="#">Revista Info</a>
				    </h2>
				    <h3>R$59,90/mês</h3>
				    				    
				    <asp:LinkButton  PostBackUrl="?item=1&cat=1" CssClass="carrinho" runat="server"></asp:LinkButton>
			    </li>		    
		    </ul>
		    <div class="clear"></div>
		    <div class="borda-pontilhada"></div>
		    <h1>Jornais</h1>
		    <ul class="produtos">
			    <li>
				    <a href="#">
					    <img src="imagens/jornais/newspaper-1.jpg" alt="" />
				    </a>
				    <h2>
					    <a href="#">Jornal O Globo</a>
				    </h2>
				    <h3>R$59,90/mês</h3>
				    <a id="" href="javascript:void(0);" class="carrinho"></a>
			    </li>			   			
		    </ul>
		    <div class="clear"></div>
	    </ContentTemplate>		
	</asp:UpdatePanel>    
</asp:Content>
