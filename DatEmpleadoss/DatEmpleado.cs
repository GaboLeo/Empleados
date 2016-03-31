using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboLeo.Empleados.Data
{
    public class DatEmpleado:DatAbstracta
    {
        public DataTable Obtener()
        {
            SqlCommand com = new SqlCommand("spObtenerEmpleados", con);
            com.CommandType=CommandType.StoredProcedure;
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
            com.Parameters.Add(new SqlParameter(){ParameterName="@EMPL_ID", Value=Id, SqlDbType=SqlDbType.Int});
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
            
        }

        public DataTable ObtenerPuesto()
        {
            SqlCommand com = new SqlCommand("spCatalogoPuestos",con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return(dt);
        }
        public DataTable ObtenerDepartamento()
        {
            SqlCommand com= new SqlCommand("spCatalogoDepartamentos",con)
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt= new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
