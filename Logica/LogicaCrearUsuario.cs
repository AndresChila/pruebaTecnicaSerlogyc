using PruebaTecnica.Datos;
using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Logica
{
    public class LogicaCrearUsuario
    {
        OperacionesBD bd = new OperacionesBD();
        List<EstadoCivil> listaEstadoCivil = new List<EstadoCivil>();
        List<Identificacion> listaTiposIdentificacion = new List<Identificacion>();

        public LogicaCrearUsuario()
        {

        }
        public List<Identificacion> traerTiposIdentificacion()
        {
            return bd.consultarIdentificacion();
        }
        public List<EstadoCivil> traerEstadoCivil()
        {
            return bd.consultarEstadoCivil();
        }
        public string crearUsuario(string tipoIdentificacion, string cedula, string nombre, string apellido, string fechaNacimiento, string estadoCivil, string contraseña)
        {
            if(cedula == "" || nombre == "" || apellido == "" || fechaNacimiento == ""|| contraseña == "")
            {
                return "Debe llenar todos los campos";
            }
            if(tipoIdentificacion == "Seleccione")
            {
                return "Debe seleccionar un tipo de identificación";
            }
            if(estadoCivil == "Seleccione")
            {
                return "Debe seleccionar un estado civil";
            }
            Usuario usuario = new Usuario();
            listaTiposIdentificacion = traerTiposIdentificacion();
            listaEstadoCivil = traerEstadoCivil();

            foreach (Identificacion id in listaTiposIdentificacion)
            {
                if (tipoIdentificacion == id.NombreIdentificacion)
                {
                    usuario.Identificacion = id.Id;
                }
            }
            foreach (EstadoCivil estado in listaEstadoCivil)
            {
                if (estadoCivil == estado.NombreEstadoCivil)
                {
                    usuario.EstadoCivil = estado.Id;
                }
            }
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Cedula = cedula;
            usuario.FechaNacimiento = DateTime.Parse(fechaNacimiento);
            usuario.Clave = contraseña;

            bool crea = bd.crearUsuario(usuario);
            if (crea)
            {
                return "Usuario creado correctamente";
            }
            else
            {
                return "este usuario ya existe";
            }
        }
    }
}