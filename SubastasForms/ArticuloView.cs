using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubastasForms.Controller;
using SubastasForms.Models.Entidades;
using SubastasForms.Services;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubastasForms
{
    public partial class ArticuloView : Form
    {
        private readonly SubastadorController controller;
        public ArticuloView(SubastadorController Controller)
        {
            InitializeComponent();
            this.controller = Controller;
            controller.Hardcodear();
            ActualizarComboBox();
            //Al final ver la ruta de la imagen "default"
        }
        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Acontroller.CrearArticulo(txtNombre.Text, txtDescripcion.Text, controller.subastador);
                ActualizarComboBox();
                MensajesDeError(false);
                MessageBox.Show
                    (
                        "El artículo se creó correctamente.",
                        "Operación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MensajesDeError(true);
                lblObligatorio.Text = ex.Message;
            }
        }
        private void ActualizarComboBox()
        {
            cbxArticulos.DataSource = null;
            cbxArticulos.DataSource = controller.MostrarMisArticulos();
            cbxArticulos.DisplayMember = "Nombre"; //elijo que atributo tomar
            cbxArticulos.ValueMember = "Id";       //referencia de cada elemento
            LimpiarFormulario();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)cbxArticulos.SelectedItem;
            controller.Acontroller.ModificarArticulo
                (
                    (seleccionado.Id),
                    txtNombre.Text,
                    txtDescripcion.Text,
                    controller.subastador//cambiar subastador
                ); 
            ActualizarComboBox();
            MessageBox.Show
                (
                    "El artículo se Modificó correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)cbxArticulos.SelectedItem;
            controller.Acontroller.EliminarArticulo(seleccionado.Id);
            ActualizarComboBox();
            MessageBox.Show
               (
                    "El artículo se Eliminó correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
               );
        }
        private void cbxArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxArticulos.SelectedItem != null)
            {
                MensajesDeError(false);
                btnCrearArticulo.Visible = false;
                btnModificarArticulo.Visible = true;
                btnEliminarArticulo.Visible = true;
                btnCancelar.Visible = true;

                Articulo seleccionado = (Articulo)cbxArticulos.SelectedItem;
                if (seleccionado != null)
                {
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;  //Convert.ToString(seleccionado.Id);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            cbxArticulos.SelectedIndex = -1;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            btnCrearArticulo.Visible = true;
            btnModificarArticulo.Visible = false;
            btnEliminarArticulo.Visible = false;
            btnCancelar.Visible = false;
        }
        private void MensajesDeError(bool visible)
        {
            if (visible)
            {
                lblObligatorio.Visible = true;
                lblOpcional1.Visible = true;
            }
            if (!visible)
            {
                lblObligatorio.Visible = false;
                lblOpcional1.Visible = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//comentario de prueba
        }
    }
}
