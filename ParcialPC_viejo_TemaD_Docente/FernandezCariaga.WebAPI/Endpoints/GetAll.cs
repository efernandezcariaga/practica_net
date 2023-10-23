using System;
using Ardalis.ApiEndpoints;
using FernandezCariaga.Entidades;
using FernandezCariaga.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static FernandezCariaga.WebAPI.Endpoints.GetAll;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class GetAll : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<DocenteResponse>>
    {
        private readonly Base _context;

        public GetAll(Base context)
        {
            _context = context;
        }

        public class DocenteResponse
        {
            public string ApellidoNombre { get; set; }
            public string CUIL { get; set; }
            public string Email { get; set; }
            public DateTime FechaIngreso { get; set; }
            public int Id { get; set; }
            public decimal Salario { get; set; }
        }

        [HttpGet("api/docentes")]
        public async override Task<ActionResult<List<DocenteResponse>>> HandleAsync(CancellationToken ct = default)
        {
            var docentes = await _context.Docentes.ToListAsync();
            var docentesEncontrados = docentes.Select(docentes => new DocenteResponse
            {
                ApellidoNombre = docentes.ApellidoNombre,
                CUIL = docentes.CUIL,
                Email = docentes.Email,
                FechaIngreso = docentes.FechaIngreso,
                Id = docentes.Id,
                Salario = docentes.Salario,
            }).ToList();

            return docentesEncontrados;

        }

    }
}