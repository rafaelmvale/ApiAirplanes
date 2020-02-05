using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAPI.Dominio.Argumentos.Airplane
{
    public class AdicionarAirplaneRequest
    {
        public string Modelo { get; set; }
        public string QtidadePassageiros { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
