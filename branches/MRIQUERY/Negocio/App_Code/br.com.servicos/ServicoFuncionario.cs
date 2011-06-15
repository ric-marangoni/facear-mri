using System;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using br.com.entidades;
using br.com.dao;
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
