using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace br.com.entidades
{
    public class Pagamento
    {

        private int id;
        private DateTime validade;
        private String formaPagamento;
        private long numeroCartao;
        private String bandeira;

        public long NumeroCartao
        {
            get { return numeroCartao; }
            set { numeroCartao = value; }
        }
       
        public String FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public long NumeroCartao
        {
            get { return numeroCartao; }
            set { numeroCartao = value; }
        }

        public String Bandeira
        {
            get { return bandeira; }
            set { bandeira = value; }
        }
    }
}
