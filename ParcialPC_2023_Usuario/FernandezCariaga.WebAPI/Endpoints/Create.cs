using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using static FernandezCariaga.WebAPI.Endpoints.Create;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using System.Threading;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Create : EndpointBaseAsync
        .WithRequest<Request>
        .WithActionResult<Response>
    {
        private readonly EvaluacionUsuarios _context;

        public Create(EvaluacionUsuarios context)
        {
            _context = context;
        }

        public class Request
        {
            public string Clave { get; set; }
            public string Email { get; set; }
            public string NombreUsuario { get; set; }
            public int TipoUsuario { get; set; }
            public DateTime UltimoIngreso { get; set; }
        }

        public class Response
        {
            public bool Success { get; set; }
        }

        [HttpPost("api/usuarios")]
        public async override Task<ActionResult<Response>> HandleAsync(Request request, CancellationToken ct = default)
        {
            var nuevoUsuario = new Usuario
            {
                Clave = request.Clave,
                Email = request.Email,
                NombreUsuario = request.NombreUsuario,
                TipoUsuario = request.TipoUsuario,
                UltimoIngreso = DateTime.Now,
            };
            try
            {
                _context.Usuarios.Add(nuevoUsuario);
                await _context.SaveChangesAsync(ct);
                return new Response { Success = true };
            }
            catch
            {
                return new Response { Success = false };

            }
        }
    }
}
