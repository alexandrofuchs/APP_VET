using System;

namespace Modelo
{
    public class Pagamento
    {
        public long PagamentoID { get; set; }
        public DateTime DataHora { get; set; }
        public double Valor { get; set; }
        public long AtendimentoID { get; set; }
        public virtual Atendimento Atendimento { get; set; }


        public Pagamento()
        {
        }

        public Pagamento(long pagamentoID, DateTime dataHora, double valor, Atendimento atendimento)
        {
            PagamentoID = pagamentoID;
            DataHora = dataHora;
            Valor = valor;
        }
    }
}
