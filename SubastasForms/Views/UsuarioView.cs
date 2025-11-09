using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubastasForms.Models.Entidades;

namespace SubastasForms.Views
{
    public partial class UsuarioView : Form
    {
        private readonly Usuario usuarioLogeado;
        public UsuarioView(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Console.WriteLine();//crear grilla modificar
        }
    }
}
