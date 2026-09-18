using eAgenda.Aplicacao.Modulos.ModuloContato;
using Microsoft.AspNetCore.Mvc;

namespace eAgenda.WebApi.Features.Contatos;

[ApiController]
[Route("api/contatos")]
public sealed class ContatosController(ServicoContato servicoContato) : ControllerBase // -> SEM RENDER DE VIEWS
{
    [HttpGet]
    public ActionResult<List<ListarContatosDto>> SelecionarTodos()
    {
        var resultado = servicoContato.SelecionarTodos();

        return Ok(resultado); // 200 com corpo vazio
    }

    [HttpPost]
    public ActionResult Cadastrar(CadastrarContatoRequest req)
    {
        var dto = new CadastrarContatoDto(
            req.Nome,
            req.Email,
            req.Telefone,
            req.Cargo,
            req.Empresa
        );

        var resultado = servicoContato.Cadastrar(dto);

        if (resultado.IsFailed)
            return BadRequest();

        var res = new CadastrarContatoResponse(resultado.Value);

        return Created("/api/contatos", res);
    }
}
