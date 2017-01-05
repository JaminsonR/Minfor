using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinforFrontEnd
{
    public partial class FrmModificarEmpleado : Form
    {
        public FrmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btnEditApellidos_Click(object sender, EventArgs e)
        {
            txtApellidos.Enabled = true;
            txtApellidos.ReadOnly = false;
            
        }

        private void btnEditNombres_Click(object sender, EventArgs e)
        {
            txtNombres.Enabled = true;
            txtNombres.ReadOnly = false;
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditMail_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtEmail.ReadOnly = false;
        }

        private void btnEditDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtDireccion.ReadOnly = false;
        }

        private void btnEditRuc_Click(object sender, EventArgs e)
        {
            txtRUC.Enabled = true;
            txtRUC.ReadOnly = false;
        }

        private void btnEditFechaInicio_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Enabled = true;
            
        }

        private void btnEditTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Enabled = true;
            txtTelefono.ReadOnly = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEditCargo_Click(object sender, EventArgs e)
        {
            cbbCargo.Enabled = true;
        }
    }
}
