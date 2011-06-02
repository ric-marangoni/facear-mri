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
    private int id;
    private String nomeFantasia;
    private String razaoSocial;
    private long cnpj;

    public int Id 
    {
        set { this.id = value; }
        get { return id; }
    }

    public String NomeFantasia 
    {
        set { this.nomeFantasia = value; }
        get { return nomeFantasia; }

    }

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
