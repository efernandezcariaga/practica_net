using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using FernandezCariaga.Entidades;
using FernandezCariaga.Models;
using FernandezCariaga.Models.Responses;
using Microsoft.EntityFrameworkCore;
using FernandezCariaga.Models.Requests;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Update : EndpointBaseAsync
        .WithRequest<UpdateRequest>
        .WithActionResult<GenericResponse>
    {
        private readonly Base _context;

        public Update(Base context)
        {
            _context = context;
        }

        [HttpPut("api/usuarios")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(UpdateRequest request, CancellationToken cancellationToken = default)
        {
            var usuarioToUpdate = await _context.Usuarios.FirstOrDefaultAsync(x => x.id == request.id);
            var resultado = new GenericResponse { Result = false };
            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.Clave = request.Clave;
                usuarioToUpdate.Email = request.Email;
                usuarioToUpdate.NombreUsuario = request.NombreUsuario;
                usuarioToUpdate.TipoUsuario = request.TipoUsuario;
                _context.Update(usuarioToUpdate);
                await _context.SaveChangesAsync(cancellationToken);
                resultado.Result = true;
            }
            return resultado;
        }
    }
}
