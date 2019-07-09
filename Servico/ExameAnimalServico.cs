using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class ExameAnimalServico
    {
        ExameAnimalDAL exameAnimalDAL = new ExameAnimalDAL();
        public void Registrar(ExameAnimal exameAnimal)
        {
            exameAnimalDAL.Add(exameAnimal);
        }

        public ExameAnimal BuscarPorID(long id)
        {
            return exameAnimalDAL.BuscarPorID(id);      
        }
        
        public IEnumerable<ExameAnimal> BuscarPorAnimal(long id)
        {
            return exameAnimalDAL.BuscarPorAnimal(id);
        }

    }
}
