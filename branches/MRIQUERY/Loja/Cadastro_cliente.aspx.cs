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
using br.com.servicos;
using br.com.entidades;

namespace Loja
{
    public partial class Cadastro_cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Cliente)Session["cliente"] != null)
            {
                Cliente cliente = (Cliente)Session["cliente"];
                cdrClienteLogin.Visible = false; 
                cdrSenha.Visible = false;
                cdrConfirmaSenha.Visible = false;
                cdrNome.Text = cliente.PessoaFisica.Nome;
                cdrClienteSexo.Text = cliente.PessoaFisica.Sexo;
                cdrDataNascimento.Text = Convert.ToString(cliente.PessoaFisica.DataNascimento);
                cdrCpf.Text = cliente.PessoaFisica.Cpf;
                                
                cdrTelResidencial.Text = cliente.PessoaFisica.TelefoneResidencial;
                cdrTelCelular.Text = cliente.PessoaFisica.TelefoneCelular;
                cdrTelComercial.Text = cliente.PessoaFisica.TelefoneComercial;
                cdrEmailPessoal.Text = cliente.PessoaFisica.EmailPessoal;
                cdrEmailComercial.Text = cliente.PessoaFisica.EmailComercial;
            }
        }

        protected void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            PessoaFisica pessoa = new PessoaFisica();
            Endereco endereco = new Endereco();
            ServicoCliente servicoCliente = new ServicoCliente();

            endereco.Logradouro = cdrEndereco.Text;

            pessoa.Login = cdrClienteLogin.Text;
            pessoa.Senha = cdrSenha.Text;
            pessoa.Nome = cdrNome.Text;
            pessoa.Sexo = cdrClienteSexo.Text;
            pessoa.DataNascimento = DateTime.Parse(cdrDataNascimento.Text);
            pessoa.Cpf = cdrCpf.Text;
            pessoa.Endereco = endereco;
            pessoa.TelefoneResidencial = cdrTelResidencial.Text;
            pessoa.TelefoneCelular = cdrTelCelular.Text;
            pessoa.TelefoneComercial = cdrTelComercial.Text;
            pessoa.EmailPessoal = cdrEmailPessoal.Text;
            pessoa.EmailComercial = cdrEmailComercial.Text;

            cliente.PessoaFisica = pessoa;

            servicoCliente.salvarCliente(cliente);
            
        }
    }
}
