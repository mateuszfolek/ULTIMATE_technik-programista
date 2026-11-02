namespace WyszukiwanieLiniowe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = { 8, 3, 12, 5, 9 };
            int szukana = 12;
            int index = -1;

            for(int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == szukana)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}