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
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveRetornar_AssuntoInvalido()
        {
            var compromisso = new Compromisso(null, "Uniplac", "", DateTime.Now.Date, new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);

            var resutladoValidacao = compromisso.Validar();

            resutladoValidacao.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveRetornar_DataInvalida()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", "",new DateTime(), new TimeSpan(18, 00, 00), new TimeSpan(19, 00, 00), null);

            var resutladoValidacao = compromisso.Validar();

            resutladoValidacao.Should().Be("O campo Data é obrigatório");
        }

        [TestMethod]
        public void DeveRetornar_Hora_DeInicioInvalida()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", null, DateTime.Now.Date, TimeSpan.MinValue,new TimeSpan(19, 00, 00), null);

            var resutladoValidacao = compromisso.Validar();

            resutladoValidacao.Should().Be("O campo Hora Início é obrigatório");
        }

        [TestMethod]
        public void DeveRetornar_Hora_DeFinalInvalida()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", null, DateTime.Now.Date, new TimeSpan(19,00,00), TimeSpan.MinValue, null);

            var resutladoValidacao = compromisso.Validar();

            resutladoValidacao.Should().Be("O campo Hora Término é obrigatório");
        }

        [TestMethod]
        public void DeveRetornar_Hora_Inicio_Hora_Final_Invalida()
        {
            var compromisso = new Compromisso("Projeto", "Uniplac", null, DateTime.Now.Date, TimeSpan.MinValue, TimeSpan.MinValue, null);

            var resutladoValidacao = compromisso.Validar();

            resutladoValidacao.Should().Be("Hora Inicio e Hora Término Inválidas");


        }
    }
}
