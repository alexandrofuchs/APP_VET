using Microsoft.EntityFrameworkCore;
using System.Linq;
using Modelo;
using System.Collections.Generic;

namespace Persistencia
{
    public class VeterinarioDAL : Repository<Veterinario>
    {
        public IEnumerable<Consulta> BuscarConsultas(long veterinarioID)
        {
            using(var ctx = new EFContext())
            {
                return ctx.Veterinario
                    .Include(v => v.Consultas)
                    .SingleOrDefault(v => v.VeterinarioID == veterinarioID)
                    .Consultas;
            }
        }

        public Veterinario BuscarPorID(long veterinarioID)
        {
            return BuscarUm(v => v.VeterinarioID == veterinarioID);
        }

        public IEnumerable<Veterinario> BuscarPorNome(string nome)
        {
            return BuscarVarios(v => v.Nome.Contains(nome) && v.Vinculo == Modelo.Enums.StatusVeterinario.Ativo);
        }

        public IEnumerable<Veterinario> BuscarVinculados()
        {
            return BuscarVarios(v => v.Vinculo == Modelo.Enums.StatusVeterinario.Ativo);
        }



    }
}
