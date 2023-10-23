using System;
using Ardalis.ApiEndpoints;
using FernandezCariaga.Entidades;
using FernandezCariaga.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static FernandezCariaga.WebAPI.Endpoints.Create;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Create : EndpointBaseAsync
        .WithRequest<CreateRequest>
        .WithActionResult<GenericResponse>
    {
        private readonly Base _context;

        public Create(Base context)
        {
            _context = context;
        }

        public class CreateRequest
        {
            public string ApellidoNombre { get; set; }
            public string CUIL { get; set; }
            public string Email { get; set; }
            public DateTime FechaIngreso { get; set; }
            public int Id { get; set; }
            public decimal Salario { get; set; }
        }

        public class GenericResponse
        {
            public bool Result { get; set; }
        }


        [HttpPost("api/docentes")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(CreateRequest request, CancellationToken ct = default)
        {
            var docenteNuevo = new Docente
            {
                ApellidoNombre = request.ApellidoNombre,
                CUIL = request.CUIL,
                Email = request.Email,
                FechaIngreso = request.FechaIngreso,
                Id = request.Id,
                Salario = request.Salario,
            };

            try
            {
                _context.Add(docenteNuevo);
                await _context.SaveChangesAsync(ct);
                return new GenericResponse { Result = true };
            }

            catch
            {
                return new GenericResponse { Result = false };
            }
        }

    }
}