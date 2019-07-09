using Modelo;
using Persistencia;
using System.Collections.Generic;

namespace Servico
{
    public class ProdutoServico
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();

        public void Registrar(Produto produto)
        {
            if (produto is Exame)
            {
                var p = produto as Exame;
                produtoDAL.Add(p);
            }
            else
            {
                if (produto is Medicamento)
                {
                    var p = produto as Medicamento;
                    produtoDAL.Add(p);
                }
                else
                {
                    if (produto is ServicoClinico)
                    {
                        var p = produto as ServicoClinico;
                        produtoDAL.Add(p);
                    }
                    else
                    {
                        produtoDAL.Add(produto);
                    }
                }
            }            
        }

        public void Remover(Produto produto)
        {
            produtoDAL.Remove(produto);
        }

        public void Atualizar(Produto produto)
        {
            if(produto is null)
            {
                throw new System.Exception("Produto não encontrado!");
            }
            produtoDAL.Update(produto);
        }

        public Produto BuscarPorID(long id)
        {
            return produtoDAL.BuscarPorID(id);

        }
        public IEnumerable<Produto> BuscarTodos()
        {
            return produtoDAL.BuscarTodos();
        }

        public IEnumerable<Produto> BuscarPorTipo(string tipo)
        {
            return produtoDAL.BuscarPorTipo(tipo);
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return produtoDAL.BuscarPorNome(nome);
        }

    }
}
