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
using System.Text;

namespace Loja
{
    
    public static class Alert
    {
        
        public static void Show(string message)
        {
  
            string cleanMessage = message.Replace("'", "\'");
            string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

  
            Page page = HttpContext.Current.CurrentHandler as Page;

  
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Alert), "alert", script);
            }
        }
    } 
}


