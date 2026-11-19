using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Zadanie5.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void PrzesunWLewo_Test()
        {
            List<int> dane = new List<int>() { 10, 20, 30, 40 };

            int[] oczekiwany = new int[] { 20, 30, 40, 10 };

            List<int> aktualnyWynik = Program.PrzesunWLewo(dane);
            CollectionAssert.AreEqual(oczekiwany, aktualnyWynik.ToArray());

        }

        [TestMethod]
        public void UsunParzyste_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);

            Stack<int> oczekiwany = new Stack<int>();
            oczekiwany.Push(1);
            oczekiwany.Push(3);
            oczekiwany.Push(5);
            oczekiwany.Push(7);
            oczekiwany.Push(9);

            Stack<int> wynik = Program.UsunParzyste(stack);

            CollectionAssert.AreEqual(oczekiwany, stack);
        }
    }
}
