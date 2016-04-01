using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboLeo.Empleados.Data
{
    public class DatEmpleado : DatAbstracta
    {
        public DataTable Obtener()
        {
            SqlCommand com = new SqlCommand("spObtenerEmpleados", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Obtener(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerEmpleadosId", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { ParameterName = "@EMPL_ID", Value = Id, SqlDbType = SqlDbType.Int });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerPuesto()
        {
            SqlCommand com = new SqlCommand("spCatalogoPuestos", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);
        }
        public DataTable ObtenerDepartamento()
        {
            SqlCommand com = new SqlCommand("spCatalogoDepartamentos", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public int Insertar(int Id, string Nombre, int Puesto, int Departamento)
        {
            SqlCommand com = new SqlCommand("spInsertarEmpleados", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter { ParameterName = "@EMPL_ID", Value = Id, SqlDbType = SqlDbType.Int });
            com.Parameters.Add(new SqlParameter { ParameterName="@EMPL_NOMB",Value=Nombre, SqlDbType=SqlDbType.VarChar});
            com.Parameters.Add(new SqlParameter { ParameterName = "@EMPL_PUES_ID", Value = Puesto, SqlDbType = SqlDbType.Int });
            com.Parameters.Add(new SqlParameter { ParameterName = "@EMPL_DEPA_ID", Value = Departamento, SqlDbType = SqlDbType.Int });
            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery(); //respuesta de ejecucion del query en la BD
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error en la capa de datos, " + ex.Message);
            }
        }
    }
}
