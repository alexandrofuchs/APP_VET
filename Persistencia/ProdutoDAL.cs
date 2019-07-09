using Modelo;
using System.Collections.Generic;

namespace Persistencia
{
    public class ProdutoDAL : Repository<Produto>
    {
        public Produto BuscarPorID(long id)
        {
            return BuscarUm(p => p.ProdutoID == id);
        }

        public IEnumerable<Produto> BuscarPorTipo(string tipo)
        {
            return BuscarVarios(p => p.GetType().Name.Equals(tipo));
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return BuscarVarios(p => p.Nome.Contains(nome));
        }

    }
}
