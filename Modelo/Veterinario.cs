using Modelo.Enums;
using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Veterinario : Pessoa
    {
        public long VeterinarioID { get; set; }

        public StatusVeterinario Vinculo { get; private set; }

        public string Especialidade { get; set; }

        public virtual List<Consulta> Consultas { get; set; }

        public Veterinario() : base()
        {
            Vinculo = StatusVeterinario.Ativo;  
        }

        public Veterinario(string nome, string cpf, DateTime dataRegistro): this()
        {
            Nome = nome;
            CPF = cpf;     
        }

        public void AlterarVinculo()
        {
            if( Vinculo == StatusVeterinario.Ativo)
            {
                Vinculo = StatusVeterinario.Desvinculado;
            }
            else
            {
                Vinculo = StatusVeterinario.Ativo;
            }            
        }

        public override string ToString()
        {
            return
                "Veterinario: "
                + "\r\nNome: "+ Nome
                + "\r\nCPF: " + CPF
                + "\r\nEspecialidade: "+ Especialidade
                + "\r\nTelefone: "+ Telefone
                + "\r\nCelular: "+ Celular;                
        }
    }
}
