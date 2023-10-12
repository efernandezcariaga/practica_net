using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using FernandezCariaga.Context;
using System.Web.Http.Results;
using FernandezCariaga.Entidades;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Create : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult
    {
        private readonly Base _context;

        public Create(Base context)
        {
            _context = context;
        }

        [HttpPost("api/usuarios")]
        public async override Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default)
        {
            var nuevoUsuario = new Usuario
            {
                Clave = 
            };
        }

    }
}
