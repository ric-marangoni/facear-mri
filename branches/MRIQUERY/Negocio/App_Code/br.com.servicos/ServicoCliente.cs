using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using br.com.dao;
using br.com.entidades;

namespace br.com.servicos
{
    public class ServicoCliente
    {
        DaoEndereco daoEndereco = new DaoEndereco();
        DaoPessoaFisica daoPessoaFisica = new DaoPessoaFisica();

        public bool salvarCliente(Cliente cliente)
        {
            daoEndereco.salvar(cliente.PessoaFisica.Endereco);
            daoPessoaFisica.salvar(cliente.PessoaFisica);

            return true;
        }
    }
}
