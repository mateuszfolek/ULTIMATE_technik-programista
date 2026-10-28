/*
 * Napisz metodę PrzesunWLewo, która przesuwa elementy listy o 1 pozycję w lewo. Pierwszy element trafia na koniec
 * np 10,20,30,40 -> 20,30,40,10
 * 
 * Napisz metodę UsunParzyste, która przyjmuje stos jako inty i 
 * zwraca nowy stos zawierający tylko liczby nieparzyste zachowując ich kolejność
 */

namespace Zadanie5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> dane = new List<int>() { 10, 20, 30, 40 };

            List<int> wynik = PrzesunWLewo(dane);
            Console.Write(string.Join(",", wynik));
            Console.WriteLine();
            Console.WriteLine("-----------------");


            Stack <int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);

            Stack<int> wynik2 = UsunParzyste(stack);

            Console.Write(string.Join(",", wynik2));

        }

        public static List<int> PrzesunWLewo(List<int> dane)
        {
            List<int> wynik = new List<int>(dane);

            wynik.RemoveAt(0);
            wynik.Add(dane[0]);

            return wynik;
        }

        public static Stack <int> UsunParzyste (Stack<int> stack)
        {
            Stack<int> wynik2 = new Stack<int>();

            Stack<int> wynik3 = new Stack<int>();
            foreach (int liczba in stack)
            {
                if(liczba % 2 != 0)
                {
                    wynik2.Push(liczba);
                }
            }

            foreach (int liczba in wynik2)
            {
                wynik3.Push(liczba);
            }

            return wynik3;
        }
    }
}