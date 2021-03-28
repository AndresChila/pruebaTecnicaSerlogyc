using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Datos
{
    public class MapeoIdentificacion : DbContext
    {
        public DbSet<Identificacion> identificacion { get; set; }

        public MapeoIdentificacion() : base("name = conexion")
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}