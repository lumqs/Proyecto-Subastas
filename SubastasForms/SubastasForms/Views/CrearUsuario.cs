using SubastasForms.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasForms.Views
{
    public partial class CrearUsuario : Form
    {
        private readonly UsuarioController controller;
        public CrearUsuario(UsuarioController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (VerificarContraseña())
            {
                bool ok = controller.AgregarUsuario(txtNombre.Text, txtEmail.Text, txtPass1.Text);
                if (!ok) MessageBox.Show("Ya existe un cliente con ese email.");
                this.Close();
            }
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        public bool VerificarContraseña()
        {
            if (txtPass1.Text == txtPass2.Text) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = !txtPass1.UseSystemPasswordChar;
        }

        private void btnPass2Visible_Click(object sender, EventArgs e)
        {
            txtPass2.UseSystemPasswordChar = !txtPass2.UseSystemPasswordChar;
        }
    }
}
