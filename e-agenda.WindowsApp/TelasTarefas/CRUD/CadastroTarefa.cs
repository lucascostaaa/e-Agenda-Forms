using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class CadastroTarefa : Form
    {
        private ControladorTarefa controlador = new ControladorTarefa();
        public CadastroTarefa()
        {
            InitializeComponent();
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string titulo = TbTitulo.Text;
            int prioridade = Convert.ToInt32(comboBoxPrioridade.SelectedItem);
            Tarefa tarefa = new Tarefa(titulo, DateTime.Now.Date, (PrioridadeEnum)prioridade);
            string validar = controlador.InserirNovo(tarefa);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("NOVA TAREFA CADASTRADA COM SUCESSO");
            else
                MessageBox.Show("TAREFA INVÁLIDA, TENTE NOVAMENTE!");

            TbTitulo.Clear();

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
