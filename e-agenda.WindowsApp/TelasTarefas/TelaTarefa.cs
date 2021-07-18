using e_agenda.WindowsApp.TelasTarefas.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WindowsApp
{
    public partial class TelaTarefa : Form
    {
        public TelaTarefa()
        {
            InitializeComponent();
        }
        private void btCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroTarefa cadastroTarefa = new CadastroTarefa();
            cadastroTarefa.Closed += (s, args) => this.Show();
            cadastroTarefa.Show();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Telaprincipal telaprincipal = new Telaprincipal();
            telaprincipal.Closed += (s, args) => this.Show();
            telaprincipal.Show();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TodasVisualizacoes todasVisualizacoes = new TodasVisualizacoes();
            todasVisualizacoes.Closed += (s, args) => this.Show();
            todasVisualizacoes.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar editar = new Editar();
            editar.Closed += (s, args) => this.Show();
            editar.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Excluir excluir = new Excluir();
            excluir.Closed += (s, args) => this.Show();
            excluir.Show();
        }
    }
}

