using System.Diagnostics;

namespace SumaElementow
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Program program = new Program();
            suma();
            srednia();
        }

        public static void suma()
        {
            //Jest to algorytm o złożoności w notacji 0(n)
            //etap1
            int[] tablica = { 4, 7, 2, 5 };
            int suma = 0;
            //etap2
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            //etap3
            Console.WriteLine(suma);
        }

        public static void srednia()
        {
            //Jest to algorytm o złożoności w notacji 0(n)
            //etap1
            int[] tablica = { 4, 7, 2, 5 };
            int suma = 0;
            //etap2
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            //etap3
            Console.WriteLine("Średnia: " + suma/tablica.Length);
        }
    }
}