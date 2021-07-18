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

namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    public partial class Excluir : Form
    {
        private ControladorTarefa controlador = new ControladorTarefa();

        public Excluir()
        {
            InitializeComponent();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {
            dataGridViewExcluir.DataSource = MostrarTodasTarefas();
        }
        public DataTable MostrarTodasTarefas()
        {
            DataTable linhasTodasTarefas = new DataTable();

            linhasTodasTarefas.Columns.Add("ID");
            linhasTodasTarefas.Columns.Add("Titulo");
            linhasTodasTarefas.Columns.Add("Prioridade");
            linhasTodasTarefas.Columns.Add("Percentual");
            linhasTodasTarefas.Columns.Add("Data Criação");
            linhasTodasTarefas.Columns.Add("Data de Conclusao");

            List<Tarefa> mostrarTodasTarefas = controlador.SelecionarTodos();

            foreach (var tarefa in mostrarTodasTarefas)
            {
                var linha = linhasTodasTarefas.NewRow();

                linha["ID"] = tarefa.Id;
                linha["Titulo"] = tarefa.Titulo;
                linha["Prioridade"] = tarefa.Prioridade;
                linha["Percentual"] = tarefa.Percentual;
                linha["Data Criação"] = tarefa.DataCriacao;
                linha["Data de Conclusao"] = tarefa.DataConclusao;

                linhasTodasTarefas.Rows.Add(linha);
            }
            return linhasTodasTarefas;
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int idselecionado = Convert.ToInt32(textBoxID.Text);
            controlador.Excluir(idselecionado);

            MessageBox.Show("Tarefa Excluida com sucesso");

            textBoxID.Clear();
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
