using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Cliente
    {
        private int id;
        private Pessoa pessoa;
        private Assinatura assinatura;
        private Endereco enderecoAlternativo;
        private FormaPagamento formaDePagamento;

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
            set { this.formaDePagamento = value; }
            get { return formaDePagamento; }
        }
	
	
	}
}
