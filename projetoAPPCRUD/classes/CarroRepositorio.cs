using System.Collections.Generic;
using projetoAPPCRUD.interfaces;

namespace projetoAPPCRUD
{
    public class CarroRepositorio : IRepositorio<Carro>
    {

        private List<Carro> ListaCarros = new List<Carro>();

        public void Atualizar(int id, Carro identidade)
        {
            
            ListaCarros[id] = identidade;
        }

        public void Excluir(int id)
        {

            ListaCarros[id] = null;
        }

        public void Inserir(Carro identidade)
        {

            ListaCarros.Add(identidade);
        }

        public List<Carro> lista()
        {

            return ListaCarros;
        }

        public int ProximoId()
        {

            return ListaCarros.Count;
        }

        public Carro RetornaPorId(int id)
        {
            
            return ListaCarros[id];
        }
    }
}