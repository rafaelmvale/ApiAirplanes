using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAPI.Dominio.Entidades
{
    public class Airplane
    {
        public Airplane( string modelo, string qtidadePassageiros, DateTime dataCriacao)
        {
            Modelo = modelo;
            QtidadePassageiros = qtidadePassageiros;
            DataCriacao = dataCriacao;
        }

        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string QtidadePassageiros { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
