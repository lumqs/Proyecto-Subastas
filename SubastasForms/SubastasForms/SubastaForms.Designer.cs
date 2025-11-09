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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.AccessibleName = "";
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(225, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre del Articulo";
            textBox1.Size = new Size(204, 29);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(160, 238);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 240);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Puja en aumento: $";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(273, 340);
            button1.Name = "button1";
            button1.Size = new Size(121, 25);
            button1.TabIndex = 4;
            button1.Text = "Crear Subasta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 96);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Descripción";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(336, 119);
            textBox2.TabIndex = 6;
            textBox2.Tag = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 240);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio Inicial: $";
            label2.Click += label2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(442, 238);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 9;
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
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(198, 281);
            numericUpDown3.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(60, 23);
            numericUpDown3.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 15;
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
            dateTimePicker1.Location = new Point(386, 285);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
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
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "SubastaForms";
            Text = "SubasataForms";
            Load += SubasataForms_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}