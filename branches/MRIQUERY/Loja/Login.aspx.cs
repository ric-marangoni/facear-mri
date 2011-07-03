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
using br.com.servicos;

namespace Loja.checkout
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                    Response.Redirect("Pagamento.aspx");
                }
                else
                {
                    Alert.Show("O usuário ou senha informados estão incorretos");
                    login.Focus();
                }
            }
        }
    }
}
