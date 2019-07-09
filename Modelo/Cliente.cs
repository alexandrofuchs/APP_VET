using Modelo.Enums;
using System.Collections.Generic;

namespace Modelo
{
    public class Cliente : Pessoa
    {
        public long ClienteID { get; set; }

        public StatusCliente Status { get; set; }

        public virtual List<Animal> Animais { get; set; }

        public override string ToString()
        {
            return
                "Dados Cliente: "
                + "\r\nNome: " + Nome
                + "\r\nCPF: " + CPF
                + "\r\nTelefone: " + Telefone
                + "\r\nCelular: " + Celular;                
        }
    }
}
