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

public class Assinatura
{
    private int id;
    private Cliente cliente;
    private Produto produto;
    private Plano plano;
    private int tipoAssinatura;
    private DateTime dataInicial;
    private DateTime dataFinal;

    public int Id 
    {
        set { this.id = value; }
        get { return id; }
    }

    public Cliente Cliente 
    {
        set { this.cliente = value; }
        get { return cliente; }
    }

    public Produto Produto 
    {
        set { this.produto = value; }
        get { return produto; } 
    }

    public Plano Plano
    {
        set { this.plano = value; }
        get { return plano; }
    }

    public Plano TipoAssinatura
    {
        set { this.tipoAssinatura = value; }
        get { return tipoAssinatura; }
    }

    public DateTime DataInicial 
    {
        set { this.dataInicial = value; }
        get { return dataInicial; }
    }

    public DateTime DataFinal 
    {
        set { this.dataFinal = value; }
        get { return dataFinal; }
    }
}
}
