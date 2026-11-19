namespace Zadanie2
{
    //Analiza tekstu i zapis statystyk do pliku

    /* Program pobiera tekst,
     * oblicza liczbę znaków, liter, cyfr, spacji, i samogłosek
     * Utwórz publiczą statyczną metodę
     * AnalizujTekst(string tekst).
     * Wynik zapisz do pliku statystyki.txt
     * Przygotuj testy dla zwykłego zdania,
     * pustego napisu,
     * oraz tekstu zawierającego litery, cyfry i znaki specjalne
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine() ?? "";
            int[] s = AnalizujTekst(tekst);

            string raport = $"Tekst: {tekst}\n Znaki: {s[0]}\n Litery: {s[1]}\n" +
                $"Cyfry: {s[2]}\n Spacje: {s[3]}\n Samogłoski: {s[4]}";

            Console.WriteLine(raport);

            File.WriteAllText("statystyki.txt", raport);
        }

        public static int[] AnalizujTekst(string tekst)
        {
            tekst ??= "";
            int litery = 0, cyfry = 0, spacje = 0, samogloski = 0;
            string sam = "aeiouyąęóAEIOUYĄĘÓ";
            foreach (char c in tekst)
            {
                if (char.IsLetter(c)) litery++;
                if (char.IsDigit(c)) cyfry++;
                if (char.IsWhiteSpace(c)) spacje++;
                if (sam.Contains(c)) samogloski++;
            }

            return new[] { tekst.Length, litery, cyfry, spacje, samogloski };

        }
    }
}