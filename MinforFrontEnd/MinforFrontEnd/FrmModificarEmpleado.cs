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
        }
    }
}
