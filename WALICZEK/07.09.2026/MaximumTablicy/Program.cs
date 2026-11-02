namespace MaximumTablicy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 11, 7 };
            int max = tablica[0];

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}