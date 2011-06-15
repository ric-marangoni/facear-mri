using System;
using System.Data;
using System.Configuration;
using System.Web;
using br.com.entidades;

namespace br.com.entidades
{

public class PessoaJuridica:Pessoa
{
    private int id;
    private String razaoSocial;
    private long cnpj;

    public int Id
    {
        set { this.id = value; }
        get { return id; }
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
