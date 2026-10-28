/*
 * Napisz metodę UsunDuplikaty, która przyjmuje List<int> i zwraca nową listę 
 * bez powtarzających się liczb 
 * przykład 5,2,5,8,2 i zwracam: 5,2,8
 * Napisz mstest dla metody UsunDuplikaty
 * 
 */

namespace Zadanie3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> dane = new List<int>()
            {
                5,2,5,8,2
            };
            List<int> wynik = UsunDuplikaty(dane);
            Console.Write(string.Join(" ", wynik));
        }

        public static List<int> UsunDuplikaty (List<int> dane)
        {
            List<int> wynik = new();
            foreach (int liczba in dane)
            {
                if (!wynik.Contains(liczba))
                {
                    wynik.Add(liczba);
                }
            }
            return wynik;
        }
    }
}