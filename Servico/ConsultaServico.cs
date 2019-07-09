using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Servico
{
    public class ConsultaServico
    {
        private ConsultaDAL consultaDAL = new ConsultaDAL();


        private void ValidarDados(Consulta consulta)
        {
            if( consulta.Animal is null)
            {
                throw new Exception("Animal não Relacionado!");
            }
            if( consulta.Veterinario is null)
            {
                throw new Exception("Veterinario não Relacionado!");
            }
        }
        
        public void Registrar(Consulta consulta)
        {
            //ValidarDados(consulta);
            consultaDAL.Add(consulta);
        }

        public Consulta BuscarPorID(long id)
        {
            return consultaDAL.BuscarPorID(id);
        }

        public IEnumerable<Consulta> BuscarPorAnimal(long id)
        {
            return consultaDAL.BuscarPorAnimal(id);
        }


        

    }
}
