namespace SubastasForms.Views
{
    partial class GrillaPrueba
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
            btnCrearUsuario = new Button();
            btnActualizarGrilla = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(631, 325);
            dataGridView1.TabIndex = 0;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(319, 41);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(97, 23);
            btnCrearUsuario.TabIndex = 1;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnActualizarGrilla
            // 
            btnActualizarGrilla.Location = new Point(35, 63);
            btnActualizarGrilla.Name = "btnActualizarGrilla";
            btnActualizarGrilla.Size = new Size(72, 23);
            btnActualizarGrilla.TabIndex = 2;
            btnActualizarGrilla.Text = "Actualizar";
            btnActualizarGrilla.UseVisualStyleBackColor = true;
            btnActualizarGrilla.Click += btnActualizarGrilla_Click;
            // 
            // GrillaPrueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizarGrilla);
            Controls.Add(btnCrearUsuario);
            Controls.Add(dataGridView1);
            Name = "GrillaPrueba";
            Text = "GrillaPrueba";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCrearUsuario;
        private Button btnActualizarGrilla;
    }
}