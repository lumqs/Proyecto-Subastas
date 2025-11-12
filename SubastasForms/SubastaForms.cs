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

namespace SubastasForms
{
    public partial class SubastaForms : Form
    {
        private readonly SubastadorController controller;
        public SubastaForms(SubastadorController Controller)
        {
            InitializeComponent();
            this.controller = Controller;
            controller.Hardcodear();//metodo a borrar
            ActualizarComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarComboBox()
        {
            cbxArticulos.DataSource = null;
            cbxArticulos.DataSource = controller.MostrarMisArticulos();
            cbxArticulos.DisplayMember = "Nombre"; 
            cbxArticulos.ValueMember = "Id";
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            cbxArticulos.SelectedIndex = -1;
            txtNombreArticulo.Text = "";
            txtDescripcionArticulo.Text = "";
            //numPujaInicial
            //numPujaAumento
            //numDuracion
            //dateTimePicker1
        }
        private void cbxArticulos_SelectionIndexChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)cbxArticulos.SelectedItem;
            if (seleccionado != null)
            {
                txtNombreArticulo.Text = seleccionado.Nombre;
                txtDescripcionArticulo.Text = seleccionado.Descripcion; 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //txtNombreArticulo
            //txtDescripcionArticulo
            //numPujaInicial
            //numPujaAumento
            //numDuracion
            //dateTimePicker1

        }
    }
}
