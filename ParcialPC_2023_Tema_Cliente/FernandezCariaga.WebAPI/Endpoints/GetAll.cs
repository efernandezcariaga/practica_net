using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetAll : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<ClienteResponse>>
    {
        private readonly EvaluacionUsuarios _context;

        public GetAll(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpGet("api/clientes")]
        public async override Task<ActionResult<List<ClienteResponse>>> HandleAsync(CancellationToken ct = default)
        {
            var clientes = await _context.Clientes.ToListAsync();
            var clienteResponse = clientes.Select(c => new ClienteResponse
            {
                Id = c.Id,
                CodigoCliente = c.CodigoCliente,
                Email = c.Email,
                NivelCliente = c.NivelCliente,
                RazonSocial = c.RazonSocial,
                UltimaCompraRealizada = c.UltimaCompraRealizada,
            }).ToList();

            return clienteResponse;
        }
    }
}