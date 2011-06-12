using System;
using System.Data;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;

namespace br.com.entidades
{
    public class Plano
    {
        private int id;
        private String nome;
        private String descricao;
        private double preco;
        private ArrayList produto;

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

        public String Descricao
        {
            set { this.descricao = value; }
            get { return descricao; }
        }
        public double Preco
        {
            set { this.preco = value; }
            get { return preco; }
        }

        public ArrayList Produto
        {
            set { this.produto = value; }
            get { return produto; }
        }
    }
}	

