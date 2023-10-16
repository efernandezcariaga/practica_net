using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using FernandezCariaga.Entidades;
using FernandezCariaga.Models;
using FernandezCariaga.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<GenericResponse>
    {
        private readonly Base _context;

        public Delete(Base context)
        {
            _context = context;
        }

        [HttpDelete("api/usuarios/{id}")]
        public override async Task<ActionResult<GenericResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuarioEncontrado = await _context.Usuarios.FirstOrDefaultAsync(x => x.id == id);
            var resultado = new GenericResponse
            {
                Result = false,
            };
            if (usuarioEncontrado != null)
            {
                _context.Usuarios.Remove(usuarioEncontrado);
                await _context.SaveChangesAsync(cancellationToken);
                resultado.Result = true;
            }
            return resultado;
        }
    }
}
