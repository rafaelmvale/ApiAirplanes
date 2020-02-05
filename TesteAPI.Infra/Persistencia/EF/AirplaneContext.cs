using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Infra.Persistencia.Map;
using TesteAPI.Shared;

namespace TesteAPI.Infra.Persistencia.EF
{
    public class AirplaneContext: DbContext
    {
        public DbSet<Airplane>  Airplanes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MapAirplane());

            base.OnModelCreating(modelBuilder);
        }
    }
}
