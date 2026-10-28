namespace Zadanie3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void UsunDuplikaty_Test()
        {
            //aaa
            List<int> dane = new() { 5, 2, 5, 2, 8 };
            List<int> oczekiwane = new() { 5, 2, 8 };

            CollectionAssert.AreEqual(oczekiwane, Program.UsunDuplikaty(dane));

        }
    }
}
