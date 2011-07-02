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
		        <asp:TextBox runat="server" ID="cdrNome" CssClass="grande" rel="obrigatorio"></asp:TextBox>		     
	        </label>
	        <label class="float-left">
		        <span>Sexo</span>
		        <asp:DropDownList runat="server" ID="cdrClienteSexo" rel="obrigatorio">
		            <asp:ListItem Value="">Selecione</asp:ListItem>
		            <asp:ListItem Value="masculino">Masculino</asp:ListItem>
		            <asp:ListItem Value="feminino">Feminino</asp:ListItem>
		        </asp:DropDownList>		    
	        </label>
	        <label class="float-left">
		        <span>Data de Nascimento</span>		     
		        <asp:TextBox runat="server" ID="cdrDataNascimento" rel="obrigatorio"></asp:TextBox>		    
	        </label>
	        <label class="float-left">
		        <span>CPF</span>		    
		        <asp:TextBox runat="server" ID="cdrCpf" rel="obrigatorio"></asp:TextBox>		     
	        </label>	    
	        <div class="clear"><!--  --></div>
            <label class="float-left">
		        <span id="lblLogin" runat="server">Login</span>		                		    
		        <asp:TextBox runat="server" ID="cdrClienteLogin" CssClass="medio" rel="obrigatorio"></asp:TextBox>		     
	        </label>
	        <br />
	        <asp:Button runat="server" ID="verificarDisponibilidade" CssClass="btnVerificar" Text="Verificar disponibilidade" OnClick="verificarDisponibilidade_Click" />
	        <div class="clear"><!--  --></div>	        
	        <asp:Label runat="server" Visible="false" ID="msgDisponibilidade"></asp:Label>		
	        <div class="clear"><!--  --></div>	        
	        <label class="float-left">
		        <span id="lblSenha" runat="server">Senha</span>		    
		        <asp:TextBox TextMode="Password" runat="server" ID="cdrSenha" rel="obrigatorio"></asp:TextBox>		      
	        </label>
	        <label>
		        <span id="lblConfirmaSenha" runat="server" >Confirme</span>		     
		        <asp:TextBox TextMode="Password" runat="server" ID="cdrConfirmaSenha" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <div class="clear"></div>
	    </fieldset>
	    <h2>Contato</h2>       
	    <fieldset>            
	        <label>
		        <span>E-mail Pessoal</span>		     
		        <asp:TextBox runat="server" ID="cdrEmailPessoal" CssClass="grande" rel="obrigatorio"></asp:TextBox>
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
		        <asp:TextBox runat="server" ID="cdrCep" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Cidade</span>		    
		        <asp:TextBox runat="server" ID="cdrCidade" CssClass="medio" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Estado</span>		    
		        <asp:TextBox runat="server" ID="cdrEstado" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <div class="clear"><!--  --></div>
	        <label class="float-left">
		        <span>Logradouro</span>		    
		        <asp:TextBox runat="server" ID="cdrLogradouro" CssClass="medio" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <label>
		        <span>Numero</span>		    
		        <asp:TextBox runat="server" ID="cdrNumero" rel="obrigatorio"></asp:TextBox>
	        </label>
	        <label class="float-left">
		        <span>Bairro</span>		    
		        <asp:TextBox runat="server" ID="cdrBairro" CssClass="medio" rel="obrigatorio"></asp:TextBox>
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
	    <asp:Button runat="server" CssClass="btn-enviar" ID="btnCadastrarCliente" OnClick="btnCadastrarCliente_Click" />
	    
	</div>
</asp:Content>
