using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WindowsApp.TelasCompromisso.CRUD
{
    public partial class VisualizarCompromissos : Form
    {
        public VisualizarCompromissos()
        {
            InitializeComponent();
        }

        private void btCompromissosPasados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompromissosPassados compromissosPassados = new CompromissosPassados();
            compromissosPassados.Closed += (s, args) => this.Show();
            compromissosPassados.Show();
        }

        private void btPendente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompromissosFuturos compromissosFuturo = new CompromissosFuturos();
            compromissosFuturo.Closed += (s, args) => this.Show();
            compromissosFuturo.Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Closed += (s, args) => this.Show();
            telaCompromisso.Show();
        }
    }
}
