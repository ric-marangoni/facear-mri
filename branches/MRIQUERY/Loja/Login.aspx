<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Loja.checkout.Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="titulo-paginas">Indentificação</h1>
    <br />
    <br />    
    <div class="pagamento-login">
        <div class="have-login">
            <h3>Já sou cliente</h3>
            <hr />
            <br />
            <p>Para efetuar login em sua conta preencha os campos abaixo:</p>
            <div class="caixa-have-login">
                <fieldset>				    
			        <label>
				        <span>Login</span>
				        <asp:TextBox ID="login" runat="server"></asp:TextBox>							
			        </label>
			        <label>
				        <span>Senha</span>							
				        <asp:TextBox TextMode="Password" ID="senha" runat="server"></asp:TextBox>
				        <asp:Button ID="btnEntrar" CssClass="btnEntrar" runat="server" OnClick="btnEntrar_Click" />														
			        </label>						
			        <a href="#">Esqueceu a senha?</a>						
			    </fieldset>
			</div> 	
        </div>
        <div class="dont-have-login">
            <h3>Sou novo aqui!</h3>
            <hr />
            <br />
            <p>Para prosseguir é necessário ter cadastro na Leia+.
                <br /> 
                Não se preocupe os itens do carrinho serão mantidos.
            </p>
            <asp:LinkButton CssClass="botao" ID="pagamentoCadastro" PostBackUrl="~/Cadastro_cliente.aspx" Text="Cadastre-se agora mesmo" runat="server"></asp:LinkButton>
        </div>
    </div>            
</asp:Content>
