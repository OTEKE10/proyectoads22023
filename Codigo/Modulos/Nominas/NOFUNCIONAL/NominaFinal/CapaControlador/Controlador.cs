using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloNomina;
using System.Data.Odbc;
using System.Data;


namespace CapaControladorNomina
{
    public class Controlador
    {
        public Sentencias sn;
       
        public Controlador()
        {
            sn = new Sentencias();
        }

        public DataTable llenartabla(string tabla)
        {
            OdbcDataAdapter dt = sn.llenartabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }

        public Empleado BuscarEmpleadoPorID(int id)
        {
            Empleado empleado = sn.BuscarEmpleadoPorID(id);
            return empleado;
        }

    }
}
