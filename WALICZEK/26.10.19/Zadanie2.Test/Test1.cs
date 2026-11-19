namespace Zadanie2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CofnijOperacje_Test()
        {

            //Arrange
            Stack <string> dane = new Stack<string>();
            dane.Push("A");
            dane.Push("B");
            dane.Push("C");

            //Act
            Stack<string> wynik = Program.CofnijOperacje(dane, 2);

            //Assert
            Assert.AreEqual(1, wynik.Count);
            Assert.AreEqual("A", wynik.Peek());

        }
    }
}
