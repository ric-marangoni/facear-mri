<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Cadastro_cliente.aspx.cs" Inherits="Loja.Cadastro_cliente" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastre-se</h1>
    <div class="frm-default">
         <h2>Dados Pessoais</h2>
         <fieldset>           
             <label>
		        <span>Nome</span>		    
		        <asp:TextBox runat="server" ID="cdrNome" CssClass="grande"></asp:TextBox>		     
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
		        <span>Login</span>		    
		        <asp:TextBox runat="server" ID="cdrClienteLogin" CssClass="medio"></asp:TextBox>		     
	        </label>
	        <label class="float-left">
		        <span>Senha</span>		    
		        <asp:TextBox TextMode="Password" runat="server" ID="cdrSenha"></asp:TextBox>		      
	        </label>
	        <label>
		        <span>Confirme</span>		     
		        <asp:TextBox TextMode="Password" runat="server" ID="cdrConfirmaSenha"></asp:TextBox>
	        </label>
	        <div class="clear"></div>
	    </fieldset>
	    <h2>Contato</h2>       
	    <fieldset>            
	        <label>
		        <span>E-mail Pessoal</span>		     
		        <asp:TextBox runat="server" ID="cdrEmailPessoal" CssClass="grande"></asp:TextBox>
	        </label>
	        <label>
		        <span>Email Comercial</span>		    
	            <asp:TextBox runat="server" ID="cdrEmailComercial" CssClass="grande"></asp:TextBox>
	        </label>
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
	    </fieldset>
	    <h2>Endereço</h2>
	    <fieldset>	        
	        <label>
		        <span>CEP</span>		    
		        <asp:TextBox runat="server" ID="cdrCep"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Cidade</span>		    
		        <asp:TextBox runat="server" ID="cdrCidade" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Estado</span>		    
		        <asp:TextBox runat="server" ID="cdrEstado"></asp:TextBox>
	        </label>
	        <div class="clear"><!--  --></div>
	        <label class="float-left">
		        <span>Logradouro</span>		    
		        <asp:TextBox runat="server" ID="cdrEndereco" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Numero</span>		    
		        <asp:TextBox runat="server" ID="cdrNumero"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Bairro</span>		    
		        <asp:TextBox runat="server" ID="cdrBairro" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Complemento</span>		    
		        <asp:TextBox runat="server" ID="cdrComplemento"></asp:TextBox>
	        </label>
	    </fieldset>
	    <h2>Endereço Alternativo</h2>
	    <fieldset>
	        <label>
		        <span>CEP</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoCep"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Cidade</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoCidade" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Estado</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoEstado"></asp:TextBox>
	        </label>
	        <div class="clear"><!--  --></div>
	        <label class="float-left">
		        <span>Logradouro</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoLogradouro" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Numero</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoNumero"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Bairro</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoBairro" CssClass="medio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Complemento</span>		    
		        <asp:TextBox runat="server" ID="cdrAlternativoComplemento"></asp:TextBox>
	        </label>
	    </fieldset> 
    	
	    <div class="clear"><!--  --></div>
    	
    	<br /><br />	    
	    <asp:Button runat="server" CssClass="btn-enviar" ID="btnCadastrarCliente" Enabled="false" onclick="btnCadastrarCliente_Click" />
	    
	</div>
</asp:Content>
