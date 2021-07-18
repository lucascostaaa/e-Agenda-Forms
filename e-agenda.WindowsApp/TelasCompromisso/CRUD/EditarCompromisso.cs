using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace e_agenda.WindowsApp.TelasCompromisso.CRUD
{
    public partial class EditarCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();

        public EditarCompromisso()
        {
            InitializeComponent();
        }

        private void EditarCompromisso_Load(object sender, EventArgs e)
        {
            dataGridViewCompromissos.DataSource = MostrarTodosCompromissos();
            dataGridViewContato.DataSource = MostrarTodosContatos();
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
        public DataTable MostrarTodosContatos()
        {
            DataTable linhasTodasContatos = new DataTable();

            linhasTodasContatos.Columns.Add("ID");
            linhasTodasContatos.Columns.Add("Nome");
            linhasTodasContatos.Columns.Add("E-mail");
            linhasTodasContatos.Columns.Add("Telefone");
            linhasTodasContatos.Columns.Add("Empresa");
            linhasTodasContatos.Columns.Add("Cargo");

            List<Contato> mostrarTodosContatos = controladorContato.SelecionarTodos();

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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            int idCompromisso = Convert.ToInt32(textBoxidCompromisso.Text);
            string assunto = textBoxAssunto.Text;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            DateTime data = dateTimePickerData.Value;
            TimeSpan horaInicio = Convert.ToDateTime(maskedTextBoxHoraIncio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(maskedTextBoxHoraTermino.Text).TimeOfDay;
            Contato contato = null;
            if (controladorContato.Existe(Convert.ToInt32(textBoxIDContato.Text)))
                contato = controladorContato.SelecionarPorId(Convert.ToInt32(textBoxIDContato.Text));

            Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string validar = controladorCompromisso.Editar(idCompromisso, compromisso);
            
            if (validar == "ESTA_VALIDO")
                MessageBox.Show("COMPROMISSO EDITADA COM SUCESSO");
            else
                MessageBox.Show("EDIÇÃO INVÁLIDA, TENTE NOVAMENTE!");

            textBoxidCompromisso.Clear();
            textBoxAssunto.Clear();
            textBoxLocal.Clear();
            textBoxLink.Clear();
            maskedTextBoxHoraIncio.Clear();
            maskedTextBoxHoraTermino.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Closed += (s, args) => this.Show();
            telaCompromisso.Show();
        }
    }
}
