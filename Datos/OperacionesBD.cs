using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Datos
{
    public class OperacionesBD
    {
        public OperacionesBD()
        {

        }
        public bool crearUsuario(Usuario usuario)
        {
            using(var db = new MapeoUsuario())
            {
                int resultado = db.usuarios.Where(x => x.Cedula == usuario.Cedula).Count();
                if(resultado == 0)
                {
                    db.usuarios.Add(usuario);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool iniciarSesion(Usuario usuario)
        {
            using(var db = new MapeoUsuario())
            {
                int consulta = db.usuarios.Where(x => x.Cedula == usuario.Cedula && x.Clave == usuario.Clave).Count();
                if (consulta == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Usuario mostrarDatos(Usuario usuario)
        {
            try
            {
                using (var db = new MapeoUsuario())
                {
                    return db.usuarios.First(x => x.Cedula == usuario.Cedula);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool crearEstadoCivil(EstadoCivil estadoCivil)
        {
            using (var db = new MapeoEstadoCivil())
            {
                int resultado = db.estadoCivil.Where(x => x.Id == estadoCivil.Id).Count();
                if (resultado == 0)
                {
                    db.estadoCivil.Add(estadoCivil);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<EstadoCivil> consultarEstadoCivil()
        {
            using(var db = new MapeoEstadoCivil())
            {
                return db.estadoCivil.ToList();
            }
        }

        public bool crearIdentificacion(Identificacion identificacion)
        {
            using (var db = new MapeoIdentificacion())
            {
                int resultado = db.identificacion.Where(x => x.Id == identificacion.Id).Count();
                if (resultado == 0)
                {
                    db.identificacion.Add(identificacion);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<Identificacion> consultarIdentificacion()
        {
            using (var db = new MapeoIdentificacion())
            {
                return db.identificacion.ToList();
            }
        }
    }
}