using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using br.com.entidades;

namespace br.com.dao
{
    public class DaoProduto : Dao<Produto>
    {

        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;


        public void salvar(Produto obj)
        {
            try
            {
                Produto produto = new Produto();
                Editora editora = new Editora();
                Categoria categoria = new Categoria();
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "INSERT INTO TB_PRODUTO(TITULO,TIPO_PRODUTO,PRECO,EDICAO,CATEGORIA,PERIOCIDADE,ANO,IMAGEM,IDIOMA,EDITORA)VALUES(@TITULO,@TIPO_PRODUTO,@PRECO,@EDICAO,@CATEGORIA,@PERIOCIDADE,@ANO,@IMAGEM,@IDIOMA,@EDITORA)";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@TITULO", obj.Titulo);
                comando.Parameters.AddWithValue("@TIPO_PRODUTO", obj.TipoProduto);
                comando.Parameters.AddWithValue("@PRECO", obj.Preco);
                comando.Parameters.AddWithValue("@EDICAO", obj.Edicao);
                comando.Parameters.AddWithValue("@CATEGORIA", obj.Categoria.ID);
                //comando.Parameters.AddWithValue("@PERIOCIDADE", obj.periodicidade);
                comando.Parameters.AddWithValue("@ANO", obj.Ano);
                comando.Parameters.AddWithValue("@IMAGEM", obj.Imagem);
                comando.Parameters.AddWithValue("@IDIOMA", obj.Idioma);
                comando.Parameters.AddWithValue("@EDITORA", obj.Editora.id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Cadastrar Produto ! " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<Produto> BuscarProduto()
        {
            List<Produto> listProduto = new List<Produto>();

            Produto produto = new Produto();
            Editora editora = new Editora();
            Categoria categoria = new Categoria();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            conexao = new MySqlConnection();
            comando = new MySqlCommand();
            try
            {
                Console.WriteLine("*****INICIANDO BUSCA DE PRODUTO");
                conexao.ConnectionString = conexaoBanco;
                string sql = "select * from TB_PRODUTO,TB_EDITORA,TB_USUARIO,TB_CATEGORIA where TB_PRODUTO.EDITORA = TB_EDITORA.ID_EDITORA AND TB_EDITORA.EDITORA = TB_USUARIO.ID_USUARIO AND TB_PRODUTO.CATEGORIA = TB_CATEGORIA.ID_CATEGORIA";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                MySqlDataReader busca = comando.ExecuteReader();
                while (busca.Read())
                {
                    produto = new Produto();
                    editora = new Editora();
                    categoria = new Categoria();
                    pessoaJuridica = new PessoaJuridica();

                    produto.Id = (int)busca["ID_PRODUTO"];
                    produto.Titulo = (String)busca["TITULO"];
                    produto.TipoProduto = (String)busca["TIPO_PRODUTO"];
                    produto.Preco = (double)busca["PRECO"];
                    produto.Edicao = (String)busca["EDICAO"];
                   // produto.periodicidade = (String)busca["PERIOCIDADE"];
                    produto.Ano = (DateTime)busca["ANO"];
                    produto.Imagem = (byte[])busca["IMAGEM"];
                   
                    produto.Idioma = (String)busca["IDIOMA"];

                    categoria.ID = (int)busca["ID_CATEGORIA"];
                    categoria.Categoria_= (String)busca["NOME_CATEGORIA"];

                    pessoaJuridica.Id = (int)busca["ID_USUARIO"];
                    pessoaJuridica.RazaoSocial = (String)busca["NOME"];
                    pessoaJuridica.Login = (String)busca["LOGIN"];
                    pessoaJuridica.Senha = (String)busca["SENHA"];
                    pessoaJuridica.Cnpj = (String)busca["CPF_CNPJ"];
                    pessoaJuridica.EmailComercial = (String)busca["EMAIL_COMERCIAL"];
                    pessoaJuridica.EmailPessoal = (String)busca["EMAIL_PESSOAL"];
                    pessoaJuridica.EmailComercial = (String)busca["EMAIL_COMERCIAL"];
                    pessoaJuridica.TelefoneResidencial = (String)busca["TELEFONE_RESIDENCIAL"];
                    pessoaJuridica.TelefoneComercial = (String)busca["TELEFONE_COMERCIAL"];
                    pessoaJuridica.TelefoneCelular = (String)busca["TELEFONE_CELULAR"];
                    //pessoaJuridica.DataCadastro = (DateTime)busca["DATA_CADASTRO"];

                    editora.id = (int)busca["ID_EDITORA"];
                    editora.pessoaJuridica = pessoaJuridica;

                    produto.Categoria = categoria;
                    produto.Editora = editora;


                    listProduto.Add(produto);
                }
                Console.WriteLine("***********FIM DE BUSCA PRODUTO");
                return listProduto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Buscar PRODUTO........ " + ex);
                return new List<Produto>();
            }
            finally
            {
                conexao.Close();
            }
        }


        public void alterar(Produto obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "UPDATE  TB_PRODUTO SET  TITULO = @TITULO , TIPO_PRODUTO = @TIPO_PRODUTO ,PRECO = @PRECO ,EDICAO = @EDICAO, CATEGORIA = @CATEGORIA, PERIOCIDADE = @PERIOCIDADE, ANO = @ANO, IMAGEM = @IMAGEM, IDIOMA = @IDIOMA, EDITORA = @EDITORA WHERE TB_PRODUTO.ID_PRODUTO = " + obj.Id;
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@TITULO", obj.Titulo);
                comando.Parameters.AddWithValue("@TIPO_PRODUTO", obj.TipoProduto);
                comando.Parameters.AddWithValue("@PRECO", obj.Preco);
                comando.Parameters.AddWithValue("@EDICAO", obj.Edicao);
                comando.Parameters.AddWithValue("@CATEGORIA", obj.Categoria.ID);
                //comando.Parameters.AddWithValue("@PERIOCIDADE", obj.periodicidade);
                comando.Parameters.AddWithValue("@ANO", obj.Ano);
                comando.Parameters.AddWithValue("@IMAGEM", obj.Imagem);
                comando.Parameters.AddWithValue("@IDIOMA", obj.Idioma);
                comando.Parameters.AddWithValue("@EDITORA", obj.Editora.id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Alterar Produto ! " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void deletar(Produto obj)
        {
            try
            {
                Console.WriteLine("*****INICIANDO EXCLUSÃO DE Produto");
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "DELETE FROM TB_PRODUTO WHERE ID_PRODUTO = " + obj.Id;
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                Console.WriteLine("***********FIM DE EXCLUSÃO PRODUTO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao EXCLUIR Produto ! " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
