using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static FernandezCariaga.WebAPI.Endpoints.GetAll;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetAll : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<UsuarioResponse>>
    {
        private readonly EvaluacionUsuarios _context;

        public GetAll(EvaluacionUsuarios context)
        {
            _context = context;
        }

        public class UsuarioResponse
        {
            public string Clave { get; set; }
            public string Email { get; set; }
            public string NombreUsuario { get; set; }
            public int TipoUsuario { get; set; }
        }

        [HttpGet("api/usuarios")]
        public async override Task<ActionResult<List<UsuarioResponse>>> HandleAsync(CancellationToken ct = default)
        {
            var usuariosExistentes = await _context.Usuarios.ToListAsync();
            var usuariosEncontrados = usuariosExistentes.Select(usuariosExistentes => new UsuarioResponse
            {
                Clave = usuariosExistentes.Clave,
                Email = usuariosExistentes.Email,
                NombreUsuario = usuariosExistentes.NombreUsuario,
                TipoUsuario = usuariosExistentes.TipoUsuario,
            }).ToList();

            return usuariosEncontrados;
        }
    }
}
