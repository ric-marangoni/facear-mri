using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public class Endereco
{
    private int id;
    private String estado;
    private String cidade;
    private String logradouro;
    private long cep;
    private long numero;
    private String complemento;

    public int Id 
    {
        set { this.id = value;}
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
    public long Cep
    {
        set { this.cep = value; }
        get { return cep; }
    }
    public long Numero
    {
        set { this.numero = value; }
        get { return numero; }
    }
    public String Complemento
    {
        set { this.complemento = value; }
        get { return complemento; }
    }
}
