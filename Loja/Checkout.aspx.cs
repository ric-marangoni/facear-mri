using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;
using br.com.entidades;

namespace Loja
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = (List<Produto>)Session["ListaProdutos"];

            if (listaProdutos != null)
            {
                grvProdutos.DataSource = listaProdutos;
                grvProdutos.DataBind();

                double valorTotal = 0;

                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    valorTotal += listaProdutos[i].Preco;
                }

                precoFinal.Text = "R$" + Convert.ToString(valorTotal);
            }
        }

        protected void continuarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void limparCarrinho_Click(object sender, EventArgs e)
        {
            Session.Remove("ListaProdutos");
            listaCarrinho.InnerHtml = "<p style=\"text-align: center; padding: 10px;\">Você não tem itens no carrinho</p>";

        }

        protected void prosseguirCompra_Click(object sender, EventArgs e)
        { 
            var cliente = Session["cliente"];

            if(cliente == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("Pagamento.aspx");
            }
        }
    }
}
