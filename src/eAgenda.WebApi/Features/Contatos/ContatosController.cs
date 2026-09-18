using Microsoft.AspNetCore.Mvc;

namespace eAgenda.WebApi.Features.Contatos;

[ApiController]
[Route("api/contatos")]
public sealed class ContatosController : ControllerBase // -> SEM RENDER DE VIEWS
{
    [HttpGet]
    public ActionResult SelecionarTodos()
    {
        return Ok(); // 200 com corpo vazio
    }
}
