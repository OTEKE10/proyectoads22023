using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNomina;
using CapaVistaNomina;

namespace CapaVistaNomina
{
    public partial class frm_mantenimiento_empleado : Form
    {
        Controlador ctrl = new Controlador();
        
        string tabla = "tbl_departamento";
        public frm_mantenimiento_empleado()
        {
            InitializeComponent();
            this.navegador1.config("tbl_empleado", this, "");
           
             llenar();
           
        }
        public void llenar()
        {
           DataTable dt = ctrl.llenartabla(tabla);
           dataDepa.DataSource = dt;
        }
            private void btn_buscar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
