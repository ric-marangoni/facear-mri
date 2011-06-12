﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace br.com.entidades
{
    public class Funcionario:PessoaFisica
    {
        private int id;
        private Perfil perfil;
        private DateTime dataAdmissao;
        private DateTime dataDemissao;
        
        public int Id 
        {
          set { this.id = value; }
          get { return id; }
        }

        public Perfil Perfil
        {
           set { this.perfil = value; }
           get { return perfil; }
        }

        public DateTime DataAdmissao
        {
          set { this.dataAdmissao = value; }
          get { return dataAdmissao; }
        }

        public DateTime DataDemissao
        {
            set { this.dataDemissao = value; }
            get { return dataDemissao; }
        }
                
     }
}
