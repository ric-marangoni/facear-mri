using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using br.com.entidades;
using System.Collections.Generic;

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

        public Cliente pegaClientePeloLogin(String login, String senha)
        {
            Cliente cliente = new Cliente();
            PessoaFisica pessoa = new PessoaFisica();
            Endereco endereco = new Endereco();

            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "SELECT U.ID_USUARIO, U.NOME, U.SEXO, U.DATA_NASCIMENTO, U.CPF_CNPJ, U.SENHA, U.LOGIN, U.STATUS," +
                             "U.EMAIL_PESSOAL, U.EMAIL_COMERCIAL, U.TELEFONE_COMERCIAL, U.TELEFONE_CELULAR, U.TELEFONE_RESIDENCIAL," +
                             "U.DATA_CADASTRO, END.CEP, END.ESTADO, END.CIDADE, END.BAIRRO, END.LOGRADOURO, END.NUMERO, END.COMPLEMENTO " +
                             "FROM TB_USUARIO U " +
                             "INNER JOIN TB_ENDERECO END ON U.ID_ENDERECO = END.ID_ENDERECO " +
                             "WHERE LOGIN = @LOGIN AND SENHA = @SENHA";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@LOGIN", login);
                comando.Parameters.AddWithValue("@SENHA", senha);

                MySqlDataReader r = comando.ExecuteReader();
                r.Read();
                                               
                pessoa.Id = (int)r["ID_USUARIO"];
                pessoa.Nome = (String)r["NOME"];
                pessoa.Login = (String)r["LOGIN"];
                pessoa.Senha = (String)r["SENHA"];
                pessoa.Sexo = (String)r["SEXO"];
                pessoa.DataNascimento = (DateTime)r["DATA_NASCIMENTO"];
                pessoa.Cpf = (String)r["CPF_CNPJ"];
                pessoa.Status = (int)r["STATUS"];
                pessoa.EmailPessoal = (String)r["EMAIL_PESSOAL"];
                pessoa.EmailComercial = (String)r["EMAIL_COMERCIAL"];
                pessoa.TelefoneResidencial = (String)r["TELEFONE_RESIDENCIAL"];
                pessoa.TelefoneCelular = (String)r["TELEFONE_CELULAR"];
                pessoa.TelefoneComercial = (String)r["TELEFONE_COMERCIAL"];
                
                endereco.Cep = (String)r["CEP"];
                endereco.Cidade = (String)r["CIDADE"];
                endereco.Estado = (String)r["ESTADO"];
                endereco.Bairro = (String)r["BAIRRO"];
                endereco.Logradouro = (String)r["LOGRADOURO"];
                endereco.Numero = (String)r["NUMERO"];
                endereco.Complemento = (String)r["COMPLEMENTO"];
                
                pessoa.Endereco = endereco;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro" + ex);
            }
            finally
            {
                conexao.Close();
                cliente.PessoaFisica = pessoa;
            }

            return cliente;                        
            
        }

        public int verificaDisponibilidadeLogin(String login)
        {
            int qtd = 0;
            
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "SELECT COUNT(ID_USUARIO)AS QTD FROM TB_USUARIO" +
                             " WHERE LOGIN = @LOGIN";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@LOGIN", login);                

                MySqlDataReader r = comando.ExecuteReader();
                r.Read();

                qtd = Convert.ToInt32((Int64)r["QTD"]);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex);
            }
            finally
            {
                conexao.Close();                
            }

            return qtd;  
        }
        
    }
}
