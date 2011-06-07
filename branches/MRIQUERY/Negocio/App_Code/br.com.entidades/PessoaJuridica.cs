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

public class PessoaJuridica:Pessoa
{
    private String razaoSocial;
    private long cnpj;

    public String RazaoSocial 
    {
        set { this.razaoSocial = value; }
        get { return razaoSocial; }
    }

    public long Cnpj 
    {
        set { this.cnpj = value; }
        get { return cnpj; }
    }
   
}
}
