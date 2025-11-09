namespace SubastasForms
{
    partial class ArticuloView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnCrearArticulo = new Button();
            lblObligatorio = new Label();
            lblOpcional1 = new Label();
            btnEliminarArticulo = new Button();
            cbxArticulos = new ComboBox();
            label1 = new Label();
            btnModificarArticulo = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(196, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Del Articulo";
            txtNombre.Size = new Size(372, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.ImeMode = ImeMode.NoControl;
            txtDescripcion.Location = new Point(196, 158);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(372, 119);
            txtDescripcion.TabIndex = 2;
            // 
            // btnCrearArticulo
            // 
            btnCrearArticulo.BackColor = SystemColors.ScrollBar;
            btnCrearArticulo.Location = new Point(12, 57);
            btnCrearArticulo.Name = "btnCrearArticulo";
            btnCrearArticulo.Size = new Size(128, 35);
            btnCrearArticulo.TabIndex = 4;
            btnCrearArticulo.Text = "Crear Articulo";
            btnCrearArticulo.UseVisualStyleBackColor = false;
            btnCrearArticulo.Click += btnCrearArticulo_Click;
            // 
            // lblObligatorio
            // 
            lblObligatorio.AutoSize = true;
            lblObligatorio.ForeColor = Color.Red;
            lblObligatorio.Location = new Point(196, 57);
            lblObligatorio.Name = "lblObligatorio";
            lblObligatorio.Size = new Size(70, 15);
            lblObligatorio.TabIndex = 5;
            lblObligatorio.Text = "*obligatorio";
            lblObligatorio.Visible = false;
            // 
            // lblOpcional1
            // 
            lblOpcional1.AutoSize = true;
            lblOpcional1.ForeColor = Color.Gray;
            lblOpcional1.Location = new Point(196, 140);
            lblOpcional1.Name = "lblOpcional1";
            lblOpcional1.Size = new Size(58, 15);
            lblOpcional1.TabIndex = 6;
            lblOpcional1.Text = "*opcional";
            lblOpcional1.Visible = false;
            // 
            // btnEliminarArticulo
            // 
            btnEliminarArticulo.Location = new Point(18, 236);
            btnEliminarArticulo.Name = "btnEliminarArticulo";
            btnEliminarArticulo.Size = new Size(121, 28);
            btnEliminarArticulo.TabIndex = 8;
            btnEliminarArticulo.Text = "Eliminar Articulo";
            btnEliminarArticulo.UseVisualStyleBackColor = true;
            btnEliminarArticulo.Visible = false;
            btnEliminarArticulo.Click += btnEliminarArticulo_Click;
            // 
            // cbxArticulos
            // 
            cbxArticulos.FormattingEnabled = true;
            cbxArticulos.Location = new Point(18, 145);
            cbxArticulos.Name = "cbxArticulos";
            cbxArticulos.Size = new Size(121, 23);
            cbxArticulos.TabIndex = 9;
            cbxArticulos.SelectionChangeCommitted += cbxArticulos_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 127);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 10;
            label1.Text = "Modificar/Eliminar";
            // 
            // btnModificarArticulo
            // 
            btnModificarArticulo.Location = new Point(18, 189);
            btnModificarArticulo.Name = "btnModificarArticulo";
            btnModificarArticulo.Size = new Size(121, 28);
            btnModificarArticulo.TabIndex = 11;
            btnModificarArticulo.Text = "Modificar Articulo";
            btnModificarArticulo.UseVisualStyleBackColor = true;
            btnModificarArticulo.Visible = false;
            btnModificarArticulo.Click += btnModificarArticulo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ScrollBar;
            btnCancelar.Location = new Point(312, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 28);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.InactiveCaption;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 332);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 25);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // ArticuloView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 369);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificarArticulo);
            Controls.Add(label1);
            Controls.Add(cbxArticulos);
            Controls.Add(btnEliminarArticulo);
            Controls.Add(lblOpcional1);
            Controls.Add(lblObligatorio);
            Controls.Add(btnCrearArticulo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "ArticuloView";
            Text = "ArticuloForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnCrearArticulo;
        private Label lblObligatorio;
        private Label lblOpcional1;
        private Button btnEliminarArticulo;
        private ComboBox cbxArticulos;
        private Label label1;
        private Button btnModificarArticulo;
        private Button btnCancelar;
        private Button btnSalir;
    }
}