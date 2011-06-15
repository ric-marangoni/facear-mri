using System;
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
    
    public abstract class Pessoa
    {
        private String status;
        private DateTime dataCadastro;
        private String senha;
        private String login;
        private Endereco endereco;
        private String emailPessoal;
        private String emailComercial;
        private long telefoneResidencial;
        private long telefoneCelular;
        private long telefoneComercial;

         
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
        public long TelefoneResidencial
        {
            set { this.telefoneResidencial = value; }
            get { return telefoneResidencial; }
        }
        public long TelefoneCelular
        {
            set { this.telefoneCelular = value; }
            get { return TelefoneCelular; }
        }
        public long TelefoneComercial
        {
            set { this.telefoneComercial = value; }
            get { return telefoneComercial; }
        }
    }
	
}