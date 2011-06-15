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
    public class FormaPagamento
    {

        private int id;
        private DateTime validade;
        private String tipoPagamento;
        private long numeroCartao;
        private String bandeira;

        public long NumeroCartao
        {
            get { return numeroCartao; }
            set { numeroCartao = value; }
        }

        public String TipoPagamento
        {
            get { return tipoPagamento; }
            set { tipoPagamento = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Validade
        {
            get { return validade; }
            set { validade = value; }
        }

        public String Bandeira
        {
            get { return bandeira; }
            set { bandeira = value; }
        }
    }
}
