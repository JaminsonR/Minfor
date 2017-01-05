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
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
        }

        private void btnEditMarca_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
        }

        private void btnEditModelo_Click(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
        }

        private void btnEditPrecioUnitario_Click(object sender, EventArgs e)
        {
            txtPrecioUnitario.Enabled = true;
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            txtStock.Enabled = true;
        }

        private void btnEditTipo_Click(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtNombres.Clear();
            txtPrecioUnitario.Clear();
            txtStock.Clear();
            txtTipo.Clear();
            

        }
    }
}
