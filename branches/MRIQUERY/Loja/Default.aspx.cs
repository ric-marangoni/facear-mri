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
using br.com.servicos;
using System.IO;

namespace Loja
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDataList();

                var lisProdutos = (List<Produto>)Session["ListaProdutos"];

                if (lisProdutos != null)
                {
                    List<Produto> produtos = new List<Produto>();
                    var data = dtlProdutos.Items;

                    for (int i = 0; i < data.Count; i++)
                    {
                        var id = Convert.ToInt32(((TextBox)data[i].FindControl("ProductID")).Text);
                        
                        for (int j = 0; j < lisProdutos.Count; j++)
                        {
                            if (id == lisProdutos[j].Id)
                            {
                                data[id - 1].FindControl("btnAdicionar").Visible = false;
                                data[id - 1].FindControl("btnCancelar").Visible = true;
                            }
                        }
                            
                    }
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
           // produto.Imagem = ((Image)e.Item.FindControl("imgProduto"));

            var lisProdutos = (List<Produto>)Session["ListaProdutos"];

            if(lisProdutos == null)
                lisProdutos = new List<Produto>();

            lisProdutos.Add(produto);

            Session["ListaProdutos"] = lisProdutos;

            Store Master = this.Master as Store;

            var pluralProduto = " item";

            if (lisProdutos.Count > 1)
            {
                pluralProduto = " itens";
            }
            
            string carMessage = "<small style=\"font-size:11px\">Você tem " + "<strong style=\"color: #006699;\">" + lisProdutos.Count + "</strong>" + pluralProduto + " na cesta</small>";
            ((HtmlGenericControl)Master.FindControl("cart_info")).InnerHtml = carMessage;
            ((LinkButton)Master.FindControl("lnkCheckout")).Visible = true;                    
                                    
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

            Store Master = this.Master as Store;

            var pluralProduto = " item";

            if (lisProdutos.Count > 1)
            {
                pluralProduto = " itens";
            }

            string carMessage = "<small style=\"font-size:11px\">Você tem " + "<strong style=\"color: #006699;\">" + lisProdutos.Count + "</strong>" + pluralProduto + " na cesta</small>";

            if (lisProdutos.Count == 0)
            {
                carMessage = "Você não tem itens em sua cesta.";
                ((LinkButton)Master.FindControl("lnkCheckout")).Visible = false;
            }

            ((HtmlGenericControl)Master.FindControl("cart_info")).InnerHtml = carMessage;

            ((LinkButton)e.Item.FindControl("btnCancelar")).Visible = false;
            ((LinkButton)e.Item.FindControl("btnAdicionar")).Visible = true;
        }
        
        /// <summary>
        /// Metodo chamado quado a pagina carrega
        /// para popular o datalist com os produtos.
        /// </summary>
        private void CarregarDataList()
        {

            /*var listaProdutos = new List<Produto>
                                    {
                                        new Produto {Id = 1, Imagem = "imagens/revistas/capa_boaforma.jpg", Titulo = "Revista um", Preco = 49.99},
                                        new Produto {Id = 2, Imagem = "imagens/revistas/capa_capricho.jpg", Titulo = "Revista dois", Preco = 49.99},
                                        new Produto {Id = 3, Imagem = "imagens/revistas/capa_claudia.jpg", Titulo = "Revista três", Preco = 49.99},
                                        new Produto {Id = 4, Imagem = "imagens/revistas/capa_gloss.jpg", Titulo = "Revista quatro", Preco = 49.99},
                                        new Produto {Id = 5, Imagem = "imagens/revistas/capa_info.jpg", Titulo = "Revista cinco", Preco = 49.99},
                                        new Produto {Id = 6, Imagem = "imagens/revistas/capa_mundoestranho.jpg", Titulo = "Revista seis", Preco = 49.99}

                                    };*/

            ServicoProduto srvProduto = new ServicoProduto();

            List<Produto> listaProdutos = srvProduto.listarProduto();

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                MemoryStream img = new MemoryStream(listaProdutos[i].Imagem);
                //Image returnImage = Image.FromStream(img);
                listaProdutos[i].imgUrl =(String)img.ToString();
            }
            dtlProdutos.DataSource = listaProdutos;
            dtlProdutos.DataBind();            
        }
        
    }
    
}
