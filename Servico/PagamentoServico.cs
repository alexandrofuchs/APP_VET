using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class PagamentoServico
    {
        private PagamentoDAL pagamentoDAL = new PagamentoDAL();

        public void Registrar(Pagamento pagamento)
        {
            if( pagamento.Valor < 1)
            {
                throw new Exception("Valor deve ser maior que zero!");
            }
            pagamentoDAL.Add(pagamento);
        }        

        public IEnumerable<Pagamento> BuscarPorData(DateTime data)
        {
            return pagamentoDAL.BuscarPorData(data);
        }

        public IEnumerable<Pagamento> BuscarEntreDatas(DateTime inicio, DateTime final)
        {
            return pagamentoDAL.BuscarEntreDatas(inicio, final);
        }

        public IEnumerable<Pagamento> BuscarPorMes(int mes)
        {
            return pagamentoDAL.BuscarPorMes(mes);
        }

    }
}
