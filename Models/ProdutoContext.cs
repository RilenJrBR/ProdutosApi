using Microsoft.EntityFrameworkCore;
using ProdutosApi.Models;

namespace ProdutosApi.Models
{
    public class ProdutoContext : DbContext
    {
        /*public DbSet<Produtos> Produtos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Host=myserver;Username=postgres;Password=rilen6578;Database=cadProdutos");*/

        public ProdutoContext(DbContextOptions<ProdutoContext> options)
                : base(options)
            {
            }

            public DbSet<Produto> Produtos { get; set; } = null!;
    }
    
}
