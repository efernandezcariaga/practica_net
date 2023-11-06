using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<GenericResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public Delete(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpDelete("api/clientes/{id}")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(Guid id, CancellationToken ct = default)
        {
            var clienteEncontrado = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
            var resultado = new GenericResponse
            {
                Result = false,
            };
            if(clienteEncontrado != null)
            {
                _context.Clientes.Remove(clienteEncontrado);
                await _context.SaveChangesAsync(ct);
                resultado.Result = true;
            }
            return resultado;
        }
    }
}