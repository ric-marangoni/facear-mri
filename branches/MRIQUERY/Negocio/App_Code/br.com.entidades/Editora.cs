using System;
using System.Data;
using System.Configuration;
using System.Collections;

namespace br.com.entidades
{
    public class Editora
    {
        private int id_;
        private PessoaJuridica pessoaJuridica_;

        public int id
        {
            set { id_ = value; }
            get { return id_; }
        }

        public PessoaJuridica pessoaJuridica
        {
            set {pessoaJuridica_ = value; }
            get { return pessoaJuridica_; }
        }
    }
}
