using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class frm_mantenimiento_departamento : Form
    {   
        public frm_mantenimiento_departamento()
        {
            InitializeComponent();
            this.navegador1.config("tbl_departamento", this, "");
        }

        public void llenar()
        {
            // DataTable dt = ctrl.llenartabla(tabla);
            // dataGridView1.DataSource = dt;
        }


    }
}
