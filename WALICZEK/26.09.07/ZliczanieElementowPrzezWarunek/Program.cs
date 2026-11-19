namespace ZliczanieElementowPrzezWarunek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 2, 7, 4, 9, 5, 5 };
            int licznik = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % 2 == 0)
                {
                    licznik++;
                }
            }
            Console.WriteLine(licznik);
        }
    }
}