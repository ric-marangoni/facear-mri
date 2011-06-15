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
    public class DaoEndereco : Dao<Endereco>
    {
        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;

        public void salvar(Endereco obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "INSERT INTO TB_ENDERECO(LOGRADOURO,CIDADE,CEP,ESTADO,NUMERO,COMPLEMENTO)"+
                "+VALUES(@LOGRADOURO,@CIDADE,@CEP,@ESTADO,@NUMERO,@COMPLEMENTO)";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@LOGRADOURO", obj.Logradouro);
                comando.Parameters.AddWithValue("@CIDADE", obj.Cidade);
                comando.Parameters.AddWithValue("@CEP", obj.Cep);
                comando.Parameters.AddWithValue("@ESTADO", obj.Estado);
                comando.Parameters.AddWithValue("@NUMERO", obj.Numero);
                comando.Parameters.AddWithValue("@COMPLEMENTO", obj.Complemento);
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

        public void alterar(Endereco obj)
        {
            
        }

        public void deletar(Endereco obj)
        {
           
        }

    }
}
