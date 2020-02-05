using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAPI.Dominio.Argumentos.Airplane
{
    public class AirplaneResponse
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string QtidadePassageiros { get; set; }
        public DateTime DataCriacao { get; set; }

        public static explicit operator AirplaneResponse(Entidades.Airplane entidade)
        {
            return new AirplaneResponse()
            {
                Id = entidade.Id,
                Modelo = entidade.Modelo,
                QtidadePassageiros = entidade.QtidadePassageiros,
                DataCriacao = entidade.DataCriacao,

            };

        }
    }
}
