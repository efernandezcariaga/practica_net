using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using static FernandezCariaga.WebAPI.Endpoints.Update;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Update : EndpointBaseAsync
        .WithRequest<UpdateRequest>
        .WithActionResult<UpdateResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public Update(EvaluacionUsuarios context)
        {
            _context = context;
        }

        public class UpdateRequest
        {
            public string Clave { get; set; }
            public string Email { get; set; }
            public string NombreUsuario { get; set; }
            public int TipoUsuario { get; set; }
        }

        public class UpdateResponse
        {
            public bool Success { get; set; }
        }

        [HttpPut("api/usuarios")]
        public async override Task<ActionResult<UpdateResponse>> HandleAsync(UpdateRequest request, CancellationToken ct = default)
        {
            var usuarioToUpdate = await _context.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == request.NombreUsuario);
            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.Clave = request.Clave;
                usuarioToUpdate.Email = request.Email;
                usuarioToUpdate.NombreUsuario = request.NombreUsuario;
                usuarioToUpdate.TipoUsuario = request.TipoUsuario;
                _context.Update(usuarioToUpdate);
                await _context.SaveChangesAsync();
                return new UpdateResponse { Success = true };
            }
            else
            {
                return new UpdateResponse { Success = false };
            }
        }
    }
}
