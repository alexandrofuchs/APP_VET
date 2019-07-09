using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public abstract class Pessoa
    {

        public DateTime DataRegistro { get; private set; }

        private string cPF;
        public string CPF
        {
            get { return cPF; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("CPF Invalido!");
                }
                if (value.Length != 14)
                {
                    throw new Exception("CPF Invalido!");
                }
                cPF = value;
            }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                {
                    throw new Exception("Data de Nascimento deve ser Maior que 18 anos");
                }
                dataNascimento = value;
            }
        }
        [Required(ErrorMessage = "{0} é requerido")]
        public string Nome { get; set; }

        public string RG { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string NumeroResidencia { get; set; }

        public string Email { get; set; }

        protected Pessoa()
        {
            DataRegistro = DateTime.Now;
        }
    }




}
