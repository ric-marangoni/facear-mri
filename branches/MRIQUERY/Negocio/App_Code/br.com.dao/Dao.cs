using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace br.com.dao
{
    public interface Dao<T> where T:new()
    {

        void salvar(T obj);

        void alterar(T obj);
    
        void deletar(T obj);
    }
}
