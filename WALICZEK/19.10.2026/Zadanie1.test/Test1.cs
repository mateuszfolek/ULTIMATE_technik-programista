namespace Zadanie1.test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void SortowanieImion_test()
        {
            ///aaa
           
            ///Arange
            List<string> list1_not_sorted = new List<string>()
            {
            "Arkadiusz",
            "Mariusz",
            "Dariusz",
            "Filip",
            "Pies",
            "goat",
            "Monika"
            };


            List<string> list2_sorted = new List<string>()
            {
            "Arkadiusz",
            "Dariusz",
            "Filip",
            "goat",
            "Mariusz",
            "Monika",
            "Pies"
            };

            //Act
            List<string> expected = Program.SortowanieImion(list1_not_sorted);

            //Assert
            CollectionAssert.AreEqual(expected, list2_sorted);
                       
        }
    }
}
