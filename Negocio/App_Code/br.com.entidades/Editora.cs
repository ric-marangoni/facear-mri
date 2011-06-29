using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;


namespace br.com.entidades
{
    public class Editora:PessoaJuridica
    {
        private ArrayList produto;

        public ArrayList Produto
        {
            set { this.produto = value; }
            get { return produto; }
        }
    }
}
