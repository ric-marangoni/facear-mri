using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Loja
{
    public partial class Store : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Loja Leia+";
            
            if ((String)Session["login"] != null) {
                frmLogin.InnerText = Convert.ToString(Session["login"]);
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Session["login"] = btnEntrar.Text;
        }
    }
}
