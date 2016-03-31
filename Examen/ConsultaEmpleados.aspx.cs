using GaboLeo.Empleados.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConsultaEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarGrid();
            CargarDepartamentos();
            CargarPuestos();
        }
    }

    private void CargarDepartamentos()
    {
        ddlDepartamentos.DataSource = new BusEmpleado().ObtenerDepartamento();
        ddlDepartamentos.DataTextField = Nombre;
    }
    private void CargarGrid()
    {
        try
        {
            gvEmpleados.DataSource = new BusEmpleado().Obtener();
            gvEmpleados.DataBind();
        }
        catch (Exception ex)
        {
            MostrarMensaje(ex.Message);
        }
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {
            MostrarMensaje(ex.Message);
        }
    }
    private void MostrarMensaje(string p)
    {
        string mensaje = "Error: " + p;
        ScriptManager.RegisterStartupScript(this, GetType(), "", mensaje, true);
    }
}