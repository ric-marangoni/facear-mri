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
            pessoa.Cpf = Convert.ToInt64(cdrCpf.Text);
            pessoa.Endereco = endereco;
            pessoa.TelefoneResidencial = Convert.ToInt64(cdrTelResidencial.Text);
            pessoa.TelefoneCelular = Convert.ToInt64(cdrTelCelular.Text);
            pessoa.TelefoneComercial = Convert.ToInt64(cdrTelComercial.Text);
            pessoa.EmailPessoal = cdrEmailPessoal.Text;
            pessoa.EmailComercial = cdrEmailComercial.Text;

            cliente.PessoaFisica = pessoa;

            servicoCliente.salvarCliente(cliente);
            
        }
    }
}
