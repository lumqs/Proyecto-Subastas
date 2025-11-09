using SubastasForms.Controller;
using SubastasForms.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SubastasForms.Views
{
    public partial class GrillaPrueba : Form
    {
        private readonly UsuarioController controller;
        public GrillaPrueba()
        {
            controller = new UsuarioController();
            InitializeComponent();
            Actualizar();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario f2 = new CrearUsuario(controller);
            f2.ShowDialog(); // abre sin bloquear el form actual
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Usuario c = dataGridView1.CurrentRow.DataBoundItem as Usuario;
            if (c == null) return;
            c.Nombre.ToString();
            c.Email.ToString();
            c.Password.ToString();
        }
        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = controller.ObtenerUsuario();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarios;
        }
        private void Actualizar()
        {
            List<Usuario> usuarios = controller.ObtenerUsuario();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarios;
        }

    }
}
