using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using static FernandezCariaga.WebAPI.Endpoints.Delete;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Delete : EndpointBaseAsync
        .WithRequest<string>
        .WithActionResult<DeleteResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public Delete(EvaluacionUsuarios context)
        {
            _context = context;
        }

        public class DeleteResponse
        {
            public bool Success { get; set; }
        }

        [HttpDelete("api/usuarios/{NombreUsuario}")]
        public async override Task<ActionResult<DeleteResponse>> HandleAsync(string NombreUsuario, CancellationToken ct = default)
        {
            var usuarioEncontrado = await _context.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == NombreUsuario);
            if (usuarioEncontrado != null)
            {
                _context.Usuarios.Remove(usuarioEncontrado);
                await _context.SaveChangesAsync();
                return new DeleteResponse { Success = true };
            }
            else { return new DeleteResponse { Success = false };}
        }
    }
}
