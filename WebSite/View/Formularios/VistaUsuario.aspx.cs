using PruebaTecnica.Logica;
using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTecnica.WebSite.View.Formularios
{
    public partial class VistaUsuario : System.Web.UI.Page
    {
        LogicaVistaUsuario logica = new LogicaVistaUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["UsuarioLogueado"];
            Usuario datos = logica.traerDatos(usuario);

            LTipoDocumento.Text = logica.traerTipoIdentificacion(datos);
            LIdentificacion.Text = datos.Cedula;
            LNombre.Text = datos.Nombre;
            LApellido.Text = datos.Apellido;
            LFechaNacimiento.Text = datos.FechaNacimiento.ToString();
            LEstadoCivil.Text =logica.traerEstadoCivil(datos);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }
    }
}