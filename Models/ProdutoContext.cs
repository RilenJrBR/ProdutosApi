using Microsoft.EntityFrameworkCore;
using ProdutosApi.Models;

public class ProdutoContext : DbContext
{
    public DbSet<Produtos> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=myserver;Username=postgres;Password=rilen6578;Database=cadProdutos");
}
