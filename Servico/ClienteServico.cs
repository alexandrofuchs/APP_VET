using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Servico
{
    public class ClienteServico
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        private void ValidaDados(Cliente cliente)
        {
            
            if (string.IsNullOrEmpty(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Nome))
            {
                throw new Exception("Preencha o Nome!");
            }
            if ( clienteDAL.BuscarCPF(cliente.CPF))
            {
                throw new Exception("CPF já Registrado no Sistema");
            }    
            
        }

        public void Registrar(Cliente cliente)
        {
            ValidaDados(cliente);
            clienteDAL.Add(cliente);
        }

        public void Atualizar(Cliente cli)
        {
            clienteDAL.Update(cli);
        }


        public Cliente BuscarPorID(long id)
        {
            return clienteDAL.BuscarPorID(id);
        }

        public Cliente BuscarPorCPF(string cpf)
        {
            return clienteDAL.BuscarPorCPF(cpf);
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            return clienteDAL.BuscarTodos();
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return clienteDAL.BuscarPorNome(nome);
        }



    }
}
