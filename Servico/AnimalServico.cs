using Modelo;
using Persistencia;
using System.Collections.Generic;

namespace Servico
{
    public class AnimalServico
    {
        private AnimalDAL animalDAL = new AnimalDAL();

        public void Registrar(Animal animal)
        {
            animalDAL.Add(animal);
        }

        public void Atualizar(Animal animal)
        {
            animalDAL.Update(animal);
        }

        public void Remover(Animal animal)
        {
            animalDAL.Remove(animal);
        }

        public Animal BuscarPorID(long id)
        {
            return animalDAL.BuscarPorID(id);
        }

        public IEnumerable<Animal> BuscarPorNome(string nome)
        {
            return animalDAL.BuscarPorNome(nome);
        }

        public IEnumerable<Animal> BuscarPorNomeProprietario(string nome)
        {
            return animalDAL.BuscarPorNomeProprietario(nome);
        }

        public IEnumerable<Animal> BuscarTodos()
        {
            return animalDAL.BuscarTodos();
        }

        public IEnumerable<Animal> BuscarPorProprietario(long clienteID)
        {
            return animalDAL.BuscarPorProprietario(clienteID);
        }


    }
}
