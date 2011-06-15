using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using br.com.entidades;
using MySql.Data.MySqlClient;

namespace br.com.dao
{
    public class DaoFuncionario:Dao<Funcionario>
    {

        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;


        public void salvar(Funcionario obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "INSERT INTO TB_USUARIO(DATA_ADMISSAO,DATA_DEMISSAO,PERFIL,USUARIO)" +
                "+VALUES(@DATA_ADMISSAO,@DATA_DEMISSAO,@LAST_INSERT_ID(),@LAST_INSERT_ID())";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@DATA_ADMISSAO", obj.DataAdmissao);
                comando.Parameters.AddWithValue("@DATA_DEMISSAO", obj.DataDemissao);
                comando.Parameters.AddWithValue("@LAST_INSERT_ID", obj.Perfil);
                comando.Parameters.AddWithValue("@LAST_INSERT_ID", obj.PessoaFisica);
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

        public void alterar(Funcionario obj)
        {
            
        }

        public void deletar(Funcionario obj)
        {
           
        }

    }
}
