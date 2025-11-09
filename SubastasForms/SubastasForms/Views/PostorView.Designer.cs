namespace SubastasForms.Views
{
    partial class PostorView
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
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            btnModificarUsuario = new Button();
            btnVerSubastas = new Button();
            label1 = new Label();
            btnPujar = new Button();
            btnSubastar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(510, 294);
            dataGridView1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(12, 394);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(155, 29);
            btnModificarUsuario.TabIndex = 2;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnVerSubastas
            // 
            btnVerSubastas.Location = new Point(12, 88);
            btnVerSubastas.Name = "btnVerSubastas";
            btnVerSubastas.Size = new Size(155, 29);
            btnVerSubastas.TabIndex = 3;
            btnVerSubastas.Text = "Ver Subastas";
            btnVerSubastas.UseVisualStyleBackColor = true;
            btnVerSubastas.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 51);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 4;
            label1.Text = "Mis subastas En Vivo";
            // 
            // btnPujar
            // 
            btnPujar.Location = new Point(12, 143);
            btnPujar.Name = "btnPujar";
            btnPujar.Size = new Size(155, 29);
            btnPujar.TabIndex = 5;
            btnPujar.Text = "Pujar";
            btnPujar.UseVisualStyleBackColor = true;
            // 
            // btnSubastar
            // 
            btnSubastar.Location = new Point(12, 199);
            btnSubastar.Name = "btnSubastar";
            btnSubastar.Size = new Size(155, 29);
            btnSubastar.TabIndex = 6;
            btnSubastar.Text = "Subastar";
            btnSubastar.UseVisualStyleBackColor = true;
            // 
            // PostorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubastar);
            Controls.Add(btnPujar);
            Controls.Add(label1);
            Controls.Add(btnVerSubastas);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Name = "PostorView";
            Text = "PostorView";
            Load += PostorView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSalir;
        private Button btnModificarUsuario;
        private Button btnVerSubastas;
        private Label label1;
        private Button btnPujar;
        private Button btnSubastar;
    }
}