using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using br.com.entidades;

namespace br.com.dao
{
    public class DaoPessoaFisica:Dao<PessoaFisica>
    {
        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;

        public void salvar(PessoaFisica obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql =
                "INSERT INTO TB_USUARIO(NOME,SEXO,DATA_NASCIMENTO,CPF_CNPJ,SENHA,LOGIN,STATUS,EMAIL_PESSOAL,EMAIL_COMERCIAL,TELEFONE_COMERCIAL,TELEFONE_CELULAR,TELEFONE_RESIDENCIAL,DATA_CADASTRO,ID_ENDERECO)" +
                "VALUES(@NOME,@SEXO,@DATA_NASCIMENTO,@CPF_CNPJ,@SENHA,@LOGIN,@STATUS_,@EMAIL_PESSOAL,@EMAIL_COMERCIAL,@TELEFONE_COMERCIAL,@TELEFONE_CELULAR,@TELEFONE_RESIDENCIAL,DATA_CADASTRO,LAST_INSERT_ID())";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@NOME", obj.Nome);
                comando.Parameters.AddWithValue("@SEXO", obj.Sexo);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", obj.DataNascimento);
                comando.Parameters.AddWithValue("@CPF_CNPJ", obj.Cpf);
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

        public void alterar(PessoaFisica obj)
        {
            
        }

        public void deletar(PessoaFisica obj)
        {
           
        }
        
    }
}
