using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPI.Dominio.Argumentos.Airplane;
using TesteAPI.Dominio.Argumentos.Base;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Dominio.Interfaces.Services;
using TesteAPI.Infra.Persistencia.EF;
using TesteAPI.Infra.Persistencia.Repositorios;

namespace TesteAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly AirplaneContext _context;
        private readonly IServiceAirplane _serviceAirplane;

        public AirplaneController(AirplaneContext context, IServiceAirplane serviceAirplane)
        {
            _context = context;
            _serviceAirplane = serviceAirplane;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airplane>>> GetAirplanes()
        {
            try
            {
                var response = _serviceAirplane.ListarAirplane();
                return await Task.FromResult(Ok(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ActionResult<IEnumerable<Airplane>>> GetAirplane([FromRoute]Guid id)
        {
            try
            {
                var response = _serviceAirplane.ObterAirplane(id);
                return await Task.FromResult(Ok(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult<Airplane>> PostAirplanes([FromBody]AdicionarAirplaneRequest request)
        {
            try
            {
                var response = _serviceAirplane.AdicionarAirplane(request);
                return await Task.FromResult(Ok(response));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<ActionResult<Airplane>> UpdateAirplanes(
            [FromRoute]Guid id,
            [FromBody]AdicionarAirplaneRequest request)
        {
            try
            {
                if(id == null)
                {
                    return BadRequest("ID não encontrado");
                }

                var response =  _serviceAirplane.UpdateAirplane(id, request);
                return await Task.FromResult(Ok("Informações alteradas com sucesso"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<ActionResult<Airplane>> DeleteAirplanes(
            [FromRoute]Guid id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest("ID não encontrado");
                }

                var response = _serviceAirplane.ExcluirAirplane(id);
                return await Task.FromResult(Ok("Avião deletado com sucesso"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }
    }
}
