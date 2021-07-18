using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controlador = null;
        ControladorContato controladorcontato = null;
        public ControladorCompromissoTest()
        {
            controlador = new ControladorCompromisso();
            controladorcontato = new ControladorContato();

            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        #region Testes de Insert
        [TestMethod]
        public void DeveInserir_Compromisso()
        {
            var novocontato = new Contato("Joao", "teste@gmail.com", "49988643136", "NDD", "Dev");
            var novocompromisso = new Compromisso("Projeto","Uniplac","", DateTime.Now.Date, new TimeSpan(16,00,00), new TimeSpan(17,00,00), novocontato);

            controladorcontato.InserirNovo(novocontato);
            controlador.InserirNovo(novocompromisso);

            var compromissoEncontrado = controlador.SelecionarPorId(novocompromisso.Id);
            compromissoEncontrado.Should().Be(novocompromisso);
        }
        [TestMethod]
        public void DeveInserir_Compromisso_SemContato()
        {
            var novocompromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);

            controlador.InserirNovo(novocompromisso);

            var compromissoEncontrado = controlador.SelecionarPorId(novocompromisso.Id);
            compromissoEncontrado.Should().Be(novocompromisso);
        }
        [TestMethod]
        public void NaoDeveInserir_Compromisso_EmHorarioOcupado()
        {
            Compromisso compromisso = new Compromisso("Projeto", "Uniplac", "", new DateTime(2021, 05, 02), new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(compromisso);

            Compromisso novocompromisso = new Compromisso("Reuniao", "NDD", "", new DateTime(2021, 05, 02), new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            string resultado = controlador.InserirNovo(novocompromisso);

            resultado.Should().Be("Nesta data e horário já tem um compromisso agendado");
            List<Compromisso> compromissos = controlador.SelecionarTodos();

            compromissos.Should().HaveCount(1);
        }

        #endregion

        #region Testes de Visualizar
        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            var compromisso1 = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(compromisso1);

            //action
            var compromissos = controlador.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(1);
        }
        [TestMethod]
        public void DeveSelecionar_CompromissosPorID()
        {
            //arrange
            var novocompromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);

            controlador.InserirNovo(novocompromisso);

            //action
            Compromisso ccompromissoEncontrado = controlador.SelecionarPorId(novocompromisso.Id);

            //assert
            ccompromissoEncontrado.Should().NotBeNull();
        }
        [TestMethod]
        public void DeveSelecionar_CompromissosFuturos()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", null, new DateTime(2021,10,01), new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controlador.InserirNovo(compromisso);

            var compromissos = controlador.SelecionarCompromissosFuturos(DateTime.Now.Date, new DateTime(2022,08,02));

            compromissos.Should().HaveCount(1);
        }
        [TestMethod]
        public void DeveSelecionar_CompromissoPassados()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", null, new DateTime(2021, 06, 20), new TimeSpan(13, 00, 00), new TimeSpan(14, 00, 00), null);
            controlador.InserirNovo(compromisso);

            var compromissos = controlador.SelecionarCompromissosPassados(DateTime.Now.Date);

            compromissos.Should().HaveCount(1);
        }
        #endregion

        #region Testes de Updates
        [TestMethod]
        public void DeveAtualiazar_Compromisso()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(compromisso);

            var novocompromisso = new Compromisso("Reuniao", "Uniplac", "", DateTime.Now.Date, new TimeSpan(20, 00, 00), new TimeSpan(21, 00, 00), null);
            controlador.Editar(compromisso.Id, novocompromisso);

            novocompromisso.Id = compromisso.Id;
            Compromisso compromissoAtualizado = controlador.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novocompromisso);
        }
        [TestMethod]
        public void DeveAtualizar_CompromissoComContato()
        {
            var contato = new Contato("Joao", "teste@gmail.com", "49988643136", "NDD", "Dev");
            controladorcontato.InserirNovo(contato);

            var compromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(compromisso);

            var novocompromisso = new Compromisso("Reuniao", "Uniplac", "", DateTime.Now.Date, new TimeSpan(20, 00, 00), new TimeSpan(21, 00, 00), contato);
            controlador.Editar(compromisso.Id, novocompromisso);

            Compromisso compromissoAtualizado = controlador.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novocompromisso);
        }
        [TestMethod]
        public void DeveAtualizar_CompromissoRemovendo_Contato()
        {
            var contato = new Contato("Joao", "teste@gmail.com", "49988643136", "NDD", "Dev");
            controladorcontato.InserirNovo(contato);

            var compromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), contato);
            controlador.InserirNovo(compromisso);

            var novocompromisso = new Compromisso("Reuniao", "Uniplac", "", DateTime.Now.Date, new TimeSpan(20, 00, 00), new TimeSpan(21, 00, 00), null);
            controlador.Editar(compromisso.Id, novocompromisso);

            Compromisso compromissoAtualizado = controlador.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novocompromisso);
        }
        [TestMethod]
        public void NaoDeveAtualizar_Com_Compromisso_No_Mesmo_Horario()
        {
            Compromisso compromisso = new Compromisso("Projeto", "Uniplac", "", new DateTime(2021, 05, 02), new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(compromisso);

            Compromisso novocompromisso = new Compromisso("Reuniao", "NDD", "", new DateTime(2021, 05, 02), new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.Editar(compromisso.Id,novocompromisso);

            var selecionartodos = controlador.SelecionarTodos();
            selecionartodos[0].Assunto.Should().Be("Projeto");
        }

        #endregion

        #region Testes de Delete 
        [TestMethod]
        public void DeveExcluir_Compromissos()
        {
            //arrange            
            var novocompromisso = new Compromisso("Projeto", "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);
            controlador.InserirNovo(novocompromisso);

            //action            
            controlador.Excluir(novocompromisso.Id);

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novocompromisso.Id);
            compromissoEncontrado.Should().BeNull();
        }
        #endregion
    }
}
