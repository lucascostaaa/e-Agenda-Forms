using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
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
    public partial class CompromissosPassados : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();

        public CompromissosPassados()
        {
            InitializeComponent();
        }

        private void CompromissosPassados_Load(object sender, EventArgs e)
        {
            dataGridViewCompromissosPassados.DataSource = MostrarCompromissosPassados();
        }
        public DataTable MostrarCompromissosPassados()
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

            List<Compromisso> mostrarCompromissosPassados = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);

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
                if(compromisso.Contato == null)
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
            VisualizarCompromissos visualizarCompromissos = new VisualizarCompromissos();
            visualizarCompromissos.Closed += (s, args) => this.Show();
            visualizarCompromissos.Show();
        }
    }
}
