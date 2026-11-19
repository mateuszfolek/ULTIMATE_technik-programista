/*
 * Odwracanie stosu
 * Napisz metodę OdwrocStos, która przymuje Stack<int> i zwraca nowy stos z
 * odwróconą kolejnością elementów.
 * Orginalny stos pozostaje bez zmian.
 */

namespace Zadanie4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> dane = new Stack<int>();
            dane.Push(1);
            dane.Push(2);
            dane.Push(3);
            dane.Push(4);
            dane.Push(5);
            dane.Push(6);

            Stack<int> wynik = OdwrocStos(dane);

            Console.Write(string.Join(",", wynik));

        }

        public static Stack<int> OdwrocStos(Stack<int> dane)
        {
            Stack <int> wynik = new Stack<int>();   
            foreach ( int liczba in dane)
            {
                wynik.Push(liczba);
            }

            return wynik;
        }
    }
}