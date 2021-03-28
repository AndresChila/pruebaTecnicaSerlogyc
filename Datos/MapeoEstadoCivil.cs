using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Datos
{
    public class MapeoEstadoCivil :DbContext
    {
        public DbSet<EstadoCivil> estadoCivil { get; set; }

        public MapeoEstadoCivil() : base("name = conexion")
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}