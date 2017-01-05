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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ptrLogo.Focus();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
        }

        private void txtUsername_MouseDown(object sender, MouseEventArgs e)
        {
            txtUsername.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Nacha") && txtPassword.Text.Equals("Players"))
            {

                this.Hide();
                FrmVentanaPrincipalAdmin f = new FrmVentanaPrincipalAdmin();
                f.ShowDialog();
                this.Show();

            }
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
