using e_agenda.WindowsApp.TelasContato.CRUD;
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
    public partial class TelaContato : Form
    {
        public TelaContato()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Closed += (s, args) => this.Show();
            cadastrar.Show();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarContatos visualizarContatos = new VisualizarContatos();
            visualizarContatos.Closed += (s, args) => this.Show();
            visualizarContatos.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarContato editarContato = new EditarContato();
            editarContato.Closed += (s, args) => this.Show();
            editarContato.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirContato excluirContato = new ExcluirContato();
            excluirContato.Closed += (s, args) => this.Show();
            excluirContato.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Telaprincipal telaprincipal = new Telaprincipal();
            telaprincipal.Closed += (s, args) => this.Show();
            telaprincipal.Show();
        }
    }
}
