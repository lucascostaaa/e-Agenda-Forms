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
    public partial class Cadastrar : Form
    {
        ControladorContato controlador = new ControladorContato();
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

            Contato contato = new Contato(nome,email,telefone,empresa,cargo);
            string validar = controlador.InserirNovo(contato);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("NOVo CONTATO CADASTRADA COM SUCESSO");
            else
                MessageBox.Show("TAREFA INVÁLIDA, TENTE NOVAMENTE!");

            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxTelefone.Clear();
            textBoxEmpresa.Clear();
            textBoxCargo.Clear();

        }
        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaContato telaContato = new TelaContato();
            telaContato.Closed += (s, args) => this.Show();
            telaContato.Show();
        }
    }
}
