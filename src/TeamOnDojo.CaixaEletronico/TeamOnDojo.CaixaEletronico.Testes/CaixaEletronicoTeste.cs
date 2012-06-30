using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamOnDojo.CaixaEletronico.Testes
{
    [TestClass]
    public class CaixaEletronicoTeste
    {
        CaixaEletronico _caixaEletronico;

        //AAA
        //A = Arrange
        //A = Act
        //A = Assert

        [TestInitialize]
        public void SetUp()
        {
            //Arrange
            _caixaEletronico = new CaixaEletronico();
        }

        [TestMethod]
        public void AoSacar_100_ReceboNota100()
        {
            //Arrange
            var esperado = new List<uint> { 100 };

            //Act
            var notas = _caixaEletronico.Sacar(100);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_50_ReceboNota50()
        {
            //Arrange
            var esperado = new List<uint> { 50 };

            //Act
            var notas = _caixaEletronico.Sacar(50);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_20_ReceboNota20()
        {
            //Arrange
            var esperado = new List<uint> { 20 };

            //Act
            var notas = _caixaEletronico.Sacar(20);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_10_ReceboNota10()
        {
            //Arrange
            var esperado = new List<uint> { 10 };

            //Act
            var notas = _caixaEletronico.Sacar(10);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_30_ReceboNota10e20() 
        {
            //Arrange
            var esperado = new List<uint> { 20, 10 };

            //Act
            var notas = _caixaEletronico.Sacar(30);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_40_Recebo2Notas20()
        {
            //Arrange
            var esperado = new List<uint> { 20, 20 };

            //Act
            var notas = _caixaEletronico.Sacar(40);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        [ExpectedException(typeof(ValorInvalidoException))]
        public void Ao_Sacar_5_Lanca_Valor_Invalido_Excecao()
        {
            //Act
            _caixaEletronico.Sacar(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ValorInvalidoException))]
        public void Ao_Sacar_105_Lanca_Valor_Invalido_Excecao()
        {
            //Act
            _caixaEletronico.Sacar(105);
        }

        [TestMethod]
        public void AoSacar_180_Recebo_Todos_Tipos_De_Notas()
        {
            //Arrange
            var esperado = new List<uint> { 100, 50, 20, 10 };

            //Act
            var notas = _caixaEletronico.Sacar(180);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_80_Recebo_Nota_50_20_10()
        {
            //Arrange
            var esperado = new List<uint> { 50, 20, 10 };

            //Act
            var notas = _caixaEletronico.Sacar(80);

            //Assert
            CollectionAssert.AreEqual(esperado, notas);
        }

        [TestMethod]
        public void AoSacar_0_ReceboNenhumaNota()
        {
            //Arrange
            var notasEsperadas = new List<uint>();
            
            //Act
            var notas = _caixaEletronico.Sacar(0);

            //Assert
            CollectionAssert.AreEqual(notasEsperadas, notas);
        }
    }
}
