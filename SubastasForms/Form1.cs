using SubastasForms.Models.Entidades;

namespace SubastasForms
{
    public partial class Form1 : Form
    {
        private int segundosRestantes = 10; // ejemplo: 10 segundos
        public Form1()
        {

            InitializeComponent();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                lblTiempo.Text = $"Tiempo restante: {segundosRestantes} s";
            }
            else
            {
                _timer.Stop();
                lblTiempo.Text = "¡Tiempo finalizado!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tiempo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Configurar el Timer
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 segundo
            _timer.Tick += Timer_Tick;

            // Iniciar el contador
            _timer.Start();

        }
    }
}
