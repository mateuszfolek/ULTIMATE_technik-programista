namespace Zadanie1.Test
{ 
    /*
   * Nazwa aplikacji: Zadanie1
   * Autor: Filip Wróbel
   * Egzamin inf04
   * Ilość klas: Program 1x
   * Ilość metod: 4x
   * Ilość zmiennych prostych: 3
   * Ilość zmiennych złożonych: 2
   * Opis: Aplikacja zwraca: min, max, suma, srednia, tablice posortowana
   * Aplikacja jest połączona z aplikacją testującą
   */

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void maks_test()
        {
            //aaa Testowanie - podział na 3 etapy projektowania app testującej
            //---------------------------------------------------------------------------
            //Arange
            int[] tab = { 1, 2, 3, 54 };
            int expected = 54;
            //Act
            int actual = Program.maks(tab);

            //Assert
            Assert.AreEqual(expected, actual);
            //Jeśl testuje prosty typ danych: int, float, double, string - TO KLASA "ASSTERT"
            //Jeśli testuje złożony typ danych: int[], obiekt - TO KLASA "COLLECTIONASSTERT" 
            //---------------------------------------------------------------------------
        }
        [TestMethod]
        public void mini_test()
        {

            //Arange
            int[] tab = { 1, 2, 3, 54 };
            int expected = 1;
            //Act
            int actual = Program.mini(tab);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void suma_test()
        {

            //Arange
            int[] tab = { 1, 2, 3, 54 };
            int expected = 60;
            //Act
            int actual = Program.suma(tab);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void avg_test()
        {

            //Arange
            int[] tab = { 1, 2, 3, 54 };
            int expected = 15;
            //Act
            double actual = Program.avg(tab);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void sortowanieTablicy_test()
        {
            int[] tab = { 5, 1, 2, 8 };
            int[] expected = { 1, 2, 5, 8 };

            int[] actual = Program.sortowanieTablicy(tab);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
