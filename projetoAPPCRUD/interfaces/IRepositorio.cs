using System.Collections.Generic;

namespace projetoAPPCRUD.interfaces
{
    public interface IRepositorio<T>
    {
         
        List<T> lista();

        T RetornaPorId(int id);

        void Inserir(T identidade);

        void Excluir(int id);

        void Atualizar(int id, T identidade);

        int ProximoId();
    }
}