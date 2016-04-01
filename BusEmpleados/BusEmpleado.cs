using GaboLeo.Empleados.Business.Entidad;
using GaboLeo.Empleados.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboLeo.Empleados.Business
{
    public class BusEmpleado
    {
        public BusEmpleado() { }

        public List<EntEmpleado> Obtener()
        {
            DataTable dt = new DatEmpleado().Obtener();
            List<EntEmpleado> lst = new List<EntEmpleado>();
            foreach (DataRow dr in dt.Rows)
            {
                EntEmpleado ent = new EntEmpleado();
                ent.Id = Convert.ToInt32(dr["EMPL_ID"].ToString());
                ent.Nombre = dr["EMPL_NOMB"].ToString();
                ent.PuestoId = Convert.ToInt32(dr["EMPL_PUES_ID"].ToString());
                ent.Puesto.Nombre = dr["PUES_NOMB"].ToString();
                ent.DepartamentoId = Convert.ToInt32(dr["EMPL_DEPA_ID"].ToString());
                ent.Departamento.Nombre = dr["DEPA_NOMB"].ToString();
                lst.Add(ent);
            }
            return lst;
        }

        public EntEmpleado Obtener(int Id)
        {
            DataTable dt = new DatEmpleado().Obtener(Id);
            EntEmpleado ent = new EntEmpleado();
            ent.Id = Convert.ToInt32(dt.Rows[0]["EMPL_ID"].ToString());
            ent.Nombre = dt.Rows[0]["EMPL_NOMB"].ToString();
            ent.PuestoId = Convert.ToInt32(dt.Rows[0]["EMPL_PUES_ID"].ToString());
            ent.Puesto.Nombre = dt.Rows[0]["PUES_NOMB"].ToString();
            ent.DepartamentoId = Convert.ToInt32(dt.Rows[0]["EMPL_DEPA_ID"].ToString());
            ent.Departamento.Nombre = dt.Rows[0]["DEPA_NOMB"].ToString();
            return ent;
        }
        public List<EntPuesto> ObtenerPuesto()
        {
            DataTable dt = new DatEmpleado().ObtenerPuesto();
            List<EntPuesto> lst = new List<EntPuesto>();
            foreach (DataRow dr in dt.Rows)
            {
                EntPuesto ent = new EntPuesto();
                ent.Id = Convert.ToInt32(dr["PUES_ID"].ToString());
                ent.Nombre = dr["PUES_NOMB"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntDepartamento> ObtenerDepartamento()
        {
            DataTable dt = new DatEmpleado().ObtenerDepartamento();
            List<EntDepartamento> lst = new List<EntDepartamento>();
            foreach (DataRow dr in dt.Rows)
            {
                EntDepartamento ent = new EntDepartamento();
                ent.Id = Convert.ToInt32(dr["DEPA_ID"].ToString());
                ent.Nombre = dr["DEPA_NOMB"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public void Insertar(EntEmpleado ent)
        {
            int filas=new DatEmpleado().Insertar(ent.Id,ent.Nombre,ent.PuestoId,ent.DepartamentoId);
        
            if (filas != 1)
                throw new ApplicationException(string.Format("Error al insertar a {0}", ent.Nombre));
        }
    }
}
