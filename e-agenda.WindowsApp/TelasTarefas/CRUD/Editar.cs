using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;

namespace e_agenda.WindowsApp.TelasTarefas.CRUD
{
    public partial class Editar : Form
    {
        private ControladorTarefa controlador = new ControladorTarefa();
        public Editar()
        {
            InitializeComponent();
        }
        private void Editar_Load(object sender, EventArgs e)
        {
            dataGridViewEditar.DataSource = MostrarTodasTarefas();
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
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int prioridade = Convert.ToInt32(comboBoxPrioridade.SelectedItem);
            int id = Convert.ToInt32(textBoxIdEditar.Text);
            Tarefa editada = controlador.SelecionarPorId(id);
            editada.Titulo = textBoxTituloEditar.Text;
            editada.Percentual = Convert.ToInt32(textBoxPercentualEditar.Text);
            editada.Prioridade = new Prioridade((PrioridadeEnum) prioridade);

            string validar = controlador.Editar(id, editada);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("TAREFA EDITADA COM SUCESSO");
            else
                MessageBox.Show("EDIÇÃO INVÁLIDA, TENTE NOVAMENTE!");

            textBoxIdEditar.Clear();
            textBoxTituloEditar.Clear();
            textBoxPercentualEditar.Clear();

        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaTarefa telatarefa = new TelaTarefa();
            telatarefa.Closed += (s, args) => this.Show();
            telatarefa.Show();
        }
    }
}
