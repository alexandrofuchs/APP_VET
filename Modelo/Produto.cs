using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Produto
    {
        public long ProdutoID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Sigla { get; set; }

        public double Custo { get; set; }

        public DateTime DataRegistro { get; protected set; }

        public Produto()
        {
            DataRegistro = DateTime.Now;
        }

    }
}