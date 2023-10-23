using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static FernandezCariaga.WebAPI.Endpoints.GetByName;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetByName : EndpointBaseAsync
        .WithRequest<GetRequest>
        .WithActionResult<List<UsuarioGetResponse>>
    {
        private readonly EvaluacionUsuarios _context;

        public GetByName(EvaluacionUsuarios context)
        {
            _context = context;
        }

        public class GetRequest
        {
            public string NombreUsuario { get; set; }
        }
        public class UsuarioGetResponse
        {
            public string Clave { get; set; }
            public string Email { get; set; }
            public string NombreUsuario { get; set; }
            public int TipoUsuario { get; set; }
        }

        [HttpGet("api/usuarios/{NombreUsuario}")]
        public async override Task<ActionResult<List<UsuarioGetResponse>>> HandleAsync(GetRequest request, CancellationToken ct = default)
        {
            var usuarios = await _context.Usuarios.Where(x => x.NombreUsuario == request.NombreUsuario).ToListAsync(ct);
            var usuariosEncontrados = usuarios.Select(usuarios => new UsuarioGetResponse
            {
                Clave = usuarios.NombreUsuario,
                Email = usuarios.Email,
                NombreUsuario = usuarios.NombreUsuario,
                TipoUsuario = usuarios.TipoUsuario,
            }).ToList();

            return usuariosEncontrados;
        }
    }
}
