using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using br.com.dao;
using br.com.entidades;
using FluorineFx;

namespace br.com.servicos
{
    [RemotingService]
    public class ServicoPerfil
    {

        DaoPerfil daoPerfil = new DaoPerfil();
        
        public bool salvarPerfil(Perfil perfil)
        {
            if (perfil.perfil != null)
            {
                daoPerfil.salvar(perfil);
            }
            else {
                return false;
            }
            return true;
        }

        public bool deletarPerfil(Perfil perfil)
        {
            if (perfil.id != 0)
            {
                daoPerfil.deletar(perfil);
            }
            else
            {
                return false;
            }
            return true;
        }

        public List<Perfil> listarPefil()
        {
            List<Perfil> listaPerfil = new List<Perfil>();
            listaPerfil = daoPerfil.BuscarPerfil();
            return listaPerfil;
        }

    }
}
