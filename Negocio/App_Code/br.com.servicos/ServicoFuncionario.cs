using System;
using System.Data;
using System.Configuration;
using br.com.dao;
using br.com.entidades;
using FluorineFx;

namespace br.com.servicos
{
    [RemotingService]
    public class ServicoFuncionario
    {
        DaoEndereco daoEndereco = new DaoEndereco();
        DaoPessoaFisica daoPessoaFisica = new DaoPessoaFisica();
        DaoPerfil daoPerfil = new DaoPerfil();
        DaoFuncionario daoFuncionario = new DaoFuncionario();

        public bool salvarFuncionario(Funcionario funcionario)
        {
            
            daoEndereco = new DaoEndereco();
            daoPessoaFisica = new DaoPessoaFisica();
            
            daoEndereco.salvar(funcionario.PessoaFisica.Endereco);
            daoPessoaFisica.salvar(funcionario.PessoaFisica);
           /// daoPerfil.salvar(funcionario.Perfil);
            daoFuncionario.salvar(funcionario);

           

            
            return true;
        }
        public void mensagen()
        {
            Console.WriteLine("hdhyfisifdsuofad");
        }
        
        
    }
}
