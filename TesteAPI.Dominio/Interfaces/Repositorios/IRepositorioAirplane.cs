using System;
using System.Collections.Generic;
using System.Text;
using TesteAPI.Dominio.Entidades;

namespace TesteAPI.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioAirplane
    {
        IEnumerable<Airplane> ListarAirplane();

        Airplane ObterAirplane(Guid idAirplane);

        Airplane UpdateAirplane(Airplane airplane);

        Airplane AdicionarAirplane(Airplane airplane);

        void ExcluirAirplane(Guid IdAirplane);
    }
}
