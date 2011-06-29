using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using br.com.entidades;
using System.Collections;
using System.Collections.Generic;

namespace br.com.dao
{
    public class DaoPerfil:Dao<Perfil>
    {
        private String conexaoBanco = "Server=localhost;user id = root; password = admin;database = projeto_integrador_mriquery;";
        private MySqlConnection conexao = null;
        MySqlCommand comando = null;

        public void salvar(Perfil obj)
        {
            try
            {
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "INSERT INTO TB_PERFIL(PERFIL,DESCRICAO)VALUES(@PERFIL,@DESCRICAO)";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@PERFIL", obj.perfil);
                comando.Parameters.AddWithValue("@DESCRICAO", obj.descricao);
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
        public List<Perfil> BuscarPerfil()
        {
            List<Perfil> listPerfil = new List<Perfil>();
            conexao = new MySqlConnection();
            comando = new MySqlCommand();
            try
            {
                Console.WriteLine("*****INICIANDO BUSCA DE PERFIL");
                conexao.ConnectionString = conexaoBanco;
                string sql = "SELECT *FROM TB_PERFIL";
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                MySqlDataReader busca = comando.ExecuteReader();
                while (busca.Read())
                {
                    Perfil perfil = new Perfil();
                    perfil.id =(int)busca["ID_PERFIL"];
                    perfil.perfil =(String)busca["PERFIL"];
                    perfil.descricao = (String)busca["DESCRICAO"];
                    listPerfil.Add(perfil);
                }
                Console.WriteLine("***********FIM DE BUSCA DE PERFIL");
                return listPerfil;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Buscar Perfil........ " + ex);
                return new List<Perfil>();
            }
            finally
            {
                conexao.Close();
            }
        }

        public void alterar(Perfil obj)
        {
            
        }

        public void deletar(Perfil obj)
        {
            try
            {
                Console.WriteLine("*****INICIANDO EXCLUSÃO DE PERFIL");
                conexao = new MySqlConnection();
                comando = new MySqlCommand();
                conexao.ConnectionString = conexaoBanco;
                string sql = "DELETE FROM TB_PERFIL WHERE ID_PERFIL = "+ obj.id;
                conexao.Open();
                comando.CommandText = sql;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                Console.WriteLine("***********FIM DE EXCLUSÃO PERFIL");
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

    }
}
