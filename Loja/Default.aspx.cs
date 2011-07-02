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
using br.com.entidades;
using System.Collections.Generic;

namespace Loja
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDataList();
            }

            var lisProdutos = (List<Produto>)Session["ListaProdutos"];

            if (lisProdutos != null)
            {
                var produtos = dtlProdutos;

                for (int i = 0; i < lisProdutos.Count; i++ )
                {
                    
                }
            }
            

        }
       
         /// <summary>
        ///Quando acionado o botao adicionar na tela, o mesmo chama este evento.
        /// é aqui que vamos adicionar os ids dos produtos na sessao
        /// \o/
        /// é nois
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void dtlProdutos_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            var produto = new Produto();

            produto.Id = Convert.ToInt32(((DataList) source).DataKeys[e.Item.ItemIndex]);
            produto.Titulo = ((LinkButton)e.Item.FindControl("lnkNomeProduto")).Text;
            produto.Preco = Convert.ToDouble(((Label)e.Item.FindControl("lblPreco")).Text);

            var lisProdutos = (List<Produto>)Session["ListaProdutos"];

            if(lisProdutos == null)
                lisProdutos = new List<Produto>();

            lisProdutos.Add(produto);

            Session["ListaProdutos"] = lisProdutos;
                        
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "addCar",
                "var carrinho = document.getElementById('ctl00_cart_info');" +
                "carrinho.innerHtml = '<small>Você tem <strong>" + lisProdutos.Count + "</strong></small>';"         
            , true);
            
            ((LinkButton)e.Item.FindControl("btnAdicionar")).Visible = false;
            ((LinkButton)e.Item.FindControl("btnCancelar")).Visible = true;

        }

        protected void dtlProdutos_CancelCommand(object source, DataListCommandEventArgs e)
        {
            var lisProdutos = (List<Produto>)Session["ListaProdutos"];

            var id = Convert.ToInt32(((DataList)source).DataKeys[e.Item.ItemIndex]);

            for (int i = 0; i < lisProdutos.Count; i++ )
            {
                if(lisProdutos[i].Id == id)
                {
                    lisProdutos.Remove(lisProdutos[i]);
                }
            }
            
            ((LinkButton)e.Item.FindControl("btnCancelar")).Visible = false;
            ((LinkButton)e.Item.FindControl("btnAdicionar")).Visible = true;
        }
        
        /// <summary>
        /// Metodo chamado quado a pagina carrega
        /// para popular o datalist com os produtos.
        /// </summary>
        private void CarregarDataList()
        {

            var listaProdutos = new List<Produto>
                                    {
                                        new Produto {Id = 1, Titulo = "Revista um", Preco = 49.99},
                                        new Produto {Id = 2, Titulo = "Revista dois", Preco = 49.99},
                                        new Produto {Id = 3, Titulo = "Revista três", Preco = 49.99},
                                        new Produto {Id = 4, Titulo = "Revista quatro", Preco = 49.99},
                                        new Produto {Id = 5, Titulo = "Revista cinco", Preco = 49.99},
                                        new Produto {Id = 6, Titulo = "Revista seis", Preco = 49.99}

                                    };

            dtlProdutos.DataSource = listaProdutos;
            dtlProdutos.DataBind();            
        }        
    }
    
}
