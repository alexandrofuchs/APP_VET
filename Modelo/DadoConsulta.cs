namespace Modelo
{
    public class DadoConsulta
    {
        public long DadoConsultaID { get; set; }
        public string Dado { get; set; }
        public string Situacao { get; set; }

        public DadoConsulta()
        {
        }

        public DadoConsulta(string dado, string situacao)
        {
            Dado = dado;
            Situacao = situacao;
        }
    }
}
