using PruebaTecnica.Datos;
using PruebaTecnica.Logica;
using PruebaTecnica.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTecnica.WebSite.View.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Formularios/CrearUsuario.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(TextBox1.Text, TextBox2.Text);
            LogicaLogin logica = new LogicaLogin();
            Session["UsuarioLogueado"] = usuario;
            Response.Redirect(logica.validarInicioSesion(usuario));
        }
    }
}