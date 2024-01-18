using System.Diagnostics;

namespace contabilizador_de_horas
{
    public partial class Form1 : Form
    {
        private Stopwatch cronometro = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cronometro.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = cronometro.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            timer1.Stop();  
        }
    }
}
