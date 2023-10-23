using System;
using Ardalis.ApiEndpoints;
using FernandezCariaga.Entidades;
using FernandezCariaga.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static FernandezCariaga.WebAPI.Endpoints.GetOne;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetOne : EndpointBaseAsync
        .WithRequest<Request>
        .WithActionResult<Response>
    {
        private readonly Base _context;

        public GetOne(Base context)
        {
            _context = context;
        }

        public class Request
        {
            public string CUIL { get; set; }
        }

        public class Response
        {
            public string ApellidoNombre { get; set; }
            public string CUIL { get; set; }
            public string Email { get; set; }
            public DateTime FechaIngreso { get; set; }
            public int Id { get; set; }
            public decimal Salario { get; set; }
        }

        [HttpGet("api/docentes/{CUIL}")]
        public async override Task<ActionResult<Response>> HandleAsync(Request request, CancellationToken ct = default)
        {
            var docenteBuscado = await _context.Docentes.FirstOrDefaultAsync(x => x.CUIL == request.CUIL);

            if (docenteBuscado != null)
            {
                var docenteEncontrado = new Response
                {
                    ApellidoNombre = docenteBuscado.ApellidoNombre,
                    CUIL = docenteBuscado.CUIL,
                    Email = docenteBuscado.Email,
                    FechaIngreso = docenteBuscado.FechaIngreso,
                    Id = docenteBuscado.Id,
                    Salario = docenteBuscado.Salario,
                };

                return docenteEncontrado;
            }
            else
            {
                return NotFound();
            }
        }
    }
}