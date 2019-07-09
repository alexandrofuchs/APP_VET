using System;

namespace Modelo
{
    public class ExameAnimal
    {
        public long ExameAnimalID { get; set; }

        public string NomeExame { get; set; }

        public long AnimalID { get; set; }

        public Animal Animal { get; set; }

        public string Resultado { get; set; }

        public string Laudo { get; set; }

        public string Laboratorio { get; set; }

        public DateTime DataResultado { get; set; }

        public DateTime DataColeta { get; set; }

        public ExameAnimal()
        {
        }

        public ExameAnimal(string nomeExame, long animalID, string resultado, string laudo,
            DateTime dataResultado, DateTime dataColeta)
        {
            NomeExame = nomeExame;
            AnimalID = animalID;
            Resultado = resultado;
            Laudo = laudo;
            DataResultado = dataResultado;
            DataColeta = dataColeta;
        }
    }



}
