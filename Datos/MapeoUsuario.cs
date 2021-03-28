using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace PruebaTecnica.Datos
{
    public class MapeoUsuario : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }

        public MapeoUsuario() : base ("name = conexion")
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}