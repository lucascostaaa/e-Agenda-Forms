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
    public partial class CadastrarCompromisso : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public CadastrarCompromisso()
        {
            InitializeComponent();
        }

        private void CadastrarCompromisso_Load(object sender, EventArgs e)
        {
            dataGridViewVerContatos.DataSource = MostrarTodosContatos();
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
            string assunto = textBoxAssunto.Text;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            DateTime data = dateTimePickerData.Value;
            TimeSpan horaInicio = Convert.ToDateTime(maskedTextBoxHoraIncio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(maskedTextBoxHoraTermino.Text).TimeOfDay;
            Contato contato = null;
            if(controladorContato.Existe(Convert.ToInt32(textBoxidContato.Text)))
            contato = controladorContato.SelecionarPorId(Convert.ToInt32(textBoxidContato.Text)); 

            Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino,contato);
            string validar = controladorCompromisso.InserirNovo(compromisso);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("COMPROMISSO CADASTRADO COM SUCESSO");
            else
                MessageBox.Show("ERRO AO TENTAR CADASTRAR UM COMPROMISSO, TENTE NOVAMENTE");

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
