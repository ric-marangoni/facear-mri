using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using MySql.Data.MySqlClient;
using br.com.entidades;

namespace br.com.dao
{
    public class DaoPessoaJuridica:Dao<PessoaJuridica>
    {
        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;

        public void salvar(PessoaJuridica obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "INSERT INTO TB_USUARIO(NOME,SEXO,DATA_NASCIMENTO,CPF_CNPJ,SENHA,LOGIN,STATUS_,EMAIL_PESSOAL,EMAIL_COMERCIAL,TELEFONE_COMERCIAL,TELEFONE_CELULAR,TELEFONE_RESIDENCIAL,DATA_CADASTRO,ENDERECO)" +
                "+VALUES(@NOME,@SEXO,@DATA_NASCIMENTO,@CPF_CNPJ,@CPF_CNPJ,@SENHA,@LOGIN,@STATUS_,@EMAIL_PESSOAL,@EMAIL_COMERCIAL,@TELEFONE_COMERCIAL,@TELEFONE_CELULAR,@TELEFONE_RESIDENCIAL,DATA_CADASTRO,LAST_INSERT_ID())";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@NOME", obj.RazaoSocial);
                comando.Parameters.AddWithValue("@CPF_CNPJ", obj.Cnpj);
                comando.Parameters.AddWithValue("@SENHA", obj.Senha);
                comando.Parameters.AddWithValue("@LOGIN", obj.Login);
                comando.Parameters.AddWithValue("@STATUS_", obj.Status);
                comando.Parameters.AddWithValue("@EMAIL_PESSOAL", obj.EmailPessoal);
                comando.Parameters.AddWithValue("@EMAIL_COMERCIAL", obj.EmailComercial);
                comando.Parameters.AddWithValue("@TELEFONE_COMERCIAL", obj.TelefoneComercial);
                comando.Parameters.AddWithValue("@TELEFONE_CELULAR", obj.TelefoneCelular);
                comando.Parameters.AddWithValue("@TELEFONE_RESIDENCIAL", obj.TelefoneResidencial);
                comando.Parameters.AddWithValue("@DATA_CADASTRO", obj.DataCadastro);
                comando.Parameters.AddWithValue("@LAST_INSERT_ID()", obj.Endereco);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Cadastrar Contato! " + ex);
            }
            finally
            {
                conexao.Close();
            }
           
        }

        public void alterar(PessoaJuridica obj)
        {
            throw new NotImplementedException();
        }

        public void deletar(PessoaJuridica obj)
        {
            throw new NotImplementedException();
        }

    }
}
