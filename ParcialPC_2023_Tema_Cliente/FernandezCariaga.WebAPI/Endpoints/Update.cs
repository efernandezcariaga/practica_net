using Ardalis.ApiEndpoints;
using FernandezCariaga.Contexto;
using FernandezCariaga.Entidades;
using FernandezCariaga.Modelos.Requests;
using FernandezCariaga.Modelos.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FernandezCariaga.WebAPI.Endpoints
{
    public class Update : EndpointBaseAsync
        .WithRequest<UpdateRequest>
        .WithActionResult<GenericResponse>
    {
        private readonly EvaluacionUsuarios _context;

        public Update(EvaluacionUsuarios context)
        {
            _context = context;
        }

        [HttpPut("api/clientes")]
        public async override Task<ActionResult<GenericResponse>> HandleAsync(UpdateRequest request, CancellationToken ct = default)
        {
            var clienteToUpdate = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == request.Id);
            var resultado = new GenericResponse { Result = false };
            if(clienteToUpdate != null)
            {
                clienteToUpdate.CodigoCliente = request.CodigoCliente;
                clienteToUpdate.Email = request.Email;
                clienteToUpdate.NivelCliente = request.NivelCliente;
                clienteToUpdate.RazonSocial = request.RazonSocial;

                _context.Update(clienteToUpdate); //Puede no ir

                await _context.SaveChangesAsync(ct);
                resultado.Result = true;
            }
            return resultado;
        }
    }
}