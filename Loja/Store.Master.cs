using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using br.com.entidades;
using br.com.servicos;

namespace Loja
{
    public partial class Store : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Loja Leia+";

            if(Request["logout"] == "1"){
                Session.Abandon();
                Response.Redirect("~/Default.aspx");
            }
            
            if(Session["cliente"] != null){
                Cliente cliente = (Cliente)Session["cliente"];
                boxLogin.Style.Add("background", "none");
                loginTitle.InnerText = "Olá,";
                frmLogin.Visible = false;
                logedUser.Visible = true;
                userName.Text =  cliente.PessoaFisica.Nome;
            }

            if ((List<Produto>)Session["ListaProdutos"] != null)
            {                
                var listaProdutos = (List<Produto>)Session["ListaProdutos"];

                var pluralProduto = " item";

                if (listaProdutos.Count > 1)
                {
                    pluralProduto = " itens";
                }

                if (listaProdutos.Count > 0)
                {
                    cart_info.InnerHtml = "<small style=\"font-size:11px\">Você tem " + "<strong style=\"color: #006699;\">" + listaProdutos.Count + "</strong>" + pluralProduto + " na cesta</small>    ";                    
                    lnkCheckout.Visible = true;                    

                }
                else
                {
                    cart_info.InnerText = "Você não tem itens em sua cesta.";                    
                }
            }            
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                Alert.Show("Por favor informe o seu usuário");
            }
            else if (senha.Text == "")
            {
                Alert.Show("Por favor informe sua senha");
            }
            else
            {


                ServicoCliente svrCliente = new ServicoCliente();
                Cliente cliente = svrCliente.pegarCliente(login.Text, senha.Text);

                if (cliente.PessoaFisica.Id != 0)
                {
                    Session["cliente"] = cliente;
                    string URL = Request.Url.AbsoluteUri.ToString();
                    Response.Redirect(URL);
                }
                else
                {
                    Alert.Show("O usuário ou senha informados estão incorretos");
                    login.Focus();
                }
            }
        }

        protected void editarConta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro_cliente.aspx");
        }
    }
}
