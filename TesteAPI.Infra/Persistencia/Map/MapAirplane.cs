using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAPI.Dominio.Entidades;

namespace TesteAPI.Infra.Persistencia.Map
{
    public class MapAirplane : IEntityTypeConfiguration<Airplane>
    {
        public void Configure(EntityTypeBuilder<Airplane> builder)
        {
            builder.ToTable("Airplane");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Modelo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.QtidadePassageiros).HasMaxLength(10).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();
        }
    }
}
