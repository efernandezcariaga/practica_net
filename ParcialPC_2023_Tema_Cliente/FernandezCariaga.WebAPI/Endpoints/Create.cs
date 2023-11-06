using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Create : EndpointBaseAsync
        .WithRequest<CreateRequest>
        .WithActionResult<GenericResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public Create(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpPost("api/clientes")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(CreateRequest request, CancellationToken ct = default)
        {
            var nuevoUsuario = new Cliente
            {
                CodigoCliente = request.CodigoCliente,
                Email = request.Email,
                NivelCliente = request.NivelCliente,
                RazonSocial = request.RazonSocial,
                UltimaCompraRealizada = DateTime.Now,
            };

            try
            {
                _context.Clientes.Add(nuevoUsuario);
                await _context.SaveChangesAsync();

                return new GenericResponse { Result = true };
            }
            catch
            {
                return new GenericResponse { Result = false };
            }
        }
    }
}