using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetById : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<ClienteResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public GetById(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpGet("api/clientes/{id}")]
        public async override Task<ActionResult<ClienteResponse>> HandleAsync(Guid id, CancellationToken ct = default)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
            var clienteEncontrado = new ClienteResponse
            {
                Id = cliente.Id,
                CodigoCliente = cliente.CodigoCliente,
                Email = cliente.Email,
                NivelCliente = cliente.NivelCliente,
                RazonSocial = cliente.RazonSocial,
                UltimaCompraRealizada = cliente.UltimaCompraRealizada,
            };

            return clienteEncontrado;
        }
    }
}