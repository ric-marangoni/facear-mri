using System;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace br.com.entidades
{
   public class PessoaFisica:Pessoa
   {
       private int id;
       private String nome;
       private DateTime dataNascimento;
       private String sexo;
       private long cpf;

       public int Id
       {
           set { this.id = value; }
           get { return id; }
       }

       public String Nome
       {
           set { this.nome = value; }
           get { return nome; }
       }

       public DateTime DataNascimento
       {
           get { return dataNascimento; }
           set { dataNascimento = value; }
       }

       public String Sexo
       {
           set { this.sexo = value; }
           get { return sexo; }
       }

       public long Cpf
       {
           set { this.cpf = value; }
           get { return cpf; }
       }
       	
   }
}
