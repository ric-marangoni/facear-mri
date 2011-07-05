using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{  
    
    public abstract class Pessoa
    {
        private String status;
        private DateTime dataCadastro;
        private String senha;
        private String login;
        private Endereco endereco;
        private String emailPessoal;
        private String emailComercial;
        private String telefoneResidencial;
        private String telefoneCelular;
        private String telefoneComercial;

         
        public String Status
        {
            set { this.status = value; }
            get { return status; }
        }

        public DateTime DataCadastro
        {
            set { this.dataCadastro = value; }
            get { return dataCadastro; }
        }
        public String Senha
        {
            set { this.senha = value; }
            get { return senha; }
        }
        public String Login
        {
            set { this.login = value; }
            get { return login; }
        }
        public Endereco Endereco
        {
            set { this.endereco = value; }
            get { return endereco; }
        }
        public String EmailComercial
        {
            set { this.emailComercial = value; }
            get { return emailComercial; }
        }

        public String EmailPessoal
        {
            set { this.emailPessoal = value; }
            get { return emailPessoal; }
        }
        public String TelefoneResidencial
        {
            set { this.telefoneResidencial = value; }
            get { return telefoneResidencial; }
        }
        public String TelefoneCelular
        {
            set { this.telefoneCelular = value; }
            get { return telefoneCelular; }
        }
        public String TelefoneComercial
        {
            set { this.telefoneComercial = value; }
            get { return telefoneComercial; }
        }
    }
	
}