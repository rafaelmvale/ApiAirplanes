using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteAPI.Dominio.Argumentos.Airplane;
using TesteAPI.Dominio.Argumentos.Base;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Dominio.Interfaces.Repositorios;
using TesteAPI.Dominio.Interfaces.Services;

namespace TesteAPI.Dominio.Services
{
    public class ServiceAirplane : IServiceAirplane
    {

        private readonly IRepositorioAirplane _repositorioAirplane;

        public ServiceAirplane(IRepositorioAirplane repositorioAirplane)
        {
            _repositorioAirplane = repositorioAirplane;
        }

        public AirplaneResponse AdicionarAirplane(AdicionarAirplaneRequest request)
        {
            Airplane airplane = new Airplane(request.Modelo, request.QtidadePassageiros, request.DataCriacao.Date);


            airplane = _repositorioAirplane.AdicionarAirplane(airplane);

            return (AirplaneResponse)airplane;

        }

    
        public Response ExcluirAirplane(Guid idAirplane)
        {
            Airplane airplane = _repositorioAirplane.ObterAirplane(idAirplane);

            if(airplane == null)
            {
                throw new Exception("Dados não encontrados");
            }

            _repositorioAirplane.ExcluirAirplane(airplane.Id);

            return new Response();
;
        }

        public IEnumerable<AirplaneResponse> ListarAirplane()
        {
            IEnumerable<Airplane> airplaneCollection = _repositorioAirplane.ListarAirplane();

            var response = airplaneCollection.ToList().Select(entidade => (AirplaneResponse)entidade);
            
            return response;
        }

        public AirplaneResponse ObterAirplane(Guid idAirplane)
        {

            Airplane airplane = _repositorioAirplane.ObterAirplane(idAirplane);

            return (AirplaneResponse)airplane;
            
        }

        public AirplaneResponse UpdateAirplane(Guid id, AdicionarAirplaneRequest request)
        {

            var response = _repositorioAirplane.ObterAirplane(id);

            response.Modelo = request.Modelo;
            response.QtidadePassageiros = request.QtidadePassageiros;
            response.DataCriacao = request.DataCriacao;


            _repositorioAirplane.UpdateAirplane(response);


            return new AirplaneResponse();

        }

       
    }
}
