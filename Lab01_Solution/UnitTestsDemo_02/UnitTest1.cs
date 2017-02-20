using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestsDemo
{
    /*
      * All credits go to Lukáš Daubner
      *
      * Debugging vsech testu lze spustit pres horni zalozku Test -> Debug -> All tests
      *
      * Zde si představíme Unit Testy.
      * Používáme je na automatické otestování funkcionality dílčích částí kódu(obvykle bereme že metod).
      * Třídy a metody testů musí mít odpovídající hlavičku([TestClass] a [TestMethod]).
      * Jméno unit testu se podle konvencí skládá ze tří částí:
      * UnitOfWork(testovaná jednotka)_StateUnderTest(stav v kterém jednotku testujeme)_ExpectedBehavior(očekávané chování)
      * Unit test se skládá ze tří částí: Arrange(inicializace prostředí pro test), Act(vykonání metody), Assert(verifikace).
      * Test je typu void (nic nevrací) a nebere žádné argumenty.
      */
    [TestClass]
    public class FactorialTest
    {
        //Nejběžnější test. Prosté porovnání výstupů.
        [TestMethod]
        public void Factorial_OnGeneralInput_Correct()
        {
            //Arrange
            int input = 5;
            int expectedOutput = 120;
            //Act
            int output = Factorial.FactorialGood(input);
            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        //Test na vyhození vyjímky. Obsahuje další hlavičku s očekávanou vyjímkou,
        //selže pokud nedojde k vyhození výjimky.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factorial_OnNegativeInput_Throws()
        {
            //Arrange
            int input = -1;
            //Act
            int output = Factorial.FactorialBadExceptionless(input);
            //Assert
            //Assert je prázdný, protože v tomto testu zjištujěme vyjímku, která je uvedena v hlavičce.
        }

        //Tento test navíc kromě správnosti výstupu kontroluje i dobu výpočtu. Doba je v milisekundách.
        [TestMethod]
        [Timeout(100)]
        public void Factorial_OnGeneralInput_CompletesAndCorrect()
        {
            //Arrange
            int input = 5;
            int expectedOutput = 120;
            //Act
            int output = Factorial.FactorialBadInfinite(input);
            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
