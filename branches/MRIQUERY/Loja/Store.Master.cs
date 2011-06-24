using System;
using System.Collections;
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
