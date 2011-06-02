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
        private Assinatura assinatura;
        private Endereco enderecoAlternativo;
        private int tipoCliete;

        public int Id
        {
            set {this.id = value;}
            get {return id;}
        }
       
        public Assinatura Assinatura
        {
            set { this.assinatura = value; }
            get { return assinatura; }
        }
        public Endereco EnderecoAlternativo
        {
            set { this.enderecoAlternativo = value; }
            get { return enderecoAlternativo; }
        }
        public int TipoCliente
        {
            set { this.tipoCliete = value; }
            get { return tipoCliete; }
        }
	
	
	}
}
