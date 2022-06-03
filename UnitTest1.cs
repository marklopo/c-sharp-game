using NUnit.Framework;

namespace QuizNUnitTest
{
    public class Tests
    {
        private const int Expected = 11;
        private string  Expected2 = To1.Podpowiedz.ko³o_ratunkowe1();
        private int Expected3 =To1.Pytania.poziom1;
        [Test]
        public void sprawdzenie_wyniku_dodawania()
        {
            To1.Podpowiedz mat = new To1.Podpowiedz();
            int result = mat.matematyka(5, 6);

            Assert.AreEqual(Expected, result);
        }
        [Test]
        public void poprawnosc_wyswietlenia_komunikatu()
        {

            string result2 = "1. 50 / 50";
            Assert.AreEqual(Expected2, result2);
        }
        [Test]
        public void poprawnosc_wyswietlenia_komunikatu_o_wygranej()
        {

            int result3 = 1000;
            Assert.AreEqual(Expected3, result3);
        }


    }
}