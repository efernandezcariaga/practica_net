using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using FernandezCariaga.Entidades;
using FernandezCariaga.Models;
using FernandezCariaga.Models.Responses;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Create : EndpointBaseAsync
        .WithRequest<CreateRequest>
        .WithActionResult<GenericResponse>
    {
        private readonly Base _context;

        public Create(Base context)
        {
            _context = context;
        }

        [HttpPost("api/usuarios")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(CreateRequest request, CancellationToken cancellationToken = default)
        {
            var nuevoUsuario = new Usuario
            {
                Clave = request.Clave,
                Email = request.Email,
                NombreUsuario = request.NombreUsuario,
                TipoUsuario = request.TipoUsuario,
            };

            try
            {
                _context.Usuarios.Add(nuevoUsuario);
                await _context.SaveChangesAsync(cancellationToken);

                return new GenericResponse { Result = true };
            }
            catch
            {
                return new GenericResponse { Result = false };
            }

        }

    }
}
