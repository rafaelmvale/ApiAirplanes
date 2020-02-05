using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Dominio.Interfaces.Repositorios;
using TesteAPI.Infra.Persistencia.EF;

namespace TesteAPI.Infra.Persistencia.Repositorios
{
    public class RepositorioAirplane : IRepositorioAirplane
    {
        private readonly AirplaneContext _airplaneContext;

        public RepositorioAirplane(AirplaneContext airplaneContext)
        {
            
            _airplaneContext = airplaneContext;
        }

        public Airplane AdicionarAirplane(Airplane airplane)
        {
            _airplaneContext.Airplanes.Add(airplane);
            _airplaneContext.SaveChanges();

            return airplane;
        }

        public void ExcluirAirplane(Guid Id)
        {
            var response = _airplaneContext.Airplanes.First(c => c.Id == Id);

            _airplaneContext.Airplanes.Remove(response);
            _airplaneContext.SaveChanges();
        }

        public IEnumerable<Airplane> ListarAirplane()
        {
            return _airplaneContext.Airplanes.ToList(); ;
        }

        public Airplane ObterAirplane(Guid idAirplane)
        {
            return _airplaneContext.Airplanes.FirstOrDefault(x => x.Id == idAirplane);
        }

        public Airplane UpdateAirplane(Airplane airplane)
        {

                _airplaneContext.SaveChanges();


            return airplane;


        }
    }
}
