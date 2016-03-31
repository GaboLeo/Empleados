using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboLeo.Empleados.Business.Entidad
{
    public class EntEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        private EntPuesto puesto;

        public EntPuesto Puesto 
        {
            get 
            {
                if (puesto == null)
                    puesto = new EntPuesto();
                return puesto; 
            }
            set 
            { if (puesto==null)
                puesto = new EntPuesto();
                puesto = value; 
            }
        }

        private EntDepartamento departamento;
        public EntDepartamento Departamento
        {
            get
            {
                if (departamento == null)
                    departamento = new EntDepartamento();
                return departamento;
            }
            set
            {
                if (departamento == null)
                    departamento = new EntDepartamento();
                departamento = value;
            }
        }
        

        

    }
    public class EntPuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }
    public class EntDepartamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

