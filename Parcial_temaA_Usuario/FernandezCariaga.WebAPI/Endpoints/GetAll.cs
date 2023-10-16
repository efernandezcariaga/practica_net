using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using FernandezCariaga.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetAll : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<UsuarioResponse>>
    {
        private readonly Base _context;

        public GetAll(Base context)
        {
            _context = context;
        }

        [HttpGet("api/usuarios")]
        public async override Task<ActionResult<List<UsuarioResponse>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            var usuariosResponse = usuarios.Select(usuario => new UsuarioResponse
            {
                id = usuario.id,
                Clave = usuario.Clave,
                Email = usuario.Email,
                NombreUsuario = usuario.NombreUsuario,
                TipoUsuario = usuario.TipoUsuario,
                UltimoIngreso = usuario.UltimoIngreso,
            }).ToList();

            return usuariosResponse;
        }
    }
}
