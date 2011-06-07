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
    public class Categoria
    {
        private int id;
        private String categoria;

        public int ID
        {
            set { this.id = value; }
            get { return id; }
        }

        public String Categoria
        {
            set { this.categoria = value; }
            get { return categoria; }
        }
    }
}
