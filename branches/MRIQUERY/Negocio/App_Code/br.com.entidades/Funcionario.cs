using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Funcionario
    {
        private Perfil perfil;
        private PessoaFisica pessoaFisica;
        private DateTime dataAdmissao;
        private DateTime dataDemissao;

        public Perfil Perfil
        {
           set { this.perfil = value; }
           get { return perfil; }
        }

        public PessoaFisica PessoaFisica
        {
            set { this.pessoaFisica = value; }
            get { return pessoaFisica; }
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
