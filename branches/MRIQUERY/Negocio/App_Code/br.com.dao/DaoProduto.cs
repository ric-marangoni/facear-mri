using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using br.com.entidades;
using MySql.Data.MySqlClient;

namespace br.com.dao
{
    class DaoProduto:Dao<Produto>
    {
        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;


        public void salvar(Produto obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "INSERT INTO TB_PRODUTO(PRODUTO, TIPO_PRODUTO, PRECO, EDICAO, ID_CATEGORIA, TIPO_PUBLICACAO, ANO, IMAGEM, ID_EDITORA)" +
                "VALUES(@PRODUTO, @TIPO_PRODUTO, @PRECO, @EDICAO, @ID_CATEGORIA, @TIPO_PUBLICACAO, @ANO, @IMAGEM, @ID_EDITORA)";
                                
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@PRODUTO", obj.Titulo);
                comando.Parameters.AddWithValue("@TIPO_PRODUTO", obj.TipoProduto);
                comando.Parameters.AddWithValue("@PRECO", obj.Preco);
                comando.Parameters.AddWithValue("@EDICAO", obj.Edicao);
                comando.Parameters.AddWithValue("@ID_CATEGORIA", obj.Categoria);
                comando.Parameters.AddWithValue("@TIPO_PUBLICACAO", obj.TipoPublicacao);
                comando.Parameters.AddWithValue("@ANO", obj.Ano);
                comando.Parameters.AddWithValue("@IMAGEM", obj.Imagem);
                comando.Parameters.AddWithValue("@ID_EDITORA", obj.Editora);

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

        public void alterar(Produto obj)
        {

        }

        public void deletar(Produto obj)
        {

        }
    }
}
