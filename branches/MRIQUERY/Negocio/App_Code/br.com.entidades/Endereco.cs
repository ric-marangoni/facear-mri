using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Endereco
    {
        private int id;
        private String estado;
        private String cidade;
        private String logradouro;
        private String cep;
        private String numero;
        private String bairro;
        private String complemento;

        public int Id
        {
            set { this.id = value; }
            get { return id; }
        }

        public String Estado
        {
            set { this.estado = value; }
            get { return estado; }
        }
        public String Cidade
        {
            set { this.cidade = value; }
            get { return cidade; }
        }
        public String Logradouro
        {
            set { this.logradouro = value; }
            get { return logradouro; }
        }
        public String Cep
        {
            set { this.cep = value; }
            get { return cep; }
        }
        public String Numero
        {
            set { this.numero = value; }
            get { return numero; }
        }

        public String Bairro
        {
            set { this.bairro = value; }
            get { return bairro; }
        }

        public String Complemento
        {
            set { this.complemento = value; }
            get { return complemento; }
        }
    }
}
