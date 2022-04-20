namespace ProdutosApi.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public decimal  valor { get; set; }
        public int estoque{ get; set;}
    }
}