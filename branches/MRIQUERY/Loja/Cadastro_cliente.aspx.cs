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
                lblLogin.Visible = false;
                cdrSenha.Visible = false;
                lblSenha.Visible = false;
                cdrConfirmaSenha.Visible = false;
                lblConfirmaSenha.Visible = false;
                verificarDisponibilidade.Visible = false;
                cdrNome.Text = cliente.PessoaFisica.Nome;
                cdrClienteSexo.Text = cliente.PessoaFisica.Sexo;
                cdrDataNascimento.Text = Convert.ToString(cliente.PessoaFisica.DataNascimento);
                cdrCpf.Text = cliente.PessoaFisica.Cpf;
                                
                cdrTelResidencial.Text = cliente.PessoaFisica.TelefoneResidencial;
                cdrTelCelular.Text = cliente.PessoaFisica.TelefoneCelular;
                cdrTelComercial.Text = cliente.PessoaFisica.TelefoneComercial;
                cdrEmailPessoal.Text = cliente.PessoaFisica.EmailPessoal;
                cdrEmailComercial.Text = cliente.PessoaFisica.EmailComercial;

                cdrCep.Text = cliente.PessoaFisica.Endereco.Cep;
                cdrCidade.Text = cliente.PessoaFisica.Endereco.Cidade;
                cdrEstado.Text = cliente.PessoaFisica.Endereco.Estado;
                cdrLogradouro.Text = cliente.PessoaFisica.Endereco.Logradouro;
                cdrNumero.Text = cliente.PessoaFisica.Endereco.Numero;
                cdrBairro.Text = cliente.PessoaFisica.Endereco.Bairro;
                cdrComplemento.Text = cliente.PessoaFisica.Endereco.Complemento;
            }
        }

        protected void verificarDisponibilidade_Click(object sender, EventArgs e)
        {
            ServicoCliente svrCliente = new ServicoCliente();

            bool existe = svrCliente.verificaDisponibilidadeLogin(cdrClienteLogin.Text);
            
            if (cdrClienteLogin.Text.Length < 6)
            {
                msgDisponibilidade.Visible = true;
                msgDisponibilidade.CssClass = "msg_erro";
                msgDisponibilidade.Text = "O login deve conter 6 ou mais caracteres";
            }
            else if (existe == true)
            {
                msgDisponibilidade.Visible = true;
                msgDisponibilidade.CssClass = "msg_erro";
                msgDisponibilidade.Text = "Este login está indisponível";
            }
            else
            {
                msgDisponibilidade.Visible = true;
                msgDisponibilidade.CssClass = "msg_sucesso";
                msgDisponibilidade.Text = "Este login está disponível";
            }
        }

        protected void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            String erro = "";
            
            if(cdrNome.Text == "")
            {
                erro = "O campo nome é obrigátio. \n";
            }

            if (cdrClienteSexo.Text == "")
            {
                erro += "Por favor escolha o seu sexo. \n";                
            }


            if (erro == "")
            {
                Cliente cliente = new Cliente();
                PessoaFisica pessoa = new PessoaFisica();
                Endereco endereco = new Endereco();
                ServicoCliente servicoCliente = new ServicoCliente();

                endereco.Cep = cdrCep.Text;
                endereco.Cidade = cdrCidade.Text;
                endereco.Estado = cdrEstado.Text;
                endereco.Logradouro = cdrLogradouro.Text;
                endereco.Numero = cdrNumero.Text;
                endereco.Bairro = cdrBairro.Text;
                endereco.Complemento = cdrComplemento.Text;


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

                Alert.Show("Cadastro realizado com sucesso");
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Alert.Show(erro);
            }
            
        }
    }
}
