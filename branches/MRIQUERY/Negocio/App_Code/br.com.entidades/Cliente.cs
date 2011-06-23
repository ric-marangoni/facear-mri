using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Cliente
    {
        private int id;
        private PessoaFisica pessoaFisica_;
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

        public PessoaFisica PessoaFisica
        {
            set { this.pessoaFisica_ = value; }
            get { return pessoaFisica_; }
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
