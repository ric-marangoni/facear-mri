using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;


namespace br.com.entidades
{
    public class Editora:PessoaJuridica
    {
        private int id;
        private ArrayList produto;

        public int Id
        {
            set { this.id = value; }
            get { return id; }
        }

        public ArrayList Produto
        {
            set { this.produto = value; }
            get { return produto; }
        }
    }
}
