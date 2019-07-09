using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Consulta
    {
        public long ConsultaID { get; set; }

        public DateTime DataConsulta { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public long VeterinarioID { get; set; }
        public virtual Veterinario Veterinario { get; set; }               

        public string ProblemasRelatados { get; set; }

        public string SintomasRelatados { get; set; }

        public string PrescricaoMedica { get; set; }

        public List<DadoConsulta> DadosConsulta { get; set; } = new List<DadoConsulta>();

        public string ExamesSolicitados { get; set; }

        public string MedicamentosReceitados { get; set; }

        public Consulta()
        {

        }

        public void AdicionarDadosConsulta(List<DadoConsulta> dadosConsulta)
        {
            DadosConsulta.AddRange(dadosConsulta);
        }

        public override string ToString()
        {
            return
              "Data da Consulta: "
              + DataConsulta.ToLongDateString()
              +" as "
              + DataConsulta.ToLongTimeString()              
              + "\r\n Animal: "
              + Animal.Nome
              + "\r\n Raça: "
              + Animal.Raca
              + "\r\n Espécie: "
              + Animal.Especie
              + "\r\n Cliente Proprietário: "
              + Animal.Cliente.Nome
              + ", CPF: "
              + Animal.Cliente.CPF
              + "\r\n Veterinário: "
              + Veterinario.Nome
              + ", CPF: "
              + Veterinario.CPF;
        }

    }
}
