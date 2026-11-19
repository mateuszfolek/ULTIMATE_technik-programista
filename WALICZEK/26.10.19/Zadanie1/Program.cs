
using System;
using System.Collections.Generic;

namespace Zadanie1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Arkadiusz");
            list.Add("Mariusz");
            list.Add("Dariusz");
            list.Add("Filip");
            list.Add("Pies");
            list.Add("goat");

            Console.WriteLine("Lista: " + string.Join(", ", list));

            list.Add("Monika");


            foreach (var imie in list)
            {
                Console.WriteLine(imie);
            }

            SortowanieImion(list);

            Console.WriteLine("\nLista po sortowaniu:");

            foreach (var imie in list)
            {
                Console.WriteLine(imie);
            }
        }

        public static List<string> SortowanieImion(List<string> imiona)
        {
            imiona.Sort();
            return imiona;
        }
    }
}
