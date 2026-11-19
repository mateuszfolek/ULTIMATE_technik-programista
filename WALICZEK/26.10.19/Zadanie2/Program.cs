/* FILO
 * Napisz metodę CofnijOperację, która przyjmuje Stack<string>
 * oraz liczbę operacji do cofnięcia.
 * Metoda zwraca nowy stos bez wskazanej liczby ostatnich operacji.
 * Orginlany stos pozostaje bez zmian.
 */

namespace Zadanie2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static Stack<string> CofnijOperacje(Stack <string> historia, int ile)
        { 
                Stack <string> wynik = new Stack<string>(historia.Reverse());

            for (int i = 0; i < ile && wynik.Count > 0; i++)
            {
                wynik.Pop();
            }
            return wynik;
        }
    }
}