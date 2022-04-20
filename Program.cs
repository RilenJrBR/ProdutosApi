using Microsoft.EntityFrameworkCore;
using ProdutosApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<ProdutoContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=cadProdutos;User Id=postgres;Password=rilen6578;"));

var app = builder.Build();


if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();