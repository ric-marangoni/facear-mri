<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Cadastro_cliente.aspx.cs" Inherits="Loja.Cadastro_cliente" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastre-se</h1>
    <div class="frm-default">
        <label class="float-left">
		    <span>Login</span>		    
		    <asp:TextBox runat="server" ID="cdrClienteLogin"></asp:TextBox>		     
	    </label>
	    <label class="float-left">
		    <span>Senha</span>		    
		    <asp:TextBox TextMode="Password" runat="server" ID="cdrSenha"></asp:TextBox>		      
	    </label>
	    <label>
		    <span>Confirme</span>		     
		    <asp:TextBox TextMode="Password" runat="server" ID="cdrConfirmaSenha"></asp:TextBox>
	    </label>
        <label>
		    <span>Nome</span>		    
		    <asp:TextBox runat="server" ID="cdrNome" CssClass="medio"></asp:TextBox>		     
	    </label>
	    <label class="float-left">
		    <span>Sexo</span>
		    <asp:DropDownList runat="server" ID="cdrClienteSexo">
		        <asp:ListItem Value="">Selecione</asp:ListItem>
		        <asp:ListItem Value="masculino">Masculino</asp:ListItem>
		        <asp:ListItem Value="feminino">Feminino</asp:ListItem>
		    </asp:DropDownList>		    
	    </label>
	    <label class="float-left">
		    <span>Data de Nascimento</span>		     
		    <asp:TextBox runat="server" ID="cdrDataNascimento"></asp:TextBox>		    
	    </label>
	    <label class="float-left">
		    <span>CPF</span>		    
		    <asp:TextBox runat="server" ID="cdrCpf"></asp:TextBox>		     
	    </label>	    
	    <div class="clear"><!--  --></div>
	    <label>
		    <span>Endereço</span>		    
		    <asp:TextBox runat="server" ID="cdrEndereco" CssClass="medio"></asp:TextBox>
	    </label>
    	
	    <div class="clear"><!--  --></div>

	    <label class="float-left">
		    <span>Telefone Residencial</span>		    
		    <asp:TextBox runat="server" ID="cdrTelResidencial"></asp:TextBox>
	    </label>
	    <label class="float-left">
		    <span>Telefone Celular</span>
		    <asp:TextBox runat="server" ID="cdrTelCelular"></asp:TextBox>
	    </label>
	    <label class="float-left">
		    <span>Telefone Comercial</span>		    
		    <asp:TextBox runat="server" ID="cdrTelComercial"></asp:TextBox>
	    </label>
	    <div class="clear"><!--  --></div>
	    <label>
		    <span>E-mail Pessoal</span>		     
		    <asp:TextBox runat="server" ID="cdrEmailPessoal" CssClass="medio"></asp:TextBox>
	    </label>
	    <label>
		    <span>Email Comercial</span>		    
	        <asp:TextBox runat="server" ID="cdrEmailComercial" CssClass="medio"></asp:TextBox>
	    </label>
    	
	    <div class="clear"><!--  --></div>
    		    
	    <asp:Button runat="server" CssClass="btn-enviar" ID="btnCadastrarCliente" onclick="btnCadastrarCliente_Click" />
	    <div class="clear"><!--  --></div>
	</div>
</asp:Content>
