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
using System.Text.RegularExpressions;
using br.com.entidades;

namespace Loja
{
    public partial class Pagamento : System.Web.UI.Page
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
    }
}
