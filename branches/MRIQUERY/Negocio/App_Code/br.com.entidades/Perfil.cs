using System;
using System.Data;
using System.Configuration;
using System.Web;
using FluorineFx;


namespace br.com.entidades
{
    [RemotingService]
     public class Perfil {

        private int id_;
        private String perfil_;
        private String descricao_;

        public int id
        {
            set { this.id_ = value; }
            get { return id_; }
        }

        public String perfil
        {
            set { this.perfil_ = value; }
            get { return perfil_; }
        }

        public String descricao
        {
            set { this.descricao_ = value; }
            get { return descricao_; }
        }
    }
}
