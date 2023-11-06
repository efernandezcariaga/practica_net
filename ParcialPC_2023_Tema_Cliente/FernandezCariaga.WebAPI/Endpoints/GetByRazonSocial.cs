using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetByRazonSocial : EndpointBaseAsync
        .WithRequest<string>
        .WithActionResult<List<ClienteResponse>>
    {
        private readonly EvaluacionUsuarios _context;

        public GetByRazonSocial(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpGet("api/clientes/filtro/{RazonSocial}")]
        public async override Task<ActionResult<List<ClienteResponse>>> HandleAsync(string razonSocial, CancellationToken ct = default)
        {
            var clientes = await _context.Clientes.Where(c => c.RazonSocial.Contains(razonSocial)).ToListAsync();
            var clientesEncontrados = clientes.Select(c => new ClienteResponse
            {
                Id = c.Id,
                CodigoCliente = c.CodigoCliente,
                Email = c.Email,
                NivelCliente = c.NivelCliente,
                RazonSocial = c.RazonSocial,
                UltimaCompraRealizada = c.UltimaCompraRealizada,
            }).ToList();

            return clientesEncontrados;
        }
    }
}