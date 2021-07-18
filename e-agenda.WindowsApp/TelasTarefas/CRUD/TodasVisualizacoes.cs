using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    public partial class TodasVisualizacoes : Form
    {
        public TodasVisualizacoes()
        {
            InitializeComponent();
        }
        private void btVisualizartodos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarTodos visualizarTodos = new VisualizarTodos();
            visualizarTodos.Closed += (s, args) => this.Show();
            visualizarTodos.Show();
        }

        private void btPendente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarPendentes visualizarPendentes = new VisualizarPendentes();
            visualizarPendentes.Closed += (s, args) => this.Show();
            visualizarPendentes.Show();
        }

        private void btConcluido_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarConcluidas visualizarConcluidas = new VisualizarConcluidas();
            visualizarConcluidas.Closed += (s, args) => this.Show();
            visualizarConcluidas.Show();
        }
        private void gpEagenda_Enter(object sender, EventArgs e)
        {
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaTarefa telaTarefa = new TelaTarefa();
            telaTarefa.Closed += (s, args) => this.Show();
            telaTarefa.Show();
        }
    }
}
