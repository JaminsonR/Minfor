using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinforFrontEnd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FrmAgregarArticulo());
            Application.Run(new FrmEliminarArticulo());
            Application.Run(new FrmEliminarCargo());
            Application.Run(new FrmEliminarCliente());
            Application.Run(new FrmEliminarEmpleado());
            Application.Run(new FrmGenerarFactura());
            Application.Run(new FrmIngresarEmpleado());
            Application.Run(new FrmIngresoCliente());
            Application.Run(new FrmIngresoNuevoCargo());
            Application.Run(new FrmInventario());
            Application.Run(new FrmLogin());
            Application.Run(new FrmModificarCargo());
            Application.Run(new FrmModificarCliente());
            Application.Run(new FrmModificarEmpleado());
            Application.Run(new FrmModificarProducto());
            Application.Run(new FrmMostrarVentas());
            Application.Run(new FrmVentanaPrincipalAdmin());
            
        }
    }
}
