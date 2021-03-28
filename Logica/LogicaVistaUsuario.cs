using PruebaTecnica.Datos;
using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Logica
{
    public class LogicaVistaUsuario
    {
        OperacionesBD bd = new OperacionesBD();
        public LogicaVistaUsuario()
        {

        }
        public Usuario traerDatos(Usuario usuario)
        {
            List<EstadoCivil> listaEstadoCivil = bd.consultarEstadoCivil();
            Usuario user = bd.mostrarDatos(usuario);
            return user;
        }
        public string traerTipoIdentificacion(Usuario user)
        {
            List<Identificacion> listaIdentificacion = bd.consultarIdentificacion();
            foreach (Identificacion id in listaIdentificacion)
            {
                if (user.Identificacion == id.Id)
                {
                    return id.NombreIdentificacion;
                }
            }
            return "";
        }
        public string traerEstadoCivil(Usuario user)
        {
            List<EstadoCivil> listaEstadoCivil = bd.consultarEstadoCivil();
            foreach (EstadoCivil estado in listaEstadoCivil)
            {
                if (user.EstadoCivil == estado.Id)
                {
                    return estado.NombreEstadoCivil;
                }
            }
            return "";
        }

    }
}