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
using System.Text.RegularExpressions;

namespace Loja
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = (List<Produto>)Session["ListaProdutos"];

            if (listaProdutos != null)
            {

                Regex er = new Regex("<img src");                
               
                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    if (!er.IsMatch(listaProdutos[i].Imagem))
                    {
                        listaProdutos[i].Imagem = "<img src=\"" + listaProdutos[i].Imagem + "\" alt=\"\"";
                    }
                }             

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

        protected void grvProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var idProduto = Convert.ToInt32(grvProdutos.DataKeys[e.RowIndex].Values["Id"]);
            
            var listaProdutoSessao = (List<Produto>)Session["ListaProdutos"];
            
            Produto pro = listaProdutoSessao.Find(x => x.Id == idProduto);
            
            listaProdutoSessao.Remove(pro);
                        
            grvProdutos.DataBind();

            double valorTotal = 0;

            for (int i = 0; i < listaProdutoSessao.Count; i++)
            {
                valorTotal += listaProdutoSessao[i].Preco;
            }

            precoFinal.Text = "R$" + Convert.ToString(valorTotal);
        }              
    }
}
