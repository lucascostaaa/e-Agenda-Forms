using e_agenda.WindowsApp.TelasCompromisso;
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
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private void btTarefa_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaTarefa telabase = new TelaTarefa();
            telabase.Closed += (s, args) => this.Show();
            telabase.Show();
        }
        private void btContato_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaContato telaContato = new TelaContato();
            telaContato.Closed += (s, args) => this.Show();
            telaContato.Show();
        }
        private void btCompromisso_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Closed += (s, args) => this.Show();
            telaCompromisso.Show();
        }
        private void gpEagenda_Enter(object sender, EventArgs e)
        {

        }
    }
}
