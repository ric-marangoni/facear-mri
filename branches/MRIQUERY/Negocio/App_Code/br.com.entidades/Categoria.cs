using System;
using System.Data;
using System.Configuration;
using System.Web;

namespace br.com.entidades
{
    public class Categoria
    {
        private int id;
        private String categoria;

        public int ID
        {
            set { this.id = value; }
            get { return id; }
        }

        public String Categoria_
        {
            set { this.categoria = value; }
            get { return categoria; }
        }
    }
}
