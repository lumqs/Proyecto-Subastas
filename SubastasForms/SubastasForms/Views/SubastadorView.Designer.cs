namespace SubastasForms.Views
{
    partial class SubastadorView
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
            btnSalir = new Button();
            btnAgregarArticulo = new Button();
            btnCrearSubasta = new Button();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.InactiveCaption;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(11, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 36);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.Location = new Point(30, 221);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(127, 35);
            btnAgregarArticulo.TabIndex = 1;
            btnAgregarArticulo.Text = "Mis Articulos";
            btnAgregarArticulo.UseVisualStyleBackColor = true;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // btnCrearSubasta
            // 
            btnCrearSubasta.Location = new Point(30, 145);
            btnCrearSubasta.Name = "btnCrearSubasta";
            btnCrearSubasta.Size = new Size(127, 33);
            btnCrearSubasta.TabIndex = 2;
            btnCrearSubasta.Text = "Crear Subasta";
            btnCrearSubasta.UseVisualStyleBackColor = true;
            btnCrearSubasta.Click += btnCrearSubasta_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 308);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 3;
            button1.Text = "Notificaciones";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(30, 399);
            button3.Name = "button3";
            button3.Size = new Size(127, 35);
            button3.TabIndex = 4;
            button3.Text = "Modo Postor";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 76);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(698, 451);
            dataGridView1.TabIndex = 5;
            // 
            // SubastadorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 593);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnCrearSubasta);
            Controls.Add(btnAgregarArticulo);
            Controls.Add(btnSalir);
            Name = "SubastadorView";
            Text = "SubastadorView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregarArticulo;
        private Button btnCrearSubasta;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
    }
}