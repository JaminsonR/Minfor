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
    public partial class FrmVentanaPrincipalAdmin : Form
    {
        public FrmVentanaPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVentanaPrincipalAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            navegarSgtVentana(new FrmIngresoCliente());
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            
            navegarSgtVentana(new FrmModificarCliente());
        }
        private void navegarSgtVentana(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmEliminarCliente());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmInventario());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmAgregarArticulo());
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmEliminarArticulo());
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmIngresarEmpleado());
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmModificarEmpleado());
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmEliminarEmpleado());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmGenerarFactura());
        }

        private void btnModificarInventario_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmModificarProducto());
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmMostrarVentas());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmIngresoNuevoCargo());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmModificarCargo());
        }

        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            navegarSgtVentana(new FrmEliminarCargo());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
