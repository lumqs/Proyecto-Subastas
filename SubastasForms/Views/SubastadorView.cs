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
    public partial class SubastadorView : Form
    {
        private readonly SubastadorController controller;
        public SubastadorView()
        {
            InitializeComponent();
            controller = new SubastadorController();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            using (var articuloView = new ArticuloView(controller))
            {
                articuloView.ShowDialog();
            }
        }

        
        void btnCrearSubasta_Click(object sender, EventArgs e)
        {
           // if (controller.MostrarMisArticulos()   );
           using (var subastaView = new SubastaForms(controller))
            {
                subastaView.ShowDialog();
            }
        }
    }
}
