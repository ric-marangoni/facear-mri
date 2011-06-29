using System;
using System.Data;
using System.Configuration;

namespace br.com.entidades
{
   public class PessoaFisica:Pessoa
   {
       private int id;
       private String nome;
       private DateTime dataNascimento;
       private String sexo;
       private String cpf;

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

       public String Cpf
       {
           set { this.cpf = value; }
           get { return cpf; }
       }
       	
   }
}
