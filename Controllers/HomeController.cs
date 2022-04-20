using Microsoft.AspNetCore.Mvc;
using ProdutosApi.Models;

namespace ProdutosApi.Controllers;

#region snippet_Route
[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
#endregion
{
    private readonly ProdutoContext _context;

    public HomeController(ProdutoContext context){
        _context = context;
    }    

    [HttpPost]
    public async Task<ActionResult<Produtos>> cadastrar(Produtos produtos){
        _context.Produtos.Add(produtos);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Produtos), new { id = produtos.Id }, produtos);
    }
}