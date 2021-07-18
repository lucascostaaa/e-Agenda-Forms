using e_agenda.WindowsApp.TelasCompromisso.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WindowsApp.TelasCompromisso
{
    public partial class TelaCompromisso : Form
    {
        public TelaCompromisso()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarCompromisso cadastrarCompromisso = new CadastrarCompromisso();
            cadastrarCompromisso.Closed += (s, args) => this.Show();
            cadastrarCompromisso.Show();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarCompromissos visualizarCompromissos = new VisualizarCompromissos();
            visualizarCompromissos.Closed += (s, args) => this.Show();
            visualizarCompromissos.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarCompromisso editarCompromisso = new EditarCompromisso();
            editarCompromisso.Closed += (s, args) => this.Show();
            editarCompromisso.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirCompromisso excluirCompromisso = new ExcluirCompromisso();
            excluirCompromisso.Closed += (s, args) => this.Show();
            excluirCompromisso.Show();
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
