using Microsoft.EntityFrameworkCore;
using ProdutosApi.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ProdutoContext>(opt =>
    opt.UseNpgsql(@"Host=myserver;Username=postgres;Password=rilen6578;Database=cadProdutos"));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
