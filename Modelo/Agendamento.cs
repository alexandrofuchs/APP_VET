using Modelo.Enums;
using System;

namespace Modelo
{
    public class Agendamento
    {
        public long AgendamentoID { get; set; }
        
        private DateTime dataHora;

        public DateTime DataHora
        {
            get { return dataHora; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("Deve ser uma data futura!");
                }
                dataHora = value;
            }
        }

        public long VeterinarioID { get; set; }
        public virtual Veterinario Veterinario { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; } 
        
        public string DescricaoAgendamento { get; set; }

        public string Observacoes { get; set; }

        public StatusAgendamento Status { get; private set; }


        public Agendamento()
        {
            Status = StatusAgendamento.Agendado;
        }

        public void CancelarAgendamento()
        {
            if (Status == StatusAgendamento.Cancelado || Status == StatusAgendamento.Concluido)
            {
                throw new Exception($"Este atendimento já foi: {Status}");
            }
            Status = StatusAgendamento.Cancelado;            
        }
        
        public void ConcluirAtendimento()
        {
            if( Status == StatusAgendamento.Cancelado || Status == StatusAgendamento.Concluido)
            {
                throw new Exception($"Este atendimento já foi: {Status}");
            }
            Status = StatusAgendamento.Concluido;
        }
         

        public override string ToString()
        {
            return
                  "\r\nDados Agendamento: "
                + "\r\nData: "+ DataHora.ToLongDateString()+" ás " + DataHora.ToLongTimeString()
                + "\r\nServiços: "+ DescricaoAgendamento
                + "\r\nSituação: "+ Status
                + "\r\nDados do Animal: "
                + "\r\n"+Animal.ToString()
                + "\r\n"+Veterinario.ToString();                
        }
    }
}
