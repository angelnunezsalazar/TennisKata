using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tennis.Web.Models;

namespace Tenis.Tests
{
    [TestClass]
    public class TennisTests
    {
        TennisGame tennis;
        [TestInitialize]
        public void Setup()
        {
            tennis = new TennisGame();
        }

        [TestMethod]
        public void EmpateAlIniciarElJuego()
        {
            var score = tennis.Score();
            Assert.AreEqual("0,0", score);
        }

        [TestMethod]
        public void AnotoElJugadorUno()
        {
            tennis.ScorePlayer1();
            var score = tennis.Score();
            Assert.AreEqual("15,0", score);
        }

        [TestMethod]
        public void AnotoElJugadorDos()
        {
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("0,15", score);
        }

        [TestMethod]
        public void PrimerEmpate()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("15,15", score);
        }

        [TestMethod]
        public void ElJugadorUnoAnoto2Veces()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            var score = tennis.Score();
            Assert.AreEqual("30,0", score);
        }

        [TestMethod]
        public void ElJugadorDosAnoto2Veces()
        {
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("0,30", score);
        }

        [TestMethod]
        public void ElJugadorUnoAnota3Veces()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            var score = tennis.Score();
            Assert.AreEqual("40,0", score);
        }

        [TestMethod]
        public void ElJugadorDosAnota3Veces()
        {
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("0,40", score);
        }

        [TestMethod]
        public void GanoJugadorUno()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            var score = tennis.Score();
            Assert.AreEqual("Juan wins", score);
        }

        [TestMethod]
        public void GanoJugadorDos()
        {
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Miguel wins", score);
        }

        [TestMethod]
        public void PrimerDeuce()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Deuce", score);
        }

        [TestMethod]
        public void SegundoDeuce()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Deuce", score);
        }

        [TestMethod]
        public void VentajaPrimerJugador()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Advantage Juan", score);
        }

        [TestMethod]
        public void VentajaSegundoJugador()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Advantage Miguel", score);
        }

        [TestMethod]
        public void GanoJugadorUnoDespuesDeVentaja()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Juan wins", score);
        }

        [TestMethod]
        public void GanoJugadorDosDespuesDeVentaja()
        {
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer1();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            tennis.ScorePlayer2();
            var score = tennis.Score();
            Assert.AreEqual("Miguel wins", score);
        }
    }
}
