namespace Zadanie4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void OdwrocStos_Test()
        {
            Stack<int> dane = new Stack<int>();
            dane.Push(1);
            dane.Push(2);
            dane.Push(3);
            dane.Push(4);
            dane.Push(5);
            dane.Push(6);

            Stack <int> wynik = Program.OdwrocStos(dane);

            CollectionAssert.AreEqual(new int[] {1,2,3,4,5,6} ,wynik.ToArray());
        }
    }
}
