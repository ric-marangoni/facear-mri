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
       private DateTime dataNascimento;
       private String sexo;
       private long cpf;

       public DateTime DataNascimento
       {
           get { return dataNascimento; }
           set { dataNascimento = value; }
       }
       public int Sexo
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
