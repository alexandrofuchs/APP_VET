using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Animal
    {
        public long AnimalID { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public double Peso { get; set; }

        public double Idade { get; set; }

        public string Pelagem { get; set; }

        public string Sexo { get; set; }

        public long ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public DateTime DataRegistro { get; private set; }

        public List<Consulta> Consultas { get; set; }

        public List<ExameAnimal> Exames { get; set; }

        public Animal()
        {
            DataRegistro = DateTime.Now;
        }

        

        public override string ToString()
        {
            return
                "Nome: "+Nome
                +"\r\nRaça: "+Raca
                + "\r\nEspécie: "+Especie
                +"\r\n"+Cliente.ToString();                
        }
    }
}
