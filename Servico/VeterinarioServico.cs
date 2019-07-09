using Modelo;
using Persistencia;
using System.Collections.Generic;

namespace Servico
{
    public class VeterinarioServico
    {
        private VeterinarioDAL veterinarioDAL = new VeterinarioDAL();
        
        public void Registrar(Veterinario veterinario)
        {
            veterinarioDAL.Add(veterinario);
        }

        public void Atualizar(Veterinario veterinario)
        {
            veterinarioDAL.Update(veterinario);
        }


        public Veterinario BuscarPorID(long veterinarioID)
        {
            return veterinarioDAL.BuscarPorID(veterinarioID);
        }

        public IEnumerable<Veterinario> BuscarTodos()
        {
            return veterinarioDAL.BuscarTodos();
        }

        public IEnumerable<Veterinario> BuscarVinculados()
        {
            return veterinarioDAL.BuscarVinculados();
        }

        public IEnumerable<Veterinario> BuscarPorNome(string nome)
        {
            return veterinarioDAL.BuscarPorNome(nome);
        }

        public IEnumerable<Consulta> ConsultasPorVeterinario(long veterinarioID)
        {
            return veterinarioDAL.BuscarConsultas(veterinarioID);
        }
    }
}
