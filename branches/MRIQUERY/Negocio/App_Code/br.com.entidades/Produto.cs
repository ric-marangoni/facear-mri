using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Produto
    {
        private int id;
        private String titulo;
        private String tipoProduto;
        private double preco;
        private String edicao;
        private Categoria categoria;
        private String tipoPublicacao;
        private DateTime ano;
        private byte imagem;
        private Editora editora;
        private String idioma;

        public int Id 
        {
            set { this.id = value; }
            get { return id; }
        }

        public String Titulo 
        {
            set { this.titulo = value; }
            get { return titulo; }
        }
        public String TipoProduto 
        {
            set { this.tipoProduto = value; }
            get { return tipoProduto; }
        }

        public double Preco 
        {
            set { this.preco = value; }
            get { return preco; }
        }

        public String Edicao 
        {
            set { this.edicao = value; }
            get { return edicao; }
        }

        public Categoria Categoria 
        {
            set { this.categoria = value; }
            get { return categoria; }
        }
        
        public String TipoPublicacao 
        {
            set { this.tipoPublicacao = value; }
            get { return tipoPublicacao; }
        }

        public DateTime Ano 
        {
            set { this.ano = value; }
            get { return ano; }
        }

        public byte Imagem 
        {
            set { this.imagem = value; }
            get { return imagem; }
        }

        public Editora Editora 
        {
            set { this.editora = value; }
            get { return editora; }
        }

        public String Idioma 
        {
            set { this.idioma = value; }
            get { return idioma; }
        }


    }
	
}
