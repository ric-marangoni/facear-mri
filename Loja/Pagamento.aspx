<%@ Page Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="Loja.Pagamento" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="titulo-paginas">Pagamento</h1>
    <div ID="listaCarrinho" class="lista-carrinho" runat="server">        
        <asp:GridView ID="grvProdutos" BorderWidth="0px"  runat="server" 
            AutoGenerateColumns="False" DataKeyNames="Id" rules="">
            <Columns>
                <asp:BoundField DataField="imgUrl" HtmlEncode="False" 
                    HtmlEncodeFormatString="False" SortExpression="Imagem">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Titulo" HeaderText="Descrição" 
                    SortExpression="Titulo" />
                <asp:BoundField DataField="Preco" HeaderText="Valor R$" SortExpression="Preco">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>                
            </Columns>
        </asp:GridView>
        <div class="carrinho-total">TOTAL: <asp:Label ID="precoFinal" runat="server"></asp:Label></div>
    </div>
    <br /><br />
    <h5>ESCOLHA UMA FORMA DE PAGAMENTO:</h5>
    <div class="botoesPagamento">
        <div>
            <img src="imagens/fechamento.visa.gif" alt="Visa" />
            <input type="radio" name="cartoes" />
        </div>
        <div>
            <img src="imagens/fechamento.mast.gif" alt="Master Card" />
            <input type="radio" name="cartoes" />
        </div>
        <div>
            <img src="imagens/fechamento.dinr.gif" alt="Diners" />
            <input type="radio" name="cartoes" />
        </div>
        <div>
            <img src="imagens/fechamento.amex.gif" alt="Amex" />
            <input type="radio" name="cartoes" />
        </div>
        <div>
            <img src="imagens/fechamento.boleto.gif" alt="Boleto" />
            <input type="radio" name="cartoes" />
        </div>        
    </div>
    <div class="clear"></div>
    <br /><br />
    <div class="pagDados">
		<table width="62%" cellspacing="0" cellpadding="0">
			<tbody><tr>
				<td>
					<label for="txtCC_Numero">Número do cartão: <br>(Digite apenas os números)</label>
					<input value="" maxlength="16" onkeypress="return OnlyNumber(event);" size="22" id="txtCC_Numero" name="txtCC_Numero" />
				</td>
				<td colspan="2">
					<label for="txtCC_CVC">Código de segurança: <br>(número atrás do cartão)</label>
					<input value="" maxlength="4" onkeypress="return OnlyNumber(event);" size="5" id="txtCC_CVC" name="txtCC_CVC" />
				</td>
			</tr>
			<tr>
				<td>
				    <br />
					<label for="txtCC_Nome">Nome do titular impresso no cartão:</label>
					<input value="" maxlength="70" size="40" id="txtCC_Nome" name="txtCC_Nome" />
				</td>
				<td colspan="2">				    
				    <br />
					<label for="txtCC_Mes">Data de validade do cartão:</label>
					<input type="text" size="1" value="" maxlength="2" id="txtCC_Mes" name="txtCC_Mes" /> / <input type="text" size="1" maxlength="2" value="" id="txtCC_Ano" name="txtCC_Ano"> (Ex. mm / aa)
				</td>
			</tr>
			<tr>
				<td class="complementar" colspan="3">
					<br />
					<b>SEGURANÇA COMPLEMENTAR</b>					
				</td>
			</tr>
			<tr>
				<td colspan="3">
				    <br />
					<label for="txtCC_CPF">CPF do titular do cartão:</label>
					<input size="30" value="" maxlength="20" onkeypress="return OnlyNumber(event);" id="txtCC_CPF" name="txtCC_CPF" />
				</td>
			</tr>
			<tr>
				<td colspan="3">
				    <br />
					<label for="txtCC_CepA">CEP da fatura do cartão:</label>
					<input type="text" maxlength="5" size="10" value="" onkeypress="return OnlyNumber(event);" id="txtCC_CepA" name="txtCC_CepA"> - <input type="text" maxlength="3" size="6" onkeypress="return OnlyNumber(event);" value="" id="txtCC_CepB" name="txtCC_CepB" />
				</td>
			</tr>
			<tr>
				<td>
				    <br />
					<label for="txtCC_Endereco">Endereço de entrega da fatura do cartão:</label>
					<input value="" maxlength="80" size="40" id="txtCC_Endereco" name="txtCC_Endereco" />
				</td>
				<td>
				    <br />
					<label for="txtCC_EnderecoNumero">Número:</label>
					<input maxlength="4" size="5" value="" onkeypress="return OnlyNumber(event);" id="txtCC_EnderecoNumero" name="txtCC_EnderecoNumero" />
				</td>
				<td>
				    <br />
					<label for="txtCC_Complemento">Complemento</label>
					<input maxlength="80" value="" size="20" id="txtCC_Complemento" name="txtCC_Complemento" />
				</td>
			</tr>
		</tbody></table>
	</div>
	<asp:ImageButton ID="confirmarCompra" ImageUrl="~/imagens/botao-concluir-compra.gif" runat="server" CssClass="concluir-compra" />            
</asp:Content>
