using PruebaTecnica.Datos;
using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Logica
{
    public class LogicaLogin
    {
        public LogicaLogin()
        {

        }

        public string validarInicioSesion(Usuario usuario)
        {
            OperacionesBD bd = new OperacionesBD();
            bool consulta = bd.iniciarSesion(usuario);
            if(consulta)
            {
                return "../Formularios/VistaUsuario.aspx";
            }
            else
            {
                return "Login.aspx";
            }
        }
    }
}