using SubastasForms.Models.Entidades;

namespace SubastasForms
{
    partial class ControlUsuarioArticulo
    {
        private int minutos;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lbltiempo = new Label();
            lblnombre = new Label();
            pbimagen = new PictureBox();
            lblprecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pbimagen).BeginInit();
            SuspendLayout();
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltiempo.Location = new Point(119, 15);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(107, 37);
            lbltiempo.TabIndex = 0;
            lbltiempo.Text = "Tiempo";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(48, 55);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(256, 41);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre Articulo";
            // 
            // pbimagen
            // 
            pbimagen.Location = new Point(71, 115);
            pbimagen.Margin = new Padding(3, 4, 3, 4);
            pbimagen.Name = "pbimagen";
            pbimagen.Size = new Size(189, 165);
            pbimagen.TabIndex = 2;
            pbimagen.TabStop = false;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprecio.Location = new Point(48, 300);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(211, 37);
            lblprecio.TabIndex = 3;
            lblprecio.Text = "Precio Actual: $..";
            // 
            // ControlUsuarioArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblprecio);
            Controls.Add(pbimagen);
            Controls.Add(lblnombre);
            Controls.Add(lbltiempo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ControlUsuarioArticulo";
            Size = new Size(343, 378);
            ((System.ComponentModel.ISupportInitialize)pbimagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (minutos > 0)
            {
                minutos--;
                lbltiempo.Text = $"Tiempo restante: {minutos}s";
            }
            else
            {
                timer1.Stop();
                lbltiempo.Text = "Finalizado";
            }
        }


        private Label lbltiempo;
        private Label lblnombre;
        private PictureBox pbimagen;
        private Label lblprecio;
        private System.Windows.Forms.Timer timer1;
    }
}
