using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_agenda.WindowsApp.TelasContato.CRUD
{
    public partial class VisualizarContatos : Form
    {
        private ControladorContato controlador = new ControladorContato();

        public VisualizarContatos()
        {
            InitializeComponent();
        }

        private void VisualizarContatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarTodosContatos();
        }
        public DataTable MostrarTodosContatos()
        {
            DataTable linhasTodasContatos = new DataTable();

            linhasTodasContatos.Columns.Add("ID");
            linhasTodasContatos.Columns.Add("Nome");
            linhasTodasContatos.Columns.Add("E-mail");
            linhasTodasContatos.Columns.Add("Telefone");
            linhasTodasContatos.Columns.Add("Empresa");
            linhasTodasContatos.Columns.Add("Cargo");

            List<Contato> mostrarTodosContatos = controlador.SelecionarTodos();

            foreach (var contato in mostrarTodosContatos)
            {
                var linha = linhasTodasContatos.NewRow();

                linha["ID"] = contato.Id;
                linha["Nome"] = contato.Nome;
                linha["E-mail"] = contato.Email;
                linha["Telefone"] = contato.Telefone;
                linha["Empresa"] = contato.Empresa;
                linha["Cargo"] = contato.Cargo;

                linhasTodasContatos.Rows.Add(linha);
            }

            return linhasTodasContatos;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaContato telaContato = new TelaContato();
            telaContato.Closed += (s, args) => this.Show();
            telaContato.Show();
        }
    }
}
