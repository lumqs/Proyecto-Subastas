namespace SubastasForms.Views
{
    partial class CrearUsuario
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
            txtEmail = new TextBox();
            txtPass1 = new TextBox();
            txtPass2 = new TextBox();
            btnCrearUsuario = new Button();
            btnPass1Visible = new Button();
            btnPass2Visible = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(318, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(318, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPass1
            // 
            txtPass1.Location = new Point(157, 215);
            txtPass1.Name = "txtPass1";
            txtPass1.PlaceholderText = "Contraseña";
            txtPass1.Size = new Size(318, 23);
            txtPass1.TabIndex = 2;
            txtPass1.UseSystemPasswordChar = true;
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(157, 279);
            txtPass2.Name = "txtPass2";
            txtPass2.PlaceholderText = "Repetir Contraseña";
            txtPass2.Size = new Size(318, 23);
            txtPass2.TabIndex = 3;
            txtPass2.UseSystemPasswordChar = true;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = SystemColors.MenuHighlight;
            btnCrearUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearUsuario.ForeColor = SystemColors.Window;
            btnCrearUsuario.Location = new Point(263, 342);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(124, 30);
            btnCrearUsuario.TabIndex = 4;
            btnCrearUsuario.Tag = "";
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnPass1Visible
            // 
            btnPass1Visible.Location = new Point(492, 215);
            btnPass1Visible.Name = "btnPass1Visible";
            btnPass1Visible.Size = new Size(22, 23);
            btnPass1Visible.TabIndex = 5;
            btnPass1Visible.Text = "*";
            btnPass1Visible.UseVisualStyleBackColor = true;
            btnPass1Visible.Click += button1_Click;
            // 
            // btnPass2Visible
            // 
            btnPass2Visible.Location = new Point(492, 279);
            btnPass2Visible.Name = "btnPass2Visible";
            btnPass2Visible.Size = new Size(22, 23);
            btnPass2Visible.TabIndex = 6;
            btnPass2Visible.Text = "*";
            btnPass2Visible.UseVisualStyleBackColor = true;
            btnPass2Visible.Click += btnPass2Visible_Click;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(635, 450);
            Controls.Add(btnPass2Visible);
            Controls.Add(btnPass1Visible);
            Controls.Add(btnCrearUsuario);
            Controls.Add(txtPass2);
            Controls.Add(txtPass1);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            Load += CrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtPass1;
        private TextBox txtPass2;
        private Button btnCrearUsuario;
        private Button btnPass1Visible;
        private Button btnPass2Visible;
    }
}