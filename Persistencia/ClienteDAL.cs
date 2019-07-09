using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class ClienteDAL : Repository<Cliente>
    {
        public bool BuscarCPF(string cpf)
        {
            return Buscar(c => c.CPF.Equals(cpf));
        }

        public Cliente BuscarPorID(long id)
        {
            return base.BuscarUm(c => c.ClienteID == id);
        }

        public Cliente BuscarPorCPF(string cpf)
        {
            return base.BuscarUm(c => c.CPF.Equals(cpf));
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return BuscarVarios(c => c.Nome.Contains(nome));
        }
    }
}

