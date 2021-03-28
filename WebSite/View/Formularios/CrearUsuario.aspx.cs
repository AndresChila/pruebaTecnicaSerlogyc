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
    public partial class CrearUsuario : System.Web.UI.Page
    {
        LogicaCrearUsuario logica = new LogicaCrearUsuario();
        List<EstadoCivil> listaEstadoCivil = new List<EstadoCivil>();
        List<Identificacion> listaTiposIdentificacion = new List<Identificacion>();

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Seleccione");
            listaTiposIdentificacion = logica.traerTiposIdentificacion();
            for(int i =0; i<listaTiposIdentificacion.Count; i++)
            {
                DropDownList1.Items.Add(listaTiposIdentificacion.ElementAt(i).NombreIdentificacion);
            }
            DropDownList2.Items.Add("Seleccione");
            listaEstadoCivil = logica.traerEstadoCivil();
            foreach(EstadoCivil estadoCivil in listaEstadoCivil)
            {
                DropDownList2.Items.Add(estadoCivil.NombreEstadoCivil);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            string mensaje = logica.crearUsuario(DropDownList1.SelectedValue.ToString(), TBNumeroId.Text, TBNombre.Text, TBApellido.Text, TBFechaNacimiento.Text, DropDownList2.SelectedValue.ToString(), TBContraseña.Text);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + mensaje + "')", true);

            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            TBNombre.Text = "";
            TBApellido.Text = "";
            TBFechaNacimiento.Text = "";
            TBContraseña.Text = "";
            TBNumeroId.Text = "";
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }
    }
}