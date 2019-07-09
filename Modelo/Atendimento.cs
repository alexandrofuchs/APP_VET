using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class Atendimento
    {
        public long AtendimentoID { get; set; }

        public StatusPagamento Status { get; set; }

        public DateTime DataRegistro { get; private set; }

        public DateTime DataVencimento { get; set; }

        public long AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public virtual ICollection<ItemProduto> ItemProdutos { get; set; } = new List<ItemProduto>();

        public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public Atendimento()
        {
            DataRegistro = DateTime.Now;
        }

        public Atendimento(DateTime dataVencimento, long animalID) : this()
        {
            DataVencimento = dataVencimento;
            AnimalID = animalID;
        }

        public void AdicionarItemProduto(string nome, double custo, int quantidade, string tipo)
        {
            ItemProdutos.Add(new ItemProduto
            {
                Nome = nome,
                Custo = custo,
                Quantidade = quantidade,
                Tipo = tipo
            });
        }

        public void RemoverItemProduto(string nome)
        {
            if (ItemProdutos.Count > 0)
            {
                var p = ItemProdutos.FirstOrDefault(ps => ps.Nome.Equals(nome));
                ItemProdutos.Remove(p);
            }
        }

        public double TotalAtendimento()
        {
            return ItemProdutos.Sum(ps => ps.Custo * ps.Quantidade);
        }

        public double TotalServicos()
        {
            return ItemProdutos.Where(ps => ps.Tipo.Equals("ServicoClinico")).Sum(ps => ps.Custo * ps.Quantidade);
        }

        public double TotalMedicamentos()
        {
            return ItemProdutos.Where(ps => ps.Tipo.Equals("Medicamento")).Sum(ps => ps.Custo * ps.Quantidade);
        }

        public double TotalExames()
        {
            return ItemProdutos.Where(ps => ps.Tipo.Equals("Exame")).Sum(ps => ps.Custo * ps.Quantidade);
        }

        public double TotalOutrosProdutos()
        {
            return ItemProdutos.Where(ps => ps.Tipo.Equals("Produto")).Sum(ps => ps.Custo * ps.Quantidade);
        }

        public double TotalPago()
        {
            if (Pagamentos.Sum(p => p.Valor) >= TotalAtendimento())
            {
                Status = StatusPagamento.Paga;
            }
            return Pagamentos.Sum(p => p.Valor);            
        }

        public void EfetuarPagamento(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);
           
        }
    }
}
