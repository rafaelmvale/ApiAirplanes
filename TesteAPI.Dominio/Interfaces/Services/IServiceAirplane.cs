using System;
using System.Collections.Generic;
using System.Text;
using TesteAPI.Dominio.Argumentos.Airplane;
using TesteAPI.Dominio.Argumentos.Base;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Dominio.Interfaces.Services.Base;

namespace TesteAPI.Dominio.Interfaces.Services
{
    public interface IServiceAirplane : IServiceBase
    {
        IEnumerable<AirplaneResponse> ListarAirplane();

        AirplaneResponse ObterAirplane(Guid idAirplane);

        AirplaneResponse UpdateAirplane(Guid id,AdicionarAirplaneRequest request);

        AirplaneResponse AdicionarAirplane(AdicionarAirplaneRequest request);

        Response ExcluirAirplane(Guid idAirplane);


    }
}
