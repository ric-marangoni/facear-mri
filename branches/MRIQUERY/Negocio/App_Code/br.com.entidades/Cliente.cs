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
    public class Cliente:Pessoa
    {
        private int id;
        private Pessoa pessoa;
        private Assinatura assinatura;
        private Endereco enderecoAlternativo;
        private FormaPagamento formaPagamento;

        public int Id
        {
            set {this.id = value;}
            get {return id;}
        }

        public Assinatura Assinatura_
        {
            set { this.assinatura = value; }
            get { return assinatura; }
        }

        public Pessoa Pessoa
        {
            set { this.pessoa = value; }
            get { return pessoa; }
        }

        public Endereco EnderecoAlternativo
        {
            set { this.enderecoAlternativo = value; }
            get { return enderecoAlternativo; }
        }
        public FormaPagamento FormaPagamento
        {
            set { this.formaPagamento = value; }
            get { return formaPagamento; }
        }
	
	
	}
}
