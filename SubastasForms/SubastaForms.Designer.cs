namespace SubastasForms
{
    partial class SubastaForms
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
            txtNombreArticulo = new TextBox();
            numPujaAumento = new NumericUpDown();
            label1 = new Label();
            btnCrearSubasta = new Button();
            txtDescripcionArticulo = new TextBox();
            label2 = new Label();
            numPujaInicial = new NumericUpDown();
            label3 = new Label();
            numDuracion = new NumericUpDown();
            cbxArticulos = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numPujaAumento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPujaInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            SuspendLayout();
            // 
            // txtNombreArticulo
            // 
            txtNombreArticulo.AccessibleDescription = "";
            txtNombreArticulo.AccessibleName = "";
            txtNombreArticulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreArticulo.Location = new Point(225, 51);
            txtNombreArticulo.Name = "txtNombreArticulo";
            txtNombreArticulo.PlaceholderText = "Nombre del Articulo";
            txtNombreArticulo.Size = new Size(204, 29);
            txtNombreArticulo.TabIndex = 0;
            // 
            // numPujaAumento
            // 
            numPujaAumento.Location = new Point(516, 243);
            numPujaAumento.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPujaAumento.Name = "numPujaAumento";
            numPujaAumento.Size = new Size(120, 23);
            numPujaAumento.TabIndex = 1;
            numPujaAumento.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 245);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Puja en aumento: $";
            label1.Click += label1_Click;
            // 
            // btnCrearSubasta
            // 
            btnCrearSubasta.Location = new Point(273, 340);
            btnCrearSubasta.Name = "btnCrearSubasta";
            btnCrearSubasta.Size = new Size(121, 25);
            btnCrearSubasta.TabIndex = 4;
            btnCrearSubasta.Text = "Crear Subasta";
            btnCrearSubasta.UseVisualStyleBackColor = true;
            btnCrearSubasta.Click += button1_Click;
            // 
            // txtDescripcionArticulo
            // 
            txtDescripcionArticulo.Location = new Point(160, 96);
            txtDescripcionArticulo.Multiline = true;
            txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            txtDescripcionArticulo.PlaceholderText = "Descripción";
            txtDescripcionArticulo.ScrollBars = ScrollBars.Vertical;
            txtDescripcionArticulo.Size = new Size(336, 119);
            txtDescripcionArticulo.TabIndex = 6;
            txtDescripcionArticulo.Tag = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 243);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio Inicial: $";
            label2.Click += label2_Click;
            // 
            // numPujaInicial
            // 
            numPujaInicial.Location = new Point(139, 241);
            numPujaInicial.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPujaInicial.Name = "numPujaInicial";
            numPujaInicial.Size = new Size(120, 23);
            numPujaInicial.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 285);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 12;
            label3.Text = "Duración de subasta (en min)";
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(198, 281);
            numDuracion.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(60, 23);
            numDuracion.TabIndex = 11;
            // 
            // cbxArticulos
            // 
            cbxArticulos.FormattingEnabled = true;
            cbxArticulos.Location = new Point(30, 12);
            cbxArticulos.Name = "cbxArticulos";
            cbxArticulos.Size = new Size(162, 23);
            cbxArticulos.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 15);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 16;
            label4.Text = "<-   Seleccione un articulo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(386, 297);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // SubastaForms
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 389);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(cbxArticulos);
            Controls.Add(label3);
            Controls.Add(numDuracion);
            Controls.Add(label2);
            Controls.Add(numPujaInicial);
            Controls.Add(txtDescripcionArticulo);
            Controls.Add(btnCrearSubasta);
            Controls.Add(label1);
            Controls.Add(numPujaAumento);
            Controls.Add(txtNombreArticulo);
            Name = "SubastaForms";
            Text = "SubasataForms";
            ((System.ComponentModel.ISupportInitialize)numPujaAumento).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPujaInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreArticulo;
        private NumericUpDown numPujaAumento;
        private Label label1;
        private Button btnCrearSubasta;
        private TextBox txtDescripcionArticulo;
        private Label label2;
        private NumericUpDown numPujaInicial;
        private Label label3;
        private NumericUpDown numDuracion;
        private ComboBox cbxArticulos;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}