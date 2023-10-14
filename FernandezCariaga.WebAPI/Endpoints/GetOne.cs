using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using FernandezCariaga.Models.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FernandezCariaga.Entidades;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetOne : EndpointBaseAsync
        .WithRequest<string>
        .WithActionResult<UsuarioResponse>
    {
        private readonly Base _context;

        public GetOne(Base context)
        {
            _context = context;
        }

        [HttpGet("api/usuarios/{NombreUsuario}")]
        public async override Task<ActionResult<UsuarioResponse>> HandleAsync(string nombreUsuario, CancellationToken ct = default)
        {
            var usuarioBuscado = await _context.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == nombreUsuario, ct);

            if (usuarioBuscado != null)
            {
                var usuarioResponse = new UsuarioResponse
                {
                    id = usuarioBuscado.id,
                    Clave = usuarioBuscado.Clave,
                    Email = usuarioBuscado.Email,
                    NombreUsuario = usuarioBuscado.NombreUsuario,
                    TipoUsuario = usuarioBuscado.TipoUsuario,
                    UltimoIngreso = usuarioBuscado.UltimoIngreso,
                };
                return usuarioResponse;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
