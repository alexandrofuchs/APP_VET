namespace Modelo
{
    public class ItemProduto
    {
        public long ItemProdutoID { get; set; }
        public string Nome { get; set; }
        public double Custo { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return "Produto: " + Nome + ", Custo: " + Custo + ", Quantidade: " + Quantidade + "Tipo: " + Tipo;
        }
    }
}
