using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class ExcluirCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public ExcluirCompromisso()
        {
            InitializeComponent();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int idselecionado = Convert.ToInt32(textBoxIDExcluir.Text);
            controladorCompromisso.Excluir(idselecionado);

            MessageBox.Show("Tarefa Excluida com sucesso");

            textBoxIDExcluir.Clear();
        }

        private void ExcluirCompromisso_Load(object sender, EventArgs e)
        {
            dataGridViewExcluir.DataSource = MostrarTodosCompromissos();
        }
        public DataTable MostrarTodosCompromissos()
        {
            DataTable linhasCompromissosPassados = new DataTable();

            linhasCompromissosPassados.Columns.Add("ID");
            linhasCompromissosPassados.Columns.Add("Assunto");
            linhasCompromissosPassados.Columns.Add("Local");
            linhasCompromissosPassados.Columns.Add("Link");
            linhasCompromissosPassados.Columns.Add("Data");
            linhasCompromissosPassados.Columns.Add("Hora Inicio");
            linhasCompromissosPassados.Columns.Add("Hora Termino");
            linhasCompromissosPassados.Columns.Add("Nome");

            List<Compromisso> mostrarCompromissosPassados = controladorCompromisso.SelecionarTodos();

            foreach (var compromisso in mostrarCompromissosPassados)
            {
                var linha = linhasCompromissosPassados.NewRow();

                linha["ID"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Local"] = compromisso.Local;
                linha["Link"] = compromisso.Link;
                linha["Data"] = compromisso.Data;
                linha["Hora Inicio"] = compromisso.HoraInicio;
                linha["Hora Termino"] = compromisso.HoraTermino;
                if (compromisso.Contato == null)
                {
                    linha["Nome"] = "";
                }
                else
                {
                    linha["Nome"] = compromisso.Contato.Nome;
                }
                linhasCompromissosPassados.Rows.Add(linha);
            }
            return linhasCompromissosPassados;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Closed += (s, args) => this.Show();
            telaCompromisso.Show();
        }
    }
}
